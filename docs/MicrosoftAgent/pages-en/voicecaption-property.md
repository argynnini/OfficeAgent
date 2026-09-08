---
layout: Conceptual
title: VoiceCaption Property (Commands Object) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/voicecaption-property
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
description: Learn about the VoiceCaption Property of the Commands object, which returns or sets the text displayed for the Commands object in the Voice Commands Window.
ms.assetid: 2c4fa175-fc2d-4474-b15f-7e838103a435
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 79873e76-95ff-dc96-52e2-89a523cab029
document_version_independent_id: 59d5f475-2b65-fb5b-74bb-e8e487e0a678
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/voicecaption-property.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/voicecaption-property.md
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 167
asset_id: lwef/voicecaption-property
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/voicecaption-property.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 58bae9a2-f90a-c6e9-3de8-1dede4cafe0e
---

# VoiceCaption Property (Commands Object) - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Returns or sets the text displayed for the [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) object in the Voice Commands Window.
- **Syntax**
    - \*agent.\***Characters("*CharacterID*").Commands.VoiceCaption** [ = *string*]

| Part | Description |
| --- | --- |
| *string* | A string expression that evaluates to the text displayed. |

## Remarks

If you set the [**Voice**](voice-property) property of your [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection, you will typically also set its **VoiceCaption** property. The **VoiceCaption** text setting appears in the Voice Commands Window when your client application is input-active and the character is visible. If this property is not set, the setting for the **Commands** collection's [**Caption**](caption-property) property determines the text displayed. When neither the **VoiceCaption** or **Caption** property is set, then commands in the collection appear in the Voice Commands Window under "(undefined command)" when your client application becomes input-active.

The **VoiceCaption** setting also determines the text displayed in the Listening Tip to indicate the commands for which the character listens.