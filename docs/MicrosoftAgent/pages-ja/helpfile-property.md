---
layout: Conceptual
title: HelpFile プロパティ - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/helpfile-property
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: HelpFile プロパティ
document_id: eff4d749-6042-c0f0-f0e7-8a1b2605647b
document_version_independent_id: 020eee0e-2dec-1365-b381-b25028aad0ca
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/helpfile-property.md
locale: ja-jp
ms.assetid: 18a5fd9b-4ca7-4701-9993-1e0c55f6e232
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/helpfile-property.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:44:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/helpfile-property.md
page_type: conceptual
toc_rel: toc.json
word_count: 488
asset_id: lwef/helpfile-property
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 3b0e0c3b-f07f-7f54-5d42-d31c1349c260
---

# HelpFile プロパティ - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - クライアント アプリケーションによって提供される Microsoft Windows の状況依存ヘルプ ファイルのパスとファイル名を設定または返します。
- **構文の**
    - \*agent.\***Characters("*CharacterID*")。Helpfile** [ = *Filename*]

| 部分 | 形容 |
| --- | --- |
| *ファイル名の* | Windows ヘルプ ファイルのパスとファイル名を指定する文字列式。 |

## 備考

アプリケーション用に Windows ヘルプ ファイルを作成し、文字の **HelpFile** プロパティを設定した場合、[**HelpModeOn**](helpmodeon-property) が **True** に設定され、ユーザーが文字をクリックするか、ポップアップ メニューからコマンドを選択すると、エージェントは自動的にヘルプを呼び出します。 選択したコマンドの [**HelpContextID**](helpcontextid-property) プロパティにコンテキスト番号を指定した場合、ヘルプには現在のヘルプ コンテキストに対応するトピックが表示されます。それ以外の場合は、"このアイテムに関連付けられているヘルプ トピックがありません" と表示されます。

このプロパティは、クライアント アプリケーションによる文字の使用にのみ適用されます。この設定は、文字の他のクライアントやクライアント アプリケーションの他の文字には影響しません。