---
layout: Conceptual
title: IAgentUserInput GetCount - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentuserinput--getcount
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
description: IAgentUserInput GetCount
ms.assetid: 9c127387-b680-405a-9a62-ee08cc70813a
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 1a3ffc44-db60-6f14-360a-4d6e1970a82f
document_version_independent_id: ebaa8cf5-968c-d2c3-85d2-fa9b4e72ddf4
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentuserinput--getcount.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentuserinput--getcount.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 114
asset_id: lwef/iagentuserinput--getcount
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentuserinput--getcount.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 0fd21532-5990-8a0f-0239-7c538878fad6
---

# IAgentUserInput GetCount - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT GetCount(
   long * pdwCount  // address of a variable for number of alternatives 
);
```

Retrieves the number of [**Command**](command-event) alternatives passed to an [**IAgentNotifySink::Command**](iagentnotifysink--command) callback.

- Returns S\_OK to indicate the operation was successful.

- *pdwCount*
    - Address of a variable that receives the count of [**Commands**](command-event) alternatives identified by the server.

If voice input was not the source for the command, for example, if the user selected the command from the character's pop-up menu, **GetCount** returns 1. If **GetCount** returns zero (0), the speech recognition engine detected spoken input but determined that there was no matching command.