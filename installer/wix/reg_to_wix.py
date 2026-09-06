#!/usr/bin/env python3
"""
installer\\vendor\\MSAgent\\x86|x64\\MSAgent_x86|x64.reg を WiX v5 の
<RegistryKey>/<RegistryValue> 断片(.wxs)に機械的に書き起こすビルド用スクリプト。

対象の.regは REG_SZ (プレーン文字列) と REG_EXPAND_SZ (hex(2)) の2種類しか
使っていないことを確認済み（DWORD/バイナリ/複数行文字列は無し）。

使い方:
    python reg_to_wix.py <input.reg> <output.wxs> <ComponentGroupId> <fileref>

  fileref: 生成する各Componentの重複防止のため、GUID生成のシード文字列に使う
           (x64.reg用/x86.reg用で別の値を渡し、同じキーパスでもGUIDが衝突しないようにする)
"""
import re
import sys
import uuid
import html

HIVE_MAP = {
    "HKEY_CLASSES_ROOT": "HKCR",
    "HKEY_CURRENT_USER": "HKCU",
    "HKEY_LOCAL_MACHINE": "HKLM",
    "HKEY_USERS": "HKU",
}

# .reg固有のGUID名前空間（このプロジェクト内で再生成しても安定するように固定値にする）
GUID_NAMESPACE = uuid.UUID("6f2a9b0e-6b8b-4e26-9b8a-2f6a2f6a2f6a")


def unescape_reg_string(s: str) -> str:
    """.reg のダブルクォート文字列（前後の"を除いた中身）をアンエスケープする"""
    return s.replace('\\\\', '\\').replace('\\"', '"')


def decode_hex2(hexbody: str) -> str:
    """hex(2):xx,xx,... (REG_EXPAND_SZ, UTF-16LE, NUL終端) をデコードする"""
    parts = [p.strip() for p in hexbody.split(",") if p.strip() != ""]
    raw = bytes(int(p, 16) for p in parts)
    text = raw.decode("utf-16-le", errors="strict")
    return text.rstrip("\x00")


def parse_reg_file(path: str):
    """.reg を読み、[(hive, keypath, [(name_or_None, type, value), ...]), ...] を返す"""
    with open(path, "r", encoding="utf-8") as f:
        raw_lines = f.readlines()

    # 継続行（末尾が \ で終わる行）を1つの論理行に結合する
    logical_lines = []
    buf = ""
    for line in raw_lines:
        line = line.rstrip("\r\n")
        if buf:
            buf += line.lstrip()
        else:
            buf = line
        if buf.endswith("\\"):
            buf = buf[:-1]
            continue
        logical_lines.append(buf)
        buf = ""
    if buf:
        logical_lines.append(buf)

    # 同じ(hive, keypath)のセクションが.reg内に複数回登場することがある
    # （元の.regに実在する重複。内容は同一 or 追加分なので、値をマージして
    # 　1つのComponentにまとめる。そのまま素通しするとComponent Id/Guidが衝突する）
    sections = []
    section_index = {}
    current = None
    section_re = re.compile(r"^\[(HKEY_[A-Z_]+)\\(.*)\]$")
    value_re = re.compile(r'^(@|"(?:[^"\\]|\\.)*")=(.*)$')

    for line in logical_lines:
        if not line.strip():
            continue
        if line.startswith("Windows Registry Editor"):
            continue
        m = section_re.match(line)
        if m:
            hive, keypath = m.group(1), m.group(2)
            key = (hive, keypath)
            if key in section_index:
                current = section_index[key]
            else:
                current = (hive, keypath, [])
                section_index[key] = current
                sections.append(current)
            continue
        m = value_re.match(line)
        if m and current is not None:
            name_raw, value_raw = m.group(1), m.group(2)
            name = None if name_raw == "@" else unescape_reg_string(name_raw[1:-1])
            existing_names = [n for n, _, _ in current[2]]
            if name in existing_names:
                continue  # 同名の値は既存のものを優先し、重複追加しない
            if value_raw.startswith('"') and value_raw.endswith('"'):
                current[2].append((name, "string", unescape_reg_string(value_raw[1:-1])))
            elif value_raw.startswith("hex(2):"):
                current[2].append((name, "expandable", decode_hex2(value_raw[len("hex(2):"):])))
            else:
                raise ValueError(f"未対応の値形式: {value_raw!r} (key={current[1]!r})")
    return sections


