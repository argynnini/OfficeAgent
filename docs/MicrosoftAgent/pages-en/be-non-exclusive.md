---
layout: Conceptual
title: Be Non-Exclusive - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/be-non-exclusive
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
description: Be Non-Exclusive
ms.assetid: 7a44840d-6bf9-4c12-ba14-66d7067a984d
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 398a1ccb-2a9e-c745-af50-2ebc0c096de8
document_version_independent_id: 2bb61704-f1b7-eea5-6f30-00a8c2626868
updated_at: 2025-03-13T17:42:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/be-non-exclusive.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/be-non-exclusive.md
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 214
asset_id: lwef/be-non-exclusive
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/be-non-exclusive.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: da354c11-c2cc-d85d-7bff-3f4668aece25
---

# Be Non-Exclusive - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

Interactive characters can be employed in the user interface as assistants, guides, entertainers, storytellers, sales agents, or in a variety of other roles. A character that automatically performs or assists should not be designed contrary to the design principle of keeping the user in control. When adding a character to the interface of a website or conventional application, use the character as an enhancement, rather than a replacement of, the primary interface. Avoid implementing any feature or operation that exclusively requires a character.

Similarly, let the user choose when they want to interact with your character. A user should be able to dismiss the character and have it return only with the user's permission. Forcing character interaction on users can have a serious negative effect. To support user control of character interaction, Microsoft Agent automatically includes Hide and Show commands. The Microsoft Agent API also supports these methods, so you can include support for these functions in your own interface. In addition, Microsoft Agent's user interface includes global properties that enable the user to override certain character output options. To ensure that the user's preferences are maintained, these properties cannot be overridden through the API.