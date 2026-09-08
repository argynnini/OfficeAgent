---
layout: Conceptual
title: Visible Property (Characters Object) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/visible-property-cob
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
description: Learn about the Visible Property of the Characters object, which returns a Boolean indicating whether the character is visible.
ms.assetid: c06d623d-8997-413a-b4ab-24275eccfa10
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 7979c211-7b50-b32c-d640-fd31c87a2b1f
document_version_independent_id: b36a3637-325d-59ed-95d4-3e4a329fb32d
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/visible-property-cob.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/visible-property-cob.md
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 128
asset_id: lwef/visible-property-cob
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/visible-property-cob.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: b4e9d615-92fb-ac2c-c03d-e2c0f596691c
---

# Visible Property (Characters Object) - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Returns a Boolean indicating whether the character is visible.
- **Syntax**
    - *agent*\*\*.Characters(**"*CharacterID*"**).Visible\*\*

| Value | Description |
| --- | --- |
| True | The character is displayed. |
| False | The character is hidden (not visible). |

## Remarks

This property indicates whether the character's frame is being displayed. It does not necessarily mean that there is an image on the screen. For example, this property returns **True** even when the character is positioned off the visible display area or when the current character frame contains no images. This property's setting applies to all clients of the character.

This property is read-only. To make a character visible or hidden, use the [**Show**](show-method) or [**Hide**](https://www.bing.com/search?q=**Hide**) methods.