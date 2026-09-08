---
layout: Conceptual
title: IAgentCharacter Interrupt - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcharacter--interrupt
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
description: IAgentCharacter Interrupt
ms.assetid: ae05d317-e2d9-4d11-a6df-f9b25e43467a
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: fa290ceb-7901-f7c5-346b-9575cf1cf5b4
document_version_independent_id: 1cf2eba5-f074-95e9-71e5-7a8ece8cfd98
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacter--interrupt.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacter--interrupt.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 198
asset_id: lwef/iagentcharacter--interrupt
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcharacter--interrupt.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 5903c8d6-1a95-f9a1-a2f1-84f213906d35
---

# IAgentCharacter Interrupt - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT Interrupt(
   long dwReqID,    // request ID to interrupt
   long * pdwReqID  // address of request ID
);
```

Interrupts the specified animation (request) of another character.

- Returns S\_OK to indicate the operation was successful. When the function returns, *pdwReqID* contains the ID of the request.

- *dwReqID*
    - An ID of the request to interrupt.
- *pdwReqID*
    - Address of a variable that receives the **Interrupt** request ID.

If you load multiple characters, you can use this method to sync up animation between characters. For example, if another character is in a looping animation, this method will stop the looping animation and start the next animation in the character's queue.

**Interrupt** halts the existing animation, but does not flush the character's animation queue. It starts the next animation in the character's queue. To halt and flush a character's queue, use the [**Stop**](/en-us/windows/desktop/lwef/iagentcharacter--stop) method.

You cannot use this method to have a character interrupt itself because the Microsoft Agent server queues the **Interrupt** method in the character's animation queue. Therefore, you can only use **Interrupt** to halt the animation of another character you have loaded.