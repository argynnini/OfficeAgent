---
layout: Conceptual
title: ITTSBufNotifySinkW - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/ittsbufnotifysinkw
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
description: ITTSBufNotifySinkW
ms.assetid: 00f4a529-2db1-4cad-9340-ed95999448f7
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 23000878-265d-db1e-77d3-d88b530aabd4
document_version_independent_id: 35c9ffab-f5d0-8869-93ed-d50a1eb32741
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/ittsbufnotifysinkw.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/ittsbufnotifysinkw.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 184
asset_id: lwef/ittsbufnotifysinkw
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/ittsbufnotifysinkw.md
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: e68563ec-6302-e30a-6ad6-a99c804f4b66
---

# ITTSBufNotifySinkW - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

The engine must call out through **BookMark**. During preprocessing of speech output, Microsoft Agent code inserts bookmarks between "words" and uses the arrival of those bookmarks to drive the pacing of text in the word balloon. While SAPI does not require anything more than the arrival of those bookmarks at some time before the end of the utterance, the bookmarks must be returned in a relatively timely fashion to support Microsoft Agent.

Note that there is no strict concept of "word" in some languages, such as Japanese. Microsoft Agent's [**Speak**](speak-method) method defines a "word" as a connected string of symbols that has a meaning and pronunciation in isolation. Microsoft Agent uses fairly simple parsing code to determine what a "word" is: it looks for symbols separated by white space. Thus, there are three "words" in the English string "The 101 Dalmatians": "the", "one hundred and one", and "Dalmatians". Text included in the Microsoft Agent Map tag is treated as a single "word" for display purposes.