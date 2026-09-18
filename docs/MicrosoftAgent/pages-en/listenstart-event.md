---
layout: Conceptual
title: ListenStart Event - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/listenstart-event
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
description: ListenStart Event
ms.assetid: 59feacd6-0b9f-4bf4-b544-48de49384312
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 43ed15ef-8498-0ae1-13d2-106390dbb32d
document_version_independent_id: 15c0fa39-770b-47f3-82ed-057e0ed41290
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/listenstart-event.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/listenstart-event.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 190
asset_id: lwef/listenstart-event
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/listenstart-event.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 74c02a53-d146-61a2-0c5b-355650721e68
---

# ListenStart Event - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Occurs when Listening mode (speech recognition) begins.
- **Syntax**
    - **Sub***agent.**ListenStart (ByVal**CharacterID*)\*\*

| Part | Description |
| --- | --- |
| *CharacterID* | Returns the ID of the listening character as a string. |

### Remarks

This event is sent to all clients when Listening mode begins because the user pressed the Listening key or the input-active client called the [**Listen**](listen-method) method with **True**. You can use this event to avoid having your character speak while the Listening mode is on.

If you turn on Listening mode with the [**Listen**](listen-method) method and then the user presses the Listening key, the Listening mode resets and continues until the Listening key time-out completes, the Listening key is released, or the user finishes speaking, whichever is later. In this situation, when Listening mode is already on, you will not get an additional **ListenStart** event when the user presses the Listening key.

The event returns the character to the clients that currently have this character loaded. All other clients receive a null character (empty string).

### See Also

[**ListenComplete event**](listencomplete-event), [**Listen method**](listen-method)