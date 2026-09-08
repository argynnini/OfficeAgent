---
layout: Conceptual
title: Bookmark イベント - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/bookmark-event
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Bookmark イベント
document_id: 8d497e8f-4cb1-0179-f4eb-0966a9ee9e26
document_version_independent_id: cf0b202a-657b-8555-b2b2-b5d3dc7c3967
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/bookmark-event.md
locale: ja-jp
ms.assetid: 6733cd4e-2ba0-4cff-b68d-abfea284f748
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/bookmark-event.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:37:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-07-03T23:50:19.3460266Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/bookmark-event.md
page_type: conceptual
toc_rel: toc.json
word_count: 208
asset_id: lwef/bookmark-event
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: c88f9803-42db-bcb5-6aa8-b9b548cf7805
---

# Bookmark イベント - Win32 apps | Microsoft Learn

[Microsoft Agent は Windows 7 の時点で非推奨となり、後続のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - アプリケーションで定義されている音声テキスト文字列内のブックマークがアクティブになったときに発生します。
- **構文**
    - **Sub***agent*\_**Bookmark** **(ByVal***BookmarkID*\*\*)\*\*

| 部分 | 説明 |
| --- | --- |
| *BookmarkID* | ブックマーク番号を識別する長整数。 |

### 解説

ブックマーク イベントを指定するには、[**Speak**](speak-method) メソッドを使用し、指定したテキストに **Mrk** タグを付けます。 タグの詳細については、「音声出力タグ」を参照してください。