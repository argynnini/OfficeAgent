---
layout: Conceptual
title: BackColor プロパティ (従来の Windows 環境機能) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/backcolor-property
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: BackColor プロパティ
document_id: b71afecd-e1a0-4ed5-ac85-834635002c65
document_version_independent_id: 395444e3-357e-2790-cda0-e244440c90e9
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/backcolor-property.md
locale: ja-jp
ms.assetid: a82c23bc-b280-4a52-9272-68879557cac7
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/backcolor-property.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:37:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-01-09T19:49:59.6397822Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/backcolor-property.md
page_type: conceptual
toc_rel: toc.json
word_count: 221
asset_id: lwef/backcolor-property
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 9ae20980-9230-b6d4-6895-284d5b07d937
---

# BackColor プロパティ (従来の Windows 環境機能) - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 指定した文字の吹き出しウィンドウに現在表示されている背景色を返します。
- **構文の**
    - エージェント \*\* です。characters ("***CharacterID***")。Balloon.BackColor\*\*

## 備考

通常の RGB カラーの有効な範囲は 0 ~ 16,777,215 (&HFFFFFF) です。 この範囲内の数値の上位バイトは 0 です。下位 3 バイト (最下位バイトから最上位バイト) は、それぞれ赤、緑、青の量を決定します。 赤、緑、青の各コンポーネントは、0 から 255 (&HFF) の間の数値で表されます。