---
layout: Conceptual
title: Get Method - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/get-method
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
description: Get Method
ms.assetid: 749566ba-d29d-4c20-b90a-adb4a4dd333d
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 567df11d-44ac-e95a-49f9-232daed8a8d9
document_version_independent_id: 6106f217-20d7-7cd4-ac78-9d061275a915
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/get-method.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/get-method.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 568
asset_id: lwef/get-method
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/get-method.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 50195d1d-4166-0fe1-cd1f-7f4ebff58222
---

# Get Method - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Retrieves specified animation data for the specified character.
- **Syntax**
    - *agent*\*\*.Characters ("***CharacterID***").Get\*\* *Type*, *Name*, [*Queue*]

| Part | Description |
| --- | --- |
| *Type* | Required. A string value that indicates the animation data type to load. "**Animation**" A character's animation data.  "**State**" A character's state data.  "**WaveFile**" A character's audio (for spoken output) file. |
| *Name* | Required. A string that indicates the name of the animation type. "**name**" The name of the animation or state.  For animations, the name is based on that defined for the character when saved using the Microsoft Agent Character Editor.  For states, the following values can be used: "**Gesturing**" To get all **Gesturing** state animations. "**GesturingDown**" To get the **GesturingDown** animation. "**GesturingLeft**" To get the **GesturingLeft** animation. "**GesturingRight**" To get the **GesturingRight** animation. "**GesturingUp**" To get the **GesturingUp** animation. "**Hiding**" To get the **Hiding** state animation. "**Hearing**" To get the **Hearing** state animation. "**Idling**" To get all **Idling** state animations. "**IdlingLevel1**" To get all **IdlingLevel1** animations. "**IdlingLevel2**" To get all **IdlingLevel2** animations. "**IdlingLevel3**" To get all **IdlingLevel3** animations. "**Listening**" To get the **Listening** state animation. "**Moving**" To get all **Moving** state animations. "**MovingDown**" To get the **MovingDown** animation. "**MovingLeft**" To get the **MovingLeft** animation. "**MovingRight**" To get the **MovingRight** animation. "**MovingUp**" To get the **MovingUp** animation. "**Showing**" To get the **Showing** state animation. "**Speaking**" To get the **Speaking** state animation. You can specify multiple animations and states by separating them with commas. However, you cannot mix types in the same **Get** statement. "*URL or* *filespec*" The specification for the sound (.WAV or .LWV) file. If the specification is not complete, it is interpreted as being relative to the specification used in the [**Load**](load-method) method. |
| *Queue* | Optional. A Boolean expression specifying whether the server queues the **Get** request. **True** (Default) Queues the **Get** request. Any animation request that follows the **Get** request (for the same character) waits until the animation data is loaded.**False** Does not queue the **Get** request. |

## Remarks

If you load a character using the HTTP protocol (an .ACF file), you must use the **Get** method to retrieve animation data before you can play the animation. You do not use this method if you loaded the character using the UNC protocol (an .ACS file). You also cannot retrieve HTTP data for a character using **Get** if you loaded that character using the UNC protocol (.ACS character file).

If you declare an object reference and set it to this method, it returns a [**Request**](/en-us/windows/desktop/lwef/the-request-object) object. If the associated animation fails to load, the server sets the **Request** object's [**Status**](status-property) property to "failed" with an appropriate error number. You can use the [**RequestComplete**](requestcomplete-event) event to check the status and determine what action to take.

Animation or sound data retrieved with the **Get** method is stored in the browser's cache. Subsequent calls will check the cache, and if the animation data is already there, the control loads the data directly from the cache. Once loaded, the animation or sound data can be played with the [**Play**](play-method) or [**Speak**](speak-method) methods.