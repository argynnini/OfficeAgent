---
layout: Conceptual
title: The Character Taskbar Icon - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/the-character-taskbar-icon
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
description: The Character Taskbar Icon
ms.assetid: b1db7151-b367-4708-897e-0695988163e8
ms.topic: concept-article
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: df26948b-c037-2616-fa5f-5aad6315b736
document_version_independent_id: f64a3815-49b9-b29d-baa4-a359e34def9e
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/the-character-taskbar-icon.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/the-character-taskbar-icon.md
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 159
asset_id: lwef/the-character-taskbar-icon
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/the-character-taskbar-icon.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: a9cdfb02-504d-3311-5b91-17ca32c1e4ca
---

# The Character Taskbar Icon - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

If a character has been authored to include an icon, the icon appears in the notification area of the taskbar when Microsoft Agent runs. This icon provides access to the character's pop-up menu, which provides access to Agent's global commands such as those that hide and show the character.

![notification area with clock and icon](images/f1tbicon.gif)

Moving the pointer over the taskbar icon displays a tip window that reflects the name of the character (in the current language of the system). Single-clicking the character's taskbar icon displays the character. The action associated with double-clicking the icon depends on the current application controlling that character.

Right-clicking the icon displays a pop-up menu. When the character is visible, the pop-up menu displays the same commands as those displayed when right-clicking the character. If the character is hidden, only the Open (or Close) Voice Commands Window and Show commands appear.