---
layout: Conceptual
title: IAgentCommands - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcommands
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
description: IAgentCommands
ms.assetid: a171a2f0-7c1c-440f-9b19-28447cc68b95
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 47643ed3-299e-27f9-15cd-7b2af605cf52
document_version_independent_id: 62df9940-4539-2803-3ae3-a0b82f45c663
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommands.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcommands.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 930
asset_id: lwef/iagentcommands
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcommands.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 7706c110-0c14-6a0c-fce1-ad34836fe6a5
---

# IAgentCommands - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

The Microsoft Agent server maintains a list of commands that are currently available to the user. This list includes commands that the server defines for general interaction, such as Hide and Microsoft Agent Properties, the list of available (but non-input-active) clients, and the commands defined by the current active client. The first two sets of commands are global commands; that is, they are available at any time, regardless of the input-active client. Client-defined commands are available only when that client is input-active.

Retrieve an **IAgentCommands** interface by querying the [**IAgentCharacter**](https://www.bing.com/search?q=**IAgentCharacter**) interface for **IAgentCommands**. Each Microsoft Agent client application can define a collection of commands called a [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection. To add a [**Command**](/en-us/windows/desktop/lwef/the-command-object) to the collection, use the [**Add**](add-method) or [**Insert**](insert-method) method. Although you can specify a **Command's** properties using [**IAgentCommand**](iagentcommand) methods, for optimum code performance, specify all of a **Command**'s properties in the [**IAgentCommands::Add**](iagentcommands--add) or [**IAgentCommands::Insert**](iagentcommands--insert) methods when initially setting the properties for a new **Command**. You can use the **IAgentCommand** methods to query or change the property settings.

For each [**Command**](/en-us/windows/desktop/lwef/the-command-object) in the [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection, you can determine whether the command appears on the character's pop-up menu, in the Voice Commands Window, in both, or in neither. For example, if you want a command to appear on the pop-up menu for the character, set the command's [**Caption**](caption-property) and [**Visible**](visible-property) properties. To display the command in the **Voice Commands Window**, set the command's **Caption** and [**Voice**](voice-property) properties.

A user can access the individual commands in your Commands collection only when your client application is input-active and the character is visible. Therefore, you will typically want to set the [**Caption**](caption-property), [**VoiceCaption**](voicecaption-property), and [**Voice**](voice-property) properties for the [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection object as well as for the commands in the collection, because this places an entry for your **Commands** collection on a character's pop-up menu and in the Voice Commands Window. When the user switches to your client by choosing its **Commands** entry, the server automatically makes your client input-active, notifying your client application using the [**IAgentNotifySink::ActivateInputState**](https://www.bing.com/search?q=**IAgentNotifySink::ActivateInputState**) and makes the **Commands** in its collection available. The server also notifies the client that is no longer input-active with the **IAgentNotifySink::ActivateInputState** event. This enables the server to present and accept only the **Commands** that apply to the current input-active client's context. It also serves to avoid [**Command**](/en-us/windows/desktop/lwef/the-command-object)-name collisions between clients.

A client can also explicitly request to make itself the input-active client using the [**IAgentCharacter::Activate**](iagentcharacter--activate) method. This method also supports setting your application to not be the input-active client. You may want to use this method when sharing a character with another application, setting your application to be input-active when your application window gets focus and not input-active when it loses focus.

Similarly, you can use [**IAgentCharacter::Activate**](iagentcharacter--activate) to set your application to be (or not be) the active client of the character. The active client is the client that receives input when its character is the topmost character. When this status changes, the server notifies your application with the [**IAgentNotifySinkEx::ActiveClientChange**](iagentnotifysinkex--activeclientchange) event.

When a character's pop-up menu is displayed, changes to the properties of a [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection or the commands in its collection do not appear until the user redisplays the menu. However, when open, the Voice Commands Window does display changes as they happen.

**IAgentCommands** defines an interface that allows applications to add, remove, set, and query properties for a [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection. These functions are also available from [**IAgentCommandsEx**](iagentcommandsex).

A [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection can appear as a command in both the pop-up menu and the Voice Commands Window for a character. To make the **Commands** collection appear, you must set its [**Caption**](caption-property) property. The following table summarizes how the properties of a **Commands** collection affect its presentation.

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

¹If the property setting is null. In some programming languages, an empty string may not be interpreted the same as a null string.

²The command is still voice-accessible.

**Methods in Vtable Order**

| IAgentCommands Methods | Description |
| --- | --- |
| [**GetCommand**](iagentcommands--getcommand) | Retrieves a [**Command**](/en-us/windows/desktop/lwef/the-command-object) object from the [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection. |
| [**GetCount**](iagentcommands--getcount) | Returns the value of the number of [**Commands**](/en-us/windows/desktop/lwef/the-command-object) in a [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection. |
| [**SetCaption**](iagentcommands--setcaption) | Sets the value of the [**Caption**](caption-property) property for a [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection. |
| [**GetCaption**](iagentcommands--getcaption) | Returns the value of the [**Caption**](caption-property) property of a [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection. |
| [**SetVoice**](iagentcommands--setvoice) | Sets the value of the [**Voice**](voice-property) property for a [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection. |
| [**GetVoice**](iagentcommands--getvoice) | Returns the value of the [**Voice**](voice-property) property of a [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection. |
| [**SetVisible**](iagentcommands--setvisible) | Sets the value of the [**Visible**](visible-property) property for a [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection. |
| [**GetVisible**](iagentcommands--getvisible) | Returns the value of the [**Visible**](visible-property) property of a [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection. |
| [**Add**](iagentcommands--add) | Adds a [**Command**](/en-us/windows/desktop/lwef/the-command-object) object to a [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection. |
| [**Insert**](iagentcommands--insert) | Inserts a [**Command**](/en-us/windows/desktop/lwef/the-command-object) object in a [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection. |
| [**Remove**](iagentcommands--remove) | Removes a [**Command**](/en-us/windows/desktop/lwef/the-command-object) object in a [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection. |
| [**RemoveAll**](iagentcommands--removeall) | Removes all [**Command**](/en-us/windows/desktop/lwef/the-command-object) objects from a [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection. |