---
layout: Conceptual
title: IAgentCharacter Play - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcharacter--play
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
description: IAgentCharacter Play
ms.assetid: a0158693-ff62-4da4-8b68-402e8d5b1c2a
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: e910e398-e24a-c0c9-25b2-99b6dd949bb9
document_version_independent_id: c96f747d-d4d4-3877-e8a2-c7f971340bbc
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacter--play.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacter--play.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 166
asset_id: lwef/iagentcharacter--play
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcharacter--play.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 77221758-753d-624a-b5e3-7e19837b95fc
---

# IAgentCharacter Play - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT Play(
   BSTR bszAnimation,  // name of an animation
   long * pdwReqID     // address of request ID
);
```

Plays the specified animation.

- Returns S\_OK to indicate the operation was successful. When the function returns, *pdwReqID* contains the ID of the request.

- *bszAnimation*
    - The name of an animation.
- *pdwReqID*
    - Address of a variable that receives the **IAgentCharacter::Play** request ID.

An animation's name is defined when the character is compiled with the Microsoft Agent Character Editor. Before playing the specified animation, the server attempts to play the **Return** animation for the previous animation (if one has been assigned).

When a character's animation data is stored on the user's local machine, you can use the **IAgentCharacter::Play** method and specify the name of the animation. When using the HTTP protocol to access animation data, use the [**Prepare**](iagentcharacter--prepare) method to ensure the availability of the animation before calling this method.