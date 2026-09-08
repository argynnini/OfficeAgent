---
layout: FAQ
title: プログラミング スクリプトに関する FAQ - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/programming-scripting-faq
schema: FAQ
summary: >
  <p>[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]</p>
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/programming-scripting-faq.yml
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: プログラミング スクリプトに関する FAQ
feedback_system: Standard
git_commit_id: 6e4c19b37670af9d18f780208060b1c9bf88e0e4
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/6e4c19b37670af9d18f780208060b1c9bf88e0e4/desktop-src/lwef/programming-scripting-faq.yml
locale: ja-jp
ms.assetid: 84078c5b-7b04-48fa-9d0a-d95393c323eb
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.topic: faq
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/programming-scripting-faq.yml
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-08-20T17:22:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
page_type: faq
toc_rel: toc.json
feedback_product_url: ''
feedback_help_link_type: ''
feedback_help_link_url: ''
asset_id: lwef/programming-scripting-faq
item_type: Content
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 43353629-02ca-7a63-466b-3c6326efa76f
---

# プログラミング スクリプトに関する FAQ - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

## Microsoft エージェントのスクリプト作成に Microsoft Visual Basic (またはその他の開発ツール) を使用する場合、サンプルで使用されているすべてのプロパティとイベントは表示されません。 操作方法アクセスしますか?

Microsoft エージェント コントロールでサポートされているほとんどのイベント、メソッド、プロパティは、実行時にのみ公開されます。 詳細については、「 [Microsoft エージェント コントロールのプログラミング](programming-the-microsoft-agent-control) 」を参照してください。

## Map タグ (またはその他のタグ) は機能していないようです。

一部のタグには、引用符で囲まれた文字列が含まれています。 Microsoft Visual Basic や Visual Basic Scripting Edition などの一部のプログラミング言語では、2 つの引用符を使用してタグのパラメーターを指定するか、文字列の一部として二重引用符を連結する必要があります。 後者は、次の Visual Basic の例に示されています。

Agent1.Characters("Genie")。"This is \map=" + chr(34) + "Spoken text" \_ + chr(34) + "=" + chr(34) + "Balloon text" + chr(34) + "\"

C、C++、Java プログラミングの場合は、円記号と二重引用符の前に円記号を付けます。 次に例を示します。

BSTR bszSpeak = SysAllocString(L"This is \\map=\"Spoken text\"=\"Balloon text\"\\");

pCharacter-Speak&gt;(bszSpeak, .....);

注意

Microsoft エージェントは、Microsoft Speech API で指定されたすべてのタグをサポートしているわけではありません。 また、一部のパラメーターのサポートは、インストールされているテキスト読み上げエンジンによって異なります。 詳細については、「 [Microsoft Agent Speech 出力タグ](microsoft-agent-speech-output-tags)」を参照してください。

## スクリプト (またはプログラム) で RequestStart イベントと RequestComplete イベントが表示されないようです。

これは、次のいずれかの問題が原因で発生する可能性があります。

- プログラミング言語では、ActiveX コントロールが完全にはサポートされていません。 ドキュメントを確認して、ActiveX オブジェクトの ActiveX インターフェイスとイベントがサポートされていることを確認してください。
- スクリプト化された Web ページで、別のコントロールのインストールまたは読み込みに失敗しました。 他のすべてのコントロールがインストールされ、Microsoft エージェントなしで正しく読み込まれたことを確認します。
- フレームを含むスクリプト化された Web ページでは `<OBJECT>` 、あるページに Microsoft エージェント コントロールのタグがあり、イベントは別のページにスクリプト化されています。 イベントは、コントロールをホストするページにのみ送信されます。

## Web ページ上の他の ActiveX コントロールで Microsoft エージェント コントロールを使用しており、イベントが発生していないようです。

他のコントロールが正しくインストールされているかどうかを確認します。 別の ActiveX コントロールがそれ自体を正しく登録できない場合、Microsoft エージェント コントロールはそのイベントを受け取る可能性があります。

## Microsoft エージェント コントロールのプログラミングに使用できるプログラミング言語は何ですか?

Microsoft エージェントは、ActiveX インターフェイスをサポートする任意の言語からサポートできる必要があります。 Visual Basic、VBScript、JScript、C/C++、Java のコード サンプルが含まれています。

## JScript を使用して Microsoft エージェントから返されたパラメーターにアクセスできますか?

はい。ただし、現在、これを行う唯一の方法は 構文を `<SCRIPT LANGUAGE="JScript" FOR="*object*" EVENT="event()">` 使用する方法です。 この構文は Microsoft インターネット エクスプローラーでサポートされていますが、他のブラウザーではサポートされていないため、ページのスクリプトのこの部分で JScript を使用しないようにすることをお勧めします。

