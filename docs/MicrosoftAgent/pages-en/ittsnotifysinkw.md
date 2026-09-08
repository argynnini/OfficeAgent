---
layout: Conceptual
title: ITTSNotifySinkW - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/ittsnotifysinkw
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
description: ITTSNotifySinkW
ms.assetid: 6305dad6-c162-458a-899e-628f6486680e
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 395338e3-591a-eafb-60b8-8bd8a9b1fb3b
document_version_independent_id: 180c27cb-94c8-174b-0749-7f37b4c76299
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/ittsnotifysinkw.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/ittsnotifysinkw.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 151
asset_id: lwef/ittsnotifysinkw
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/ittsnotifysinkw.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: acc6d87f-39a4-0e6c-2fe3-00b998a7dc3c
---

# ITTSNotifySinkW - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

The engine must call out through [**AudioStop**](https://www.bing.com/search?q=**AudioStop**), [**AudioStart**](https://www.bing.com/search?q=**AudioStart**), and [**Visual**](https://www.bing.com/search?q=**Visual**). The **Visual** callback must provide IPA phonemes. (The International Phonetic Alphabet [IPA] is a universal notation for describing the phonetic content of spoken communication. All speakable phonemes have representations in IPA. Details of IPA are in the Microsoft Speech API specification [part of the Speech SDK 4.0 download] at [https://www.microsoft.com/speech/](https://msdn.microsoft.com/library/ee705648.aspx).)

Although the [**Visual**](https://www.bing.com/search?q=**Visual**) notification is fairly rich, Microsoft Agent uses only the **cIPAPhoneme** value to animate the mouth as the character speaks. Any Microsoft Agent-compatible engine must provide a closely synchronized stream of **Visual** notifications reflecting the phonetic content of the produced utterance. In this case, "relatively timely notification" is not adequate, because speaker-hearers are fairly sensitive to discrepancies between mouth position and acoustic content. **Visual** notifications need to be returned promptly.