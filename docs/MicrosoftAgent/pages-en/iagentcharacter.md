---
layout: Conceptual
title: IAgentCharacter - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcharacter
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
description: IAgentCharacter
ms.assetid: 77d0ffc2-76a2-4a21-88e1-1ca85b8c5d2f
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: f89b0ad7-353b-99bb-060c-2ad7a10d7911
document_version_independent_id: adb4a26a-7cb6-cb70-099d-6966573bb672
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacter.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacter.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 332
asset_id: lwef/iagentcharacter
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcharacter.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 9564c028-e355-0836-58f4-1a0544227db7
---

# IAgentCharacter - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

**IAgentCharacter** defines an interface that allows applications to query character properties and play animations. These functions are also available from [**IAgentCharacterEx**](iagentcharacterex). You can use some method return request IDs to track their status in the character's queue and to synchronize your code with the character's current animation state.

**Methods in Vtable Order**

| IAgentCharacter Methods | Description |
| --- | --- |
| [**GetVisible**](iagentcharacter--getvisible) | Returns whether the character (frame) is currently visible. |
| [**SetPosition**](iagentcharacter--setposition) | Sets the position of the character frame. |
| [**GetPosition**](iagentcharacter--getposition) | Returns the position of the character frame. |
| [**SetSize**](iagentcharacter--setsize) | Sets the size of the character frame. |
| [**GetSize**](iagentcharacter--getsize) | Returns the size of the character frame. |
| [**GetName**](iagentcharacter--getname) | Returns the name of the character. |
| [**GetDescription**](iagentcharacter--getdescription) | Returns the description for the character. |
| [**GetTTSSpeed**](iagentcharacter--getttsspeed) | Returns the current TTS output speed setting for the character. |
| [**GetTTSPitch**](iagentcharacter--getttspitch) | Returns the current TTS pitch setting for the character. |
| [**Activate**](iagentcharacter--activate) | Sets whether a client is active or a character is topmost. |
| [**SetIdleOn**](iagentcharacter--setidleon) | Sets the server's idle processing. |
| [**GetIdleOn**](iagentcharacter--getidleon) | Returns the setting of the server's idle processing. |
| [**Prepare**](iagentcharacter--prepare) | Retrieves animation data for the character. |
| [**Play**](iagentcharacter--play) | Plays a specified animation. |
| [**Stop**](iagentcharacter--stop) | Stops an animation for a character. |
| [**StopAll**](iagentcharacter--stopall) | Stops all animations for a character. |
| [**Wait**](iagentcharacter--wait) | Holds the character's animation queue. |
| [**Interrupt**](iagentcharacter--interrupt) | Interrupts a character's animation. |
| [**Show**](iagentcharacter--show) | Displays the character and plays the character's **Showing** state animation. |
| [**Hide**](iagentcharacter--hide) | Plays the character's **Hiding** state animation and hides the character's frame. |
| [**Speak**](iagentcharacter--speak) | Plays spoken output for the character. |
| [**MoveTo**](iagentcharacter--moveto) | Moves the character frame to the specified location. |
| [**GestureAt**](iagentcharacter--gestureat) | Plays a gesturing animation based on the specified location. |
| [**GetMoveCause**](iagentcharacter--getmovecause) | Retrieves the cause of the character's last move. |
| [**GetVisibilityCause**](iagentcharacter--getvisibilitycause) | Retrieves the cause of the last change to the character's visibility state. |
| [**HasOtherClients**](iagentcharacter--hasotherclients) | Retrieves whether the character has other current clients. |
| [**SetSoundEffectsOn**](iagentcharacter--setsoundeffectson) | Determines whether a character animation's sound effects play. |
| [**GetSoundEffectsOn**](iagentcharacter--getsoundeffectson) | Retrieves whether a character's sound effects setting is enabled. |
| [**SetName**](iagentcharacter--setname) | Sets the character's name. |
| [**SetDescription**](iagentcharacter--setdescription) | Sets the character's description. |
| [**GetExtraData**](iagentcharacter--getextradata) | Retrieves additional data stored with the character. |