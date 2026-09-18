---
layout: Conceptual
title: HelpContextID プロパティ (Commands コレクション オブジェクト) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/helpcontextid-property
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Commands コレクション オブジェクトの HelpContextID プロパティについて説明します。 Microsoft エージェントは、Windows 7 の時点で非推奨です。
document_id: 62c64114-8945-53ae-8a01-99ff02077360
document_version_independent_id: 12c5d981-8ca5-8e11-b7a0-777241dfd780
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/helpcontextid-property.md
locale: ja-jp
ms.assetid: 8b8ac1c6-1a34-45f1-a0a6-2ae14ad6adef
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/helpcontextid-property.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:43:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/helpcontextid-property.md
page_type: conceptual
toc_rel: toc.json
word_count: 438
asset_id: lwef/helpcontextid-property
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 9dfdf9cd-f174-4ce9-960a-3c135a9f7b7c
---

# HelpContextID プロパティ (Commands コレクション オブジェクト) - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) オブジェクトに関連付けられたコンテキスト番号を設定または返します。 **Commands** オブジェクトに状況依存のヘルプを提供するために使用します。
- **構文の**
    - \*agent.\***Characters("*CharacterID*")。Commands("*名前*").HelpContextID** [ = *Number*]

| 部分 | 形容 |
| --- | --- |
| *数値* | 有効なコンテキスト番号を指定する整数。 |

## 備考

アプリケーション用に Windows ヘルプ ファイルを作成し、文字の [**HelpFile**](helpfile-property) プロパティを設定した場合、[**HelpModeOn**](helpmodeon-property) が true **に設定され、ユーザーが**[**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) オブジェクトを選択すると、自動的にヘルプが呼び出されます。 **HelpContextID**でコンテキスト番号を設定すると、エージェントはヘルプを呼び出し、そのコンテキスト番号で識別されたトピックを検索します。

このプロパティは、クライアント アプリケーションによる文字の使用にのみ適用されます。この設定は、文字の他のクライアントやクライアント アプリケーションの他の文字には影響しません。

手記

ヘルプ ファイルをビルドするには、Microsoft Windows ヘルプ コンパイラが必要です。