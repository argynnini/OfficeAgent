---
layout: Conceptual
title: IAgentCharacter Prepare - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcharacter--prepare
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
description: IAgentCharacter Prepare
ms.assetid: e016039f-a0b1-4ae9-bff6-7212b02c1ad8
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 7400979b-3aa0-0c88-9d72-e70a37ffa364
document_version_independent_id: 6b858a57-3526-e7a4-b8a7-ee6b33fe6acb
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacter--prepare.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacter--prepare.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 517
asset_id: lwef/iagentcharacter--prepare
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcharacter--prepare.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: eda8c4b0-1455-437d-9e80-eb0bb2e586c7
---

# IAgentCharacter Prepare - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT Prepare(
   long dwType,     // type of animation data to load
   BSTR bszName,    // name of the animation 
   long bQueue,     // queue the request
   long * pdwReqID  // address of request ID
);
```

Retrieves animation data for a character.

- Returns S\_OK to indicate the operation was successful. When the function returns, *pdwReqID* contains the ID of the request.

- *dwType*
    - A value that indicates the animation data type to load that must be one of the following:

| Value | Description |
| --- | --- |
| **const unsigned short** **PREPARE\_ANIMATION = 0;** | A character's animation data. |
| **const unsigned short** **PREPARE\_STATE = 1;** | A character's state data. |
| **const unsigned short** **PREPARE\_WAVE = 2** | A character's sound file (.WAV or .LWV) for spoken output. |
- *bszName*
    - The name of the animation or state.

The animation name is based on that defined for the character when it was saved using the Microsoft Agent Character Editor.

For states, the value can be one of the following:

| - | Description |
| --- | --- |
| **"Gesturing"** | To retrieve all **Gesturing** state animations. |
| **"GesturingDown"** | To retrieve **GesturingDown** animations. |
| **"GesturingLeft"** | To retrieve **GesturingLeft** animations. |
| **"GesturingRight"** | To retrieve **GesturingRight** animations. |
| **"GesturingUp"** | To retrieve **GesturingUp** animations. |
| **"Hiding"** | To retrieve the **Hiding** state animations. |
| **"Hearing"** | To retrieve the **Hearing** state animations. |
| **"Idling"** | To retrieve all **Idling** state animations. |
| **"IdlingLevel1"** | To retrieve all **IdlingLevel1** animations. |
| **"IdlingLevel2"** | To retrieve all **IdlingLevel2** animations. |
| **"IdlingLevel3"** | To retrieve all **IdlingLevel3** animations. |
| **"Listening"** | To retrieve the **Listening** state animations. |
| **"Moving"** | To retrieve all **Moving** state animations. |
| **"MovingDown"** | To retrieve all **Moving** animations. |
| **"MovingLeft"** | To retrieve all **MovingLeft** animations. |
| **"MovingRight"** | To retrieve all **MovingRight** animations. |
| **"MovingUp"** | To retrieve all **MovingUp** animations. |
| **"Showing"** | To retrieve the **Showing** state animations. |
| **"Speaking"** | To retrieve the **Speaking** state animations. |

For .WAV files, set *bszName* to the URL or file specification for the .WAV file. If the specification is not complete, it is interpreted as being relative to the specification used in the [**Load**](https://www.bing.com/search?q=**Load**) method.
- *bQueue*
    - A Boolean specifying whether the server queues the [**Prepare**](/en-us/windows/desktop/lwef/iagentcharacter--prepare) request. **True** queues the request and causes any animation request that follows it to wait until the animation data it specifies is loaded. **False** retrieves the animation data asynchronously.
- *pdwReqID*
    - Address of a variable that receives the [**Prepare**](/en-us/windows/desktop/lwef/iagentcharacter--prepare) request ID.

If you load a character using the HTTP protocol (an .ACF file), you must use the [**Prepare**](/en-us/windows/desktop/lwef/iagentcharacter--prepare) method to retrieve animation data before you can play the animation. You cannot use this method if you loaded the character using the UNC protocol (an .ACS file). You also cannot retrieve HTTP data for a character using **Prepare** if you loaded that character using the UNC protocol (.ACS character file).

Animation or sound data retrieved with the [**Prepare**](/en-us/windows/desktop/lwef/iagentcharacter--prepare) method is stored in the browser's cache. Subsequent calls will check the cache, and if the animation data is already there, the control loads the data directly from the cache. Once loaded, the animation or sound data can be played with the [**Play**](/en-us/windows/desktop/lwef/iagentcharacter--play) or [**Speak**](/en-us/windows/desktop/lwef/iagentcharacter--speak) methods.

You can specify multiple animations and states by separating them with commas. However, you cannot mix types in the same [**Prepare**](/en-us/windows/desktop/lwef/iagentcharacter--prepare) statement.