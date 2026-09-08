---
layout: Conceptual
title: Use the Active Voice - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/use-the-active-voice
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
description: Use the Active Voice
ms.assetid: 7a89ea83-1cf0-4bfb-8f69-63081f8adf48
ms.topic: concept-article
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 3afb8870-2cb3-7653-9afe-15672673ac46
document_version_independent_id: dc02109b-ba34-b079-218f-43268f25d395
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/use-the-active-voice.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/use-the-active-voice.md
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 143
asset_id: lwef/use-the-active-voice
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/use-the-active-voice.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: f834b1d9-c9b2-8b3a-1b82-b9ea9eef3042
---

# Use the Active Voice - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

When using speech output to provide directive information or to elicit a user response, use the active voice and clearly specify the user's expected action. The following example illustrates the differences:

| Directive | Evaluation |
| --- | --- |
| Let me repeat your number. | No user action |
| The number will be repeated. | Passive voice, no user action |
| Listen while the number is repeated. | Passive voice |
| Listen to the repetition. | Best choice |

In addition, construct your output to unfold the key information at the end of the phrase as shown in the following examples:

| Instead of this... | Use this |
| --- | --- |
| "Is three the next digit?" | "Is the next digit three?" |
| "Click OK to begin." | "To begin, click OK." |
| "Say 'Done' to complete your order." | "To complete your order, say 'Done.'" |