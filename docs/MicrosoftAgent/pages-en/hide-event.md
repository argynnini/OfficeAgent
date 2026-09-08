---
layout: Conceptual
title: Hide Event - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/hide-event
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
description: Hide Event
ms.assetid: vs|msagent|~\pacontrol_9yuk.htm
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: c0ec16cc-68da-fc3e-a91d-37213b3f3ac6
document_version_independent_id: 7e064321-c504-2bf2-2bde-97529e837563
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/hide-event.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/hide-event.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 135
asset_id: lwef/hide-event
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/hide-event.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 8f321989-68f0-c4f4-5b8c-1b58a8e53df6
---

# Hide Event - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Occurs when a character is hidden.
- **Syntax**
    - **Sub***agent*\*\*\_Hide(\*\* **ByVal***CharacterID*, **ByVal***Cause*\*\*)\*\*

| Part | Description |
| --- | --- |
| *CharacterID* | Returns the ID of the hidden character as a string. |
| *Cause* | Returns a value that indicates what caused the character to hide. 1 User hid the character by selecting the command on the character's taskbar icon pop-up menu or using speech input. 3 Your client application hid the character. 5 Another client application hid the character. 7 User hid the character by selecting the command on the character's pop-up menu. |

### Remarks

The server sends this event to all clients of the character. To query the current state of the character, use the [**Visible**](visible-property) property.

### See Also

[**Show event**](show-event), [**VisibilityCause**](visibilitycause-property)