---
layout: Conceptual
title: PropertySheet オブジェクト - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/the-propertysheet-object
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: PropertySheet オブジェクト
document_id: 78460226-8ff1-9cdc-fde0-845c759ee4c9
document_version_independent_id: 3c4fc335-5027-2c1e-8b17-2a94b8d0dda9
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/the-propertysheet-object.md
locale: ja-jp
ms.assetid: 9d15d198-a4fe-4c05-a7be-0807a179cd9c
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/the-propertysheet-object.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:02:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/the-propertysheet-object.md
page_type: conceptual
toc_rel: toc.json
word_count: 262
asset_id: lwef/the-propertysheet-object
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 44187fa6-eb3a-1bfd-c541-115fd3b5aa27
---

# PropertySheet オブジェクト - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

[**PropertySheet**](https://www.bing.com/search?q=**PropertySheet**) オブジェクトには、Microsoft Agent プロパティ シート ([高度な文字オプション] ウィンドウとも呼ばれます) を基準にして文字を操作する場合に使用できるプロパティがいくつか用意されています。

- [**\[高さ\]**](height-property-pso)
- [**左**](left-property-pso)
- [**ページ**](page-property)
- [**ページのトップへ**](top-property-pso)
- [**\[表示\]**](visible-property)
- [**幅**](width-property-pso)

プロパティ シートが表示される前に [**Height**](height-property-pso)、 [**Left**](left-property-pso)、 [**Top**](top-property-pso)、 [**Width**](width-property-pso) の各プロパティに対してクエリを実行すると、その値はゼロ (0) として返されます。 表示されると、これらのプロパティはウィンドウの最後の位置とサイズを返します (現在の画面解像度に対する相対位置)。