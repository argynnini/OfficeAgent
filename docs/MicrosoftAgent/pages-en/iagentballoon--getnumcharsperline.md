---
layout: Conceptual
title: IAgentBalloon GetNumCharsPerLine - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentballoon--getnumcharsperline
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
description: IAgentBalloon GetNumCharsPerLine
ms.assetid: ae0c7fff-8c58-465e-9b4f-3260f7574b57
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: db924a34-b0a4-9fed-2671-b50c5b550a8e
document_version_independent_id: 1eafd75d-427c-dcea-f875-5de7ebee118c
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentballoon--getnumcharsperline.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentballoon--getnumcharsperline.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 121
asset_id: lwef/iagentballoon--getnumcharsperline
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentballoon--getnumcharsperline.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 6923b34d-3966-8c63-b0a9-bd6ad001e250
---

# IAgentBalloon GetNumCharsPerLine - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT GetNumCharsPerLine(
   long * plCharsPerLine  // address of variable for characters per line
);                        // displayed in word balloon
```

Retrieves the value for the average number of characters per line displayed in a word balloon.

- Returns S\_OK to indicate the operation was successful.

- *pbCharsPerLine*
    - The address of a variable that receives the number of characters per line.

The Microsoft Agent server automatically scrolls the lines displayed for spoken output in the word balloon. The average number of characters per line for a character's word balloon is defined in the Microsoft Agent Character Editor. It cannot be changed by an application.