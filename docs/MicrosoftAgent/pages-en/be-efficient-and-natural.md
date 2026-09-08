---
layout: Conceptual
title: Be Efficient and Natural - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/be-efficient-and-natural
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
description: Be Efficient and Natural
ms.assetid: 6642b41c-1833-41be-9de2-ef091cefaa45
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 506afb58-82c2-720e-fc99-7f2a530fe993
document_version_independent_id: eede3f5d-a866-c051-aa72-9078494c9122
updated_at: 2025-03-13T17:42:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/be-efficient-and-natural.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/be-efficient-and-natural.md
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 494
asset_id: lwef/be-efficient-and-natural
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/be-efficient-and-natural.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/97159432-14a9-4307-a469-d2f2c75f0e33
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/50565c62-5f6b-4687-be38-323113c72c2e
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 6ffcc7ce-cc5b-3bf4-ee55-8e3fffabcf0e
---

# Be Efficient and Natural - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

When accomplishing tasks, effective human conversations are typically exchanges of brief information. Often, elements in the discussion are established between the parties and then referred to indirectly using abbreviated responses. These forms of abbreviation are beneficial because they are efficient, and they also imply that the speaker and listener have a common context; that is, that they are communicating. Using appropriate forms of abbreviation also makes a dialogue more natural.

One form of conversational abbreviation is the use of contractions. When they are not used, they make a speaker seem more formal and rigid, and sometimes less human. Most human conversations demonstrate more freedom in the linguistic rules than written text.

Another common form of abbreviation in conversations is *anaphora*, the use of pronouns. For example, when someone asks, "Have you seen Bill today?" responses that substitute "him" for "Bill" are more natural than repeating the name again. The substitution is a cue that the parties in the dialogue share a common context of *who* "him" is. Keep in mind that the word "I" refers to the character when he or she says it.

Shared context is also communicated by the use of linguistic *ellipsis*, the truncation of many of the words in the original query. For example, the listener could respond, "Yes, I saw him," demonstrating the shared context of *when* or even respond with a simple "Yes" that demonstrates the shared context of *who* and *when*.

Implicit understanding can also be conveyed through other forms of abbreviated conversational style, where content is inferred without repetition, as shown in the following example:

**User:** I'd like a Chicago-style pizza.

**Character:** With "Extra Cheese"?

Similarly, if someone says, "It is hot in here," the phrase is understandable and requires no further detail if you know where the speaker is. However, if the context is not well established or is ambiguous, eliminating all contextual references may leave the user confused.

When using abbreviated communication, always consider the user's context and the type of content. It is appropriate to use longer descriptions for new and unfamiliar information. However, even with long descriptive information, try to break it up into smaller chunks. This gives you the ability to change the animation as the character speaks. It also provides greater opportunity for the user to interrupt the character, especially when using speech input.

Consistency is important in speech output. Strange speech patterns or prosody may be interpreted as downgrading the intelligence of the character. Similarly, switching between TTS and recorded speech may cause users to interpret the character as strange or possessing more than one personality. Lip-synced mouth movements can improve intelligibility of speech. Microsoft Agent automatically supports lip-syncing for TTS engines that comply with its required SAPI interfaces. However, lip-syncing is also supported for recorded speech. Sound files can also be enhanced with the Microsoft Linguistic Sound Editing Tool.