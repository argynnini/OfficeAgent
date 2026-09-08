---
layout: Conceptual
title: Animation Sound Effects - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/animation-sound-effects
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
description: Animation Sound Effects
ms.assetid: 8d35f67d-67b2-45d7-aa58-3075224dd39a
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 642deaac-a20e-4084-445e-a1bb0aff92f6
document_version_independent_id: ac76015c-8c5b-1910-0aee-fbae2b297dde
updated_at: 2025-03-13T17:42:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/animation-sound-effects.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/animation-sound-effects.md
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 96
asset_id: lwef/animation-sound-effects
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/animation-sound-effects.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 85c9de2a-7180-a42f-263c-943aecc50685
---

# Animation Sound Effects - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

Microsoft Agent also enables you to include sound effects as a part of a character's animation. Using the Microsoft Agent Character Editor, you can specify the filename of standard Windows sound (.WAV) files to trigger on a given frame. Note that Microsoft Agent does not mix sound effects and spoken output, so spoken output does not begin until a sound effect completes. Therefore, avoid any long or looping sound effect as a part of a character's animation.