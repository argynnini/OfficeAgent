---
layout: Conceptual
title: IAgentCharacter SetPosition - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcharacter--setposition
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
description: IAgentCharacter SetPosition
ms.assetid: cc47b537-8154-4dfb-93e1-5ac3c3b50788
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 78fffabb-0ecf-863b-fdf2-45f466c0173c
document_version_independent_id: 06ab0dd0-0e23-0363-0adb-25588c97236f
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacter--setposition.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacter--setposition.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 144
asset_id: lwef/iagentcharacter--setposition
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcharacter--setposition.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 3588c9b9-ff39-cecf-bf29-112c05e3bbef
---

# IAgentCharacter SetPosition - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT SetPosition(
   long lLeft,  // screen coordinate of the left edge of character 
   long lTop    // screen coordinate of the top edge of character 
);
```

Sets the position of the character's animation frame.

- Returns S\_OK to indicate the operation was successful.

- *lLeft*
    - Screen coordinate of the character animation frame's left edge in pixels, relative to the screen origin (upper left).
- *lTop*
    - Screen coordinate of the character animation frame's top edge in pixels, relative to the screen origin (upper left).

This property's setting applies to all clients of the character. Even though the character appears in an irregularly shaped region window, the location of the character is based on its rectangular animation frame.

Note

Unlike the [**MoveTo**](https://www.bing.com/search?q=**MoveTo**) method, this function is not queued.