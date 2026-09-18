---
layout: Conceptual
title: IAgentBalloonEx GetStyle - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentballoonex--getstyle
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
description: IAgentBalloonEx GetStyle
ms.assetid: 7c6a7260-073b-4535-b8e7-a8cae9aae9ef
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 091ece34-ee1d-bba1-affd-61698524f5ae
document_version_independent_id: 5998813b-23fc-aa00-681b-5e621a5f77f6
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentballoonex--getstyle.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentballoonex--getstyle.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 372
asset_id: lwef/iagentballoonex--getstyle
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentballoonex--getstyle.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: d38d5ce0-e791-2af0-35ac-f84e3a03c6d3
---

# IAgentBalloonEx GetStyle - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT GetStyle(
   long * plStyle,  // address of style settings
);
```

Retrieves the character's word balloon style settings.

- Returns S\_OK to indicate the operation was successful.

- *plStyle*
    - Style settings for the word balloon, which can be a combination of any of the following values:

| Value | Description |
| --- | --- |
| **const unsigned short** **BALLOON\_STYLE\_BALLOONON = 0x00000001;** | The balloon is supported for output. |
| **const unsigned short** **BALLOON\_STYLE \_SIZETOTEXT = 0x0000002;** | The balloon height is sized to accommodate the text output. |
| **const unsigned short** **BALLOON\_STYLE \_AUTOHIDE = 0x00000004;** | The balloon is automatically hidden. |
| **const unsigned short** **BALLOON\_STYLE \_AUTOPACE = 0x00000008;** | The text output is paced based on the output rate. |

When the **BalloonOn** style bit is set, the word balloon appears when the [**Speak**](speak-method) or [**Think**](think-method) method is used, unless the user overrides its display through the Microsoft Agent property sheet. When not set, no balloon appears.

When the **SizeToText** style bit is set, the word balloon automatically sizes the height of the balloon to the current size of the text specified in the [**Speak**](speak-method) or [**Think**](think-method) method. When not set, the balloon's height is based on the balloon's number of lines property setting. This style bit is set to 1 and an attempt to use [**IAgentBalloonEx::SetNumLines**](iagentballoonex--setnumlines) will result in an error.

When the **AutoHide** style bit is set, the word balloon automatically hides after a short time-out. When not set, the balloon displays until a new [**Speak**](speak-method) or [**Think**](think-method) call, the character is hidden, or the user clicks or drags the character.

When the **AutoPace** style bit is set, the word balloon paces the output based on the current output rate, for example, one word at a time. When output exceeds the size of the balloon, the former text is automatically scrolled. When not set, all text included in a [**Speak**](speak-method) or [**Think**](think-method) statement displays at once.

This property applies only to your client application's use of the character; the setting does not affect other clients of the character or other characters of your client application.

The defaults for these style bits are based on the settings when the character is compiled through the Microsoft Agent Character Editor.