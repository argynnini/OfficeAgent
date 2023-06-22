# OfficeAgent
最新の Office 環境に カイル君 を復活させるプロジェクト

![](https://github.com/argynnini/OfficeAgent/assets/88919409/80188b9f-33b5-4bfb-91b4-70326f58bb7d)


賢くなったカイル君とお話ししよう！！

ChatGPT の力を経て質問になんでも答えられます．
![](https://github.com/argynnini/OfficeAgent/assets/88919409/f9758942-41df-48f2-adf3-61a88ffdb4ba)

# 使い方

## 起動
カイル君を起動するとバックグラウンドで常駐し，Word，Excel，PowerPoint などのOfficeソフトが起動すると姿を現してくれます．

終了すると姿を消します．

## 検索
カイル君をクリックすると吹き出しが表示されます．

### Chat GPT
吹き出しに入力して「検索」を押すと，カイル君が一生懸命考えて答えを出してくれます．

![](https://user-images.githubusercontent.com/88919409/157601288-e0f37334-2096-4d91-850e-c50ebc8ab983.png)
![](https://user-images.githubusercontent.com/88919409/157601800-533733f4-6e5e-46b9-a15a-85387cb01637.png)
![](https://github.com/argynnini/OfficeAgent/assets/88919409/cc98eb84-cb5a-401c-9f97-2c58e666b3da)

出した答えはカイル君をマウスのホイールでクリックするとクリップボードにコピーしてくれます．

### ウェブ検索
カイル君を右クリックして出てくるオプションから，検索方法をWeb検索に変えることもできます．

![](https://user-images.githubusercontent.com/88919409/157601800-533733f4-6e5e-46b9-a15a-85387cb01637.png)
![](https://user-images.githubusercontent.com/88919409/157601803-c431ebe2-08da-42cf-96c6-c9e07c44569d.png)

## アニメーション

検索時はもちろん，右クリックメニューから好きなアニメーションをさせることが出来ます．

![](https://github.com/argynnini/OfficeAgent/assets/88919409/cb384fdb-5e3f-4495-98fb-8e44208a9dd5)

# 動作環境
 
* Microsoft Windows 10 以降
* Microsoft .NET Framework 4.8

# 注意

LinuxやMacでの動作確認はしていません．

Chat GPT を利用するには，OpenAIから API キーを入手する必要があります．（無料）

## インストール方法

カイル君を動かすには，Microsoft Agent コンポーネントが必要です．

Microsoft が配布しているMicrosoft Agent コンポーネントは，最新の Windows では動きません．

そこで， MSAgent_Installer.zip にインストーラと最新の Windows でも動く修正パッチをまとめたインストーラを作成しました．

① MSAgent_Installer.zip をダウンロードして展開します．

② MSAgent_Installer.zip を展開した中にある install.bat を管理者として実行します．

③ OfficeAgent2.1.0.exe をダウンロードして実行します．

④ Word， Excel， PowerPoint などの Office 製品を起動します．

⑤ 出現したカイル君を右クリックして，設定を開きます．

⑥ OpenAI API Key に OpenAI の API キーを入力します．

⑦ Chat GPT で検索できるようになります．

## OpenAI API キー
OpenAI の API キーは以下の リンク から取得できます．

[OpenAI API](https://openai.com/blog/openai-api)

## 自動起動方法

PC の起動時に自動起動させるには，スタートアップフォルダに OfficeAgent2.1.0.exe を置きます．

C:\Users\Username\AppData\Roaming\Microsoft\Windows\Start Menu\Programs\Startup\

## 動かないときは．．．

### 起動時に「An application is attempting to load a Microsoft Agent character from an untrusted Web site.」と出る場合

![タイトルなし](https://github.com/argynnini/OfficeAgent/assets/88919409/79fedcbd-98a0-433f-b577-38651708032d)

C:\Windows\msagent\chars\ フォルダの中にある 「DOLPHIN.ACS」を右クリックしてプロパティを開きます．

全般タブの中のセキュリティの「許可する」にチェックを入れてOKを押します．

![](https://github.com/argynnini/OfficeAgent/assets/88919409/2a3fbdc2-f8ca-42f6-a9ef-18ae70e7d6a8)

エラーが出た場合は「再試行」をクリックして「許可」をクリックします．

# License
 
"Ofice Agent" は [MIT ライセンス](https://en.wikipedia.org/wiki/MIT_License) です．
