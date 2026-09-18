---
layout: Conceptual
title: Using the Editor with a Different Speech Engine - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/using-the-editor-with-a-different-speech-engine
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
description: Using the Editor with a Different Speech Engine
ms.assetid: a102bda8-5824-4dbc-bf50-6338c40fc9e5
ms.topic: concept-article
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 8fb5c71d-0bc7-b2e4-5010-d01c880044d4
document_version_independent_id: c7341709-db8c-7a55-aa31-046e90a18969
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/using-the-editor-with-a-different-speech-engine.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/using-the-editor-with-a-different-speech-engine.md
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 129
asset_id: lwef/using-the-editor-with-a-different-speech-engine
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/using-the-editor-with-a-different-speech-engine.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 43d2a02d-70fd-4eaa-922a-695dcb16b391
---

# Using the Editor with a Different Speech Engine - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

While the sound editor installs the Microsoft Speech Recognition Engine (4.0), it may be used with another speech engine, if that engine supports the required interfaces documented in the Speech Engine Requirements document. Before attempting to use the editor with another engine, confirm with your vendor that they comply with these requirements.

To use the sound editor with another speech engine, choose the Speech Engine command on the **Edit** menu. This displays a dialog box showing the current engine in use. To choose another engine, display the list of engines, then click **OK**. If there are no other engines listed, then you do not have any other compatible engines included.