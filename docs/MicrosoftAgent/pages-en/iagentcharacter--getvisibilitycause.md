---
layout: Conceptual
title: IAgentCharacter GetVisibilityCause - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcharacter--getvisibilitycause
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
description: IAgentCharacter GetVisibilityCause
ms.assetid: 46f681de-1c99-4f90-a3fe-aae04bb75339
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 49f1b6bf-f4f5-517e-b1c2-c47a41228b5f
document_version_independent_id: aceddea4-5d65-7a9a-3c36-51d0b12d49c1
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacter--getvisibilitycause.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacter--getvisibilitycause.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 198
asset_id: lwef/iagentcharacter--getvisibilitycause
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcharacter--getvisibilitycause.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 0aac813d-1893-67bc-2c73-8e13b1c9e36c
---

# IAgentCharacter GetVisibilityCause - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT GetVisibilityCause(
   long * pdwCause  // address of variable for cause of character visible state
);
```

Retrieves the cause of the character's visible state.

- Returns S\_OK to indicate the operation was successful.

- *pdwCause*
    - Address of a variable that receives the cause of the character's last visibility state change and will be one of the following:

| Value | Description |
| --- | --- |
| **const unsigned short** **NeverShown = 0;** | Character has not been shown. |
| **const unsigned short** **UserHid = 1;** | User hid the character with the character's taskbar icon pop-up menu or using speech input. |
| **const unsigned short** **UserShowed = 2;** | User showed the character. |
| **const unsigned short** **ProgramHid = 3;** | Your application hid the character. |
| **const unsigned short** **ProgramShowed = 4;** | Your application showed the character. |
| **const unsigned short** **OtherProgramHid = 5;** | Another application hid the character. |
| **const unsigned short** **OtherProgramShowed = 6;** | Another application showed the character. |
| **const unsigned short** **UserHidViaCharacterMenu = 7** | User hid the character with the character's pop-up menu. |
| **const unsigned short** **UserHidViaTaskbarIcon = UserHid** | User hid the character with the character's taskbar icon pop-up menu or using speech input. |