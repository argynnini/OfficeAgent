---
layout: Conceptual
title: The Command Object - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/the-command-object
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
description: The Command Object
ms.assetid: a757846a-c2d0-4239-9533-babf5dc8399f
ms.topic: concept-article
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 0f982f29-524e-cc86-df63-e5aab32d322c
document_version_independent_id: 5bdc0251-97d7-6f41-e185-dc45a7133af7
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/the-command-object.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/the-command-object.md
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 727
asset_id: lwef/the-command-object
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/the-command-object.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: ec125304-e14a-4656-2462-1ab484274e5d
---

# The Command Object - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

A [**Command**](/en-us/windows/desktop/lwef/the-command-object) object is an item in a [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection. The server provides the user access to your **Command** objects when your client application becomes input-active.

- [Command Object Properties](command-object-properties)

To access the property of a [**Command**](/en-us/windows/desktop/lwef/the-command-object) object, you reference it in its collection using its [**Name**](name-property) property. In VBScript and Visual Basic you can use the **Name** property directly:

```
   <i>agent</i>.Characters("<i>CharacterID</i>").Commands("<i>Name</i>").<i>property</i> [= <i>value</i>]
```

For programming languages that don't support collections, use the [**Command**](command-method) method:

```
   <i>agent</i>.Characters("<i>CharacterID</i>").Commands.Command("<i>Name</i>").<i>property</i> [= <i>value</i>]
```

You can also reference a Command object by creating a reference to it. In Visual Basic, declare an object variable and use the Set statement to create the reference:

```
   Dim Cmd1 as Object
   ...
   Set Cmd1 = Agent.Characters("MyCharacterID").Commands("SampleCommand")
   ...
   Cmd1.Enabled = True
```

In Visual Basic 5.0, you can also declare the object as type [**IAgentCtlCommandEx**](https://www.bing.com/search?q=**IAgentCtlCommandEx**) and create the reference. This convention enables early binding, which results in better performance:

```
   Dim Cmd1 as IAgentCtlCommandEx
   ...
   Set Cmd1 = Agent.Characters("MyCharacterID").Commands("SampleCommand")
   ...
   Cmd1.Enabled = True
```

In VBScript, you can declare a reference as a particular type, but you can still declare the variable and set it to the [**Command**](/en-us/windows/desktop/lwef/the-command-object) in the collection:

```
   Dim Cmd1
   ...
   Set Cmd1 = Agent.Characters("MyCharacterID").Commands("SampleCommand")
   ...
   Cmd1.Enabled = True
```

A command may appear in either the character's pop-up menu and the Commands Window, or in both. To appear in the pop-up menu it must have a caption and have the [**Visible**](visible-property) property set to **True**. In addition, its Commands collection object **Visible** property must also be set to **True**. To appear in the Commands Window, a [**Command**](/en-us/windows/desktop/lwef/the-command-object) must have its [**Caption**](caption-property) and [**Voice**](voice-property) properties set. Note that a character's pop-up menu entries do not change while the menu displays. If you add or remove commands or change their properties while the character's pop-up menu is displayed, the menu displays those changes whenever the user next displays it. However, the Commands Window dynamically reflects any changes you make.

The following table summarizes how the properties of a [**Command**](/en-us/windows/desktop/lwef/the-command-object) affect its presentation:

Caption Property

Voice-Caption Property

Voice Property

Visible Property

Enabled Property

Appears in Character's Pop-up Menu

Appears in Commands Window

Yes

Yes

Yes

True

True

Normal, using [**Caption**](caption-property)

Yes, using [**VoiceCaption**](voicecaption-property)

Yes

Yes

Yes

True

False

Disabled, using [**Caption**](caption-property)

No

Yes

Yes

Yes

False

True

Does not appear

Yes, using [**VoiceCaption**](voicecaption-property)

Yes

Yes

Yes

False

False

Does not appear

No

Yes

Yes

No

True

True

Normal, using [**Caption**](caption-property)

No

Yes

Yes

No

True

False

Disabled, using [**Caption**](caption-property)

No

Yes

Yes

No

False

True

Does not appear

No

Yes

Yes

No

False

False

Does not appear

No

No

Yes

Yes

True

True

Does not appear

Yes, using [**VoiceCaption**](voicecaption-property)

No

Yes

Yes

True

False

Does not appear

No

No

Yes

Yes

False

True

Does not appear

Yes, using [**VoiceCaption**](voicecaption-property)

No

Yes

Yes

False

False

Does not appear

No

No

Yes

No

True

True

Does not appear

No

No

Yes

No

True

False

Does not appear

No

No

Yes

No

False

True

Does not appear

No

No

Yes

No

False

False

Does not appear

No

Yes

No

Yes

True

True

Normal, using [**Caption**](caption-property)

Yes, using [**Caption**](caption-property)

Yes

No

Yes

True

False

Disabled, using [**Caption**](caption-property)

No

Yes

No

Yes

False

True

Does not appear

Yes, using [**Caption**](caption-property)

Yes

No

Yes

False

False

Does not appear

No

Yes

No

No

True

True

Normal, using [**Caption**](caption-property)

No

Yes

No

No

True

False

Disabled, using [**Caption**](caption-property)

No

Yes

No

No

False

True

Does not appear

No

Yes

No

No

False

False

Does not appear

No

No

No

Yes

True

True

Does not appear

No

No

No

Yes

True

False

Does not appear

No

No

No

Yes

False

True

Does not appear

No

No

No

Yes

False

False

Does not appear

No

No

No

No

True

True

Does not appear

No

No

No

No

True

False

Does not appear

No

No

No

No

False

True

Does not appear

No

No

No

No

False

False

Does not appear

No

If the property setting is null. In some programming languages, an empty string may not be interpreted the same as a null string. The command is still voice-accessible.

When the server receives input for one of your commands, it sends a [**Command**](/en-us/windows/desktop/lwef/the-command-object) event, and passes back the name of the **Command** as an attribute of the [**UserInput**](/en-us/windows/desktop/lwef/iagentuserinput) object. You can then use conditional statements to match and process the **Command**.