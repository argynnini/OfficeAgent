---
layout: Conceptual
title: Speed Property - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/speed-property
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
description: Speed Property
ms.assetid: 43d0480b-d3a5-4992-a2a5-80eba37221e4
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: ee21fece-ddb6-e7cb-ed65-a8873faba741
document_version_independent_id: 4ea69575-6021-4128-6467-2d420cfab01e
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/speed-property.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/speed-property.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 144
asset_id: lwef/speed-property
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/speed-property.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: d73f0ca1-925c-51e4-c261-df2477e1401d
---

# Speed Property - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Returns a Long integer that specifies the current speed of the character's speech output.
- **Syntax**
    - *agent*\*\*.Characters ("***CharacterID***").Speed\*\*

## Remarks

This property returns the current speaking output speed setting for the character. For characters using TTS output, the property returns the actual TTS output setting for the character. If TTS is not enabled or the character does not support TTS output, the setting reflects the user setting for output speed.

Although your application cannot write this value, you can include **Spd** (speed) tags in your output text that will temporarily speed up the output for a particular utterance. However, using the **Spd** tag to change the character's spoken output does not affect the **Speed** property setting. For further information, see [Speech Output Tags](microsoft-agent-speech-output-tags).