---
layout: Conceptual
title: AutoPopupMenu Property - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/autopopupmenu-property
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
description: AutoPopupMenu Property
ms.assetid: 499092cb-0990-4edb-915c-12e3011de142
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 2ecfde19-aee5-2cd9-2157-61c439a979a8
document_version_independent_id: 9aed57f6-6bb5-d6f2-7910-7f307b72015b
updated_at: 2025-03-13T17:42:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/autopopupmenu-property.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/autopopupmenu-property.md
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 137
asset_id: lwef/autopopupmenu-property
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/autopopupmenu-property.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: d9bd7d56-c965-312b-999d-062fb1648b51
---

# AutoPopupMenu Property - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Returns or sets whether right-clicking the character or its taskbar icon automatically displays the character's pop-up menu.
- **Syntax**
    - *agent.**Characters***("***CharacterID***").AutoPopupMenu\*\* [ = *boolean*]

| Part | Description |
| --- | --- |
| *boolean* | A Boolean expression specifying whether the server automatically displays the character's pop-up menu on right-click. **True** (Default) Displays the menu on right-click. **False** Does not display the menu on right-click. |

## Remarks

By setting this property to **False**, you can create your own menu-handling behavior. To display the menu after setting this property to **False**, use the [**ShowPopupMenu**](showpopupmenu-method) method.

This property applies only to your client application's use of the character; the setting does not affect other clients of the character or other characters of your client application.