---
layout: Conceptual
title: Animation Design - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/animation-design
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
description: Animation Design
ms.assetid: 8812e4cc-9062-4c65-81ef-229bd29534cd
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 46647d0f-4c86-4e87-9047-f2d5da0f6fb6
document_version_independent_id: e6e4fca1-0d7a-c2de-4a94-3f5d2359b8f9
updated_at: 2025-03-13T17:42:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/animation-design.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/animation-design.md
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 335
asset_id: lwef/animation-design
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/animation-design.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 4229c829-590d-b247-8f57-32e6d58b970b
---

# Animation Design - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

### Image Design

Use the Microsoft Office Palette when designing your characters to minimize any potential palette realization issues. Avoid selecting a transparency color that is similar to the colors that you use in your document.

### Sounds

Microsoft Agent enables you to play sounds in your animations. We recommend you do not include sounds for your **Idle** animations. This is so there won't be a delay in the middle of the animation, if Agent has to load the system multimedia DLL.

### Frame Size

Typical Office Assistants are 123 x 93 pixels. While you can create characters of other sizes, they will be scaled to 123 x 93 in the Assistant Gallery.

### Frame Transition

All animations except for **Goodbye**, **Greeting**, **Show** and **Hide** should begin and end with the RestPose animation. Microsoft Office does not play explicit **Return** animations, so you should not define them. All animations should also have Exit Branching. Exit branching enables us to 'hurry up and finish' the current animation before we call the next animation. If you don't supply Exit Branching, the transition between animations may be jerky.

### Character Properties

Microsoft Agent enables you to set the character's [**Name**](name-property), [**Description**](description-property) and [**ExtraData**](extradata-property) properties. Microsoft Office uses the **ExtraData** field to hold to one or more Introduction Phrases and Reminder Phrases. Microsoft Office picks from the other Introduction Phrases to put in the speech balloon in the Assistant Gallery. We use the Reminder Phrases when you receive a reminder from Outlook.

The [**ExtraData**](extradata-property) field is formatted as follows:

IntroPhrase1~~IntroPhrase2~~IntroPhrase3^^ReminderPhrase1~~ReminderPhrase2~~ReminderPhrase3

Intro Phrases are separated by a pair of tilde characters (~), followed by Reminder Phrases. These Reminder Phrases are also separated by a pair of tilde characters. The two sets of phrases are separated by two caret characters (^^). There is no limit to the number of each kind of phrase, except that there must be at least one of each.