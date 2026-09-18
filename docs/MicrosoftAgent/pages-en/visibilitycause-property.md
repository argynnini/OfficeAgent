---
layout: Conceptual
title: VisibilityCause Property - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/visibilitycause-property
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
description: VisibilityCause Property
ms.assetid: 106574ef-af5f-44cf-9efb-9e6da19ebc1f
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: cc70eb92-ec92-e55c-aef0-f2eecd2fc4a5
document_version_independent_id: 29a64768-c592-c5cd-36cc-236de1fbb5d6
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/visibilitycause-property.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/visibilitycause-property.md
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 162
asset_id: lwef/visibilitycause-property
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/visibilitycause-property.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: c12ecaa0-7a8c-5d8b-d571-ee57205b544a
---

# VisibilityCause Property - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Returns an integer value that specifies what caused the character's visible state.
- **Syntax**
    - *agent*.**Characters("*CharacterID*").VisibilityCause**

| Value | Description |
| --- | --- |
| 0 | The character has not been shown. |
| 1 | User hid the character using the command on the character's taskbar icon pop-up menu or using speech input.. |
| 2 | The user showed the character. |
| 3 | Your application hid the character. |
| 4 | Your application showed the character. |
| 5 | Another client application hid the character. |
| 6 | Another client application showed the character. |
| 7 | The user hid the character using the command on the character's pop-up menu. |

## Remarks

You can use this property to determine what caused the character to move when more than one application is sharing (has loaded) the same character. These values are the same as those returned by the [**Show**](show-event) and [**Hide**](hide-event) events.