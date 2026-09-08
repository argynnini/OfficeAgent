---
layout: Conceptual
title: Speech Input Events - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/speech-input-events
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
description: Speech Input Events
ms.assetid: d7b621fe-9274-4b16-af8a-664b0b296c89
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: e9d8191b-b31c-f22e-9221-eff9fc1167b1
document_version_independent_id: 288f529a-e0c2-a4f2-4c2a-298e4ecfe022
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/speech-input-events.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/speech-input-events.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 383
asset_id: lwef/speech-input-events
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/speech-input-events.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 5e9db189-38cb-fc2b-a521-6acf198a63da
---

# Speech Input Events - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

In addition, to the [**Command**](command-event) event notification, Agent also notifies the input-active client when the server turns the Listening mode on or off, using the [**ListenStart**](listenstart-event) and [**ListenComplete**](listencomplete-event) events ([**IAgentNotifySinkEx::ListeningState**](iagentnotifysinkex--listeningstate)). However, if the user presses the Listening mode key and there is no matching speech recognition engine available for the topmost character of the input-active client, the server starts the Listening hotkey mode time-out, but does not generate a **ListenStart** event for the active client of the character. If, before the time-out completes, the user activates another character with speech recognition engine support, the server attempts to activate speech input and generates the **ListenStart** event.

Similarly, if a client attempts to turn on the Listening mode using the [**Listen**](listen-method) method and there is no matching speech recognition engine available, the call fails and the server does not generate a [**ListenStart**](listenstart-event)event. In the Microsoft Agent control, the **Listen** method returns **False**, but the call does not raise an error.

When the Listening key mode is on and the user switches to a character that uses a different speech recognition engine, the server switches to and activates that engine and triggers a [**ListenComplete**](listencomplete-event) and then a [**ListenStart**](listenstart-event) event. If the activated character does not have an available speech recognition engine (because one is not installed or none match the activated character's language ID setting), the server will trigger the **ListenComplete** event for the previously activated character and passes back a value in the **Cause** parameter. However, the server does not generate **ListenStart** or **ListenComplete** events for the clients that do not have speech recognition support.

If a client successfully calls the [**Listen**](listen-method) method and a character without speech recognition engine support becomes input-active before the Listening mode time-out completes, and then the user switches back to the character of the original client, the server will generate a [**ListenStart**](listenstart-event) event for that client.

If the input-active client switches speech recognition engines by changing [**SRModeID**](srmodeid-property) while in Listening mode, the server switches to and activates that engine without re-triggering the [**ListenStart**](listenstart-event) event. However, if the specified engine is not available, the call fails (raises an error in the control) and the server also calls the [**ListenComplete**](listencomplete-event) event.