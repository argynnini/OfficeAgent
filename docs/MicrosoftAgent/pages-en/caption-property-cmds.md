---
layout: Conceptual
title: Caption Property (Commands Collection Object) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/caption-property-cmds
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
description: Learn about the Caption property of the Command Collection object. Microsoft Agent is deprecated as of Windows 7.
ms.assetid: 7182c21e-1ff0-4dce-9571-534b7576c082
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: b59f47fe-b6d2-6748-cdd5-f1e681e94b7b
document_version_independent_id: 2323bb6e-328b-0186-8989-552dbfdf612e
updated_at: 2025-03-13T17:42:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/caption-property-cmds.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/caption-property-cmds.md
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 134
asset_id: lwef/caption-property-cmds
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/caption-property-cmds.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: ead1f96d-7610-fa0a-197f-97e290bb3200
---

# Caption Property (Commands Collection Object) - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Determines the text displayed for a [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) object in the character's pop-up menu.
- **Syntax**
    - *agent*\*\*.Characters ("***CharacterID***").\*\*[Commands.Caption](caption-property) [ = *string*]

| Part | Description |
| --- | --- |
| *string* | A string expression that evaluates to the text displayed as the caption. |

## Remarks

Setting the [**Caption**](caption-property) property for your [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection defines how it will appear on the character's pop-up menu when its [**Visible**](visible-property) property is set to True and your application is not the input-active client. To specify an access key (unlined mnemonic) for your **Caption**, include an ampersand (&) character before that character.

If you define commands for a [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection that has a [**Caption**](caption-property), you typically also define a **Caption** for its associated **Commands** collection.