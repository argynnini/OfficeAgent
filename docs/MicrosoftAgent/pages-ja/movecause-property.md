---
layout: Conceptual
title: MoveCause プロパティ - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/movecause-property
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: MoveCause プロパティ
document_id: 1bd286fe-ffdc-a5c2-3dc8-39411e8c4da4
document_version_independent_id: d3188639-6166-665c-3bb0-c25db5425403
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/movecause-property.md
locale: ja-jp
ms.assetid: 8f78a6da-8498-4a39-a4b9-5ab7a43d97f5
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/movecause-property.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:55:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/movecause-property.md
page_type: conceptual
toc_rel: toc.json
word_count: 337
asset_id: lwef/movecause-property
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 22801d54-e382-31e4-9595-7fd92ed189a6
---

# MoveCause プロパティ - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 文字の最後の移動の原因を指定する整数値を返します。
- **構文の**
    - エージェント *を*します。**Characters("*CharacterID*")。MoveCause**

| 価値 | 形容 |
| --- | --- |
| 0 | 文字が移動されていません。 |
| 1 | ユーザーが文字を移動しました。 |
| 2 | アプリケーションによって文字が移動されました。 |
| 3 | 別のクライアント アプリケーションが文字を移動しました。 |
| 4 | エージェント サーバーは、画面の解像度が変更された後も画面に表示され続けるために文字を移動しました。 |

## 備考

このプロパティを使用すると、複数のアプリケーションが同じ文字を共有 (読み込んだ) ときに、文字が移動する原因を特定できます。 これらの値は、[**Move**](move-event) イベントによって返されるものと同じです。