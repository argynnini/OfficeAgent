---
layout: Conceptual
title: Ctx タグ - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/ctx-tag
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Ctx タグ
document_id: c7448678-1a4d-69da-3825-cf6b4f17baf7
document_version_independent_id: 5e18c645-8981-5382-cd6c-06aeca4b54b3
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/ctx-tag.md
locale: ja-jp
ms.assetid: 96ceaa98-869d-4c51-a419-882cc9d40ae2
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/ctx-tag.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:39:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/ctx-tag.md
page_type: conceptual
toc_rel: toc.json
word_count: 262
asset_id: lwef/ctx-tag
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 98fe4363-caef-87fe-e0d5-838564c467f2
---

# Ctx タグ - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 出力テキストのコンテキストを設定します。
- **構文の**
    - Ctx**=*文字列*\ を \**する

| 部分 | 形容 |
| --- | --- |
| 文字列 *を* する | 記号または省略形の読み上げ方法を決定する、次のテキストのコンテキストを指定する文字列。 [アドレス] **[アドレス] または [電話番号] を** します。 電子メール **電子メールを** します。**"不明"** (既定) コンテキストが不明です。 |

### 備考

このタグは、TTS で生成された出力でのみサポートされます。 パラメーターの値の範囲は、インストールされている TTS エンジンによって異なる場合があります。