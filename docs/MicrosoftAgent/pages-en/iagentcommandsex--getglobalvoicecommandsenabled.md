---
layout: Conceptual
title: IAgentCommandsEx GetGlobalVoiceCommandsEnabled - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcommandsex--getglobalvoicecommandsenabled
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
description: IAgentCommandsEx GetGlobalVoiceCommandsEnabled
ms.assetid: 9c8fa978-a02b-4dfc-8cf7-e066c5b75122
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 133ff1ba-9d59-e21c-272e-7ec2dad834c6
document_version_independent_id: 3e3a3176-3223-e7a4-4268-5a6e964b82a0
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommandsex--getglobalvoicecommandsenabled.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcommandsex--getglobalvoicecommandsenabled.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 154
asset_id: lwef/iagentcommandsex--getglobalvoicecommandsenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcommandsex--getglobalvoicecommandsenabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 541e5017-3384-4c16-2e24-055ec2dc2678
---

# IAgentCommandsEx GetGlobalVoiceCommandsEnabled - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT GetGlobalVoiceCommandsEnabled(
   long * pbEnabled  // address of the global voice command setting
);
```

Retrieves whether the voice grammar for Agent's global commands is enabled.

- Returns S\_OK to indicate the operation was successful.

- *pbEnabled*
    - The address that receives **True** if the voice grammar for Agent's global commands is enabled, **False** if disabled.

Microsoft Agent automatically adds voice parameters (grammar) for opening and closing the Voice Commands Window and for showing and hiding the character. When this method returns **False**, any voice parameters for these commands as well as the voice parameters for the [**Caption**](caption-property) of other clients' [**Command**](/en-us/windows/desktop/lwef/the-command-object) objects are not included in the grammar. This enables you to eliminate these from your client's current active grammar. However, this setting does not reflect the inclusion of these commands in the character's pop-up menu.