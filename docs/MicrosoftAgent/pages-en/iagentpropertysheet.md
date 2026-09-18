---
layout: Conceptual
title: IAgentPropertySheet - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentpropertysheet
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
description: IAgentPropertySheet
ms.assetid: f81091e7-c165-43ac-90ac-c60ffd1bbe79
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: da190ec0-a018-dcce-2621-b7c7b3d79ee5
document_version_independent_id: 750f29c8-b44e-b573-3c60-a1547303dab6
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentpropertysheet.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentpropertysheet.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 109
asset_id: lwef/iagentpropertysheet
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentpropertysheet.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 54b16c22-fb9a-81da-d1ec-4f528b17d210
---

# IAgentPropertySheet - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

**IAgentPropertySheet** defines an interface that allows applications to set and query properties for the Microsoft Agent property sheet (window).

**Methods in Vtable Order**

| IAgentPropertySheet Methods | Description |
| --- | --- |
| [**GetVisible**](iagentpropertysheet--getvisible) | Returns whether the Microsoft Agent property sheet is visible. |
| [**SetVisible**](iagentpropertysheet--setvisible) | Sets the [**Visible**](visible-property) property of the Microsoft Agent property sheet. |
| [**GetPosition**](iagentpropertysheet--getposition) | Returns the position of the Microsoft Agent property sheet. |
| [**GetSize**](iagentpropertysheet--getsize) | Returns the size of the Microsoft Agent property sheet. |
| [**GetPage**](iagentpropertysheet--getpage) | Returns the current page for the Microsoft Agent property sheet. |
| [**SetPage**](iagentpropertysheet--setpage) | Sets the current page for the Microsoft Agent property sheet. |