---
layout: Conceptual
title: Character Object Methods - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/character-object-methods
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
description: Character Object Methods
ms.assetid: 0f926b7b-c1cf-4bd6-ba8c-1b2877eb1d24
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 45be45e4-8c7f-e85c-b961-6ecef10f78bd
document_version_independent_id: 604f4035-f3a6-5877-a4c7-6932647544dd
updated_at: 2020-08-19T21:26:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/character-object-methods.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/adcc2e2cf0329f73eb5d5ecafc17c88bc0bfb02f/desktop-src/lwef/character-object-methods.md
git_commit_id: adcc2e2cf0329f73eb5d5ecafc17c88bc0bfb02f
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 414
asset_id: lwef/character-object-methods
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/character-object-methods.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 847b1aae-7b85-f2ab-9449-9062376ab8bb
---

# Character Object Methods - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

The server also exposes methods for each character in a [**Characters**](/en-us/windows/desktop/lwef/the-characters-object) collection. The following methods are supported:

- [**Activate**](activate-method)
- [**GestureAt**](gestureat-method)
- [**Get**](get-method)
- [**Hide**](hide-method)
- [**Interrupt**](interrupt-method)
- [**Listen**](listen-method)
- [**MoveTo**](moveto-method)
- [**Play**](play-method)
- [**Show**](show-method)
- [**ShowPopupMenu**](showpopupmenu-method)
- [**Speak**](speak-method)
- [**Stop**](stop-method)
- [**StopAll**](stopall-method)
- [**Think**](think-method)
- [**Wait**](wait-method)

To use a method, reference the character in the collection. In VBScript and Visual Basic, you do this by specifying the ID for a character:

```
   Sub FormLoad

   'Load the genie character into the Characters collection
   Agent1.Characters.Load "Genie", "Genie.acs"

   'Display the character
   Agent1.Characters("Genie").Show
   Agent1.Characters("Genie").Play "Greet"
   Agent1.Characters("Genie").Speak "Hello. "

   End Sub
```

To simplify the syntax of your code, you can define an object variable and set it to reference a character object in the [**Characters**](/en-us/windows/desktop/lwef/the-characters-object) collection; then you can use your variable to reference methods or properties of the character. The following example demonstrates how you can do this using the Visual Basic Set statement:

```
   'Define a global object variable
   Dim Genie as Object

   Sub FormLoad

   'Load the genie character into the Characters collection
   Agent1.Characters.Load "Genie", " Genie.acs"

   'Create a reference to the character
   Set Genie = Agent1.Characters("Genie")

   'Display the character
   Genie.Show

   'Get the Restpose animation
   Genie.Get "animation", "RestPose"

   'Make the character say Hello
   Genie.Speak "Hello."

   End Sub
```

In Visual Basic 5.0, you can also create your reference by declaring your variable as a [**Character**](/en-us/windows/desktop/lwef/the-characters-object)object:

```
   Dim Genie as IAgentCtlCharacterEx

   Sub FormLoad

   'Load the genie character into the Characters collection
   Agent1.Characters.Load "Genie", "Genie.acs"

   'Create a reference to the character
   Set Genie = Agent1.Characters("Genie")

   'Display the character
   Genie.Show

   End Sub
```

Declaring your object of type IAgentCtlCharacterEx enables early binding on the object, which results in better performance.

In VBScript, you cannot declare a reference as a particular type. However, you can simply declare the variable reference:

```
<SCRIPT LANGUAGE = "VBSCRIPT">
<!—--

   Dim Genie
   
   Sub window_OnLoad
   
   'Load the character
   AgentCtl.Characters.Load "Genie", "https://agent.microsoft.com/characters/v2/genie/genie.acf"

   'Create an object reference to the character in the collection
   set Genie= AgentCtl.Characters ("Genie")

   'Get the Showing state animation
   Genie.Get "state", "Showing"

   'Display the character
   Genie.Show

   End Sub

-->
   </SCRIPT>
```

Some programming languages do not support collections. However, you can access a [**Character**](/en-us/windows/desktop/lwef/the-characters-object) object's methods with the [**Character**](character-method) method:

```
   agent.Characters.Character("CharacterID").method
```

In addition, you can also create a reference to the [**Character**](/en-us/windows/desktop/lwef/the-characters-object) object to make your script code easier to follow:

```
<SCRIPT LANGUAGE="JScript" FOR="window" EVENT="onLoad()">
<!--
   
   //Load the character's data
   AgentCtl.Characters.Load ("Genie", _
      "https://agent.microsoft.com/characters/v2/genie/genie.acf");   

   //Create a reference to this object
   Genie = AgentCtl.Characters.Character("Genie");
   
   //Get the Showing state animation
   Genie.Get("state", "Showing");

   //Display the character
   Genie.Show();

-->
</SCRIPT>
```