---
layout: Conceptual
title: ConfidenceText プロパティ - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/confidencetext-property
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: ConfidenceText プロパティ
document_id: fc7c2eff-c81b-d6ea-c477-94155509fd51
document_version_independent_id: 1ade3abe-850f-0c41-a91b-bcaf32ec9c3a
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/confidencetext-property.md
locale: ja-jp
ms.assetid: ff856af7-c5ad-4970-8778-b59a76c5e276
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/confidencetext-property.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:38:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/confidencetext-property.md
page_type: conceptual
toc_rel: toc.json
word_count: 210
asset_id: lwef/confidencetext-property
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: c4fdd5f5-e101-5a69-f65d-3ed8136866f6
---

# ConfidenceText プロパティ - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - リッスン ヒントに表示されるクライアントの **ConfidenceText** を設定または返します。
- **構文の**
    - エージェント \*\* です。characters ("***CharacterID***")。Commands("***名***")\*\* です。**ConfidenceText**[ = 文字列 ]

| 部分 | 形容 |
| --- | --- |
| 文字列 *を* する | [**コマンド**](/ja-jp/windows/desktop/lwef/the-command-object)の **ConfidenceText** のテキストに評価される文字列式。 |

## 備考

最適一致 (UserInput.Confidence) の返された信頼度値が [**の信頼度**](confidence-property) 設定を超えていない場合、サーバーはリッスン ヒントに **ConfidenceText** で指定されたテキストを表示します。