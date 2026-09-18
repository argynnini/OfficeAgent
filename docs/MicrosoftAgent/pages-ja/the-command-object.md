---
layout: Conceptual
title: Command オブジェクト - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/the-command-object
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Command オブジェクト
document_id: 0f982f29-524e-cc86-df63-e5aab32d322c
document_version_independent_id: 5bdc0251-97d7-6f41-e185-dc45a7133af7
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/the-command-object.md
locale: ja-jp
ms.assetid: a757846a-c2d0-4239-9533-babf5dc8399f
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/the-command-object.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:02:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/the-command-object.md
page_type: conceptual
toc_rel: toc.json
word_count: 1801
asset_id: lwef/the-command-object
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: ec125304-e14a-4656-2462-1ab484274e5d
---

# Command オブジェクト - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

[**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトは、[**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクション内の項目です。 サーバーは、クライアント アプリケーションが入力アクティブになったときに **、Command** オブジェクトへのユーザー アクセスを提供します。

- [Command オブジェクトのプロパティ](command-object-properties)

[**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトの プロパティにアクセスするには、[**Name**](name-property) プロパティを使用してコレクション内で参照します。 VBScript と Visual Basic では、 **Name** プロパティを直接使用できます。

```
   <i>agent</i>.Characters("<i>CharacterID</i>").Commands("<i>Name</i>").<i>property</i> [= <i>value</i>]
```

コレクションをサポートしないプログラミング言語の場合は、 [**Command**](command-method) メソッドを使用します。

```
   <i>agent</i>.Characters("<i>CharacterID</i>").Commands.Command("<i>Name</i>").<i>property</i> [= <i>value</i>]
```

Command オブジェクトを参照するには、そのオブジェクトへの参照を作成します。 Visual Basic でオブジェクト変数を宣言し、Set ステートメントを使用して参照を作成します。

```
   Dim Cmd1 as Object
   ...
   Set Cmd1 = Agent.Characters("MyCharacterID").Commands("SampleCommand")
   ...
   Cmd1.Enabled = True
```

Visual Basic 5.0 では、オブジェクトを [**IAgentCtlCommandEx**](https://www.bing.com/search?q=**IAgentCtlCommandEx**) 型として宣言し、参照を作成することもできます。 この規則により、早期バインディングが有効になり、パフォーマンスが向上します。

```
   Dim Cmd1 as IAgentCtlCommandEx
   ...
   Set Cmd1 = Agent.Characters("MyCharacterID").Commands("SampleCommand")
   ...
   Cmd1.Enabled = True
```

VBScript では、参照を特定の型として宣言できますが、変数を宣言してコレクション内の [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) に設定することもできます。

```
   Dim Cmd1
   ...
   Set Cmd1 = Agent.Characters("MyCharacterID").Commands("SampleCommand")
   ...
   Cmd1.Enabled = True
```

コマンドは、文字のポップアップ メニューとコマンド ウィンドウ、またはその両方に表示される場合があります。 ポップアップ メニューに表示するには、キャプションがあり、[**Visible**](visible-property) プロパティが **True** に設定されている必要があります。 さらに、その Commands コレクション オブジェクト **Visible** プロパティも **True** に設定する必要があります。 コマンド ウィンドウに表示するには、 [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) に [**Caption**](caption-property) プロパティと [**Voice**](voice-property) プロパティが設定されている必要があります。 メニューが表示されている間、文字のポップアップ メニュー エントリは変更されないことに注意してください。 文字のポップアップ メニューが表示されているときにコマンドを追加または削除したり、プロパティを変更したりすると、ユーザーが次に表示するたびにメニューにそれらの変更が表示されます。 ただし、[コマンド] ウィンドウには、行った変更が動的に反映されます。

次の表は、 [**Command の**](/ja-jp/windows/desktop/lwef/the-command-object) プロパティがプレゼンテーションにどのように影響するかをまとめたものです。

Caption プロパティ

Voice-Caption プロパティ

Voice プロパティ

Visible プロパティ

Enabled プロパティ

キャラクターのポップアップメニューに表示される

コマンド ウィンドウに表示される

はい

はい

はい

True

True

標準(キャプションを使用)

はい([**VoiceCaption** を使用)](voicecaption-property)

はい

はい

はい

True

False

キャプションを使用して無効

いいえ

はい

はい

はい

False

True

表示されない

はい([**VoiceCaption** を使用)](voicecaption-property)

はい

はい

はい

False

False

表示されない

いいえ

はい

はい

いいえ

True

True

標準(キャプションを使用)

いいえ

はい

はい

いいえ

True

False

キャプションを使用して無効

いいえ

はい

はい

いいえ

False

True

表示されない

いいえ

はい

はい

いいえ

False

False

表示されない

いいえ

いいえ

はい

はい

True

True

表示されない

はい([**VoiceCaption** を使用)](voicecaption-property)

いいえ

はい

はい

True

False

表示されない

いいえ

いいえ

はい

はい

False

True

表示されない

はい([**VoiceCaption** を使用)](voicecaption-property)

いいえ

はい

はい

False

False

表示されない

いいえ

いいえ

はい

いいえ

True

True

表示されない

いいえ

いいえ

はい

いいえ

True

False

表示されない

いいえ

いいえ

はい

いいえ

False

True

表示されない

いいえ

いいえ

はい

いいえ

False

False

表示されない

いいえ

はい

いいえ

はい

True

True

標準(キャプションを使用)

はい(キャプションを使用 [**)**](caption-property)

はい

いいえ

はい

True

False

キャプションを使用して無効

いいえ

はい

いいえ

はい

False

True

表示されない

はい(キャプションを使用 [**)**](caption-property)

はい

いいえ

はい

False

False

表示されない

いいえ

はい

いいえ

いいえ

True

True

標準(キャプションを使用)

いいえ

はい

いいえ

いいえ

True

False

キャプションを使用して無効

いいえ

はい

いいえ

いいえ

False

True

表示されない

いいえ

はい

いいえ

いいえ

False

False

表示されない

いいえ

いいえ

いいえ

はい

True

True

表示されない

いいえ

いいえ

いいえ

はい

True

False

表示されない

いいえ

いいえ

いいえ

はい

False

True

表示されない

いいえ

いいえ

いいえ

はい

False

False

表示されない

いいえ

いいえ

いいえ

いいえ

True

True

表示されない

いいえ

いいえ

いいえ

いいえ

True

False

表示されない

いいえ

いいえ

いいえ

いいえ

False

True

表示されない

いいえ

いいえ

いいえ

いいえ

False

False

表示されない

いいえ

プロパティの設定が null の場合。 一部のプログラミング言語では、空の文字列が null 文字列と同じように解釈されない場合があります。 コマンドは引き続き音声でアクセスできます。

サーバーは、いずれかのコマンドの入力を受け取ると、[**Command**](/ja-jp/windows/desktop/lwef/the-command-object) イベントを送信し、[**UserInput**](/ja-jp/windows/desktop/lwef/iagentuserinput) オブジェクトの属性として **Command** の名前を返します。 その後、条件付きステートメントを使用して **、Command** を照合して処理できます。