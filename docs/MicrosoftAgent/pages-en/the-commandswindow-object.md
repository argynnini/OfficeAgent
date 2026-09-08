---
layout: Conceptual
title: The CommandsWindow Object - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/the-commandswindow-object
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
description: The CommandsWindow Object
ms.assetid: f7f37499-f16b-47fb-85d1-23a68171bf0b
ms.topic: concept-article
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: b706958c-ccf6-e390-f9d8-74c413383aa5
document_version_independent_id: 841ae551-1591-36fe-59dc-1722c77705ce
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/the-commandswindow-object.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/the-commandswindow-object.md
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 141
asset_id: lwef/the-commandswindow-object
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/the-commandswindow-object.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 587c22fd-2131-647e-0716-1fe0bc4d609b
---

# The CommandsWindow Object - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

The [**CommandsWindow**](/en-us/windows/desktop/lwef/the-commandswindow-object) object provides access to properties of the Voice Commands Window. The Voice Commands Window is a shared resource primarily designed to enable users to view voice-enabled commands. If speech recognition is disabled, the Voice Commands Window still displays, with the text "Speech input disabled" (in the language of the character). If no speech engine is installed that matches the character's language setting the window displays, "Speech input not available." If the input-active client has not defined voice parameters for its commands and has disabled global voice commands, the window displays, "No voice commands." You can also query the properties of the Voice Commands Window regardless of whether speech input is disabled or a compatible speech engine is installed.

- [CommandsWindow Properties](commandswindow-properties)