---
layout: Conceptual
title: IAgentCharacterEx GetHelpFileName - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcharacterex--gethelpfilename
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
description: IAgentCharacterEx GetHelpFileName
ms.assetid: 52d5a874-ad3e-4833-9e3e-ff485414c54c
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: ce2a5a71-9fbb-6fef-5b0c-91326acb7959
document_version_independent_id: c8cd8b46-8cac-c766-0efb-022ef62dfdf0
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacterex--gethelpfilename.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacterex--gethelpfilename.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 175
asset_id: lwef/iagentcharacterex--gethelpfilename
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcharacterex--gethelpfilename.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 3b9a13b3-be43-81b7-17b0-0036d600ea57
---

# IAgentCharacterEx GetHelpFileName - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT GetHelpFileName(
   BSTR * pbszName  // address of Help filename
);
```

Retrieves the HelpFileName for a character.

- Returns S\_OK to indicate the operation was successful.

- *pbszName*
    - Address of a variable that receives the Help filename for the character.

If you've created a Windows Help file for your application and set the character's [**HelpFile**](helpfile-property) property, Microsoft Agent automatically calls Help when [**HelpModeOn**](helpmodeon-property) is set to **True** and the user clicks the character or selects a command from its pop-up menu. If there is a context number in the selected command's [**HelpContextID**](helpcontextid-property) property, Help displays a topic corresponding to the current Help context; otherwise it displays "No Help topic associated with this item."

This property applies only to your client application's use of the character; the setting does not affect other clients of the character or other characters of your client application.

Note

Building a Help file requires the Microsoft Windows Help Compiler.