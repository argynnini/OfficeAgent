---
layout: Conceptual
title: HelpContextID Property (Commands Collection Object) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/helpcontextid-property
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
description: Learn about the HelpContextID property of the Commands Collection object. Microsoft Agent is deprecated as of Windows 7.
ms.assetid: 8b8ac1c6-1a34-45f1-a0a6-2ae14ad6adef
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 62c64114-8945-53ae-8a01-99ff02077360
document_version_independent_id: 12c5d981-8ca5-8e11-b7a0-777241dfd780
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/helpcontextid-property.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/helpcontextid-property.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 161
asset_id: lwef/helpcontextid-property
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/helpcontextid-property.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 9dfdf9cd-f174-4ce9-960a-3c135a9f7b7c
---

# HelpContextID Property (Commands Collection Object) - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Returns or sets an associated context number for the [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) object. Used to provide context-sensitive Help for the **Commands** object.
- **Syntax**
    - \*agent.\***Characters("*CharacterID*").Commands("*name*").HelpContextID** [ = *Number*]

| Part | Description |
| --- | --- |
| *Number* | An integer specifying a valid context number. |

## Remarks

If you've created a Windows Help file for your application and set the character's [**HelpFile**](helpfile-property) property, Agent automatically calls Help when [**HelpModeOn**](helpmodeon-property) is set to **True** and the user selects the [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) object. If you set a context number in the **HelpContextID**, Agent calls Help and searches for the topic identified by that context number.

This property applies only to your client application's use of the character; the setting does not affect other clients of the character or other characters of your client application.

Note

Building a Help file requires the Microsoft Windows Help Compiler.