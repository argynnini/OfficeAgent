---
layout: Conceptual
title: Width Property (Characters Object) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/width-property-co
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
description: Learn about the Width Property of the Characters object, which returns or sets the width of the frame for the specified character.
ms.assetid: ebada4cc-dbe6-4540-be1f-1f61e176765b
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 2f95adfe-6123-cbd0-9faa-a0fd20973702
document_version_independent_id: c338f901-762f-75a7-8e47-37c4db377128
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/width-property-co.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/width-property-co.md
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 111
asset_id: lwef/width-property-co
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/width-property-co.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 141a0b61-b4f8-560a-7292-77045c9bfee9
---

# Width Property (Characters Object) - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Returns or sets the width of the frame for the specified character.
- **Syntax**
    - *agent*\*\*.Characters ("***CharacterID***").Width\*\* [= *value*]

| Part | Description |
| --- | --- |
| *value* | A Long integer that specifies the character's frame width. |

## Remarks

The [**Width**](width-property) property is always expressed in pixels. This property's setting applies to all clients of the character.

Even though the character appears in an irregularly shaped region window, the location of the character is based on the external dimensions of the rectangular animation frame used when the character was compiled with the Microsoft Agent Character Editor.