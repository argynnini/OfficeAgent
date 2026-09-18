---
layout: Conceptual
title: ConfidenceText Property - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/confidencetext-property
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
description: ConfidenceText Property
ms.assetid: ff856af7-c5ad-4970-8778-b59a76c5e276
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: fc7c2eff-c81b-d6ea-c477-94155509fd51
document_version_independent_id: 1ade3abe-850f-0c41-a91b-bcaf32ec9c3a
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/confidencetext-property.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/confidencetext-property.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 90
asset_id: lwef/confidencetext-property
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/confidencetext-property.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: c4fdd5f5-e101-5a69-f65d-3ed8136866f6
---

# ConfidenceText Property - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Returns or sets the client's **ConfidenceText** that appears in the Listening Tip.
- **Syntax**
    - *agent*\*\*.Characters ("***CharacterID***").Commands("***name***")\*\*.**ConfidenceText**[ = *string*]

| Part | Description |
| --- | --- |
| *string* | A string expression that evaluates to the text for the **ConfidenceText** for the [**Command**](/en-us/windows/desktop/lwef/the-command-object). |

## Remarks

When the returned confidence value of the best match (UserInput.Confidence) does not exceed the [**Confidence**](confidence-property) setting, the server displays the text supplied in **ConfidenceText** in the Listening Tip.