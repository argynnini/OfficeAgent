---
layout: Conceptual
title: Installing the Sound Editor - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/installing-the-sound-editor
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
description: Installing the Sound Editor
ms.assetid: 0ce35b29-1cf3-4068-91b8-04231cb02a9d
ms.topic: concept-article
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: b6d861b3-4a01-f3ed-62d9-4285ad98fbd5
document_version_independent_id: 8535943a-db80-1497-53b2-b1ced49f1a28
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/installing-the-sound-editor.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/installing-the-sound-editor.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 238
asset_id: lwef/installing-the-sound-editor
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/installing-the-sound-editor.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 57f50347-22b3-2f9b-3507-4d2862b08b03
---

# Installing the Sound Editor - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

The recommended system configuration for using the sound editor is a PC with a Pentium 166, at least 48 MB RAM, and a Windows-compatible sound card. If you want to record spoken input with the tool, you will also need a compatible microphone.

To install the Microsoft Linguistic Sound Editing Tool, open its self-extracting installation file. This will automatically install the appropriate files on your system. If you download the sound editor from the Microsoft Agent website, you can choose to install the editor after downloading or save it to your disk to be subsequently opened and installed. The installation tool will propose to install itself in the Tools subdirectory of Microsoft Agent. We recommend that you use this location.

The Microsoft Command and Control speech recognition engine (version. 4.0) must also be installed before you can use the sound editor. This normally gets installed with the sound editor, but if it was subsequently uninstalled, you can reinstall it from the Microsoft Platform SDK or the Microsoft Agent website. The sound editor can only generate linguistic information based on the language supported by the speech engine. To generate information for other languages, a compatible speech recognition engine for that language must be installed. Contact your speech engine vendor to determine whether they support the Microsoft Linguistic Sound Editing Tool.