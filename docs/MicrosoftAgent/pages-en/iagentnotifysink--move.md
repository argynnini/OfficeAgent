---
layout: Conceptual
title: IAgentNotifySink Move - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentnotifysink--move
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
description: IAgentNotifySink Move
ms.assetid: d1809fdb-df4b-4884-b9e8-2877a814dc9a
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 36c0b953-92fc-3fc2-977f-346612ffb985
document_version_independent_id: 6577d529-5971-ee2b-e067-9d4569f7c58f
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentnotifysink--move.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentnotifysink--move.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 225
asset_id: lwef/iagentnotifysink--move
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentnotifysink--move.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: ff0c05e2-2580-aca2-cdfa-48fe6290fb52
---

# IAgentNotifySink Move - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT Move(
   long dwCharID,  // character ID
   long x,         // x-coordinate of new location
   long y,         // y-coordinate of new location
   long dwCause    // cause of move state
);                          
```

Notifies a client application when the character has been moved.

- No return value.

- *dwCharID*
    - Identifier of the character that has been moved.
- *x*
    - The x-coordinate of the new position in pixels, relative to the screen origin (upper left). The location of a character is based on the upper left corner of its animation frame.
- *y*
    - The y-coordinate of the new position in pixels, relative to the screen origin (upper left). The location of a character is based on the upper left corner of its animation frame.
- *dwCause*
    - The cause of the character move. The parameter may be one of the following:

| Value | Description |
| --- | --- |
| **const unsigned short** **NeverMoved = 0;** | Character has not been moved. |
| **const unsigned short** **UserMoved = 1;** | User dragged the character. |
| **const unsigned short** **ProgramMoved = 2;** | Your application moved the character. |
| **const unsigned short** **OtherProgramMoved = 3;** | Another application moved the character. |
| **const unsigned short** **SystemMoved = 4** | The server moved the character to keep it onscreen after a screen resolution change. |

This event is sent to all clients of the character.