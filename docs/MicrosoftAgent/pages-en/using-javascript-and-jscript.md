---
layout: Conceptual
title: Using JavaScript and JScript - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/using-javascript-and-jscript
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
description: Using JavaScript and JScript
ms.assetid: c6927663-9432-4fa9-8de6-abb7237909b9
ms.topic: concept-article
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: d8238597-97fc-e65c-3e9c-edfb00ae7eda
document_version_independent_id: 8a38eda5-d653-ad2b-0228-975b12b59833
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/using-javascript-and-jscript.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/using-javascript-and-jscript.md
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 164
asset_id: lwef/using-javascript-and-jscript
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/using-javascript-and-jscript.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 5a191756-26d5-784f-0561-9ee68ee02772
---

# Using JavaScript and JScript - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

If you use JavaScript or Microsoft JScript to access Microsoft Agent's programming interface, follow the conventions for this language for specifying methods or properties:

```syntax
agent.object.Method (parameter)
agent.object.Property = value
```

JavaScript does not currently have event syntax for non-HTML objects. However, with Internet Explorer you can use the `<SCRIPT>` tag's **For...Event** syntax:

```syntax
<SCRIPT LANGUAGE="JScript" FOR="object" EVENT="event()">
statements
</SCRIPT>
```

Because not all browsers currently support this event syntax, you may want to use JavaScript only for pages that support Microsoft Internet Explorer or for code that does not require event handling.

To access Agent's object collections, use the JScript [**Enumerator**](https://www.bing.com/search?q=**Enumerator**) function. However, versions of JScript included prior to Internet Explorer 4.0 do not support this function and do not support collections. To access methods and properties of the [**Character**](/en-us/windows/desktop/lwef/the-characters-object) object, use the [**Character**](character-method) method. Similarly, to access the properties of a [**Command**](/en-us/windows/desktop/lwef/the-command-object) object, use the [**Command**](command-method) method.