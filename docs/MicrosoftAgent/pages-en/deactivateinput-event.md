---
layout: Conceptual
title: DeactivateInput Event - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/deactivateinput-event
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
description: DeactivateInput Event
ms.assetid: 59747932-82be-45d5-8465-73798904e8a7
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: a6b350e1-c92f-6338-d80a-1a9973a8855b
document_version_independent_id: dca14518-5ee4-0a50-fda0-cac71778daf0
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/deactivateinput-event.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/deactivateinput-event.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 157
asset_id: lwef/deactivateinput-event
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/deactivateinput-event.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 6254d756-e59d-1eea-f158-4a6d3c23a200
---

# DeactivateInput Event - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Occurs when a client becomes non-input-active.
- **Syntax**
    - **Sub***agent*\*\*\_DeactivateInput\*\* **(ByVal***CharacterID*\*\*)\*\*

| Part | Description |
| --- | --- |
| *CharacterID* | Returns the ID of the character that makes the client become non-input-active. |

### Remarks

A non-input-active client no longer receives mouse or speech events from the server (unless it becomes input-active again). The server sends this event only to the client that becomes non-input-active.

This event occurs when your client application is input-active and the user chooses the caption of another client in a character's pop-up menu or the Voice Commands Window or you call the [**Activate**](activate-method) method and set the **State** parameter to 0. It may also occur when the user selects the name of another character by clicking or speaking. You also get this event when your character is hidden or another character becomes visible.

### See Also

[**ActivateInput event**](activateinput-event)