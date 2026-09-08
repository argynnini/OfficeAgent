---
layout: Conceptual
title: IAgentCharacter Hide - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcharacter--hide
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
description: IAgentCharacter Hide
ms.assetid: a8128fe8-9a3b-41a3-bfe3-82ace1baff6f
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 7e6324f4-884d-9cf1-4635-ca26494df38a
document_version_independent_id: 56afcdcf-d987-9381-5983-f8f084383ddd
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacter--hide.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacter--hide.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 219
asset_id: lwef/iagentcharacter--hide
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcharacter--hide.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: faac1ec1-2b3f-93cc-a561-f29175d19956
---

# IAgentCharacter Hide - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT Hide(
   long bFast,      // play Hiding state animation flag
   long * pdwReqID  // address of request ID
);
```

Hides the character.

- Returns S\_OK to indicate the operation was successful. When the function returns, *pdwReqID* contains the ID of the request.

- *bFast*
    - **Hiding** state animation flag. If this parameter is **True**, the **Hiding** animation does not play before the character frame is hidden; if **False**, the animation plays.
- *pdwReqID*
    - Address of a variable that receives the **Hide** request ID.

The server queues the animation associated with the **Hide** method in the character's queue. This allows you to use it to hide the character after a sequence of other animations. You can play the action immediately by using the [**Stop**](iagentcharacter--stop) method before calling the **Hide** method.

When using the HTTP protocol to access character and animation data, use the [**Prepare**](/en-us/windows/desktop/lwef/iagentcharacter--prepare) method to ensure the availability of the **Hiding** state animation before calling this method.

Hiding a character can also result in triggering the [**IAgentNotifySink::ActivateInputState**](iagentnotifysink--activateinputstate) event of another visible character.

Hidden characters cannot access the audio channel. The server will pass back a failure status in the [**RequestComplete**](iagentnotifysink--requestcomplete) event if you generate an animation request and the character is hidden.