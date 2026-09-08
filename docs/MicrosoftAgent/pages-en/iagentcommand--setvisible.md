---
layout: Conceptual
title: IAgentCommand SetVisible - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcommand--setvisible
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
description: IAgentCommand SetVisible
ms.assetid: 58a383f4-6c98-4037-b469-ae68f06c852d
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: a08f3a37-ef80-fe72-bb02-d659ca7ecdbe
document_version_independent_id: 34892f48-7ba7-9b21-e2aa-8232ca79e5f2
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommand--setvisible.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcommand--setvisible.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 93
asset_id: lwef/iagentcommand--setvisible
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcommand--setvisible.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 67233b22-2a37-d30c-0acd-64074aafc717
---

# IAgentCommand SetVisible - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT SetVisible(
   long bVisible  // Visible setting for Command
);
```

Sets the value of the [**Visible**](visible-property) property for a [**Command**](/en-us/windows/desktop/lwef/the-command-object).

- Returns S\_OK to indicate the operation was successful.

- *bVisible*
    - A Boolean value that determines the [**Visible**](visible-property) property of a [**Command**](/en-us/windows/desktop/lwef/the-command-object). **True** shows the **Command**; **False** hides it.

A [**Command**](/en-us/windows/desktop/lwef/the-command-object) must have its [**Visible**](visible-property) property set to **True** and its [**Caption**](caption-property) property set to appear in the character's pop-up menu.