---
layout: Conceptual
title: Synthesized Speech Support - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/synthesized-speech-support
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
description: Synthesized Speech Support
ms.assetid: 38172e04-a5b6-41e4-9d7c-539d9d4117be
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: cb972b30-36b9-dc74-b3af-1387244f9408
document_version_independent_id: 9cbce955-5da6-55fd-17a8-33a40b1f73b6
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/synthesized-speech-support.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/synthesized-speech-support.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 431
asset_id: lwef/synthesized-speech-support
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/synthesized-speech-support.md
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/c6f99e62-1cf6-4b71-af9b-649b05f80cce
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/3f56b378-07a9-4fa1-afe8-9889fdc77628
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 46d1e533-8c29-8cf8-5340-a4560a9dee7d
---

# Synthesized Speech Support - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

If you use synthesized speech, your character has the ability to say almost anything, which provides the greatest flexibility. With recorded audio, you can give the character a specific or unique voice. To specify output, provide the spoken text as a parameter of the [**Speak**](speak-method) method.

Because Microsoft Agent's architecture uses Microsoft SAPI for synthesized speech output, you can use any engine that conforms to this specification, and supports International Phonetic Alphabet (IPA) output using the [**Visual**](https://www.bing.com/search?q=**Visual**) method of the [**ITTSNotifySinkW**](ittsnotifysinkw) interface. For further information on the engine requires, see [Speech Engine Support Requirements](requirements-for-text-to-speech-engines).

A character's language ID setting determines its TTS output. If a client does not specify a language ID for the character, the character's language ID is set to the user default language ID. If the character's definition includes a specific engine and that engine can be loaded and it matches the character's language setting, that engine will be used. Otherwise, Microsoft Agent enumerates the other available engines and requests a SAPI best match based on language, gender, and age (in that order). If there is no matching engine available, there is no TTS output for that client's use of the character. Agent attempts to load the TTS engine on the first [**Speak**](speak-method) call or when you query or successfully set its mode ID.

A client application can also specify a TTS engine for its character (using the [**TTSModeID**](ttsmodeid-property) property). This overrides the server's attempt to automatically find a matching engine based on the character's preferred TTS mode ID or the character's current language ID setting. However, if that engine is not installed (or cannot otherwise be loaded), the call will fail (and raise an error in the control). The server then attempts to load another engine based on the language ID, compiled character TTS setting, and available TTS engines. If there is still no match, TTS is not available for that client, but the character can still speak into its word balloon.

Only the TTS engines in use by any client remain loaded. For example, if a character has a defined preference for a specific engine and that engine is available, but your client application has specified a different engine (by setting a character's language ID differently from the engine or specifying a different mode ID), only the engine specified by your application remains loaded. The engine matching the character's defined preference for a TTS setting is unloaded (unless another client is using the character's compiled engine setting).