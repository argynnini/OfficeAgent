---
layout: Conceptual
title: IAgentCommandWindow GetPosition - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcommandwindow--getposition
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
description: IAgentCommandWindow GetPosition
ms.assetid: d85a7a2c-f0ea-4612-aa73-2e44c49e4e18
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 5f2541fb-ccce-5b57-3d55-e7feb3d4c86e
document_version_independent_id: 78a691c2-0422-bd1e-08f5-376bea845bad
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommandwindow--getposition.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentcommandwindow--getposition.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 122
asset_id: lwef/iagentcommandwindow--getposition
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcommandwindow--getposition.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 341e094b-4937-cc55-88f0-2608bcdac477
---

# IAgentCommandWindow GetPosition - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT GetPosition(
   long * plLeft,  // address of variable for left edge of Voice Commands Window
   long * plTop    // address of variable for top edge of Voice Commands Window
);
```

Retrieves the Voice Commands Window's position.

- Returns S\_OK to indicate the operation was successful.

- *plLeft*
    - Address of a variable that receives the screen coordinate of the left edge of the Voice Commands Window in pixels, relative to the screen origin (upper left).
- *plTop*
    - Address of a variable that receives the screen coordinate of the top edge of the Voice Commands Window in pixels, relative to the screen origin (upper left).