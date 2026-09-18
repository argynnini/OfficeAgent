---
layout: Conceptual
title: IAgentCharacter Speak - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcharacter--speak
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
description: IAgentCharacter Speak
ms.assetid: 3c4baf83-9e69-4048-bdaf-4ead8ea8e7cd
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 4995970e-4a3d-a39d-4b99-3673038232f9
document_version_independent_id: 30fd8758-9d60-be68-8d3d-ff4c02392822
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacter--speak.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacter--speak.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 456
asset_id: lwef/iagentcharacter--speak
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcharacter--speak.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 5702a2db-753f-8740-01fd-297f0f8c61c0
---

# IAgentCharacter Speak - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT Speak(
   BSTR bszText,    // text to speak
   BSTR bszURL,     // URL of a file to speak
   long * pdwReqID  // address of a request ID
);
```

Speaks the text or sound file.

- Returns S\_OK to indicate the operation was successful.

- *bszText*
    - The text the character is to speak.
- *bszURL*
    - The URL (or file specification) of a sound file to use for spoken output. This can be a standard sound file (.WAV) or linguistically enhanced sound file (.LWV).
- *pdwReqID*
    - Address of a variable that receives the [**Speak**](/en-us/windows/desktop/lwef/iagentcharacter--speak) request ID.

To use this method with a character configured to speak using a text-to-speech (TTS) engine; simply provide the *bszText* parameter. You can include vertical bar characters (|) in the *bszText* parameter to designate alternative strings, so that each time the server processes the method, it randomly choose a different string. Support of TTS output is defined when the character is compiled using the Microsoft Agent Character Editor.

If you want to use sound file output for the character, specify the location for the file in the *bszURL* parameter. When using the HTTP protocol to download a sound file, use the [**Prepare**](/en-us/windows/desktop/lwef/iagentcharacter--prepare) method to ensure the availability of the file before using this method. You can use the *bszText* parameter to specify the words that appear in the character's word balloon. If you specify a linguistically enhanced sound file (.LWV) for the *bszURL* parameter and do not specify text, the *bszText* parameter uses the text stored in the file.

The [**Speak**](/en-us/windows/desktop/lwef/iagentcharacter--speak) method uses the last animation played to determine which speaking animation to play. For example, if you precede the **Speak** command with an [**IAgentCharacter::Play**](iagentcharacter--play) "**GestureRight**", the server will play **GestureRight** and then the **GestureRight** speaking animation. If the last animation played has no speaking animation, then Microsoft Agent plays the animation assigned to the character's **Speaking** state.

If you call [**Speak**](/en-us/windows/desktop/lwef/iagentcharacter--speak) and the audio channel is busy, the character's audio output will not be heard, but the text will display in the word balloon. The word balloon's [Enabled](enabled-property) property must also be **True** for the text to display.

Microsoft Agent's automatic word breaking in the word balloon, breaks words using white-space characters (for example, space and tab). However, it may break a word to fit the balloon as well. In languages like Japanese, Chinese, and Thai, where spaces are not used to break words, insert a Unicode zero width space character (0x200B) between characters to define logical word breaks.

Note

Set the character's language ID (using [**IAgentCharacterEx::SetLanguageID**](iagentcharacterex--setlanguageid) before using the [**Speak**](/en-us/windows/desktop/lwef/iagentcharacter--speak) method to ensure appropriate text display within the word balloon.