---
layout: Conceptual
title: Microsoft Agent Error Codes - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/microsoft-agent-error-codes
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
description: Microsoft Agent Error Codes
ms.assetid: 39bc203a-c260-46f5-a30a-7324bae2e2cf
ms.topic: error-reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 21247145-d121-4b78-a832-495fc9875859
document_version_independent_id: 6f2e27e4-fc44-66cc-72cd-21a87d1bcb34
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/microsoft-agent-error-codes.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/microsoft-agent-error-codes.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 1162
asset_id: lwef/microsoft-agent-error-codes
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/microsoft-agent-error-codes.md
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 125b83c2-131e-310d-4b5c-bfe3e36715f3
---

# Microsoft Agent Error Codes - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

Microsoft Agent returns the following error information:

| Error Number | Hex Value | Description |
| --- | --- | --- |
| -2147213311 | 0x80042001 | The specified Microsoft Agent client was not found. |
| -2147213310 | 0x80042002 | The character ID is not valid. Verify that the ID has been defined and is spelled correctly. |
| -2147213309 | 0x80042003 | The specified animation is not supported. Verify that the animation name is correct. |
| -2147213308 | 0x80042004 | No animation exists for this state. Verify that an animation has been assigned to this state. |
| -2147213306 | 0x80042006 | The command name was not found. Verify that the command name you specified is correct. |
| -2147213305 | 0x80042007 | The specified command name parameter has already been defined. |
| -2147213304 | 0x80042008 | The specified Microsoft Agent client was not found. |
| -2147213302 | 0x8004200A | The specified method failed because the character is hidden. |
| -2147213301 | 0x8004200B | The character is already loaded. Check for previous [**Load**](load-method) method calls. |
| -2147213300 | 0x8004200C | The current character's settings do not support a word balloon. |
| -2147213299 | 0x8004200D | The Voice Commands Window cannot be displayed because speech input support has not been completely defined for this character. Verify that speech input is enabled and that there is a speech recognition engine and voice commands defined for the character. |
| -2147213298 | 0x8004200E | The [**Get**](stop-method) method was specified with an invalid Type parameter. Verify that the type you specified is supported and spelled correctly. |
| -2147213297 | 0x8004200F | The specified animation is not valid. It may be damaged or has no frames. |
| -2147213296 | 0x80042010 | A character cannot be moved while it is being dragged. |
| -2147213295 | 0x80042011 | The specified operation failed because it requires the character to be active. |
| -2147213294 | 0x80042012 | The specified language for the character is not supported on this computer. |
| -2147213293 | 0x80042013 | The specified speech engine could not be found, the speech engine does not match the specified language for the character, or speech audio output is currently disabled. |
| -2147213292 | 0x80042014 | The specified speech engine could not be found, The speech engine does not match the specified language for the character, or speech input is currently disabled. |
| -2147213291 | 0x80042015 | The specified engine mode ID does not support the current language for the character. |
| -2147213290 | 0x80042016 | The specified operation failed because spoken audio output for all characters has been disabled in the Advanced Character Options. |
| -2147213289 | 0x80042017 | There are no standard characters installed on this system. |
| -2147213288 | 0x80042018 | The default character and other characters cannot be loaded at the same time by a single control. |
| -2147213055 | 0x80042101 | The Request object was not found. The Request object no longer exists in the character's animation queue. |
| -2147213054 | 0x80042102 | The specified Request object is not valid. |
| -2147213053 | 0x80042103 | The [**Stop**](stop-method) method was used incorrectly. A character cannot use the [**Stop**](stop-method) method to interrupt another character. Try the Interrupt method. |
| -2147213052 | 0x80042104 | The Interrupt method was used incorrectly. A character cannot interrupt itself. |
| -2147213051 | 0x80042105 | A character cannot wait on its own requests. |
| -2147213050 | 0x80042106 | The specified bookmark is invalid. Make sure the bookmark specified is not reserved by Microsoft Agent. |
| -2147213048 | 0x80042108 | The specified Request object was removed from the character queue. |
| -2147213046 | 0x8004210A | The operation was interrupted because the Listening key was pressed. |
| -2147213045 | 0x8004210B | The operation was interrupted because of spoken input. |
| -2147213044 | 0x8004210C | The operation was interrupted by the application. |
| -2147213043 | 0x8004210D | The operation was interrupted because the character was hidden. |
| -2147213042 | 0x8004210E | The [Lst](lst-tag) speech tag cannot be used with additional text or a URL. |
| -2147212799 | 0x80042201 | The Microsoft Agent Data Provider was not able to start. |
| -2147212798 | 0x80042202 | The specified character data file version is not supported by the installed version of Microsoft Agent. You need to update the character. |
| -2147212797 | 0x80042203 | The version of Microsoft Agent installed is older than the specified character file. Verify that you have the correct version of Microsoft Agent installed. |
| -2147212796 | 0x80042204 | The specified file is not a Microsoft Agent character file. Verify the file name is correct. |
| -2147212795 | 0x80042205 | The character ID is not valid. Verify that the ID has been correctly defined and is spelled correctly. |
| -2147212794 | 0x80042206 | The specified file is not a valid sound (.WAV) file. |
| -2147212793 | 0x80042207 | The specified sound file is not valid or does not include the correct data. |
| -2147212792 | 0x80042208 | There was a problem in accessing the system's multimedia component. |
| -2147212791 | 0x80042209 | Microsoft Agent does not support the specified URL protocol. |
| -2147212543 | 0x80042301 | The audio device cannot be accessed. Verify that the sound card and drivers are correctly installed. |
| -2147212542 | 0x80042302 | Microsoft Agent could not find any compatible speech recognition engines. |
| -2147212540 | 0x80042304 | There is a problem in the specified Commands object definition. |
| -2147212539 | 0x80042305 | The text for the Voice property of a command is either missing a right parenthesis or includes a misplaced left parenthesis. |
| -2147212538 | 0x80042306 | The text for the Voice property of a command is missing a right square bracket or includes a misplaced left square bracket. |
| -2147212537 | 0x80042307 | The text for the Voice property of a command is missing a left parenthesis, includes a misplaced right parenthesis, or has no text between parentheses. |
| -2147212536 | 0x80042308 | The text for the Voice property of a command is missing a left square bracket, includes a misplaced right square bracket, or has no text between square brackets. |
| -2147212535 | 0x80042309 | The text for the Voice property of a command is missing surrounding parentheses or square brackets for specifying alternative text. |
| -2147212534 | 0x8004230A | There was a problem in accessing the speech recognition mode. Verify that the speech engine is correctly installed. |
| -2147212287 | 0x80042401 | The audio device cannot be accessed. Verify that the sound card and drivers are correctly installed. |
| -2147212286 | 0x80042402 | The text-to-speech (TTS) engine cannot be started. |
| -2147212285 | 0x80042403 | The text-to-speech (TTS) engine cannot be started. |
| -2147212284 | 0x80042404 | The text-to-speech (TTS) engine cannot be started. |
| -2147212283 | 0x80042405 | The text-to-speech (TTS) engine cannot be started. |
| -2147212282 | 0x80042406 | The Microsoft Agent lip sync component failed. |
| -2147212281 | 0x80042407 | The Microsoft Agent lip sync component failed. |
| -2147212280 | 0x80042408 | The Microsoft Agent lip sync component failed. |
| -2147212030 | 0x80042502 | Microsoft Agent was unable to start. Verify that Microsoft Agent is properly installed. |
| -2147024894 | 0x80070002 | The system cannot find the file specified.\* |
| -2147024883 | 0x8007000D | The data is invalid.\* |
| -2147023436 | 0x800705B4 | This operation returned because the timeout period expired. \* |
| -2146697214 | 0x800C0002 | Invalid URL.\* Please verify that the specified URL exists and is correct. |
| -2146697212 | 0x800C0004 | Server access failure.\* The attempt to connect with the server failed. Please verify that the server is running and available. |
| -2146697210 | 0x800C0006 | File not found.\* The file could not be found at the specified URL. Please make sure the URL is correct. |
| -2146697205 | 0x800C000B | Server connection time-out.\* The connection to the server timed out. Please verify that the server is running and available. |
| -2146697202 | 0x800C000E | Server security access failure.\* There was a security problem when accessing the server. |

\* Errors whose descriptions include an asterisk are Windows system errors. They are provided here because they may commonly occur in Agent-enabled applications. For information on other errors not included here, see the Platform SDK documentation.