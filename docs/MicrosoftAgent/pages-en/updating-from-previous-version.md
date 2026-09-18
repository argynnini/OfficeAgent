---
layout: Conceptual
title: Updating from Previous Version - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/updating-from-previous-version
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
description: Updating from Previous Version
ms.assetid: a3f0c0bb-8c12-4907-8e49-49b098449c38
ms.topic: concept-article
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 4bcc1a66-1064-f708-52f7-e2670293ae92
document_version_independent_id: d8d6cf28-deaa-95cd-a762-fb1e46aa25ad
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/updating-from-previous-version.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/updating-from-previous-version.md
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 274
asset_id: lwef/updating-from-previous-version
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/updating-from-previous-version.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 82ae8a9b-a98c-8f87-d2e1-40400308b451
---

# Updating from Previous Version - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

Applications built and compiled with the previous 1.5 version of Microsoft Agent should run without modification under the new 2.0 version. The [**Connected**](connected-property) property can no longer be set to **False**; certain properties of the SpeechInput object that have been replaced still exist, but no longer turn any values, and the server no longer fires the [**Restart**](https://www.bing.com/search?q=**Restart**) and [**Shutdown**](https://www.bing.com/search?q=**Shutdown**) events.

However, if you update your applications to use the Agent 2.0 control, you may have to modify your code. If you have installed the 2.0 version of Microsoft Agent and load a Visual Basic project use the earlier version of the Agent control, Visual Basic includes an option that will automatically display a message indicating that it detected a new version of the control. To ensure proper operation of your application, always choose to use the later version.

For other programming languages (such as Microsoft Office 97 VBA), to update the control, you may have to first remove the 1.5 Agent control and save your code. Then, quit the programming environment, restart the programming environment, reload your code and insert the new control. Avoid editing an Agent 2.0-enabled application in the same instance of the programming environment that you are editing an Agent 1.5-enabled application in. Some programming environments may not handle the differences between the two versions of controls.

You should be able to uninstall the Agent 1.5 release on your system after installing the Agent 2.0 release. However, if Agent 1.5 is installed over the 2.0 release, you may have to reinstall 2.0.