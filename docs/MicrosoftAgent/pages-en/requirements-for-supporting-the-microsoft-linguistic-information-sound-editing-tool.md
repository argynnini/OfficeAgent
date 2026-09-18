---
layout: Conceptual
title: Requirements for Supporting the Microsoft Linguistic Information Sound Editing Tool - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/requirements-for-supporting-the-microsoft-linguistic-information-sound-editing-tool
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
description: Requirements for Supporting the Microsoft Linguistic Information Sound Editing Tool
ms.assetid: 8ec9801c-e763-4586-b447-1ea6fb8470e6
ms.topic: concept-article
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 06f98b70-52b7-1f2a-bf43-df0847ce68bb
document_version_independent_id: 8724eed8-1b7b-55f0-b4bf-43bc8aeab5ec
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/requirements-for-supporting-the-microsoft-linguistic-information-sound-editing-tool.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/requirements-for-supporting-the-microsoft-linguistic-information-sound-editing-tool.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 85
asset_id: lwef/requirements-for-supporting-the-microsoft-linguistic-information-sound-editing-tool
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/requirements-for-supporting-the-microsoft-linguistic-information-sound-editing-tool.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 8a9e6bad-10cf-e684-14dd-2a7fbcbd9605
---

# Requirements for Supporting the Microsoft Linguistic Information Sound Editing Tool - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

The Microsoft Linguistic Information Sound Editing Tool uses a speech recognition engine to produce word breaks and phonetic information for standard Windows wave sound (.wav) files. The 2.0 version now supports use with other speech engines. Vendors that wish to support the sound editor must ensure that their engines fully support the SAPI 4.0 specification for context-free grammar engines and the following requirements.

- [ISRResGraphEx and IAttributes](isrresgraphex-and-iattributes)