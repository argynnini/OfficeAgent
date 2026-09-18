---
layout: Conceptual
title: VoiceCaption Property (Command Object) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/voicecaption-property-c
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
description: Learn about the VoiceCaption Property of the Command object, which sets or returns the text displayed for the Command object in the Voice Commands Window.
ms.assetid: 97a3015c-6c39-42d5-b6bd-7563bd444b38
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 7d806b59-78c6-7a24-0dc4-883b03c54b73
document_version_independent_id: d8ce3ce9-85d7-4cd7-daeb-ce7a6985378e
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/voicecaption-property-c.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/voicecaption-property-c.md
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 140
asset_id: lwef/voicecaption-property-c
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/voicecaption-property-c.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 9de27910-501b-1234-1a17-6e06cedd122b
---

# VoiceCaption Property (Command Object) - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Sets or returns the text displayed for the [**Command**](/en-us/windows/desktop/lwef/the-command-object) object in the Voice Commands Window.
- **Syntax**
    - \*agent.\***Characters("*CharacterID*").Commands("*Name*").VoiceCaption** [ = *string*]

| Part | Description |
| --- | --- |
| *string* | A string expression that evaluates to the text displayed. |

## Remarks

If you define a [**Command**](/en-us/windows/desktop/lwef/the-command-object) object in a [**Commands**](https://www.bing.com/search?q=**Commands**) collection and set its [**Voice**](voice-property) property, you will typically also set its [**VoiceCaption**](voicecaption-property) property. This text will appear in the Voice Commands Window when your client application is input-active and the character is visible. If this property is not set, the setting for the [**Caption**](caption-property) property determines the text displayed. When neither the **VoiceCaption** nor **Caption** property is set, the command does not appear in the Voice Commands Window.

### See Also

[**Caption property**](caption-property)