def stable_guid(seed: str) -> str:
    return str(uuid.uuid5(GUID_NAMESPACE, seed)).upper()


def stable_id(prefix: str, seed: str) -> str:
    import hashlib
    h = hashlib.md5(seed.encode("utf-8")).hexdigest()[:16]
    return f"{prefix}_{h}"


def xml_escape(s: str) -> str:
    return html.escape(s, quote=True)


def generate_wxs(sections, group_id: str, fileref: str) -> str:
    out = []
    out.append('<?xml version="1.0" encoding="utf-8"?>')
    out.append(f'<!-- 自動生成: reg_to_wix.py で {fileref} から書き起こし。手編集しないこと -->')
    out.append('<Wix xmlns="http://wixtoolset.org/schemas/v4/wxs">')
    out.append('  <Fragment>')
    # Directory="WindowsFolder": レジストリのみのComponentは実ファイルを持たないため
    # 本来どこでも良いが、per-user/per-machineの判定(ICE57)を素直に通すために
    # パッケージのビット幅に自動追従する標準ディレクトリを使う
    out.append(f'    <ComponentGroup Id="{group_id}" Directory="WindowsFolder">')

    for hive, keypath, values in sections:
        root = HIVE_MAP[hive]
        comp_id = stable_id("Reg", f"{fileref}|{root}|{keypath}")
        guid = stable_guid(f"{fileref}|{root}|{keypath}")
        out.append(f'      <Component Id="{comp_id}" Guid="{guid}">')
        if not values:
            # 値が1つも無い（キー自体の存在だけを主張する）セクション。
            # ForceCreateOnInstallだけだとComponentにKeyPathが無く、囲うDirectoryの
            # per-machine/per-user種別とRoot(HKCU等)の食い違いでICE57に引っかかるため、
            # 同じRoot配下に空の既定値を1つ持たせてそれをKeyPathにする
            out.append(f'        <RegistryKey Root="{root}" Key="{xml_escape(keypath)}">')
            out.append('          <RegistryValue Type="string" Value="" KeyPath="yes" />')
            out.append('        </RegistryKey>')
        else:
            out.append(f'        <RegistryKey Root="{root}" Key="{xml_escape(keypath)}">')
            first = True
            for name, vtype, value in values:
                name_attr = f' Name="{xml_escape(name)}"' if name is not None else ""
                keypath_attr = ' KeyPath="yes"' if first else ""
                first = False
                out.append(f'          <RegistryValue{name_attr} Type="{vtype}" Value="{xml_escape(value)}"{keypath_attr} />')
            out.append('        </RegistryKey>')
        out.append('      </Component>')

    out.append('    </ComponentGroup>')
    out.append('  </Fragment>')
    out.append('</Wix>')
    return "\n".join(out) + "\n"


def main():
    if len(sys.argv) != 5:
        print(f"usage: {sys.argv[0]} <input.reg> <output.wxs> <ComponentGroupId> <fileref>", file=sys.stderr)
        sys.exit(1)
    in_path, out_path, group_id, fileref = sys.argv[1:5]
    sections = parse_reg_file(in_path)
    wxs = generate_wxs(sections, group_id, fileref)
    with open(out_path, "w", encoding="utf-8") as f:
        f.write(wxs)
    print(f"{in_path}: {len(sections)} キー -> {out_path} ({group_id})")


if __name__ == "__main__":
    main()
