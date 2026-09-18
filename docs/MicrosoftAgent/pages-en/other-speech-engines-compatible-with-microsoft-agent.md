---
layout: Conceptual
title: Other Speech Engines Compatible with Microsoft Agent - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/other-speech-engines-compatible-with-microsoft-agent
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
description: Other Speech Engines Compatible with Microsoft Agent
ms.assetid: fa87c592-c819-4dea-a1d0-6ccb25cc0bcc
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 8670d59b-88e0-cf0a-2477-608f53def857
document_version_independent_id: b43951e3-0841-4d64-1ef9-12fb562dcf3b
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/other-speech-engines-compatible-with-microsoft-agent.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/other-speech-engines-compatible-with-microsoft-agent.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 376
asset_id: lwef/other-speech-engines-compatible-with-microsoft-agent
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/other-speech-engines-compatible-with-microsoft-agent.md
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: ae447366-e8e5-281d-f89b-90958be4f882
---

# Other Speech Engines Compatible with Microsoft Agent - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

In addition to the Microsoft speech engines that are provided with and support Microsoft Agent, a number of companies also offer speech engines with support for Microsoft Agent. This page gives you a brief overview of such engines that may be available in U.S. English and other languages. Information about how to install and access, as well as license and redistribute the engines can be found at their websites.

When using any third-party speech engine, you also need to install Microsoft SAPI 4.0a runtime binaries so that the engines are enumerated properly. From your webpage you can include the following tag to trigger an autodownload of the Speech API:

```syntax
<OBJECT WIDTH=0 HEIGHT=0
  CLASSID="CLSID:0C7F3F20-8BAB-11d2-9432-00C04F8EF48F"
  CODEBASE="#VERSION=4,0,0,0">
</OBJECT>
```

For more information about the SAPI runtime binaries, refer to the [Microsoft Speech group's website](https://msdn.microsoft.com/library/ee705648.aspx). Microsoft Agent also installs the SAPI runtime binaries with the Microsoft Speech Recognition Engine, the Speech Control Panel, and the Agent Character Editor.

Please note that these links point to servers that are not under Microsoft control. Please read the Microsoft [official statement](https://www.microsoft.com/isapi/gomscom.asp?TARGET=/Misc/NonMS.md) regarding other servers. Microsoft does not endorse the content nor the software provided at these websites. All technical and support questions should also be directed to the suppliers of the engines and not to Microsoft or the Microsoft Agent team.

**Digalo Text-To-Speech Engine**

Digalo is an affordable TTS engine designed for end-users and developers. The engine is offered in a number of languages: French, German, Portuguese (Brazil), Spanish, Russian, and UK and U.S. English, with Italian, Polish, and other languages coming soon. Developer information, as well as details on end-user registration and affiliate programs, is also available.

**Elan Speech Engine**

Elan Speech Engine uses Elan's Text To Speech technology and is available in seven languages: French, German, Portuguese (Brazil), Spanish, Russian, UK and U.S. English.

**IBM ViaVoice Outloud**

IBM has developed several Microsoft Agent characters for use with ViaVoice Outloud. IBM ViaVoice Outloud is a text-to-speech (speech synthesis) technology and is available in French, German, Italian, Spanish, UK English and U.S. English. When combined with Microsoft Agent, you can create vibrant applications in many languages and extend your sales opportunities to new worldwide markets.