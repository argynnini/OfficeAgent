---
layout: Conceptual
title: Microsoft Agent Speech Output Tags - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/microsoft-agent-speech-output-tags
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
description: Microsoft Agent Speech Output Tags
ms.assetid: b7939974-bc54-4dd8-8e79-3ebd24e76215
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 110c78e8-3977-f5cd-d792-c90cd9db8499
document_version_independent_id: 625e8ba1-4b05-2913-a492-a46465b45935
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/microsoft-agent-speech-output-tags.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/microsoft-agent-speech-output-tags.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 380
asset_id: lwef/microsoft-agent-speech-output-tags
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/microsoft-agent-speech-output-tags.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: e5c60d2f-cc87-db7f-4e14-c145962dd1bb
---

# Microsoft Agent Speech Output Tags - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

The Microsoft Agent services support modifying speech output through special tags inserted in the speech text string. These tags help you change the characteristics of the output expression of the character.

Speech output tags use the following rules of syntax:

- All tags begin and end with a backslash character (\).
- The single backslash character is not enabled within a tag. To include a backslash character in a text parameter of a tag, use a double backslash (\\).
- Tags are case-insensitive. For example, \pit\ is the same as \PIT\.
- Tags are whitespace-dependent. For example, \Rst\ is not the same as \ Rst \.

Unless otherwise specified or modified by another tag, the speech output retains the characteristic set by the tag within the text specified in a single [**Speak**](speak-method) method. Speech output is automatically reset through the user-defined parameters after a **Speak** method is completed.

Some tags include quoted strings. For some programming languages, such as Visual Basic Scripting Edition (VBScript) and Visual Basic, this means that you may have to use two quote marks to designate the tag's parameter or concatenate a double-quote character as part of the string. The latter is shown in this Visual Basic example:

```
Agent1.Characters("Genie").Speak "This is \map=" + chr(34) + "Spoken text" _
+ chr(34) + "=" + chr(34) + "Balloon text" + chr(34) + "\."
```

For C, C++, and Java™ programming, precede backslashes and double quotes with a backslash. For example:

```
BSTR bszSpeak = SysAllocString(L"This is \\map=\"Spoken text\"=\"Balloon text\"\\");

pCharacter->Speak(bszSpeak, ......);
```

For foreign languages that support double-byte character set (DBCS) characters, you can use double-byte characters to specify string parameters. However, use single-byte characters for all other parameters and characters that are used to define the tag, including the tag itself.

The following tags are supported:

- [**Chr**](chr-tag)
- [**Ctx**](ctx-tag)
- [**Emp**](emp-tag)
- [**Lst**](lst-tag)
- [**Map**](map-tag)
- [**Mrk**](mrk-tag)
- [**Pau**](pau-tag)
- [**Pit**](pit-tag)
- [**Rst**](rst-tag)
- [**Spd**](spd-tag)
- [**Vol**](vol-tag)

The tags are primarily designed for adjusting text-to-speech (TTS)-generated output. Only the [**Mrk**](mrk-tag) and [**Map**](map-tag) tags can be used with sound file-based spoken output.

Note

Microsoft Agent does not support all the tags documented in the Microsoft Speech SDK. Parameters may also vary depending on the TTS engine selected. You can set a specific TTS engine using [**TTSModeID**](ttsmodeid-property).