# 引き継ぎ資料: ずんだもん(VOICEVOX)音声対応・調査状況

作成日: 2026-09-08
対象読者: このセッションを引き継ぐ次のセッション(自分自身 or 別セッション)

## 何をしていたか(全体像)

OfficeAgent(PowerPointのスピーカーノート読み上げ機能)で、Windows標準の音声ではなく
**VOICEVOXの「ずんだもん」に喋らせたい**という要望から始まった。

VOICEVOXをSAPI5音声として登録するブリッジツール
**[SAPIForVOICEVOX](https://github.com/shigobu/SAPIForVOICEVOX)** を使うルートを選択。
実際に使ってみたところ、Microsoft Agent(超レガシーなSAPI呼び出し方をする)との組み合わせで
複数の不具合が見つかり、SAPIForVOICEVOX本体のソースを直接修正して対応中。

**本家にPRは出さない方針。** `argynnini/SAPIForVOICEVOX` に自分でフォークして開発している。

## リポジトリ・ブランチの状態

### `D:\git\OfficeAgent`(このプロジェクト本体)
- ブランチ: `3.1`
- 未コミットの変更あり(下記「OfficeAgent側の未コミット変更」参照)
- `docs/MicrosoftAgent/` 配下にMicrosoft Agent公式ドキュメント(日本語版・英語版)をオフライン保存済み(コミット済み)

### `D:\git\SAPIForVOICEVOX`(SAPIForVOICEVOXのクローン、フォーク済み)
- `origin` = `https://github.com/argynnini/SAPIForVOICEVOX.git`(自分のフォーク)
- `upstream` = `https://github.com/shigobu/SAPIForVOICEVOX.git`(本家)
- ブランチ: `msagent-compat`
- コミット済み: `bad7a25`(下記「確定して直った不具合」の内容、pushmit済み)
- **未コミットの変更あり**(下記「SAPIForVOICEVOX側の未コミット変更」参照。今まさに動作確認待ちの状態)

## 実機の状態(このマシン固有の情報)

- Officeは**64bit版**がインストールされている
- Microsoft Agent本体(`agentsvr.exe`)は `C:\WINDOWS\MSAgent64\agentsvr.exe` にある、**本物の64bitバイナリ**
  (バージョンリソースは "Copyright Microsoft Corp 1997-98" のままだが、コミュニティによる64bit移植版と思われる)
- SAPIForVOICEVOXは **64bit版** が `C:\SAPIForVOICEVOX64\` にインストール済み
  (レジストリ `HKLM\SOFTWARE\Classes\CLSID\{7a1bb9c4-df39-4e01-a8dc-20dc1a0c03c6}` 経由でCOM登録)
- ずんだもん(ノーマル、SpeakerNumber=3)がSAPIトークン `VOICEVOX000` として登録済み
- VOICEVOX本体(ポート50021)を起動しておく必要がある(プロセス名 `run.exe`)
- デバッグ用コンソール `SFVvConsole.exe` も `C:\SAPIForVOICEVOX64\` に配置済み。
  起動しておくと、SAPIForVOICEVOXが処理中のテキストや診断ログを覗ける
  (`%TEMP%\SFVvConsole_log.txt` にもファイル保存されるようにした)

## 確定して直った不具合(コミット済み: `bad7a25`)

Microsoft Agent経由でずんだもんに喋らせると、**「2147483646」のような無関係な数値が
読み上げに混入する**という不具合があった。原因は`VoiceVoxTTSEngine.cs`の`Speak()`が、
SAPIの`SPVTEXTFRAG`リストに含まれる**ブックマークや無音区間などの制御用フラグメント
(eAction)も無条件で読み上げ対象として処理していた**ため。以下を修正した:

1. `eAction`が`SPVA_Speak`/`SPVA_Pronounce`/`SPVA_SpellOut`以外は読み上げをスキップ
2. `SPVA_Bookmark`は`SPEI_TTS_BOOKMARK`イベントとして呼び出し元に通知(`FireBookmarkEvent`)
3. `SPVA_Silence`は実際に指定時間の無音PCMを出力(`WriteSilence`)
4. 単語/文境界イベント(`SPEI_WORD_BOUNDARY`/`SPEI_SENTENCE_BOUNDARY`)の文字位置(lParam)が、
   fragment内だけのローカル位置になっていたバグを修正。`SPVTEXTFRAG.ulTextSrcOffset`を
   使って発話全体を通したグローバル位置を正しく計算するようにした
5. `SPEI_START_INPUT_STREAM`/`SPEI_END_INPUT_STREAM`が要求されているのに一度も
   発火されていなかったので追加(`FireStreamBoundaryEvent`、finallyで確実に発火)
6. `SPEI_VOICE_CHANGE`も同様に未発火だったため追加(`FireVoiceChangeEvent`、Tokenを使用)

**この状態で、ずんだもんは正しい内容を音声で読み上げられることを実機で確認済み。**

## 未解決の不具合: auto-pace有効時に吹き出しが空白のまま

`Balloon.Style`の`auto-pace`ビット(文字を発話に合わせて少しずつ表示する機能)を
有効にすると、**音声は正しく再生されるのに、吹き出しの枠だけ出て中身が空白のまま**
になる。全部話し終わっても空白のまま。

### 重要な比較実験の結果

- **カイル(Think()、外部エンジンなし)**: auto-pace有効でも吹き出しは正常に表示される
- **ずんだもん(VOICEVOX/SAPIForVOICEVOX経由、Speak())**: 吹き出しが空白のまま

→ **VOICEVOX/SAPIForVOICEVOX特有の問題**と確定している。Microsoft Agent側や
OfficeAgent側の設定の問題ではない。

### 試して効果が無かったこと

- Bookmark/Silence/StartStream/EndStream/VoiceChangeの実装(上記の確定修正。音声は直ったが吹き出しには効果なし)
- `EventInterest`の確認 → `0x000000024000FFFF`
  (Bookmark/Word/Sentence/Phoneme/Viseme/AudioLevel/StartStream/EndStream/VoiceChange全て`True`で要求されている)
- `Phoneme`/`Viseme`/`AudioLevel`イベントをダミー値で1回ずつ発火 → 効果なし
- `ISpTTSEngineSSML`インターフェースをスタブ実装して呼ばれるか確認 →
  **呼ばれていない**ことを確認(Microsoft Agentはこのインターフェースを使っていない)
- `Balloon.Style`から`size-to-text`を外し、代わりに固定`CharsPerLine`/`NumberOfLines`を
  指定(auto-paceとsize-to-textは概念的に矛盾するのでは、という仮説) → 効果なし
  (**この変更は今もOfficeAgent側に残っている**。下記参照)

### 重大な副作用の発見: TTS処理が失敗すると吹き出しだけ表示される

`.TTSModeID`に無効な値(`"TTS_MS_JA-JP_HARUKA_11.0"`という、恐らく形式が違う値)を
設定してテストしたところ、**音声は一切出なくなったが、なぜか吹き出しには文字が
表示された**。ログも一切出なかった(エンジンが呼ばれていない)。

同様に、`GetOutputFormat`メソッドに(内容を問わず)何かコードを追加すると、
**毎回**同じように「発声しなくなるが吹き出しは正常に表示される」という結果になった
(3回、異なる方法で再現: パイプ経由ログ、ファイル経由ログ、unsafeブロック外での
初回のみファイルログ、いずれも同じ症状)。

**仮説**: Microsoft Agentには「TTSが正常に機能した時の同期表示ルート(何かが壊れていて
吹き出しが出ない)」と「TTSが失敗した時のフォールバック表示ルート(なぜか正常に
文字が出る)」の2系統があるのではないか。

**教訓: `GetOutputFormat`には絶対に手を加えないこと。** 何を足しても壊れる
(原因不明、恐らくこのメソッドが呼ばれるタイミング・頻度・スレッドコンテキストが
特殊で、ちょっとした処理の追加がタイムアウト等を引き起こしている)。

### 音声フォーマット情報は`Speak()`側から安全に取得可能

`GetOutputFormat`を直接触らなくても、`Speak()`の引数`pWaveFormatEx`に
**最終的に確定した音声フォーマット**が入っている。これなら安全(`Speak()`は
何度も触って実績がある)。実際に追加してみたところ、正常に動作しログも出た:

```
WaveFormat=24000Hz/16bit/1ch
```

ただしこれは、私たちのエンジンの**デフォルト値と一致している**ため、
「Microsoft Agentが本当に24000Hzを要求したのか」「別の値(22050Hz等、1997-98年当時
主流だった低いレート)を要求したのに範囲外としてデフォルトに丸められたのか」を
区別できない。

## SAPIForVOICEVOX側の未コミットの変更(今ここ)

`D:\git\SAPIForVOICEVOX` の作業ツリーに以下の未コミット変更がある(ビルド・
`C:\SAPIForVOICEVOX64\`への反映済み、**まだ実機での動作確認結果を受け取れていない**):

1. **`VoiceVoxTTSEngine.cs`の`Speak()`**: `EventInterest`ログに`WaveFormat`と
   `rguidFormatId`を追記(安全な場所からの音声フォーマット取得)
2. **`VoiceVoxTTSEngine.cs`の`GetOutputFormat()`**: サンプリングレートの受け入れ範囲を
   `24000〜192000Hz` から **`8000〜192000Hz`** に拡張
   (Microsoft Agentが低いレートを要求していた場合、それを尊重するように)
3. **`SFVvConsole/Program.cs`**: 受信したログを`%TEMP%\SFVvConsole_log.txt`にも
   保存するように変更(コンソールの見落とし防止)

### 次にやるべきこと

1. Officeを完全に再起動(WINWORD/EXCEL/POWERPNTを全て終了)してから、
   カイルの設定を開くか、起動時のテスト発話(下記OfficeAgent側参照)で
   ずんだもんに喋らせる
2. `WaveFormat=`のログを確認する(`%TEMP%\SFVvConsole_log.txt` またはSFVvConsoleの
   コンソール画面)。**前回と違う値(例えば22050Hz)が出れば「サンプリングレートの
   ミスマッチ」説が濃厚**
3. 吹き出しに文字が出るようになったか確認する
4. 直っていなければ、この変更(サンプリングレート拡張)にも効果が無かったことになる。
   `git checkout -- SAPIForVOICEVOX/VoiceVoxTTSEngine.cs` で確定済みの状態
   (`bad7a25`)に戻すこと

## DLL差し替え手順(実機作業の再現用)

```powershell
# 1. ビルド(D:\git\SAPIForVOICEVOXで)
& "C:\Program Files\Microsoft Visual Studio\18\Community\MSBuild\Current\Bin\MSBuild.exe" `
  "D:\git\SAPIForVOICEVOX\SAPIForVOICEVOX.sln" /t:SAPIForVOICEVOX `
  /p:Configuration=Release /p:Platform=x64 /p:TargetFrameworkVersion=v4.8 /v:minimal /nologo

# 2. agentsvr.exeを終了（DLLロック解除のため）
Stop-Process -Name agentsvr -Force -ErrorAction SilentlyContinue

# 3. 差し替え（ロック中でもrenameは通ることが多いので、rename→削除→コピーの手順を使う）
cd C:\SAPIForVOICEVOX64
mv SAPIForVOICEVOX.dll SAPIForVOICEVOX.dll.old
rm -f SAPIForVOICEVOX.dll.old
cp D:\git\SAPIForVOICEVOX\SAPIForVOICEVOX\bin\x64\Release\SAPIForVOICEVOX.dll .

# 4. Officeを完全に再起動してから動作確認する
```

**注意**: `GetOutputFormat`をいじった場合、agentsvr.exeを殺すだけでは不十分で、
**Office自体(Word/Excel/PowerPoint)を完全に終了して再起動する**必要があった
ケースが複数回あった(内部状態が壊れたまま残っている可能性)。

## OfficeAgent側の未コミットの変更

`D:\git\OfficeAgent`(ブランチ`3.1`)にも未コミットの変更がある:

### `AgentFloatingForm.vb`
- `BalloonStyleDefault`を`BalloonOn + SizeToText + AutoPace`から
  `BalloonOn + AutoPace + 固定CharsPerLine(40) + 固定NumberOfLines(4)`に変更
  (auto-paceとsize-to-textの矛盾を疑った切り分け用。**効果は無かった**ので、
  最終的には元(`BalloonOn + SizeToText + AutoPace`)に戻すか検討要)
- `InsertWordBreaks`(日本語の折り返し対策、ゼロ幅スペース挿入)を追加。
  ただし`SpeakSlideNotes`では**使わない**ようにした
  (ゼロ幅スペースがVOICEVOX側のテキスト解析を壊す不具合があったため)。
  `SpeakOrThink`(常に無音)側では引き続き使用
- `SpeakSlideNotes`メソッド追加: スライドノート読み上げ専用、実際に`.Speak()`で
  音声を出す(`SpeakOrThink`は音声を出さない設計のため専用メソッドが必要だった)
- `StopSpeaking`メソッド追加: 読み上げの即時打ち切り用
- **暫定テストコード**: `AgentFloatingForm_Load`内、`ShowOnStartup`が有効な時に
  起動時に自動でテスト用の文章を喋らせるコードが入っている
  (`TODO(暫定・検証用)`とコメントあり)。**原因究明が終わったら削除すること**

### その他のファイル(`AgentRibbon.vb`, `AgentSettings.vb`, `RibbonUI.xml`, `ThisAddIn.vb`)
- PowerPointの「スライド ショー」リボンに「スピーカーノート読み上げ」チェックボックスと
  「読み上げ音声の設定」ボタン(`sapi.cpl`を開く)を追加
- `AgentSettings.SpeakSlideNotesDuringSlideShow`設定を追加
- PowerPoint側`ThisAddIn.vb`: スライド切り替え時にノートを読み上げる処理、
  同じスライドへの重複呼び出しガード(`_lastSpokenSlideNotesIndex`)を追加

### 未追跡ファイル
- `agents/FINFIN.ACS` — 以前の別作業で復元したファイル。コミット未実施

## 次のセッションで最初にやること

1. `D:\git\SAPIForVOICEVOX`で`git status`を見て、上記「サンプリングレート拡張」の
   実機確認結果がまだなら、Officeを再起動して確認する
2. 効果が無ければ`git checkout -- SAPIForVOICEVOX/VoiceVoxTTSEngine.cs`で
   `bad7a25`の状態に戻し、別の切り口を検討する
   (例: SFVvConsoleを使わず、Sysinternals Process Monitor等の外部ツールで
   `agentsvr.exe`が実際に呼んでいるCOMメソッド・パラメータを観測する、等)
3. 一区切りついたら、`D:\git\SAPIForVOICEVOX`の変更を`msagent-compat`ブランチに
   コミット・push(`git push origin msagent-compat`)
4. `D:\git\OfficeAgent`側も、暫定テストコード(起動時の自動発話)を削除し、
   `BalloonStyleDefault`をどちらの形にするか確定させてからコミットする
