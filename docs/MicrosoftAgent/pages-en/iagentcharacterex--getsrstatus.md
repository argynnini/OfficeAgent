---
layout: Conceptual
title: IAgentCharacterEx GetSRStatus - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcharacterex--getsrstatus
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
description: IAgentCharacterEx GetSRStatus
ms.assetid: ccb34108-8078-421a-a883-731b51fae179
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 539325d9-5aa1-e66a-8b09-44472711f150
document_version_independent_id: 63cd8be3-c05d-c965-8e68-0d33eb0aaf0d
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacterex--getsrstatus.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacterex--getsrstatus.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 415
asset_id: lwef/iagentcharacterex--getsrstatus
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcharacterex--getsrstatus.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: f52a04a3-d0ac-bcce-4470-c80e27f5d3c7
---

# IAgentCharacterEx GetSRStatus - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT GetSRStatus(
   long * plStatus  // address of the speech input status
);
```

Retrieves the status of the condition necessary to support speech input.

- Returns S\_OK to indicate the operation was successful.

- *plStatus*
    - Address of a variable that receives one of the following values for the state setting:

| Value | Description |
| --- | --- |
| **const unsigned long** **LISTEN\_STATUS\_CANLISTEN = 0;** | Conditions support speech input. |
| **const unsigned long** **LISTEN\_STATUS\_NOAUDIO = 1;** | There is no audio input device available on this system. (Note that this does not detect whether a microphone is installed; it can only detect whether the user has a properly installed input-enabled sound card with a working driver.) |
| **const unsigned long** **LISTEN\_STATUS\_NOTTOPMOST = 2;** | Another client is the active client of this character, or the current character is not topmost. |
| **const unsigned long** **LISTEN\_STATUS\_CANTOPENAUDIO = 3;** | The audio input or output channel is currently busy, some other application is using audio. |
| **const unsigned long** **LISTEN\_STATUS\_COULDNTINITIALIZESPEECH = 4;** | An unspecified error occurred in the process of initializing the speech recognition subsystem. This includes the possibility that there is no speech engine available matching the character's language setting. |
| **const unsigned long** **LISTEN\_STATUS\_SPEECHDISABLED = 5;** | The user has disabled speech input in the Advanced Character Options window. |
| **const unsigned long** **LISTEN\_STATUS\_ERROR = 6;** | An error occurred in checking the audio status, but the cause of the error was not returned by the system. |

This function enables you to query whether current conditions support speech recognition input, including the status of the audio device. If your application uses the [**IAgentCharacterEx::Listen**](iagentcharacterex--listen) method, you can use this function to better ensure that the call will succeed. Calling this method also loads the speech engine if it is not already loaded. However, it does not turn on Listening mode.

When speech input is enabled in the Agent property sheet (Advanced Character Options), querying the status will load the associated engine (if it is not already loaded), and start speech services. That is, the Listening key is available, and the Listening Tip is displayable. (The Listening key and Listening Tip are enabled only if they are also enabled in Advanced Character Options.) However, if you query the property when speech is disabled, the server does not start speech services.

This function returns only the setting for your client application's use of the character; the setting does not reflect other clients of the character or other characters of your client application.