---
layout: Conceptual
title: IAgentCommand - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcommand
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
description: IAgentCommand
ms.assetid: 70873093-df71-4377-9c39-c7528400052f
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 7626a395-6fed-8702-a5e4-8cbc316e671c
document_version_independent_id: c2b46835-5d3f-6147-f347-d51755e9cafe
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommand.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcommand.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 709
asset_id: lwef/iagentcommand
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcommand.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: afa6e40d-75ab-c233-8d4d-b30b2eedf568
---

# IAgentCommand - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

A [**Command**](/en-us/windows/desktop/lwef/the-command-object) object is an item in a [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection. The server provides the user access to your commands your client application becomes input active. To retrieve a **Command**, call [**IAgentCommands::GetCommand**](iagentcommands--getcommand).

**IAgentCommand** defines an interface that allows applications to set and query properties for [**Command**](/en-us/windows/desktop/lwef/the-command-object) objects that can appear in a character's pop-up menu and in the Voice Commands Window. These functions are also available from [**IAgentCommandEx**](iagentcommandex). A **Command** object is an item in a [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection. The server provides the user access to your commands when your client application becomes input active.

A [**Command**](/en-us/windows/desktop/lwef/the-command-object) may appear in either or both the character's pop-up menu and the Voice Commands Window. To appear in the pop-up menu, it must have a [**Caption**](caption-property) and have the [**Visible**](visible-property) property set to **True**. The **Visible** property for its [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection object must also be set to **True** for the command to appear in the pop-up menu when your client application is input-active. To appear in the Voice Commands Window, a **Command** must have its [**VoiceCaption**](voicecaption-property) and [**Voice**](voice-property) properties set. (For backward compatibility, if there is no **VoiceCaption**, the **Caption** setting is used.)

A character's pop-up menu entries do not change while the menu is displayed. If you add or remove Commands or change their properties while the character's popup menu is displayed, the menu displays those changes when redisplayed. However, the Voice Commands Window does display changes as you make them.

The following table summarizes how the properties of a command affect its presentation.

| Caption Property | Voice-Caption Property | Voice Property | Visible Property | Appears in Character's Pop-up Menu | Appears in Voice Commands Window |
| --- | --- | --- | --- | --- | --- |
| Yes | Yes | Yes | True | Yes, using [**Caption**](caption-property) | Yes, using [**VoiceCaption**](voicecaption-property) |
| Yes | Yes | No¹ | True | Yes, using [**Caption**](caption-property) | No |
| Yes | Yes | Yes | False | No | Yes, using [**VoiceCaption**](voicecaption-property) |
| Yes | Yes | No¹ | False | No | No |
| No¹ | Yes | Yes | True | No | Yes, using [**VoiceCaption**](voicecaption-property) |
| No¹ | Yes | Yes | False | No | Yes, using [**VoiceCaption**](voicecaption-property) |
| No¹ | Yes | No¹ | True | No | No |
| No¹ | Yes | No¹ | False | No | No |
| Yes | No¹ | Yes | True | Yes, using [**Caption**](caption-property) | Yes, using [**Caption**](caption-property) |
| Yes | No¹ | No¹ | True | Yes | No |
| Yes | No¹ | Yes | False | No | Yes, using [**Caption**](caption-property) |
| Yes | No¹ | No¹ | False | No | No |
| No¹ | No¹ | Yes | True | No | No² |
| No¹ | No¹ | Yes | False | No | No² |
| No¹ | No¹ | No¹ | True | No | No |
| No¹ | No¹ | No¹ | False | No | No |

¹If the property setting is null. In some programming languages, an empty string may not be interpreted as the same as a null string.

²The command is still voice-accessible.

Generally, if you define a [**Command**](/en-us/windows/desktop/lwef/the-command-object) with a [**Voice**](voice-property) setting, you also define [**Caption**](caption-property) and **Voice** settings for its associated [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection. If the **Commands** collection for a set of commands has no **Voice** or no **Caption** setting and is currently input-active, but the **Commands** have **Caption** and **Voice** settings, the **Commands** appear in the Voice Commands Window tree view under "(undefined command)" when your client application becomes input-active.

When the server receives input that matches one of the [**Command**](/en-us/windows/desktop/lwef/the-command-object) objects you defined for your [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection, it sends a [**IAgentNotifySink::Command**](https://www.bing.com/search?q=**IAgentNotifySink::Command**) event, and passes back the ID of the command as an attribute of the [**IAgentUserInput**](https://www.bing.com/search?q=**IAgentUserInput**) object. You can then use conditional statements to match and process the command.

**Methods in Vtable Order**

| IAgentCommand Methods | Description |
| --- | --- |
| [**SetCaption**](https://www.bing.com/search?q=**SetCaption**) | Sets the value for the [**Caption**](caption-property) for a [**Command**](/en-us/windows/desktop/lwef/the-command-object) object. |
| [**GetCaption**](https://www.bing.com/search?q=**GetCaption**) | Returns the value of the [**Caption**](caption-property) property of a [**Command**](/en-us/windows/desktop/lwef/the-command-object) object. |
| [**SetVoice**](iagentcommand--setvoice) | Sets the value for the [**Voice**](voice-property) text for a [**Command**](/en-us/windows/desktop/lwef/the-command-object) object. |
| [**GetVoice**](iagentcommand--getvoice) | Returns the value of the [**Voice**](voice-property) property of a [**Command**](/en-us/windows/desktop/lwef/the-command-object) object. |
| [**SetEnabled**](iagentcommand--setenabled) | Sets the value of the [**Enabled**](enabled-property) property for a [**Command**](/en-us/windows/desktop/lwef/the-command-object) object. |
| [**GetEnabled**](iagentcommand--getenabled) | Returns the value of the [**Enabled**](enabled-property) property of a [**Command**](/en-us/windows/desktop/lwef/the-command-object) object. |
| [**SetVisible**](iagentcommand--setvisible) | Sets the value of the [**Visible**](visible-property) property for a [**Command**](/en-us/windows/desktop/lwef/the-command-object) object. |
| [**GetVisible**](iagentcommand--getvisible) | Returns the value of the [**Visible**](visible-property) property of a [**Command**](/en-us/windows/desktop/lwef/the-command-object) object. |
| [**SetConfidenceThreshold**](iagentcommand--setconfidencethreshold) | Sets the value of the [**Confidence**](confidence-property) property for a [**Command**](/en-us/windows/desktop/lwef/the-command-object) object. |
| [**GetConfidenceThreshold**](iagentcommand--getconfidencethreshold) | Returns the value of the [**Confidence**](confidence-property) property of a [**Command**](/en-us/windows/desktop/lwef/the-command-object) object. |
| [**SetConfidenceText**](iagentcommand--setconfidencetext) | Sets the value of the [**ConfidenceText**](confidencetext-property) property for a [**Command**](/en-us/windows/desktop/lwef/the-command-object) object. |
| [**getConfidenceText**](iagentcommand--getconfidencetext) | Returns the value of the [**ConfidenceText**](confidencetext-property) property of a [**Command**](/en-us/windows/desktop/lwef/the-command-object) object. |
| [**getID**](iagentcommand--getid) | Returns the ID of a [**Command**](/en-us/windows/desktop/lwef/the-command-object) object. |