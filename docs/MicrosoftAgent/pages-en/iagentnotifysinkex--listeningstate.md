---
layout: Conceptual
title: IAgentNotifySinkEx ListeningState - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentnotifysinkex--listeningstate
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
description: IAgentNotifySinkEx ListeningState
ms.assetid: e303b299-0dd0-419a-87a9-1490fe6cf54a
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: e8c82ed3-eeb5-0d1f-0420-cd971fcf6dfc
document_version_independent_id: 4c60c0cd-15af-c75c-86ed-0dfa88c31e0c
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentnotifysinkex--listeningstate.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentnotifysinkex--listeningstate.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 282
asset_id: lwef/iagentnotifysinkex--listeningstate
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentnotifysinkex--listeningstate.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: bef775c4-ea21-9ab3-a90a-5619365d2c3d
---

# IAgentNotifySinkEx ListeningState - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT ListeningState(
   long dwCharacterID,  // character ID
   long bListening,     // listening mode state
   long dwCause         // cause  
);
```

Notifies a client application when the Listening mode changes.

- No return value.

- *dwCharacterID*
    - The character for which the listening state changed.
- *bListening*
    - The Listening mode state. **True** indicates that Listening mode has started; **False**, that Listening mode has ended.
- *dwCause*
    - The cause for the event, which may be one of the following values.

| Value | Description |
| --- | --- |
| **const unsigned long** **LSCOMPLETE\_CAUSE\_PROGRAMDISABLED = 1;** | Listening mode was turned off by program code. |
| **const unsigned long** **LSCOMPLETE\_CAUSE\_PROGRAMTIMEDOUT = 2;** | Listening mode (turned on by program code) timed out. |
| **const unsigned long** **LSCOMPLETE\_CAUSE\_USERTIMEDOUT = 3;** | Listening mode (turned on by the Listening key) timed out. |
| **const unsigned long** **LSCOMPLETE\_CAUSE\_USERRELEASEDKEY = 4;** | Listening mode was turned off because the user released the Listening key. |
| **const unsigned long** **LSCOMPLETE\_CAUSE\_USERUTTERANCEENDED = 5;** | Listening mode was turned off because the user finished speaking. |
| **const unsigned long** **LSCOMPLETE\_CAUSE\_CLIENTDEACTIVATED = 6;** | Listening mode was turned off because the input active client was deactivated. |
| **const unsigned long** **LSCOMPLETE\_CAUSE\_DEFAULTCHARCHANGE = 7** | Listening mode was turned off because the default character was changed. |
| **const unsigned long** **LSCOMPLETE\_CAUSE\_USERDISABLED = 8** | Listening mode was turned off because the user disabled speech input. |

This event is sent to all clients when the Listening mode begins after the user presses the Listening key or when its time-out ends, or when the input-active client calls the [**IAgentCharacterEx::Listen**](iagentcharacterex--listen) method with **True** or **False**.

The event returns values to the clients that currently have this character loaded. All other clients receive a null character (empty string).