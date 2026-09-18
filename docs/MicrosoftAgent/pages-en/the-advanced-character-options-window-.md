---
layout: Conceptual
title: Advanced Character Options Window (Voice Commands Window) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/the-advanced-character-options-window-
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
description: Learn about the Advanced Character Options Window, which provides options for users to adjust their interaction with all characters.
ms.assetid: c2f784e9-d1c5-4fa3-b3f7-5061c9b7e6d9
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 7b944240-84fc-c688-34e1-322ee6ab68bf
document_version_independent_id: 690aab39-0b74-887e-5ebc-3534f20b6859
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/the-advanced-character-options-window-.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/the-advanced-character-options-window-.md
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 187
asset_id: lwef/the-advanced-character-options-window-
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/the-advanced-character-options-window-.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: c80b6386-53ed-8cc6-c4ac-90cb7d96ebe1
---

# Advanced Character Options Window (Voice Commands Window) - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

The Advanced Character Options window provides options for users to adjust their interaction with all characters. For example, users can disable speech input or change input parameters. Users can also change the output settings for the word balloon. These settings override any set by a client application or set as part of the character definition. Your application cannot change or disable these options, because they apply to the general user preferences for operation of all characters. However, the server will notify your application ([**DefaultCharacterChange**](defaultcharacterchange-event)) when the user changes and applies an option. You can also display or close the window using the window's [**Visible**](visible-property) property and access its location through its [**Top**](top-property) and [**Left**](left-property) properties.

In addition to supporting the animation of a character, Microsoft Agent supports audio output for the character. This includes spoken output and sound effects. For spoken output, the server automatically lip-syncs the character's defined mouth images to the output. You can choose text-to-speech (TTS) synthesis, recorded audio, or only word balloon text output.