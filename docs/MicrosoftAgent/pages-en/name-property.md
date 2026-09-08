---
layout: Conceptual
title: Name Property (Characters Object) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/name-property
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
description: Learn about the Name property of the Characters object. Microsoft Agent is deprecated as of Windows 7.
ms.assetid: vs|msagent|~\pacontrol_2bxm.htm
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 933c2cb2-2871-dcef-d976-45b90fd80a82
document_version_independent_id: 05cf86a8-973f-2cec-c648-ecb859a735f7
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/name-property.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/name-property.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 143
asset_id: lwef/name-property
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/name-property.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: bb1b7b97-ec18-8ed5-dd0a-71ca89759abd
---

# Name Property (Characters Object) - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Returns or sets a string that specifies the default name of the specified character.
- **Syntax**
    - *agent*\*\*.Characters ("***CharacterID***").Name\*\* [ = *string*]

| Part | Description |
| --- | --- |
| *string* | A string value corresponding to the character's name (in the current language setting). |

## Remarks

A character's **Name** may depend on the character's [**LanguageID**](languageid-property) setting. A character's name in one language may be different or use different characters than in another. The character's default **Name** for a specific language is defined when the character is compiled with the Microsoft Agent Character Editor.

Avoid renaming a character, especially when using it in a scenario where other client applications may use the same character. Also, Agent uses the character's **Name** to automatically create commands for hiding and showing the character.