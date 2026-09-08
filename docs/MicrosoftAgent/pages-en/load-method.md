---
layout: Conceptual
title: Load Method - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/load-method
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
description: Load Method
ms.assetid: 72a37471-f69b-49a5-a6eb-d65bff970c0f
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 92ed1656-a7dc-1bc5-031f-89535896ce63
document_version_independent_id: fa6eb514-b855-bda7-eedf-fe572af1525f
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/load-method.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/load-method.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 626
asset_id: lwef/load-method
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/load-method.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: f318b588-f1a6-4820-3639-e2930ac70751
---

# Load Method - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Loads a character into the [**Characters**](/en-us/windows/desktop/lwef/the-characters-object) collection.
- **Syntax**
    - *agent*\*\*.Characters.Load "***CharacterID***",\*\* *Provider*

| Part | Description |
| --- | --- |
| *CharacterID* | Required. A string value that you will use to refer to the character data to be loaded. |
| *Provider* | Required. A variant data type that must be one of the following: **Filespec** The local file location of the specified character's definition file. **URL** The HTTP address for the character's definition file. |

## Remarks

You can load characters from the Agent subdirectory by specifying a relative path (one that does not include a colon or leading slash character). This prefixes the path with Agent's characters directory (located in the localized Windows\msagent directory). For example, specifying the following would load Genie.acs from Agent's Chars directory:

```
   Agent.Character.Load "genie", "genie.acs"
```

You can also specify your own directory in Agent's Chars directory.

```
   Agent.Character.Load "genie", "MyCharacters\genie.acs"
```

You can load the character currently set as the current user's default character by not including a path as the second parameter of the **Load** method.

```
   Agent.Character.Load "character"
```

You cannot load the same character (a character having the same GUID) more than once from a single instance of the control. Similarly, you cannot load the default character and other characters at the same time from a single instance of the control because the default character could be the same as the other character. If you attempt to do this, the server raises an error. However, you can create another instance of the Agent control and load the same character.

The Microsoft Agent Data Provider supports loading character data stored either as a single structured file (.ACS) with character data and animation data together or as separate character data (.ACF) and animation (.ACA) files. Use the single structured .ACS file to load a character that is stored on a local disk or network and accessed using a conventional file protocol (such as UNC pathnames). Use the separate .ACF and .ACA files when you want to load the animation files individually from a remote site where they are accessed using the HTTP protocol.

For .ACS files, using the **Load** method provides access to a character's animations. For .ACF files, you also use the [**Get**](get-method) method to load animation data. The **Load** method does not support downloading .ACS files from an HTTP site.

Loading a character does not automatically display the character. Use the [**Show**](show-method) method first to make the character visible.

If you use the **Load** method to load a character file stored on the local machine and the call fails; for example, because the file is not found, Agent raises an error. You can use the support in your programming language to provide an error handling routine to catch and process the error.

```
   Sub Form_Load
      On Error GoTo ErrorHandler
      Agent1.Characters.Load "mychar", "genie.acs"
      ' Successful load
      . . .
      Exit Sub
      ErrorHandler:
      ' Unsuccessful load
      . . .
      Resume Next
   End Sub
```

You can also handle the error by setting [**RaiseRequestErrors**](https://www.bing.com/search?q=**RaiseRequestErrors**) to **False**, declaring a object, and assigning the **Load** request to it. Then follow the **Load** call with a statement that checks the status of the [**Request**](/en-us/windows/desktop/lwef/the-request-object) object.

```
Dim LoadRequest as Object

   Sub Form_Load
      Agent1.RaiseRequestErrors = False
      Set LoadRequest = Agent1.Characters.Load _
         ("mychar", "c:\some directory\some character.acs")
      If LoadRequest.Status Not 0 Then
         ' Unsuccessful load
         . . .
         Exit Sub
      Else 
         ' Successful load
         . . .
   End Sub
```

If you load a character that is not local; for example, using HTTP protocol, you can also check for a **Load** failure by assigning a [**Request**](/en-us/windows/desktop/lwef/the-request-object) object to the **Load** method. However, because this method of loading a character is handled asynchronously, check its status in the [**RequestComplete**](requestcomplete-event) event. This technique will not work loading a character using the UNC protocol because the **Load** method is processed synchronously.