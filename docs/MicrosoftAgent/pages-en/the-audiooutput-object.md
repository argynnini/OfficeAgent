---
layout: Conceptual
title: The AudioOutput Object - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/the-audiooutput-object
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
description: The AudioOutput Object
ms.assetid: 7c1c6079-f445-4980-9559-8d26b6014e89
ms.topic: concept-article
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 3681b1fa-a51f-1579-22db-900bbb801e39
document_version_independent_id: ad9e94a2-794e-617f-3dbb-9598a01aec76
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/the-audiooutput-object.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/the-audiooutput-object.md
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 94
asset_id: lwef/the-audiooutput-object
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/the-audiooutput-object.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 8b6db82c-c80d-5625-f4da-7556f75fcbbb
---

# The AudioOutput Object - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

This object provides access to audio output properties maintained by the server. The properties are read-only, but the user can change them in the Microsoft Agent property sheet.

If you declare an object variable of type [**IAgentCtlAudioObjectEx**](https://www.bing.com/search?q=**IAgentCtlAudioObjectEx**), you will not be able to access all properties for the [**AudioOutput**](/en-us/windows/desktop/lwef/the-audiooutput-object) object. While Agent also supports [**IAgentCtlAudioObject**](https://www.bing.com/search?q=**IAgentCtlAudioObject**), this latter interface is provided only for backward compatibility and supports only those properties in previous releases.

- [**Enabled**](enabled-property-ao)
- [**SoundEffects**](soundeffects-property)
- [**Status**](status-property)