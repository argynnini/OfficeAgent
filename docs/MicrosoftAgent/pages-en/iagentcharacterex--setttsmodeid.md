---
layout: Conceptual
title: IAgentCharacterEx SetTTSModeID - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcharacterex--setttsmodeid
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
description: IAgentCharacterEx SetTTSModeID
ms.assetid: 66ed792a-1693-45dc-b9a8-eebe772c5af9
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: f4281466-8bbf-b03f-685c-982c5ce31cf9
document_version_independent_id: 74fe0a5c-681b-9f88-f617-9c1ed44788e3
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacterex--setttsmodeid.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacterex--setttsmodeid.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 304
asset_id: lwef/iagentcharacterex--setttsmodeid
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcharacterex--setttsmodeid.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 0f70208d-13c5-636a-bab6-d88166207ee8
---

# IAgentCharacterEx SetTTSModeID - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT SetTTSModeID(
   BSTR bszModeID  // TTS engine ID
);
```

Sets the mode ID of the TTS engine set for the character.

- Returns S\_OK to indicate the operation was successful.

- *bszModeID*
    - The mode ID setting of the TTS engine for the character.

Note

**IAgentCharacterEx:SetTTSModeID** can fail if Speech.dll is not installed and the engine you specify does not match the character's compiled TTS mode setting.

This setting determines the preferred engine mode for a character's spoken TTS output. The mode ID for a TTS (text-to-speech) engine is the GUID defined by the speech vendor that uniquely identifies the mode of the engine (formatted with braces and dashes). For more information, see the [Microsoft Speech SDK documentation](https://msdn.microsoft.com/library/ee705648.aspx).

If you set a TTS mode ID, it overrides the server attempt to match a speech engine based on the character's compiled TTS mode ID, the current system language ID, and the character's current language ID. However, if you attempt to set a mode ID when the user has disabled speech output in the Microsoft Agent property sheet or when the associated engine is not installed, this call will fail.

If you do not set a TTS engine mode ID for the character, the server sets an engine that matches the character's language setting (using Microsoft Speech API interfaces). Setting this property will load the associated engine if it is not already loaded.

This property applies to only your client application's use of the character; the setting does not affect other clients of the character or other characters of your client application.

Microsoft Agent's speech engine requirements are based on the Microsoft Speech API. Engines supporting Microsoft Agent's SAPI requirements can be installed and used with Agent.