---
layout: Conceptual
title: Pop-up Menu Support - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/pop-up-menu-support
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
description: Pop-up Menu Support
ms.assetid: a8a1cf91-c18a-497f-89a7-b47536eaca0a
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: af577a70-7e82-2196-c1b5-68cc4e9ebd38
document_version_independent_id: 504c3485-0a0e-5c2b-75cf-a8d1a5f7a45b
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/pop-up-menu-support.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/pop-up-menu-support.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 379
asset_id: lwef/pop-up-menu-support
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/pop-up-menu-support.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: de2e7233-b797-feb2-5df0-889bb61908e6
---

# Pop-up Menu Support - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

Microsoft Agent includes a pop-up menu (also known as a contextual menu) for each character. The server displays this pop-up menu automatically when a user right-clicks the character. You can add commands for your client application to the menu by defining a [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection. For each command in the collection that you define, you can specify [**Caption**](caption-property) and [**Visible**](visible-property) properties. The **Caption** is the text that appears in the menu when the **Visible** property is set to **True**. You can also use the [**Enabled**](enabled-property) property to display the command in the menu as disabled and the [**HelpContextID**](helpcontextid-property) to support Help support for the property. Define the access key for the menu text by including an ampersand (&) before the text character of the **Caption** text setting.

The server automatically adds to the menu commands for opening the Voice Commands Window and hiding the character as well as the [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) captions of other clients of the character to enable users to switch between clients. The server automatically adds a separator to the menu between its menu entries and those defined by the client. Separators appear only when there are items in the menu to separate.

To remove commands from a menu, use the [**Remove**](remove-method) method. Note that menu entries do not change while the menu displays. If you add or remove commands or change their properties, the menu displays the changes when the user redisplays the menu.

If you prefer to provide your own pop-up menu services for a character, you can use the [**AutoPopupMenu**](autopopupmenu-property) property to turn off server handling of the right-click action. You can then use the [**Click**](click-event) event notification to create your own menu handling behavior.

When the user selects a command from a character's pop-up menu or the Voice Commands Window, the server triggers the [**Command**](command-event) event of the associated client and passes back the parameters of the input using the [**UserInput**](/en-us/windows/desktop/lwef/iagentuserinput) object.

The server also provides a pop-up menu for the character's taskbar icon. When the character is visible, right-clicking this menu displays the same commands as those displayed by right-clicking the character. However, when the character is hidden, only the server-supplied commands are included.