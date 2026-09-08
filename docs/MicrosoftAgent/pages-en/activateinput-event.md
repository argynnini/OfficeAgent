---
layout: Conceptual
title: ActivateInput Event - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/activateinput-event
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
description: ActivateInput Event
ms.assetid: bc395750-5da0-4379-8eca-3195e936052c
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: f16ae5e0-64db-bf0b-6b16-a6e70abafbe6
document_version_independent_id: 6b10bf6e-be7e-1ab8-a9a8-21f369bfd3d5
updated_at: 2025-03-13T17:42:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/activateinput-event.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/activateinput-event.md
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 199
asset_id: lwef/activateinput-event
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/activateinput-event.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 6ab18d3e-e4ff-8889-745b-4813e5dc9841
---

# ActivateInput Event - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Occurs when a client becomes input-active.
- **Syntax**
    - **Sub***agent*\_ActivateInput\*\*(ByVal\*\* *CharacterID*\*\*)\*\*

| Part | Description |
| --- | --- |
| *CharacterID* | Returns the ID of the character through which the client becomes input-active. |

### Remarks

The input-active client receives mouse and speech input events supplied by the server. The server sends this event only to the client that becomes input-active.

This event can occur when the user switches to your [Command](the-command-object) object, for example, by choosing your Command object entry in the Commands Window or in the pop-up menu for a character. It can also occur when the user selects a character (by clicking or speaking its name), when a character becomes visible, and when the character of another client application becomes hidden. You can also call the [Activate Method](activate-method) (with **State** set to 2) to explicitly make the character topmost, which results in your client application becoming input-active and triggers this event. However, this event does not occur if you use the Activate Method method only to specify whether your client is the active client of the character.

### See Also

[**DeactivateInput** event](deactivateinput-event), [**Activate** method](activate-method)