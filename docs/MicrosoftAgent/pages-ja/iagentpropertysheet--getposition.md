---
layout: Conceptual
title: IAgentPropertySheet GetPosition - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentpropertysheet--getposition
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentPropertySheet GetPosition
document_id: c8c5a6a0-581e-5cef-b42c-2a4d7b8873d9
document_version_independent_id: 33c24e7b-d6eb-7da2-7a15-4a5126e1542e
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentpropertysheet--getposition.md
locale: ja-jp
ms.assetid: 5d3de366-e48a-4643-81c5-ac4808671763
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentpropertysheet--getposition.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:52:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentpropertysheet--getposition.md
page_type: conceptual
toc_rel: toc.json
word_count: 237
asset_id: lwef/iagentpropertysheet--getposition
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 75dc4949-2393-9f35-3d51-eee34cc1f8fb
---

# IAgentPropertySheet GetPosition - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT GetPosition(
   long * plLeft,  // address of variable for left edge of property sheet
   long * plTop    // address of variable for top edge of property sheet
);
```

Microsoft エージェントのプロパティ シート ウィンドウの位置を取得します。

- 操作が成功したことを示すS\_OKを返します。

- plLeft*を * する
    - プロパティ シートの左端の画面座標を受け取る変数のアドレス (画面の原点 (左上) を基準にしたピクセル単位)。
- plTop*を * する
    - プロパティ シートの上端の画面座標を受け取る変数のアドレス (画面の原点 (左上) を基準にしたピクセル単位)。