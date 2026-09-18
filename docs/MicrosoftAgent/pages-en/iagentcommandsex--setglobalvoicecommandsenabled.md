---
layout: Conceptual
title: IAgentCommandsEx SetGlobalVoiceCommandsEnabled - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcommandsex--setglobalvoicecommandsenabled
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
description: IAgentCommandsEx SetGlobalVoiceCommandsEnabled
ms.assetid: f456b1d3-60aa-4b90-90d0-6c695947fa8a
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 3bc289de-47bc-f551-2cbc-ff24f90fc6ac
document_version_independent_id: 81c72f1b-67ee-0040-dea0-4eeb559b4dc1
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommandsex--setglobalvoicecommandsenabled.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcommandsex--setglobalvoicecommandsenabled.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 188
asset_id: lwef/iagentcommandsex--setglobalvoicecommandsenabled
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcommandsex--setglobalvoicecommandsenabled.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 9719ab37-4b64-73e7-4518-3242c063c4ad
---

# IAgentCommandsEx SetGlobalVoiceCommandsEnabled - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT SetGlobalVoiceCommandsEnabled(
 long bEnable  // Enabled setting for Agent's global voice commands
);
```

Sets the [**Enabled**](enabled-property) property for the voice grammar of Microsoft Agent's global commands.

- Returns S\_OK to indicate the operation was successful.

- *bEnable*
    - A Boolean value that sets whether the voice grammar of Agent's global commands is enabled. **True** enables the voice grammar; **False** disables it.

Microsoft Agent automatically adds voice parameters (grammar) for opening and closing the Voice Commands Window and for showing and hiding the character. When set to **False**, Agent disables any voice parameters for these commands as well as the voice parameters for the [**Caption**](caption-property) of other client's [**Command**](/en-us/windows/desktop/lwef/the-command-object) objects. This enables you to eliminate these from your client's current active grammar. However, because this potentially blocks voice access to other clients, reset this property to **True** after processing the user's voice input.

Disabling the property does not affect the character's pop-up menu. The global commands added by the server will still appear. You cannot remove them from the pop-up menu.