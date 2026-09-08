---
layout: Conceptual
title: AutoPopupMenu プロパティ - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/autopopupmenu-property
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: AutoPopupMenu プロパティ
document_id: 2ecfde19-aee5-2cd9-2157-61c439a979a8
document_version_independent_id: 9aed57f6-6bb5-d6f2-7910-7f307b72015b
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/autopopupmenu-property.md
locale: ja-jp
ms.assetid: 499092cb-0990-4edb-915c-12e3011de142
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/autopopupmenu-property.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:37:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/autopopupmenu-property.md
page_type: conceptual
toc_rel: toc.json
word_count: 402
asset_id: lwef/autopopupmenu-property
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: d9bd7d56-c965-312b-999d-062fb1648b51
---

# AutoPopupMenu プロパティ - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 文字またはそのタスク バー アイコンを右クリックして、文字のポップアップ メニューを自動的に表示するかどうかを設定または返します。
- **構文の**
    - エージェント *します。**Characters***("***CharacterID***")。AutoPopupMenu\*\* [ = *boolean*]

| 部分 | 形容 |
| --- | --- |
| ブール | サーバーが文字のポップアップ メニューを右クリックで自動的に表示するかどうかを指定するブール式。 **True** (既定値) 右クリックでメニューを表示します。 **False** 右クリックしてもメニューが表示されません。 |

## 備考

このプロパティを false 設定すると、独自のメニュー処理動作を作成できます。 このプロパティを false 設定した後にメニューを表示するには、[**ShowPopupMenu**](showpopupmenu-method) メソッドを使用します。

このプロパティは、クライアント アプリケーションによる文字の使用にのみ適用されます。この設定は、文字の他のクライアントやクライアント アプリケーションの他の文字には影響しません。