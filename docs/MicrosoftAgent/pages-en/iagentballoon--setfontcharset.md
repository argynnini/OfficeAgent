---
layout: Conceptual
title: IAgentBalloon SetFontCharSet - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentballoon--setfontcharset
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
description: IAgentBalloon SetFontCharSet
ms.assetid: ce1b152d-c8af-47ec-9e6b-5768dbcf3566
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 2f160ebf-e9ef-c2b8-d8ab-f2bed8d2b713
document_version_independent_id: fe167d97-a4e7-2e0f-c592-0a5d25a28751
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentballoon--setfontcharset.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentballoon--setfontcharset.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 225
asset_id: lwef/iagentballoon--setfontcharset
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentballoon--setfontcharset.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 0c47753c-8ca0-81fa-05ff-33d5ec4c6956
---

# IAgentBalloon SetFontCharSet - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT SetFontCharSet(
   short sFontCharSet  // character set displayed in word balloon
); 
```

Sets the character set of the font displayed in the word balloon.

- Returns S\_OK to indicate the operation was successful.

- *sFontCharSet*
    - The character set of the font. The following are some common settings for value:

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

The default character set used in a character's word balloon is defined in the Microsoft Agent Character Editor. You can change it with [**IAgentBalloon::SetFontCharSet**](https://www.bing.com/search?q=**IAgentBalloon::SetFontCharSet**). However, the user can override the character set setting for all characters using the Microsoft Agent property sheet. This property applies only to your client application's use of the character; the setting does not affect other clients of the character or other characters of your client application.