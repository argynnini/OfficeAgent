---
layout: Conceptual
title: Stop Method (Legacy Windows Environment Features) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/stop-method
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
description: Stop Method
ms.assetid: 68372f72-db9c-447c-a3e4-488940c730d7
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 61ea26df-ff61-b18a-b461-e66a990c124a
document_version_independent_id: 2ee4c980-2c93-2ec0-b83c-585ce769fe57
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/stop-method.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/stop-method.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 174
asset_id: lwef/stop-method
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/stop-method.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: df133574-6624-f430-2965-0def9a14319d
---

# Stop Method (Legacy Windows Environment Features) - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Stops the animation for the specified character.
- **Syntax**
    - *agent*\*\*.Characters ("***CharacterID***").Stop\*\* [*Request*]

| Part | Description |
| --- | --- |
| *Request* | Optional. A [**Request**](/en-us/windows/desktop/lwef/the-request-object) object specifying a particular animation call. |

## Remarks

To specify the request parameter, you must create a variable and assign the animation request you want to stop. If you don't set the **Request** parameter, the server stops all animations for the character, including queued [**Get**](get-method) calls, and clears its animation queue unless the character is currently playing its **Hiding** or **Showing** animation. This method does not stop non-queued **Get** calls.

To stop a specific animation or [**Get**](get-method) call, declare an object variable and assign your animation request to that variable:

```
   Dim MyRequest
   Dim Genie

   Agent1.Characters.Load "Genie", "https://agent.microsoft.com/characters/v2/genie/genie.acf"

   Set Genie = Agent1.Characters ("Genie")

   Genie.Get "state", "Showing"
   Genie.Get "animation", "Greet, GreetReturn"

   Genie.Show
   
   'This animation will never play
   Set MyRequest = Genie.Play ("Greet")
   
   Genie.Stop MyRequest
```

This method will not generate a [**Request**](/en-us/windows/desktop/lwef/the-request-object) object.