---
layout: Conceptual
title: HasOtherClients プロパティ - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/hasotherclients-property
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: HasOtherClients プロパティ
document_id: edaa8436-e8dd-e042-5367-cfb7398a24ba
document_version_independent_id: 768a4351-44b3-373b-0a12-2081ecd72aa7
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/hasotherclients-property.md
locale: ja-jp
ms.assetid: 5ecc6f42-786b-40a6-8800-9ad0d92edfb2
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/hasotherclients-property.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:43:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/hasotherclients-property.md
page_type: conceptual
toc_rel: toc.json
word_count: 234
asset_id: lwef/hasotherclients-property
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 1ff9e0e8-34a3-1275-3034-4d0c92f352e1
---

# HasOtherClients プロパティ - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 指定した文字が他のアプリケーションで使用されているかどうかを返します。
- **構文の**
    - エージェント *を*します。**Characters("*CharacterID*")。HasOtherClients**

| 価値 | 形容 |
| --- | --- |
| **True** | 文字には他のクライアントがあります。 |
| false **の** | 文字に他のクライアントがありません。 |

## 備考

このプロパティを使用すると、複数のアプリケーションが同じ文字を共有 (読み込んだ) ときに、アプリケーションが文字の唯一のクライアントか最後のクライアントかを判断できます。