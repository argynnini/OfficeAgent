---
layout: Conceptual
title: FontName プロパティ (Commands オブジェクト) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/fontname-property
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: FontName Commands オブジェクト プロパティについて説明します。 Microsoft エージェントは、Windows 7 の時点で非推奨です。
document_id: 304b0e2f-867e-c39c-c015-c9af50c5c185
document_version_independent_id: e5e9902a-6c72-4f21-a017-ba7cf798c4c3
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/fontname-property.md
locale: ja-jp
ms.assetid: 7de3653e-9b4d-4a31-82d5-243f10e2743b
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/fontname-property.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:43:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/fontname-property.md
page_type: conceptual
toc_rel: toc.json
word_count: 327
asset_id: lwef/fontname-property
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 1a26731d-f548-969e-bd08-94dece0766d6
---

# FontName プロパティ (Commands オブジェクト) - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 文字のポップアップ メニューで使用されるフォントを設定または返します。
- **構文の**
    - \*agent.\***Characters("*CharacterID*")。Commands.FontName** [ = *Font*]

| 部分 | 形容 |
| --- | --- |
| *フォント* | フォントの名前に対応する文字列値。 |

## 備考

**FontName** プロパティは、文字のポップアップ メニューにテキストを表示するために使用するフォントを定義します。 フォント設定の既定値は、文字の **LanguageID** 設定のメニュー フォント設定、または設定されていない場合はユーザーの既定の言語 ID 設定に基づいています。

このプロパティは、クライアント アプリケーションによる文字の使用にのみ適用されます。この設定は、文字の他のクライアントやクライアント アプリケーションの他の文字には影響しません。