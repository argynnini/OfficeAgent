---
layout: Conceptual
title: Insert Method - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/insert-method
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
description: Insert Method
ms.assetid: d58cfe50-ace7-4b0f-8539-c2e13a180c96
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 343220ad-ed61-331b-d5c0-d257a08e3cee
document_version_independent_id: e7508803-9b0f-7e62-f0ff-b922013a270e
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/insert-method.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/insert-method.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 364
asset_id: lwef/insert-method
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/insert-method.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 07b3b2c4-c1bb-5b61-5fb5-3a2630710684
---

# Insert Method - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Inserts a **Command** object in the **Commands** collection.
- **Syntax**
    - *agent*\*\*.Characters ("***CharacterID***").Commands.Insert\*\* *Name*, *RefName*, *Before*\_

*Caption*, *Voice, Enabled, Visible*

| Part | Description |
| --- | --- |
| *Name* | Required. A string value corresponding to the ID you assign to the [**Command**](/en-us/windows/desktop/lwef/the-command-object). |
| *RefName* | Required. A string value corresponding to the name (ID) of the command just above or below where you want to insert the new command. |
| *Before* | Optional. A Boolean value indicating whether to insert the new command before the command specified by *RefName*. **True** (Default). The new command will be inserted before the referenced command.**False** The new command will be inserted after the referenced command. |
| *Caption* | Optional. A string value corresponding to the name that will appear in the character's pop-up menu and in the Commands Window when the client application is input-active. For more information, see the [**Command**](/en-us/windows/desktop/lwef/the-command-object) object's [**Caption**](caption-property)property. |
| *Voice* | Optional. A string value corresponding to the words or phrase to be used by the speech engine for recognizing this command. For more information on formatting alternatives for the string, see the [**Command**](/en-us/windows/desktop/lwef/the-command-object) object's **Voice** property. |
| *Enabled* | Optional. A Boolean value indicating whether the command is enabled. The default value is **True**. For more information, see the [**Command**](/en-us/windows/desktop/lwef/the-command-object) object's **Enabled** property. |
| *Visible* | Optional. A Boolean value indicating whether the command is visible in the Commands Window when the client application is input-active. The default value is **True**. For more information, see the [**Command**](/en-us/windows/desktop/lwef/the-command-object) object's [**Visible**](visible-property) property. |

## Remarks

The value of a [**Command**](/en-us/windows/desktop/lwef/the-command-object) object's [**Name**](name-property) property must be unique within its [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection. You must remove a **Command** before you can create a new **Command** with the same **Name** property setting. Attempting to create a **Command** with a **Name** property that already exists raises an error.

This method also returns a [**Command**](/en-us/windows/desktop/lwef/the-command-object) object. This enables you to declare an object and assign a **Command** to it when you call the **Insert** method.

```
   Dim Cmd2 as IAgentCtlCommandEx
   Set Cmd2 = Genie.Commands.Insert ("my second command", "my first command",_ True, "Test", "Test", True, True)
   Cmd2.VoiceCaption = "this is a test"
```