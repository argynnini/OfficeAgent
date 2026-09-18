---
layout: Conceptual
title: IAgentBalloon GetFontCharSet - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentballoon--getfontcharset
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
description: IAgentBalloon GetFontCharSet
ms.assetid: 1ab5767a-31e3-449c-b242-f20b11336ca0
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: c258cdb7-f8a4-57e9-3dac-a0798b754de2
document_version_independent_id: 49bfbff6-5062-7e5b-e8b6-7ad5bbbfedc6
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentballoon--getfontcharset.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentballoon--getfontcharset.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 202
asset_id: lwef/iagentballoon--getfontcharset
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentballoon--getfontcharset.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 76396962-e625-d6ff-5482-faaef408df59
---

# IAgentBalloon GetFontCharSet - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT GetFontCharSet(
   short * psFontCharSet  // character set displayed in word balloon
); 
```

Indicates the character set of the font displayed in a word balloon.

- Returns S\_OK to indicate the operation was successful.

- *psFontCharSet*
    - The address of a value that receives the font's character set. The following are some common settings for value:

| Value | Character set |
| --- | --- |
| 0 | Standard Windows characters (ANSI). |
| 1 | Default character set. |
| 2 | The symbol character set. |
| 128 | Double-byte character set (DBCS) unique to the Japanese version of Windows. |
| 129 | Double-byte character set (DBCS) unique to the Korean version of Windows. |
| 134 | Double-byte character set (DBCS) unique to the Simplified Chinese version of Windows. |
| 136 | Double-byte character set (DBCS) unique to the Traditional Chinese version of Windows. |
| 255 | Extended characters usually displayed by MS-DOS applications. |

For other character set values, consult the Platform SDK documentation.

The default character set used in a character's word balloon is defined in the Microsoft Agent Character Editor. You can change it using [**IAgentBalloon::SetFontCharSet**](iagentballoon--setfontcharset). However, the user can override the character set setting for all characters using the Microsoft Agent property sheet.