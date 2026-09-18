---
layout: Conceptual
title: IAgentCommands Insert - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcommands--insert
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
description: IAgentCommands Insert
ms.assetid: f450aae4-db6f-4326-ae14-ddb68ab0953a
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: e02badf6-a263-a286-0000-74b95a1154c5
document_version_independent_id: b14b3667-88f5-4dab-7a18-c134a307afa7
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommands--insert.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentcommands--insert.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 255
asset_id: lwef/iagentcommands--insert
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcommands--insert.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://authoring-docs-microsoft.poolparty.biz/devrel/8b896464-3b7d-4e1f-84b0-9bb45aeb5f64
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://authoring-docs-microsoft.poolparty.biz/devrel/b1d2d671-9549-46e8-918c-24349120dbf5
platformId: ba2a53d9-d81e-517a-af0d-20f8f31da654
---

# IAgentCommands Insert - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT Insert(
   BSTR bszCaption,  // Caption setting for Command
   BSTR bszVoice,    // Voice setting for Command
   long bEnabled,    // Enabled setting for Command
   long bVisible,    // Visible setting for Command
   long dwRefID,     // reference Command for insertion
   long dBefore,     // insertion position flag
   long * pdwID      // address for variable for Command ID
);
```

Inserts a [**Command**](/en-us/windows/desktop/lwef/the-command-object) object in a [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection.

- Returns S\_OK to indicate the operation was successful.

- *bszCaption*
    - A BSTR that specifies the value of the [**Caption**](caption-property) text displayed for the [**Command**](/en-us/windows/desktop/lwef/the-command-object).
- *bszVoice*
    - A BSTR that specifies the value of the [**Voice**](voice-property) text setting for a [**Command**](/en-us/windows/desktop/lwef/the-command-object).
- *bEnabled*
    - A Boolean expression that specifies the [**Enabled**](enabled-property) setting for a [**Command**](/en-us/windows/desktop/lwef/the-command-object). If the parameter is **True**, the **Command** is enabled and can be selected; if **False**, the **Command** is disabled.
- *bVisible*
    - A Boolean expression that specifies the [**Visible**](visible-property) setting for a [**Command**](/en-us/windows/desktop/lwef/the-command-object). If the parameter is **True**, the **Command** will be visible in the character's pop-up menu (if the [**Caption**](caption-property) property is also set).
- *dwRefID*
    - The ID of a [**Command**](/en-us/windows/desktop/lwef/the-command-object) used as a reference for the relative insertion of the new **Command**.
- *dBefore*
    - A Boolean expression that specifies where to place the [**Command**](/en-us/windows/desktop/lwef/the-command-object). If this parameter is **True**, the new **Command** is inserted before the referenced **Command**; if **False**, the new **Command** is placed after the referenced **Command**.
- *pdwID*
    - Address of a variable that receives the ID for the inserted [**Command**](/en-us/windows/desktop/lwef/the-command-object).