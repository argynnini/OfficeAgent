---
layout: Conceptual
title: IAgentCommandsEx SetDefaultID - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcommandsex--setdefaultid
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
description: IAgentCommandsEx SetDefaultID
ms.assetid: 056ec518-bf0b-403f-adc6-9b53b0c044a7
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: e0803b29-3f8e-fc88-bea1-0e0d74562eec
document_version_independent_id: 3940e969-b5b3-1eec-cb6c-0571402c2916
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommandsex--setdefaultid.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcommandsex--setdefaultid.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 126
asset_id: lwef/iagentcommandsex--setdefaultid
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcommandsex--setdefaultid.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 1d1280ce-5e66-bd1d-fe73-1d71fed3e886
---

# IAgentCommandsEx SetDefaultID - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT SetDefaultID(
   long dwID,  // default command's ID
);
```

Sets the ID of the default command in a [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection.

- Returns S\_OK to indicate the operation was successful.

- *dwID*
    - The ID for the [**Command**](/en-us/windows/desktop/lwef/the-command-object) to be set as the default.

This property sets the default [**Command**](/en-us/windows/desktop/lwef/the-command-object) object set in your [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection. The default command is bold in the character's pop-up menu. However, setting the default command does not actually change command handling or double-click events.

This property applies only to your client application's use of the character; the setting does not affect other clients of the character or other characters of your client application.