---
layout: Conceptual
title: IAgentCharacterEx GetLanguageID - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcharacterex--getlanguageid
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
description: IAgentCharacterEx GetLanguageID
ms.assetid: 4e4e5342-edf9-480b-a9c3-e2626fd89e76
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 80fd41d7-3149-7013-b2ff-7e89826751f2
document_version_independent_id: 56fc6672-248e-cd6b-97ef-3122930e7809
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacterex--getlanguageid.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacterex--getlanguageid.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 333
asset_id: lwef/iagentcharacterex--getlanguageid
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcharacterex--getlanguageid.md
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/c6f99e62-1cf6-4b71-af9b-649b05f80cce
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/3f56b378-07a9-4fa1-afe8-9889fdc77628
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: d95dad66-1005-f177-e4ea-b8faaadb1bf8
---

# IAgentCharacterEx GetLanguageID - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT GetLanguageID(
   long * plangID  // address of language ID setting
);
```

Retrieves the language ID set for the character.

- Returns S\_OK to indicate the operation was successful.

- *plangID*
    - Address of a variable that receives the language ID setting for the character.

A Long integer specifying the language ID for the character. The language ID (LANGID) for a character is a 16-bit value defined by Windows, consisting of a primary language ID and a secondary language ID. The following examples are values for some languages. To determine the values other languages, see the Platform SDK documentation.

| Language | ID | Language | ID |
| --- | --- | --- | --- |
| Arabic (Saudi) | 0x0401 | Italian | 0x0410 |
| Basque | 0x042d | Japanese | 0x0411 |
| Chinese (Simplified) | 0x0804 | Korean | 0x0412 |
| Chinese (Traditional) | 0x0404 | Norwegian | 0x0414 |
| Croatian | 0x041A | Polish | 0x0415 |
| Czech | 0x0405 | Portuguese (Portugal) | 0x0816 |
| Danish | 0x0406 | Portuguese (Brazil) | 0x0416 |
| Dutch | 0x0413 | Romanian | 0x0418 |
| English (British) | 0x0809 | Russian | 0x0419 |
| English (US) | 0x0409 | Slovakian | 0x041B |
| Finnish | 0x040B | Slovenian | 0x0424 |
| French | 0x040C | Spanish | 0x0C0A |
| German | 0x0407 | Swedish | 0x041D |
| Greek | 0x0408 | Thai | 0x041E |
| Hebrew | 0x040D | Turkish | 0x041F |
| Hungarian | 0x040E |  |  |

If you do not set this language ID for the character, the character's language ID will be the current system language ID.

This setting also determines the language for TTS output, word balloon text, the commands in the character's pop-up menu, and speech recognition engine. To determine if there is a compatible speech recognition engine available for the character's language, use [**IAgentCharacterEx::GetSRModeID**](iagentcharacterex--getsrmodeid) or [**IAgentCharacterEx::GetTTSModeID**](iagentcharacterex--getttsmodeid).

This property applies only to your client application's use of the character; the setting does not affect other clients of the character or other characters of your client application.

Note

If the language ID is set to a language that supports bidirectional text (such as Arabic or Hebrew), but the system running your application does not have bidirectional support installed, text will appear in the word balloon in logical rather than display order.