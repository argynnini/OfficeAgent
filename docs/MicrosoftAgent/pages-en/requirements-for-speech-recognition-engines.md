---
layout: Conceptual
title: Requirements for Speech Recognition Engines - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/requirements-for-speech-recognition-engines
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
description: Requirements for Speech Recognition Engines
ms.assetid: 41aca5da-c680-41c1-b070-af291cb0c8e1
ms.topic: concept-article
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: f581b2bb-e9c8-30b8-5d70-fee068188aea
document_version_independent_id: 02b5c7b4-7ee8-c8c9-8b3c-ed3565172052
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/requirements-for-speech-recognition-engines.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/requirements-for-speech-recognition-engines.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 212
asset_id: lwef/requirements-for-speech-recognition-engines
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/requirements-for-speech-recognition-engines.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 8e6719d7-1cd3-a5f9-77df-7e5250609a19
---

# Requirements for Speech Recognition Engines - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

A speech recognition engine must also be a fully compliant Command and Control (C&C) engine according to SAPI 4.0. It must support multiple grammars in the binary format described in the specification and allow those grammars to be activated or deactivated in real time.

Note that SAPI 4.0 requires that speech recognition engines support the wide character, Unicode interfaces. However, in supporting these interfaces, the engine should not depend on converting Unicode data to ANSI, as the engine may not function correctly on some systems. For example, a Japanese engine that converts Unicode to ANSI may not work on an English-language Microsoft Windows 95 system.

In addition, to be considered Microsoft Agent-compliant, the engine must return results objects upon the successful recognition of a phrase (through ISRGramNotifySinkW::PhraseFinish). These results objects must support ISRResBasic, as the specification requires. In addition, they should support ISRResScore. Although Microsoft Agent will run with an engine that supports only ISRResBasic, or even with an engine that returns no results objects whatsoever, performance will usually be significantly poorer with such engines. Many applications use the confidence values provided by the engine to control how they respond to various commands.