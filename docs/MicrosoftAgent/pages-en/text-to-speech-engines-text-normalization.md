---
layout: Conceptual
title: Text-to-Speech Engines Text Normalization - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/text-to-speech-engines-text-normalization
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
description: Text-to-Speech Engines Text Normalization
ms.assetid: 1974d47b-4877-47e3-89d8-fd70967e7605
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: e5746fa8-1f15-1935-e2f2-223608556f54
document_version_independent_id: c2975bd7-d50c-f92f-60f5-c4b3872b58e0
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/text-to-speech-engines-text-normalization.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/text-to-speech-engines-text-normalization.md
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 128
asset_id: lwef/text-to-speech-engines-text-normalization
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/text-to-speech-engines-text-normalization.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://authoring-docs-microsoft.poolparty.biz/devrel/a8711e05-df51-442a-970f-935304535b39
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://authoring-docs-microsoft.poolparty.biz/devrel/3d3c20d8-79ed-4203-aee0-ffb9c9bafe72
platformId: 78a5ca2f-484e-21e2-7243-3282fd6c9a18
---

# Text-to-Speech Engines Text Normalization - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

Normalization is the process of identifying numbers, abbreviations, acronyms and idiomatics and transforming them into full text as needed, usually based on the context of the sentence.

For example, using the L&H TruVoice American English TTS Engine, the sentence:

King George VI of England died on Feb 6, 1952.

will be read under **normal context** as:

 King George V I of England, died on February six, nineteen fifty-two.

But under **E-mail context**, it will be read as:

 King George the sixth of England, died on February sixth, nineteen fifty-two.

Information about using the **Context** speech tag can be found in the Agent programming documentation [Microsoft Agent Speech Output Tags](microsoft-agent-speech-output-tags).