## Microsoft エージェントは、Microsoft が提供するもの以外の音声認識または音声合成 (テキスト読み上げ、または TTS) エンジンで使用できますか?

はい。Microsoft エージェントに必要な Microsoft Speech API (SAPI) 4.0 インターフェイスがエンジンでサポートされている場合。 エンジンサプライヤーに確認してください。 Microsoft エージェントで必要な SAPI インターフェイスの詳細については、「 [Speech Engine のサポート要件](speech-engine-support-requirements)」を参照してください。

## マイ ページには、Microsoft エージェント用の HTML オブジェクト タグ、Lernout & Hauspie TruVoice TTS エンジン、Microsoft Command and Control 音声認識エンジンが含まれていますが、すべてのコンポーネントがインストールされるわけではありません。

通常、ページを更新することで問題を修正できます。 一般的な方法として、最初に Microsoft Agent Control `<OBJECT>` タグ、次に Lernout & Hauspie TruVoice エンジン、次に Command and Control 音声認識エンジンを指定することをお勧めします。

## MoveTo メソッドを呼び出した後、Move 状態アニメーションに Return アニメーションが割り当てられている場合でも、キャラクターがフリーズしているように見えます。

アニメーションを再生すると、別のアニメーションが呼び出されるまで、アニメーション サービスは最後のフレームを表示し続けます。 したがって、 [**MoveTo**](moveto-method) を呼び出した後に別のアニメーションを再生する必要があります。 **移動**状態アニメーションの **Return** アニメーションを定義した場合、サーバーが最初に再生します。

## 文字の Pitch プロパティに対してクエリを実行すると、値 -1 が返されます。

これは、音声エンジンの既定のピッチ プロパティを使用して文字がコンパイルされている場合に発生します。つまり、文字の作成時にピッチが変更されませんでした。

## コードがテキスト読み上げエンジンの TTS モード ID を設定しようとすると、次のエラーが表示されます。アプリケーションが入力同期呼び出しをディスパッチしているため、発信呼び出しを行うことはできません。

TTSModeID プロパティを設定するには、Speech.dllがインストールされている必要があります。 これは通常、音声エンジンのインストール コードの一部です。 これをインストールする場合は、[Microsoft エージェントのダウンロード] ページから入手できる Speech オブジェクトコントロール パネル をインストールします。

## 読み込みに失敗した文字の読み込みを再試行すると、呼び出しは "文字が既に読み込まれています" というエラーで失敗します。

関連付けられた文字ファイルの読み込みに失敗した場合、Microsoft Agent コントロールは文字オブジェクトをアンロードしません (参照を解放します)。 文字の読み込みを再試行する場合は、Load を 2 回目 [**に呼び**](unload-method) 出す前に [**Unload を明示的**](load-method) に呼び出す必要があります。 Web ページ スクリプトからこれを試みる場合は、 **Unload** 呼び出しの前に On Error Resume Next ステートメントを指定する必要もあります。または、 **Unload** 呼び出しも失敗します。 (JScript には On Error Resume Next ステートメントがないことに注意してください)。

ただし、ファイルの読み込みに失敗したときに文字の読み込みを直ちに再試行するコードを含める必要がない場合があります。 Microsoft インターネット エクスプローラーと Microsoft エージェント サーバー コンポーネントは、再試行を複数回自動的に試行するため、再試行によって正常な読み込みが発生する可能性はリモートになります。 より良い方法は、再試行する前に数秒待つ (タイマーを設定する) 方法です。

## アプリケーションの一部として、または Web サーバーから Microsoft エージェントをインストールするにはどうすればよいですか?

*HTML オブジェクト タグに CLSID* を含めることで、Microsoft Web サイトからエージェントをインストールできます。 ただし、独自のアプリケーション インストール プログラムまたは独自のサーバーからエージェントを含め、インストールする場合は、[ダウンロード] ページからダウンロードして、Microsoft Agent のセルフインストール キャビネット ファイルをダウンロードする必要があります。 ダウンロード時に、ブラウザーの [実行] ではなく [保存] オプションを選択します。 このファイルが実行されるたびに、ターゲット コンピューターに Microsoft エージェントが自動的にインストールされます。 したがって、インストール スクリプトでファイルを指定できます。

さまざまな をコピーして Microsoft エージェントをインストールしないでください。DLL を使用して自分で登録を試みます。 他の方法でエージェントをインストールしようとしても、そのセルフインストール キャビネット ファイルの実行はサポートされていません。

