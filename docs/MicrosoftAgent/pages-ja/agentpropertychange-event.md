---
layout: Conceptual
title: AgentPropertyChange イベント - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/agentpropertychange-event
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: AgentPropertyChange イベント
document_id: cbfa9fa3-5679-02e4-a677-bc0f3a7fe614
document_version_independent_id: c6d99547-56ca-c2bf-cd4f-b749477061e7
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/agentpropertychange-event.md
locale: ja-jp
ms.assetid: 56607e9c-99eb-42c1-987a-0f2bc3f82d75
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/agentpropertychange-event.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:37:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/agentpropertychange-event.md
page_type: conceptual
toc_rel: toc.json
word_count: 227
asset_id: lwef/agentpropertychange-event
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 4723c7cf-3cbd-f096-af91-78d01aabba4d
---

# AgentPropertyChange イベント - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

- **Description**
    - ユーザーが [高度な文字オプション] ウィンドウでプロパティを変更したときに発生します。
- **構文**
    - **Sub** \*agent.\***AgentPropertyChange**

### 解説

このイベントは、ユーザーが [文字の詳細設定オプション] ウィンドウに含まれるプロパティを変更して適用したタイミングを示します。

このイベントを処理するためのコードでは、 [AudioOutput](the-audiooutput-object) オブジェクトまたは [SpeechInput](the-speechinput-object) オブジェクトの特定のプロパティ設定に対してクエリを実行できます。

### 参照

[**DefaultCharacterChange イベント**](defaultcharacterchange-event)