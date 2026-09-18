---
layout: Conceptual
title: IAgentUserInput GetItemConfidence - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentuserinput--getitemconfidence
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
description: IAgentUserInput GetItemConfidence
ms.assetid: 7d1ca2f0-416c-43c3-99a8-9f287cb88de1
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 98b02669-a3a9-a8cf-a61a-7dc1990d696a
document_version_independent_id: ce574fe2-bc14-2d46-26e1-159127fc5e9a
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentuserinput--getitemconfidence.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentuserinput--getitemconfidence.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 142
asset_id: lwef/iagentuserinput--getitemconfidence
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentuserinput--getitemconfidence.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 65a369b8-e9da-b0b0-8502-06fc1bd3a37e
---

# IAgentUserInput GetItemConfidence - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT GetItemConfidence(
   long dwItemIndex,    // index of Command alternative
   long * plConfidence  // address of confidence value for Command 
);
```

Retrieves the confidence value for a [**Command**](command-event) passed to an [**IAgentNotifySink::Command**](iagentnotifysink--command) callback.

- Returns S\_OK to indicate the operation was successful.

- *dwItemIndex*
    - The index of a [**Command**](command-event) alternative passed to the [**IAgentNotifySink::Command**](iagentnotifysink--command) callback.
- *plConfidence*
    - Address of a variable that receives the confidence score for a [**Command**](command-event) alternative passed to the [**IAgentNotifySink::Command**](iagentnotifysink--command) callback.

If voice input was not the source for the command, for example, if the user selected the command from the character's pop-up menu, the Microsoft Agent server returns the confidence value of the best match as 100 and the confidence values for all other alternatives as zero (0).