---
layout: Conceptual
title: GestureAt Method - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/gestureat-method
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
description: GestureAt Method
ms.assetid: c84e9363-e905-476a-832b-9acf6ddee5f1
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 52f22719-04a7-40ff-4964-8a84841c465f
document_version_independent_id: 7974dbf5-25cf-c010-58eb-a2f70b9026f2
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/gestureat-method.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/gestureat-method.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 171
asset_id: lwef/gestureat-method
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/gestureat-method.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 83975e0e-adec-ac4b-a6a2-cacf95962c76
---

# GestureAt Method - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Plays the gesturing animation for the specified character at the specified location.
- **Syntax**
    - *agent*\*\*.Characters ("***CharacterID***").GestureAt\*\* *x,y*

| Part | Description |
| --- | --- |
| *x,y* | Required. An integer value that indicates the horizontal (*x*) screen coordinate and vertical (*y*) screen coordinate to which the character will gesture. These coordinates must be specified in pixels. |

## Remarks

The server automatically plays the appropriate animation to gesture toward the specified location. The coordinates are always relative to the screen origin (upper left).

If you declare an object reference and set it to this method, it returns a [**Request**](/en-us/windows/desktop/lwef/the-request-object) object. In addition, if the associated animation has not been loaded on the local machine, the server sets the **Request** object's [**Status**](status-property) property to "failed" with an appropriate error number. Therefore, if you are using the HTTP protocol to access character animation data, use the [**Get**](get-method) method to load the **Gesturing** state animations before calling the **GestureAt** method.