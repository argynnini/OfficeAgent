---
layout: Conceptual
title: IAgentCommands Add - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcommands--add
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
description: IAgentCommands Add
ms.assetid: f6be7773-77fa-4c59-8feb-c2ebf54fd2e0
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 5b03aaa3-222c-fdd6-50a2-5a1a40d6d7c5
document_version_independent_id: ca56ad6d-ceda-f5d9-b10a-bb557ee055e3
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommands--add.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcommands--add.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 206
asset_id: lwef/iagentcommands--add
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcommands--add.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 46b9a5e7-ccaf-091d-379b-202dd894831c
---

# IAgentCommands Add - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT Add(
   BSTR bszCaption,  // Caption setting for Command
   BSTR bszVoice,    // Voice setting for Command
   long bEnabled,    // Enabled setting for Command
   long bVisible,    // Visible setting for Command
   long * pdwID      // address for variable for ID
);
```

Adds a [**Command**](/en-us/windows/desktop/lwef/the-command-object) to a [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection.

- Returns S\_OK to indicate the operation was successful.

- *bszCaption*
    - A BSTR that specifies the value of the [**Caption**](caption-property) text displayed for a [**Command**](/en-us/windows/desktop/lwef/the-command-object) in a [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection.
- *bszVoice*
    - A BSTR that specifies the value of the [**Voice**](voice-property) text setting for a [**Command**](/en-us/windows/desktop/lwef/the-command-object) in a [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection.
- *bEnabled*
    - A Boolean expression that specifies the [**Enabled**](enabled-property) setting for a [**Command**](/en-us/windows/desktop/lwef/the-command-object) in a [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection. If the parameter is **True**, the **Command** is enabled and can be selected; if **False**, the **Command** is disabled.
- *bVisible*
    - A Boolean expression that specifies the [**Visible**](visible-property) setting for a [**Command**](/en-us/windows/desktop/lwef/the-command-object) in a [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection. If the parameter is **True**, the **Command** will be visible in the character's pop-up menu (if the [**Caption**](caption-property) property is also set).
- *pdwID*
    - Address of a variable that receives the ID for the added [**Command**](/en-us/windows/desktop/lwef/the-command-object).