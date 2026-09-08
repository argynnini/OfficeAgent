---
layout: Conceptual
title: Microsoft Agent - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/microsoft-agent
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
description: Microsoft Agent version 2.0 provides technology to create innovative, new conversational interfaces for applications and webpages.
ms.assetid: vs|msagent|~\agentstartpage_7gdh.htm
keywords:
- Microsoft Agent
- Microsoft Agent, start page
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 32001c35-c754-1e60-ce8c-0c05b20cc86f
document_version_independent_id: 2379acd2-084a-da41-7fde-0716b103387b
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/microsoft-agent.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/microsoft-agent.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 512
asset_id: lwef/microsoft-agent
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/microsoft-agent.md
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: f2e89354-1fc4-6c34-39af-d87ef18fb59b
---

# Microsoft Agent - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows. For more information, see [Windows 7 and Windows Server 2008 R2 Application Quality Cookbook](../win7appqual/windows-7-application-quality-cookbook).]

## Purpose

Microsoft Agent version 2.0 provides technology to create innovative, new conversational interfaces for applications and webpages. It provides powerful animation capability, interactivity, and versatility, with incredible ease of development.

Microsoft Agent is a technology that provides a foundation for more natural ways for people to communicate with their computers. It is a set of software services that enable developers to incorporate interactive animated characters into their applications and webpages. These characters can speak, via a text-to-speech engine or recorded audio, and even accept spoken voice commands. Microsoft Agent empowers developers to extend the user interface beyond the conventional mouse and keyboard interactions prevalent today.

Enhancing applications and webpages with a visible interactive personality will both broaden and humanize the interaction between users and their computers.

## Where applicable

There are a limitless number of roles and functions that developers can create for these personalities to perform.

- A welcome host could greet new users and provide a guided tour the first time a computer is turned on, an application is run, or a website is browsed.
- A friendly tutor could lead someone through a task or a decision tree with instructions step-by-step along the way.
- A messenger could deliver a notification or alert that a new email has arrived and then offer to read it to you.
- An assistant could perform tasks for you like looking up information on the Internet and then reading it out loud.

## Developer audience

Microsoft Agent is designed primarily for developers who use languages or environments which support COM or Microsoft ActiveX control interfaces. These include:

- Microsoft Visual Studio (Visual C++, Visual Basic)
- Microsoft Office (Visual Basic for Applications)
- Microsoft Internet Explorer (Visual Basic Scripting Edition or Microsoft JScript)
- Microsoft Windows Script Host (ActiveX Scripting Language)
- Other Applications and Environments which support COM or ActiveX control interfaces.

## Run-time requirements

**Required:**

- Microsoft Windows 95, Windows 98, Windows Me, Windows NT 4.0 (x86), or Windows 2000
- Internet Explorer version 3.02 or later
- A Pentium 100 MHz PC (or faster)
- At least 16 megabytes (MB) RAM
- At least 1 MB free disk space for the core components
- An additional 2 to 4 MB for each character you install
- An additional 32 KB for each language component (DLL)

**Recommended:**

- An additional 1.6 MB free disk space if you plan to use the Lernout & Hauspie TruVoice Text-To-Speech Engine for speech output
- An additional 22 MB free disk space if you plan to use the Microsoft Speech Recognition Engine for speech input
- A Windows-compatible sound card
- A compatible set of speakers and microphone