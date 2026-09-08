---
layout: Conceptual
title: Character Object Properties - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/character-object-properties
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
description: Character Object Properties
ms.assetid: 86748de2-f5c8-4057-bfa4-79d46cac1e62
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: ef37d18f-0995-ed96-c4a0-a1d4b50ed098
document_version_independent_id: 74764482-9875-069e-7357-f8485a0ebf6d
updated_at: 2025-03-13T17:42:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/character-object-properties.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/character-object-properties.md
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 234
asset_id: lwef/character-object-properties
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/character-object-properties.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: f03140f6-08a1-f210-2892-5fb44c58bf65
---

# Character Object Properties - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

The [**Character**](/en-us/windows/desktop/lwef/the-characters-object) object exposes the following properties:

- [**Active**](active-property)
- [**AutoPopupMenu**](autopopupmenu-property)
- [**Description**](description-property)
- [**ExtraData**](extradata-property)
- [**GUID**](guid-property)
- [**HasOtherClients**](hasotherclients-property)
- [**Height**](height-property)
- [**HelpContextID**](helpcontextid-property-ch)
- [**HelpFile**](helpfile-property)
- [**HelpModeOn**](helpmodeon-property)
- [**IdleOn**](idleon-property)
- [**LanguageID**](languageid-property)
- [**Left**](left-property)
- [**MoveCause**](movecause-property)
- [**Name**](name-property)
- [**OriginalHeight**](originalheight-property)
- [**OriginalWidth**](originalwidth-property)
- [**Pitch**](pitch-property)
- [**SoundEffectsOn**](soundeffectson-property)
- [**Speed**](speed-property)
- [**SRModeID**](srmodeid-property)
- [**SRStatus**](srstatus-property)
- [**Top**](top-property)
- [**TTSModeID**](ttsmodeid-property)
- [**Version**](version-property)
- [**VisibilityCause**](visibilitycause-property)
- [**Visible**](visible-property-cob)
- [**Width**](width-property-co)

Note that the [**Height**](height-property), [**Left**](left-property), [**Top**](top-property), and [**Width**](width-property-co) properties of a character differ from those that may be supported by the programming environment for the placement of the control. The [**Character**](/en-us/windows/desktop/lwef/the-characters-object) properties apply to the visible presentation of a character, not the location of the Microsoft Agent control.

As with [**Character**](/en-us/windows/desktop/lwef/the-characters-object) object methods, you can access a character's properties using the [**Characters**](/en-us/windows/desktop/lwef/the-characters-object) collection, or simplify your syntax by declaring an object variable and setting it to a character in the collection. In the following example, Test1 and Test2 will be set to the same value:

```
   Dim Genie 
   Dim MyRequest
   
   Sub window_Onload

   Agent.Characters.Load "Genie", "https://agent.microsoft.com/characters/v2/genie/genie.acf"

   Set Genie = Agent.Characters("Genie")

   Genie.MoveTo 15,15
   Set MyRequest = Genie.Show()

   End Sub

   Sub Agent_RequestComplete(ByVal Request)

   If Request = MyRequest Then 
      Test1 = Agent.Characters("Genie").Top
      Test2 = Genie.Top
      MsgBox "Test 1 is " + cstr(Test1) + "and Test 2 is " + cstr(Test2)
   End If

   End Sub
```

Because the server loads a character asynchronously, ensure that the character has been loaded before querying its properties, for example, using the [**RequestComplete**](requestcomplete-event) event. Otherwise, the properties may return incorrect values.