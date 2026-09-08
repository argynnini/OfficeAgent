---
layout: Conceptual
title: ListeningTip Property - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/listeningtip-property
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
description: ListeningTip Property
ms.assetid: 02a678bb-5eb6-495f-b339-35170a44b15e
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: ae8a866a-51da-78bc-752b-0e334bc94e1f
document_version_independent_id: 2de8c38c-26b6-7e76-d123-eb70f83e186f
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/listeningtip-property.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/listeningtip-property.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 98
asset_id: lwef/listeningtip-property
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/listeningtip-property.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 984d3b0d-d822-071c-32e8-2592410f3680
---

# ListeningTip Property - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Returns a Boolean indicating the current user setting for the Listening Tip.
- **Syntax**
    - *agent*\*\*.SpeechInput.ListeningTip\*\*

| Value | Description |
| --- | --- |
| **True** | The Listening Tip is enabled. |
| **False** | The Listening Tip is disabled. |

## Remarks

The **ListeningTip** property indicates whether the Display Listening Tip option in the Microsoft Agent property sheet (Advanced Character Options) is enabled. When **ListeningTip** returns **True** and speech input is enabled, the server displays the tip window when the user presses the Listening key.