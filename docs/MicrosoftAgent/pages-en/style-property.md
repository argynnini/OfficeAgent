---
layout: Conceptual
title: Style Property - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/style-property
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
description: Style Property
ms.assetid: f01d7d51-8a16-4265-b9b7-93b64f4984e3
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: f33755a3-06bf-6758-9048-6b89e3c35509
document_version_independent_id: 70e3d192-22bd-4621-900b-3112283675f1
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/style-property.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/style-property.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 660
asset_id: lwef/style-property
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/style-property.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 22eb21d5-3313-7630-161b-9ae9cdc8d8da
---

# Style Property - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Returns or sets the character's word balloon output style.
- **Syntax**
    - \*agent.\***Characters("*CharacterID*").Balloon.Style** [ = *Style*]

| Part | Description |
| --- | --- |
| *Style* | An integer that represents the balloon's output style. The style setting is a bitfield with bits corresponding to: balloon-on (bit 0), size-to-text (bit 1), auto-hide (bit 2), auto-pace (bit 3), number of characters per lines (bits 16-23), and number of lines (bits 24-31). |

## Remarks

When the balloon-on style bit is set to 1, the word balloon appears when a [**Speak**](https://www.bing.com/search?q=**Speak**) or [**Think**](think-method) method is used, unless the user overrides this setting in the Microsoft Agent property sheet. When set to 0, a balloon does not appear.

When the size-to-text style bit is set to 1, the word balloon automatically sizes the height of the balloon to the current size of the text for the [**Speak**](https://www.bing.com/search?q=**Speak**) or [**Think**](think-method) statement. When set to 0, the balloon's height is based on the [**NumberOfLines**](numberoflines-property) property setting. If this style bit is set to 1 and you attempt to set the **NumberOfLines** property, Agent raises an error.

When the auto-hide style bit is set to 1, the word balloon automatically hides when spoken output completes. When set to 0, the balloon remains displayed until the next [**Speak**](https://www.bing.com/search?q=**Speak**) or [**Think**](think-method) call, the character is hidden, or the user clicks or drags the character.

When the auto-pace style bit is set to 1, the word balloon paces the output based on the current output rate, for example, one word at a time. When output exceeds the size of the balloon, the former text is automatically scrolled. When set to 0, all text included in a [**Speak**](https://www.bing.com/search?q=**Speak**) or [**Think**](think-method) statement is displayed at once.

To retrieve just the value of the bottom four bits, **And** the value returned by **Style** with 255. To set a bit value, **Or** the value returned with the value of the bits you want set. To turn a bit off, **And** the value returned with one's complement of the bit:

```
   Const BalloonOn = 1

   ' Turn the word balloon off
   Genie.Balloon.Style = Genie.Balloon.Style And (Not BalloonOn)
   Genie.Speak "No balloon"

   ' Turn the word balloon on
   Genie.Balloon.Style = Genie.Balloon.Style Or BalloonOn
   Genie.Speak "Balloon"
```

The **Style** property also returns the number of characters per line in the lower byte of the upper word and the number of lines in the high byte of the upper word. While this can be more easily read using the [**CharsPerLine**](charsperline-property) and [**NumberOfLines**](numberoflines-property)properties, the **Style** property also enables you to set those values.

For example, to change the number of lines, clear bits 24 to 31 with a logical **AND** operation before setting the new value as the product of the new value times 2^24, added to the existing value of the **Style** property.

```
   ' Set the number of lines to 4
   Genie.Balloon.Style = (Genie.Balloon.Style <b>AND</b> &amp;H00FFFFFF) + (4*(2^24))
```

To set the number of characters per line, clear bits 16 to 23 with a logical **AND** operation before setting the new value as the product of the new value times 2^16, added to the existing value of the Style property.

```
   ' Set the number of characters per line to 16
   Genie.Balloon.Style = (Genie.Balloon.Style AND &amp;HFF00FFFF) + (16*(2^16))
```

The **Style** property can be set even if the user has disabled balloon display using the Microsoft Agent property sheet. However, the values for the number of lines must be between 1 and 128 and the number characters per line must be between 8 and 255. If you provide an invalid value for the **Style** property, Agent will raise an error.

This property applies only to your client application's use of the character; the setting does not affect other clients of the character or other characters of your client application.

The defaults for these style bits are based on their settings when the character is compiled with the Microsoft Agent Character Editor.