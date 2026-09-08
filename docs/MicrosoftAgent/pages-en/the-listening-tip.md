---
layout: Conceptual
title: The Listening Tip - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/the-listening-tip
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
description: The Listening Tip
ms.assetid: d363c1ac-53fc-4b93-b056-63eeee923380
ms.topic: concept-article
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 44133598-3b37-bb3a-c65d-fc8c2f02e9f1
document_version_independent_id: 97266942-8c87-324a-e9ba-c4504e9b63b6
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/the-listening-tip.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/the-listening-tip.md
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 917
asset_id: lwef/the-listening-tip
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/the-listening-tip.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: f1c1954e-a139-4458-7bf3-88673237bde0
---

# The Listening Tip - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

The Listening Tip is another speech input service provided by Microsoft Agent. When speech input is installed, Agent includes a special tooltip window that appears when the user presses the Listening hotkey or calls the Listen method. The Listening Tip appears only when the speech services are available. If no client has authored a voice command or successfully loads a speech engine, the Listening Tip does not appear. Further, both speech input and the Display Listening Tips option in the Advanced Character Options must be enabled for the tip to appear.

The following table summarizes the display of the Listening Tip when speech recognition is enabled.

| Action | Result |
| --- | --- |
| User presses the Listening mode hotkey or input-active calls the [**Listen**](listen-method) method | The Listening Tip appears below the active client's character and displays:  -- *CharacterName* is listening --  for "*InputActiveClientCommandsVoiceCaption*" commands. If the client hasn't defined a VoiceCaption its Commands object, the value of its Caption property is used. The first line identifying the character is centered. The second line is left justified and breaks to a third line when it exceeds the Listening Tip's maximum width. If an input-active client of the character does not have a caption or defined voice parameters for its Commands object, the Listening Tip displays: -- *CharacterName* is listening --  for commands. If there are no visible characters, the Listening Tip appears adjacent to the character's taskbar icon and displays: -- *CharacterName* is listening --  Say the name of a character to display it. If the speech recognition is still initializing, the Listening Tip displays: -- *CharacterName* is preparing to listen --  Please wait to speak. If the audio channel is busy, as when the character is audibly speaking or some other application is using the audio channel, the Listening Tip displays: -- *CharacterName* is not listening --  for "*InputActiveClientCommandsVoiceCaption*" commands. If there is no language-compatible speech engine installed for the input-active client's character, the Listening Tip displays the following, where *Language* represents the selected language of the character: -- *CharacterName* is not listening -  Speech input is not available in *Language*. If the audio device is not available for other reasons, such as when it is busy or there is some error in attempting to open the audio device, the following tip appears when the Listening mode is activated: -- *CharacterName* is not listening -  Speech input not available. If the input-active client application has not defined any Voice settings for commands and has also disabled voice parameters for Agent's global commands, this tip appears:*CharacterName* is not listening -  No voice commands. If all characters are hidden, the Listening Tip displays the following text:*CharacterName* is listening -  Say the name of a character to display it. |
| User speaks a voice command | If the spoken text matches a client- or server-defined command, the Listening Tip appears below the active client's character and displays:  -- *CharacterName* is listening -  Heard "*CommandText*" However, when a recognition is passed back and the Listening mode has timed out, but the Listening Tip time-out has not, or if the Listening mode is still in effect, but the audio channel is not yet available (for example, the user is still holding the Listening key or the Listening mode has not timed out, because the character is speaking), the Listening Tip displays:*CharacterName* is not listening -  Heard "*text heard*" When the spoken text matches a server-defined command, but the server does not act on it because the command has a low confidence score, the second line of the Listening Tip displays: Didn't understand your request. The first line is centered. The second line is left-justified and breaks to a third line when it exceeds the Listening Tip's maximum width. |

The Listening Tip automatically times out after being presented. If the "Heard" text time-out completes while the user is still holding down the hotkey, the tip reverts to the "listening" text unless the server receives another matching utterance. In this case, the tip displays the new "Heard" text and begins the time-out for that tip text. If the user releases the hotkey and the server is displaying the "Heard" text, the time-out continues and the Listening Tip window is hidden when the time-out interval elapses.

If the server has not yet attempted to load a speech recognition engine, the Listening Tip will not display. Similarly, if the user has disabled the display of the Listening Tip or disabled speech input in Advanced Character Options, the Listening Tip will not be displayed.

The Listening Tip does not appear when the pointer is over the character's taskbar icon. Instead, the standard notification tip window appears and displays the character's name.

Client applications cannot write directly to the Listening Tip, but you can specify alternative text that the server displays on recognition of a matching voice command. To do this, set the [**Confidence**](confidence-property) property and the new [**ConfidenceText**](confidencetext-property)property for the command. If spoken input matches the command, but the best match does not exceed the confidence setting, the server uses the text set in the **ConfidenceText** property in the tip window. If the client does not supply this value, the server displays the text (grammar) it matched.

The Listening Tip text appears in the language based on the input-active client's character language ID setting, regardless of whether there is a language-compatible speech recognition engine available.