---
layout: Conceptual
title: イベントを表示 - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/show-event
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: イベントを表示
document_id: 8e3366e5-33e4-45a3-6c75-83c16d3187b9
document_version_independent_id: 0a1b5be5-9de2-f2f8-8d18-bade92c2ddea
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/show-event.md
locale: ja-jp
ms.assetid: vs|msagent|~\pacontrol_7wrw.htm
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/show-event.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:00:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-07-03T23:50:19.3460266Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/show-event.md
page_type: conceptual
toc_rel: toc.json
word_count: 302
asset_id: lwef/show-event
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 42bc79c6-48c5-fb4b-b50a-6ccf9caee967
---

# イベントを表示 - Win32 apps | Microsoft Learn

[Microsoft Agent は Windows 7 の時点で非推奨となり、後続のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 文字が表示されるときに発生します。
- **構文**
    - **サブ***エージェント*\*\*\_Show (ByVal\*\* *CharacterID*, **ByVal***原因*\*\*)\*\*

| 部分 | 説明 |
| --- | --- |
| *CharacterID* | 表示される文字の ID を文字列として返します。 |
| *原因* | 文字が表示された原因を示す値を返します。 2 ユーザーは（メニューまたは音声コマンドを使用して）文字を表示しました。 4 クライアント アプリケーションに文字が表示されました。 6 別のクライアント アプリケーションに文字が表示されました。 |

### 解説

サーバーは、このイベントをキャラクターのすべてのクライアントに送信します。 キャラクターの現在の状態を照会するには、[**Visible**](visible-property) プロパティを使用します。

### 参照

[**イベントを非表示**](hide-event), [**VisibilityCause**](visibilitycause-property)