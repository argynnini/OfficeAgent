---
layout: Conceptual
title: IAgentCharacter Activate - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcharacter--activate
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
description: IAgentCharacter Activate
ms.assetid: a81eb62d-709b-46b4-9ff2-c9017f7f853e
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 0c27cebf-5152-9208-2483-f44a221f8137
document_version_independent_id: 5f6eb0b0-bc44-39e8-dc6c-ebb76878776f
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacter--activate.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacter--activate.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 456
asset_id: lwef/iagentcharacter--activate
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcharacter--activate.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: eb1a6bfe-9e6f-37c0-0ac4-7a359b921bf0
---

# IAgentCharacter Activate - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT Activate(
   short sState, // topmost character or client setting
);
```

Sets whether a client is active or a character is topmost.

- Returns S\_OK to indicate the operation was successful.
- Returns S\_FALSE to indicate the operation was not successful.

- *sState*
    - You can specify the following values for this parameter:

| Value | Description |
| --- | --- |
| 0 | Set as not the active client. |
| 1 | Set as the active client. |
| 2 | Make the topmost character. |

When multiple characters are visible, only one of the characters receives speech input at a time. Similarly, when multiple client applications share the same character, only one of the clients receives mouse input (for example, Microsoft Agent control click or drag events) at a time. The character set to receive mouse and speech input is the topmost character and the client that receives input is the character's active client. (The topmost character's window also appears at the top of the character window's z-order.) Typically, the user determines which character is topmost by explicitly selecting it. However, topmost activation also changes when a character is shown or hidden (the character becomes or is no longer topmost, respectively.)

You can also use this method to explicitly manage when your client receives input directed to the character, such as when your application itself becomes active. For example, setting **State** to 2 makes the character topmost, and your client receives all mouse and speech input events generated from user interaction with the character. Therefore, it also makes your client the input-active client of the character. However, you can also set the active client for a character without making the character topmost, by setting **State** to 1. This enables your client to receive input directed to that character when the character becomes topmost. Similarly, you can set your client to not be the active client (to not receive input) when the character becomes topmost, by setting **State** to 0. You can determine if a character has other current clients using [**IAgentCharacter::HasOtherClients**](iagentcharacter--hasotherclients).

Avoid calling this method directly after a [**Show**](iagentcharacter--show) method. **Show** automatically sets the input-active client. When the character is hidden, the **Activate** call may fail, if it gets processed before the **Show** method completes.

Attempting to call this method with the **State** parameter set to 2 (when the specified character is hidden) will fail. Similarly, if you set **State** to 0, and your application is the only client, this call fails. A character must always have a topmost client.

Note

Calling this method with **State** set to 1 does not typically generate an [**AgentNotifySink::ActivateInputState**](https://www.bing.com/search?q=**AgentNotifySink::ActivateInputState**) event unless there are no other characters loaded or your application is already input-active.