---
layout: Conceptual
title: Listen Method - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/listen-method
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
description: Listen Method
ms.assetid: ceb3b62f-2a33-4a13-b608-4cfa800be38a
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: a85a4b15-37ba-d540-41c5-d459473cf174
document_version_independent_id: 683b405b-1263-c48c-af91-81cb9c13dc9f
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/listen-method.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/listen-method.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 431
asset_id: lwef/listen-method
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/listen-method.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 35695996-0654-0682-6c6f-61f5377c449e
---

# Listen Method - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Turns on Listening mode (speech recognition) for a timed period.
- **Syntax**
    - *agent.**Characters***("***CharacterID***").Listen\*\* *State*

| Part | Description |
| --- | --- |
| *State* | Required. A Boolean value that determines whether to turn Listening mode on or off. **True** Turns Listening mode on. **False** Turns Listening mode off. |

## Remarks

Setting this method to **True** enables Listening mode (turns on speech recognition) for a fixed period of time (10 seconds). While you cannot set the value of the time-out, you can turn off Listening mode before the time-out expires. If you (or another client) successfully set Listening mode on and you attempt to set this property to **True** before the time-out expires, the method succeeds and resets the time-out. However, if the Listening mode is on because the user is pressing the Listening key, the method succeeds, but the time-out is ignored and the Listening mode ends based on the user's interaction with the Listening key.

This method succeeds only when called by the input-active client and if speech services have been started. To ensure that speech services have been started, query or set the [**SRModeID**](srmodeid-property) or set the [**Voice**](voice-property) setting for a [**Command**](/en-us/windows/desktop/lwef/the-command-object) before you call **Listen** otherwise the method will fail. To detect the success of this method, call it as a function and it will return a Boolean value indicating whether the method succeeded.

```
   If Genie.Listen(True) Then
      'The method succeeded

   Else
      ' The method failed

   End If
```

The method also fails if the user is pressing the Listening key and you attempt to set **Listen** to **False**. However, if the user has released the Listening key and Listening mode has not timed out, it will succeed.

**Listen** also fails if there is no compatible speech engine available that matches the character's [**LanguageID**](languageid-property) setting, the user has disabled speech input using the Microsoft Agent property sheet, or the audio device is busy.

When you successfully set this method to **True**, the server triggers the [**ListenStart**](listenstart-event) event. The server sends [**ListenComplete**](listencomplete-event) when the Listening mode time-out completes or when you set **Listen** to **False**.

This method does not automatically call [**Stop**](stop-method) and play a Listening state animation as the server does when the Listening key is pressed. This enables you to determine whether to interrupt the current animation using the [**ListenStart**](listenstart-event) animation by calling **Stop** and playing your own appropriate animation. However, the server does call **Stop** and plays a Hearing state animation when a user utterance is detected.