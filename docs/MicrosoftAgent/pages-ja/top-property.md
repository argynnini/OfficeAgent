---
layout: Conceptual
title: Top プロパティ (Characters オブジェクト) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/top-property
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Top プロパティ (Characters オブジェクト) について説明します。 Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。
document_id: a0dc57b7-1982-024a-1f47-fd4652b1201e
document_version_independent_id: 24afa48e-d5fc-9eb0-7533-bea159c93328
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/top-property.md
locale: ja-jp
ms.assetid: d5758a77-2d9a-44b8-bbbb-57ddf96c7fe4
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/top-property.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:03:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/top-property.md
page_type: conceptual
toc_rel: toc.json
word_count: 314
asset_id: lwef/top-property
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 150478cb-28d9-692b-b4c2-774ff89295f4
---

# Top プロパティ (Characters オブジェクト) - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 指定した文字のフレームの上端を設定または返します。
- **構文の**
    - エージェント \*\* です。characters ("***CharacterID***")。Top\*\* [ = *value*]

| 部分 | 形容 |
| --- | --- |
| *値の* | 文字の上端を指定する長整数。 |

## 備考

**Top** プロパティは、画面の原点 (左上) に対して常にピクセル単位で表されます。 このプロパティの設定は、文字のすべてのクライアントに適用されます。

文字が不規則な形状の領域ウィンドウに表示される場合でも、文字の位置は、その文字が Microsoft Agent Character Editor でコンパイルされたときに使用される四角形のアニメーション フレームの外部寸法に基づきます。

[**MoveTo**](moveto-method) メソッドを使用して、文字の位置を変更します。