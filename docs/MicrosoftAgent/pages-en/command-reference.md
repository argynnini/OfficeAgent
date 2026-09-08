---
layout: Conceptual
title: Command Reference (Linguistic Information Sound Editing Tool) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/command-reference
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
description: This command reference describes the Linguistic Information Sound Editing Tool. Microsoft Agent is deprecated as of Windows 7.
ms.assetid: 084f14ee-6774-46e2-a4ec-92f480f2f74a
ms.topic: concept-article
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 14c4387b-9746-fb58-f546-71f00bc49ddf
document_version_independent_id: 817e4c54-e8ef-b789-4f06-8e240cd21d09
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/command-reference.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/command-reference.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 563
asset_id: lwef/command-reference
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/command-reference.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 793d8b17-afe3-c738-2521-9b054bbfc062
---

# Command Reference (Linguistic Information Sound Editing Tool) - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

### The File Menu

- **New**
    - Resets the sound editor for creating a new enhanced sound file. If an existing sound file is loaded and has unsaved edits, the sound editor displays a message to determine whether to save or discard unsaved changes.
- **Open**
    - Displays the Open dialog box, enabling you to open an existing sound file. If an existing sound file is loaded and has unsaved edits, the sound editor displays a message to determine whether to save or discard unsaved changes.
- **Save**
    - Saves a sound file. If the sound file does not exist (has not been named), the sound editor displays the Save As dialog box for input of the filename.
- **Save As**
    - Displays the Save As dialog box, enabling you to enter a new name for the sound file.
- **Save Selection As**
    - Displays the Save Selection As dialog box, enabling you to enter a name for the selected part of the sound file.
- **Most Recently Open Files**
    - Keeps track of the recent character definition files you opened. Choosing a file automatically opens that file for editing. If an existing character is loaded and has unsaved edits to a file, the sound editor displays a message to determine whether to save or discard unsaved changes.
- **Exit**
    - Quits the sound editor. If an existing file is loaded and has unsaved edits, the sound editor displays a message to determine whether to save or discard unsaved changes.

### The Edit Menu

- **Undo**
    - Removes a change made in the sound editor.
- **Redo**
    - Reverses an undo action in the sound editor.
- **Cut**
    - Removes the selected text and places it on the clipboard.
- **Copy**
    - Copies the selected text to the clipboard.
- **Paste**
    - Copies text on the clipboard to the insertion point or selection in the Text Representation text box.
- **Delete**
    - Removes the selected text.
- **Select All**
    - Selects the text in the Text Representation text box.
- **Generate Linguistic Info**
    - Begins generating word-break and phoneme information for a sound file.
- **Insert Phoneme**
    - Displays the Insert Phoneme dialog box that enables you to insert a selected phoneme label.
- **Replace Phoneme**
    - Displays the Replace Phoneme dialog box that enables you to replace the selected phoneme label.
- **Delete Phoneme**
    - Deletes the selected phoneme label.
- **Insert Word**
    - Displays the Insert Word dialog box that enables you to insert a word label in the Audio Representation.
- **Replace Word**
    - Displays the Replace Word dialog box that enables you to replace the selected word label in the Audio Representation.
- **Delete Word**
    - Deletes the selected word label in the Audio Representation.
- **Phoneme Label Display**
    - Changes the phoneme label display between descriptive names and IPA byte values.
- **Speech Engine**
    - Enables you to change the speech engine you use to generate the word break and phoneme information.

### The Audio Menu

- **Play**
    - Plays the sound file or selected portion of the sound file.
- **Record**
    - Records a new sound file.
- **Pause**
    - Pauses the play of the sound file or selected portion of the sound file. Use Play to resume playing.
- **Stop**
    - Stops recording or playing the sound file or selected portion of the sound file.

### The Help Menu

- **Help Topics**
    - Displays the Help Topics dialog box, enabling you to select a sound editor help topic.
- **About Microsoft Linguistic Sound Editing Tool**
    - Displays a dialog box with copyright and version information for the sound editor.