---
layout: Conceptual
title: The AnimationNames Collection - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/the-animationnames-collection
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
description: The AnimationNames Collection
ms.assetid: 3b06e497-1d03-43be-8d33-e69ef2972237
ms.topic: concept-article
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: a0e87d97-2383-5bed-4c25-b67633c233dd
document_version_independent_id: a0f023f8-bcc7-6ff5-3322-664c366c87f0
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/the-animationnames-collection.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/the-animationnames-collection.md
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 122
asset_id: lwef/the-animationnames-collection
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/the-animationnames-collection.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 3ac37d9f-074a-e48a-7d7c-018c9d0f4392
---

# The AnimationNames Collection - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

The [**AnimationNames**](https://www.bing.com/search?q=**AnimationNames**) collection is a special collection that contains the list of animation names compiled for a character. You can use the collection to enumerate the names of the animations for a character. For example, in Visual Basic or VBScript (2.0 or later) you can access these names using the **For Each...Next** statements:

```
   For Each Animation in Genie.AnimationNames
      Genie.Play Animation
   Next
```

Items in the collection have no properties, so individual items cannot be accessed directly.

For .ACF characters, the collection returns all the animations that have been defined for the character, not just the ones that have been retrieved with the [**Get**](get-method) method.