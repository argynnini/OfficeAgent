---
layout: Conceptual
title: Agent Control Properties - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/agent-control-properties
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
description: Agent Control Properties
ms.assetid: e6a5b2db-9abf-4988-be41-fc7f4530507f
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: bf6fbd8f-f44c-58d2-0185-092178bd7bce
document_version_independent_id: b44c02dd-0f8c-5ea4-1bc8-6dbed8fb5fab
updated_at: 2025-03-13T17:42:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/agent-control-properties.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/agent-control-properties.md
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 101
asset_id: lwef/agent-control-properties
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/agent-control-properties.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: f83394c1-3bd3-d367-c97f-dfde05e34a7f
---

# Agent Control Properties - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

The following properties are directly accessed from the Agent control:

- [**Connected**](connected-property)
- [**Name**](name-property-a)
- [**RaiseRequestErrors**](raiserequesterrors-property)

In addition, some programming environments may assign additional design-time or run-time properties. For example, Visual Basic adds Left, Index, Tag, and Top properties that define the location of the control on a form even though the control does not appear on the form's page at run time.

The Suspended property is still supported for backward compatibility, but always returns **False** because the server no longer supports a suspended state.