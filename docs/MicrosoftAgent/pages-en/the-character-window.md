---
layout: Conceptual
title: The Character Window - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/the-character-window
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
description: The Character Window
ms.assetid: 92b6111f-b52d-4720-8bd9-59585d826bf5
ms.topic: concept-article
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 983b6634-47d0-c9df-993f-b731d3ba473c
document_version_independent_id: 71d46f35-8c7f-0422-0bd9-c6cec49df569
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/the-character-window.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/the-character-window.md
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 260
asset_id: lwef/the-character-window
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/the-character-window.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 8fd157bd-bfed-7299-3860-d965a7f57335
---

# The Character Window - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

Microsoft Agent displays animated characters in their own windows that always appear at the top of the window z-order (that is, always on top). A user can move a character's window by dragging the character with the left mouse button. The character image moves with the pointer. In addition, an application can move a character using the [**MoveTo**](moveto-method) method.

When the user right-clicks a character, a pop-up menu appears that displays the following commands:

Open | Close Voice Commands Window

Hide

----------------------------…

Command\*

*OtherHostingApplicationCaption\*\**

\*Commands listed are based on the input-active client. For more information on defining commands that appear in the pop-up menu, see The Microsoft Agent Programming Interface Overview.

\*\*Entries listed are all other applications currently hosting the character. For more information on defining this entry, see The Microsoft Agent Programming Interface Overview.

The Open | Close Voice Commands Window command controls the display of the Commands Window of the current active character. If speech recognition services are disabled, this command is disabled. If speech recognition services are not installed, this command does not appear.

The Hide command hides the character. The animation assigned to the character's **Hiding** state plays and hides the character. The letter "H" in hide is the command's access key (mnemonic).

The commands for the application(s) currently hosting the character follow the Hide command, preceded by a separator. Then the names of other applications using the character appear, also preceded by a separator.