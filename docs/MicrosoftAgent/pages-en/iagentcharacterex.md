---
layout: Conceptual
title: IAgentCharacterEx - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcharacterex
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
description: IAgentCharacterEx
ms.assetid: 8defc836-cc54-40c7-8afc-ec90f941861b
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: d6fc13b0-9445-a296-1114-27a106e1a0f5
document_version_independent_id: cd4b007f-636c-976e-7db5-8956b405c884
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacterex.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacterex.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 235
asset_id: lwef/iagentcharacterex
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcharacterex.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: d0291bc1-9616-04cf-94ef-d8d0702a056e
---

# IAgentCharacterEx - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

**IAgentCharacterEx** derives from the [**IAgentCharacter**](iagentcharacter) interface. It includes all the **IAgentCharacter** methods as well as provides access to additional functions.

**Methods in Vtable Order**

| IAgentCharacterEx Methods | Description |
| --- | --- |
| [**ShowPopupMenu**](iagentcharacterex--showpopupmenu) | Displays the pop-up menu for the character. |
| [**SetAutoPopupMenu**](iagentcharacterex--setautopopupmenu) | Sets whether the server automatically displays the character's pop-up menu. |
| [**GetAutoPopupMenu**](iagentcharacterex--getautopopupmenu) | Returns whether the server automatically displays the character's pop-up menu. |
| [**GetHelpFileName**](iagentcharacterex--gethelpfilename) | Returns the Help filename for the character. |
| [**SetHelpFileName**](iagentcharacterex--sethelpfilename) | Sets the Help filename for the character. |
| [**SetHelpModeOn**](iagentcharacterex--sethelpmodeon) | Sets Help mode on. |
| [**GetHelpModeOn**](iagentcharacterex--gethelpmodeon) | Returns whether Help mode is on. |
| [**SetHelpContextID**](iagentcharacterex--sethelpcontextid) | Sets the HelpContextID for the character. |
| [**GetHelpContextID**](iagentcharacterex--gethelpcontextid) | Returns the HelpContextID for the character. |
| [**GetActive**](iagentcharacterex--getactive) | Returns the active state for the character. |
| [**Listen**](iagentcharacterex--listen) | Sets the listening state for the character. |
| [**SetLanguageID**](iagentcharacterex--setlanguageid) | Sets the language ID for the character. |
| [**getLanguageID**](iagentcharacterex--getlanguageid) | Returns the language ID for the character. |
| [**getTTSModeID**](iagentcharacterex--getttsmodeid) | Returns the TTS mode ID set for the character. |
| [**SetTTSModeID**](iagentcharacterex--setttsmodeid) | Sets the TTS mode ID for the character. |
| [**getSRModeID**](iagentcharacterex--getsrmodeid) | Returns the current speech recognition engine's mode ID. |
| [**setSRModeID**](iagentcharacterex--setsrmodeid) | Sets the speech recognition engine. |
| [**GetGUID**](iagentcharacterex--getguid) | Returns the character's identifier. |
| [**GetOriginalSize**](iagentcharacterex--getoriginalsize) | Returns the original size of the character frame. |
| [**Think**](iagentcharacterex--think) | Displays the specified text in the character's "thought" balloon. |
| [**GetVersion**](iagentcharacterex--getversion) | Returns the version of the character. |
| [**GetAnimationNames**](iagentcharacterex--getanimationnames) | Returns the names of the animations for the character. |
| [**getSRStatus**](iagentcharacterex--getsrstatus) | Returns the conditions necessary to support speech input. |