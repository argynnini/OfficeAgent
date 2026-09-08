---
layout: Conceptual
title: IAgentCommandsEx SetVoiceCaption - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcommandsex--setvoicecaption
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
description: IAgentCommandsEx SetVoiceCaption
ms.assetid: f13c9ca5-70c9-42d0-b53c-45dc8980a24c
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: b502aa79-0506-6514-370f-0fc596ceadaa
document_version_independent_id: ab338c9c-4473-890b-fa03-ecf8fb254e46
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommandsex--setvoicecaption.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcommandsex--setvoicecaption.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 139
asset_id: lwef/iagentcommandsex--setvoicecaption
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcommandsex--setvoicecaption.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 1114e0aa-a6b0-0b3e-9218-5318f46685b3
---

# IAgentCommandsEx SetVoiceCaption - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT SetVoiceCaption(
   BSTR bszVoiceCaption  // voice caption text
);
```

Sets the [**VoiceCaption**](voicecaption-property) text displayed for the [**Command**](/en-us/windows/desktop/lwef/the-command-object) object.

- Returns S\_OK to indicate the operation was successful.

- *bszVoiceCaption*
    - A BSTR that specifies the text for the [**VoiceCaption**](voicecaption-property) property for a [**Command**](/en-us/windows/desktop/lwef/the-command-object).

If you define a [**Command**](/en-us/windows/desktop/lwef/the-command-object) object in a [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection and set its [**Voice**](voice-property) property, you will typically also set its [**VoiceCaption**](voicecaption-property) property. This text will appear in the Voice Commands Window when your client application is input-active and the character is visible. If this property is not set, the setting for the [**Caption**](caption-property) property determines the text displayed. When neither the **VoiceCaption** or **Caption** property is set, the command does not appear in the Voice Commands Window.