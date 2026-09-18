---
layout: Conceptual
title: FontName Property (Balloon Object) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/fontname-property-bal
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
description: Learn about the FontName Balloon object property. Microsoft Agent is deprecated as of Windows 7.
ms.assetid: a84a19a4-9e0e-4736-b401-286e6618bc19
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: f020f9e5-594c-f78a-ada2-64c761f3ae42
document_version_independent_id: b455a6f2-bb49-70c0-05bf-3ea8a1dfb980
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/fontname-property-bal.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/fontname-property-bal.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 190
asset_id: lwef/fontname-property-bal
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/fontname-property-bal.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 438d7834-d692-eebb-788f-1c1ac5dce474
---

# FontName Property (Balloon Object) - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Returns or sets the font used in the word balloon for the specified character.
- **Syntax**
    - \*agent.\***Characters("*CharacterID*").Balloon.FontName** [ = *font*]

| Part | Description |
| --- | --- |
| *font* | A string value corresponding to the font's name. |

## Remarks

The [**FontName**](fontname-property) property defines the font used to display text in the word balloon window of a string. The default value for the font settings of a character's word balloon are set in the Microsoft Agent Character Editor. In addition, the user can override font settings for all characters in the Microsoft Agent property sheet.

This property applies only to your client application's use of the character; the setting does not affect other clients of the character or other characters of your client application.

Note

If you are using a character that you did not compile, check the [**FontName**](fontname-property) and [**FontCharSet**](fontcharset-property) properties for the character to determine whether they are appropriate for your locale. You may need to set these values before using the [**Speak**](speak-method) method to ensure appropriate text display within the word balloon.