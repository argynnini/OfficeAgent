---
layout: Conceptual
title: IAgentCharacterEx GetActive - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcharacterex--getactive
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
description: IAgentCharacterEx GetActive
ms.assetid: b14ae69a-a50e-4488-b5a7-33702e6555eb
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 32dffc6b-d294-ef33-b94d-c642f2f50a82
document_version_independent_id: 6c4a0682-6008-f8f9-71ed-16d4e48d9ae0
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacterex--getactive.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacterex--getactive.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 225
asset_id: lwef/iagentcharacterex--getactive
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcharacterex--getactive.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 8664596c-ce14-6c64-6530-f65e30163672
---

# IAgentCharacterEx GetActive - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT GetActive(
   short * psState  // address of active state setting
);
```

Retrieves whether your client application is the active client of the character and whether the character is topmost.

- Returns S\_OK to indicate the operation was successful.

- *psState*
    - Address of a variable that receives one of the following values for the state setting:

| Value | Description |
| --- | --- |
| **const unsigned short** **ACTIVATE\_NOTACTIVE = 0;** | Your client is not the active client of the character. |
| **const unsigned short** **ACTIVATE\_ACTIVE = 1;** | Your client is the active client of the character. |
| **const unsigned short** **ACTIVATE\_INPUTACTIVE = 2;** | Your client is input-active (active client of the topmost character). |

This setting lets you know whether you are the active client of the character or whether your character is the input active character. When multiple client applications share the same character, the active client of the character receives mouse input (for example, Microsoft Agent control click or drag events). Similarly, when multiple characters are displayed, the active client of the topmost character (also known as the input-active client) receives [**IAgentNotifySink::Command**](iagentnotifysink--command) events.

Use the [**Activate**](iagentcharacter--activate) method to set whether your application is the active client of the character or to make your application the input active client (which also makes the character topmost).