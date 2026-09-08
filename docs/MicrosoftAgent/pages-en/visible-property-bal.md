---
layout: Conceptual
title: Visible Property (Balloon Object) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/visible-property-bal
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
description: Learn about the Visible Property of the Balloon object, which returns or sets the visible setting for the word balloon for the specified character.
ms.assetid: cbda7f69-889a-45a0-9549-d27eddfcec57
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: fd732790-f2b4-083f-01e8-7b9fdd2a2931
document_version_independent_id: 006e9f61-210e-2116-6249-760e2d58deff
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/visible-property-bal.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/visible-property-bal.md
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 228
asset_id: lwef/visible-property-bal
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/visible-property-bal.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 10281de1-d0be-da9f-b3c9-ac8db8b634bf
---

# Visible Property (Balloon Object) - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Returns or sets the visible setting for the word balloon for the specified character.
- **Syntax**
    - *agent*\*\*.Characters(**"*CharacterID*"**).Balloon.Visible\*\* [ = *boolean*]

| Part | Description |
| --- | --- |
| *boolean* | A Boolean expression specifying whether the word balloon is visible.**True** The balloon is visible.**False** The balloon is hidden. |

## Remarks

If you follow a [**Speak**](speak-method) or [**Think**](think-method) call with a statement to attempt to change the balloon's property, it may not affect the balloon's Visible state because the **Speak** or **Think** call gets queued, but the call setting the balloon's visible state does not. Therefore, only set this value when no **Speak** or **Think** calls are in the character's queue.

If you attempt to set this property while the character is speaking, moving, or being dragged, the property setting does not take effect until the preceding operation is completed.

Calling the [**Speak**](speak-method) and [**Think**](think-method) methods automatically makes the balloon visible, setting the [**Visible**](visible-property) property to **True**. If the character's balloon AutoHide property is enabled, the balloon is automatically hidden after the output text is spoken. Clicking or dragging a character that is not currently speaking also automatically hides the balloon even if its AutoHide setting is disabled. You can change the character's AutoHide setting using the balloon's [**Style**](style-property) property.

### See Also

[**Style property**](style-property)