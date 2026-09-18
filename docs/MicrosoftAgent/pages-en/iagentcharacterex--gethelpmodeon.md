---
layout: Conceptual
title: IAgentCharacterEx GetHelpModeOn - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcharacterex--gethelpmodeon
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
description: IAgentCharacterEx GetHelpModeOn
ms.assetid: 848c9e75-6e4c-487c-b01c-36ec6314d0c1
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 4955310a-49b6-4778-77b4-e4615a246728
document_version_independent_id: d2a2ee19-fe2e-e835-c755-9f924663fefa
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacterex--gethelpmodeon.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacterex--gethelpmodeon.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 206
asset_id: lwef/iagentcharacterex--gethelpmodeon
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcharacterex--gethelpmodeon.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 1b7a940b-7313-9d23-6ea1-6255ce28e1d0
---

# IAgentCharacterEx GetHelpModeOn - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT GetHelpModeOn(
   long * pbHelpModeOn  // address of help mode setting
);
```

Retrieves whether context-sensitive Help mode is on for the character.

- Returns S\_OK to indicate the operation was successful.

- *pbHelpModeOn*
    - Address of a variable that receives **True** if Help mode is on for the character and **False** if not.

When this property is set to **True**, the mouse pointer changes to the context-sensitive Help image when moved over the character or over the pop-up menu for the character. When the user clicks or drags the character or clicks an item in the character's pop-up menu, the server triggers the [**IAgentNotifySinkEx::HelpComplete**](https://www.bing.com/search?q=**IAgentNotifySinkEx::HelpComplete**) event and exits Help mode.

In Help mode, the server does not send the [**IAgentNotifySink::Click**](iagentnotifysink--click), [**IAgentNotifySink::DragStart**](iagentnotifysink--dragstart), [**IAgentNotifySink::DragComplete**](iagentnotifysink--dragcomplete), and [**IAgentNotifySink::Command**](iagentnotifysink--command) events, unless [**GetAutoPopupMenu**](https://www.bing.com/search?q=**GetAutoPopupMenu**) property returns **True**. In that case, the server will send the **IAgentNotifySink::Click** event (does not exit Help mode), but only for the right mouse button to enable you to display the pop-up menu.

This property applies only to your client application's use of the character; the setting does not affect other clients of the character or other characters of your client application.