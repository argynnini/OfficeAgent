---
layout: Conceptual
title: DefaultCharacterChange Event - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/defaultcharacterchange-event
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
description: DefaultCharacterChange Event
ms.assetid: 14b86a44-8fd2-4719-b7b5-cdcc618d27cd
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 288024ed-e90a-647a-2c14-85642183a5ee
document_version_independent_id: d554fc43-6657-7e58-b414-030711b29010
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/defaultcharacterchange-event.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/defaultcharacterchange-event.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 108
asset_id: lwef/defaultcharacterchange-event
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/defaultcharacterchange-event.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 48c1122b-3793-d450-adc0-fdbcbae1e8c7
---

# DefaultCharacterChange Event - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Occurs when the user changes the default character.
- **Syntax**
    - **Sub***agent.**DefaultCharacterChange** **(ByVal**GUID*)\*\*

| Part | Description |
| --- | --- |
| *GUID* | Returns the unique identifier for the character. |

### Remarks

This event indicates when the user has changed the character assigned as the user's default character. The server sends this only to clients that have loaded the default character.

When the new character appears, it assumes the same size as any already loaded instance of the character or the previous default character (in that order).

### See Also

[**ShowDefaultCharacterProperties method**](showdefaultcharacterproperties-method), [**Load method**](load-method)