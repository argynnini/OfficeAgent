---
layout: Conceptual
title: Visible Property (Commands Object) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/visible-property-cso
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
description: Learn about the Visible Property of the Commands object, which determines whether your Commands collection's caption appears in the character's pop-up menu.
ms.assetid: 0178a789-141b-4d4c-ba7c-05c7995f13bc
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 5dfa001d-3dd0-e900-36a1-de0a29884f84
document_version_independent_id: 52700b16-4d75-e74b-fc7d-db1fdc07d8e0
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/visible-property-cso.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/visible-property-cso.md
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 132
asset_id: lwef/visible-property-cso
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/visible-property-cso.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 6b328c6d-666e-ba46-f8d7-a6c0f13c40e4
---

# Visible Property (Commands Object) - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Returns or sets a value that determines whether your [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection's caption appears in the character's pop-up menu.
- **Syntax**
    - *agent*\*\*.Characters(**"*CharacterID*"**).Commands.Visible\*\* [ = *boolean*]

| Part | Description |
| --- | --- |
| *boolean* | A Boolean expression specifying whether your [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) object appears in the character's pop-up menu. **True** The caption appears.**False** The caption does not appear. |

## Remarks

For the caption to appear in the character's pop-up menu when your application is not the input-active client, this property must be set to **True** and the [**Caption**](caption-property) property set for your Commands collection. In addition, this property must be set to **True** for commands in your collection to appear in the pop-up menu when your application is input-active.