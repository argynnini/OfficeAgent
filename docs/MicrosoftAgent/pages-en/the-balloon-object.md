---
layout: Conceptual
title: The Balloon Object - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/the-balloon-object
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
description: The Balloon Object
ms.assetid: d5b52310-0b4e-4fe3-a481-53687be4a89c
ms.topic: concept-article
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: d02539ec-dac1-4bbe-4967-d08e0adf7a83
document_version_independent_id: fed15457-1fac-13fb-2086-d503a313cb90
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/the-balloon-object.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/the-balloon-object.md
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 149
asset_id: lwef/the-balloon-object
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/the-balloon-object.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: e68ca1db-9982-d17e-6627-27625becb612
---

# The Balloon Object - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

Microsoft Agent supports textual captioning of [**Speak**](speak-method) method using a cartoon word balloon. The [**Think**](think-method) method enables you to display text without audio output in a "thought" word balloon.

A character's initial word balloon window defaults are defined and compiled in the Microsoft Agent Character Editor. Once running, the balloon's [**Enabled**](enabled-property) and [**Font**](https://www.bing.com/search?q=**Font**) properties may be overridden by the user. If a user changes the word balloon's properties, they affect all characters. Both the [**Speak**](speak-method) and [**Think**](think-method) word balloons use the same property settings for size. You can access the properties for a character's word balloon through the [**Balloon**](/en-us/windows/desktop/lwef/the-balloon-object) object, which is a child of the [**Character**](/en-us/windows/desktop/lwef/the-characters-object) object.

The [**Balloon**](/en-us/windows/desktop/lwef/the-balloon-object) object supports the following properties:

- [**BackColor**](backcolor-property)
- [**BorderColor**](bordercolor-property)
- [**CharsPerLine**](charsperline-property)
- [**Enabled**](enabled-property)
- [**FontCharSet**](fontcharset-property)
- [**FontName**](fontname-property-bal)
- [**FontBold**](fontbold-property)
- [**FontItalic**](fontitalic-property)
- [**FontSize**](fontsize-property-bal)
- [**FontStrikeThru**](fontstrikethru-property)
- [**FontUnderline**](fontunderline-property)
- [**ForeColor**](forecolor-property)
- [**NumberOfLines**](numberoflines-property)
- [**Style**](style-property)
- [**Visible**](visible-property-bal)