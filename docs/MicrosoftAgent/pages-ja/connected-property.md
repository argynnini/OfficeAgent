---
layout: Conceptual
title: Connected プロパティ - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/connected-property
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Connected プロパティ
document_id: 7bf4c1b7-acfe-a204-e473-8d7c18a7bbcb
document_version_independent_id: eb285f02-19bb-7f9b-34ee-35437698c848
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/connected-property.md
locale: ja-jp
ms.assetid: 61b7f550-d8d6-4719-a0d4-0bf3a8cf096c
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/connected-property.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:38:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/connected-property.md
page_type: conceptual
toc_rel: toc.json
word_count: 1331
asset_id: lwef/connected-property
item_type: Content
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: c0a82fc7-ae3d-77a2-b0d0-95fe32ba596d
---

# Connected プロパティ - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 現在のコントロールが Microsoft エージェント サーバーに接続されているかどうかを示す値を取得または設定します。
- **構文の**
    - \*agent.\***Connected** [ = *boolean*]

| 部分 | 形容 |
| --- | --- |
| ブール | コントロールが接続されているかどうかを示すブール式。 **True** コントロールが接続されています。 |

## 備考

多くの場合、コントロールを指定すると、Microsoft エージェント サーバーとの接続が自動的に作成されます。 たとえば、Web ページの &lt;OBJECT&gt; タグに Microsoft エージェント コントロールの CLSID を指定すると、サーバー接続が自動的に開き、ページを終了すると接続が閉じます。 同様に、フォーム上のコントロールを削除できる Visual Basic やその他の言語の場合、プログラムを実行すると自動的に接続が開き、プログラムを終了すると接続が閉じます。 サーバーが現在実行されていない場合は、自動的に起動します。

ただし、実行時にエージェント コントロールを作成する場合は、**Connected** プロパティを使用して、サーバーへの新しい接続を明示的に開く必要がある場合もあります。 たとえば、Visual Basic では、**New** キーワード (または CreateObject 関数) で Set ステートメントを使用して、実行時に ActiveX オブジェクトを作成できます。 これによりオブジェクトが作成されますが、サーバーへの接続が作成されない場合があります。 次の例に示すように、Microsoft エージェントのプログラミング インターフェイスを呼び出すコードの前に、**Connected** プロパティを使用できます。

```
   ' Declare a global variable for the control
   Dim MyAgent as Agent

   ' Create an instance of the control using New
   Set MyAgent = New Agent

   ' Open a connection to the server
   MyAgent.Connected = True

   ' Load a character
   MyAgent.Characters.Load "Genie", " Genie.acs"

   ' Display the character
   MyAgent.Characters("Genie").Show
```

この手法を使用してコントロールを作成しても、エージェント コントロールのイベントは公開されません。 Visual Basic 5.0 (以降) では、プロジェクトの参照にコントロールを含めることでコントロールのイベントにアクセスし、変数宣言で **WithEvents** キーワードを使用できます。

```
   Dim WithEvents MyAgent as Agent

   ' Create an instance of the control using New
   Set MyAgent = New Agent
```

**WithEvents** を使用して、実行時にエージェント コントロールのインスタンスを作成すると、Microsoft エージェント サーバーとの接続が自動的に開きます。 そのため、**Connected** ステートメントを含める必要はありません。

エージェント オブジェクトに対して作成したすべての参照 (IAgentCtlCharacterEx、IAgentCtlCommandEx など) を解放することで、サーバーへの接続を閉じます。 エージェント コントロール自体への参照も解放する必要があります。 Visual Basic では、変数を **Nothing**に設定することで、オブジェクトへの参照を解放できます。 文字を読み込んだ場合は、文字オブジェクトを解放する前にアンロードします。

```
   Dim WithEvents MyAgent as Agent
   Dim Genie as IAgentCtlCharacterEx
   
   Sub Form_Load

   ' Create an instance of the control using New
   Set MyAgent = New Agent

   ' Open a connection to the server
   MyAgent.Connected = True

   ' Load the character into the Characters collection
   MyAgent.Characters.Load "Genie", " Genie.acs"

   ' Create a reference to the character
   Set Genie = MyAgent.Characters("Genie")

   End Sub

   Sub CloseConnection

   ' Unload the character
   MyAgent.Characters.Unload "Genie"

   ' Release the reference to the character object
   Set Genie = Nothing

   ' Release the reference to the Agent control
   Set MyAgent = Nothing
   End Sub
```

手記

コンポーネントが追加された参照を解放して、サーバーへの接続を閉じることはできません。 たとえば、&lt;OBJECT&gt; タグを使用してコントロールを宣言する Web ページや、フォーム上のコントロールを削除する Visual Basic アプリケーションでは、サーバーへの接続を閉じることはできません。 すべてのエージェント参照を解放するとエージェントのワーキング セットが減少しますが、接続は次のページに移動するか、アプリケーションを終了するまで保持されます。