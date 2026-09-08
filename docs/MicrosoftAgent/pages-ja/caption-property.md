---
layout: Conceptual
title: Caption プロパティ (Command オブジェクト) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/caption-property
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Command オブジェクトの Caption プロパティについて説明します。 Microsoft エージェントは、Windows 7 の時点で非推奨です。
document_id: 3bf289e2-9d7a-20a9-12f1-2e8634d220ab
document_version_independent_id: 3e752056-b263-bd02-07bd-03f5f6062685
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/caption-property.md
locale: ja-jp
ms.assetid: 8dcdf3e0-3111-438b-9d39-ba9a36437ad2
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/caption-property.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:37:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-01-09T19:49:59.6397822Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/caption-property.md
page_type: conceptual
toc_rel: toc.json
word_count: 237
asset_id: lwef/caption-property
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 78564a42-593f-7431-89f1-8cda6391f65f
---

# Caption プロパティ (Command オブジェクト) - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 指定した文字のポップアップ メニューで [**コマンド**](/ja-jp/windows/desktop/lwef/the-command-object) に表示されるテキストを指定します。
- **構文の**
    - エージェント \*\* です。characters ("***CharacterID***")。Commands("***名***")。Caption\*\* [ = *string*]

| 部分 | 形容 |
| --- | --- |
| 文字列 *を* する | **コマンド**のキャプションとして表示されるテキストに評価される文字列式。 |

## 備考

**Caption**のアクセス キー (線なしニーモニック) を指定するには、その文字の前にアンパサンド (&) 文字を含めます。

コマンドに **VoiceCaption** を定義しない場合は、**Caption** 設定が使用されます。