---
layout: Conceptual
title: Characters - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/characters
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
description: Characters
ms.assetid: d3eac94b-7899-4695-b0e5-0276c1f5e9cb
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: c752ea01-1911-763a-82fe-701a5cf24b5a
document_version_independent_id: 765bc70b-b608-98e2-c40c-bb781a3e50b9
updated_at: 2025-03-13T17:42:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/characters.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/characters.md
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 594
asset_id: lwef/characters
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/characters.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 018bea25-d257-58b2-613c-8d0cd266dc6e
---

# Characters - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

Human communication is fundamentally social. Microsoft Agent enables you to leverage this aspect of interaction using animated characters. Users will expect a character to conform to the same social, though not necessarily physical, rules they use when interacting with other people, even when they understand that the character is synthetic. To the extent that you create characters that meet their expectations, users will find your characters more believable and likable. Therefore, how you design a character can have a dramatic effect on its success.

When designing a character, first consider the profile of your target audience and what appeals to them as well as what tasks they do. Similarly, consider how well your character's design and style matches its purpose in addition to the application it supports. For example, a dog character may work well for a retrieval or security application depending on its overall appearance. Often the success is in the details. Research has shown that changing an animal character's roundness of eyes and ear shape can generate very different reactions to the character.

Also consider your character's basic personality type: dominant or submissive, emotional or reserved, sophisticated or down-to-earth; or perhaps you want to adapt its personality based on user interaction. For example, you can provide a control that enables a user to adjust whether the character volunteers more information or waits to be asked. The former would be more outgoing than the latter.

The name you supply for your character can infer a particular type of personality. For example, "Max" and "Linus" may convey very different personalities. The Microsoft Agent Character Editor enables you to set your character's name and include a short description. These attributes can be queried at run time.

In addition, decide whether you plan to use a synthetic voice (using a text-to-speech engine) or recorded voice (.WAV file). This decision may depend on the type of character you use, the languages you plan to support, and what you want the character to be able to say. For example, a synthesized voice enables your character to say almost anything. Programming what your character will say is easy and quick: You just supply the text the character will speak. However, using a computer-generated speech engine requires some extra overhead for initial installation and will be language-specific. Further, most synthesized voices sound computer-generated; they do not match the clarity and prosody of most human speech. It may be difficult to simulate a voice that matches your character, particularly if you use a character that already has an established identity or one that has a very distinctive voice. In such a case, you may want to use recorded speech files for your output. Microsoft Agent also supports lip-syncing for recorded speech output. Although audio files provide a natural voice and are easier to implement in other languages, they must be copied or downloaded to local machines. Recorded speech files also limit your character to the vocabulary contained in them. Whether you choose synthetic or recorded speech output, keep in mind that a voice carries with it additional social information about the gender, age, and personality of the speaker.

You can also decide to use the word balloon for output and the default settings for the balloon's font and color. Note, however, that the user can change the font and color attributes. In addition, you cannot assume that the word balloon's state remains constant because the user can turn the word balloon off.