---
layout: Conceptual
title: HelpModeOn Property - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/helpmodeon-property
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
description: HelpModeOn Property
ms.assetid: 4a9b5fd3-12e2-489b-8ce0-9b66b01f517a
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: c2b099d7-cfc2-ca6f-46bc-fa69bc19b4c2
document_version_independent_id: 179fec8a-2402-0370-70ca-6d41219bd159
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/helpmodeon-property.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/helpmodeon-property.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 204
asset_id: lwef/helpmodeon-property
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/helpmodeon-property.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 4a0e94fc-1fb5-def3-9155-71e2a8b3cfcd
---

# HelpModeOn Property - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Returns or sets whether context-sensitive Help mode is on for the character.
- **Syntax**
    - \*agent.\***Characters("*CharacterID*").HelpModeOn** [ = *boolean*]

| Part | Description |
| --- | --- |
| *boolean* | A Boolean expression specifying whether context-sensitive Help mode is on. **True** Help mode is on. **False** (Default) Help mode is off. |

## Remarks

When you set this property to **True**, the mouse pointer changes to the context-sensitive Help image when moved over the character or over the pop-up menu for the character. When the user clicks or drags the character or clicks an item in the character's pop-up menu, the server triggers the [**HelpComplete**](helpcomplete-event) event and exits Help mode.

In Help mode, the server does not send the [**Click**](click-event), [**DragStart**](dragstart-event), [**DragComplete**](dragcomplete-event), and [**Command**](command-event) events, unless you set the [**AutoPopupMenu**](autopopupmenu-property) property to **True**. In that case, the server will send the **Click** event (does not exit Help mode), but only for the right mouse button to enable you to display the pop-up menu.

This property applies only to your client application's use of the character; the setting does not affect other clients of the character or other characters of your client application.