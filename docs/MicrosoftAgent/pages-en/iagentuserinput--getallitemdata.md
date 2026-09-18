---
layout: Conceptual
title: IAgentUserInput GetAllItemData - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentuserinput--getallitemdata
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
description: IAgentUserInput GetAllItemData
ms.assetid: d1857b28-c745-4ed2-b49e-774f247e7348
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: c72e5c62-9f67-2f36-85d1-528416042233
document_version_independent_id: fe3dc598-d89c-e9cd-684a-9d95b97ca303
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentuserinput--getallitemdata.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentuserinput--getallitemdata.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 302
asset_id: lwef/iagentuserinput--getallitemdata
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentuserinput--getallitemdata.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 9ccfe187-ba57-eb6d-bc6c-f75b0ab54c0e
---

# IAgentUserInput GetAllItemData - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT GetAllItemData(
   VARIANT * pdwItemIndices,  // address of variable for alternative IDs
   VARIANT * plConfidences,   // address of variable for confidence scores
   VARIANT * pbszText         // address of variable for voice text
);
```

Retrieves the data for all [**Command**](command-event) alternatives passed to an [**IAgentNotifySink::Command**](iagentnotifysink--command) callback.

- Returns S\_OK to indicate the operation was successful.

- *pdwItemIndices*
    - Address of a variable that receives the IDs of [**Commands**](command-event) passed to the [**IAgentNotifySink::Command**](iagentnotifysink--command) callback.
- *plConfidences*
    - Address of a variable that receives the confidence scores for [**Command**](command-event) alternatives passed to the [**IAgentNotifySink::Command**](iagentnotifysink--command) callback.
- *pbszText*
    - Address of a variable that receives the voice text for [**Command**](command-event) alternatives passed to the [**IAgentNotifySink::Command**](iagentnotifysink--command) callback.

If speech input triggers [**IAgentNotifySink::Command**](iagentnotifysink--command), the server returns the best match, the second-best match, and the third-best match, if these are provided by the speech engine. It provides the relative confidence scores, in the range of -100 to 100, and actual text "heard" by the speech engine. If the best match was a server-supplied command, the server sends a NULL ID, but still sends a confidence score and the [**Voice**](voice-property) text.

If speech input was not the source for the event; for example, if the user selected the command from the character's pop-up menu, the Microsoft Agent server returns the ID of the [**Command**](command-event) selected, with a confidence score of 100 and voice text as NULL. The other alternatives return as NULL with confidence scores of zero (0) and voice text as NULL.

Note

Not all speech recognition engines may return all the values for all the parameters of this event. Check with your engine vendor to determine whether the engine supports the Microsoft Speech API interface for returning alternatives and confidence scores.