---
layout: Conceptual
title: Input-Active Client - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/input-active-client
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
description: Input-Active Client
ms.assetid: b46e91d3-eca7-4a4a-b1ce-27b5e6ad92a5
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: a78a0c81-64ee-468c-1532-2d41b71eee11
document_version_independent_id: 2816cbe2-e06b-77ec-3ae2-cd97528e2493
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/input-active-client.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/input-active-client.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 308
asset_id: lwef/input-active-client
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/input-active-client.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 6de5c184-3a3a-fd3b-f63c-899ba1af9641
---

# Input-Active Client - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

Because multiple client applications can share the same character and because multiple clients can use different characters at the same time, the server designates one client as the *input-active* client and sends mouse and voice input only to that client application. This maintains the orderly management of user input, so that an appropriate client responds to the input.

Typically, user interaction determines which client application becomes input-active. For example, if the user clicks a character, that character's client application becomes input-active. Similarly, if a user speaks the name of a character, it becomes input-active. Also, when the server processes a character's [**Show**](show-method) method, the client of that character becomes input-active.

When a character is hidden, the client of that character will no longer be input-active for that character. The server automatically makes the active client of any remaining character(s) input-active. When all characters are hidden, no client is input-active. However, in this situation, if the user presses the Listening hotkey, Agent will continue to listen for its commands (using the speech recognition engine matching the topmost character of the last input-active client).

If multiple clients are sharing the same character, the server will designate its *active client* as input-active client. The active character is the topmost in the client order. You can set your client to be the active or not-active client using the [**Activate**](activate-method) method. You can also use the **Activate** method to explicitly make your client input-active; but to avoid disrupting other clients of the character, you should do so only when your client application is active. For example, if the user clicks your application's window, activating your application, you can call the **Activate** method to receive and process mouse and speech input directed to the character.