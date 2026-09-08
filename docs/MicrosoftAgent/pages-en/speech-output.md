---
layout: Conceptual
title: Speech Output - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/speech-output
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
description: Speech Output
ms.assetid: 86ac204c-4925-4945-b7fa-d628c3539a8a
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 4d351290-1622-3ff1-680a-892889eb9d50
document_version_independent_id: f9151f78-304c-8b4e-d2f5-2adcafc76a68
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/speech-output.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/speech-output.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 268
asset_id: lwef/speech-output
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/speech-output.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 83207be6-f664-1bdc-d612-33679a742e64
---

# Speech Output - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

Like speech input, speech output is a familiar and natural form of communication, so it is also an appropriate complement in a character-based interface. However, speech output also has its liabilities. In some environments, speech output may not be preferred or audible. In addition, by itself, speech is invisible and has no persistent output, relying heavily on short-term memory. These factors limit its capacity and speed for processing large amounts of information. Similarly, speech output can also disrupt user input, particularly when speech is the input method. Speech engines generally have little support that enables the user to interrupt when speech or other audio has the output channel.

As a result, avoid using speech as the exclusive form of output. However, because Microsoft Agent presents characters as a part of the Windows interface, it provides several advantages over speech-only environments. Characters can be combined with other forms of input and output to make options and actions visible, enabling a more effective interface than one that is exclusively visual or speech-based.

In addition, to make speech output more visible, Microsoft Agent includes the option of authoring a character with a cartoon-style word balloon. Other settings enable you to determine how text appears in the balloon and when the balloon is removed. You can also determine what font to use. Although you can set a character's word balloon attributes, be aware that the user can override these settings.

- [Be Efficient and Natural](be-efficient-and-natural)
- [Use the Active Voice](use-the-active-voice)
- [Use Appropriate Timing and Emphasis](use-appropriate-timing-and-emphasis)