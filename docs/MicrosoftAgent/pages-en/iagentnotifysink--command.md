---
layout: Conceptual
title: IAgentNotifySink Command - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentnotifysink--command
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
description: IAgentNotifySink Command
ms.assetid: d54fb2e8-27d6-47a4-8a1e-5419a94ea26d
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: acadc072-1a77-cbb3-c4f9-09db64d28c1a
document_version_independent_id: bd6f6992-5fb1-317d-88a3-90c0a7ae331e
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentnotifysink--command.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentnotifysink--command.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 143
asset_id: lwef/iagentnotifysink--command
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentnotifysink--command.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: a27af99f-3cef-5f99-da02-e3721e9ac9e7
---

# IAgentNotifySink Command - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT Command(
   long dwCommandID,         // Command ID of the best match
   IUnknown * punkUserInput  // address of IAgentUserInput object 
);                          
```

Notifies a client application that a [**Command**](/en-us/windows/desktop/lwef/the-command-object) was selected by the user.

- No return value.

- *dwCommandID*
    - Identifier of the best match command alternative.
- *punkUserInput*
    - Address of the [**IUnknown**](/en-us/windows/desktop/api/unknwn/nn-unknwn-iunknown) interface for the [**IAgentUserInput**](iagentuserinput) object.

Use [**QueryInterface**](/en-us/windows/desktop/api/unknwn/nf-unknwn-iunknown-queryinterface%28q%29) to retrieve the [**IAgentUserInput**](iagentuserinput) interface.

The server notifies the input-active client when the user chooses a command by voice or by selecting a command from the character's pop-up menu. The event occurs even when the user selects one of the server's commands. In this case the server returns a null command ID, the confidence score, and the voice text returned by the speech engine for that entry.