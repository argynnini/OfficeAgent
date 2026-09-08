---
layout: Conceptual
title: IAgentCharacter GetMoveCause - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcharacter--getmovecause
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
description: IAgentCharacter GetMoveCause
ms.assetid: 36cdd3bc-65b6-469f-9344-93403c1d24e0
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 7ed3fd73-4ebc-1ba7-872a-af31325a7a7a
document_version_independent_id: 06d25392-6030-af4a-ea5f-1d15a367c9d8
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacter--getmovecause.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacter--getmovecause.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 136
asset_id: lwef/iagentcharacter--getmovecause
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcharacter--getmovecause.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: bc124128-8a22-8582-a526-02e345bdb232
---

# IAgentCharacter GetMoveCause - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT GetMoveCause(
   long * pdwCause  // address of variable for cause of character move
);
```

Retrieves the cause of the character's last move.

- Returns S\_OK to indicate the operation was successful.

- *pdwCause*
    - Address of a variable that receives the cause of the character's last move and will be one of the following:

| Value | Description |
| --- | --- |
| **const unsigned short** **NeverMoved = 0;** | Character has not been moved. |
| **const unsigned short** **UserMoved = 1;** | User dragged the character. |
| **const unsigned short** **ProgramMoved = 2;** | Your application moved the character. |
| **const unsigned short** **OtherProgramMoved = 3;** | Another application moved the character. |
| **const unsigned short** **SystemMoved = 4** | The server moved the character to keep it onscreen after a screen resolution change. |