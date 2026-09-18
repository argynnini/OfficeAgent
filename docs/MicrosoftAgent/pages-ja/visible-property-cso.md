---
layout: Conceptual
title: Visible プロパティ (Commands オブジェクト) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/visible-property-cso
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Commands コレクションのキャプションが文字のポップアップ メニューに表示されるかどうかを決定する Commands オブジェクトの Visible プロパティについて説明します。
document_id: 5dfa001d-3dd0-e900-36a1-de0a29884f84
document_version_independent_id: 52700b16-4d75-e74b-fc7d-db1fdc07d8e0
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/visible-property-cso.md
locale: ja-jp
ms.assetid: 0178a789-141b-4d4c-ba7c-05c7995f13bc
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/visible-property-cso.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:04:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/visible-property-cso.md
page_type: conceptual
toc_rel: toc.json
word_count: 379
asset_id: lwef/visible-property-cso
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 6b328c6d-666e-ba46-f8d7-a6c0f13c40e4
---

# Visible プロパティ (Commands オブジェクト) - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションのキャプションが文字のポップアップ メニューに表示されるかどうかを示す値を取得または設定します。
- **構文の**
    - エージェント \*\* です。Characters(**"*CharacterID*"**).Commands.Visible\*\* [ = *boolean*]

| 部分 | 形容 |
| --- | --- |
| ブール | [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) オブジェクトが文字のポップアップ メニューに表示されるかどうかを指定するブール式。 **True** キャプションが表示されます。**False** キャプションは表示されません。 |

## 備考

アプリケーションが入力アクティブなクライアントでないときに文字のポップアップ メニューにキャプションを表示するには、このプロパティを **True** に設定し、Commands コレクションの [**Caption**](caption-property) プロパティを設定する必要があります。 さらに、このプロパティを **True に設定する必要があります True アプリケーションがアクティブな場合にポップアップ メニューに表示するコレクション内のコマンドの** します。