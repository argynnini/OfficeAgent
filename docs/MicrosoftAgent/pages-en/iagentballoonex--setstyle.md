---
layout: Conceptual
title: IAgentBalloonEx SetStyle - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentballoonex--setstyle
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
description: IAgentBalloonEx SetStyle
ms.assetid: 5be569b7-8a2d-437b-b5db-401af343bc78
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 21812662-14f5-0209-415e-02fb7d392ed1
document_version_independent_id: 349a60e9-f944-c76a-bde1-71ddaa50c0ae
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentballoonex--setstyle.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentballoonex--setstyle.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 392
asset_id: lwef/iagentballoonex--setstyle
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentballoonex--setstyle.md
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/49f7a155-15b3-4cce-8c03-a814c52269b6
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/73c34d6e-8193-442f-9cd9-38506534a799
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: fd4f0b43-a51e-2881-8f42-3b23073b2c68
---

# IAgentBalloonEx SetStyle - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT SetStyle(
   long lStyle,  // style settings
);
```

Retrieves the character's word balloon style settings.

- Returns S\_OK to indicate the operation was successful.

- *lStyle*
    - Style settings for the word balloon, which can be a combination of any of the following values:

| Value | Description |
| --- | --- |
| **const unsigned short** **BALLOON\_STYLE\_BALLOONON = 0x00000001;** | The balloon is supported for output. |
| **const unsigned short** **BALLOON\_STYLE \_SIZETOTEXT = 0x0000002;** | The balloon height is sized to accommodate the text output. |
| **const unsigned short** **BALLOON\_STYLE \_AUTOHIDE = 0x00000004;** | The balloon is automatically hidden. |
| **const unsigned short** **BALLOON\_STYLE \_AUTOPACE = 0x00000008;** | The text output is paced based on the output rate. |

When the **BalloonOn** style bit is set, the word balloon appears when the [**Speak**](speak-method) or [**Think**](think-method) method is used, unless the user overrides its display in the Microsoft Agent property sheet. When not set, no balloon appears.

When the **SizeToText** style bit is set, the word balloon automatically sizes the height of the balloon to the current size of the text specified in the [**Speak**](speak-method) or [**Think**](think-method) method. When not set, the balloon's height is based on the balloon's number of lines property setting. This style bit is set to 1 and an attempt to use [**IAgentBalloonEx::SetNumLines**](iagentballoonex--setnumlines) will result in an error.

When the **AutoHide** style bit is set, the word balloon automatically hides after a short timeout. When not set, the balloon displays until a new [**Speak**](speak-method) or [**Think**](think-method) call, the character is hidden, or the user clicks or drags the character.

When the **AutoPace** style bit is set, the word balloon paces the output based on the current output rate, for example, one word at a time. When output exceeds the size of the balloon, the former text is automatically scrolled. When not set, all text included in a [**Speak**](speak-method) or [**Think**](think-method) statement displays at once.

The Balloon's style property can be set even if the user has disabled display of the Balloon using the Microsoft Agent property sheet.

This property applies only to your client application's use of the character; the setting does not affect other clients of the character or other characters of your client application.

The defaults for these style bits are based on their settings when the character is compiled with the Microsoft Agent Character Editor.