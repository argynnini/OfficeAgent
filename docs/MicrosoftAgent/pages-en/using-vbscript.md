---
layout: Conceptual
title: Using VBScript - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/using-vbscript
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
description: Using VBScript
ms.assetid: a078eb60-aa12-42ea-850c-7b845fc8037c
ms.topic: concept-article
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: a5d38d44-4bd3-b886-7840-ab84486d3063
document_version_independent_id: a16593b4-a10a-18bf-d265-3a7a7239f6e1
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/using-vbscript.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/using-vbscript.md
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 386
asset_id: lwef/using-vbscript
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/using-vbscript.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 5d3019fb-eb58-8f49-8693-4b6da6c8bb2d
---

# Using VBScript - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

VBScript is a programming language included with Microsoft Internet Explorer. For other browsers, contact your vendor about support. VBScript 2.0 (or later) is recommended for use with Agent. Although earlier versions of VBScript may work with Agent, they lack certain functions that you may want to use. You can download VBScript 2.0 and obtain further information on VBScript at the Microsoft Downloads site and the Microsoft VBScript site.

To program Microsoft Agent from VBScript, use the HTML &lt;SCRIPT&gt; tags. To access the programming interface, use the name of control you assign in the &lt;OBJECT&gt; tag, followed by the subobject (if any), the name of the method or property, and any parameters or values supported by the method or property:

```syntax
agent[.object].Method parameter, [parameter]
agent[.object].Property = value
```

For events, include the name of the control followed by the name of the event and any parameters:

```syntax
Sub agent_event (ByVal parameter[,ByVal parameter])
statements
End Sub
```

You can also specify an event handler using the &lt;SCRIPT&gt; tag's **For...Event** syntax:

```syntax
<SCRIPT LANGUAGE=VBScript For=agent Event=event[(parameter[,parameter])]>
statements
</SCRIPT>
```

Although Microsoft Internet Explorer supports this latter syntax, not all browsers do. For compatibility, use only the former syntax for events.

With VBScript (2.0 or later), you can verify whether Microsoft Agent is installed by trying to create the object and checking to see if it exists. The following sample demonstrates how to check for the Agent control without triggering an auto-download of the control (as would happen if you included an &lt;OBJECT&gt; tag for the control on the page):

```syntax
<!-- WARNING - This code requires VBScript 2.0.
It will always fail to detect the Agent control
in VbScript 1.x, because CreateObject doesn't work.
-->

<SCRIPT LANGUAGE=VBSCRIPT>
If HaveAgent() Then
      'Microsoft Agent control was found.
document.write "<H2 align=center>Found</H2>"
Else
      'Microsoft Agent control was not found.
document.write "<H2 align=center>Not Found</H2>"
End If

Function HaveAgent()
' This procedure attempts to create an Agent Control object.
' If it succeeds, it returns True.
'    This means the control is available on the client.
' If it fails, it returns False.
'    This means the control hasn't been installed on the client.

   Dim agent
   HaveAgent = False
   On Error Resume Next
   Set agent = CreateObject("Agent.Control.1")
   HaveAgent = IsObject(agent)

End Function

</SCRIPT>
```