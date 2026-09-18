---
layout: Conceptual
title: Connected Property - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/connected-property
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
description: Connected Property
ms.assetid: 61b7f550-d8d6-4719-a0d4-0bf3a8cf096c
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 7bf4c1b7-acfe-a204-e473-8d7c18a7bbcb
document_version_independent_id: eb285f02-19bb-7f9b-34ee-35437698c848
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/connected-property.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/connected-property.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 602
asset_id: lwef/connected-property
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/connected-property.md
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: c0a82fc7-ae3d-77a2-b0d0-95fe32ba596d
---

# Connected Property - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Returns or sets whether the current control is connected to the Microsoft Agent server.
- **Syntax**
    - \*agent.\***Connected** [ = *boolean*]

| Part | Description |
| --- | --- |
| *boolean* | A Boolean expression specifying whether the control is connected. **True** The control is connected. |

## Remarks

In many situations, specifying the control automatically creates a connection with the Microsoft Agent server. For example, specifying the Microsoft Agent control's CLSID in the &lt;OBJECT&gt; tag in a webpage automatically opens a server connection and exiting the page closes the connection. Similarly, for Visual Basic or other languages that enable you to drop a control on a form, running the program automatically opens a connection and exiting the program closes the connection. If the server isn't currently running, it automatically starts.

However, if you want to create an Agent control at run time, you may also need to explicitly open a new connection to the server using the **Connected** property. For example, in Visual Basic you can create an ActiveX object at run time using the Set statement with the **New** keyword (or CreateObject function). While this creates the object, it may not create the connection to the server. You can use the **Connected** property before any code that calls into Microsoft Agent's programming interface, as shown in the following example:

```
   ' Declare a global variable for the control
   Dim MyAgent as Agent

   ' Create an instance of the control using New
   Set MyAgent = New Agent

   ' Open a connection to the server
   MyAgent.Connected = True

   ' Load a character
   MyAgent.Characters.Load "Genie", " Genie.acs"

   ' Display the character
   MyAgent.Characters("Genie").Show
```

Creating a control using this technique does not expose the Agent control's events. In Visual Basic 5.0 (and later), you can access the control's events by including the control in your project's references, and use the **WithEvents** keyword in your variable declaration:

```
   Dim WithEvents MyAgent as Agent

   ' Create an instance of the control using New
   Set MyAgent = New Agent
```

Using **WithEvents** to create an instance of the Agent control at run time automatically opens the connection with the Microsoft Agent server. Therefore, you don't need to include a **Connected** statement.

You can close your connection to the server by releasing all references you created to Agent objects, such as IAgentCtlCharacterEx and IAgentCtlCommandEx. You must also release your reference to the Agent control itself. In Visual Basic, you can release a reference to an object by setting its variable to **Nothing**. If you have loaded characters, unload them before releasing the character object.

```
   Dim WithEvents MyAgent as Agent
   Dim Genie as IAgentCtlCharacterEx
   
   Sub Form_Load

   ' Create an instance of the control using New
   Set MyAgent = New Agent

   ' Open a connection to the server
   MyAgent.Connected = True

   ' Load the character into the Characters collection
   MyAgent.Characters.Load "Genie", " Genie.acs"

   ' Create a reference to the character
   Set Genie = MyAgent.Characters("Genie")

   End Sub

   Sub CloseConnection

   ' Unload the character
   MyAgent.Characters.Unload "Genie"

   ' Release the reference to the character object
   Set Genie = Nothing

   ' Release the reference to the Agent control
   Set MyAgent = Nothing
   End Sub
```

Note

You cannot close your connection to the server by releasing references where the component has been added. For example, you cannot close your connection to the server on webpages where you use the &lt;OBJECT&gt; tag to declare the control or in a Visual Basic application where you drop the control on a form. While releasing all Agent references will reduce Agent's working set, the connection remains until you navigate to the next page or exit the application.