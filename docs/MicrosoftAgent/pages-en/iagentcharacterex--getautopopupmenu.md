---
layout: Conceptual
title: IAgentCharacterEx GetAutoPopupMenu - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcharacterex--getautopopupmenu
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
description: IAgentCharacterEx GetAutoPopupMenu
ms.assetid: c29bfd6e-c7eb-426e-be38-2fa0bdb13211
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: f0efda8b-ea4e-8cf9-b730-15e49ecd4e71
document_version_independent_id: 41b43875-a0d0-ac67-ab65-88087a0511cd
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacterex--getautopopupmenu.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacterex--getautopopupmenu.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 124
asset_id: lwef/iagentcharacterex--getautopopupmenu
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcharacterex--getautopopupmenu.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 20f536f8-5255-ba22-456c-cec29d304bd1
---

# IAgentCharacterEx GetAutoPopupMenu - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT GetAutoPopupMenu(
   long * pbAutoPopupMenu  // address of auto pop-up menu display setting
);
```

Retrieves whether the server automatically displays the character's pop-up menu.

- Returns S\_OK to indicate the operation was successful.

- *pbAutoPopupMenu*
    - Address of a variable that receives **True** if the Microsoft Agent server automatically handles displaying the character's pop-up menu and **False** if not.

When this property is set to **False**, your application must display the pop-up menu using [**IAgentCharacterEx::ShowPopupMenu**](iagentcharacterex--showpopupmenu) method.

This property applies only to your client application's use of the character; the setting does not affect other clients of the character or other characters of your client application.