ターゲット システムには、最新バージョンのMSVCRT.DLL (VC++ ランタイム)、REGSVR32.EXE (Microsoft VC++に含まれる登録ツール)、COM も含める必要があります。 正しいバージョンがインストールされていることを確認する最善の方法は、Microsoft Internet エクスプローラー 3.02 以降のインストールを要求することです。 ただし、これらのランタイム要件にライセンスを付与することもできます。 (最新バージョンの COM の場合は、Microsoft Web サイトから DCOM 更新プログラムにアクセスしてください)。

このバージョンのオペレーティング システムには既にエージェントが含まれているため、Microsoft Agent 2.0 は Microsoft Windows 2000 にインストールされません。

## Visual Basic セットアップ ウィザードを使用して Microsoft エージェントをインストールできますか?

Visual Basic (VB) コードを使用して独自のインストール プログラムを作成できますが、Visual Basic セットアップ ウィザードを使用してこれを行うことはできません。 VB からエージェントをインストールするには、シェル コマンドを使用して、Microsoft Agent のセルフインストール キャビネット ファイルを指定します。

## Windows 2000 に Microsoft エージェントをインストール操作方法

Microsoft Agent 2.0 は、オペレーティング システムの一部として既に含まれているため、Windows 2000 にはインストールされません。

## Speak が WAV ファイルで呼び出されると、AgentSvr がクラッシュします。

これにより、文字が音声出力に TTS を使用し、WAV ファイルを使用するように変更された場合に発生する可能性があります。 Speak メソッドの最初のパラメーターにテキストが指定されませんでした。

クラッシュを回避するには、テキスト出力がない場合でも、Speak メソッドの最初のパラメーターにスペース文字を含めます。

## 特定の言語のエージェント言語コンポーネント (DLL) を既にインストールしていますが、文字の言語をその言語に設定すると、コンポーネントが見つからないというエラーが発生します。

これは通常、エージェント言語コンポーネントをインストールするときに Microsoft Office 2000 などのエージェント アプリケーションを開いている場合に発生します。 すべてのアプリケーションを閉じてから、もう一度やり直してください。 問題が解決しない場合は、コンピューターを再起動すると、言語 ID を今すぐ設定できるようになります。

## アンパサンドの"&"記号を使用すると、文字の単語吹き出しの記号の周囲のテキストが切り捨てられます。

これは既知の問題です。 これを回避する方法は、マップ タグを使用します。 たとえば、文字の吹き出しに "A & B" を表示するには、Speak ステートメントで "A \map="and"="&&\B" を使用します。

## アプリケーションを使用すると、ユーザーは既定の文字を変更でき、変更するとプログラムがクラッシュします。

原因として、次の 2 つが考えられます。

既定の文字の TTS モード ID を変更し、ユーザーが ShowDefaultCharacterProperties を使用して既定の文字を変更できるようにすると、AgentSvr がクラッシュします。

この問題は、Windows 2000 および Windows XP オペレーティング システムで修正されています。 他のプラットフォームでクラッシュを回避するには、既定の文字の TTS モード ID を変更した後にユーザーが既定の文字を変更できないようにするか、アプリケーションまたは Web ページで既定の文字を使用しないようにする必要があります。

アプリケーションで Microsoft 提供のエージェント文字を使用しない場合は、カスタマイズした文字で 256 色の完全なパレットが使用されていることを確認します。 詳細については、Microsoft エージェントの文字の設計に関するドキュメントを参照してください。

## マイ ページでは、複数のフレームからエージェント文字が読み込まれます。 IE 5 では、Microsoft エージェントの読み込みに失敗しましたエラーが表示されます。

これは IE 5 の既知の問題です。 ブラウザーが特定のイベントを処理する方法に変更が加えられたため、AgentSvr が開始される前に HTML スクリプトの実行が開始されます。 ブラウザーのすべてのバージョンでページを動作させるには、次の行をスクリプトに追加する必要があります。

AgentControl.Connected = True

AgentSvr への接続を明示的に作成します。 これは、ページが複数のフレームからエージェントを読み込む場合にのみ必要であることに注意してください。

## アプリケーションが Windows 2000 (または Windows XP) に Microsoft エージェントをインストールしようとすると、エージェントが Windows 2000 (または Windows XP) と互換性がないというエラーが表示されます。

以前のバージョンのエージェント コア コンポーネント キャビネット ファイル MSAGENT.exeは、Windows 2000 (および Windows XP) で実行すると、インストールがブロックされ、実行中のオペレーティング システムのバージョンとエージェントが互換性がないことを示す不正確なエラー メッセージが表示されます。 実際、Microsoft Agent 2.0 コア コンポーネントは Windows 2000 (および Windows XP) の一部として含まれており、Windows セットアップによって既定で既にインストールされています。

