---
layout: Conceptual
title: The PropertySheet Object - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/the-propertysheet-object
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
description: The PropertySheet Object
ms.assetid: 9d15d198-a4fe-4c05-a7be-0807a179cd9c
ms.topic: concept-article
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 78460226-8ff1-9cdc-fde0-845c759ee4c9
document_version_independent_id: 3c4fc335-5027-2c1e-8b17-2a94b8d0dda9
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/the-propertysheet-object.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/the-propertysheet-object.md
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 98
asset_id: lwef/the-propertysheet-object
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/the-propertysheet-object.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 44187fa6-eb3a-1bfd-c541-115fd3b5aa27
---

# The PropertySheet Object - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

The [**PropertySheet**](https://www.bing.com/search?q=**PropertySheet**) object provides several properties you can use if you want to manipulate the character relative to the Microsoft Agent property sheet (also known as the Advanced Character Options window).

- [**Height**](height-property-pso)
- [**Left**](left-property-pso)
- [**Page**](page-property)
- [**Top**](top-property-pso)
- [**Visible**](visible-property)
- [**Width**](width-property-pso)

If you query [**Height**](height-property-pso), [**Left**](left-property-pso), [**Top**](top-property-pso), and [**Width**](width-property-pso) properties before the property sheet has ever been shown, their values return as zero (0). Once shown, these properties return the last position and size of the window (relative to your current screen resolution).