---
layout: Conceptual
title: SoundEffects Property - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/soundeffects-property
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
description: SoundEffects Property
ms.assetid: 39e48e5f-b24e-48ce-b5a3-85467ac252e9
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 328a17ef-3c77-b25b-5e50-0db42c6d4109
document_version_independent_id: 16f52682-503d-1844-1aaf-edb7bba08850
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/soundeffects-property.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/soundeffects-property.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 124
asset_id: lwef/soundeffects-property
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/soundeffects-property.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: c3d29b6a-588b-a61d-86c8-37b3310b6093
---

# SoundEffects Property - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Returns a Boolean indicating whether sound effects (.WAV) files configured as part of a character's actions will play.
- **Syntax**
    - *agent*\*\*.AudioOutput.SoundEffects\*\*

| Value | Description |
| --- | --- |
| **True** | Character sound effects are enabled. |
| **False** | Character sound effect are disabled. |

## Remarks

This property reflects the Play Character Sound Effects option on the Output page of the Agent property sheet (Advanced Character Options). When the **SoundEffects** property returns **True**, sound effects included in a character's definition will be played. When **False**, the sound effects will not be played. The property setting affects all characters and is read-only; only the user can set this property value.