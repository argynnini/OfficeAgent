---
layout: Conceptual
title: IAgentCommandWindow GetSize - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcommandwindow--getsize
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
description: IAgentCommandWindow GetSize
ms.assetid: 24ad3b48-6557-4790-b9c4-2cf7df92fa7d
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: eb9581d4-5ea0-76bd-38b3-9e82e27245b6
document_version_independent_id: 06484141-84f6-1eda-f2f9-ac9404715e13
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommandwindow--getsize.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentcommandwindow--getsize.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 111
asset_id: lwef/iagentcommandwindow--getsize
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcommandwindow--getsize.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: b3fdf88c-44b6-3e22-243a-779d1a685bab
---

# IAgentCommandWindow GetSize - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT GetSize(
   long * plWidth,  // address of variable for Voice Commands Window width
   long * plHeight  // address of variable for Voice Commands Window height
);
```

Retrieves the current size of the Voice Commands Window.

- Returns S\_OK to indicate the operation was successful.

- *plWidth*
    - Address of a variable that receives the width of the Voice Commands Window in pixels, relative to the screen origin (upper left).
- *plHeight*
    - Address of a variable that receives the height of the Voice Commands Window in pixels, relative to the screen origin (upper left).