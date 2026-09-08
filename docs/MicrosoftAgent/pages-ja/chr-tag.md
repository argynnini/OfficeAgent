---
layout: Conceptual
title: Chr タグ - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/chr-tag
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Chr タグ
document_id: 6431bf75-d5e7-bd80-a116-6dcbaa65c30b
document_version_independent_id: c16a6cf4-7b9a-9638-83c7-b23bae6829dd
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/chr-tag.md
locale: ja-jp
ms.assetid: da0cb038-24fb-453e-8687-c81e11a9d8e0
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/chr-tag.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:38:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/chr-tag.md
page_type: conceptual
toc_rel: toc.json
word_count: 219
asset_id: lwef/chr-tag
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 8e510a95-2521-8ec5-b171-e9bd553b2180
---

# Chr タグ - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 音声の文字を設定します。
- **構文の**
    - Chr**=*文字列*\ を \**する

| 部分 | 形容 |
| --- | --- |
| 文字列 *を* する | 音声の文字を指定する文字列。**"標準"** (既定) 通常の音声のトーン。 「モノトーン」**モノトーン音声を** します。**ささやく声**「ささやく」。 |

### 備考

このタグは、TTS で生成された出力でのみサポートされます。 パラメーターの値の範囲は、インストールされている TTS エンジンによって異なる場合があります。