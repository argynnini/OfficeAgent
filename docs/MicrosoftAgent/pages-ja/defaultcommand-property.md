---
layout: Conceptual
title: DefaultCommand プロパティ - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/defaultcommand-property
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: DefaultCommand プロパティ
document_id: d0aef1e8-fe32-b36f-ca51-98bf9ccab3b0
document_version_independent_id: 413c7b22-954d-ab66-5311-12a8665ce3c0
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/defaultcommand-property.md
locale: ja-jp
ms.assetid: ba4d51fc-7178-4dbb-9ae5-f1991f40aad6
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/defaultcommand-property.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:39:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-07-03T23:50:19.3460266Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/defaultcommand-property.md
page_type: conceptual
toc_rel: toc.json
word_count: 297
asset_id: lwef/defaultcommand-property
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: d0ef28c0-786e-374c-b4d1-e807c2da56fe
---

# DefaultCommand プロパティ - Win32 apps | Microsoft Learn

[Microsoft Agent は Windows 7 の時点で非推奨となり、後続のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) オブジェクトのデフォルト コマンドを返すか設定します。
- **構文**
    - \*agent.\***Characters** **("*CharacterID*").Commands.DefaultCommand** [ = *string*]

| 部分 | 説明 |
| --- | --- |
| *string* | [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) の名前 (ID) を識別する文字列値。 |

## 解説

このプロパティを使用すると、[**Commands**](/ja-jp/windows/desktop/lwef/the-command-object) コレクションの [**Command**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) をデフォルト コマンドとして設定し、太字で表示できます。 これにより、コマンド処理やダブルクリック イベントが実際に変更されることはありません。

このプロパティは、クライアント アプリケーションによるキャラクターの使用にのみ適用されます。この設定は、キャラクターの他のクライアントやクライアント アプリケーションの他のキャラクターには影響しません。