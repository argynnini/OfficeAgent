---
layout: Conceptual
title: Speech Engine Selection - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/speech-engine-selection
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
description: Speech Engine Selection
ms.assetid: f5afedc6-093f-4247-a5c8-277d6b2d646c
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 5159b2fe-c468-3b60-705f-79672dda296f
document_version_independent_id: 265a663f-363f-9b01-d5d9-4795402298b2
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/speech-engine-selection.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/speech-engine-selection.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 264
asset_id: lwef/speech-engine-selection
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/speech-engine-selection.md
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/c6f99e62-1cf6-4b71-af9b-649b05f80cce
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/3f56b378-07a9-4fa1-afe8-9889fdc77628
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: af902c43-e08c-2f15-bafb-b7de0ad13327
---

# Speech Engine Selection - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

A character's language ID setting determines its default speech input language; Microsoft Agent requests SAPI for an installed engine that matches that language. If a client application does not specify a language preference, Microsoft Agent will attempt to find a speech recognition engine that matches the user default language ID (using the major language ID, then the minor language ID). If no engine is available matching this language, speech is disabled for that character.

You can also request a specific speech recognition engine by specifying its mode ID (using the character [**SRModeID**](srmodeid-property) property). However, if the language ID for that mode ID does not match the client's language setting, the call will fail (raise an error in the control). The speech recognition engine will then remain the last successfully set engine by the client, or if none, the engine that matches the current system language ID. If there is still no match, speech input is not available for that client.

Microsoft Agent automatically loads a speech recognition engine when speech input is initiated by a user pressing the Listening hotkey or the input-active client calls the [**Listen**](listen-method) method. However, an engine may also be loaded when setting or querying its mode ID, setting or querying the properties of the Voice Commands Window, querying [**SRStatus**](srstatus-property), or when speech is enabled and the user displays the Speech Input page of the Advanced Character Options. However, Microsoft Agent only keeps loaded the speech engines that clients are using.