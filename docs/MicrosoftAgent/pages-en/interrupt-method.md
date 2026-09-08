---
layout: Conceptual
title: Interrupt Method - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/interrupt-method
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
description: Interrupt Method
ms.assetid: b8442e25-a629-47c7-acdd-1d28e74d78a2
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 306503d3-fbb9-c2af-6cca-4d17579c1e03
document_version_independent_id: 75c6d0c3-538a-502a-ae12-5eb73c7c2ead
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/interrupt-method.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/interrupt-method.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 282
asset_id: lwef/interrupt-method
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/interrupt-method.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/0850fefd-e402-4507-ae98-46cfdfc2e16c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/6ecf98a5-97c7-4249-b209-a9d9e42633a0
platformId: 1763369d-0b6a-b233-aff2-7ca0b3f3ae84
---

# Interrupt Method - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Interrupts the animation for the specified character.
- **Syntax**
    - *agent*\*\*.Characters ("***CharacterID***").Interrupt\*\* *Request*

| Part | Description |
| --- | --- |
| *Request* | A [**Request**](/en-us/windows/desktop/lwef/the-request-object) object for a particular animation call. |

## Remarks

You can use this to sync up animation between characters. For example, if another character is in a looping animation, this method will stop the loop and move to the next animation in the character's queue. You cannot interrupt a character animation that you are not using (that you have not loaded).

To specify the request parameter, you must create a variable and assign the animation request you want to interrupt:

```
   Dim GenieRequest as Object
   Dim RobbyRequest as Object
   Dim Genie as Object
   Dim Robby as Object

   Sub FormLoad()

      MyAgent1.Characters.Load "Genie", "Genie.acs"

      MyAgent1.Characters.Load "Robby", "Robby.acs"

      Set Genie = MyAgent1.Characters ("Genie")
      Set Robby = MyAgent1.Characters ("Robby")

      Genie.Show

      Genie.Speak "Just a moment"

      Set GenieRequest = Genie.Play ("Processing")

      Robby.Show
      Robby.Play "confused"
      Robby.Speak "Hey, Genie. What are you doing?"
      Robby.Interrupt GenieRequest

      Genie.Speak "I was just checking on something."

   End Sub
```

You cannot interrupt the animation of the same character you specify in this method because the server queues the **Interrupt** method in that character's animation queue. Therefore, you can only use **Interrupt** to halt the animation of another character you have loaded.

If you declare an object reference and set it to this method, it returns a [**Request**](/en-us/windows/desktop/lwef/the-request-object) object.

Note

**Interrupt** does not flush the character's queue; it halts the existing animation and moves on to the next animation in the character's queue. To halt and flush a character's queue, use the [**Stop**](stop-method) method.