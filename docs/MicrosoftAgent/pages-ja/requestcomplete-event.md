---
layout: Conceptual
title: RequestComplete イベント - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/requestcomplete-event
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: RequestComplete イベント
document_id: abf528e1-726a-b93d-665a-14c85a3ea593
document_version_independent_id: 380ea509-cfcf-436a-bbc4-10a43ffcb20b
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/requestcomplete-event.md
locale: ja-jp
ms.assetid: 543b79d1-f09d-4061-a1a8-8c8ab496bceb
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/requestcomplete-event.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:59:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-07-03T23:50:19.3460266Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/requestcomplete-event.md
page_type: conceptual
toc_rel: toc.json
word_count: 592
asset_id: lwef/requestcomplete-event
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: d427f824-dcd9-ce24-b6a5-defed73f8a8c
---

# RequestComplete イベント - Win32 apps | Microsoft Learn

[Microsoft Agent は Windows 7 の時点で非推奨となり、後続のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - サーバーがキューに入れられた要求を完了したときに発生します。
- **構文**
    - **サブ***エージェント*\*\*\_RequestComplete\*\* **(ByVal***Request*\*\*)\*\*

| 部分 | 説明 |
| --- | --- |
| *Request* | [**Request**](/ja-jp/windows/desktop/lwef/the-request-object) オブジェクトを返します。 |

### 解説

このイベントは [**Request**](/ja-jp/windows/desktop/lwef/the-request-object) オブジェクトを返します。 リクエストは非同期的に処理されるため、このイベントを使用して、サーバーがリクエストの処理を完了したタイミング ([**Get**](get-method)、 [**Play**](play-method)、 [**Speak**](speak-method) メソッドなど) を判断し、このイベントをアプリケーションによって生成された他のアクションと同期させることができます。 サーバーは、 **Request** オブジェクトへの参照を作成したクライアントにのみ、また、リクエスト参照のグローバル変数を定義した場合にのみ、イベントを送信します。

```
   Dim MyRequest 
   Dim Genie 

   Sub window_Onload
   
   Agent1.Characters.Load "Genie","https://agent.microsoft.com/characters/v2/genie/genie.acf"

   Set Genie = Agent.Characters("Genie")

   ' This syntax will generate RequestStart and RequestComplete events.
   Set MyRequest = Genie.Get("state", "Showing")
   ' This syntax will not generate RequestStart and RequestComplete events.
   Genie.Get "state", "Hiding"
   
   End Sub

   Sub Agent1_RequestComplete(ByVal Request)

   If Request = MyRequest Then
      Status = "Showing animation is now loaded"

   End Sub
```

アニメーション [**Request**](/ja-jp/windows/desktop/lwef/the-request-object) オブジェクトはサーバーがリクエストを処理するまで割り当てられないため、評価する前に **Request** オブジェクトが存在することを確認してください。 たとえば、Visual Basic で条件を使用して特定の要求が完了したかどうかをテストする場合は、 **Nothing** キーワードを使用できます。

```
   Sub Agent1_RequestComplete (ByVal Request)

   If Not (MyRequest Is Nothing) Then
      If Request = MyRequest Then
      '-- Do whatever
      End If
   End If

   End Sub
```

Note

VBScript 1.0 では、 [**Request**](/ja-jp/windows/desktop/lwef/the-request-object) オブジェクトへの参照を定義していない場合でも、このイベントが発生します。 これは VBScript 2.0 で修正されました。

### 参照

[**RequestStart イベント**](requeststart-event)