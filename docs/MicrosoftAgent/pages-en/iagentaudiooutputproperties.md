---
layout: Conceptual
title: IAgentAudioOutputProperties - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentaudiooutputproperties
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
description: IAgentAudioOutputProperties
ms.assetid: 568786ca-9b9b-425c-95f5-4377516dbe79
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: ec9999a1-d9a1-f56a-fcdf-954b1c99f769
document_version_independent_id: c314767c-a0f6-4997-3fa3-273dfc9b3667
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentaudiooutputproperties.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentaudiooutputproperties.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 77
asset_id: lwef/iagentaudiooutputproperties
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentaudiooutputproperties.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 70f569af-af94-5a60-8124-87f47109977b
---

# IAgentAudioOutputProperties - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

IAgentAudioOutputProperties provides access to audio output properties maintained by the Microsoft Agent server. These functions are also available from IAgentAudioOutputProperties. The properties are read-only, but the user can change them in the Microsoft Agent property sheet.

**Methods in Vtable Order**

| IAgentAudioOutputProperties Methods | Description |
| --- | --- |
| [**GetEnabled**](iagentaudiooutputproperties--getenabled) | Returns whether audio output is enabled. |
| [**GetUsingSoundEffects**](iagentaudiooutputproperties--getusingsoundeffects) | Returns whether sound-effect output is enabled. |