---
layout: Conceptual
title: Request オブジェクト - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/the-request-object
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Request オブジェクト
document_id: 9a643e62-b2f2-2b9c-79b1-134bd820f280
document_version_independent_id: e9b5da95-294c-c596-4b34-75b35c4a5932
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/the-request-object.md
locale: ja-jp
ms.assetid: d8b37164-6855-48c0-bcf8-a86c0f8b3a59
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/the-request-object.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:02:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/the-request-object.md
page_type: conceptual
toc_rel: toc.json
word_count: 1263
asset_id: lwef/the-request-object
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://authoring-docs-microsoft.poolparty.biz/devrel/540ac133-a371-4dbb-8f94-28d6cc77a70b
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://authoring-docs-microsoft.poolparty.biz/devrel/60bfc045-f127-4841-9d00-ea35495a5800
platformId: f29792a6-f8dd-f913-1928-bc6ed647b3d8
---

# Request オブジェクト - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

サーバーは、一部のメソッドを非同期的に処理します。 これにより、メソッドの完了中にアプリケーション コードを続行できます。 クライアント アプリケーションがこれらのメソッドのいずれかを呼び出すと、コントロールは [**要求の Request**](/ja-jp/windows/desktop/lwef/the-request-object) オブジェクトを作成して返します。 **Request** オブジェクトを使用すると、オブジェクト変数を メソッドに割り当てることで、メソッドの状態を追跡できます。 Visual Basic で、最初にオブジェクト変数を宣言します。

```
   Dim MyRequest as Object
```

VBScript では、宣言に変数型を含めないでください。

```
   Dim MyRequest
```

また、Visual Basic の Set ステートメントを使用して、メソッド呼び出しに変数を割り当てます。

```
   Set MyRequest = <i>agent</i>.Characters("<i>CharacterID</i>").<i>method</i> (<i>parameter</i>[s])
```

これにより、 [**Request**](/ja-jp/windows/desktop/lwef/the-request-object) オブジェクトへの参照が追加されます。 **Request** オブジェクトは、これ以上参照がない場合に破棄されます。 **Request** オブジェクトを宣言する場所とその使用方法によって、その有効期間が決まります。 オブジェクトがサブルーチンまたは関数に対してローカルに宣言されている場合、スコープ外になると破棄されます。つまり、サブルーチンまたは関数が終了したときです。 オブジェクトがグローバルに宣言されている場合、プログラムが終了するか、新しい値 (または "空" に設定された値) がオブジェクトに割り当てられるまで破棄されません。

[**Request**](/ja-jp/windows/desktop/lwef/the-request-object) オブジェクトには、クエリを実行できるプロパティがいくつか用意されています。 たとえば、 [**Status**](status-property) プロパティは要求の現在の状態を返します。 このプロパティを使用して、要求の状態をチェックできます。

```
   Dim MyRequest
   
   Set MyRequest = Agent1.Characters.Load ("Genie", "https://agent.microsoft.com/characters/v2/genie/genie.acf")

   If (MyRequest.Status = 2) then
      'do something

   Else If (MyRequest.Status = 0) then
      'do something right away

   End If
```

[**Status**](status-property) プロパティは、[**Request**](/ja-jp/windows/desktop/lwef/the-request-object) オブジェクトの状態を Long 整数値として返します。

| Status | 定義 |
| --- | --- |
| 0 | 要求が正常に完了しました。 |
| 1 | 要求に失敗しました。 |
| 2 | 保留中の要求 (キュー内ですが、完了していません)。 |
| 3 | 要求が中断されました。 |
| 4 | 要求が進行中です。 |

[**Request**](/ja-jp/windows/desktop/lwef/the-request-object) オブジェクトには、[**Status**](status-property) コードのエラーまたは原因を返す [**Number**](https://www.bing.com/search?q=**Number**) プロパティに Long 整数値も含まれています。 none の場合、この値はゼロ (0) になります。 [**Description**](description-property) プロパティには、エラー番号に対応する文字列値が含まれています。 文字列が存在しない場合、 **Description** には "アプリケーション定義またはオブジェクト定義エラー" が含まれます。

[**Number**](https://www.bing.com/search?q=**Number**) プロパティによって返される値と意味については、「[エラー コード](microsoft-agent-error-codes)」を参照してください。

サーバーは、指定した文字のキューにアニメーション要求を配置します。 これにより、サーバーは別のスレッドでアニメーションを再生でき、アニメーションの再生中にアプリケーションのコードを続行できます。 [**Request**](/ja-jp/windows/desktop/lwef/the-request-object) オブジェクト参照を作成すると、[**RequestStart**](https://www.bing.com/search?q=**RequestStart**) イベントと [**RequestComplete**](https://www.bing.com/search?q=**RequestComplete**) イベントを通じてアニメーション要求が開始または完了したときに、サーバーから自動的に通知されます。 **Request** オブジェクトを返すメソッドは非同期であり、呼び出し元の関数のスコープ中に完了しない可能性があるため、**Request** オブジェクトへの参照をグローバルに宣言します。

[**Request**](/ja-jp/windows/desktop/lwef/the-request-object) オブジェクトを取得するには、[**GestureAt**](gestureat-method)、[**Get**](get-method)、[**Hide**](hide-method)、[**Interrupt**](interrupt-method)、[**Load**](load-method)、[**MoveTo**](moveto-method)、[**Play**](play-method)、[**Show**](show-method)、[**Speak**](speak-method)、[**Wait**](https://www.bing.com/search?q=**Wait**) の各メソッドを使用できます。