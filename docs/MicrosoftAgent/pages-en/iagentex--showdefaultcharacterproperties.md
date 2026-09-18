---
layout: Conceptual
title: IAgentEx ShowDefaultCharacterProperties - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentex--showdefaultcharacterproperties
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
description: IAgentEx ShowDefaultCharacterProperties
ms.assetid: 4817b52a-7168-4008-9cda-0b8d598daea0
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: d876d1d9-0ed6-d70c-5718-881715340d12
document_version_independent_id: 41322134-d83e-383d-2783-ecebf1f41694
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentex--showdefaultcharacterproperties.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentex--showdefaultcharacterproperties.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 151
asset_id: lwef/iagentex--showdefaultcharacterproperties
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentex--showdefaultcharacterproperties.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 8bb0ae72-f095-b22c-d022-e31aa2768025
---

# IAgentEx ShowDefaultCharacterProperties - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT ShowDefaultCharacterProperties(
   short x,          // x-coordinate of window
   short y,          // y-coordinate of window
   long bUseDefault  // default position flag
);
```

Displays default character properties window.

- Returns S\_OK to indicate the operation was successful.

- *x*
    - The x-coordinate of the window in pixels, relative to the screen origin (upper left).
- *y*
    - The y-coordinate of the window in pixels, relative to the screen origin (upper left).
- *bUseDefault*
    - Default position flag. If this parameter is **True**, Microsoft Agent displays the property sheet window for the default character at the last location it appeared.

Note

For Windows 2000, it may be necessary to call the new [**AllowSetForegroundWindow**](/en-us/windows/desktop/api/winuser/nf-winuser-allowsetforegroundwindow) API to ensure that this window becomes the foreground window. For more information about setting the foreground window under Windows 2000, see the Platform SDK documentation.