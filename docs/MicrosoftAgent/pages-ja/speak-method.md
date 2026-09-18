---
layout: Conceptual
title: Speak メソッド - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/speak-method
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Speak メソッド
document_id: 7a87f221-bf01-d08a-7637-6734af312302
document_version_independent_id: e9ad4b3c-9777-d928-4785-f33a6cc0a647
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/speak-method.md
locale: ja-jp
ms.assetid: 6267e04c-feb5-4f48-8a88-4e6ca3388bf3
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/speak-method.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:00:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/speak-method.md
page_type: conceptual
toc_rel: toc.json
word_count: 2186
asset_id: lwef/speak-method
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: acfff9e5-3dc9-acbe-6fbe-d23c59da62f1
---

# Speak メソッド - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 指定した文字の指定したテキストまたはサウンド ファイルを読み上げる。
- **構文の**
    - エージェント \*\* です。characters ("***CharacterID***")。Speak\*\* [*Text*], [*URL*]

| 部分 | 形容 |
| --- | --- |
| *テキスト* | 随意。 文字の言い分を指定する文字列。 |
| *URL* | 随意。 オーディオ ファイルの場所を指定する文字列式 (.WAV または .LWV 形式)。 場所は、ファイル (UNC パス仕様を含む) または URL (文字アニメーション データも HTTP プロトコルを使用して取得される場合) として指定できます。 |

## 備考

*Text* パラメーターと *Url* パラメーターは省略可能ですが、そのうちの 1 つを指定する必要があります。 このメソッドを、ワード バルーンでのみ読み上げるか、テキスト読み上げ (TTS) エンジンを使用するように構成された文字で使用するには、*Text* パラメーターを指定するだけです。 従来スペースを含まない言語の場合でも、単語吹き出しに適切な単語区切りを定義するために、単語間にスペースを含めます。

また、*Text* パラメーターに垂直バー文字 (|) を含めて代替文字列を指定することもできます。そのため、サーバーはメソッドを処理するたびに異なる文字列をランダムに選択します。

TTS 出力の文字サポートは、Microsoft エージェント文字エディターを使用して文字をコンパイルするときに定義されます。 TTS 出力を生成するには、このメソッドを呼び出す前に、互換性のある TTS エンジンが既にインストールされている必要があります。 詳細については、「Speech Services [へのアクセス](accessing-speech-services)」を参照してください。

録音したサウンドファイル(.WAV または .LWV 形式のみ) 文字の出力、*Url* パラメーターでファイルの場所を指定します。 このファイル仕様には、ローカル (絶対または相対) または汎用名前付け規則 (UNC) パスを含めることができます。 ファイル名には、米国コード ページ 1252 に含まれていない文字を含めることはできません。 ただし、HTTP プロトコルを使用して文字アニメーション データにアクセスする場合は、**Speak** メソッドを呼び出す前に、[**Get**](get-method) メソッドを使用してアニメーションを読み込みます。 クリエイティブの詳細については、「Microsoft 言語情報サウンド編集ツールの [を使用する](using-the-microsoft-linguistic-information-sound-editing-tool)」を参照してください。LWV ファイル。

録音されたサウンド ファイル出力を使用する場合でも、*Text* パラメーターを使用して、文字のワード バルーンに表示される単語を指定できます。 ただし、言語的に拡張されたサウンド ファイル (.*URL* パラメーターに LWV) を指定し、ワード バルーンのテキストを指定しません。*Text* パラメーターは、ファイルに格納されているテキストを使用します。

*Text* パラメーターに含める特殊なタグを使用して、音声出力のパラメーターを変更することもできます。 詳細については、「[Microsoft Agent Speech 出力タグの](microsoft-agent-speech-output-tags)」を参照してください。

オブジェクト参照を宣言してこのメソッドに設定すると、[**Request**](/ja-jp/windows/desktop/lwef/the-request-object) オブジェクトが返されます。 これを使用すると、次の例のように、コードの他の部分を文字の読み上げ出力と同期できます。

```
   Dim SpeakRequest as Object
...
   Set SpeakRequest = Genie.Speak ("And here it is.")
...
   Sub Agent1_RequestComplete (ByVal Request as Object)
   ' Make certain the request exists
   If SpeakRequest Not Nothing Then
      ' See if it was this request
      If Request = SpeakRequest Then
         ' Display the message box 
         Msgbox "Ta da!"
      End If
   End If
   End Sub
```

[**Request**](/ja-jp/windows/desktop/lwef/the-request-object) オブジェクトを使用して、特定のエラー状態を確認することもできます。 たとえば、**Speak** メソッドを使用して話し、互換性のある TTS エンジンがインストールされていない場合、サーバーは、**Request** オブジェクトの [**Status**](status-property) プロパティを "failed" に設定し、[**Description**](description-property) プロパティを "Class not registered" または "Unknown or object returned error" に設定します。 TTS エンジンがインストールされているかどうかを確認するには、[**TTSModeID**](ttsmodeid-property) プロパティを使用します。

同様に、文字がサウンド ファイルを読み上げようとしたときに、ファイルが読み込まれていない場合、またはオーディオ デバイスに問題がある場合、サーバーは、[**Request**](/ja-jp/windows/desktop/lwef/the-request-object) オブジェクトの [**Status**](status-property) プロパティを適切なエラー コード番号で "failed" に設定します。

また、音声テキストにブックマークの音声タグを含め、コードを同期することもできます。

```
   Dim SpeakRequest as Object
...
   Set SpeakRequest = Genie.Speak ("And here \mrk=100\it is.")
...
   Sub Agent1_Bookmark (ByVal BookmarkID As Long)
   If BookmarkID = 100 Then
      ' Display the message box 
         Msgbox "Tada!"
      End If
   End Sub
```

ブックマーク音声タグの詳細については、「[Speech Output Tags](mrk-tag)」を参照してください。

**Speak** メソッドは、最後に再生されたアクションを使用して、再生するスピーキング アニメーションを決定します。 たとえば、**Speak** コマンドの前に [**Play**](play-method) "**GestureRight**" を指定した場合、サーバーは GestureRight  再生され、**GestureRight** 読み上げアニメーションが再生されます。 最後に再生されたアニメーションにスピーキング アニメーションがない場合、エージェントはキャラクターの **Speaking** 状態に割り当てられたアニメーションを再生します。

**Speak** を呼び出し、オーディオ チャネルがビジー状態の場合、キャラクターのオーディオ出力は聞こえないが、テキストは吹き出しという単語に表示されます。

吹き出し内のエージェントの自動単語区切りは、空白文字 (スペースや Tab など) を使用して単語を区切ります。 ただし、できない場合は、吹き出しに合わせて単語を分割することがあります。 日本語、中国語、タイ語などの言語では、単語を区切るためにスペースを使用しない場合は、文字の間に Unicode のゼロ幅スペース文字 (0x200B) を挿入して、論理的な単語区切りを定義します。

手記

吹き出しの [**Enabled**](enabled-property) プロパティも、テキストを表示するには True  する必要があります。

手記

文字の言語 ID を設定します (**Speak** メソッドを使用する前に、文字の **LanguageID** を設定して、ワード バルーン内に適切なテキストが表示されるようにします。