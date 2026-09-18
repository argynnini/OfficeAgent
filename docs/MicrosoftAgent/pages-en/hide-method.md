---
layout: Conceptual
title: Hide Method - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/hide-method
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
description: Hide Method
ms.assetid: c30eda78-0951-43b4-8ae1-daccbd41170d
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: e7d201c8-b4c3-69f1-f8d4-47e7e7ed0335
document_version_independent_id: 000acc47-fe39-8828-8031-1104124845a3
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/hide-method.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/hide-method.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 240
asset_id: lwef/hide-method
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/hide-method.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: ec6260bb-cfd7-3994-8b92-7e2c891fd91b
---

# Hide Method - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Hides the specified character.
- **Syntax**
    - *agent*\*\*.Characters ("***CharacterID***").Hide\*\* [*Fast*]

| Part | Description |
| --- | --- |
| *Fast* | Optional. A Boolean value that indicates whether to skip the animation associated with the character's Hiding state **True** Does not play the **Hiding** animation. **False** (Default) Plays the **Hiding** animation. |

## Remarks

The server queues the actions of the **Hide** method in the character's queue, so you can use it to hide the character after a sequence of other animations. You can play the action immediately by using the [**Stop**](stop-method) method before calling this method.

If you declare an object reference and set it to this method, it returns a [**Request**](/en-us/windows/desktop/lwef/the-request-object) object. In addition, if the associated **Hiding** animation has not been loaded and you have not specified the **Fast** parameter as **True**, the server sets the **Request** object [**Status**](status-property) property to "failed" with an appropriate error number. Therefore, if you are using the HTTP protocol to access character or animation data, use the [**Get**](get-method) method and specify the **Hiding** state to load the animation before calling the **Hide** method.

Hiding a character can also result in triggering the [**ActivateInput**](activateinput-event) event of another client.

Note

Hidden characters cannot access the audio channel. The server will pass back a failure status in the [**RequestComplete**](requestcomplete-event) event if you generate an animation request and the character is hidden.