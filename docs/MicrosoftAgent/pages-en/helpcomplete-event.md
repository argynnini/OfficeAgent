---
layout: Conceptual
title: HelpComplete Event - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/helpcomplete-event
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
description: HelpComplete Event
ms.assetid: d805f089-154f-4b39-9d78-a02b732f87ed
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 63895371-70f0-5bc2-90ad-e8e9018e8b8f
document_version_independent_id: 22db8074-f079-d1d1-b169-0e741b589170
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/helpcomplete-event.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/helpcomplete-event.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 317
asset_id: lwef/helpcomplete-event
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/helpcomplete-event.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 6d5f07be-15d4-0991-701f-cc5c49c87c59
---

# HelpComplete Event - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Indicates that context-sensitive Help mode has been exited.
- **Syntax**
    - **Sub***agent.***(ByVal***CharacterID*\*\*, ByVal\*\* *Name*\*\*, ByVal\*\* *Cause*\*\*)\*\*

| Part | Description |
| --- | --- |
| *CharacterID* | Returns the ID of the clicked character as a string. |
| *Name* | Returns a string value identifying the name (ID) of the command. |
| *Cause* | Returns a value that indicates what caused the Help mode to complete. 1 The user selected a command supplied by your application. 2 The user selected the [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) object of another client. 3 The user selected the Open Voice Commands command. 4 The user selected the Close Voice Commands command. 5 The user selected the Show *CharacterName* command. 6 The user selected the Hide *CharacterName* command. 7 The user selected (clicked) the character. |

### Remarks

Typically, Help mode completes when the user clicks or drags the character or selects a command from the character's pop-up menu. Clicking on another character or elsewhere on the screen does not cancel Help mode. The client that set Help mode for the character can cancel Help mode by setting [**HelpModeOn**](helpmodeon-property) to **False**. (This does not trigger the **HelpComplete** event.)

When the user selects a command from the character's pop-up menu in Help mode, the server removes the menu, calls Help with the command's specified [**HelpContextID**](helpcontextid-property), and sends this event. The context-sensitive (also known as What's This?) Help window is displayed at the pointer location. If the user selects the command by voice input, the Help window is displayed over the character. If the character is off-screen, the window is displayed on-screen nearest to the character's current position.

If the server returns Name as an empty string (""), it indicates that the user selected a server-supplied command.

This event is sent only to the client application that places the character in Help mode.

### See Also

[**HelpModeOn property**](helpmodeon-property), [**HelpContextID property**](helpcontextid-property)