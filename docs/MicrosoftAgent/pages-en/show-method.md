---
layout: Conceptual
title: Show Method - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/show-method
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
description: Show Method
ms.assetid: 58adbb55-f4cb-4356-abc4-b85fa3af744d
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 604f17e9-f883-ebaa-366c-640fc2266ce7
document_version_independent_id: 3d242798-7104-d285-59ef-beb542f86592
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/show-method.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/show-method.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 228
asset_id: lwef/show-method
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/show-method.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: f813a384-2c19-36b2-c65a-707ea8035c21
---

# Show Method - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Makes the specified character visible and plays its associated **Showing** animation.
- **Syntax**
    - *agent*\*\*.Characters ("***CharacterID***").Show\*\* [*Fast*]

| Part | Description |
| --- | --- |
| *Fast* | Optional. A Boolean expression specifying whether the server plays the **Showing** animation. **True** Skips the **Showing** state animation. **False** (Default) Does not skip the **Showing** state animation. |

## Remarks

If you declare an object reference and set it to this method, it returns a [**Request**](/en-us/windows/desktop/lwef/the-request-object) object. In addition, if the associated **Showing** animation has not been loaded and you have not specified the **Fast** parameter as **True**, the server sets the **Request** object's [**Status**](status-property) property to "failed" with an appropriate error number. Therefore, if you are using the HTTP protocol to access character animation data, use the [**Get**](get-method) method to load the **Showing** state animation before calling the **Show** method.

Avoid setting the **Fast** parameter to **True** without first playing an animation beforehand; otherwise, the character frame may display with no image. In particular, note that if you call [**MoveTo**](moveto-method) when the character is not visible, it does not play any animation. Therefore, if you call the **Show** method with **Fast** set to **True**, no image will display. Similarly, if you call [**Hide**](hide-method) then **Show** with **Fast** set to **True**, there will be no visible image.