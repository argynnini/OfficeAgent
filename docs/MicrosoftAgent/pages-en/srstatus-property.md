---
layout: Conceptual
title: SRStatus Property - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/srstatus-property
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
description: SRStatus Property
ms.assetid: 67618a35-05e4-4bb3-b910-c75de6e32578
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 76c6afbe-62d1-b233-e003-9e8e21ab939a
document_version_independent_id: ca7c8c7f-bba1-a1eb-9f65-ff78a718d1d1
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/srstatus-property.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/srstatus-property.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 325
asset_id: lwef/srstatus-property
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/srstatus-property.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: d76102f5-b4bc-92e7-a51f-c974f5fcf0e5
---

# SRStatus Property - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Returns whether speech input can be started for the character.
- **Syntax**
    - \*agent.\***Characters("*CharacterID*").SRStatus**

| Value | Description |
| --- | --- |
| 0 | Conditions support speech input. |
| 1 | There is no audio input device available on this system. (Note that this does not detect whether a microphone is installed; it can only detect whether the user has a properly installed input-enabled sound card with a working driver.) |
| 2 | Another client is the active client of this character, or the current character is not topmost. |
| 3 | The audio input or output channel is currently busy, an application is using audio. |
| 4 | An unspecified error occurred in the process of initializing the speech recognition subsystem. This includes the possibility that there is no speech engine available matching the character's language setting. |
| 5 | The user has disabled speech input in the Advanced Character Options. |
| 6 | An error occurred in checking the audio status, but the cause of the error was not returned by the system. |

## Remarks

This property returns the conditions necessary to support speech input, including the status of the audio device. You can check this property before you call the [**Listen**](listen-method) method to better ensure its success.

When speech input is enabled in the Agent property sheet (Advanced Character Options), querying this property will load the associated engine, if it is not already loaded, and start speech services. That is, the Listening key is available, and the Listening Tip is automatically displayable. (The Listening key and Listening Tip are only enabled if they are also enabled in Advanced Character Options.) However, if you query the property when speech is disabled, the server does not start speech services.

This property only applies to your client application's use of the character; the setting does not affect other clients of the character or other characters of your client application.