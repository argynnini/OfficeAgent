---
layout: Conceptual
title: Commands Object Properties - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/commands-object-properties
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
description: Commands Object Properties
ms.assetid: 889a56b2-0b6d-4df8-a313-7553371e4413
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 5f82cf64-9391-74eb-0f4b-0b1b4e5e27d5
document_version_independent_id: b77c885f-e0f9-24ce-c244-d5405c510093
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/commands-object-properties.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/commands-object-properties.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 283
asset_id: lwef/commands-object-properties
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/commands-object-properties.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: c653b6e6-7831-2405-1bf0-737cb2ae3033
---

# Commands Object Properties - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

The server supports the following properties for the [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection:

- [**Caption**](caption-property-cmds)
- [**Count**](count-property)
- [**DefaultCommand**](defaultcommand-property)
- [**FontName**](fontname-property)
- [**FontSize**](fontsize-property)
- [**GlobalVoiceCommandsEnabled**](globalvoicecommandsenabled-property)
- [**HelpContextID**](helpcontextid-property)
- [**Visible**](visible-property-cso)
- [**Voice**](voice-property)
- [**VoiceCaption**](voicecaption-property)

An entry for the [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection can appear in both the pop-up menu and the Voice Commands Window for a character. To make this entry appear in the pop-up menu, set its [**Caption**](caption-property-cmds) property. To include the entry in the Voice Commands Window, set its [**VoiceCaption**](voicecaption-property) property. (For backward compatibility, if there is no **VoiceCaption**, the **Caption** setting is used)

The following table summarizes how the properties of a [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) object affect the entry's presentation:

| Caption Property | Voice-Caption Property | Voice Property | Visible Property | Appears in Character's Pop-up Menu | Appears in Voice Commands Window |
| --- | --- | --- | --- | --- | --- |
| Yes | Yes | Yes | True | Yes, using Caption | Yes, using VoiceCaption |
| Yes | Yes | No | True | Yes, using Caption | No |
| Yes | Yes | Yes | False | No | Yes, using VoiceCaption |
| Yes | Yes | No | False | No | No |
| No | Yes | Yes | True | No | Yes, using VoiceCaption |
| No | Yes | Yes | False | No | Yes, using VoiceCaption |
| No | Yes | No | True | No | No |
| No | Yes | No | False | No | No |
| Yes | No1 | Yes | True | Yes, using Caption | Yes, using Caption |
| Yes | No | No | True | Yes | No |
| Yes | No | Yes | False | No | Yes, using Caption |
| Yes | No | No | False | No | No |
| No | No | Yes | True | No | No |
| No | No | Yes | False | No | No |
| No | No | No | True | No | No |
| No | No | No | False | No | No |
| If the property setting is null. In some programming languages, an empty string may not be interpreted as the same as a null string. The command is still voice-accessible, and appears in the Voice Commands Window as "(command undefined)". |  |  |  |  |  |