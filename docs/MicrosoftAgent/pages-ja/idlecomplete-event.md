---
layout: Conceptual
title: IdleComplete イベント - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/idlecomplete-event
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IdleComplete イベント
document_id: 1236e58f-7053-db72-c5f3-b17f032ea30d
document_version_independent_id: 255d2dab-dc35-2599-9919-f16e1c9428fd
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/idlecomplete-event.md
locale: ja-jp
ms.assetid: 1d684f75-f23e-4ed8-a60a-5e6792332103
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/idlecomplete-event.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:53:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-07-03T23:50:19.3460266Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/idlecomplete-event.md
page_type: conceptual
toc_rel: toc.json
word_count: 167
asset_id: lwef/idlecomplete-event
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: d705b22f-3d18-0161-62b9-d1a558263cb0
---

# IdleComplete イベント - Win32 apps | Microsoft Learn

[Microsoft Agent は Windows 7 の時点で非推奨となり、後続のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - サーバーがキャラクターの **アイドル** 状態を終了したときに発生します。
- **構文**
    - **サブ***エージェント*\*\*\_IdleComplete\*\* **(ByVal***CharacterID*\*\*)\*\*

| 部分 | 説明 |
| --- | --- |
| *CharacterID* | アイドル状態の文字の ID を文字列として返します。 |

### 解説

サーバーはこのイベントをキャラクターのすべてのクライアントに送信します。

### 参照

[**IdleStart イベント**](idlestart-event)