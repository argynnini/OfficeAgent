---
layout: Conceptual
title: Move Event - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/move-event
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
description: Move Event
ms.assetid: 973e9e68-edbb-4741-b50e-57db96712df8
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 3cb3da57-218d-0e93-0724-b8ec1addc3a1
document_version_independent_id: 7c1e4f7c-03ff-b1c0-e062-31af316e8e50
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/move-event.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/move-event.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 181
asset_id: lwef/move-event
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/move-event.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: cfad8c6a-a037-bf6a-46c2-620d5784d3af
---

# Move Event - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Occurs when a character is moved.
- **Syntax**
    - **Sub***agent*\_**Move (ByVal***CharacterID*, **ByVal***X*, **ByVal***Y*, **ByVal***Cause*\*\*)\*\*

| Part | Description |
| --- | --- |
| *CharacterID* | Returns the ID of the character that moved. |
| *X* | Returns the x-coordinate (in pixels) of the top edge of character frame's new location as an integer. |
| *Y* | Returns the y-coordinate (in pixels) of the left edge of character frame's new location as an integer. |
| *Cause* | Returns a value that indicates what caused the character to move. 1 The user dragged the character. 2 Your client application moved the character. 3 Another client application moved the character. 4 The Agent server moved the character to keep it onscreen after a screen resolution change. |

### Remarks

This event occurs when the user or an application changes the character's position. Coordinates are relevant to the upper left corner of the screen. This event is sent only to the clients of the character (applications that have loaded the character).

**See Also**

[**MoveCause property**](movecause-property), [**Size event**](size-event)