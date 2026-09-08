---
layout: Conceptual
title: IAgent Load - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagent--load
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
description: IAgent Load
ms.assetid: 8f25e6b6-a117-4b37-969a-d8f80c7be224
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 1915ee2f-51af-0e93-d731-362f44987d32
document_version_independent_id: f14defbd-b51d-57e4-27d6-af874ea2c4ae
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagent--load.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagent--load.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 394
asset_id: lwef/iagent--load
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagent--load.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: eb6f4e37-c48e-cfed-a682-62c310eab83f
---

# IAgent Load - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT Load(
   VARIANT vLoadKey,  // data provider
   long * pdwCharID,  // address of a variable for character ID
   long * pdwReqID    // address of a variable for request ID
);
```

Loads a character into the [**Characters**](iagent) collection.

- Returns S\_OK to indicate the operation was successful.

- *vLoadKey*
    - A variant datatype that must be one of the following:

| Value | Description |
| --- | --- |
| *filespec* | The local file location of the specified character's definition file. |
| *URL* | The HTTP address for the character's definition file. |
- *pdwCharID*
    - Address of a variable that receives the character's ID.
- *pdwReqID*
    - Address of a variable that receives the [**Load**](load-method) request ID.

You can load characters from the Microsoft Agent subdirectory by specifying a relative path (one that does not include a colon or leading slash character). This prefixes the path with Agent's characters directory (located in the localized %windows%\msagent directory). You can also use a relative address to specify your own directory in Agent's Chars directory.

You cannot load the same character (a character having the same GUID) more than once from a single connection. Similarly, you cannot load the default character and other characters at the same time from a single connection, because the default character could be the same as the other character. However, you can create another connection (using CoCreateInstance) and load the same character.

Microsoft Agent's data provider supports loading character data stored as a single structured file (.ACS) with character data and animation data together, or as separate character data (.ACF) and animation (.ACA) files. Generally, use the single structured .ACS file to load a character that is stored on a local disk drive or network and accessed using conventional file protocol (such as UNC pathnames). Use the separate .ACF and .ACA files when you want to load the animation files individually from a remote site where they are accessed using HTTP protocol.

For .ACS files, using the [**Load**](load-method) method provides access a character's animations; once loaded, you can use the [**Play**](play-method) method to animate the character. For .ACF files, you also use the [**Prepare**](/en-us/windows/desktop/lwef/iagentcharacter--prepare) method to load animation data. The **Load** method does not support downloading .ACS files from an HTTP site.

Loading a character does not automatically display the character. Use the [**Show**](show-method) method first to make the character visible.