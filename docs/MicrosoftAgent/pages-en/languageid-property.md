---
layout: Conceptual
title: LanguageID Property - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/languageid-property
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
description: LanguageID Property
ms.assetid: f57b0fa1-b3b8-49c8-b441-2a40e564d6ea
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 6f740300-4803-50d3-afff-74e9e730e926
document_version_independent_id: b769237c-2cf3-1e53-b6a6-259b3561d286
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/languageid-property.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/languageid-property.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 426
asset_id: lwef/languageid-property
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/languageid-property.md
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/c6f99e62-1cf6-4b71-af9b-649b05f80cce
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/3f56b378-07a9-4fa1-afe8-9889fdc77628
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: bed8bcac-a70f-8255-5bab-8503de2cb5b7
---

# LanguageID Property - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Returns or sets the language ID for the character.
- **Syntax**
    - \*agent.\***Characters** **("*CharacterID*").LanguageID** [ = *LanguageID*]

Part

Description

LanguageID

A Long integer specifying the language ID for the character. The language ID (LANGID) for a character is a 16-bit value defined by Windows, consisting of a primary language ID and a secondary language ID. The following examples are values for languages supported by Microsoft Agent. To determine the value for other languages, see the *Platform SDK documentation*.

Arabic

&H0401

Italian

&H0410

Basque

&H042D

Japanese

&H0411

Chinese (Simplified)

&H0804

Korean

&H0412

Chinese (Traditional)

&H0404

Norwegian

&H0414

Croatian

&H041A

Polish

&H0415

Czech

&H0405

Portuguese (Portugal)

&H0816

Danish

&H0406

Portuguese (Brazil)

&H0416

Dutch

&H0413

Romanian

&H0418

English (British)

&H0809

Russian

&H0419

English (US)

&H0409

Slovakian

&H041B

Finnish

&H040B

Slovenian

&H0424

French

&H040C

Spanish

&H0C0A

German

&H0407

Swedish

&H041D

Greek

&H0408

Thai

&H041E

Hebrew

&H040D

Turkish

&H041F

Hungarian

&H040E

## Remarks

If you do not set the **LanguageID** for the character, its language ID will be the current system language ID if the corresponding Agent language DLL is installed, otherwise, the character's language will be English (US).

This property also determines the language for word balloon text, the commands in the character's pop-up menu, and the speech recognition engine. It also determines the default language for TTS output.

If you try to set the **LanguageID** for a character and the Agent language DLL for that language is not installed or a display font for the language ID is not available, Agent raises an error and **LanguageID** remains at its last setting.

Setting this property does not raise an error if there are no matching speech engines for the language. To determine if there is a compatible speech engine available for the **LanguageID**, check [**SRModeID**](srmodeid-property) or [**TTSModeID**](ttsmodeid-property). If you do not set **LanguageID**, it will be set to the user default language ID setting.

This property applies only to your client application's use of the character; the setting does not affect other clients of the character or other characters of your client application.

Note

If you set **LanguageID** to a language that supports bidirectional text (such as Arabic or Hebrew), but the system running your application does not have bidirectional support installed, text in the word balloon will appear in logical rather than display order.