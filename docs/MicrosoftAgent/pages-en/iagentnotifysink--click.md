---
layout: Conceptual
title: IAgentNotifySink Click - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentnotifysink--click
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
description: IAgentNotifySink Click
ms.assetid: 6587fed8-4651-4c5c-b257-6e3f991cd3a0
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 47132585-3d53-fcf5-29ea-d68879a8f33a
document_version_independent_id: aef4750e-faea-4c91-08bb-6a2ef59cf8fb
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentnotifysink--click.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentnotifysink--click.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 211
asset_id: lwef/iagentnotifysink--click
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentnotifysink--click.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 9141d521-3e22-517c-af0a-4ad20ec03b23
---

# IAgentNotifySink Click - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT Click(
   long dwCharID,  // character ID
   short fwKeys,   // mouse button and modifier key state
   long x,         // x coordinate of mouse pointer
   long y          // y coordinate of mouse pointer
);                          
```

Notifies a client application when the user clicks a character or character's taskbar icon.

- No return value.

- *dwCharID*
    - Identifier of the clicked character.
- *fwKeys*
    - A parameter that indicates the mouse button and modifier key state. The parameter can return any combination of the following:

| Value | Description |
| --- | --- |
| 0x0001 | Left Button |
| 0x0010 | Middle Button |
| 0x0002 | Right Button |
| 0x0004 | Shift Key Down |
| 0x0008 | Control Key Down |
| 0x0020 | Alt Key Down |
| 0x1000 | Event occurred on the character's taskbar icon |
- *x*
    - The x-coordinate of the mouse pointer in pixels, relative to the screen origin (upper left).
- *y*
    - The y-coordinate of the mouse pointer in pixels, relative to the screen origin (upper left).

This event is sent to the input-active client of the character. If none of the character's clients are input-active, the server notifies the character's active client. If the character is visible, the server also makes that client input-active and sends the [**IAgentNotifySink::ActivateInputState**](iagentnotifysink--activateinputstate). If the character hidden, the character is also automatically shown.