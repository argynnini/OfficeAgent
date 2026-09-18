---
layout: Conceptual
title: IAgentNotifySinkEx ActiveClientChange - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentnotifysinkex--activeclientchange
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
description: IAgentNotifySinkEx ActiveClientChange
ms.assetid: e953e803-c898-4c07-adc0-8b895b5e8473
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: c340dd7b-2f89-101a-4c2f-cdcb5c24c81a
document_version_independent_id: 643ab780-a03e-b269-a4ae-24e64c31211a
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentnotifysinkex--activeclientchange.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentnotifysinkex--activeclientchange.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 321
asset_id: lwef/iagentnotifysinkex--activeclientchange
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentnotifysinkex--activeclientchange.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 941a92da-6442-9646-1174-4afdbcd83ef9
---

# IAgentNotifySinkEx ActiveClientChange - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT ActiveClientChange(
...long dwCharID,  // character ID
   long lStatus    // active state flag
);
```

Notifies a client application if its active client is no longer the active client of a character.

- No return value.

- *dwCharID*
    - Identifier of the character for which active client status changed.
- *lStatus*
    - Active state change of the client, which can be a combination of any of the following values:

| Value | Description |
| --- | --- |
| **const unsigned short** **ACTIVATE\_NOTACTIVE = 0;** | Your client is not the active client of the character. |
| **const unsigned short** **ACTIVATE\_ACTIVE = 1;** | Your client is the active client of the character. |
| **const unsigned short** **ACTIVATE\_INPUTACTIVE = 2;** | Your client is input-active (active client of the topmost character). |

When multiple client applications share the same character, the active client of the character receives mouse input (for example, Microsoft Agent control click or drag events). Similarly, when multiple characters are displayed, the active client of the topmost character (also known as the input-active client) receives [**IAgentNotifySink::Command**](iagentnotifysink--command) events.

When the active client of a character changes, this event passes back the ID of that character and **True** if your application has become the active client of the character or **False** if it is no longer the active client of the character.

A client application may receive this event when the user selects another client application's entry in character's pop-up menu or by voice command, the client application changes its active status, or another client application quits its connection to Microsoft Agent. Agent sends this event only to the client applications that are directly affected-those that either become the active client or stop being the active client.

You can use the [**Activate**](iagentcharacter--activate) method to set whether your application is the active client of the character or to make your application the input-active client (which also makes the character topmost).