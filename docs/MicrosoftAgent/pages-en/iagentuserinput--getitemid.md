---
layout: Conceptual
title: IAgentUserInput GetItemID - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentuserinput--getitemid
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
description: IAgentUserInput GetItemID
ms.assetid: 3afd4d9d-51bb-4086-bf7b-7c9a2ddcd807
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 1a797e1a-5295-828e-6e9a-4883c58d180a
document_version_independent_id: 06b1a8e6-4fa9-cb7e-7adf-53c85bf11b15
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentuserinput--getitemid.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentuserinput--getitemid.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 109
asset_id: lwef/iagentuserinput--getitemid
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentuserinput--getitemid.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: bbe9903e-118d-c82d-1d8c-81d09d73d105
---

# IAgentUserInput GetItemID - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT GetItemID(
   long dwItemIndex,    // index of Command alternative
   long * pdwCommandID  // address of a variable for number of alternatives 
);
```

Retrieves the identifier of a [**Command**](command-event) alternative passed to an [**IAgentNotifySink::Command**](iagentnotifysink--command) callback.

- Returns S\_OK to indicate the operation was successful.

- *dwItemIndex*
    - The index of the [**Command**](command-event) alternative passed to the [**IAgentNotifySink::Command**](iagentnotifysink--command) callback.
- *pdwCommandID*
    - Address of a variable that receives the ID of a [**Command**](command-event).

If voice input triggers the [**IAgentNotifySink::Command**](iagentnotifysink--command) callback, the server returns the IDs for any matching [**Commands**](command-event) defined by your application.