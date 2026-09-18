---
layout: Conceptual
title: DefaultCommand Property - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/defaultcommand-property
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
description: DefaultCommand Property
ms.assetid: ba4d51fc-7178-4dbb-9ae5-f1991f40aad6
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: d0aef1e8-fe32-b36f-ca51-98bf9ccab3b0
document_version_independent_id: 413c7b22-954d-ab66-5311-12a8665ce3c0
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/defaultcommand-property.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/defaultcommand-property.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 111
asset_id: lwef/defaultcommand-property
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/defaultcommand-property.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: d0ef28c0-786e-374c-b4d1-e807c2da56fe
---

# DefaultCommand Property - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Returns or sets the default command of the [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) object.
- **Syntax**
    - \*agent.\***Characters** **("*CharacterID*").Commands.DefaultCommand** [ = *string*]

| Part | Description |
| --- | --- |
| *string* | A string value identifying the name (ID) of the [**Command**](/en-us/windows/desktop/lwef/the-command-object). |

## Remarks

This property enables you to set a [**Command**](/en-us/windows/desktop/lwef/the-command-object) in your [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection as the default command, rendering it bold. This does not actually change command handling or double-click events.

This property applies only to your client application's use of the character; the setting does not affect other clients of the character or other characters of your client application.