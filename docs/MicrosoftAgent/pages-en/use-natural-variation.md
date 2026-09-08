---
layout: Conceptual
title: Use Natural Variation - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/use-natural-variation
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
description: Use Natural Variation
ms.assetid: 5d5750e4-cf30-43dc-9419-7e6bbdb9aa5a
ms.topic: concept-article
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 110f6ad4-f3fe-9139-79ac-48e0c95716b5
document_version_independent_id: 89d89d20-1e3f-e6c3-f4de-3139ebd46360
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/use-natural-variation.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/use-natural-variation.md
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 222
asset_id: lwef/use-natural-variation
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/use-natural-variation.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: d9401d36-e5f7-6a54-92c0-1b07acdd0777
---

# Use Natural Variation - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

While consistency of presentation in your application's conventional interface, such as menus and dialog boxes, makes the interface more predictable, vary the animation and spoken output in the character's interface. Appropriately varying the character's responses provides a more natural interface. If a character always addresses the user exactly the same way; for example, always saying the same words, the user is likely to consider the character boring, disinterested, or even rude. Human communication rarely involves precise repetition. Even when repeating something in a similar situation, we may change wording, gestures, or facial expression.

Microsoft Agent enables you to build in some variation for a character. When defining a character's animations, you can use branching probabilities on any animation frame to change an animation when it plays. You can also assign multiple animations to each state. Microsoft Agent randomly chooses one of the assigned animations each time it initiates a state. For speech output, you can also include vertical bar characters in your output text to automatically vary the text spoken. For example, Microsoft Agent will randomly select one of the following statements when processing this text as part of the [**Speak**](speak-method) method:

"I can say this.|I can say that.|I can say something else."