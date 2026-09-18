---
layout: Conceptual
title: Play Method (Legacy Windows Environment Features) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/play-method
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
description: Play Method
ms.assetid: 7e89341a-b4d3-4bea-8e7f-31c649ff06b3
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 3c36f622-ee7a-7a79-cce0-92a5bbde959d
document_version_independent_id: 0a26abe3-7d95-75f0-d2cb-5ca7c1a23820
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/play-method.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/play-method.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 305
asset_id: lwef/play-method
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/play-method.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 64b605cc-5804-ed42-3588-85e86dad98c2
---

# Play Method (Legacy Windows Environment Features) - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Plays the specified animation for the specified character.
- **Syntax**
    - *agent*\*\*.Characters ("***CharacterID***").Play\*\* "*AnimationName*"

| Part | Description |
| --- | --- |
| *AnimationName* | Required. A string that specifies the name of an animation sequence. |

## Remarks

An animation's name is defined when the character is compiled with the Microsoft Agent Character Editor. Before playing the specified animation, the server attempts to play the **Return** animation for the previous animation, if one has been assigned.

When accessing a character's animations using a conventional file protocol, you can simply use the **Play** method specifying the name of the animation. However, if you are using the HTTP protocol to access character animation data, use the **Get** method to load the animation before calling the **Play** method.

For more information, see the **Get** method.

To simplify your syntax, you can declare an object reference and set it to reference the [**Character**](/en-us/windows/desktop/lwef/the-characters-object) object in the [**Characters**](/en-us/windows/desktop/lwef/the-characters-object) collection and use the reference as part of your **Play** statements:

```
   Dim Genie   
   Agent1.Characters.Load "Genie", "https://agent.microsoft.com/characters/v2/genie/genie.acf"

   Set Genie = Agent1.Characters ("Genie")
   
   Genie.Get "state", "Showing"
   Genie.Show

   Genie.Get "animation", "Greet, GreetReturn"
   Genie.Play "Greet"
   Genie.Speak "Hello."
```

If you declare an object reference and set it to this method, it returns a [**Request**](/en-us/windows/desktop/lwef/the-request-object) object. In addition, if you specify an animation that is not loaded or if the character has not been successfully loaded, the server sets the [**Status**](status-property) property of **Request** object to "failed" with an appropriate error number. However, if the animation does not exist and the character's data has already been successfully loaded, the server raises an error.

The **Play** method does not make the character visible. If the character is not visible, the server plays the animation invisibly, and sets the [**Status**](status-property) property of the [**Request**](/en-us/windows/desktop/lwef/the-request-object) object.