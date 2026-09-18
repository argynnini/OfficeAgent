---
layout: Conceptual
title: Enabled Property (Speech Input Object) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/enabled-property-sio
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
description: Learn about the Enabled Speech Input object property. Microsoft Agent is deprecated as of Windows 7.
ms.assetid: d48f02f1-7d93-4780-88a7-61597672bb58
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 83226414-50b2-0aff-68e7-162b812215ac
document_version_independent_id: 1f477fa2-9a01-513c-8aee-a6121161eb9c
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/enabled-property-sio.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/enabled-property-sio.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 87
asset_id: lwef/enabled-property-sio
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/enabled-property-sio.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 5dd83793-9259-7c22-752d-22dad9640826
---

# Enabled Property (Speech Input Object) - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Returns a Boolean value indicating whether speech input is enabled.
- **Syntax**
    - *agent*\*\*.SpeechInput.Enabled\*\*

| Value | Description |
| --- | --- |
| **True** | Speech input is enabled. |
| **False** | Speech input is disabled. |

## Remarks

The [**Enabled**](enabled-property) property reflects the Characters Listen For Input option on the Speech Input page of the Agent property sheet (Advanced Character Options). The property setting affects all Agent characters and is read-only; only the user can change this property.