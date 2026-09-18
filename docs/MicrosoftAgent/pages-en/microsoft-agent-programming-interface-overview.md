---
layout: Conceptual
title: Microsoft Agent Programming Interface Overview - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/microsoft-agent-programming-interface-overview
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
description: Microsoft Agent Programming Interface Overview
ms.assetid: 8709441b-9739-4f11-a2de-40a5f5eefb72
ms.topic: concept-article
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: d054e901-17c1-c0cd-854e-953bfdb750ae
document_version_independent_id: eab2f641-03f9-07e0-dc08-e20d024d1172
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/microsoft-agent-programming-interface-overview.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/microsoft-agent-programming-interface-overview.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 248
asset_id: lwef/microsoft-agent-programming-interface-overview
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/microsoft-agent-programming-interface-overview.md
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 318b5321-4667-b808-c11e-bc0001311a36
---

# Microsoft Agent Programming Interface Overview - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

The Microsoft Agent API provides services that support the display and animation of animated characters. Implemented as an OLE Automation (Component Object Model [COM]) server, Microsoft Agent enables multiple applications, called clients or client applications, to host and access its animation, input, and output services at the same time. A client can be any application that connects to the Microsoft Agent's COM interfaces.

As a COM server, Microsoft Agent automatically starts up only when a client application uses the COM interfaces and requests to connect to it. It remains running until all clients close their connections. When no connected clients remain, Microsoft Agent automatically exits.

Although you can call Microsoft Agent's COM interfaces directly, Microsoft Agent also includes a Microsoft ActiveX control. This control makes it easy to access Microsoft Agent's services from programming languages that support the ActiveX control interface.

In addition to supporting stand-alone programs written for Windows, Agent can be scripted to support webpages, provided that the browser supports the ActiveX interface. Microsoft Internet Explorer includes support for ActiveX as well as scripting languages that you can use to program Agent. If you are not using Internet Explorer, consult with your vendor or supplier about the browser's support for ActiveX.

The following information provides a brief overview of the programming interfaces for the Microsoft Agent software.

- [Animation Services](animation-services)
- [Input Services](input-services)
- [The Voice Commands Window](the-voice-commands-window)
- [Output Services](output-services)