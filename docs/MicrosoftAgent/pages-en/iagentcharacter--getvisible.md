---
layout: Conceptual
title: IAgentCharacter GetVisible - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcharacter--getvisible
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
description: IAgentCharacter GetVisible
ms.assetid: 6e8e3a68-a7bb-4afb-a753-836fe82a0b24
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: b3b2471d-de41-eaab-5e6a-39d52684b65b
document_version_independent_id: e6657da3-0dd5-cc44-d90a-e1b67007d274
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacter--getvisible.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacter--getvisible.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 98
asset_id: lwef/iagentcharacter--getvisible
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcharacter--getvisible.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 309142ce-fc7c-07a1-c3ed-b43f256ce0db
---

# IAgentCharacter GetVisible - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT GetVisible(
   long * pbVisible  // address of variable for character Visible setting
);
```

Determines whether the character's animation frame is currently visible.

- Returns S\_OK to indicate the operation was successful.

- *pbVisible*
    - Address of a variable that receives **True** if the character's frame is visible and **False** if hidden.

You can use this method to determine whether the character's frame is currently visible. To make a character visible, use the [**Show**](/en-us/windows/desktop/lwef/iagentcharacter--show) method. To hide a character, use the [**Hide**](/en-us/windows/desktop/lwef/iagentcharacter--hide) method.