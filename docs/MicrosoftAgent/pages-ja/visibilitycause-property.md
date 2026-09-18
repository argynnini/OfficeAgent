---
layout: Conceptual
title: VisibilityCause プロパティ - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/visibilitycause-property
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: VisibilityCause プロパティ
document_id: cc70eb92-ec92-e55c-aef0-f2eecd2fc4a5
document_version_independent_id: 29a64768-c592-c5cd-36cc-236de1fbb5d6
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/visibilitycause-property.md
locale: ja-jp
ms.assetid: 106574ef-af5f-44cf-9efb-9e6da19ebc1f
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/visibilitycause-property.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:03:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/visibilitycause-property.md
page_type: conceptual
toc_rel: toc.json
word_count: 459
asset_id: lwef/visibilitycause-property
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: c12ecaa0-7a8c-5d8b-d571-ee57205b544a
---

# VisibilityCause プロパティ - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 文字の表示状態の原因を指定する整数値を返します。
- **構文の**
    - エージェント *を*します。**Characters("*CharacterID*")。VisibilityCause**

| 価値 | 形容 |
| --- | --- |
| 0 | 文字が表示されていません。 |
| 1 | ユーザーは、文字のタスク バー アイコンのポップアップ メニューのコマンドを使用するか、音声入力を使用して、文字を非表示にしました。 |
| 2 | ユーザーが文字を表示しました。 |
| 3 | アプリケーションが文字を隠しました。 |
| 4 | アプリケーションに文字が表示されました。 |
| 5 | 別のクライアント アプリケーションが文字を隠しました。 |
| 6 | 別のクライアント アプリケーションに文字が表示されました。 |
| 7 | ユーザーは、文字のポップアップ メニューのコマンドを使用して文字を隠しました。 |

## 備考

このプロパティを使用すると、複数のアプリケーションが同じ文字を共有 (読み込んだ) ときに文字が移動する原因を特定できます。 これらの値は、[**Show**](show-event) イベントおよび [**Hide**](hide-event) イベントによって返されるものと同じです。