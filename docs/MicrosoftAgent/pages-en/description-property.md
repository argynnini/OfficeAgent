---
layout: Conceptual
title: Description Property (Legacy Windows Environment Features) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/description-property
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
description: Description Property
ms.assetid: 81ac4bc7-ef0c-4e7c-b57e-acc4ad315515
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: a743baca-5fc6-67d3-f4ce-1be9b8807f57
document_version_independent_id: 77e1b245-3d71-f067-fdb2-66d06b802350
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/description-property.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/description-property.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 121
asset_id: lwef/description-property
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/description-property.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: a4422a91-f216-db5f-0514-c2a49b25e416
---

# Description Property (Legacy Windows Environment Features) - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Returns or sets a string that specifies the description for the specified character.
- **Syntax**
    - *agent*.**Characters("*CharacterID*").Description** [ = *string*]

| Part | Description |
| --- | --- |
| *string* | A string value corresponding to the character's description (in the current language setting). |

## Remarks

A character's **Description** may depend on the character's **LanguageID** setting. A character's name in one language may be different or use different characters than in another. The character's default **Description** for a specific language is defined when the character is compiled with the Microsoft Agent Character Editor.

Note

The **Description** property setting is optional and may not be supplied for all characters.