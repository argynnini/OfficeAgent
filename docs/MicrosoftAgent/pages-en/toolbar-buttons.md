---
layout: Conceptual
title: Toolbar Buttons (Linguistic Information Sound Editing Tool) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/toolbar-buttons
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
description: Toolbar Buttons
ms.assetid: 346a55e6-b506-4fd4-9ef8-bf4fbd866dd3
ms.topic: concept-article
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 49b6f7b7-0540-30b9-0ced-9039116150c8
document_version_independent_id: a569bd8b-6de1-4f9d-123e-9d70e72e99bc
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/toolbar-buttons.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/toolbar-buttons.md
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 249
asset_id: lwef/toolbar-buttons
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/toolbar-buttons.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 84c2fd1b-1341-1893-e1ae-960d8f52e9dd
---

# Toolbar Buttons (Linguistic Information Sound Editing Tool) - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

![](images/f9charnew.gif)

- **New**
    - Resets the sound editor for creating a new sound file. If an existing sound file is loaded and has unsaved edits, the sound editor displays a message to determine whether to save or discard unsaved changes.

![](images/f10charopen.gif)

- **Open**
    - Displays the Open File dialog box, enabling you to open an existing sound file. If an existing sound file is loaded and has unsaved edits, the sound editor displays a message to determine whether to save or discard unsaved changes.

![](images/f11charsave.gif)

- **Save**
    - Saves the sound file. If the file does not exist (has not been named), the editor displays the Save As dialog box for input of the filename.

![](images/f14charcut.gif)

- **Cut**
    - Removes the selected text from the editor and places it on the Windows Clipboard.

![](images/f15charcopy.gif)

- **Copy**
    - Copies the selected text in the editor to the Windows Clipboard.

![](images/f16charpaste.gif)

- **Paste**
    - Copies text from the current Windows Clipboard to the selected location in the Text Representation text box.

![](images/f17chardel.gif)

- **Delete**
    - Removes the selected text from the sound editor.

![](images/f18charundo.gif)

- **Undo**
    - Removes a change made in the sound editor.

![](images/f19charredo.gif)

- **Redo**
    - Reverses an undo action in the sound editor.

![](images/flistlinguist.gif)

- **Generate Linguistic Info**
    - Generates phoneme and word labels for the sound file.

![](images/flistpause.gif)

- **Pause**
    - Pauses playing of the sound file.

![](images/flistplay.gif)

- **Play**
    - Plays the sound file or selected portion of the sound file.

![](images/fliststop.gif)

- **Stop**
    - Stops recording or playing the sound file or selected portion of the sound file.

![](images/flistrecord.gif)

- **Record**
    - Starts recording a sound file.