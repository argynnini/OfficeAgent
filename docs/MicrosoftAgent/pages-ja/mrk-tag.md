---
layout: Conceptual
title: Mrk タグ - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/mrk-tag
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Mrk タグ
document_id: 97d13fea-0fba-2dcb-b9ef-217e3ada5884
document_version_independent_id: 3776fc19-a316-d25e-1bf0-4f9ade63894d
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/mrk-tag.md
locale: ja-jp
ms.assetid: 1bc04853-f919-4f6f-90c2-21ac836bb1e4
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/mrk-tag.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:58:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/mrk-tag.md
page_type: conceptual
toc_rel: toc.json
word_count: 178
asset_id: lwef/mrk-tag
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: d88dca23-1d51-80d2-c8e0-018f786c1806
---

# Mrk タグ - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 読み上げられたテキストのブックマークを定義します。
- **構文の**
    - **\Mrk=*数値*\**

| 部分 | 形容 |
| --- | --- |
| *番号* | ブックマークを識別する Long 整数値。 |

### 備考

サーバーがブックマークを処理すると、ブックマーク イベントが生成されます。 0 より大きく、2147483647または2147483646と等しくない数値を指定する必要があります。