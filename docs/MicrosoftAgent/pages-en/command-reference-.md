---
layout: Conceptual
title: Command Reference (Microsoft Agent Character Editor) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/command-reference-
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
description: This command reference describes the Microsoft Agent Character Editor. Microsoft Agent is deprecated as of Windows 7.
ms.assetid: c8d57500-ad29-4325-aec7-3f857990b28c
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 69f823dc-3f48-521f-cfbe-202602063714
document_version_independent_id: 60d8f3ec-1d7b-2d27-5763-b59127c22728
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/command-reference-.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/command-reference-.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 498
asset_id: lwef/command-reference-
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/command-reference-.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 7fc6c24b-f9f8-6af3-bba8-125f74db0dd8
---

# Command Reference (Microsoft Agent Character Editor) - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

## The File Menu

- **New**
    - Resets the Agent Character Editor for creating a new character definition. If an existing character is loaded and has unsaved edits, the Editor displays a message to determine whether to save or discard unsaved changes.
- **Open**
    - Displays the Open File dialog box, enabling you to open an existing character definition file for editing. If an existing character is loaded and has unsaved edits to a file, the Editor displays a message to determine whether to save or discard unsaved changes.
- **Save**
    - Saves the character definition. If the character definition does not exist (has not been named), the Editor displays the Save As dialog box for input of the filename.
- **Save As**
    - Displays the Save As dialog box, enabling you to enter a new name for the character definition file.
- **Print**
    - Displays the Print dialog box, enabling you to choose a printing option and to print the character definition file.
- **Build Character**
    - Displays the Build Character dialog box, which includes options for defining how to build a character's data and animation files for use with Microsoft Agent.
- **Page Setup**
    - Displays the Page Setup dialog box that enables you to set the printing options for the character definition file.
- **Most Recently Open Files**
    - Keeps track of the recent character definition files you opened. Choosing a file automatically opens that file for editing. If an existing character is loaded and has unsaved edits to a file, the Editor displays a message to determine whether to save or discard unsaved changes.
- **Exit**
    - Quits the Agent Character Editor. If an existing character is loaded and has unsaved edits to a file, the Editor displays a message to determine whether to save or discard unsaved changes.

## The Edit Menu

- **Undo**
    - Removes a change made in the Editor.
- **Redo**
    - Reverses an undo action in the Editor.
- **Cut**
    - Removes the selected item from the Editor and places it on the Windows Clipboard.
- **Copy**
    - Copies the selected item in the Editor to the Windows Clipboard.
- **Paste**
    - Copies data from the current Windows Clipboard to the selected location.
- **Delete**
    - Removes the selected item from the Editor.
- **New Animation**
    - Creates a new animation object in the Editor.
- **New Frame**
    - Creates a new frame for an animation.
- **New Frames from Files**
    - Displays the Select Image Files dialog box and creates frames using the selected files.
- **Open Frame Window**
    - Displays the current frame and its images in a separate window without scaling the images loaded into the frame.
- **Preview | Stop Preview**
    - Plays (or stops playing) an animation, starting from its selected frame.
- **Preview | Stop Preview Exit Branching**
    - Plays (or stops playing) an animation's exit branching, starting from its selected frame.

## The Help Menu

- **Help Topics**
    - Displays the Help Topics dialog box, enabling you to select an Editor help topic.
- **About Microsoft Agent Character Editor**
    - Displays a dialog box with copyright and version information for the Editor.