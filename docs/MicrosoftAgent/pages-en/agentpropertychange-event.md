---
layout: Conceptual
title: AgentPropertyChange Event - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/agentpropertychange-event
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
description: AgentPropertyChange Event
ms.assetid: 56607e9c-99eb-42c1-987a-0f2bc3f82d75
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: cbfa9fa3-5679-02e4-a677-bc0f3a7fe614
document_version_independent_id: c6d99547-56ca-c2bf-cd4f-b749477061e7
updated_at: 2025-03-13T17:42:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/agentpropertychange-event.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/agentpropertychange-event.md
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 82
asset_id: lwef/agentpropertychange-event
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/agentpropertychange-event.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 4723c7cf-3cbd-f096-af91-78d01aabba4d
---

# AgentPropertyChange Event - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Occurs when the user changes a property in the Advanced Character Options window.
- **Syntax**
    - **Sub** \*agent.\***AgentPropertyChange**

### Remarks

This event indicates when the user has changed and applied any property included in the Advanced Character Option window.

In your code for this handling this event, you can query for the specific property settings of [AudioOutput](the-audiooutput-object) or [SpeechInput](the-speechinput-object) objects.

### See Also

[**DefaultCharacterChange event**](defaultcharacterchange-event)