---
layout: Conceptual
title: ListenComplete Event - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/listencomplete-event
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
description: ListenComplete Event
ms.assetid: 29e3f424-17b4-4287-b644-ed62b80e0035
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 9005e410-60c4-1fc0-eed7-128698bad71b
document_version_independent_id: 2b936665-983c-400a-09b7-08131629611b
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/listencomplete-event.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/listencomplete-event.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 287
asset_id: lwef/listencomplete-event
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/listencomplete-event.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 8047a4ad-ef31-4999-58b0-a103c1113297
---

# ListenComplete Event - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Occurs when Listening mode (speech recognition) has ended.
- **Syntax**
    - **Sub***agent.**ListenComplete (ByVal**CharacterID, **ByVal**Cause*)\*\*

| Part | Description |
| --- | --- |
| *CharacterID* | Returns the ID of the listening character as a string. |
| *Cause* | Returns the cause of the complete event as an integer that may be one of the following: 1 Listening mode was turned off by program code. 2 Listening mode (turned on by program code) timed out. 3 Listening mode (turned on by the Listening key) timed out. 4 Listening mode was turned off because the user released the Listening key. 5 Listening mode ended because the user finished speaking. 6 Listening mode ended because the input-active client was deactivated. 7 Listening mode ended because the default character was changed. 8 Listening mode ended because the user disabled speech input. |

### Remarks

This event is sent to all clients when the Listening mode time-out ends, after the user releases the Listening key, when the input active client calls the [**Listen**](listen-method) method with **False**, or the user finished speaking. You can use this event to determine when to resume character spoken (audio) output.

If you turn on Listening mode using the [**Listen**](listen-method) method and then the user presses the Listening key, the Listening mode resets and continues until the Listening key time-out completes, the Listening key is released, or the user finishes speaking, whichever is later. In this situation, you will not receive a **ListenComplete** event until the listening key's mode completes.

The event returns the character to the clients that currently have this character loaded. All other clients receive a null character (empty string).

### See Also

[**ListenStart event**](listenstart-event), [**Listen method**](listen-method)