---
layout: Conceptual
title: The Request Object - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/the-request-object
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
description: The Request Object
ms.assetid: d8b37164-6855-48c0-bcf8-a86c0f8b3a59
ms.topic: concept-article
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 9a643e62-b2f2-2b9c-79b1-134bd820f280
document_version_independent_id: e9b5da95-294c-c596-4b34-75b35c4a5932
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/the-request-object.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/the-request-object.md
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 492
asset_id: lwef/the-request-object
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/the-request-object.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://authoring-docs-microsoft.poolparty.biz/devrel/540ac133-a371-4dbb-8f94-28d6cc77a70b
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://authoring-docs-microsoft.poolparty.biz/devrel/60bfc045-f127-4841-9d00-ea35495a5800
platformId: f29792a6-f8dd-f913-1928-bc6ed647b3d8
---

# The Request Object - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

The server processes some methods asynchronously. This enables your application code to continue while the method is completing. When a client application calls one of these methods, the control creates and returns a [**Request**](/en-us/windows/desktop/lwef/the-request-object) object for the request. You can use the **Request** object to track the status of the method by assigning an object variable to the method. In Visual Basic, first declare an object variable:

```
   Dim MyRequest as Object
```

In VBScript, you don't include the variable type in your declaration:

```
   Dim MyRequest
```

And use Visual Basic's Set statement to assign the variable to the method call:

```
   Set MyRequest = <i>agent</i>.Characters("<i>CharacterID</i>").<i>method</i> (<i>parameter</i>[s])
```

This adds a reference to the [**Request**](/en-us/windows/desktop/lwef/the-request-object) object. The **Request** object will be destroyed when there are no more references to it. Where you declare the **Request** object and how you use it determines its lifetime. If the object is declared local to a subroutine or function, it will be destroyed when it goes out of scope; that is, when the subroutine or function ends. If the object is declared globally, it will not be destroyed until either the program terminates or a new value (or a value set to "empty") is assigned to the object.

The [**Request**](/en-us/windows/desktop/lwef/the-request-object) object provides several properties you can query. For example, the [**Status**](status-property) property returns the current status of the request. You can use this property to check the status of your request:

```
   Dim MyRequest
   
   Set MyRequest = Agent1.Characters.Load ("Genie", "https://agent.microsoft.com/characters/v2/genie/genie.acf")

   If (MyRequest.Status = 2) then
      'do something

   Else If (MyRequest.Status = 0) then
      'do something right away

   End If
```

The [**Status**](status-property) property returns the status of a [**Request**](/en-us/windows/desktop/lwef/the-request-object) object as a Long integer value.

| Status | Definition |
| --- | --- |
| 0 | Request successfully completed. |
| 1 | Request failed. |
| 2 | Request pending (in the queue, but not complete). |
| 3 | Request interrupted. |
| 4 | Request in progress. |

The [**Request**](/en-us/windows/desktop/lwef/the-request-object) object also includes a Long integer value in the [**Number**](https://www.bing.com/search?q=**Number**) property that returns the error or cause of the [**Status**](status-property) code. If none, this value is zero (0). The [**Description**](description-property) property contains a string value that corresponds to the error number. If the string doesn't exist, **Description** contains "Application-defined or object-defined error".

For the values and meaning returned by the [**Number**](https://www.bing.com/search?q=**Number**) property, see [Error Codes](microsoft-agent-error-codes).

The server places animation requests in the specified character's queue. This enables the server to play the animation on a separate thread, and your application's code can continue while animations play. If you create a [**Request**](/en-us/windows/desktop/lwef/the-request-object) object reference, the server automatically notifies you when an animation request has started or completed through the [**RequestStart**](https://www.bing.com/search?q=**RequestStart**) and [**RequestComplete**](https://www.bing.com/search?q=**RequestComplete**) events. Because methods that return **Request** objects are asynchronous and may not complete during the scope of the calling function, declare your reference to the **Request** object globally.

The following methods can be used to return a [**Request**](/en-us/windows/desktop/lwef/the-request-object) object: [**GestureAt**](gestureat-method), [**Get**](get-method), [**Hide**](hide-method), [**Interrupt**](interrupt-method), [**Load**](load-method), [**MoveTo**](moveto-method), [**Play**](play-method), [**Show**](show-method), [**Speak**](speak-method), and [**Wait**](https://www.bing.com/search?q=**Wait**).