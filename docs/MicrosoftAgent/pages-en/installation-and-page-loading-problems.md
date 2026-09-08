---
layout: Conceptual
title: Installation and Page Loading Problems - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/installation-and-page-loading-problems
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
description: Installation and Page Loading Problems
ms.assetid: 1611c3f1-0411-4631-a64c-e7637fc7edd9
ms.topic: concept-article
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 0a5159be-7dc6-fbf7-85eb-196755333ea0
document_version_independent_id: dfe57f41-5f20-3d5f-93aa-214f67c2cd28
updated_at: 2025-05-19T16:30:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/installation-and-page-loading-problems.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/ca74834093fa2f82c608f87b28f030b2f88462b1/desktop-src/lwef/installation-and-page-loading-problems.md
git_commit_id: ca74834093fa2f82c608f87b28f030b2f88462b1
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 719
asset_id: lwef/installation-and-page-loading-problems
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/installation-and-page-loading-problems.md
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: b098a43f-bde9-cda5-d4ca-ed1e9b47e537
---

# Installation and Page Loading Problems - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

### When I attempt to install Microsoft Agent on Microsoft Windows NT, I get a message indicating that I need to be an administrator.

Because Microsoft Agent writes files to your system directory when it installs, you must have administrator (not user) privileges to install.

### When I attempt to install Microsoft Agent, I get one of the following errors: Process (Regsvr32 /s windows\msagent\AgentCtl.dll). Error while creating this file. Cannot find this file. (Note: The directory location cited in the error message varies depending on how you installed Windows.) A required DLL MSVCRT.DLL was not found. Error creating process &lt;c:\windows\msagent\agentsvr.exe /regserver&gt;. Reason: One of the library files needed to run this application cannot be found. (Note: The directory location cited in the error message varies depending on how you installed Windows.)

Installation of Microsoft Agent requires the proper installation of Regsvr32.exe, Msvcrt.dll (the Microsoft C run-time library), and up-to-date OLE dlls. For more information, see [DCOM update](/en-us/openspecs/windows_protocols/ms-dcom/4a893f3d-bd29-48cd-9f43-d9777a4415b0). The best way to ensure that all the correct system files are present is to install [Microsoft Internet Explorer 4.0](https://www.microsoft.com/ie/download) or later.

### When I attempt to load a page scripted for Microsoft Agent, I get a scripting error: "VBScript Runtime Error, Object required."

One of the following conditions may cause the message to display:

- Your security options for Microsoft Internet Explorer must be set to enable ActiveX controls and plug-ins. Check your browser's security page. In Microsoft Internet Explorer, open the View menu, choose Options, click the Security tab, and make sure the Enable ActiveX Controls And Plug-Ins check box is checked.
- You are running on a dual-boot Windows 9x or Windows NT system and you have installed Microsoft Agent on one operating system but are trying to access the page from the other operating system. Although the operating systems may share directories and files, the registry information used by Microsoft Agent is not shared, so you must install Microsoft Agent on the operating system you use to access webpages scripted with the character.

### When I attempt to load a page scripted for Microsoft Agent, nothing happens.

This can occur if one of the following conditions exists:

- Check your browser's security options. Your browser must be set to enable the loading of ActiveX scripts and playing of ActiveX controls.
- If you are accessing pages scripted with Microsoft Agent and using Microsoft Internet Explorer, you must have version 3.02 or later (download the latest version of Internet Explorer at [https://www.microsoft.com/windows/ie/](https://www.microsoft.com/windows/internet-explorer/default.aspx)https://www.microsoft.com/windows/ie/). In Microsoft Internet Explorer, open the View menu, choose Options, click the Security tab, and select all the Active Content check boxes.
- A Java applet on the page can also cause this error. To run Microsoft Agent on the same page as a Java applet requires version 2.0 of the Microsoft Virtual Machine (VM). For more information, see the [Programming/Scripting FAQ](programming-scripting-faq).

### When I attempt to load a page scripted for Microsoft Agent, I get the message, "Unable to initialize Microsoft Agent."

This usually occurs when you don't have Microsoft Agent or some other control that page uses installed, and choose No when you are prompted to install the control. Try refreshing the page, though the page may work only if you install all the components it requires.

### When I attempt to load a page scripted for Microsoft Agent, I get the message, "The component has been digitally "signed" by its publisher, but the signature does not match the component. It is possible that this component has been damaged or tampered with? Do you want to continue?"

This may appear if you attempt to install Microsoft Agent on Microsoft Internet Explorer 3.02. You can either continue with the installation or update your browser to Internet Explorer 4.0 or later.

### When I attempt to load a page scripted for Microsoft Agent using Netscape Navigator (or other Internet browsers), I get errors.

Microsoft Agent is implemented using ActiveX interfaces. You can use it only with a browser (such as Microsoft Internet Explorer) that supports embedding ActiveX objects through script on a page, and only on systems running Microsoft Windows 95, Windows 98, and Windows NT 4.0 (or later). If you are not using Microsoft Internet Explorer ([https://www.microsoft.com/windows/ie/](https://www.microsoft.com/windows/internet-explorer/default.aspx)), check with your browser vendor for further information on ActiveX support.