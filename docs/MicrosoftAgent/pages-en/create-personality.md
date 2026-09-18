---
layout: Conceptual
title: Create Personality - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/create-personality
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
description: Create Personality
ms.assetid: ee8b2b8d-82e6-47c9-9ba1-8eb18f82683f
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: d0403368-8969-2b07-8a7c-f8bcda71524a
document_version_independent_id: d07f2dd9-40c6-49ea-015a-744425b4e9c3
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/create-personality.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/create-personality.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 371
asset_id: lwef/create-personality
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/create-personality.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 5a51a7ac-4bcf-ba8f-537c-17341fd642ac
---

# Create Personality - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

We quickly classify the personality of people we meet based on the simplest of social cues, such as posture, gesture, appearance, word choice, and style. So the first impression a character makes is very important. Creating personality doesn't require artificial intelligence or realistic rendering. Great animators have known this for years and have used the simplest social cues to create rich personalities for inanimate objects. Consider, for example, the flying carpet in Disney's *Aladdin*, and Lassiter's *Luxo Jr*., a humorous animated video of a pair desk lamps. Beginning animators at Disney were often given the challenge of drawing flour sacks that expressed emotion.

A character's name, how it introduces itself, how it speaks, how it moves, and how it responds to user input can all contribute to establishing its basic personality. For example, an authoritative or dominant style of personality can be established by a character making assertions, demonstrating confidence, and issuing commands, whereas a submissive personality may be characterized by phrasing things as questions or making suggestions. Similarly, personality can be conveyed in the sequence of interaction. Dominant personalities always go first. It is important to provide a distinct, well-defined personality type, regardless of which personality type you are creating. Everyone generally dislikes weakly defined or ambiguous personalities.

The kind of personality you choose for a character depends on your objective. If the character's purpose is to direct users toward specific goals, use a dominant, assertive personality. If the character's purpose is to respond to users' requests, use a more submissive personality.

Another approach is to adapt a character's personality to the user's. Studies have shown that users prefer interaction with personalities most like themselves. You might offer the user a choice of characters with different personalities or observe the user's style of interaction with the character and modify the character's interactive style. Research shows that when attempting to match a user's personality you don't always have to be 100% correct. Humans tend to show flexibility in their relationships and, because of the nature of social relationships, are also likely to modify their own behavior somewhat to working with a character.