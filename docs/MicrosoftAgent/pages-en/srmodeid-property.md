---
layout: Conceptual
title: SRModeID Property - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/srmodeid-property
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
description: SRModeID Property
ms.assetid: 4c784fc5-d2c2-4e5b-ba5f-f59b4507f40f
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 6bf7fbd0-5b60-999c-ffa0-bd2d9a9d4f4d
document_version_independent_id: 92a7c9f1-dfee-1d4c-5966-0a31c975b174
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/srmodeid-property.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/srmodeid-property.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 440
asset_id: lwef/srmodeid-property
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/srmodeid-property.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 4b0553bc-0e75-9187-085c-50a6a000ebca
---

# SRModeID Property - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Returns or sets the speech recognition engine the character uses.
- **Syntax**
    - *agent*\*\*.Characters("***CharacterID***").SRModeID\*\* [ = *ModeID*]

| Part | Description |
| --- | --- |
| *ModeID* | A string expression that corresponds to the mode ID of a speech engine. |

## Remarks

The property determines the speech recognition engine used by the character for speech input. The mode ID for a speech recognition engine is a formatted string defined by the speech vendor that uniquely identifies the engine. For more information, see [Accessing a Speech Engine In Your Code](accessing-a-speech-engine-in-your-code).

If you specify a mode ID for a speech engine that isn't installed, if the user has disabled speech recognition (in the Microsoft Agent property sheet), or if the language of the specified speech engine doesn't match the character's [**LanguageID**](languageid-property) setting, the server raises an error.

If you query this property and haven't already (successfully) set the speech recognition engine, the server returns the mode ID of the engine that SAPI returns based on the character's [**LanguageID**](languageid-property) setting. If you haven't set the character's **LanguageID**, then Agent returns the mode ID of the engine that SAPI returns based on the user's default language ID setting. If there is no matching engine, the server returns an empty string (""). Querying this property does not require that [**SpeechInput.Enabled**](https://www.bing.com/search?q=**SpeechInput.Enabled**) be set to **True**. However, if you query the property when speech input is disabled, the server returns an empty string.

When speech input is enabled (in the Advanced Character Options window), querying or setting this property will load the associated engine (if it is not already loaded), and start speech services. That is, the Listening key is available, and the Listening Tip is displayable. (The Listening key and Listening Tip are enabled only if they are also enabled in Advanced Character Options.) However, if you query the property when speech is disabled, the server does not start speech services.

This property applies only to your client application's use of the character; the setting does not affect other clients of the character or other characters of your client application.

Microsoft Agent's speech engine requirements are based on the Microsoft Speech API. Engines supporting Microsoft Agent's SAPI requirements can be installed and used with Agent.

Note

This property also returns the empty string if you have no compatible sound support installed on your system.

Note

Querying this property does not typically return an error. However, if the speech engine takes an abnormally long time to load, you may get an error indicating that the query timed out.