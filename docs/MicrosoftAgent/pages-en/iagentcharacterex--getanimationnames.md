---
layout: Conceptual
title: IAgentCharacterEx GetAnimationNames - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcharacterex--getanimationnames
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
description: IAgentCharacterEx GetAnimationNames
ms.assetid: d565b258-dc12-422b-a13d-aeec56057f64
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 4a98d3c2-b105-23bb-6048-b0fb53c1602d
document_version_independent_id: a867be19-fa1f-0d11-24ff-c83bf9f24956
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacterex--getanimationnames.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacterex--getanimationnames.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 159
asset_id: lwef/iagentcharacterex--getanimationnames
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcharacterex--getanimationnames.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: afbc37ba-64e6-f86b-e701-c2f9082ad43a
---

# IAgentCharacterEx GetAnimationNames - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT GetAnimationNames(
   IUnknown ** punkEnum // address of IUnknown interface
);
```

Retrieves the animation names for a character.

- Returns **S\_OK** to indicate the operation was successful.

- *IUnknown*
    - The address of the [**IUnknown**](/en-us/windows/win32/api/unknwn/nn-unknwn-iunknown) interface for the character's animation collection.

This function enables you to enumerate the names of the animations for a character. Items in the collection have no properties, so individual items cannot be accessed directly. To access the collection, query punkEnum for the IEnumVARIANT interface:

```c
IEnumVARIANT pEnum;
VARIANT vAnimName;
DWORD dwRetrieved;

hRes = punkEnum->QueryInterface(IID_IEnumVARIANT, (LPVOID *)&pEnum);

if (SUCCEEDED(hRes)) {

    while (TRUE) {

         hRes = pEnum->Next(1, &vAnimName, &dwRetrieved);

         if (hRes != NOERROR)
            break;

         // vAnimName.bstrVal is the animation name

         VariantClear(&vAnimName);
    } 

    pEnum->Release();
}

punkEnum->Release();
```

Note

For ACF characters, the collection returns all the animations that have been defined for the character, adding to the ones that have been retrieved with the [**Get**](https://www.bing.com/search?q=**Get**) method.