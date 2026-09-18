---
layout: Conceptual
title: IAgent - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagent
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
description: IAgent
ms.assetid: 35b12006-a938-450c-969a-7b73a3768a4d
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: c3d39e35-273f-34d6-cfeb-bc489ca03c03
document_version_independent_id: 86ef5125-f89c-ecf9-db5e-5894c65c53b9
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagent.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagent.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 106
asset_id: lwef/iagent
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagent.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: af84d0f0-24c1-207a-1510-7ea72d6c6fe8
---

# IAgent - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

**IAgent** defines an interface that allows applications to load characters, receive events, and check the current state of the Microsoft Agent Server. These functions are also available from [**IAgentEx**](iagentex).

The GetSuspended method included in previous versions is obsolete and returns **False** for backward compatibility.

**Methods in Vtable Order**

| IAgent Methods | Description |
| --- | --- |
| [**Load**](load-method) | Loads a character's data file. |
| [**Unload**](unload-method) | Unloads a character's data file. |
| [**Register**](iagent--register) | Registers a notification sink for the client. |
| [**Unegister**](iagent--unregister) | Unregisters a client's notification sink. |
| [**GetCharacter**](iagent--getcharacter) | Returns the IAgentCharacter interface for a loaded character. |