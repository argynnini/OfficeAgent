---
layout: Conceptual
title: IAgentCommands GetVoice - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcommands--getvoice
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
description: IAgentCommands GetVoice
ms.assetid: ef8983bc-c70c-48c7-9c5f-1dae61028d90
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 4590cda3-d384-8d47-031a-53bf23ff958a
document_version_independent_id: 5da17832-434f-ed4a-2210-489b2861e56f
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommands--getvoice.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcommands--getvoice.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 75
asset_id: lwef/iagentcommands--getvoice
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcommands--getvoice.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 806977e7-972c-62c4-111c-0ed2d6991f9e
---

# IAgentCommands GetVoice - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT GetVoice(
   BSTR * pbszVoice  // address of Voice setting for Commands collection
);
```

Retrieves the value of the [**Voice**](voice-property) property for a [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection.

- Returns S\_OK to indicate the operation was successful.

- *pbszVoice*
    - The address of a BSTR that receives the value of the [**Voice**](voice-property) text setting for a [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection.