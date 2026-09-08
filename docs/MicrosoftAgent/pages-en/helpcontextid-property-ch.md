---
layout: Conceptual
title: HelpContextID Property (Characters Object) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/helpcontextid-property-ch
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
description: Learn about the HelpContextID property of the Characters object. Microsoft Agent is deprecated as of Windows 7.
ms.assetid: 7ef190ba-c194-4386-a8d6-d32d902a1c03
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 4e3039fc-2829-60b4-9ee3-4a4d185fd8b5
document_version_independent_id: 3adfb3e0-e5b2-3858-6a5f-1efc7a9748fb
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/helpcontextid-property-ch.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/helpcontextid-property-ch.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 193
asset_id: lwef/helpcontextid-property-ch
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/helpcontextid-property-ch.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 283f14fb-8f63-2af3-7dec-7a0429ba5288
---

# HelpContextID Property (Characters Object) - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Returns or sets an associated context number for the character. Used to provide context-sensitive Help for the character.
- **Syntax**
    - \*agent.\***Characters("*CharacterID*").HelpContextID** [ = *Number*]

| Part | Description |
| --- | --- |
| *Number* | An integer specifying a valid context number. |

## Remarks

To support context-sensitive Help for the character, assign the context number to the character you use for the associated Help topic when you compile your Help file. This property applies only to the client of the character; the setting does not affect other clients of the character or other characters of the client.

If you've created a Windows Help file for your application and set the character's [**HelpFile**](helpfile-property) property, Agent automatically calls Help when [**HelpModeOn**](helpmodeon-property) is set to **True** and the user clicks the character. If there is a context number in the [**HelpContextID**](helpcontextid-property), Agent calls Help and searches for the topic identified by the current context number. The current context number is the value of **HelpContextID** for the character.

Note

Building a Help file requires the Microsoft Windows Help Compiler.