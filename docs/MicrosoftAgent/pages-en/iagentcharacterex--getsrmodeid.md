---
layout: Conceptual
title: IAgentCharacterEx GetSRModeID - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcharacterex--getsrmodeid
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
description: IAgentCharacterEx GetSRModeID
ms.assetid: 28049680-8245-49f3-9ecd-13c7605f10ed
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 40e2aa2a-f076-d167-2992-6356a9295a4a
document_version_independent_id: 4be352f4-3ba7-ea7b-1a2d-a05a253cbbc1
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacterex--getsrmodeid.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacterex--getsrmodeid.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 324
asset_id: lwef/iagentcharacterex--getsrmodeid
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcharacterex--getsrmodeid.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 41a6fc1b-dc32-581a-194b-d8b0bdfeceef
---

# IAgentCharacterEx GetSRModeID - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT GetSRModeID(
   BSTR * pbszModeID  // address of speech recognition engine ID
);
```

Retrieves the mode ID of the speech recognition engine set for the character.

- Returns S\_OK to indicate the operation was successful.

- *pbszModeID*
    - Address of a BSTR that receives the mode ID setting of the speech recognition engine for the character.

This setting returns the engine set for a character's speech input. The mode ID for a speech recognition engine is a string representation of the GUID (formatted with braces and dashes) by the speech vendor uniquely identifying the engine. For more information, see the [Microsoft Speech SDK documentation](https://msdn.microsoft.com/library/ee705648.aspx).

If you do not set a speech recognition engine mode ID for the character, the server returns an engine that matches the character's language setting (using Microsoft Speech API interfaces). If there is no matching speech recognition engine available for the character, the server returns a null (empty) string.

When speech input is enabled (in the Advanced Character Options window), querying or setting this property will load the associated engine (if it is not already loaded), and start speech services. That is, the Listening key is available, and the Listening Tip is displayable. (The Listening key and Listening Tip are enabled only if they are also enabled in Advanced Character Options.) However, if you query the property when speech is disabled, the server does not start speech services and it returns a null string (empty string).

This function returns only the setting for your client application's use of the character; the setting does not reflect other clients of the character or other characters of your client application.

This function does not fail if the [**IAgentSpeechInputProperties::GetEnabled**](iagentspeechinputproperties--getenabled) returns **False**.

Microsoft Agent's speech engine requirements are based on the Microsoft Speech API. Engines supporting Microsoft Agent's SAPI requirements can be installed and used with Agent.