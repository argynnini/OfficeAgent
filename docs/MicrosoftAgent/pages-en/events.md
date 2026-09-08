---
layout: Conceptual
title: IAgentNotifySink - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/events
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
description: IAgentNotifySink
ms.assetid: vs|msagent|~\paface_2xet.htm
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 5365cf38-fd37-eb4d-1587-78288aadbf7c
document_version_independent_id: 69d15307-d777-fe16-a3e4-414a3fec8dd5
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/events.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/events.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 196
asset_id: lwef/events
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/events.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: fef37f4b-b4b3-aeaf-99b0-fb5e6db6123e
---

# IAgentNotifySink - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

IAgentNotifySink notifies clients when certain state changes occur. These functions are also available from [IAgentNotifySinkEx](iagentnotifysinkex).

**Methods in Vtable Order**

| IAgentNotifySink | Description |
| --- | --- |
| [**Command**](command-method) | Occurs when the server processes a client-defined command. |
| [**ActivateInputState**](iagentnotifysink--activateinputstate) | Occurs when a character becomes or ceases to be input-active. |
| [**BalloonVisibleState**](iagentnotifysink---balloonvisiblestate) | Occurs when the character's **Visible** state changes. |
| [**Click Event**](click-event) | Occurs when a character is clicked. |
| [**DblClick Event**](dblclick-event) | Occurs when a character is double-clicked. |
| [**DragStart**](/en-us/windows/desktop/lwef/dragstart-event) | Occurs when a user starts dragging a character. |
| [**DragComplete**](https://www.bing.com/search?q=**DragComplete**) | Occurs when a user stops dragging a character. |
| [**RequestStart**](iagentnotifysink--requeststart) | Occurs when the server begins processing a [**Request**](/en-us/windows/desktop/lwef/the-request-object) object. |
| [**RequestComplete**](iagentnotifysink--requestcomplete) | Occurs when the server completes processing a [**Request**](/en-us/windows/desktop/lwef/the-request-object) object. |
| [**Bookmark**](iagentnotifysink--bookmark) | Occurs when the server processes a bookmark. |
| [**Idle**](iagentnotifysink--idle) | Occurs when the server starts or ends idle processing. |
| [**Move**](iagentnotifysink--move) | Occurs when a character has been moved. |
| [**Size**](iagentnotifysink---size) | Occurs when a character has been resized. |
| [**BalloonVisibleState**](iagentnotifysink---balloonvisiblestate) | Occurs when the visibility state of a character's word balloon changes. |

The IAgentNotifySink::Restart and IAgentNotifySink::Shutdown events, supported in earlier versions of Microsoft Agent, are now obsolete. While supported for backward compatibility, the server no longer sends these events.