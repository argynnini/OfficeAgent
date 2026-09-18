---
layout: Conceptual
title: Think Method - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/think-method
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
description: Think Method
ms.assetid: a188dd47-6af1-429d-af0a-69451f6b495e
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: b215254f-f9d1-c600-bba1-016eb8d1bf2f
document_version_independent_id: c0aaca06-7368-0dc0-ec07-7e04085f6370
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/think-method.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/think-method.md
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 262
asset_id: lwef/think-method
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/think-method.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: e69f879a-75b0-2bb4-442c-abc0be23862c
---

# Think Method - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Displays the specified text for the specified character in a "thought" word balloon.
- **Syntax**
    - *agent*\*\*.Characters ("***CharacterID***").Think\*\* [*Text*]

| Part | Description |
| --- | --- |
| *Text* | Optional. A string that specifies the character's thought output. |

## Remarks

Like the [**Speak**](speak-method) method, the **Think** method is a queued request that displays text in a word balloon, except that the **Think** word balloon differs visually. In addition, the balloon supports only the Bookmark speech control tag (**\Mrk**) and ignores any other speech control tags. Unlike **Speak**, the **Think** method does not change the character's animation state.

The [**Balloon**](/en-us/windows/desktop/lwef/the-balloon-object) object's properties affect the output of both the [**Speak**](speak-method) and **Think** methods. For example, the **Balloon** object's [**Enabled**](enabled-property) property must be **True** for text to display.

If you declare an object reference and set it to this method, it returns a [**Request**](/en-us/windows/desktop/lwef/the-request-object) object. In addition, if the file has not been loaded, the server sets the **Request** object's [**Status**](status-property) property to "failed" with an appropriate error code number.

Agent's automatic word breaking in the word balloon breaks words using white-space characters (for example, Space or Tab). However, if it cannot, it may break a word to fit the balloon. In languages like Japanese, Chinese, and Thai where spaces are not used to break words, insert a Unicode zero-width space character (0x200B) between characters to define logical word breaks.

Note

Set the character's language ID before using the [**Speak**](speak-method) method to ensure appropriate text display within the word balloon.