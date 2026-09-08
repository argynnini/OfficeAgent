---
layout: Conceptual
title: IAgentCharacter GestureAt - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcharacter--gestureat
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
description: IAgentCharacter GestureAt
ms.assetid: ece84652-383e-4397-a6d9-f0209dd80767
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 1cca4af1-8b77-3816-1bf7-89f41f28f96b
document_version_independent_id: e4e854ac-380f-a505-d411-978dcc9314cd
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacter--gestureat.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacter--gestureat.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 163
asset_id: lwef/iagentcharacter--gestureat
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcharacter--gestureat.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 34946702-50eb-86f0-1e80-38ad43e7083c
---

# IAgentCharacter GestureAt - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT GestureAt(
   short x,         // x-coordinate of specified location
   short y,         // y-coordinate of specified location
   long * pdwReqID  // address of a request ID
);
```

Plays the associated **Gesturing** state animation based on the specified location.

- Returns S\_OK to indicate the operation was successful. When the function returns, *pdwReqID* contains the ID of the request.

- *x*
    - The x-coordinate of the specified location in pixels, relative to the screen origin (upper left).
- *y*
    - The y-coordinate of the specified location in pixels, relative to the screen origin (upper left).
- *pdwReqID*
    - Address of a variable that receives the **GestureAt** request ID.

The server automatically determines and plays the appropriate gesturing animation based on the character's current position and the specified location. When using the HTTP protocol to access character and animation data, use the [**Prepare**](iagentcharacter--prepare) method to ensure that the animations are available before calling this method.