このバージョンでは、チェックが削除され、インストール ファイルに Windows 2000 (または Windows XP) の下に前述のエラー メッセージは表示されません。 これはインストール ファイルに対する唯一の変更であり、エージェント コア コンポーネント自体にコード変更がないことに注意してください。 したがって、エージェント 2.0 が既にインストールされている場合、または Web サイトでオブジェクト タグを使用して Microsoft オブジェクト ストアからのエージェント コア コンポーネントの自動ダウンロードをトリガーする場合は、この更新プログラムの影響を受けません。

アプリケーションにエージェントコアコンポーネントのインストールファイルを含める場合、またはインストールファイルをサーバーに投稿する場合は、この更新プログラムをダウンロードすることができます。 これを行うには、ここをクリックして[このプログラムをディスクに保存]オプションを選択します。 このような状況では、有効で現在のエージェント配布ライセンスが必要です。

または、以前のバージョンのMSAGENT.exeインストール ファイルをインストールするときにサイレント オプションを使用して、この問題を回避することもできます。 シェル コマンドは次のとおりです。

** /q:a をMSAGENT.exeする**

これは、1998 年 10 月に最初にリリースされたエージェント言語コンポーネントにも適用されます。 アラビア語、フランス語、ドイツ語、ヘブライ語、イタリア語、日本語、韓国語、簡体字中国語、スペイン語、繁体字中国語の各言語コンポーネントが Windows 2000 (および Windows XP) の下にインストールされないようにするチェックが存在しました。 これらのインストール ファイルの新しいバージョンと、2000 年 3 月に追加された 19 の言語は、このチェックを含まず、Windows 2000 (および Windows XP) に正常にインストールされます。

## カスタマイズした文字は、Windows 2000 (および Windows XP) の透過性の色で予期しない動作を示します。

これは、256 色未満のパレットで作成された文字に関する既知の問題です。 これらの文字に関する問題には、背景に表示される透明度の色、透明なバルーン テキスト、透明なバルーンの境界線、透明なバルーンの背景などがあります。 このような文字を使用すると、エージェントの文字選択ダイアログまたは Microsoft Office Assistant ギャラリーに読み込まれると、アプリケーションがクラッシュする可能性があることに注意してください。 カスタマイズした文字は、256 色のフル パレットを使用する必要があります。 Office Assistant の文字用に用意されているサンプル パレットを、完全な 256 カラー パレットの開始点として使用できます。

## 私はその言語IDをイギリス英語&h0809に設定しているにもかかわらず、文字は英国英語TTSエンジンを使用していません。

まず、エージェント コア コンポーネント、SAPI ランタイム バイナリ、および SAPI4 準拠の英国英語 TTS エンジン (TTS3000 British English エンジンなど) がインストールされていることを確認します。これは、[エージェントのダウンロード] ページでダウンロードできます。 キャラクターがまだ英国英語 TTS エンジンを使用していない場合は、アメリカ英語の TTS エンジンもインストールされている可能性があります。 イギリス英語とアメリカ英語の両方が同じ第一言語 (英語) を共有し、アメリカ英語が既定であるため、エージェントは SAPI によって返される最初の利用可能なアメリカ英語 TTS エンジンを選択します。 英国英語の TTS エンジンを使用するには、代わりに文字の TTSModeID プロパティを使用します。 たとえば、TTS3000 英国英語男性音声の TTSModeID は {227A0E41-A92A-11d1-B17B-0020AFED142E} です。 Microsoft Visual Basic では、Merlin の TTSModeID を次のように設定することで、このエンジンを使用できます。

AgentControl.Characters("Merlin")。TTSModeID = {227A0E41-A92A-11d1-B17B-0020AFED142E}

## 音声タグ \Vol=0\ を使用して文字のボリュームを 0 に設定すると、影響を受けなかったり、AgentSvr がクラッシュしたりします。

これは既知の問題です。 Windows 95、Windows 98、および Windows Me オペレーティング システムでは、文字のボリュームは変更されませんが、以前に設定したレベルのままです。 Windows NT 4.0、Windows 2000、および Windows XP プラットフォームでは、TTS エンジンがインストールされていない場合でも AgentSvr がクラッシュします。 文字の音量の範囲は 0 (無音) から 65535 (最大音量) まで大きく、連続するレベルの違いはほとんど識別できないため、簡単な回避策は、文字の音声を聞き取れない場合に 0 ではなくボリュームを 1 に設定することです。

## カスタマイズしたキャラクターの Return アニメーションが、MoveDown、MoveLeft、MoveRight、MoveUp のいずれかのアニメーションの後に正しく再生されません。

単純な話すアニメーションが [話す状態] に割り当てられていることを確認します。 たとえば、マウス オーバーレイを使用して、キャラクターのニュートラルな位置で構成される 1 つのフレームを使用できます。