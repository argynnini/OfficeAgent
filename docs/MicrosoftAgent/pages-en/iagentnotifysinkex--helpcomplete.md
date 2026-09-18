---
layout: Conceptual
title: IAgentNotifySinkEx HelpComplete - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentnotifysinkex--helpcomplete
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
description: IAgentNotifySinkEx HelpComplete
ms.assetid: f8285d05-3b96-4046-a058-0e001e47b54b
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 6905c3aa-ef72-7a8e-43e3-bb6f04faed86
document_version_independent_id: 6e6f0b90-1dda-2acd-1023-87b1129b77c7
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentnotifysinkex--helpcomplete.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentnotifysinkex--helpcomplete.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 359
asset_id: lwef/iagentnotifysinkex--helpcomplete
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentnotifysinkex--helpcomplete.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 203a3c77-7ba5-d8ca-48f1-a718f083c2ef
---

# IAgentNotifySinkEx HelpComplete - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT HelpComplete(
   long dwCharID,     // character ID
   long dwCommandID,  // command ID
   long dwCause       // cause 
);
```

Notifies a client application when the user selects a command or character to complete Help mode.

- No return value.

- *dwCharID*
    - Identifier of the character for which Help mode completed.
- *dwCommandID*
    - Identifier of the command the user selected.
- *dwCause*
    - The cause for the event, which may be the following values:

| Value | Description |
| --- | --- |
| **const unsigned short** **CSHELPCAUSE\_COMMAND = 1;** | The user selected a command supplied by your application. |
| **const unsigned short** **CSHELPCAUSE\_OTHERPROGRAM = 2;** | The user selected the [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) object of another client. |
| **const unsigned short** **CSHELPCAUSE\_OPENCOMMANDSWINDOW = 3;** | The user selected the Open Voice Commands command. |
| **const unsigned short** **CSHELPCAUSE\_CLOSECOMMANDSWINDOW = 4;** | The user selected the Close Voice Commands command. |
| **const unsigned short** **CSHELPCAUSE\_SHOWCHARACTER = 5;** | The user selected the Show *CharacterName* command. |
| **const unsigned short** **CSHELPCAUSE\_HIDECHARACTER = 6;** | The user selected the Hide *CharacterName* command. |
| **const unsigned short** **CSHELPCAUSE\_CHARACTER = 7;** | The user selected (clicked) the character. |

Typically Help mode completes when the user clicks or drags the character or selects a command from the character's pop-up menu. Clicking on another character or elsewhere on the screen does not cancel Help mode. The client that set Help mode for the character can cancel Help mode by setting [**IAgentCharacter::HelpModeOn**](https://www.bing.com/search?q=**IAgentCharacter::HelpModeOn**) to **False**. (This does not trigger the **IAgentNotifySinkEx::HelpComplete** event.)

When the user selects a command from the character's pop-up menu in Help mode, the server removes the menu, calls Help with the command's specified [**HelpContextID**](helpcontextid-property), and sends this event. The context-sensitive (also known as What's This?) Help window is displayed at the pointer location. If the user selects the command by voice input, the Help window is displayed over the character. If the character is off-screen, the window is displayed on-screen nearest to the character's current position.

If the server returns *dwCommandID* as an empty string (""), it indicates that the user selected a server-supplied command.

This event is sent only to the client application that places the character into Help mode.