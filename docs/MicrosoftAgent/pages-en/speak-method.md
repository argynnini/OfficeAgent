---
layout: Conceptual
title: Speak Method - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/speak-method
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
description: Speak Method
ms.assetid: 6267e04c-feb5-4f48-8a88-4e6ca3388bf3
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 7a87f221-bf01-d08a-7637-6734af312302
document_version_independent_id: e9ad4b3c-9777-d928-4785-f33a6cc0a647
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/speak-method.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/speak-method.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 872
asset_id: lwef/speak-method
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/speak-method.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: acfff9e5-3dc9-acbe-6fbe-d23c59da62f1
---

# Speak Method - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Speaks the specified text or sound file for the specified character.
- **Syntax**
    - *agent*\*\*.Characters ("***CharacterID***").Speak\*\* [*Text*], [*Url*]

| Part | Description |
| --- | --- |
| *Text* | Optional. A string that specifies what the character says. |
| *Url* | Optional. A string expression specifying the location of an audio file (.WAV or .LWV format). The location can be specified as a file (including a UNC path specification) or URL (when character animation data is also being retrieved via HTTP protocol). |

## Remarks

Although the *Text* and *Url* parameters are optional, one of them must be supplied. To use this method with a character configured to speak only in its word balloon or using a text-to-speech (TTS) engine, simply provide the *Text* parameter. Include a space between words to define appropriate word breaks in the word balloon, even for languages that do not traditionally include spaces.

You can also include vertical bar characters (|) in the *Text* parameter to designate alternative strings, so that the server randomly chooses a different string each time it processes the method.

Character support of TTS output is defined when the character is compiled using the Microsoft Agent Character Editor. To generate TTS output, a compatible TTS engine must already be installed before calling this method. For further information, see [Accessing Speech Services](accessing-speech-services).

If you use recorded sound-file (.WAV or .LWV format only) output for the character, specify the file's location in the *Url* parameter. This file specification can include a local (absolute or relative) or universal naming convention (UNC) path. The filename cannot include any characters not included in the US code page 1252. However, if you are using the HTTP protocol to access the character animation data, use the [**Get**](get-method) method to load the animation before calling the **Speak** method. See [Using the Microsoft Linguistic Information Sound Editing Tool](using-the-microsoft-linguistic-information-sound-editing-tool) for information about creative .LWV files.

When using recorded sound-file output, you can still use the *Text* parameter to specify the words that appear in the character's word balloon. However, if you specify a linguistically enhanced sound file (.LWV) for the *Url* parameter and do not specify text for the word balloon, the *Text* parameter uses the text stored in the file.

You can also vary parameters of the speech output with special tags that you include in the *Text* parameter. For more information, see [Microsoft Agent Speech Output Tags](microsoft-agent-speech-output-tags).

If you declare an object reference and set it to this method, it returns a [**Request**](/en-us/windows/desktop/lwef/the-request-object) object. You can use this to synchronize other parts of your code with the character's spoken output, as in the following example:

```
   Dim SpeakRequest as Object
...
   Set SpeakRequest = Genie.Speak ("And here it is.")
...
   Sub Agent1_RequestComplete (ByVal Request as Object)
   ' Make certain the request exists
   If SpeakRequest Not Nothing Then
      ' See if it was this request
      If Request = SpeakRequest Then
         ' Display the message box 
         Msgbox "Ta da!"
      End If
   End If
   End Sub
```

You can also use a [**Request**](/en-us/windows/desktop/lwef/the-request-object) object to check for certain error conditions. For example, if you use the **Speak** method to speak and do not have a compatible TTS engine installed, the server sets the **Request** object's [**Status**](status-property) property to "failed" with its [**Description**](description-property) property to "Class not registered" or "Unknown or object returned error". To determine if you have a TTS engine installed, use the [**TTSModeID**](ttsmodeid-property) property.

Similarly, if you have the character attempt to speak a sound file, and if the file has not been loaded or there is a problem with the audio device, the server also sets the [**Request**](/en-us/windows/desktop/lwef/the-request-object) object's [**Status**](status-property) property to "failed" with an appropriate error code number.

You can also include bookmark speech tags in your Speak text to synchronize your code:

```
   Dim SpeakRequest as Object
...
   Set SpeakRequest = Genie.Speak ("And here \mrk=100\it is.")
...
   Sub Agent1_Bookmark (ByVal BookmarkID As Long)
   If BookmarkID = 100 Then
      ' Display the message box 
         Msgbox "Tada!"
      End If
   End Sub
```

For more information on the bookmark speech tag, see [Speech Output Tags](mrk-tag).

The **Speak** method uses the last action played to determine which speaking animation to play. For example, if you preceded the **Speak** command with a [**Play**](play-method) "**GestureRight**", the server will play **GestureRight** and then the **GestureRight** speaking animation. If the last animation played has no speaking animation, Agent plays the animation assigned to the character's **Speaking** state.

If you call **Speak** and the audio channel is busy, the character's audio output will not be heard, but the text will display in the word balloon.

Agent's automatic word breaking in the word balloon breaks words using white-space characters (for example, Space or Tab). However, if it cannot, it may break a word to fit the balloon. In languages like Japanese, Chinese, and Thai, where spaces are not used to break words, insert a Unicode zero-width space character (0x200B) between characters to define logical word breaks.

Note

The word balloon's [**Enabled**](enabled-property) property must also be **True** for text to display.

Note

Set the character's language ID (by setting the character's **LanguageID** before using the **Speak** method to ensure appropriate text display within the word balloon.