---
layout: Conceptual
title: Confidence プロパティ - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/confidence-property
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Confidence プロパティ
document_id: c3e177f2-e6cb-95c2-a306-0f32394ee609
document_version_independent_id: 3bc2ce99-edad-65da-8001-acf7bc924062
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/confidence-property.md
locale: ja-jp
ms.assetid: 28a57970-4649-4a9a-9fb2-bf3f0b2f54ce
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/confidence-property.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:38:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/confidence-property.md
page_type: conceptual
toc_rel: toc.json
word_count: 230
asset_id: lwef/confidence-property
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: acf862c1-9b7c-c40e-f6c5-6e0b81567349
---

# Confidence プロパティ - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - クライアントの **信頼度** がリッスン ヒントに表示されるかどうかを示す値を取得または設定します。
- **構文の**
    - エージェント \*\* です。characters ("***CharacterID***")。Commands("***名***")\*\* です。**信頼度** [ = *数値*]

| 部分 | 形容 |
| --- | --- |
| *数値* | [**コマンド**](/ja-jp/windows/desktop/lwef/the-command-object)の信頼度値を識別する Long 整数に評価される数値式。 |

## 備考

最適一致 (UserInput.Confidence) の返された信頼度値が、**信頼度** プロパティに設定した値を超えていない場合は、[**ConfidenceText**](confidencetext-property) で指定されたテキストがリッスン ヒントに表示されます。