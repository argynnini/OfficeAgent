---
layout: Conceptual
title: IAgentCommandsEx GetDefaultID - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcommandsex--getdefaultid
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
description: IAgentCommandsEx GetDefaultID
ms.assetid: 14079ae0-ad2c-4f38-9371-9914f8402e49
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: a6477ffe-1053-f1b4-d69c-a0a7789af491
document_version_independent_id: 6bf4f12a-171e-3e55-b1bb-cc42ac1693c4
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommandsex--getdefaultid.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcommandsex--getdefaultid.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 132
asset_id: lwef/iagentcommandsex--getdefaultid
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcommandsex--getdefaultid.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 81b51123-1344-2195-466b-1f0a4103f890
---

# IAgentCommandsEx GetDefaultID - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT GetDefaultID(
   long * pdwID  // address of default command's ID
);
```

Retrieves the ID of the default command in a [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection.

- Returns S\_OK to indicate the operation was successful.

- *pdwID*
    - Address of a variable that receives the ID of the [**Command**](/en-us/windows/desktop/lwef/the-command-object) set as the default.

This property returns the current default [**Command**](/en-us/windows/desktop/lwef/the-command-object) object in your [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection. The default command is bold in the character's pop-up menu. However, setting the default command does not change command handling or double-click events.

This property applies only to your client application's use of the character; the setting does not affect other clients of the character or other characters of your client application.