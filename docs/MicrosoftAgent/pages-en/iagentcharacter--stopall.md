---
layout: Conceptual
title: IAgentCharacter StopAll - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcharacter--stopall
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
description: IAgentCharacter StopAll
ms.assetid: cb0ce220-7b35-45c0-b587-30939d26740f
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: b24364fb-559b-8aed-7e38-2a3797421dc3
document_version_independent_id: 34af3731-80c3-342a-4c3d-7d7d99db687a
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacter--stopall.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacter--stopall.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 140
asset_id: lwef/iagentcharacter--stopall
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcharacter--stopall.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 247c95bc-ab72-91d4-2aea-16938c2f12de
---

# IAgentCharacter StopAll - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT StopAll();
   long lType,  // request type
```

Stops all animations (requests) and removes them from the character's animation queue.

- *lType*
    - A bitfield that indicates the types of requests to stop (and remove from the character's queue), comprised from the following:

| Value | Description |
| --- | --- |
| **const unsigned long** **STOP\_TYPE\_ALL = 0xFFFFFFFF;** | Stops all animation requests, including non-queued [**Prepare**](iagentcharacter--prepare) requests. |
| **const unsigned long** **STOP\_TYPE\_PLAY = 0x00000001;** | Stops all Play requests. |
| **const unsigned long** **STOP\_TYPE\_MOVE = 0x00000002;** | Stops all [**Move**](https://www.bing.com/search?q=**Move**) requests. |
| **const unsigned long** **STOP\_TYPE\_SPEAK = 0x00000004;** | Stops all [**Speak**](iagentcharacter--speak) requests. |
| **const unsigned long** **STOP\_TYPE\_PREPARE = 0x00000008;** | Stops all queued [**Prepare**](iagentcharacter--prepare) requests. |
| **const unsigned long** **STOP\_TYPE\_NONQUEUEDPREPARE = 0x00000010;** | Stops all non-queued [**Prepare**](iagentcharacter--prepare) requests. |
| **const unsigned long** **STOP\_TYPE\_VISIBLE = 0x00000020;** | Stops all [**Hide**](iagentcharacter--hide) or [**Show**](iagentcharacter--show) requests. |