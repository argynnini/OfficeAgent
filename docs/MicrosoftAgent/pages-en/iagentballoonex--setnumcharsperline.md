---
layout: Conceptual
title: IAgentBalloonEx SetNumCharsPerLine - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentballoonex--setnumcharsperline
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
description: IAgentBalloonEx SetNumCharsPerLine
ms.assetid: 44025b6b-ed42-4476-b841-c244accf0f83
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: d013ab74-0847-256e-4a8e-d14bbce1bf27
document_version_independent_id: df61a231-c061-22ec-ada7-f8b26e621afe
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentballoonex--setnumcharsperline.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentballoonex--setnumcharsperline.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 129
asset_id: lwef/iagentballoonex--setnumcharsperline
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentballoonex--setnumcharsperline.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 76006a16-3607-89da-0742-f82721cf729c
---

# IAgentBalloonEx SetNumCharsPerLine - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT SetNumCharsPerLine(
   long lCharsPerLine,  // number of characters per line setting
);
```

Sets the number of characters per line that can be displayed in the character's word balloon.

- Returns S\_OK to indicate the operation was successful.
- Returns E\_INVALIDARG if the parameter is less than eight.

- *lCharsPerLine*
    - Number of lines to display in the word balloon.

The minimum setting is 8 and the maximum is 255. If the text specified in the [**Speak**](speak-method) or [**Think**](think-method) method exceeds the size of the current balloon, Agent automatically scrolls the text in the balloon.

The default setting is based on settings when the character is compiled with the Microsoft Agent Character Editor.