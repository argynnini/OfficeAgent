---
layout: Conceptual
title: Add Method - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/add-method
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
description: Add Method
ms.assetid: dd258294-33d6-45f5-a6a1-a3a56b12a7df
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 4fba7970-436b-397c-f65f-56c09ee99b2c
document_version_independent_id: 9adee1b1-610d-8762-a641-758cc5cd7a74
updated_at: 2025-03-13T17:42:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/add-method.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/add-method.md
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 297
asset_id: lwef/add-method
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/add-method.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: a2f902e1-c007-a69e-f5d4-4226fc6e51f6
---

# Add Method - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Adds a [Command](the-command-object) object to the [Commands](the-commands-collection-object) collection.
- **Syntax**
    - *agent*\*\*.Characters ("***CharacterID***").Commands.Add\*\* *Name*, *Caption*, *Voice*, *Enabled*, *Visible*

| Part | Description |
| --- | --- |
| *Name* | Required. A string value corresponding to the ID you assign for the command. |
| *Caption* | Optional. A string value corresponding to the name that will appear in the character's pop-up menu and in the Commands Window when the client application is input-active. For more information, see the [Command](the-command-object) object's [Caption](caption-property) property. |
| *Voice* | Optional. A string value corresponding to the words or phrase to be used by the speech engine for recognizing this command. For more information on formatting alternatives for the string, see the [Command](the-command-object) object's [Voice](voice-property) property. |
| *Enabled* | Optional. A Boolean value indicating whether the command is enabled. The default value is **True**. For more information, see the [Command](the-command-object) object's [Enabled](enabled-property) property. |
| *Visible* | Optional. A Boolean value indicating whether the command is visible in the character's pop-up menu for the character when the client application is input-active. The default value is **True**. For more information, see the [Command](the-command-object) object's [Visible](visible-property) property. |

## Remarks

The value of a [Command](the-command-object) object's [Name](name-property) property must be unique within its [Commands](the-commands-collection-object) collection. You must remove a Command before you can create a new Command with the same Name property setting. Attempting to create a Command with a Name property that already exists raises an error.

This method also returns a [Command](the-command-object) object. This enables you to declare an object and assign a Command to it when you call the Addmethod.

```
   Dim Cmd1 as IAgentCtlCommandEx
   Set Cmd1 = Genie.Commands.Add ("my first command", "Test", "Test", True, True)
   Cmd1.VoiceCaption = "this is a test"
```