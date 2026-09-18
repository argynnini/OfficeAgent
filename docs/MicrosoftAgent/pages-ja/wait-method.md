---
layout: Conceptual
title: Wait メソッド - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/wait-method
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Wait メソッド
document_id: cbe3a755-d4f5-880e-6ad8-4ef15176b21a
document_version_independent_id: 41045f6b-1426-9f07-8906-a6edbbeacec2
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/wait-method.md
locale: ja-jp
ms.assetid: 968a3f19-6953-473b-ba98-0dc93696e703
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/wait-method.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:04:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/wait-method.md
page_type: conceptual
toc_rel: toc.json
word_count: 587
asset_id: lwef/wait-method
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 9247e890-a44c-1f93-ce8c-08b0bf642dff
---

# Wait メソッド - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 指定したアニメーション要求が完了するまで、指定した文字のアニメーション キューを待機します。
- **構文の**
    - エージェント \*\* です。characters ("***CharacterID***")。Wait\*\**Request*

| 部分 | 形容 |
| --- | --- |
| *要求* | 特定のアニメーションを指定する [**Request**](/ja-jp/windows/desktop/lwef/the-request-object) オブジェクト。. |

## 備考

このメソッドは、複数の (同時) 文字をサポートし、文字の相互作用をシーケンス処理しようとしている場合にのみ使用します。 (1 文字の場合、各アニメーション要求は、前の要求が完了した後に順番に再生されます)。2 つの文字があり、もう一方の文字のアニメーションが完了するまでキャラクターのアニメーション要求を待機する場合は、**Wait** メソッドを他のキャラクタのアニメーションに設定します [**Request**](/ja-jp/windows/desktop/lwef/the-request-object) オブジェクト。 要求パラメーターを指定するには、変数を作成し、割り込むアニメーション要求を割り当てる必要があります。

```
   Dim GenieRequest 
   Dim RobbyRequest 
   Dim Genie 
   Dim Robby 

   Sub window_Onload

   Agent1.Characters.Load "Genie", "https://agent.microsoft.com/characters/v2/genie/genie.acf"
   Agent1.Characters.Load "Robby", "https://agent.microsoft.com/characters/v2/robby/robby.acf"

   Set Genie = Agent1.Characters("Genie")
   Set Robby = Agent1.Characters("Robby")

   Genie.Get "State", "Showing"
   Robby.Get "State", "Showing"

   Genie.Get "Animation", "Announce, AnnounceReturn, Pleased, _ 
      PleasedReturn"
   
   Robby.Get "Animation", "Confused, ConfusedReturn, Sad, SadReturn"

   Set Genie = Agent1.Characters ("Genie")
   Set Robby = Agent1.Characters ("Robby")

   Genie.MoveTo 100,100
   Genie.Show

   Robby.MoveTo 250,100
   Robby.Show

   Genie.Play "Announce"
   Set GenieRequest = Genie.Speak ("Why did the chicken cross the road?")
   
   Robby.Wait GenieRequest
   Robby.Play "Confused"
   Set RobbyRequest = Robby.Speak ("I don't know. Why did the chicken _
      cross the road?")
   
   Genie.Wait RobbyRequest
   Genie.Play "Pleased"
   Set GenieRequest = Genie.Speak ("To get to the other side.")
   
   Robby.Wait GenieRequest
   Robby.Play "Sad"
   Robby.Speak "I never should have asked."

   End Sub
```

また、特定のアニメーション要求を使用して **Wait** を直接呼び出すだけで、コードを効率化することもできます。

```
   Robby.Wait Genie.Play "GestureRight"
```

これにより、[**Request**](/ja-jp/windows/desktop/lwef/the-request-object) オブジェクトを明示的に宣言する必要がなくなります。