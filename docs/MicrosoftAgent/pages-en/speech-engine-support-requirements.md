---
layout: Conceptual
title: Speech Engine Support Requirements - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/speech-engine-support-requirements
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
description: Speech Engine Support Requirements
ms.assetid: 3f37cf87-e45c-4a75-aae0-1db3b3e0206e
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 12a3f429-0644-63eb-4c6b-e88183896699
document_version_independent_id: c59c07f5-e26f-f316-3aa1-050406f3f549
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/speech-engine-support-requirements.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/speech-engine-support-requirements.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 100
asset_id: lwef/speech-engine-support-requirements
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/speech-engine-support-requirements.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: a861fa4f-f5ed-3bc6-f159-e62f69f66e6e
---

# Speech Engine Support Requirements - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

Microsoft Agent uses the Microsoft Speech Application Programming Interface (SAPI) to support speech input (speech recognition, or SR) and speech output (text-to-speech, or TTS). By supporting this standard, Microsoft Agent's speech services can be supported by other speech engines. This document describes the required SAPI interfaces used by Microsoft Agent. For more information about SAPI, see the [Microsoft Speech](https://msdn.microsoft.com/library/ee705648.aspx) group's web site.

- [Requirements for Text-To-Speech Engines](requirements-for-text-to-speech-engines)
- [Requirements for Speech Recognition Engines](requirements-for-speech-recognition-engines)
- [Requirements for Supporting the Microsoft Linguistic Information Sound Editing Tool](requirements-for-supporting-the-microsoft-linguistic-information-sound-editing-tool)