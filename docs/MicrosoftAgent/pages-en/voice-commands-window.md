---
layout: Conceptual
title: Voice Commands Window - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/voice-commands-window
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
description: Voice Commands Window
ms.assetid: vs|msagent|~\guidlin_12gn.htm
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 7896e2ec-16e4-fca3-b5f3-c996c42ed4b0
document_version_independent_id: d0a21aa9-9752-9d18-949a-dc10aaa7c7b9
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/voice-commands-window.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/voice-commands-window.md
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 564
asset_id: lwef/voice-commands-window
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/voice-commands-window.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: c821ecff-1590-c7b2-c8b0-c96c339e25de
---

# Voice Commands Window - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

The Voice Commands Window displays the current active voice commands available for the character. The window appears when the Open Commands Window command is chosen or the [**Visible**](visible-property) property of the [**CommandsWindow**](/en-us/windows/desktop/lwef/the-commandswindow-object) object is set to **True**. If the speech engine has not yet been loaded, querying or setting this property will cause Microsoft Agent to attempt to initialize the engine. If the user disables speech, the window can still display; however, it will include a text message that informs the user that speech is currently disabled.

The input-active client's commands appear in the Voice Commands Window based on the [**Voice**](voice-property)[**Caption**](caption-property) and **Voice** property settings listed under the [**VoiceCaption**](voicecaption-property) of their [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection.

**Figure 1. Voice Commands Window**

The Voice Commands Window appears when the Open Commands Window command is chosen. The input-active client's commands appear in the Voice Commands Window based on the [**Voice**](voice-property)[**Caption**](caption-property) and **Voice** property settings listed under **Voice** of the [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection.

The Voice Commands Window also lists the [**VoiceCaption**](voicecaption-property) of the [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection for other clients of the character, and the following server-generated voice commands for general interaction under the Global Commands entry:

| Voice Caption | Voice Grammar |
| --- | --- |
| Open | Close Voice Commands Window | (open | show) [the] commands [window] | what can I say [now]  toggles with:  close [the] commands [window] |
| Hide | hide \* |
| *CharacterName* | *CharacterName*\*\* |
| Global Commands | [show] [me] global commands |

\* A character is listed here only if it is currently visible.

\*\* All loaded characters are listed.

Speaking the voice command for another client's [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection switches to that client, and the Voice Commands Window displays the commands of that client. No other entries are expanded. Similarly, if the user switches characters, the Voice Commands Window changes to display the commands of its input-active client. If the client is already input-active, speaking one of its voice commands has no effect. (However, if the user collapses the active client's subtree with the mouse, speaking the client name redisplays the client's subtree.)

If a client has voice commands, but no [**Voice**](voice-property) setting for its [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) object (or no **Voice**[**Caption**](caption-property)), the tree displays "(command undefined)" as the parent entry -- but only when that client is input-active and the client has commands in its collection that have **Caption** and **Voice** settings.

The server automatically displays the commands of the current input-active client and, if necessary, scrolls the window to display as many of the client's commands as possible, based on the size of the window. If the character has no client entries, the Global Commands entry is expanded.

If the user speaks "Global Commands," the Voice Commands Window always displays its associated subtree entries. If they are already displayed, the command has no effect.

Although you can also display or hide the Voice Commands Window from your application's code using the [**Visible**](visible-property) property, you cannot change the Voice Commands Window size or location. The server maintains the Voice Commands Window's properties based on the user's interaction with the window. Its initial location is immediately adjacent to the character's taskbar icon.

The Voice Commands Window is included in the ALT+TAB window order. This enables a user to switch to the window to scroll, resize, or reposition the window with the keyboard.

- [The Listening Tip](the-listening-tip)
- [The Advanced Character Options Window](https://www.bing.com/search?q=The+Advanced+Character+Options+Window)