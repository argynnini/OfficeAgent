---
layout: Conceptual
title: Accessing the Control from Visual Basic and Other Programming Languages - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/accessing-the-control-from-visual-basic-and-other-programming-languages
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
description: Accessing the Control from Visual Basic and Other Programming Languages
ms.assetid: 869b8eb1-1f40-4d87-8501-e41d6c0a3a97
ms.topic: concept-article
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: b0195058-9dfa-5b22-83a8-b7b27ea4bf4f
document_version_independent_id: ad4a4ab5-4d00-3e31-4f59-8cdfae6e03a8
updated_at: 2025-03-13T17:42:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/accessing-the-control-from-visual-basic-and-other-programming-languages.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/accessing-the-control-from-visual-basic-and-other-programming-languages.md
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 365
asset_id: lwef/accessing-the-control-from-visual-basic-and-other-programming-languages
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/accessing-the-control-from-visual-basic-and-other-programming-languages.md
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/c6f99e62-1cf6-4b71-af9b-649b05f80cce
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/3f56b378-07a9-4fa1-afe8-9889fdc77628
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: a0fc2738-6308-5b2f-8ea7-92b9444b686e
---

# Accessing the Control from Visual Basic and Other Programming Languages - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

You can also use Microsoft Agent's control from Visual Basic and other programming languages. Make sure that the language fully supports the ActiveX control interface, and follow its conventions for adding and accessing ActiveX controls. To access the control, Agent must already be installed on the target system.

You can then download Agent's self-installing cabinet file from the website (using the Save rather than Run option). You can include this file in your installation setup program. Whenever it is executed, it will automatically install Agent on the target system. For further details on installation, see the Microsoft Agent distribution license agreement. Installation other than using Agent's self-installing cabinet file, such as attempting to copy and register Agent component files, is not supported. This ensures consistent and complete installation. Note that the Microsoft Agent self-installing file will not install on Microsoft Windows 2000 because that version of the operating system already includes its own version of Agent.

To successfully install Agent on a target system, you must also ensure that the target system has a recent version of the Microsoft Visual C++ runtime (Msvcrt.dll), Microsoft registration tool (Regsvr32.dll), and Microsoft COM dlls. The easiest way to ensure that the necessary components are on the target system is to require that Microsoft Internet Explorer 3.02 or later is installed. Alternatively, you can install the first two components which are available as part of Microsoft Visual C++. The necessary COM dlls can be installed as part of the Microsoft DCOM update, available at the Microsoft website. You can find further information and licensing information for these components at the Microsoft website.

Agent's language components can be installed the same way. Similarly, you can use this technique to install the ACS format of the Microsoft characters available for distribution from the Microsoft Agent website. The character files automatically install to the Microsoft Agent \Chars subdirectory.

Because Microsoft Agent's components are designed as operating system components, Agent may not be uninstalled. Similarly, where Agent is already installed as part of the Windows operating system, the Agent self-installing cabinet may not install.