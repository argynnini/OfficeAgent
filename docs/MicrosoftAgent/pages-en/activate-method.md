---
layout: Conceptual
title: Activate Method - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/activate-method
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
description: Activate Method
ms.assetid: 8111139d-1453-416e-8f08-38c06669ff4d
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 4816c39d-8c53-7a32-6cdf-2d0541e68be1
document_version_independent_id: c708b108-8828-58ce-2911-c175fc630281
updated_at: 2025-03-13T17:42:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/activate-method.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/activate-method.md
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 473
asset_id: lwef/activate-method
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/activate-method.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 5560df44-15eb-4998-b806-8f4d1fb52a45
---

# Activate Method - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- [**Description**](../wmformat/description)
    - Sets the active client or character.
- **Syntax**
    - *agent*\*\*.Characters ("***CharacterID***").Activate\*\* [*State*]

| Part | Description |
| --- | --- |
| *State* | Optional. You can specify the following values for this parameter: 0 Not the active client. 1 The active client.  2 (Default) The topmost character. |

## Remarks

When multiple characters are visible, only one of the characters receives speech input at a time. Similarly, when multiple client applications share the same character, only one of the clients receives mouse input (for example, Microsoft Agent control click or drag events). The character set to receive mouse and speech input is the topmost character and the client that receives the input is the active client of that character. (The topmost character's window also appears at the top of the character window's z-order.) Typically, the user determines the topmost character by explicitly selecting the character. However, topmost activation also changes when a character is shown or hidden (the character becomes or is no longer topmost, respectively.)

You can also use this method to explicitly manage when your client receives input directed to the character such as when your application itself becomes active. For example, setting *State* to 2 makes the character topmost and your client receives all mouse and speech input events generated from user interaction with the character. Therefore, it also makes your client the input-active client of the character.

However, you can also set yourself to be the active client for a character without making the character topmost, by setting *State* to 1. This enables your client to receive input directed to that character when the character becomes topmost. Similarly, you can set your client to not be the active client (not to receive input) when the character becomes topmost, by setting *State* to 0.

Avoid calling this method directly after a [**Show**](/en-us/previous-versions/visualstudio/foxpro/d79z7xxa%28v=vs.71%29) method. **Show** automatically sets the input-active client. When the character is hidden, the [**Activate**](/en-us/previous-versions/visualstudio/foxpro/01ayxx68%28v=vs.71%29) call may fail if it gets processed before the **Show** method completes.

If you call this method to a function, it returns a Boolean value that indicates whether the method succeeded. Attempting to call this method with the *State* parameter set to 2 when the specified character is hidden will fail. Similarly, if you set *State* to 0 and your application is the only client, this call fails because a character must always have a topmost client.

```
   Dim Genie as Object

   Sub FormLoad()

   Agent1.Characters.Load "Genie", "Genie.acs"

   Set Genie = Agent1.Characters ("Genie")

   If (Genie. Activate = True) Then
      'I'm active

   Else
      'I must be hidden or something

   End If 
   
   End Sub
```

Note

Calling this method with *State* set to 1 does not typically generate an [**ActivateInput**](https://www.bing.com/search?q=**ActivateInput**) event unless there are no other characters loaded or your application is already input-active.