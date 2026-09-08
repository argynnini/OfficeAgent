---
layout: Conceptual
title: Loading the Default Character - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/loading-the-default-character
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
description: Loading the Default Character
ms.assetid: 4e91aef5-8402-401d-b09f-83be25011027
ms.topic: concept-article
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 1728d6f2-eac9-ed92-0a2f-ac94d5e3fbc6
document_version_independent_id: 2bdf5183-c88e-d382-76c3-d042345bbc8b
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/loading-the-default-character.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/loading-the-default-character.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 335
asset_id: lwef/loading-the-default-character
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/loading-the-default-character.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: d36076cc-4afe-1ad9-d8d0-2600e38ac3e6
---

# Loading the Default Character - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

Instead of loading only a specific character directly by specifying its filename, you can load the *default character*. The default character is a service intended to provide a shared, central Windows assistant that the user chooses. Microsoft Agent includes a property sheet as part of the default character service, known as the Character Properties window, which enables the user to change their selection of the default character.

Selection of the default character is limited to a character that supports the standard animation set, ensuring a basic level of consistency across characters. This does not exclude a character from having additional animations.

However, because the default character is intended for general-purpose use and may be shared by other applications at the same time, avoid loading the default character when you want a character exclusively for your application.

To load the default character, call the [**Load**](load-method) method without specifying a filename or path. Microsoft Agent automatically loads the current character set as the default character. If the user has not yet selected a default character, Agent will select the first character that supports the standard animation set. If none is available, the method will fail and report back the cause.

Although a client application can inquire as to the identity of the character, only a user can change its settings. You can use the [**ShowDefaultCharacterProperties**](showdefaultcharacterproperties-method) to display the Character Properties window.

The server will notify clients that have loaded the default character when a user changes a character selection, and pass the GUID of the new character. The server automatically unloads the former character and reloads the new character. The queues of any clients that have loaded the default character are halted and flushed. However, the queues of clients that have loaded the character explicitly using the character's filename are not affected. If necessary, the server also handles automatically resetting the text-to-speech (TTS) engine for the new character.