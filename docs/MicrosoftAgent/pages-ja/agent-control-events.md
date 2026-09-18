---
layout: Conceptual
title: エージェントコントロールイベント - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/agent-control-events
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: エージェントコントロールイベント
document_id: 51358eb6-5bfe-7718-6dcc-7335d5f70b2e
document_version_independent_id: 7100daf2-3abc-dfa1-eee3-7a5e7a16c347
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/agent-control-events.md
locale: ja-jp
ms.assetid: 86543cc0-ed1c-41d8-9fc9-cc163e308947
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/agent-control-events.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:36:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/agent-control-events.md
page_type: conceptual
toc_rel: toc.json
word_count: 210
asset_id: lwef/agent-control-events
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 49de1be5-2b2e-7fa0-0b2f-361d38c66c28
---

# エージェントコントロールイベント - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

Microsoft エージェント コントロールには、クライアント アプリケーションがサーバーの状態を追跡できるようにするいくつかのイベントが用意されています。

- ActivateInput**[の](activateinput-event)**
- ActiveClientChange**[の](activeclientchange-event)**
- [**AgentPropertyChange**](agentpropertychange-event)
- [**BalloonHide**](balloonhide-event)
- [**BalloonShow**](balloonshow-event)
- [**ブックマーク**](bookmark-event)
- [**クリック**](click-event)
- [**コマンド**](command-event)
- [**DblClick**](dblclick-event)
- DeactivateInput**[の](deactivateinput-event)**
- DefaultCharacterChange**[の](defaultcharacterchange-event)**
- [**DragComplete**](dragcomplete-event)
- [**DragStart**](dragstart-event)
- [**HelpComplete**](helpcomplete-event)
- を非表示にする
- [**IdleComplete**](idlecomplete-event)
- [**IdleStart**](idlestart-event)
- ListenComplete**[の](listencomplete-event)**
- [**ListenStart**](listenstart-event)
- [**移動**](move-event)
- [**RequestComplete**](requestcomplete-event)
- [**RequestStart**](requeststart-event)
- の表示
- [**サイズ**](size-event)

サーバーは、これらの再起動イベントとシャットダウン イベントを送信しなくなりました。