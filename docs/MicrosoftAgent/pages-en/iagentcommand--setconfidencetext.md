---
layout: Conceptual
title: IAgentCommand SetConfidenceText - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcommand--setconfidencetext
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
description: IAgentCommand SetConfidenceText
ms.assetid: e776a2ba-3592-4f26-a3e3-2c044eed7f0c
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 59e84ecb-a680-6bc4-77db-2a71a0c844bf
document_version_independent_id: 518a1683-1a1e-d0fb-be07-c02b3c6c26c4
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommand--setconfidencetext.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcommand--setconfidencetext.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 102
asset_id: lwef/iagentcommand--setconfidencetext
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcommand--setconfidencetext.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: a80a145a-4682-2599-9942-c49cadfa9339
---

# IAgentCommand SetConfidenceText - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT SetConfidenceText(
   BSTR bszTipText  // ConfidenceText setting for Command 
);
```

Sets the value of the Listening Tip text for a [**Command**](/en-us/windows/desktop/lwef/the-command-object).

- Returns S\_OK to indicate the operation was successful.

- *bszTipText*
    - A BSTR that specifies the text for the [**ConfidenceText**](confidencetext-property) property of a [**Command**](/en-us/windows/desktop/lwef/the-command-object).

If the confidence value returned of the best match returned in the [**Command**](/en-us/windows/desktop/lwef/the-command-object) event does not exceed the value set for the [**ConfidenceThreshold**](/en-us/windows/desktop/lwef/confidence-property) property, the text supplied in *bszTipText* is displayed in the Listening Tip.