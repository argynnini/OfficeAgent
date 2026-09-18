---
layout: Conceptual
title: BorderColor プロパティ - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/bordercolor-property
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: BorderColor プロパティ
document_id: 6f97c65b-2200-dc2c-bd06-984a6e1dfcd1
document_version_independent_id: 293cb9d0-e226-7937-fea3-d9cdb27e64ba
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/bordercolor-property.md
locale: ja-jp
ms.assetid: 7592db02-c157-45f4-bbcf-e6d5bd99e8e8
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/bordercolor-property.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:37:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-01-09T19:49:59.6397822Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/bordercolor-property.md
page_type: conceptual
toc_rel: toc.json
word_count: 221
asset_id: lwef/bordercolor-property
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: f1050c61-b6c2-1dff-fea7-180bed5d3965
---

# BorderColor プロパティ - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 指定した文字の吹き出しウィンドウに現在表示されている境界線の色を返します。
- **構文の**
    - エージェント \*\* です。Characters ("***CharacterID***").\*\*Balloon.BorderColor

## 備考

通常の RGB カラーの有効な範囲は 0 ~ 16,777,215 (&HFFFFFF) です。 この範囲内の数値の上位バイトは 0 です。下位 3 バイト (最下位バイトから最上位バイト) は、それぞれ赤、緑、青の量を決定します。 赤、緑、青の各コンポーネントは、0 から 255 (&HFF) の間の数値で表されます。