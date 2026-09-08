---
layout: Conceptual
title: IAgentNotifySink VisibleState - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentnotifysink--visiblestate
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
description: IAgentNotifySink VisibleState
ms.assetid: b0346296-74e9-448f-aa6d-a9fb1e645f05
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: e212675c-06df-a0d9-1df1-f008b6ed84fa
document_version_independent_id: 9d75493a-9002-c613-7e72-e8d20d61f8de
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentnotifysink--visiblestate.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentnotifysink--visiblestate.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 226
asset_id: lwef/iagentnotifysink--visiblestate
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentnotifysink--visiblestate.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: f67838d7-0217-ef58-2bed-af18e9651d1d
---

# IAgentNotifySink VisibleState - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT VisibleState(
   long dwCharID,  // character ID
   long bVisible,  // visibility flag
   long dwCause,   // cause of visible state
);                          
```

Notifies a client application when the visibility state of the character changes.

- No return value.

- *dwCharID*
    - Identifier of the character whose visibility state is changed.
- *bVisible*
    - Visibility flag. This Boolean value is **True** when character becomes visible and **False** when the character becomes hidden.
- *dwCause*
    - Cause of last change to the character's visibility state. The parameter may be one of the following:

| Value | Description |
| --- | --- |
| **const unsigned short** **NeverShown = 0;** | Character has not been shown. |
| **const unsigned short** **UserHid = 1;** | User hid the character with the character's taskbar icon pop-up menu or with speech input.. |
| **const unsigned short** **UserShowed = 2;** | User showed the character. |
| **const unsigned short** **ProgramHid = 3;** | Your application hid the character. |
| **const unsigned short** **ProgramShowed = 4;** | Your application showed the character. |
| **const unsigned short** **OtherProgramHid = 5;** | Another application hid the character. |
| **const unsigned short** **OtherProgramShowed = 6;** | Another application showed the character. |
| **const unsigned short** **UserHidViaCharacterMenu = 7** | User hid the character with the character's pop-up menu. |
| **const unsigned short** **UserHidViaTaskbarIcon = UserHid** | User hid the character with the character's taskbar icon pop-up menu or using speech input. |