---
layout: Conceptual
title: Description プロパティ (従来の Windows 環境機能) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/description-property
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Description プロパティ
document_id: a743baca-5fc6-67d3-f4ce-1be9b8807f57
document_version_independent_id: 77e1b245-3d71-f067-fdb2-66d06b802350
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/description-property.md
locale: ja-jp
ms.assetid: 81ac4bc7-ef0c-4e7c-b57e-acc4ad315515
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/description-property.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:39:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/description-property.md
page_type: conceptual
toc_rel: toc.json
word_count: 301
asset_id: lwef/description-property
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: a4422a91-f216-db5f-0514-c2a49b25e416
---

# Description プロパティ (従来の Windows 環境機能) - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 指定した文字の説明を指定する文字列を設定または返します。
- **構文の**
    - エージェント *を*します。**Characters("*CharacterID*")。Description** [ = *string*]

| 部分 | 形容 |
| --- | --- |
| 文字列 *を* する | 文字の説明に対応する文字列値 (現在の言語設定)。 |

## 備考

文字の **説明** は、文字の **LanguageID** 設定によって異なります。 ある言語の文字の名前が異なる場合や、別の言語とは異なる文字を使用する場合があります。 特定の言語の文字の既定の **説明** は、その文字が Microsoft エージェント文字エディターでコンパイルされるときに定義されます。

手記

**Description** プロパティの設定は省略可能であり、すべての文字に対して指定できるわけではありません。