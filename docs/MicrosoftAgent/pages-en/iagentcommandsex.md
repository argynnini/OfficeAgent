---
layout: Conceptual
title: IAgentCommandsEx - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcommandsex
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
description: IAgentCommandsEx
ms.assetid: 6c354677-4cdb-4a74-9c41-2d0bf6f8dd55
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 0efaf034-421c-3c56-6ca4-2129cc91be53
document_version_independent_id: 2f36e422-6f3f-77d8-e1c2-bbf91cc878c3
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommandsex.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcommandsex.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 181
asset_id: lwef/iagentcommandsex
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcommandsex.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: bb3dd29c-e060-2ef7-a4b3-946cc0d4f356
---

# IAgentCommandsEx - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

[**IAgentCommandsEx**](iagentcommandex) defines an interface that extends the [**IAgentCommands**](iagentcommands) interface.

**Methods in Vtable Order**

| IAgentCommandsEx Methods | Description |
| --- | --- |
| [SetDefaultID](iagentcommandsex--setdefaultid) | Sets the default command for the character's pop-up menu. |
| [GetDefaultID](iagentcommandsex--getdefaultid) | Returns the default command for the character's pop-up menu. |
| [**SetHelpContextID**](iagentcommandex--sethelpcontextid) | Sets the context-sensitive help topic ID for a [**Command**](/en-us/windows/desktop/lwef/the-command-object) object. |
| [**GetHelpContextID**](iagentcommandex--gethelpcontextid) | Returns the context-sensitive help topic ID for a [**Command**](/en-us/windows/desktop/lwef/the-command-object) object. |
| [SetFontName](iagentcommandsex--setfontname) | Sets the font to use in the character's pop-up menu. |
| [GetFontName](iagentcommandsex--getfontname) | Returns the font used in the character's pop-up menu. |
| [SetFontSize](iagentcommandsex--setfontsize) | Sets the font size to use in the character's pop-up menu. |
| [GetFontSize](iagentcommandsex--getfontsize) | Returns the font size used in the character's pop-up menu. |
| [**SetVoiceCaption**](iagentcommandex--setvoicecaption) | Sets the voice caption for the character's [**Command**](/en-us/windows/desktop/lwef/the-command-object) object. |
| [**GetVoiceCaption**](iagentcommandex--getvoicecaption) | Returns the voice caption for the character's [**Command**](/en-us/windows/desktop/lwef/the-command-object) object. |
| [AddEx](iagentcommandsex--addex) | Adds a [**Command**](/en-us/windows/desktop/lwef/the-command-object) object to a [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection. |
| [InsertEx](iagentcommandsex--insertex) | Inserts a [**Command**](/en-us/windows/desktop/lwef/the-command-object) object in a [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection. |
| [SetGlobalVoiceCommandsEnabled](iagentcommandsex--setglobalvoicecommandsenabled) | Enables the voice grammar for Agent's global commands. |
| [GetGlobalVoiceCommandsEnabled](iagentcommandsex--getglobalvoicecommandsenabled) | Returns whether the voice grammar for Agent's global commands is enabled. |