---
layout: Conceptual
title: イベントを移動 - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/move-event
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: イベントを移動
document_id: 3cb3da57-218d-0e93-0724-b8ec1addc3a1
document_version_independent_id: 7c1e4f7c-03ff-b1c0-e062-31af316e8e50
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/move-event.md
locale: ja-jp
ms.assetid: 973e9e68-edbb-4741-b50e-57db96712df8
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/move-event.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:55:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-07-03T23:50:19.3460266Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/move-event.md
page_type: conceptual
toc_rel: toc.json
word_count: 471
asset_id: lwef/move-event
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: cfad8c6a-a037-bf6a-46c2-620d5784d3af
---

# イベントを移動 - Win32 apps | Microsoft Learn

[Microsoft Agent は Windows 7 の時点で非推奨となり、後続のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - キャラクターが移動されたときに発生します。
- **構文**
    - **サブ***エージェント*\_**移動 (ByVal***CharacterID*, **ByVal***X*, **ByVal***Y*, **ByVal***原因*\*\*)\*\*

| 部分 | 説明 |
| --- | --- |
| *CharacterID* | 移動したキャラクターの ID を返します。 |
| *X* | 文字フレームの新しい位置の上端の x 座標 (ピクセル単位) を整数として返します。 |
| *Y* | 文字フレームの新しい位置の左端の y 座標 (ピクセル単位) を整数として返します。 |
| *原因* | キャラクターが移動した原因を示す値を返します。 1 ユーザーがキャラクターをドラッグしました。 2 クライアント アプリケーションが文字を移動しました。 3 別のクライアントアプリケーションが文字を移動しました。 4 エージェント サーバーは、画面解像度の変更後も画面上にキャラクターを表示し続けるためにキャラクターを移動しました。 |

### 解説

このイベントは、ユーザーまたはアプリケーションが文字の位置を変更したときに発生します。 座標は画面の左上隅に関連します。 このイベントは、キャラクターのクライアント (キャラクターをロードしたアプリケーション) にのみ送信されます。

**参照**

[**MoveCause プロパティ**](movecause-property), [**サイズイベント**](size-event)