---
layout: Conceptual
title: Toolbar Buttons (Microsoft Agent Character Editor) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/toolbar-buttons-
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
description: Learn about the Microsoft Agent Character Editor toolbar buttons, such as the New Custom Character button.
ms.assetid: 8867a038-d2c4-43c1-b994-bd3779a251b9
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 1659ee53-4bcb-9a76-712a-6ca78b81cb6d
document_version_independent_id: 2b54f465-0ba2-6f76-fbaa-8d32ac415e76
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/toolbar-buttons-.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/toolbar-buttons-.md
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 342
asset_id: lwef/toolbar-buttons-
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/toolbar-buttons-.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: c9da0115-f571-3b3a-0a84-bb6844916ac6
---

# Toolbar Buttons (Microsoft Agent Character Editor) - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

![](images/f9charnew.gif)

- **New Custom Character**
    - Resets the Editor for creating a new Custom character definition. If an existing character is loaded and has unsaved edits to a file(s), the Editor displays a message to determine whether to save or discard unsaved changes.

![](images/f10charopen.gif)

- **Open Character Definition**
    - Displays the Open File dialog box, enabling you to open an existing character definition file for editing. If an existing character is loaded and has unsaved edits to a file(s), the Editor displays a message to determine whether to save or discard unsaved changes.

![](images/f11charsave.gif)

- **Save Character Definition**
    - Saves the character definition. If the character definition does not exist (has not been named), the Editor displays the Save As dialog box for input of the filename.

![](images/f12charbuild.gif)

- **Build Character**
    - Builds a Microsoft Agent character from the character definition.

![](images/f13charprint.gif)

- **Print Character Definition**
    - Prints the current character definition file open in the Editor.

![](images/f14charcut.gif)

- **Cut**
    - Removes the selected item in the Editor and places it on the Windows Clipboard.

![](images/f15charcopy.gif)

- **Copy**
    - Copies the selected item in the Editor to the Windows Clipboard.

![](images/f16charpaste.gif)

- **Paste**
    - Copies data from the current Windows Clipboard to the selected location.

![](images/f17chardel.gif)

- **Delete**
    - Removes the selected item from the Editor.

![](images/f18charundo.gif)

- **Undo**
    - Removes a change made in the Editor.

![](images/f19charredo.gif)

- **Redo**
    - Reverses an undo action in the Editor.

![](images/f20charaanim.gif)

- **New Animation**
    - Creates a new animation object in the Editor.

![](images/f21charanfr.gif)

- **New Animation Frame**
    - Creates a new frame for an animation.

![](images/f22charprev.gif)

- **Preview**
    - Plays an animation, starting from its selected frame.

![](images/f23charprevex.gif)

- **Preview Exit Branching**
    - Plays an animation's exit branching, starting from its selected frame.

![](images/f24charstop.gif)

- **Stop Preview**
    - Stops playing the preview of an animation.

![](images/f25charadd.gif)

- **Add Image File**
    - Displays the Select Image File dialog box. Selected images are added to the list.

![](images/f26charmvup.gif)

- **Move Up**
    - Moves an image up in the ordered (z-ordered) list. In a frame's images list, this moves the image up in the visual z-order.

![](images/f27charmvdwn.gif)

- **Move Down**
    - Moves an image down in the ordered (z-ordered) list. In a frame's images list, this moves the image down in the visual z-order.