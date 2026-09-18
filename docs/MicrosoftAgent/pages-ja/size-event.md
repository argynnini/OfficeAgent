---
layout: Conceptual
title: サイズイベント - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/size-event
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: サイズイベント
document_id: 3c85c388-df28-3590-9bea-56f02df6e7ac
document_version_independent_id: c14f038b-0639-5972-48cb-56a0b21fa3d3
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/size-event.md
locale: ja-jp
ms.assetid: 06089f84-8e75-475f-a492-536c83fa6730
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/size-event.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:00:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-07-03T23:50:19.3460266Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/size-event.md
page_type: conceptual
toc_rel: toc.json
word_count: 282
asset_id: lwef/size-event
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: b3949755-6796-6d7f-bf4f-e3cbe3179fc1
---

# サイズイベント - Win32 apps | Microsoft Learn

[Microsoft Agent は Windows 7 の時点で非推奨となり、後続のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 文字のサイズが変更されたときに発生します。
- **構文**
    - **サブ***エージェント*\_**サイズ (ByVal***キャラクターD*, **ByVal***幅*, **ByVal***高さ*)

| 部分 | 説明 |
| --- | --- |
| *CharacterID* | 移動したキャラクターの ID を返します。 |
| *幅* | 文字フレームの新しい幅（ピクセル単位）を整数として返します。 |
| *高さ* | 文字フレームの新しい高さ（ピクセル単位）を整数として返します。 |

### 解説

このイベントは、アプリケーションが文字のサイズを変更したときに発生します。 このイベントは、キャラクターのクライアント (キャラクターをロードしたアプリケーション) にのみ送信されます。

### 参照

[**イベントを移動**](move-event)