---
layout: Conceptual
title: Active Property - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/active-property
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
description: Active Property
ms.assetid: 76ada073-782a-4355-b4e8-42dd84d0139b
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 44a4f53d-7d21-26c5-d67a-6e322876a2d6
document_version_independent_id: 1dd8b27e-6d1d-f0cc-8fd7-e27b507331b4
updated_at: 2025-03-13T17:42:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/active-property.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/active-property.md
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 158
asset_id: lwef/active-property
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/active-property.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 167a083a-5691-dc9f-8f0c-8f0f058faabf
---

# Active Property - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Returns whether your application is the active client of the character and whether the character is topmost.
- **Syntax**
    - *agent.**Characters***("***CharacterID***").Active\*\* [ = *State*]

| Part | Description |
| --- | --- |
| *state* | An integer expression specifying the state of your client application. 0 Not the active client. 1 The active client.  2 The input-active client. (The topmost character.) |

## Remarks

When multiple client applications share the same character, the active client of the character receives mouse input (for example, Microsoft Agent control [**Click**](click-event) or [DragStart](dragstart-event) events). Similarly, when multiple characters are displayed, the active client of the topmost character (also known as the input-active client) receives Command events.

You can use the [**Activate**](activate-method)method to set whether your application is the active client of the character or to make your application the input active client (which also makes the character topmost).