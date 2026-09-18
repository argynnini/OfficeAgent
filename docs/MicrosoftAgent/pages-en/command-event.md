---
layout: Conceptual
title: Command Event - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/command-event
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
description: Command Event
ms.assetid: 3e180286-dfa0-4b34-90ee-3267ed6f48af
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 7f31f97d-c211-353a-2959-4edd6f786f10
document_version_independent_id: 03ee5014-c265-db2a-4f31-6c9d9e71d5ae
updated_at: 2025-03-13T17:42:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/command-event.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/command-event.md
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 538
asset_id: lwef/command-event
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/command-event.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: be684f39-93f6-5a73-f593-bf34950ce048
---

# Command Event - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

- **Description**
    - Occurs when the user chooses a (client's) command.
- **Syntax**
    - **Sub***agent*\_**Command** **(ByVal***UserInput*\*\*)\*\*

| Part | Description |
| --- | --- |
| *UserInput* | Identifies the [**Command**](/en-us/windows/desktop/lwef/the-command-object) object returned by the server.  The following properties can be accessed from the [**Command**](/en-us/windows/desktop/lwef/the-command-object) object: CharacterID  A string value identifying the name (ID) of the character that received the command. [**Name**](name-property) A string value identifying the name (ID) of the command.[**Confidence**](confidence-property) A Long integer value indicating the confidence scoring for the command. [**Voice**](voice-property) A string value identifying the voice text for the command. Alt1Name  A string value identifying the name of the next (second) best command. Alt1Confidence  A Long integer value indicating the confidence scoring for the next (second) best command. Alt1Voice  A string value identifying the voice text for the next best alternative command match. Alt2Name  A string value identifying the name of third best command match. Alt2Confidence  A Long integer identifying the confidence scoring for the third best command match. Alt2Voice  A string value identifying the voice text for the third best command match.[**Count**](count-property) Long integer value indicating the number of alternatives returned. |

### Remarks

The server notifies you with this event when your application is input-active and the user chooses a command by spoken input or character's pop-up menu. The event passes back the number of possible matching commands in [**Count**](count-property) as well as the name, confidence scoring, and voice text for those matches.

If voice input triggers this event, the server returns a string that identifies the best match in the [**Name**](name-property) parameter, and the second- and third-best match in Alt1Name and Alt2Name . An empty string indicates that the input did not match any command your application defined; for example, it could be one of the server's defined commands. If the command was matched to the Agent's command; for example, Hide, an empty string would be returned in the **Name** parameter, but you would still receive the text heard in the [**Voice**](voice-property) parameter.

You may get the same command name returned in more than one entry. [**Confidence**](confidence-property), Alt1Confidence , and Alt2Confidence parameters return the relative scores, in the range of -100 to 100, that are returned by the speech recognition engine for each respective match. [**Voice**](voice-property), Alt1Voice , and Alt2Voice parameters return the voice text that the speech recognition engine matched for each alternative. If [**Count**](count-property) returns zero (0), the server detected spoken input, but determined that there was no matching command.

If voice input was not the source for the command, for example, if the user selected the command from the character's pop-up menu, the server returns the name (ID) of the command selected in the [**Name**](name-property)property. It also returns the value of the [**Confidence**](confidence-property) parameter as 100, and the value of the [**Voice**](voice-property) parameters as the empty string (""). Alt1Name and Alt2Name also return empty strings. Alt1Confidence and Alt2Confidence return zero (0), and Alt1Voice and Alt2Voice return empty strings. [**Count**](count-property) returns 1.

Note

Not all speech recognition engines may return all the values for all the parameters of this event. Check with your engine vendor to determine whether the engine supports the Microsoft Speech API interface for returning alternatives and confidence scores.