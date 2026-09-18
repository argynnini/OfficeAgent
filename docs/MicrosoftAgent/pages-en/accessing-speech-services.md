---
layout: Conceptual
title: Accessing Speech Services (Microsoft Agent Server Interface) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/accessing-speech-services
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
description: Learn about accessing speech services with Microsoft Agent Server Interface. Microsoft Agent is deprecated as of Windows 7.
ms.assetid: 99cf630d-3bd1-403a-833a-9173a84fe3c0
ms.topic: concept-article
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 5fc41a23-3cd0-cf3d-0cb2-127db74af175
document_version_independent_id: 0c8f776c-ee26-76d4-cf10-2e9516955d76
updated_at: 2025-03-13T17:42:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/accessing-speech-services.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/accessing-speech-services.md
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 317
asset_id: lwef/accessing-speech-services
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/accessing-speech-services.md
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/a8711e05-df51-442a-970f-935304535b39
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/3d3c20d8-79ed-4203-aee0-ffb9c9bafe72
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 43b87981-7d91-b37c-86fc-07833d6e32e9
---

# Accessing Speech Services (Microsoft Agent Server Interface) - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

Although Microsoft Agent's services include support for speech input, a compatible command-and-control speech recognition engine must be installed to access Agent's speech input services. Similarly, if you want to use Microsoft Agent's speech services to support synthesized speech output for a character, you must install a compatible text-to-speech (TTS) speech engine for your character. Because Microsoft Agent's speech services are based on the Microsoft Speech API (SAPI), you can use any engines that compatibly support the required speech interfaces.

To enable speech input support in your application, define a [**Command**](https://www.bing.com/search?q=**Command**) object and set its [**Voice**](https://www.bing.com/search?q=**Voice**) property. Microsoft Agent will automatically load speech services, so that when the user presses the Listening key or you call [**Listen**](https://www.bing.com/search?q=**Listen**), the speech recognition engine will be loaded. By default the character's language ID will determine which engine is loaded. Agent attempts to load the first engine that SAPI returns as matching this language. Use **IAgentCharacterEx::SetSRModeID** if you want to load a specific engine.

To enable text-to-speech output, use the [**Speak**](https://www.bing.com/search?q=**Speak**) method. Microsoft Agent will automatically attempt to load an engine that matches the character's language ID. If the character's definition includes a specific TTS engine mode ID and that engine is available and matches the character's language ID, Agent loads that engine for the character. If not, Agent loads the first TTS engine that SAPI returns as matching the character's language setting. You can also use **IAgentCharacterEx::SetTTSModeID** to load a specific engine.

Typically, Microsoft Agent loads a speech recognition engine when the Listening mode is initiated and loads a text-to-speech engine when [**Speak**](https://www.bing.com/search?q=**Speak**) is first called. However, if you want to preload the speech engine, you can do this by querying the properties related to the speech interfaces. For example, calling **IAgentCharacterEx::GetSRModeID** or **IAgentCharacterEx::GetTTSModeID** will attempt to load that type of engine.