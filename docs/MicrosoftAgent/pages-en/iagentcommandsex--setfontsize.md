---
layout: Conceptual
title: IAgentCommandsEx SetFontSize - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcommandsex--setfontsize
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
description: IAgentCommandsEx SetFontSize
ms.assetid: 095f78d2-ef91-4880-ad49-dd9a94f02891
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: cca6c5c8-cc59-8fc6-e6e3-2a56dee20abd
document_version_independent_id: d96c3964-58a9-a4fa-bece-28e5f2882d56
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommandsex--setfontsize.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcommandsex--setfontsize.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 162
asset_id: lwef/iagentcommandsex--setfontsize
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcommandsex--setfontsize.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: c3bd2031-b033-65f0-c468-0a1382fab371
---

# IAgentCommandsEx SetFontSize - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT SetFontSize(
   long lFontSize  // font size displayed in character's pop-up menu
);
```

Sets the size of the font displayed in the character's pop-up menu.

- Returns S\_OK to indicate the operation was successful.

- *lFontSize*
    - The size of the font.

This property determines the point size of the font used to display text in the character's pop-up menu when your client application is input-active. The default value for the font setting is based on the menu font setting for the character's language ID setting-or if that's not set-the user default language setting. If not input-active, your client application's [**Command**](/en-us/windows/desktop/lwef/the-command-object)[**Caption**](caption-property) text appears in the point size specified for the input-active client.

This property applies only to your client application's use of the character; the setting does not affect other clients of the character or other characters of your client application.