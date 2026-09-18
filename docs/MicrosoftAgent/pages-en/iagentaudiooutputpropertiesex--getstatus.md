---
layout: Conceptual
title: IAgentAudioOutputPropertiesEx GetStatus - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentaudiooutputpropertiesex--getstatus
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
description: IAgentAudioOutputPropertiesEx GetStatus
ms.assetid: 29bf1379-eebe-4b8b-b8d0-b86d2da78b64
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: b80b848b-e8c9-79d5-07b7-e56526618376
document_version_independent_id: 457ced76-3d3b-3102-0be6-239c9cadd624
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentaudiooutputpropertiesex--getstatus.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentaudiooutputpropertiesex--getstatus.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 234
asset_id: lwef/iagentaudiooutputpropertiesex--getstatus
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentaudiooutputpropertiesex--getstatus.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: f3ae7da2-241b-72cf-442f-72c639ddf23c
---

# IAgentAudioOutputPropertiesEx GetStatus - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT GetStatus(
   long * plStatus,  // address of audio channel status
);
```

Retrieves the status of the audio channel.

- Returns S\_OK to indicate the operation was successful.

- *plStatus*
    - Status of the audio output channel, which may be one of the following values:

| Value | Description |
| --- | --- |
| **const unsigned short** **AUDIO\_STATUS\_AVAILABLE = 0;** | The audio output channel is available (not busy). |
| **const unsigned short** **AUDIO\_STATUS\_NOAUDIO = 1;** | There is no support for audio output; for example, because there is no sound card. |
| **const unsigned short** **AUDIO\_STATUS\_CANTOPENAUDIO = 2;** | The audio output channel can't be opened (is busy); for example, because another application is playing audio. |
| **const unsigned short** **AUDIO\_STATUS\_USERSPEAKING = 3;** | The audio output channel is busy because the server is processing user speech input |
| **const unsigned short** **AUDIO\_STATUS\_CHARACTERSPEAKING = 4;** | The audio output channel is busy because a character is currently speaking. |
| **const unsigned short** **AUDIO\_STATUS\_SROVERRIDEABLE = 5;** | The audio output channel is not busy, but it is waiting for user speech input. |
| **const unsigned short** **AUDIO\_STATUS\_ERROR = 6;** | There was some other (unknown) problem in attempting to access the audio output channel. |

This setting enables your client application to query the state of the audio output channel. You can use this to determine whether to have your character speak or to try to turn on Listening mode (using **IAgentCharacterEx::Listen**).