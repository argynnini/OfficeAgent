---
layout: Conceptual
title: MoveTo Method - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/moveto-method
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
description: MoveTo Method
ms.assetid: cca2b1b8-0d44-4272-9f0b-f7afd091d802
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 0efe238f-ff75-cb64-f90f-1bfd59d89eaa
document_version_independent_id: 0eff35e9-d556-898e-bfd8-3b8ad3686f91
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/moveto-method.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/moveto-method.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 285
asset_id: lwef/moveto-method
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/moveto-method.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: 83a94700-3ec4-dbbc-bed0-c807d7291b6d
---

# MoveTo Method - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Moves the specified character to the specified location.
- **Syntax**
    - *agent*\*\*.Characters ("***CharacterID***").MoveTo\*\* *x,y*[*Speed*]

| Part | Description |
| --- | --- |
| *x,y* | Required. An integer value that indicates the left edge (*x*) and top edge (*y*) of the animation frame. Express these coordinates in pixels. |
| *Speed* | Optional. A Long integer value specifying in milliseconds how quickly the character's frame moves. The default value is 1000. Specifying zero (0) moves the frame without playing an animation. |

## Remarks

The server automatically plays the appropriate animation assigned to the **Moving** states. The location of a character is based on the upper left corner of its frame.

If you declare an object variable and set it to this method, it returns a [**Request**](/en-us/windows/desktop/lwef/the-request-object) object. In addition, if the associated animation has not been loaded on the local machine, the server sets the **Request** object's [**Status**](status-property) property to "failed" with an appropriate error number. Therefore, if you are using the HTTP protocol to access character or animation data, use the [**Get**](get-method) method to load the **Moving** state animations before calling the **MoveTo** method.

Even if the animation is not loaded, the server still moves the frame.

Note

If you call **MoveTo** with a nonzero value before the character is shown, it will return a failure status if you assigned it a [**Request**](/en-us/windows/desktop/lwef/the-request-object) object, because the nonzero value indicates that you are attempting to play an animation when the character is not visible.

Note

The *Speed* parameter's actual effect may vary based on the speed of the processor of the computer and the priority of other tasks running on the system.