---
layout: Conceptual
title: ISRResGraphEx and IAttributes - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/isrresgraphex-and-iattributes
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
description: ISRResGraphEx and IAttributes
ms.assetid: 6eb37da1-5252-4c41-891c-c19cca6fb7d1
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 7c6da650-5cb5-e201-5362-2f8eb4561179
document_version_independent_id: 91e0faa7-1742-df95-25a7-9e2810dd3308
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/isrresgraphex-and-iattributes.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/isrresgraphex-and-iattributes.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 630
asset_id: lwef/isrresgraphex-and-iattributes
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/isrresgraphex-and-iattributes.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 9f65c9e0-e87c-c6db-4544-b07fd55a8ec6
---

# ISRResGraphEx and IAttributes - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

The results objects returned by the engine must support the ISRResGraphEx interface and the IAttributes interface. Merely supporting the ISRResGraphEx interface is enough to enable the sound editor to provide word break information, but does not provide the necessary support for phoneme information.

The sound editor requires that engines also support a special DWord attribute, **SRATTR\_PHONESEG**. The editor queries the engines to see IAttributes interface and attempts to set the **SRATTR\_PHONESEG** to 1. If that call succeeds, the sound editor assumes that the engine's results will support the gathering of phoneme-segmentation information from results object.

`#define    SRATTR_PHONESEG    MAKELONG (1, SRVEN_MICROSOFT)`

When a results object is transmitted to the sound editor, it queries that object for its implementation of ISRResGraphEx. ISRResGraphEx contains a member function, DataGet, with type signature

`HRESULT  DataGet  (DWord, dwID, GUID gAttrib, SDATA *psData)`

Where **dwID** is the identifier of the graph object, **gAttrib** is a GUID corresponding to the attribute sought, and **psData** is a pointer to an SDATA object containing the data returned. The engine is responsible for allocating the data stored in **psData** through [**CoTaskMemAlloc**](/en-us/windows/desktop/api/combaseapi/nf-combaseapi-cotaskmemalloc). The calling application (in this case the sound editor) is responsible for freeing it through [**CoTaskMemFree**](/en-us/windows/desktop/api/combaseapi/nf-combaseapi-cotaskmemfree) when it is finished.

DataGet is required to recognize three predefined GUIDs, which are listed in the SAPI documentation. An engine which returns a success code to the call to **DWORDSet(SRATTR\_PHONESEG, 1)** is also required to recognize a specific GUID, **SRGARC\_PHONEMESEGMENTATION**, when called with a **dwID** that corresponds to an edge in the graph.

`DEFINE_GUID(SRGARC_PHONMESEGMENTATION, 0xd05405b0, 0x1db1, 0x11d2, 0x94, 0x2, 0x0, 0xc0, 0x4f, 0x8e, 0xf4, 0x8f);`

When the call returns, **psData** should point to an array of DWORD-aligned structure of type **PHONESEG**, defined by:

```syntax
typedef struct tagSRPHONESEG {
   DWORD   dwSize;       // Size of the SRPHONESEG structure + phone data
   QWORD   qwStartTime;  // SAPI timestamp of the start of the seqment
   …QWORD   qwEndTime;    // SAPI timestamp of the end of the seqment
   int      nScore;      // The segment's score
   WCHAR   aPhones[0];   // Array of phone(s) making up the segment
} SRPHONESEG,  *PSRPHONESEG;
```

where **qwStartTime** and **qwEndTime** point to the beginning and end of each phoneme making up the word covered by the edge, and **aPhones** is an array of Unicode characters corresponding to the IPA representation of the phone, which were produced in this segment. (In some languages, there are phonemes which are spelled with more than one IPA phoneme. In English, for instance, the "long I" sound in the word "live" is actually a diphthong, made up of two simpler phonemes concatenated together.) The **aPhones** array should be zero terminated and padded at the end to make each **SRPHONESEG** structure in the array an even multiple of four bytes long.

For example, suppose the word spoken on arc 4 was "made". Then the call to DataGet(4, **SRGARC\_PHONEMESEGMENTATION**, &sd) might return an array of three phoneme segments, /m/ running from **qwStartTime**=328434 bytes to **qwEndTime**=330354 bytes, /1e/ running from **qwStartTime**=330354 bytes to **qwEndTime**=344114 bytes, and /d/ running from **qwStartTime**=344114 bytes to **qwEndTime**=347314 bytes. These would be presented as a packed array of three **SRPHONESEG** structures of sizes 28, 32, and 28 bytes, respectively. Notice that there is some padding at the end of the middle **SRPHONESEG** structure, so that the next item in the array starts at a 4-byte boundary.

The SAPI 4.0 SDK includes a tool (SRFunc) for testing compliance with the SAPI 4.0 spec. Included in that tool is a test for compliance with this set of interfaces. The source code for that tool is a good place to start in order to understand how these interfaces will interact with the sound editor, and to debug the interfaces during development.