---
layout: Conceptual
title: DblClick Event - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/dblclick-event
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
description: DblClick Event
ms.assetid: 81ed5396-a2dc-49fe-820f-61ca0935fe85
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 191186e1-75f4-8513-7d9a-1cacf0dca3a7
document_version_independent_id: d5cf0046-a104-e28b-ded2-a73b42df1976
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/dblclick-event.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/dblclick-event.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 390
asset_id: lwef/dblclick-event
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/dblclick-event.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: c3f1174b-4375-b6e4-9fa2-87a0fd7c9ef9
---

# DblClick Event - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Occurs when the user double-clicks a character.
- **Syntax**
    - **Sub***agent*\*\*\_DblClick\*\* **(ByVal***CharacterID*, **ByVal***Button*, **ByVal***Shift*, **ByVal***X*, **ByVal***Y*\*\*)\*\*

| Part | Description |
| --- | --- |
| *CharacterID* | Returns the ID of the double-clicked character as a string. |
| *Button* | Returns an integer that identifies the button that was pressed and released to cause the event. The button argument is a bitfield with bits corresponding to the left button (bit 0), right button (bit 1), and middle button (bit 2). These bits correspond to the values 1, 2, and 4, respectively. Only one of the bits is set, indicating the button that caused the event. If the character includes a taskbar icon, if bit 13 is also set, the click occurred on the taskbar icon. |
| *Shift* | Returns an integer that corresponds to the state of the SHIFT, CTRL, and ALT keys when the button specified in the button argument is pressed or released. A bit is set if the key is down. The shift argument is a bitfield with the least-significant bits corresponding to the SHIFT key (bit 0), the CTRL key (bit 1), and the ALT key (bit 2). These bits correspond to the values 1, 2, and 4, respectively. The shift argument indicates the state of these keys. Some, all, or none of the bits can be set, indicating that some, all, or none of the keys are pressed. For example, if both CTRL and ALT were pressed, the value of shift would be 6. |
| *X,Y* | Returns an integer that specifies the current location of the mouse pointer. The X and Y values are always expressed in pixels, relative to the upper-left corner of the screen. |

### Remarks

This event is sent only to the input-active client of a character. When the user double-clicks a character or its taskbar icon with no input-active client, the server sends the event to its last input-active client. If the character is visible ([Visible](visible-property) = **True**), then it also sets the active client as the current input-active client, sending the [**ActivateInput**](activateinput-event) event to that client, and then sending the **DblClick** event. If the character is hidden (Visible = **False**) and the user double-clicks the character's taskbar icon using button 1, it also automatically shows the character.