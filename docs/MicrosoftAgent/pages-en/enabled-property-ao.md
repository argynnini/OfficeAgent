---
layout: Conceptual
title: Enabled Property (AudioOutput Object) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/enabled-property-ao
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
description: Learn about the Enabled AudioOutput object property. Microsoft Agent is deprecated as of Windows 7.
ms.assetid: 6526f249-be13-4732-b79e-a9952489461f
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 3e334f08-02ef-c28f-c3d8-cb7f2468a0e0
document_version_independent_id: 7e31dd86-9ad4-c5ec-7d90-ceaa2e7591bb
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/enabled-property-ao.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/enabled-property-ao.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 139
asset_id: lwef/enabled-property-ao
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/enabled-property-ao.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: d0ff1f31-c677-70a3-54ce-526f7ee8cda1
---

# Enabled Property (AudioOutput Object) - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Returns a Boolean indicating whether audio (spoken) output is enabled.
- **Syntax**
    - *agent*\*\*.AudioOutput.Enabled\*\*

| Value | Description |
| --- | --- |
| **True** | (Default) Spoken audio output is enabled. |
| **False** | Spoken audio output is disabled. |

## Remarks

This property reflects the Play Audio Output option on the Output page of the Agent property sheet (Advanced Character Options). When the [**Enabled**](enabled-property) property returns **True**, the [**Speak**](speak-method) method produces audio output if a compatible TTS engine is installed or you use sound files for spoken output. When it returns **False**, it means that speech output is not installed or has been disabled by the user. The property setting applies to all Agent characters and is read-only; only the user can set this property value.