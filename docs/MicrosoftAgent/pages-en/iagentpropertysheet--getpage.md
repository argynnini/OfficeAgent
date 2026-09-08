---
layout: Conceptual
title: IAgentPropertySheet GetPage - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentpropertysheet--getpage
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
description: IAgentPropertySheet GetPage
ms.assetid: 40d00e9b-dd81-4e23-907a-6ca24a28fa95
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 7d9649ac-1ec8-df5d-a01b-d7f490bdcf0e
document_version_independent_id: 74290a53-0200-b0a2-cb60-2219c7f4f67c
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentpropertysheet--getpage.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentpropertysheet--getpage.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 99
asset_id: lwef/iagentpropertysheet--getpage
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentpropertysheet--getpage.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: b52c29ae-314b-d381-0344-7fff11610ee3
---

# IAgentPropertySheet GetPage - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT GetPage(
BSTR * pbszPage  // address of variable for current property page
);
```

Retrieves the current page of the Microsoft Agent property sheet.

- Returns S\_OK to indicate the operation was successful.

- *pbszPage*
    - Address of a variable that receives the current page of the property sheet (last viewed page if the window is not open). The parameter can be one of the following:

| - | Description |
| --- | --- |
| **"Speech"** | The Speech Input page. |
| **"Output"** | The Output page. |
| **"Copyright"** | The Copyright page. |