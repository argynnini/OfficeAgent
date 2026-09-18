---
layout: Conceptual
title: The Default Character Properties Window - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/the-default-character-properties-window
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
description: The Default Character Properties Window
ms.assetid: a775738e-c3f8-443e-b519-1df0a5d3e95d
ms.topic: concept-article
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: bdb932ac-9198-789e-5121-764bc768c6bd
document_version_independent_id: 16bf5c10-abf9-468b-8e51-1f951336ac38
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/the-default-character-properties-window.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/the-default-character-properties-window.md
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 115
asset_id: lwef/the-default-character-properties-window
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/the-default-character-properties-window.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 142be42c-e14d-917a-66c8-5564e9b57e1d
---

# The Default Character Properties Window - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

In addition to enabling applications to load a specific character, applications can load a character that is a shared resource for the user, known as the *default character*. The default character is accessible from any application, but the character is only selectable by the user. To facilitate selection of this character, Agent provides a window that provides access to selecting this character, called the default character properties window. Access to this window is supported from the Agent API.

![genie character properties dialog box](images/f8dpwin.gif)

The default character properties window cannot be used to provide character selection other than for the default character.