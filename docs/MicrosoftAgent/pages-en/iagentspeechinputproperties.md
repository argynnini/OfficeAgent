---
layout: Conceptual
title: IAgentSpeechInputProperties - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentspeechinputproperties
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
description: IAgentSpeechInputProperties
ms.assetid: 87bfc8c4-473b-4df9-becd-e90db12dae51
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 5f76efc2-726d-8927-d6cf-0dde0210f6c7
document_version_independent_id: c257ccc1-21dc-b3a1-401a-e82c7f21bfa9
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentspeechinputproperties.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentspeechinputproperties.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 176
asset_id: lwef/iagentspeechinputproperties
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentspeechinputproperties.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: ec559b13-bea6-d75f-9186-27ae3a55b6d9
---

# IAgentSpeechInputProperties - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

IAgentSpeechInputProperties provides access to the speech input properties maintained by the server. Most of the properties are read-only for client applications, but the user can change them in the Microsoft Agent property sheet. The Microsoft Agent server returns values only if a compatible speech engine has been installed and is enabled. Querying these properties attempts to start the speech engine.

**Methods in Vtable Order**

| IAgentSpeechInputProperties Methods | Description |
| --- | --- |
| [**GetEnabled**](iagentspeechinputproperties--getenabled) | Returns whether the speech recognition engine is enabled. |
| [**GetHotKey**](iagentspeechinputproperties--gethotkey) | Returns the current key assignment of the Listening key. |
| [**GetListeningTip**](iagentspeechinputproperties--getlisteningtip) | Returns whether the Listening Tip is enabled. |

[**GetInstalled**](https://www.bing.com/search?q=**GetInstalled**), [**GetLCID**](https://www.bing.com/search?q=**GetLCID**), [**GetEngine**](https://www.bing.com/search?q=**GetEngine**), and [**SetEngine**](https://www.bing.com/search?q=**SetEngine**) methods (supported in earlier versions of Microsoft Agent) are still supported for backward compatibility. However, the methods are not stubbed and do not return useful values. Use [**GetSRModeID**](https://www.bing.com/search?q=**GetSRModeID**) and [**SetSRModeID**](https://www.bing.com/search?q=**SetSRModeID**) to query and set the speech recognition engine to be used with the character. Keep in mind that the engine must match the character's current language setting.