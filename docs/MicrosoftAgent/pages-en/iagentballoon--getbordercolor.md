---
layout: Conceptual
title: IAgentBalloon GetBorderColor - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentballoon--getbordercolor
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
description: IAgentBalloon GetBorderColor
ms.assetid: e6c592c3-0e14-474f-a829-6028f2de5791
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: c4d065cd-156c-16a0-e2fc-4e4a0e9f849c
document_version_independent_id: 33fe1582-1b3d-1265-2021-56547a852de5
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentballoon--getbordercolor.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentballoon--getbordercolor.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 118
asset_id: lwef/iagentballoon--getbordercolor
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentballoon--getbordercolor.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 0dbbc74d-d74e-1750-ee11-5d5deebb8a91
---

# IAgentBalloon GetBorderColor - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT GetBorderColor (
  long * plBorderColor// address of variable for border color displayed
);                    // for word balloon
```

Retrieves the value for the border color displayed for a word balloon.

- Returns S\_OK to indicate the operation was successful.

- *plBorderColor*
    - The address of a variable that receives the color setting for the balloon border.

The border color for a character word balloon is defined in the Microsoft Agent Character Editor. It cannot be changed by an application. However, the user can change the border color of the word balloons for all characters through the Microsoft Agent property sheet.