---
layout: Conceptual
title: StopAll Method - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/stopall-method
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
description: StopAll Method
ms.assetid: 2ce32ff8-4908-45b1-9b83-4d558f67417c
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: d97efe7e-20a6-c8ff-3cf0-e2178a074ca7
document_version_independent_id: c84b3ebc-99d3-289f-d153-2e6ddbd7cb0b
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/stopall-method.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/stopall-method.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 167
asset_id: lwef/stopall-method
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/stopall-method.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: ae3296b0-23d3-06f7-d057-ff36a87188a7
---

# StopAll Method - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Stops all animation requests or specified types of requests for the specified character.
- **Syntax**
    - *agent*\*\*.Characters ("***CharacterID***").StopAll\*\* [*Type*]

| Part | Description |
| --- | --- |
| *Type* | Optional. To use this parameter you can use any of the following values. You can also specify multiple types by separating them with commas.  "**Get**"  To stop all queued [**Get**](get-method) requests. "**NonQueuedGet**"  To stop all non-queued [**Get**](get-method) requests (**Get** method with **Queue** parameter set to **False**). "**Move**"  To stop all queued [**MoveTo**](moveto-method) requests. "**Play**"  To stop all queued [**Play**](play-method) requests. "**Speak**"  To stop all queued [**Speak**](speak-method) requests. |

## Remarks

If you don't set the **Type** parameter, the server stops all animations for the character, including queued and non-queued [**Get**](get-method) requests, and clears its animation queue. It also stops playing a character's Hiding or Showing animation.

This method will not generate a [**Request**](/en-us/windows/desktop/lwef/the-request-object) object.