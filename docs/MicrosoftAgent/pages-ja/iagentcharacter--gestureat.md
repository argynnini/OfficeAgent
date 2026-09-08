---
layout: Conceptual
title: IAgentCharacter GestureAt - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcharacter--gestureat
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCharacter GestureAt
document_id: 1cca4af1-8b77-3816-1bf7-89f41f28f96b
document_version_independent_id: e4e854ac-380f-a505-d411-978dcc9314cd
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacter--gestureat.md
locale: ja-jp
ms.assetid: ece84652-383e-4397-a6d9-f0209dd80767
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacter--gestureat.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:46:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcharacter--gestureat.md
page_type: conceptual
toc_rel: toc.json
word_count: 387
asset_id: lwef/iagentcharacter--gestureat
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 34946702-50eb-86f0-1e80-38ad43e7083c
---

# IAgentCharacter GestureAt - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT GestureAt(
   short x,         // x-coordinate of specified location
   short y,         // y-coordinate of specified location
   long * pdwReqID  // address of a request ID
);
```

指定した位置に基づいて、関連付けられた **ゲスチャリング** 状態アニメーションを再生します。

- 操作が成功したことを示すS\_OKを返します。 関数から制御が戻ると、pdwReqID  要求の ID が格納されます。

- *x*
    - 画面の原点 (左上) を基準とした、指定した位置の x 座標 (ピクセル単位)。
- *y*
    - 画面の原点 (左上) を基準とした、指定した位置の y 座標 (ピクセル単位)。
- pdwReqID*を * する
    - **GestureAt** 要求 ID を受け取る変数のアドレス。

サーバーは、キャラクターの現在位置と指定した位置に基づいて、適切なゲスチャリング アニメーションを自動的に決定して再生します。 HTTP プロトコルを使用して文字とアニメーションのデータにアクセスする場合は、[**Prepare**](iagentcharacter--prepare) メソッドを使用して、このメソッドを呼び出す前にアニメーションを使用できるようにします。