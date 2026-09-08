---
layout: Conceptual
title: IAgentCommandWindow GetVisible - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcommandwindow--getvisible
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
description: IAgentCommandWindow GetVisible
ms.assetid: a69a2aaa-5a3a-46b8-b505-49609a2aa5ba
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: ef553981-ccfb-2c96-9c4e-eacdb77c8361
document_version_independent_id: bbd93cdd-77d4-f2e8-94a7-f017e6baec95
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommandwindow--getvisible.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentcommandwindow--getvisible.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 76
asset_id: lwef/iagentcommandwindow--getvisible
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcommandwindow--getvisible.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 477c55fa-211e-5cbf-5458-ab4a5a362ae0
---

# IAgentCommandWindow GetVisible - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT GetVisible(
   long * pbVisible  // address of variable for Visible setting for 
);                   // Voice Commands Window
```

Determines whether the Voice Commands Window is visible or hidden.

- Returns S\_OK to indicate the operation was successful.

- *pbVisible*
    - Address of a variable that receives **True** if the Voice Commands Window is visible, or **False** if hidden.