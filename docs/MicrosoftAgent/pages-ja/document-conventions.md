---
layout: Conceptual
title: ドキュメント規則 - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/document-conventions
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: ドキュメント規則
document_id: da5616b6-2195-085c-5e8a-e65fbd824049
document_version_independent_id: e3879902-78be-5726-20ff-f68056259bd2
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/document-conventions.md
locale: ja-jp
ms.assetid: 63ff3427-6a91-4968-ad8d-f8b56c3587a8
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/document-conventions.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:39:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/document-conventions.md
page_type: conceptual
toc_rel: toc.json
word_count: 427
asset_id: lwef/document-conventions
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 7ea86cc0-7e0b-c862-bd4b-d815d246b58a
---

# ドキュメント規則 - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

このドキュメントでは、次の文字体裁規則を使用します。

| 大会 | 形容 |
| --- | --- |
| **Sub、Visible、Caption** | 最初の文字が大文字の太字の単語はキーワードを示します。 |
| *エージェント、String、Now* | 斜体の単語は、指定した情報のプレースホルダーを示します。 |
| Enter、F1 | すべての大文字の単語は、ファイル名、キー名、およびキー シーケンスを示します。 |
| `Agent1.Commands.Enabled = True` | このフォントのテキストは、コード サンプルを示します。 |
| `' This is a comment` | アポストロフィ (`'`) は、コード コメントを示します。 |
| `Agent1.Commands.Add "Test1", _` | スペースとアンダースコア (\_) は、コード行を続行します。 |
| `[words or expression]` | 角かっこ内の項目は省略可能です。 |
| `This | That` | 縦棒は、2 つ以上の項目の選択を示します。 |
| *エージェントの* | 斜体の "agent" という単語は、使用するエージェント コントロールの名前を表します。 |

このドキュメントのプログラミング インターフェイスの説明は、Microsoft VBScript の規則に従います。 ただし、通常は他の言語にも適用される必要があります。