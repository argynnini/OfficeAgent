---
layout: Conceptual
title: The Voice Commands Window - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/the-voice-commands-window
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
description: The Voice Commands Window
ms.assetid: 4cbf1eeb-be35-46e5-87c0-08e022db621c
ms.topic: concept-article
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 8572db5e-99fe-fe15-4cd8-23d3e6d28095
document_version_independent_id: 04905c97-d824-52d5-073f-a32e3a1620c7
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/the-voice-commands-window.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/the-voice-commands-window.md
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 242
asset_id: lwef/the-voice-commands-window
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/the-voice-commands-window.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 4c619dd5-8a56-6e58-3ed1-f9dc65bb3f91
---

# The Voice Commands Window - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

If a compatible speech engine is installed, Microsoft Agent supplies a special window called the **Voice Commands Window** that displays the commands that have been voice-enabled for speech recognition. The **Voice Commands Window** serves as a visual prompt for what can be spoken as input (commands cannot be selected with the mouse).

![voice commands dialog box](images/f2voice.gif)

The window appears when a user selects the **Open Voice Commands Window** command, either by speaking the command or right-clicking the character and choosing the command from the character's pop-up menu. However, if the user disables speech input, the **Voice Commands Window** is not accessible.

The **Voice Commands Window** displays voice-enabled commands as a tree. If the current hosting application supplies voice commands, they appear expanded and at the top of the window. Entries also appear for other applications using the character. The window also includes the global voice commands supplied by Microsoft Agent. If the current hosting application has no voice commands, the global voice commands appear expanded and at the top of the window.

The user can size and move the **Voice Commands Window**. Microsoft Agent remembers the last location of the window and redisplays it at that location if the user closes and re-opens the window. If the entries in the window exceed the current display size of the window, scroll bars appear.