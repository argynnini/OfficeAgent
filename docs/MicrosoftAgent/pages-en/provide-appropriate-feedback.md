---
layout: Conceptual
title: Provide Appropriate Feedback - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/provide-appropriate-feedback
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
description: Provide Appropriate Feedback
ms.assetid: e89b5f08-645e-4048-a153-4f01de8e82f0
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 7501177d-2872-7c20-125b-a730d0d17285
document_version_independent_id: 570ef434-0213-ac2c-f5e0-6c9a20b0102d
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/provide-appropriate-feedback.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/provide-appropriate-feedback.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 375
asset_id: lwef/provide-appropriate-feedback
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/provide-appropriate-feedback.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/8b896464-3b7d-4e1f-84b0-9bb45aeb5f64
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/b1d2d671-9549-46e8-918c-24349120dbf5
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 0291ca5b-2f38-21cf-24ec-54dcb617de36
---

# Provide Appropriate Feedback - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

Quality, appropriateness, and timing are important factors to consider when providing feedback in any interface design. When you incorporate interactive characters, the opportunities for natural forms of feedback increase, as does the user's expectation that the feedback conform to appropriate social interaction. A character can be designed to provide verbal and non-verbal conversational cues in addition to spoken audio output. Use gestures or facial expressions to convey information about its mood or intent. The face is especially important in communication, so always consider the character's facial expression. Keep in mind that no facial expression *is* a facial expression.

We humans have an orienting reflex that causes us to attend to changes in our environment, especially changes in motion, volume, or contrast. Therefore, character animation and sound effects should be kept at a minimum to avoid distracting users when they aren't directly interacting with the character. This doesn't mean the character must freeze, but natural idling behavior such as breathing or looking around is preferable to greater movement. Idling behavior maintains the illusion of social context and availability of the character without distracting the user. You may also want to consider removing the character if the user hasn't interacted with it for a set time period, but make sure the user understands why the character is going away.

Conversely, large body motion, unusual body motion, or highly active animation is very effective if you want to capture the user's attention, particularly if the animation occurs outside the user's current focus. Note also that motion toward the user can effectively gain the user's attention.

Placement and movement of the character should be appropriate to its participation in the user's current task. If the current task involves the character, the character can be placed at the point of focus. When the user is not interacting with the character, move it to a consistent "standby" location or where it will not interfere with tasks or distract the user. Always provide a rationale for how the character gets from one location to another. Similarly, users feel most comfortable when the character appears in the same screen location from which it departed.