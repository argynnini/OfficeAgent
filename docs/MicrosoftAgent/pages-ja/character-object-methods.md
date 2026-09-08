---
layout: Conceptual
title: Character オブジェクト メソッド - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/character-object-methods
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Character オブジェクト メソッド
document_id: 45be45e4-8c7f-e85c-b961-6ecef10f78bd
document_version_independent_id: 604f4035-f3a6-5877-a4c7-6932647544dd
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: adcc2e2cf0329f73eb5d5ecafc17c88bc0bfb02f
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/adcc2e2cf0329f73eb5d5ecafc17c88bc0bfb02f/desktop-src/lwef/character-object-methods.md
locale: ja-jp
ms.assetid: 0f926b7b-c1cf-4bd6-ba8c-1b2877eb1d24
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/character-object-methods.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:38:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/character-object-methods.md
page_type: conceptual
toc_rel: toc.json
word_count: 758
asset_id: lwef/character-object-methods
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 847b1aae-7b85-f2ab-9449-9062376ab8bb
---

# Character オブジェクト メソッド - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

また、サーバーは [**Characters**](/ja-jp/windows/desktop/lwef/the-characters-object) コレクション内の各文字のメソッドも公開します。 以下のメソッドがサポートされています。

- [**アクティブ化**](activate-method)
- [**GestureAt**](gestureat-method)
- [**取得**](get-method)
- [**非表示**](hide-method)
- [**割り込み**](interrupt-method)
- [**聞く**](listen-method)
- [**MoveTo**](moveto-method)
- [**再生**](play-method)
- [**表示**](show-method)
- [**ShowPopupMenu**](showpopupmenu-method)
- [**Speak**](speak-method)
- [**Stop**](stop-method)
- [**StopAll**](stopall-method)
- [**思考**](think-method)
- [**Wait**](wait-method)

メソッドを使用するには、コレクション内の文字を参照します。 VBScript と Visual Basic では、文字の ID を指定してこれを行います。

```
   Sub FormLoad

   'Load the genie character into the Characters collection
   Agent1.Characters.Load "Genie", "Genie.acs"

   'Display the character
   Agent1.Characters("Genie").Show
   Agent1.Characters("Genie").Play "Greet"
   Agent1.Characters("Genie").Speak "Hello. "

   End Sub
```

コードの構文を簡略化するために、オブジェクト変数を定義し、 [**Characters**](/ja-jp/windows/desktop/lwef/the-characters-object) コレクション内の文字オブジェクトを参照するように設定できます。その後、変数を使用して、文字のメソッドまたはプロパティを参照できます。 次の例では、Visual Basic Set ステートメントを使用してこれを行う方法を示します。

```
   'Define a global object variable
   Dim Genie as Object

   Sub FormLoad

   'Load the genie character into the Characters collection
   Agent1.Characters.Load "Genie", " Genie.acs"

   'Create a reference to the character
   Set Genie = Agent1.Characters("Genie")

   'Display the character
   Genie.Show

   'Get the Restpose animation
   Genie.Get "animation", "RestPose"

   'Make the character say Hello
   Genie.Speak "Hello."

   End Sub
```

Visual Basic 5.0 では、変数を [**Character**](/ja-jp/windows/desktop/lwef/the-characters-object)オブジェクトとして宣言して参照を作成することもできます。

```
   Dim Genie as IAgentCtlCharacterEx

   Sub FormLoad

   'Load the genie character into the Characters collection
   Agent1.Characters.Load "Genie", "Genie.acs"

   'Create a reference to the character
   Set Genie = Agent1.Characters("Genie")

   'Display the character
   Genie.Show

   End Sub
```

IAgentCtlCharacterEx 型のオブジェクトを宣言すると、オブジェクトに対する事前バインディングが有効になり、パフォーマンスが向上します。

VBScript では、参照を特定の型として宣言することはできません。 ただし、変数参照を宣言するだけです。

```
<SCRIPT LANGUAGE = "VBSCRIPT">
<!—--

   Dim Genie
   
   Sub window_OnLoad
   
   'Load the character
   AgentCtl.Characters.Load "Genie", "https://agent.microsoft.com/characters/v2/genie/genie.acf"

   'Create an object reference to the character in the collection
   set Genie= AgentCtl.Characters ("Genie")

   'Get the Showing state animation
   Genie.Get "state", "Showing"

   'Display the character
   Genie.Show

   End Sub

-->
   </SCRIPT>
```

一部のプログラミング言語では、コレクションがサポートされていません。 ただし、[**Character**](character-method) メソッドを使用して [**Character**](/ja-jp/windows/desktop/lwef/the-characters-object) オブジェクトのメソッドにアクセスできます。

```
   agent.Characters.Character("CharacterID").method
```

さらに、 [**Character**](/ja-jp/windows/desktop/lwef/the-characters-object) オブジェクトへの参照を作成して、スクリプト コードを簡単に実行することもできます。

```
<SCRIPT LANGUAGE="JScript" FOR="window" EVENT="onLoad()">
<!--
   
   //Load the character's data
   AgentCtl.Characters.Load ("Genie", _
      "https://agent.microsoft.com/characters/v2/genie/genie.acf");   

   //Create a reference to this object
   Genie = AgentCtl.Characters.Character("Genie");
   
   //Get the Showing state animation
   Genie.Get("state", "Showing");

   //Display the character
   Genie.Show();

-->
</SCRIPT>
```