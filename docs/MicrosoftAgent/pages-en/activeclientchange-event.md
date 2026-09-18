---
layout: Conceptual
title: ActiveClientChange Event - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/activeclientchange-event
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
description: ActiveClientChange Event
ms.assetid: 617b40e6-cafb-463e-8b36-2a12c468d3ae
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 8b53f7f7-53f6-27a3-5606-088d0c555871
document_version_independent_id: c277b77c-48a1-a50b-f021-7d19fbd90182
updated_at: 2025-03-13T17:42:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/activeclientchange-event.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/activeclientchange-event.md
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 254
asset_id: lwef/activeclientchange-event
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/activeclientchange-event.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 5fc7bf25-e23d-53c6-abf0-0ec4e1da1bd6
---

# ActiveClientChange Event - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Occurs when the active client of the character changes.
- **Syntax**
    - **Sub** \*agent.\*ActiveClientChange (ByVal *CharacterID*, ByVal *Active***)**

| Part | Description |
| --- | --- |
| *CharacterID* | Returns the ID of the character for which the event occurred. |
| *Active* | A Boolean value that indicates whether the client became active or not active. **True** The client application became the active client of the character. **False** The client application is no longer the active client of the character. |

### Remarks

When multiple client applications share the same character, the active client of the character receives mouse input (for example, Microsoft Agent control click or drag events). Similarly, when multiple characters are displayed, the active client of the topmost character (also known as the input-active client) receives [Command](command-event) events.

When the active client of a character changes, this event passes back the ID of that character and **True** if your application has become the active client of the character or **False** if it is no longer the active client of the character.

A client application may receive this event when the user selects a client application's entry in character's pop-up menu or by voice command, when the client application changes its active status, or when another client application quits its connection to Agent. Agent sends this event only to the client applications that are directly affected; that either become the active client or stop being the active client.

### See Also

[**ActivateInput event**](activateinput-event), [**Active property**](active-property), [**DeactivateInput event**](deactivateinput-event), [**Activate method**](activate-method)