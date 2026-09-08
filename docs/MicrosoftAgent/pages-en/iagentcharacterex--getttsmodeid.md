---
layout: Conceptual
title: IAgentCharacterEx GetTTSModeID - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcharacterex--getttsmodeid
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
description: IAgentCharacterEx GetTTSModeID
ms.assetid: e7b3c576-dc3c-40de-8d09-8e7f4b79250b
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 3ab7cea4-1ada-c52c-396d-e56763d45a42
document_version_independent_id: 6f878eee-4d18-51d7-73aa-566349d62fc8
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacterex--getttsmodeid.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacterex--getttsmodeid.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 281
asset_id: lwef/iagentcharacterex--getttsmodeid
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcharacterex--getttsmodeid.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/c6f99e62-1cf6-4b71-af9b-649b05f80cce
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/3f56b378-07a9-4fa1-afe8-9889fdc77628
platformId: 7994feb3-7161-1fee-f405-8b2e458c2af9
---

# IAgentCharacterEx GetTTSModeID - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT GetTTSModeID(
   BSTR * pbszModeID  // address of TTS engine ID
);
```

Retrieves the mode ID of the TTS engine set for the character.

- Returns S\_OK to indicate the operation was successful.

- *pbszModeID*
    - Address of a BSTR that receives the mode ID setting of the TTS engine for the character.

This setting returns the TTS (text-to-speech) engine mode ID for a character's spoken output. The mode ID for a TTS engine is a string representation of the GUID (formatted with braces and dashes) defined by the speech vendor uniquely identifying the engine. For more information, see the [Microsoft Speech SDK documentation](https://msdn.microsoft.com/library/ee705648.aspx). Querying this property will load the associated engine if it is not already loaded.

If you do not set a TTS engine mode ID for the character, the server attempts to return an engine that matches (using Microsoft Speech API interfaces) the character's compiled TTS setting and the character's current language setting. If these are different, then the character's language setting overrides its authored mode setting. If you have not set the character's language setting, the character's language is the user default language ID, and the server attempts the match based on that language ID.

This function does not fail if the [**IAgentAudioObjectProperties::GetEnabled**](https://www.bing.com/search?q=**IAgentAudioObjectProperties::GetEnabled**) returns **False**.

This property applies only to your client application's use of the character; the setting does not affect other clients of the character or other characters of your client application.

Microsoft Agent's speech engine requirements are based on the Microsoft Speech API. Engines supporting Microsoft Agent's SAPI requirements can be installed and used with Agent.