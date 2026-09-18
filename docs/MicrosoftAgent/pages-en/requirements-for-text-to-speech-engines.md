---
layout: Conceptual
title: Requirements for Text-To-Speech Engines - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/requirements-for-text-to-speech-engines
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
description: Requirements for Text-To-Speech Engines
ms.assetid: 21d19949-c9b4-4d9c-9684-6d15162f7a7d
ms.topic: concept-article
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 2128e1a8-300f-6f6a-322e-e899ac6c8d3c
document_version_independent_id: 7dc1c40a-3eb2-70fd-c6a2-c2479dc9a382
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/requirements-for-text-to-speech-engines.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/requirements-for-text-to-speech-engines.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 74
asset_id: lwef/requirements-for-text-to-speech-engines
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/requirements-for-text-to-speech-engines.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 25a30f09-fbb9-ff9b-4b5b-36241a8d41d5
---

# Requirements for Text-To-Speech Engines - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

The engine must be fully SAPI 4.0-compliant. In addition, the engine must also support the following SAPI interfaces for tagged text and bookmark notifications. These interfaces enable Microsoft Agent to pace the output of text to a character's word balloon and lip-sync the character's mouth (or equivalent) with the spoken words.

- [ITTSCentralW](ittscentralw)
- [ITTSNotifySinkW](ittsnotifysinkw)
- [ITTSBufNotifySinkW](ittsbufnotifysinkw)
- [ITTSAttributesW](ittsattributesw)