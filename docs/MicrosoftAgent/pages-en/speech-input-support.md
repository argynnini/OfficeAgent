---
layout: Conceptual
title: Speech Input Support - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/speech-input-support
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
description: Speech Input Support
ms.assetid: 4702b941-fcc9-4d00-aba2-eca624b6d417
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 5e24a305-0a17-484b-4d61-5513c6ad19a0
document_version_independent_id: 702cc18d-b377-5706-6cc4-4ace41ff9c87
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/speech-input-support.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/speech-input-support.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 721
asset_id: lwef/speech-input-support
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/speech-input-support.md
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 0e21af84-854e-eaca-cc14-98926bb321eb
---

# Speech Input Support - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

In addition to supporting mouse and keyboard interaction, Microsoft Agent includes direct support for speech input. Because Microsoft Agent's support for speech input is based on Microsoft SAPI (Speech Application Programming Interface), you can use Microsoft Agent with speech recognition command and control engines that include the SAPI-required support. For more information on speech engine requirements, see [Speech Engine Support Requirements](requirements-for-speech-recognition-engines).

Microsoft provides a command-and-control speech recognition engine you can use with Microsoft Agent. For more information, see [Speech Engine Selection](speech-engine-selection).

The user can initiate speech input by pressing and holding the push-to-talk Listening hotkey. In this Listening mode, if the speech engine receives the beginning of spoken input, it holds the audio channel open until it detects the end of the utterance. However, when not receiving input, it does not block audio output. This enables the user to issue multiple voice commands while holding down the key, and the character can respond when the user isn't speaking.

The Listening mode times out once the user releases the Listening key. The user can adjust the time-out for this mode using the Advanced Character Options. You cannot set this time-out from your client application code.

If a character attempts to speak while the user is speaking, the character's audible output fails though text may still be displayed in its word balloon. If the character has the audio channel while the Listening key is pressed, the server automatically transfers control back to the user after processing the text in the [**Speak**](speak-method) method. An optional MIDI tone is played to cue the user to begin speaking. This enables the user to provide input even if the application driving the character failed to provide logical pauses in its output.

You can also use the [**Listen**](listen-method) method to initiate speech input. Calling this method turns on the speech recognition for a predefined period of time. If there is no input during this interval, Microsoft Agent automatically turns off the speech recognition engine and frees up the audio channel. This avoids blocking input to or output from the audio device and minimizes the processor overhead the speech recognition uses when it is on. You can also use the **Listen** method to turn off speech input. However, be aware that because the speech recognition engine operates asynchronously, the effect may not be immediate. As a result, it is possible to receive a [**Command**](command-event) event even after your code called **Listen** to turn off speech input.

To support speech input, you define a *grammar*, a set of words you want the speech recognition engine to listen and match for as the **Voice** setting for a [**Command**](/en-us/windows/desktop/lwef/the-command-object) in your [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection. You can include optional and alternative words and repeated sequences in your grammar. Note that Agent does not enable the Listening hotkey until one of its clients has successfully loaded a speech engine or has authored a **Voice** for one of its **Command** objects.

Whether the user presses the Listening hotkey or your client application calls the [**Listen**](listen-method) method to initiate speech input, the speech recognition engine attempts to match an utterance's input to the grammar for the commands that have been defined, and passes the information back the server. The server then notifies the client application using the [**Command**](command-event) event ([**IAgentNotifySink::Command**](iagentnotifysink--command)); passing back the [**UserInput**](/en-us/windows/desktop/lwef/iagentuserinput) object that includes the command ID of the best match and next two alternative matches (if any), a confidence score, and the matching text for each match.

The server also notifies your client application when it matches the speech input to one of its supplied commands. While the command ID is **NULL**, you still get the confidence score and text matched. When in Listening mode, the server automatically plays the animation assigned to the character's **Listening** state. Then, when an utterance is actually detected, the server plays the character's **Hearing** state animation. The server will keep the character in an attentive state until the utterance has ended. This provides the appropriate social feedback to cue the user for input.

If the user disables speech input in Advanced Character Options, the Listening hotkey will also be disabled. Similarly, attempting to call the [**Listen**](listen-method) method when speech input is disabled will cause the method to fail.