---
layout: Conceptual
title: IdleOn Property - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/idleon-property
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
description: IdleOn Property
ms.assetid: ba436dec-c7b4-42e8-99d6-c6ff93afd73c
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 686b8314-6f9d-eba7-746c-6c755a6f71a2
document_version_independent_id: a513a0a0-eb65-6baa-0206-3b510c402a87
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/idleon-property.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/idleon-property.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 184
asset_id: lwef/idleon-property
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/idleon-property.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: facdaa10-c96e-fea7-44ff-1d80ba72ca58
---

# IdleOn Property - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Returns or sets a Boolean value that determines whether the server manages the specified character's **Idling** state animations.
- **Syntax**
    - *agent*\*\*.Characters ("***CharacterID***").IdleOn\*\* [ = *boolean*]

| Part | Description |
| --- | --- |
| *boolean* | A Boolean expression specifying whether the server manages idle mode. **True** (Default) Server handling of the idle state is enabled. **False** Server handling of the idle state is disabled. |

## Remarks

The server automatically sets a time-out after the last animation played for a character. When this timer's interval is complete, the server begins the **Idling** state for a character, playing its associated **Idling** animations at regular intervals. If you want to disable the server from automatically playing the **Idling** state animations, set the property to **False** and play an animation or call the [**Stop**](stop-method) method. Setting this value does not affect the current animation state of the character.

This property applies only to your client application's use of the character; the setting does not affect other clients of the character or other characters of your client application.