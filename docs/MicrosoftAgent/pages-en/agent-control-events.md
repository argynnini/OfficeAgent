---
layout: Conceptual
title: Agent Control Events - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/agent-control-events
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
uhfHeaderId: MSDocsHeader-WinDevCenter
recommendations: true
adobe-target: true
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.author: jken
author: GrantMeStrength
feedback_system: Standard
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_help_link_type: get-help-at-qna
description: Agent Control Events
ms.assetid: 86543cc0-ed1c-41d8-9fc9-cc163e308947
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 51358eb6-5bfe-7718-6dcc-7335d5f70b2e
document_version_independent_id: 7100daf2-3abc-dfa1-eee3-7a5e7a16c347
updated_at: 2025-03-13T17:42:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/agent-control-events.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/agent-control-events.md
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 72
asset_id: lwef/agent-control-events
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/agent-control-events.md
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

# Agent Control Events - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

The Microsoft Agent control provides several events that enable your client application to track the state of the server:

- [**ActivateInput**](activateinput-event)
- [**ActiveClientChange**](activeclientchange-event)
- [**AgentPropertyChange**](agentpropertychange-event)
- [**BalloonHide**](balloonhide-event)
- [**BalloonShow**](balloonshow-event)
- [**Bookmark**](bookmark-event)
- [**Click**](click-event)
- [**Command**](command-event)
- [**DblClick**](dblclick-event)
- [**DeactivateInput**](deactivateinput-event)
- [**DefaultCharacterChange**](defaultcharacterchange-event)
- [**DragComplete**](dragcomplete-event)
- [**DragStart**](dragstart-event)
- [**HelpComplete**](helpcomplete-event)
- [**Hide**](hide-event)
- [**IdleComplete**](idlecomplete-event)
- [**IdleStart**](idlestart-event)
- [**ListenComplete**](listencomplete-event)
- [**ListenStart**](listenstart-event)
- [**Move**](move-event)
- [**RequestComplete**](requestcomplete-event)
- [**RequestStart**](requeststart-event)
- [**Show**](show-event)
- [**Size**](size-event)

The server no longer sends these Restart and Shutdown events.