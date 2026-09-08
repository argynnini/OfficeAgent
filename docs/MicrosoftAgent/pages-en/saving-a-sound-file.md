---
layout: Conceptual
title: Saving a Sound File - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/saving-a-sound-file
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
description: Saving a Sound File
ms.assetid: b8b91883-e4d2-441a-b749-379c5ba661f8
ms.topic: concept-article
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: d4ae7fe5-e751-7552-3dc2-70dc1b1f1e11
document_version_independent_id: 45b07084-3c65-f650-3a3f-06f71aca094f
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/saving-a-sound-file.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/saving-a-sound-file.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 236
asset_id: lwef/saving-a-sound-file
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/saving-a-sound-file.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 29f5775e-d5cc-6faa-2627-2c7d8bbf2fd0
---

# Saving a Sound File - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

When you are ready to save your sound file, choose the **Save** command on the **File** menu or on the editor's toolbar. The editor displays the **Save As** dialog box and proposes a name and default file type based on whether you generated linguistic information for the file. If you save the file as a sound file (.wav), the editor saves just the audio data. If you save the file information as a linguistically enhanced sound file (.lwv), the word and phoneme information are automatically included as part of a modified sound file. After you have confirmed or edited the name, location, file type, and format, choose the **Save** button.

![Screenshot that shows the 'Save As' dialog with a 'File name', 'Save as type', 'Format', and 'Attributes' selected.](images/f7listsave.gif)

If you want to save a sound file with a new name, different location, or different format, choose the **Save As** command on the **File** menu. When the **Save As** dialog box appears, type in the new filename and click the **Save** button.

You can also save a portion of the sound file. For example, you may want to save the file without excessive silence at its beginning or end. In the Audio Representation, select the portion of the file you want to save, and choose **Save Selection As** from the **File** menu. The command is enabled only when you have a selection in the **Audio Representation**.