---
layout: Conceptual
title: Enabled Property (Command Object) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/enabled-property-co
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
description: Learn about the Enabled Command object property. Microsoft Agent is deprecated as of Windows 7.
ms.assetid: d9dcbdf0-ba35-4ebd-b6f2-f3c8bdfc0431
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: e96dd39b-f131-6658-88bb-0e7bbf2c6750
document_version_independent_id: 99172b9a-ffca-5222-e29e-4c8ed52ae3af
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/enabled-property-co.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/enabled-property-co.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 115
asset_id: lwef/enabled-property-co
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/enabled-property-co.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 2ebec279-6381-1006-0933-54dd04e28533
---

# Enabled Property (Command Object) - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Returns or sets whether the **Command** is enabled in the specified character's pop-up menu.
- **Syntax**
    - *agent*\*\*.Characters ("***CharacterID***").Commands("***name***").Enabled\*\* [ = *boolean*]

| Part | Description |
| --- | --- |
| *boolean* | A Boolean expression specifying whether the **Command** is enabled.<br>- **True**<br>    - The **Command** is enabled.<br>- **False**<br>    - The **Command** is disabled. |

## Remarks

If the [**Enabled**](enabled-property) property is set to **True**, the [**Command**](/en-us/windows/desktop/lwef/the-command-object) objects's caption appears as normal text in the character's pop-up menu when the client application is input-active. If the **Enabled** property is **False**, the caption appears as unavailable (disabled) text. A disabled **Command** is also not accessible for voice input.