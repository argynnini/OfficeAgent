# OfficeAgent
最新の Office 環境に カイル君 を復活させるプロジェクト

![](https://github.com/argynnini/OfficeAgent/assets/88919409/80188b9f-33b5-4bfb-91b4-70326f58bb7d)


賢くなったカイル君とお話ししよう！！

ChatGPT や Groq の力を経て質問になんでも答えられます．

OfficeAgent は Word，Excel，PowerPoint の VSTO アドインとして動作します．

# 使い方

## 起動
インストールしておけば，各 Office ソフトを起動するだけでカイル君が自動的に姿を現してくれます．

Office ソフトを終了すると（他の Office ソフトが起動していない場合は）姿を消します．

## 検索
カイル君をクリックすると吹き出しが表示されます．

### Chat GPT / Groq / ウェブ検索
吹き出しに入力して「検索」を押すと，カイル君が一生懸命考えて答えを出してくれます．

検索方法（OpenAI GPT / Groq / ウェブ検索）は詳細設定（サイドパネル）から切り替えられます．

![](https://user-images.githubusercontent.com/88919409/157601288-e0f37334-2096-4d91-850e-c50ebc8ab983.png)
![](https://user-images.githubusercontent.com/88919409/157601800-533733f4-6e5e-46b9-a15a-85387cb01637.png)
![](https://github.com/argynnini/OfficeAgent/assets/88919409/cc98eb84-cb5a-401c-9f97-2c58e666b3da)

出した答えはカイル君をマウスのホイールでクリックするとクリップボードにコピーしてくれます．

## 選択範囲についてAIに聞く
Word / Excel / PowerPoint で文章やセルを選択した状態でカイル君を右クリックし，「選択範囲について」から次の操作を選べます．

* 要約する
* 翻訳する（日本語⇔英語）
* 解説する
* 誤字脱字をチェックする

選択中のテキストがそのまま AI に送られ，結果が吹き出しで返ってきます．検索方法として OpenAI か Groq を選んでいる場合のみ使えます．

## アニメーション

### 手動での再生
検索時はもちろん，右クリックメニューから好きなアニメーションをさせることが出来ます．

![](https://github.com/argynnini/OfficeAgent/assets/88919409/cb384fdb-5e3f-4495-98fb-8e44208a9dd5)

### 操作に連動した自動再生
カイル君は Word / Excel / PowerPoint の操作にあわせて自動でアニメーションします．対象となる操作は以下の通りです．

| 操作 | 既定 |
| --- | --- |
| 開く（Ctrl+O） | オフ |
| 閉じる（Ctrl+W） | オフ |
| 保存（Ctrl+S） | オン |
| 印刷（Ctrl+P） | オン |
| 保護ビュー表示 | オン |
| シート追加（Shift+F11，Excel のみ） | オン |
| スライド開始（F5，PowerPoint のみ） | オン |
| スライド終了（Esc，PowerPoint のみ） | オン |
| スライド追加（Ctrl+M，PowerPoint のみ） | オン |

それぞれの操作でオン／オフ・再生するアニメーションの種類は，詳細設定（サイドパネル）の「イベントごとのアニメーション設定」から操作ごとに変更できます．

## PowerPoint：発表時間のお知らせ
PowerPoint でスライドショーを終了すると，カイル君が発表にかかった時間を教えてくれます．

## リボンからの操作
Word / Excel / PowerPoint の「表示」タブに「OfficeAgent」グループが追加されます．

* カイル君の表示 / 終了の切り替え
* 詳細設定（サイドパネルの表示切り替え）

## 詳細設定（サイドパネル）
カイル君を右クリックして「設定」を選ぶと，その Office ソフトのサイドパネル（作業ウィンドウ）に詳細設定が表示されます．リボンの「詳細設定」ボタンからも同じパネルを開閉できます．

* 検索方法（ウェブ検索 / OpenAI GPT / Groq）・API キー・モデル名
* カイル君の性格（プロンプト）
* サウンド／起動時に表示 の切り替え
* スライドショー中は非表示にする（PowerPoint）
* 検索に選択中のテキストを含める
* 既定の検索サイト・検索サイト一覧の編集
* イベントごとのアニメーション設定

# インストール

## 動作環境
* Microsoft Windows 10 以降
* Microsoft .NET Framework 4.8.1
* Microsoft Office（Word / Excel / PowerPoint）

LinuxやMacでの動作確認はしていません．

## インストール方法
カイル君を動かすには，Microsoft Agent コンポーネントが必要です．

Microsoft が配布している Microsoft Agent コンポーネントは，最新の Windows では動きません．そこで，最新の Windows でも動く修正パッチと Word / Excel / PowerPoint 用アドインをまとめてインストールできる `OfficeAgentSetup.exe` を用意しています（`installer/wix` 以下の WiX プロジェクトからビルドされます）．

① `OfficeAgentSetup.exe` をダウンロード（または Visual Studio でソリューションをビルドして生成）します．

② `OfficeAgentSetup.exe` を管理者として実行します．Microsoft Agent コンポーネントと，Word / Excel / PowerPoint 用の OfficeAgent アドインがまとめてインストールされます．

③ Word， Excel， PowerPoint などの Office 製品を起動します．

④ 出現したカイル君を右クリックして，設定を開きます．

⑤ OpenAI API Key（または Groq API Key）を入力します．

⑥ Chat GPT や Groq で検索できるようになります．

VSTO アドインとして登録されるため，PC や Office ソフトの起動時に自動的に読み込まれます．スタートアップフォルダなどへの登録は不要です．

## API キー
OpenAI の API キーは以下の リンク から取得できます．

[OpenAI API](https://openai.com/blog/openai-api)

Groq の API キーは以下の リンク から取得できます．

[GroqCloud](https://console.groq.com/keys)

## 動かないときは．．．

### 「発行元を確認できません」という確認ダイアログが出る場合

各アドインのマニフェスト署名に自己署名のテスト証明書を使っているために表示されることがあります．`OfficeAgentSetup.exe` によるインストール時に証明書を信頼済み発行元ストアへ自動登録するため，通常はこのダイアログは出ません．

### 起動時に「An application is attempting to load a Microsoft Agent character from an untrusted Web site.」と出る場合

![タイトルなし](https://github.com/argynnini/OfficeAgent/assets/88919409/79fedcbd-98a0-433f-b577-38651708032d)

%ProgramFiles%\OfficeAgent\assets\ フォルダの中にある 「DOLPHIN.ACS」を右クリックしてプロパティを開きます．

全般タブの中のセキュリティの「許可する」にチェックを入れてOKを押します．

![](https://github.com/argynnini/OfficeAgent/assets/88919409/2a3fbdc2-f8ca-42f6-a9ef-18ae70e7d6a8)

エラーが出た場合は「再試行」をクリックして「許可」をクリックします．

# 開発者向け

## プロジェクト構成
* `src/OfficeAgent.Core` — Word / Excel / PowerPoint 共通のロジック（エージェント表示，AI チャット，設定パネル，アニメーション制御など）をまとめたクラスライブラリ
* `src/OfficeAgent.Word.AddIn` / `OfficeAgent.Excel.AddIn` / `OfficeAgent.PowerPoint.AddIn` — 各 Office アプリ向けの VSTO アドインプロジェクト（`OfficeAgent.Core` を参照）
* `installer/wix` — WiX Toolset によるインストーラー定義一式（MSAgent ランタイム / アドイン本体 / それらをまとめる Bundle）
* `assets` — MSAgent キャラクターファイル（`.ACS`）やアイコンなど，各アドインで共有するリソース

## 必要な環境
* Visual Studio 2026（「Office/SharePoint 開発」ワークロード，Visual Basic 対応）
* .NET Framework 4.8.1 Developer Pack
* 動作確認用の Word / Excel / PowerPoint

## アドインのビルド
`OfficeAgent.slnx` を Visual Studio で開いてビルドします．

## デバッグ実行の手順
1. Visual Studio でソリューションをビルドします．これにより `D:\git\OfficeAgent\installer\MSAgentRuntime.msi` が生成されます．
2. 生成された `MSAgentRuntime.msi` をインストールします．
3. インストール後，Visual Studio から実行してデバッグします．

MSAgent ランタイム（ActiveX コントロール本体）が入っていない環境ではアドインがエージェントを描画できないため，初回は必ずこの順番でランタイムを導入してからデバッグ実行してください．

## インストーラーのビルド
`OfficeAgent.slnx` には WiX のインストーラープロジェクト（`MSAgentRuntime` / `OfficeAgentAddins` / `OfficeAgentSetup`）も含まれているため，Visual Studio でビルドするだけで `OfficeAgentSetup.exe`（MSAgent ランタイム＋Word/Excel/PowerPoint アドインの統合インストーラー）まで生成されます．

実際のインストール／アンインストール動作の確認は，HKCR への COM 登録や `C:\Windows\MSAgent` 配下へのファイル配置，Office レジストリの変更を伴うため，必ずクリーンな環境で行ってください．
