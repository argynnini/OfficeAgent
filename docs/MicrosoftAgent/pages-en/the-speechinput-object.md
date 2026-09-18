---
layout: Conceptual
title: The SpeechInput Object - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/the-speechinput-object
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
description: The SpeechInput Object
ms.assetid: e968edb8-747f-421a-800b-29f13857410c
ms.topic: concept-article
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: e6a70c3b-c447-9197-9b20-31a77bfc5c11
document_version_independent_id: 39a83e20-ce2e-a0a3-fba2-d3144c096312
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/the-speechinput-object.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/the-speechinput-object.md
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 102
asset_id: lwef/the-speechinput-object
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/the-speechinput-object.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 0708a0e9-2d80-9d9f-62af-c8fa7499cbea
---

# The SpeechInput Object - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

The [**SpeechInput**](https://www.bing.com/search?q=**SpeechInput**) object provides access to the speech input properties maintained by the Agent server. The properties are read-only for client applications, but the user can change them in the Microsoft Agent property sheet. The server returns values only if a compatible speech engine has been installed and is enabled.

The [**Engine**](https://www.bing.com/search?q=**Engine**), [**Installed**](https://www.bing.com/search?q=**Installed**), and [**Language**](https://www.bing.com/search?q=**Language**) properties are no longer supported, but (for backward compatibility) return null values if queried. To query or set a speech recognition's mode, use the [**SRModeID**](srmodeid-property) property.

- [SpeechInput Properties](speechinput-properties)