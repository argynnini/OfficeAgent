---
layout: Conceptual
title: Adding Microsoft Agent Functionality to Your Application - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/adding-microsoft-agent-functionality-to-your-application
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
description: Adding Microsoft Agent Functionality to Your Application
ms.assetid: 2b4816dd-11bf-4c17-873e-4bdbb7fa1ccf
ms.topic: concept-article
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: bc896203-4357-adf6-75b5-ae55639a0ebc
document_version_independent_id: cf554d70-a01d-db20-7081-c6cd82e6bcb0
updated_at: 2025-03-13T17:42:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/adding-microsoft-agent-functionality-to-your-application.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/adding-microsoft-agent-functionality-to-your-application.md
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 467
asset_id: lwef/adding-microsoft-agent-functionality-to-your-application
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/adding-microsoft-agent-functionality-to-your-application.md
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 768bd325-33a2-bc61-8e69-f7fdc50149a5
---

# Adding Microsoft Agent Functionality to Your Application - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

To access Microsoft Agent's server interfaces, Agent must already be installed on the target system. Installation other than using Agent's self-installing executable file, such as attempting to copy and register Agent component files, is not supported. This ensures consistent and complete installation. Note that the Microsoft Agent self-installing file will not install on Microsoft Windows 2000 and later operating systems because these versions of the operating system already include their own version of Agent.

To successfully install Agent on a target system with a prior Microsoft Windows operating system, you must also ensure that the target system has a recent version of the Microsoft Visual C++ runtime (Msvcrt.dll), Microsoft registration tool (Regsvr32.dll), and Microsoft COM dlls. The easiest way to ensure that the necessary components are on the target system is to require that Microsoft Internet Explorer 3.02 or later is installed. Alternatively, you can install the first two components which are available as part of Microsoft Visual C++. The necessary COM dlls can be installed as part of the Microsoft DCOM update, available at the Microsoft website. You can find further information and licensing information for these components at the Microsoft website.

Agent's language components can be installed the same way. Similarly, you can use this technique to install the ACS format of the Microsoft characters available for distribution from the Microsoft Agent website. The character files automatically install to the Microsoft Agent \Chars subdirectory.

Because Microsoft Agent's components are designed as operating system components, Agent may not be uninstalled. Similarly, where Agent is already installed as part of the Windows operating system, the Agent self-installing cabinet may not install.

Once installed, to call Agent's interfaces, create an instance of the server and request a pointer to a specific interface that the server supports using the standard COM convention. In particular, the COM library provides an API function, [**CoCreateInstance**](/en-us/windows/desktop/api/combaseapi/nf-combaseapi-cocreateinstance), that creates an instance of the object and returns a pointer to the requested interface of the object. Request a pointer to the [**IAgent**](iagent) or [**IAgentEx**](iagentex) interface in your **CoCreateInstance** call or in a subsequent call to [**QueryInterface**](/en-us/windows/desktop/api/unknwn/nf-unknwn-iunknown-queryinterface%28q%29).

The following code illustrates this in C/C++.

```
hRes = CoCreateInstance(CLSID_AgentServer,
                     NULL,
                     CLSCTX_SERVER,
                     IID_IAgentEx,
                     (LPVOID *)&amp;pAgentEx);
```

If the Microsoft Agent server is running, this function connects to the server; otherwise, it starts up the server.

Note that the Microsoft Agent server interfaces often include extended interfaces that include an "Ex" suffix. These interfaces are derived from, and therefore include all the functionality of, their non-Ex counterparts. If you want to use any of the extended features, use the Ex interfaces.

Functions that take pointers to BSTRs allocate memory using [**SysAllocString**](/en-us/previous-versions/windows/desktop/api/oleauto/nf-oleauto-sysallocstring). It is the caller's responsibility to free this memory using [**SysFreeString**](/en-us/previous-versions/windows/desktop/api/oleauto/nf-oleauto-sysfreestring).