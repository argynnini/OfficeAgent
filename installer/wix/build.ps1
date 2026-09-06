# MSAgentランタイムとOfficeAgentアドイン(Word/Excel/PowerPoint)を統合した
# OfficeAgentSetup.exe をビルドするスクリプト。
# 初回は WiX Toolset (dotnet global tool) と必要な拡張の導入も行う。
#
# 使い方: installer\wix フォルダで実行するか、PowerShellの作業ディレクトリを問わず
#         このスクリプト自身の場所を基準にパスを解決する。

$ErrorActionPreference = "Stop"
$scriptDir = Split-Path -Parent $MyInvocation.MyCommand.Path
Set-Location $scriptDir

function Ensure-Wix {
    $wix = Get-Command wix -ErrorAction SilentlyContinue
    if (-not $wix) {
        Write-Host "WiX Toolset (dotnet tool) をインストールします..."
        dotnet tool install --global wix
    }
    # WiX v7以降はOSMF EULAの同意が必要（年間売上$10,000超の組織のみ有償、個人利用は無償）。
    # https://wixtoolset.org/osmf/
    wix eula accept wix7 | Out-Null

    $extensions = wix extension list -g
    if ($extensions -notmatch "WixToolset.Util.wixext") {
        wix extension add -g WixToolset.Util.wixext
    }
    if ($extensions -notmatch "WixToolset.BootstrapperApplications.wixext") {
        wix extension add -g WixToolset.BootstrapperApplications.wixext
    }
}

function Regenerate-RegistryFragments {
    Write-Host "MSAgent_x64.reg / MSAgent_x86.reg からWiXレジストリ断片を再生成します..."
    New-Item -ItemType Directory -Force -Path "generated" | Out-Null
    python3 reg_to_wix.py "vendor/MSAgent/x64/MSAgent_x64.reg" "generated/MSAgentRegistry.x64.wxs" "MSAgentRegistry_x64" "x64.reg"
    python3 reg_to_wix.py "vendor/MSAgent/x86/MSAgent_x86.reg" "generated/MSAgentRegistry.x86.wxs" "MSAgentRegistry_x86" "x86.reg"
}

function Get-MSBuildExe {
    # VSTOプロジェクト(ResolveComReference/Microsoft.VisualStudio.Tools.Office.targets)は
    # .NET Core版MSBuild(dotnet build)ではビルドできないため、Visual Studio付属の
    # .NET Framework版MSBuild.exeをvswhereで探して使う
    $vswhere = "${env:ProgramFiles(x86)}\Microsoft Visual Studio\Installer\vswhere.exe"
    $vsPath = & $vswhere -latest -products * -requires Microsoft.Component.MSBuild -property installationPath
    if (-not $vsPath) { throw "Visual StudioのMSBuildが見つかりませんでした" }
    return Join-Path $vsPath "MSBuild\Current\Bin\MSBuild.exe"
}

function Build-Setup {
    Write-Host "OfficeAgentSetup.exe（MSAgentランタイム＋OfficeAgentアドイン統合インストーラ）をビルドします..."
    # OfficeAgentSetup.wixproj -> (MSAgentRuntime.wixproj, OfficeAgentAddins.wixproj)
    #   -> OfficeAgentAddins.wixproj -> Word/Excel/PowerPoint AddInのvbproj (ReferenceOutputAssembly=false、
    #      ビルド順序を強制するためだけの参照)
    # というProjectReferenceの連鎖により、1回のMSBuild呼び出しで正しい順序
    # （VBアドイン→ハーベスト→統合）に自動的にビルドされる。
    # VSTOプロジェクト（ResolveComReference等）は.NET Core版MSBuild(dotnet build)では
    # ビルドできないため、Visual Studio付属の.NET Framework版MSBuild.exeを使う。
    # /t:Rebuildにしているのは、WiX側の「差分なし」判定がsrc\*\bin\Releaseの中身の
    # 変化を追跡できず、古い内容の.msiを使い回すことがある（実際に踏んだ不具合）ため。
    $msbuild = Get-MSBuildExe
    & $msbuild OfficeAgentSetup.Proj\OfficeAgentSetup.wixproj /t:Restore`;Rebuild /p:Configuration=Release /nologo /v:minimal
    if ($LASTEXITCODE -ne 0) { throw "統合インストーラのビルドに失敗しました" }

    Write-Host "ICE検証中..."
    wix msi validate ../MSAgentRuntime.msi
    if ($LASTEXITCODE -ne 0) { throw "MSAgentRuntime.msiのICE検証に失敗しました" }
    wix msi validate ../OfficeAgentAddins.msi
    if ($LASTEXITCODE -ne 0) { throw "OfficeAgentAddins.msiのICE検証に失敗しました" }

    Write-Host "完了: installer\OfficeAgentSetup.exe （MSAgentランタイム＋Word/Excel/PowerPointアドインを1本でインストール可能）"
    Write-Host "注意: 実際のインストール/アンインストール確認は、必ず使い捨てのVM等クリーンな環境で行うこと。"
    Write-Host "      （HKCRへのCOM登録やC:\Windows\MSAgent[64]へのファイル配置、Officeレジストリ変更を伴うため）"
}

Ensure-Wix
Regenerate-RegistryFragments
Build-Setup
