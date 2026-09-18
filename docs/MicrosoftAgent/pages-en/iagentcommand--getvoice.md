---
layout: Conceptual
title: IAgentCommand GetVoice - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcommand--getvoice
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
description: IAgentCommand GetVoice
ms.assetid: 69f3c91b-2ccf-4bea-8034-0c3e0a5e4ec4
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 23c4ccf7-b763-2021-3d81-0c9e88b9e634
document_version_independent_id: 1624ce0a-e3b1-8991-969f-679e9f1c0941
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommand--getvoice.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcommand--getvoice.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 116
asset_id: lwef/iagentcommand--getvoice
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcommand--getvoice.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 872e66cd-a56b-a491-5be2-ca6490051bb0
---

# IAgentCommand GetVoice - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT GetVoice(
   BSTR * pbszVoice  // address of Voice setting for Command
);
```

Retrieves the value of the [**Voice**](voice-property) text property for a [**Command**](/en-us/windows/desktop/lwef/the-command-object).

- Returns S\_OK to indicate the operation was successful.

- *pbszVoice*
    - The address of a BSTR that receives the [**Voice**](voice-property) text property for a [**Command**](/en-us/windows/desktop/lwef/the-command-object).

A [**Command**](/en-us/windows/desktop/lwef/the-command-object) with its [**Voice**](voice-property) property set and its [**Enabled**](enabled-property) property set to **True** will be voice-accessible. If its [**Caption**](caption-property) property is also set it appears in the Voice Commands Window. If its [**Visible**](visible-property) property is set to **True**, it appears in the character's pop-up menu.