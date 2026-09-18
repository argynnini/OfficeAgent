---
layout: Conceptual
title: Microsoft Agent Changes in Windows Vista - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/microsoft-agent-changes-in-windows-vista
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
description: Microsoft Agent Changes in Windows Vista
ms.assetid: 2498e8d5-2274-477c-a807-77443c76afb7
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: ce40749e-e8ce-8af6-33c9-b3cbe0514f6b
document_version_independent_id: 17d24cb0-530c-95d3-ebc3-f3145661e6ea
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/microsoft-agent-changes-in-windows-vista.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/microsoft-agent-changes-in-windows-vista.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 541
asset_id: lwef/microsoft-agent-changes-in-windows-vista
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/microsoft-agent-changes-in-windows-vista.md
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 7124db36-426a-6da4-2819-94fd0f09d53c
---

# Microsoft Agent Changes in Windows Vista - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

Windows Vista introduces some changes in how speech and speech recognition interact with Windows Vista.

Microsoft Agent now supports SAPI 5 Text-to-Speech and Speech Recognition components. The TTSModeID and SRModeID properties of the Agent object are still used to determine which voice or recognizer is selected for the agent and to alter this selection. SAPI 4 modes appear as GUID strings such as "{ca141fd0-ac7f-11d1-97a3-006008273000}", while SAPI 5 tokens (equivalent to modes) appear as regular names, such as "Microsoft Anna". As in earlier releases, the agent will make a default choice of TTS and SR engines. If SAPI 5 engines are installed then these will always be preferred over any SAPI 4 engines that may be installed. The user's default Text-to-Speech engine, as specified in the control panel, is used if its gender matches that of the character, otherwise a SAPI 5 engine of the same gender is chosen if one is available. Mode ids specified directly on the character are ignored if SAPI 5 engines are present. The default selections can be verified by reading the TTSModeID and SRModeID properties at the beginning of your script.

As before, TTSModeID and SRModeID will return a blank string if the Text-to-Speech or Speech Recognition capability is not present. A specific voice or recognizer can be selected by setting these properties to the appropriate SAPI 4 mode string or SAPI 5 token name. After setting a specific mode or token, you can also read the property back again to verify that its value has taken, which indicates that the new mode or token was indeed available, and was successfully selected. For developers deploying Agent over the web, please note that many Vista users will have one or more SAPI 5 voices installed already, so you may want to avoid auto-downloading SAPI 4 voices unless your script specifically requests them, as the downloaded voice would not end up being used.

SAPI 5 Text-to-Speech engines use a different set of standards than SAPI 4 for annotating speech with markup, for example to change the pitch or rate of the speech. In SAPI 4 you use "slash" commands, such as /pit=170/. In SAPI 5 you use XML tags, such as &lt;PITCH MIDDLE="5"/&gt;. In Vista, Agent will accept both types of annotations in Speak method strings "slash" commands will be ignored by SAPI 5 engines, and XML tags will be ignored by SAPI 4 engines. As with slash tags, support for SAPI 5 XML tags varies from vendor to vendor, and some vendors may support additional tags. For more information on SAPI 5 XML tags, please see the SAPI 5 Specification.

Agent no longer includes support for multiple languages. The language used by Agent is always assumed to be the user's current language, as registered with the operating system. The LanguageID property of the Agent object is still writable, but its value is ignored by Agent on Vista. For example if the user's language is set to US English (&H0409), and he or she uses a program that sets the LanguageID to French (&H040C), then the voice tip text, and Advanced Character Options dialogs will still appear in English.