---
layout: Conceptual
title: The Office Animation Set - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/the-office-animation-set
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
description: The Office Animation Set
ms.assetid: ea80d19b-bf4c-4f6e-bab0-424a9f78f457
ms.topic: concept-article
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: e14742fc-6c7d-addc-e6be-f3764a8845c0
document_version_independent_id: dbba89ee-b5cd-532e-ada9-2f31faa6a228
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/the-office-animation-set.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/the-office-animation-set.md
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 838
asset_id: lwef/the-office-animation-set
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/the-office-animation-set.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/e93f3d5f-c77d-4365-a7fb-c9f2234416c7
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/62e8d07a-cc62-4934-b30b-e168a571e51d
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 7357eb5b-6d6c-e3e2-ea3c-c7b36ea61f10
---

# The Office Animation Set - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

The following table lists the animations defined for the Microsoft Office 2000 characters. If you intend to use your character in Microsoft Office, you should support all of the animations in this table. In addition, you can add any other animations you live, but keep in mind that Microsoft Office won't call them. Animations with asterisks (\*) should be 100% looping. Other animations should be brief.

| Animation | Agent State | Example of When Used | Specific animation examples |
| --- | --- | --- | --- |
| **Alert** | None | When the character wants to alert the user | Character looks toward user. |
| **CheckingSomething\*** | None | Spellcheck, grammar check | Character looks something up in a reference book |
| **Congratulate** | None | Complete a wizard | Big grin, look of relief, tired but happy |
| **EmptyTrash** | None | Trash is emptied in Outlook | Character lights trash can on fire |
| **Explain** | None | When the character wants to explain something to the user | Looks briefly but attentively at user, then look away |
| **GestureDown** | GesturingDown | Character points out something on the screen | Character looks at user and then points and looks at the screen |
| **GestureLeft** | GesturingLeft | Character points out something on the screen, such as a help topic or a piece of UI | Character looks at user and then points and looks at the screen |
| **GestureRight** | GesturingRight | "Presenting" a help topic or dialog | Character looks at user and then points and looks at the screen |
| **GestureUp** | GesturingUp | Character points out something on the screen | Character looks at user and then points and looks at the screen |
| **GetArtsy\*** | None | AutoFormat | Character puts on beret, holds palette, and paints |
| **GetAttention** | None | High-priority tip | Gestures strongly to get the user's attention; for example, jumps up and down waving arms |
| **GetTechy** | None | Runs while in programming environment | Character pulls out calculator or soldering iron |
| **GetWizardy\*** | None | Chart Wizard running while Character visible (action re-triggered with each new wizard panel) | Character puts on wizard hat and waves wand |
| **Goodbye** | None | Another Character is chosen | This is an elaborate disappear that begins in **RestPose** and ends with blank frame |
| **Greeting** | None | Character is chosen | This is an elaborate appear that begins with a blank frame, and ends in **RestPose** |
| **Hearing\_1\*** | None | Lengthy file open | Ear to the ground, listening to the computer |
| **Hide** | Hiding | Character leaves temporarily | Leaves quickly in a puff of smoke |
| **Idle1\_1** | No user input | Actively listening, then curls up and goes to sleep. (opportunity to show off character personality) | Blinking, looking around, waiting patiently |
| **Idle2** | No user input | Longer idle periods | Character yawns and looks sleepy |
| **Idle3** | No user input | Deep idle (when the character has been idle for a long time) | Character goes to sleep |
| **IdleHit** | None | This is a non-mapped representative sample of Idle Level 1 animations | All of the idle animations |
| **LookDown** | None | Looks down briefly | Notices a row is inserted and glances at it |
| **LookDownLeft** | None | Looks down and left briefly | Notices a row is inserted and glances at it |
| **LookDownRight** | None | Looks down and right briefly | Notices a column is inserted and glances at it |
| **LookLeft** | None | Looks left briefly | Notices a table is inserted and glances at it |
| **LookRight** | None | Looks right briefly | Notices a word is moved and glances at it |
| **LookUp** | None | Looks up briefly, as if at something going on above character on the screen | Notices toolbar button gets clicked and glances at it (Character isn't surprised as much as interested) |
| **LookUpLeft** | None | Looks left and up briefly | Notices toolbar button gets clicked and glances at it (Character isn't surprised as much as interested) |
| **LookUpRight** | None | Looks right and up briefly | Notices toolbar button gets clicked and glances at it (Character isn't surprised as much as interested) |
| **Print** | None | Printing a page of a print job | Grabs one piece of paper and sends it down to the printer |
| **Processing\*** | None | General action for which we don't have specific character action | Character gets look of concentration and pulls out a hammer to hammer. Animation should have a quick entry into a loop, then a quick exit |
| **RestPose** | None | Used when the character isn't playing an animation | An image of the assistant |
| **Save\*** | None | Used during a File Save operation | Character puts something into a vault |
| **Searching\*** | None | Used for Find, spell check, and grammar check | Head turns and looks back at document. Animation should have a quick entry into a loop, then a quick exit |
| **SendMail** | None | Sending mail | Pulls out a letter and puts it into a mailbox |
| **Show** | Showing | Character returns from brief leave | Springs quickly on stage, quickly |
| **Thinking\*** | None | Doing a complex calculation, such as Solver | Character looks upward and scratches head. Animation should have a quick entry into a loop, then a quick exit |
| **Wave** | None | Accompanying alerts | Wave. Similar to Alert, but not as long or as frantic |
| **Writing\*** | None | Customer changes something in Tools Options; customer typing IntelliSearch request | Pulls out pad and starts scribbling. Animation should have a quick entry into a loop, then a quick exit |