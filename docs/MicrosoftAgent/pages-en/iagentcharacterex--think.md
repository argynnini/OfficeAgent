---
layout: Conceptual
title: IAgentCharacterEx Think - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcharacterex--think
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
description: IAgentCharacterEx Think
ms.assetid: 64bfa388-0db7-423c-a4af-64a9f7351e9a
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: c51254af-3d32-bc98-8025-f628d9af7e0d
document_version_independent_id: 46e2aae8-e1e6-450e-b7a1-e4a7cef017d8
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacterex--think.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacterex--think.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 249
asset_id: lwef/iagentcharacterex--think
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcharacterex--think.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: fb3d377d-4f56-0229-2887-7cd8924ce98d
---

# IAgentCharacterEx Think - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT Think(
   BSTR bszText,    // text to think
   long * pdwReqID  // address of a request ID
);
```

Displays the character's thought word balloon with the specified text.

- Returns S\_OK to indicate the operation was successful.

- *bszText*
    - The text to appear in the character's thought balloon.
- *pdwReqID*
    - Address of a variable that receives the **Think** request ID.

Like the [**IAgentCharacter::Speak**](iagentcharacter--speak) method, the **Think** method is a queued request that displays text in a word balloon, except that thoughts display in a special thought balloon. The thought balloon supports only the Bookmark speech control tag (**\Mrk**) and ignores any other speech control tags. Unlike **IAgentCharacter::Speak**, the **Think** method does not change the character's animation state.

The [**IAgentBalloon**](/en-us/windows/desktop/lwef/iagentballoon) settings also apply to the appearance style of the thought balloon. For example, the balloon's [**Enabled**](enabled-property) property must also be **True** for the text to display.

Microsoft Agent's automatic word breaking in the word balloon breaks words using white-space characters (for example, space and tab). However, it may break a word to fit the balloon as well. In languages like Japanese, Chinese, and Thai, where spaces are not used to break words, insert a Unicode zero width space character (0x200B) between characters to define logical word breaks.

Note

Set the character's language ID (using [**IAgentCharacterEx::SetLanguageID**](iagentcharacterex--setlanguageid) before using the [**IAgentCharacter::Speak**](iagentcharacter--speak) method to ensure appropriate text display within the word balloon.