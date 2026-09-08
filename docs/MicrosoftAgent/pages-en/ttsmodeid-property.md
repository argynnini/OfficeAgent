---
layout: Conceptual
title: TTSModeID Property - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/ttsmodeid-property
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
description: TTSModeID Property
ms.assetid: 9205c37e-e006-466a-9b33-b98408c01ed7
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 5e07e893-9882-b407-61dd-d24ca8997b4c
document_version_independent_id: ccdf1115-c722-6361-47f2-2a507f1f0747
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/ttsmodeid-property.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/ttsmodeid-property.md
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 501
asset_id: lwef/ttsmodeid-property
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/ttsmodeid-property.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 395ca1a5-7e94-424d-e204-ffb7056ac039
---

# TTSModeID Property - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Returns or sets the TTS engine mode used for the character.
- **Syntax**
    - *agent*\*\*.Characters ("***CharacterID***").TTSModeID\*\* [ = *ModeID*]

| Part | Description |
| --- | --- |
| *ModeID* | A string expression that corresponds to the mode ID of a speech engine. |

## Remarks

This property determines the TTS (text-to-speech) engine mode ID for a character's spoken output. The mode ID for a TTS engine is a formatted string defined by the speech vendor that uniquely identifies the engine's mode. For more information, see [Accessing a Speech Engine in Your Code](accessing-a-speech-engine-in-your-code).

Setting this property overrides the server's attempt to load an engine based on the character's compiled TTS setting and the character's current [**LanguageID**](languageid-property) setting. However, if you specify a mode ID for an engine that isn't installed or if the user has disabled speech output in the Microsoft Agent property sheet (**AudioOutput.Enabled = False**), the server raises an error.

If you do not (or have not successfully) set a TTS mode ID for the character, the server checks to see if the character's compiled TTS mode setting matches the character's [**LanguageID**](languageid-property) setting, and that the associated TTS engine is installed. If so, the TTS mode used by the character for spoken output and this property returns that mode ID. If not, the server requests a compatible SAPI speech engine that matches the **LanguageID** of the character, as well as the gender and age set for the character's compiled mode ID. If you have not set the character's **LanguageID**, its **LanguageID** is the current user language. If no matching engine can be found, querying for this property returns an empty string for the engine's mode ID. Similarly, if you query this property when the user has disabled speech output in the Microsoft Agent property sheet (**AudioOutput.Enabled = False**), the value will be an empty string.

Querying or setting this property will load the associated engine (if it is not already loaded). However, if the engine specified in the character's compiled TTS setting is installed and matches the character's language ID setting, the engine will be loaded when the character loads.

This property applies only to your client application's use of the character; the setting does not affect other clients of the character or other characters of your client application.

Microsoft Agent's speech engine requirements are based on the Microsoft Speech API. Engines supporting Microsoft Agent's SAPI requirements can be installed and used with Agent.

Note

This property also returns the empty string if you have no compatible sound support installed on your system.

Note

Setting the **TTSModeID** can fail if Speech.dll is not installed and the engine you specify does not match the character's compiled TTS mode setting.

Note

Querying this property does not typically return an error. However, if the speech engine takes an abnormally long time to load, you may get an error indicating that the query timed out.