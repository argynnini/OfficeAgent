---
layout: Conceptual
title: The Commands Collection Object - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/the-commands-collection-object
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
description: The Commands Collection Object
ms.assetid: 8726ce04-77d3-4ae3-bd46-e75f42b36d6f
ms.topic: concept-article
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 2221bad4-b564-fdc7-7760-d4366aabe893
document_version_independent_id: f4a2b895-a8e9-3247-6523-d6a9bf0d8339
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/the-commands-collection-object.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/the-commands-collection-object.md
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 545
asset_id: lwef/the-commands-collection-object
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/the-commands-collection-object.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: b0a38f38-efc2-039c-eb09-e9e673cff850
---

# The Commands Collection Object - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

The Microsoft Agent server maintains a list of commands that are currently available to the user. This list includes commands that the server defines for general interaction (such as Hide and Open The Voice Commands Window), the list of available (but non-input-active) clients, and the commands defined by the current active client. The first two sets of commands are global commands; that is, they are available at any time, regardless of the input-active client. Client-defined commands are available only when that client is input-active and the character is visible.

Each client application can define a collection of commands called the [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection. To add a command to the collection, use the [**Add**](add-method) or [**Insert**](insert-method) method. Although you can specify a command's properties with separate statements, for optimum code performance, specify all of a command's properties in the **Add** or **Insert** method statement. For each command in the collection, you can determine whether user access to the command appears in the character's pop-up menu, in the Voice Commands Window, in both, or in neither. For example, if you want a command to appear on the pop-up menu for the character, set the command's [**Caption**](caption-property) and [**Visible**](visible-property) properties. To display the command in the Voice Commands Window, set the command's [**VoiceCaption**](voicecaption-property) and [**Voice**](voice-property) properties.

A user can access the individual comm[**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object)ands in your collection only when your client application is input-active. Therefore, when you may be sharing the character with other client applications you'll typically want to set the [**Caption**](caption-property), [**VoiceCaption**](voicecaption-property), and [**Voice**](voice-property) properties for the **Commands** collection object as well as for the commands in the collection. This places an entry for your **Commands** collection in a character's pop-up menu and in the Voice Commands Window.

When the user switches to your client by choosing its [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) entry, the server automatically makes your client input-active, notifying your client application using the [**ActivateInput**](activateinput-event) event and makes the commands in its collection available. The server also notifies the client that it is no longer input-active with the [**DeActivateInput**](deactivateinput-event) event. This enables the server to present and accept only the commands that apply to the current input-active client's context. It also serves to avoid command-name collisions between clients.

A client can also explicitly request to make itself the input-active client using the [**Activate**](activate-method) method. This method also supports setting your application to not be the input-active client. You may want to use this method when you are sharing a character with another application, setting your application to be input-active when your application window gets focus and not input-active when it loses focus.

Similarly, you can use the [**Activate**](activate-method) method to set your application to be (or not be) the active client of the character. The active client is the client that receives input when its character is the topmost character. When this status changes, the server notifies your application with the [**ActiveClientChange**](activeclientchange-event) event.

When a character's pop-up menu displays, changes to the properties of a [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection or the commands in its collection do not appear until the user redisplays the menu. However, the Commands Window does display changes as they happen.

- [Commands Object Methods](commands-object-methods)
- [Commands Object Properties](commands-object-properties)