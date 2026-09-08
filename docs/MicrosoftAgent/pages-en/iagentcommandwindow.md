---
layout: Conceptual
title: IAgentCommandWindow - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcommandwindow
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
description: IAgentCommandWindow
ms.assetid: 315b24b4-110e-4373-a1ee-0317531e6008
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: b299cccc-0c3f-c826-89f6-17acacb19861
document_version_independent_id: 905df70c-961b-8de3-0417-4ae091937eb2
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommandwindow.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentcommandwindow.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 197
asset_id: lwef/iagentcommandwindow
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcommandwindow.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: e9587875-b1b4-acd2-8019-9b40d1c38eca
---

# IAgentCommandWindow - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

**IAgentCommandWindow** defines an interface that allows applications to set and query the properties of the Voice Commands Window. The Voice Commands Window is a shared resource primarily designed to enable users to view voice-enabled commands. If speech recognition is disabled, the Voice Commands Window still displays, with the text "Speech input disabled" (in the language of the character). If no speech engine is installed that matches the character's language setting, the window displays, "Speech input not available." If the input-active client has not defined voice parameters for its commands and has disabled global voice commands, the window displays, "No voice commands." You can also query the properties of the Voice Commands Window regardless of whether speech input is disabled or a compatible speech engine is installed.

**Methods in Vtable Order**

| IAgentCommandWindow Methods | Description |
| --- | --- |
| [**SetVisible**](iagentcommandwindow--setvisible) | Sets the value of the [**Visible**](visible-property) property of the Voice Commands Window. |
| [**GetVisible**](iagentcommandwindow--getvisible) | Returns the value of the [**Visible**](visible-property) property of the Voice Commands Window. |
| [**GetPosition**](iagentcommandwindow--getposition) | Returns the position of the Voice Commands Window. |
| [**GetSize**](iagentcommandwindow--getsize) | Returns the size of the Voice Commands Window. |