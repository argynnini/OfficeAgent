---
layout: Conceptual
title: IAgentCommands RemoveAll - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcommands--removeall
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
description: IAgentCommands RemoveAll
ms.assetid: fab43363-6325-4566-b7bb-599591f67321
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 10f918c1-8507-6f83-c958-eabcb686e8e8
document_version_independent_id: 6d9a84d1-3df1-bd41-4eaa-271506f47db9
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommands--removeall.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentcommands--removeall.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 74
asset_id: lwef/iagentcommands--removeall
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcommands--removeall.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 654b7fac-67da-699d-00e3-13735d3361eb
---

# IAgentCommands RemoveAll - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT Remove();
```

Removes all [**Commands**](/en-us/windows/desktop/lwef/the-command-object) from a [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection.

- Returns S\_OK to indicate the operation was successful.

Removing all [**Commands**](/en-us/windows/desktop/lwef/the-command-object) from a [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection also removes them from the pop-up menu and the **Voice Commands Window** when your application is input-active. **RemoveAll** does not remove server or other client's entries.