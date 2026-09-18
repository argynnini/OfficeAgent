---
layout: Conceptual
title: Wait Method - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/wait-method
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
description: Wait Method
ms.assetid: 968a3f19-6953-473b-ba98-0dc93696e703
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: cbe3a755-d4f5-880e-6ad8-4ef15176b21a
document_version_independent_id: 41045f6b-1426-9f07-8906-a6edbbeacec2
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/wait-method.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/wait-method.md
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 283
asset_id: lwef/wait-method
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/wait-method.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 9247e890-a44c-1f93-ce8c-08b0bf642dff
---

# Wait Method - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Causes the animation queue for the specified character to wait until the specified animation request completes.
- **Syntax**
    - *agent*\*\*.Characters ("***CharacterID***").Wait\*\**Request*

| Part | Description |
| --- | --- |
| *Request* | A [**Request**](/en-us/windows/desktop/lwef/the-request-object) object specifying a particular animation.. |

## Remarks

Use this method only when you support multiple (simultaneous) characters and are trying to sequence the interaction of characters. (For a single character, each animation request is played sequentially--after the previous request completes.) If you have two characters and you want a character's animation request to wait until the other character's animation completes, set the **Wait** method to the other character's animation [**Request**](/en-us/windows/desktop/lwef/the-request-object) object. To specify the request parameter, you must create a variable and assign the animation request you want to interrupt:

```
   Dim GenieRequest 
   Dim RobbyRequest 
   Dim Genie 
   Dim Robby 

   Sub window_Onload

   Agent1.Characters.Load "Genie", "https://agent.microsoft.com/characters/v2/genie/genie.acf"
   Agent1.Characters.Load "Robby", "https://agent.microsoft.com/characters/v2/robby/robby.acf"

   Set Genie = Agent1.Characters("Genie")
   Set Robby = Agent1.Characters("Robby")

   Genie.Get "State", "Showing"
   Robby.Get "State", "Showing"

   Genie.Get "Animation", "Announce, AnnounceReturn, Pleased, _ 
      PleasedReturn"
   
   Robby.Get "Animation", "Confused, ConfusedReturn, Sad, SadReturn"

   Set Genie = Agent1.Characters ("Genie")
   Set Robby = Agent1.Characters ("Robby")

   Genie.MoveTo 100,100
   Genie.Show

   Robby.MoveTo 250,100
   Robby.Show

   Genie.Play "Announce"
   Set GenieRequest = Genie.Speak ("Why did the chicken cross the road?")
   
   Robby.Wait GenieRequest
   Robby.Play "Confused"
   Set RobbyRequest = Robby.Speak ("I don't know. Why did the chicken _
      cross the road?")
   
   Genie.Wait RobbyRequest
   Genie.Play "Pleased"
   Set GenieRequest = Genie.Speak ("To get to the other side.")
   
   Robby.Wait GenieRequest
   Robby.Play "Sad"
   Robby.Speak "I never should have asked."

   End Sub
```

You can also streamline your code by just calling **Wait** directly, using a specific animation request.

```
   Robby.Wait Genie.Play "GestureRight"
```

This avoids having to explicitly declare a [**Request**](/en-us/windows/desktop/lwef/the-request-object) object.