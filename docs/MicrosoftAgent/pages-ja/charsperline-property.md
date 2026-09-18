---
layout: Conceptual
title: CharsPerLine プロパティ - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/charsperline-property
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: CharsPerLine プロパティ
document_id: cdc7a0d6-58e1-2c07-312f-26ea93e1288a
document_version_independent_id: ef8e6b71-033c-a6c5-a935-15e7785d8897
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/charsperline-property.md
locale: ja-jp
ms.assetid: 8493eb85-2c17-458d-8f1e-e76c978675a7
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/charsperline-property.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:38:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/charsperline-property.md
page_type: conceptual
toc_rel: toc.json
word_count: 168
asset_id: lwef/charsperline-property
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: a26246e1-d972-ed75-ba4f-fe4a21e8ac62
---

# CharsPerLine プロパティ - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

- **Description**
    - 指定した文字の吹き出しでサポートされている 1 行あたりの文字数を返します。
- **構文**
    - *エージェント*[**。Characters ("**](/ja-jp/windows/desktop/lwef/the-characters-object)*CharacterID*\*\*").\*\*Balloon.CharsPerLine

## 解説

このプロパティは、吹き出しに表示される平均文字数 (文字) を Long 整数値として返します。 [**値**](style-property)は Style プロパティを使用して設定できます。