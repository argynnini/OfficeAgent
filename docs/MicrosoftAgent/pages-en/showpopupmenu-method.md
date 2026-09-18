---
layout: Conceptual
title: ShowPopupMenu Method - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/showpopupmenu-method
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
description: ShowPopupMenu Method
ms.assetid: 7f964d53-2594-41b1-9450-1ba7e9f85882
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 38ed5b21-a7e1-93f2-0492-add87d9a48f7
document_version_independent_id: e6bdf577-a307-45ac-2593-1fdfae89894d
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/showpopupmenu-method.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/showpopupmenu-method.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 221
asset_id: lwef/showpopupmenu-method
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/showpopupmenu-method.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 32a2fe21-d189-1bc0-c540-e9ac4a80805c
---

# ShowPopupMenu Method - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Displays the character's pop-up menu at the specified location.
- **Syntax**
    - *agent.**Characters("CharacterID").ShowPopupMenu**x, y*

| Part | Description |
| --- | --- |
| *x* | Required. An integer value that indicates the horizontal (*x*) screen coordinate to display the menu. These coordinates must be specified in pixels. |
| *y* | Required. An integer value that indicates the vertical (*y*) screen coordinate to display the menu. These coordinates must be specified in pixels. |

## Remarks

Agent automatically displays the character's pop-up menu when the user right-clicks the character. If you set [**AutoPopupMenu**](autopopupmenu-property) to **False**, you can use this method to display the menu.

The menu remains displayed until the user selects a command or displays another menu. Only one pop-up menu can be displayed at a time; therefore, calls to this method will cancel (remove) the former menu.

This method should be called only when your client application is the active client of the character; otherwise it fails. To determine the success of this method you can call it as a function and it will return a Boolean value indicating whether the method succeeded.

```
   If Genie.ShowPopupMenu (10,10) = True Then
      ' The menu will be displayed

   Else 
      ' The menu will not be displayed

   End If
```