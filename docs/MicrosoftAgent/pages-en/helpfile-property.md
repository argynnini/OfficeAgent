---
layout: Conceptual
title: HelpFile Property - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/helpfile-property
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
description: HelpFile Property
ms.assetid: 18a5fd9b-4ca7-4701-9993-1e0c55f6e232
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: eff4d749-6042-c0f0-f0e7-8a1b2605647b
document_version_independent_id: 020eee0e-2dec-1365-b381-b25028aad0ca
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/helpfile-property.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/helpfile-property.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 173
asset_id: lwef/helpfile-property
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/helpfile-property.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 3b0e0c3b-f07f-7f54-5d42-d31c1349c260
---

# HelpFile Property - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Returns or sets the path and filename for a Microsoft Windows context-sensitive Help file supplied by the client application.
- **Syntax**
    - \*agent.\***Characters("*CharacterID*").Helpfile** [ = *Filename*]

| Part | Description |
| --- | --- |
| *Filename* | A string expression specifying the path and filename of the Windows Help file. |

## Remarks

If you've created a Windows Help file for your application and set the character's **HelpFile** property, Agent automatically calls Help when [**HelpModeOn**](helpmodeon-property) is set to **True** and the user clicks the character or selects a command from its pop-up menu. If you specified a context number in the [**HelpContextID**](helpcontextid-property) property of the selected command, Help displays a topic corresponding to the current Help context; otherwise it displays "No Help topic associated with this item."

This property applies only to your client application's use of the character; the setting does not affect other clients of the character or other characters of your client application.