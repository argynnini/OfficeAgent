---
layout: Conceptual
title: IAgentCharacter Show - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcharacter--show
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
description: IAgentCharacter Show
ms.assetid: 5f13dcef-3777-41eb-827f-6162bad71a2e
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: fb75561c-cc3a-5050-8cc8-033365d9bd75
document_version_independent_id: 0ab79923-241a-2887-f02a-e36750ef8608
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacter--show.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacter--show.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 208
asset_id: lwef/iagentcharacter--show
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcharacter--show.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: f23922e6-0c7c-9104-6af0-3a198a64041d
---

# IAgentCharacter Show - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT Show(
   long bFast,      // play Showing state animation flag
   long * pdwReqID  // address of request ID
);
```

Displays a character.

- Returns S\_OK to indicate the operation was successful. When the function returns, *pdwReqID* contains the ID of the request.

- *bFast*
    - Showing state animation flag. If this parameter is **True**, the **Showing** state animation plays after making the character visible; if **False**, the animation does not play.
- *pdwReqID*
    - Address of a variable that receives the [**Show**](/en-us/windows/desktop/lwef/iagentcharacter--show) request ID.

Avoid setting the *bFast* parameter to **True** without playing an animation beforehand, otherwise, the character frame may be displayed, but have no image to display. In particular, note that if you call [**MoveTo**](iagentcharacter--moveto) when the character is not visible, it does not play any animation. Therefore, if you call the **Show** method with *bFast* set to **True**, no image will be displayed. Similarly, if you call [**Hide**](/en-us/windows/desktop/lwef/iagentcharacter--hide), then **Show** with *bFast* set to **True**, there will be no visible image.

When using the HTTP protocol to access character and animation data, use the [**Prepare**](/en-us/windows/desktop/lwef/iagentcharacter--prepare) method to ensure the availability of the **Showing** state animation before calling this method.