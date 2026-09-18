---
layout: Conceptual
title: IAgentCharacter MoveTo - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcharacter--moveto
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
description: IAgentCharacter MoveTo
ms.assetid: 4e24d2f8-1df2-47ca-a1e9-b9d29708207d
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 07f423b0-f3e9-5749-b7ba-9c17cbe6e373
document_version_independent_id: a4c9a671-7c6a-a937-619d-0bca84473aee
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacter--moveto.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacter--moveto.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 232
asset_id: lwef/iagentcharacter--moveto
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcharacter--moveto.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: b4f7fbc1-8ab3-f413-5a1e-ea080c7e5d87
---

# IAgentCharacter MoveTo - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT MoveTo(
   short x,         // x-coordinate of new location
   short y,         // y-coordinate of new location
   long lSpeed,     // speed to move the character
   long * pdwReqID  // address of request ID
);
```

Plays the associated **Moving** state animation and moves the character frame to the specified location.

- Returns S\_OK to indicate the operation was successful. When the function returns, this variable contains the ID of the request.

- *x*
    - The x-coordinate of the new position in pixels, relative to the screen origin (upper left). The location of a character is based on the upper left corner of its animation frame.
- *y*
    - The y-coordinate of the new position in pixels, relative to the screen origin (upper left). The location of a character is based on the upper left corner of its animation frame.
- *lSpeed*
    - A parameter specifying in milliseconds how quickly the character's frame moves. The recommended value is 1000. Specifying zero (0) moves the frame without playing an animation.
- *pdwReqID*
    - Address of a variable that receives the [**MoveTo**](https://www.bing.com/search?q=**MoveTo**) request ID.

When using the HTTP protocol to access character and animation data, use the [**Prepare**](/en-us/windows/desktop/lwef/iagentcharacter--prepare) method to ensure the availability of the **Moving** state animations before calling this method. Even if the animation is not loaded, the server still moves the frame.