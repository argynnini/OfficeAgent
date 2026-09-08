---
layout: Conceptual
title: Accessing the Controls Methods, Properties, and Events - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/accessing-the-controls-methods--properties--and-events
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
description: Accessing the Controls Methods, Properties, and Events
ms.assetid: 70a3b011-0290-4df4-9b66-23b27bcb14e9
ms.topic: concept-article
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 0e2b7217-1d21-1dc0-d137-0e5752598c85
document_version_independent_id: da037c9f-6e7d-29b7-f780-ff44bc02b427
updated_at: 2025-03-13T17:42:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/accessing-the-controls-methods--properties--and-events.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/accessing-the-controls-methods--properties--and-events.md
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 504
asset_id: lwef/accessing-the-controls-methods--properties--and-events
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/accessing-the-controls-methods--properties--and-events.md
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 8bce64e6-97ff-08c9-a8f4-bc12f8d96779
---

# Accessing the Controls Methods, Properties, and Events - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

Using Microsoft Agent's control with Visual Basic is very similar to using the control with VBScript, except that events in Visual Basic must include the data type of passed parameters. Adding the Microsoft Agent control to a form will automatically include Microsoft Agent's events with their appropriate parameters. It will also automatically create a connection to the Agent server when the application runs.

You may also be able to use your programming language's object's creation syntax to create an instance of the control at runtime. For example, in Visual Basic (5.0 or later), if you include the Microsoft Agent 2.0 Control in your project's references, you can use a [**With Events**](https://www.bing.com/search?q=**With+Events**)..[**New**](https://www.bing.com/search?q=**New**) declaration. If you do not include the reference, VB raises an error indicating that Microsoft Agent was unable to start (error code 80042502).

```syntax
   ' Declare a global variable for the control
   Dim WithEvents MyAgent as Agent

   ' Create an instance of the control using New
   Set MyAgent = New Agent

' Load a character
   MyAgent.Characters.Load "Genie", " Genie.acs"

   ' Display the character
   MyAgent.Characters("Genie").Show
```

For versions of VB prior to 5.0, you can use the VB [**New**](https://www.bing.com/search?q=**New**) keyword without [**WithEvents**](https://www.bing.com/search?q=**WithEvents**) declaration or the VB [**CreateObject**](https://msdn.microsoft.com/library/Bb545141%28v=VS.85%29.aspx) function, but these conventions will not expose the Agent control's events. You also need to use the [**Connected**](https://www.bing.com/search?q=**Connected**) property before you reference any Agent methods or properties. If this is not done, VB will raise an error indicating that Microsoft Agent was unable to start (error code 80042502).

Similarly for other programming languages, you may have to use the [**Connected**](https://www.bing.com/search?q=**Connected**) property to establish a connection to the Agent Component Object Model (COM) server before your code can call any of the Agent control's methods or properties. In addition, for some programming languages, Agent's methods and properties may not be directly exposed unless you declare the Agent control using its type. For example, in Microsoft Access 97, you will need to declare the object as type Agent to see the methods and properties display in the Auto List Members drop-down box when you type.

Most programming languages that support ActiveX controls follow conventions similar to Visual Basic. For programming languages that do not support object collections, you can use the [**Character**](https://www.bing.com/search?q=**Character**) method and [**Command**](https://www.bing.com/search?q=**Command**) method to access methods and properties of items in the collection.

Programming languages like Visual Basic, that provide access to the object types exposed by the Agent control, enable you to use these in your object declarations. For example, instead of declaring an object as a generic type:

```syntax
   Dim Genie as Object
```

You can declare an object as a specific type:

```syntax
   Dim Genie as IAgentCtlCharacterEx
```

This may improve the overall performance of your application.

For some object types, you may find two types that are the same except for the "Ex" suffix. Where both exist, use the "Ex" type because this provides the full functionality of Agent. The non-"Ex" counterparts are included only for backward compatibility.