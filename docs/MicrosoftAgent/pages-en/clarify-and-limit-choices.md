---
layout: Conceptual
title: Clarify and Limit Choices - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/clarify-and-limit-choices
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
description: Clarify and Limit Choices
ms.assetid: 4ec3ca01-231b-4a45-aae1-fba5b2ba0033
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: af236765-c5cf-5bb4-55f7-c8da0e016ab5
document_version_independent_id: e056c1e9-6ea9-e7ad-0ef9-925fadc04a1a
updated_at: 2025-03-13T17:42:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/clarify-and-limit-choices.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/clarify-and-limit-choices.md
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 986
asset_id: lwef/clarify-and-limit-choices
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/clarify-and-limit-choices.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 0efbd0eb-2d6e-44fe-d461-bf77359143ea
---

# Clarify and Limit Choices - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

Speech recognition becomes more successful when the user learns the range of appropriate grammar. It also works better when the range of choices is limited. The less open-ended the input, the better the speech engine can analyze the acoustic information input.

Microsoft Agent includes several built-in provisions that increase the success of speech input. The first is the Commands Window displayed when the user says, "Open Commands Window," or "What can I say?" (or when the user chooses Open Commands Window from the character's pop-up menu). The Command Window serves as a visual guide to the active grammar of the speech engine. It also reduces recognition errors by activating only the speech grammar of the input-active application and Microsoft Agent's global commands. Therefore, the active grammar of the speech engine applies to the immediate context. For more information on the Commands Window, see [Microsoft Agent Programming Interface Overview](microsoft-agent-programming-interface-overview).

When you create Microsoft Agent voice-enabled commands, you can author the caption text that appears in Commands Window as well as its voice text (grammar), the words that the engine should use for matching this command. Always try to make your commands as distinctive as possible. The greater the difference between the wording of commands, especially for the voice text, the more likely the speech engine will be able to discriminate between spoken commands and provide an accurate match. Also avoid single-word or very short commands. Generally, more acoustic information in a spoken utterance gives the engine a better chance to make an accurate match.

When defining the voice text for a command, provide a reasonable variety of wording. Requests that mean the same thing can be phrased very differently, as illustrated in the following example:

Add some pepperoni.

I'd like some pepperoni.

Could you add some pepperoni?

Pepperoni, please.

Microsoft Agent enables you to easily specify alternatives or optional words for the voice grammar for your application. You enclose alternative words or phrases between parentheses, separated by a vertical bar character. You can define optional words by enclosing them between square bracket characters. You can also nest alternatives or optional words. In addition, you can also use an ellipsis (...) in voice text as a placeholder for any word. However, using ellipses too frequently may make it more difficult for the engine to distinguish between different voice commands. In any case, always make sure that your voice text includes at least one distinctive word for each command that is not optional. Typically, this should match a word or words in the caption text you define that appears in the Commands Window.

Although you can include symbols, punctuation, or abbreviations in your caption text, avoid them in your voice text. Many speech recognition engines cannot handle symbols and abbreviations or may use them to set special input parameters. In addition, spell out numbers. This also ensures more reliable recognition support.

You can also use directive prompts to avoid open-ended input. Directive prompts implicitly reference the choices or explicitly state them, as shown in the following examples:

| Prompt | Evaluation |
| --- | --- |
| What do you want? | Too general, an open-ended request |
| Choose a pizza style or ingredient. | Good, if choices are visible, but still general |
| Say "Hawaiian," "Chicago," or "The Works." | Better, an explicit directive with specific options |

This guides the user toward issuing a valid command. By suggesting the words or phrase, you are more likely to elicit expected wording in return. To avoid unnatural repetitiveness, change the wording or shorten the original for subsequent presentation as the user becomes more experienced with the input style. Directive prompts can also be used in situations where the user fails to issue a command within a prescribed time or fails to provide an expected command. Directive prompts can be provided using speech output, your application interfaces, or both. The key is helping the user know the appropriate choices.

Wording influences the success of a prompt. For example, the prompt, "Would you like to order your pizza?" could generate either a "Yes" or "No" response, but it might also generate an order request. Define prompts to be non-ambiguous or be prepared to accept a larger variety of possible responses. In addition, note the tendency for people to mimic words and constructs they hear. This can often be used to help evoke an appropriate response as in the following example:

**User:** Show me all messages from Paul.

**Character:**

This is more likely to elicit the full name of one of the parties with the possible prefix of "I mean" or "I meant."

Because Microsoft Agent characters operate within the visual interface of Microsoft Windows, you can use visual elements to provide directive prompts for speech input. For example, you can have the character gesture at a list of choices and request that the user select one, or display choices in a dialog box or message window. This has two benefits: it explicitly suggests the words you want the user to speak and it provides an alternate way for the user to reply.

You can also use other modes of interaction to subtly suggest to users the appropriate speech grammar, as shown in the following example:

**User:** (Clicks Hawaiian-style pizza option with the mouse)

**Character:** Hawaiian-style pizza.

**User:** (Clicks Extra Cheese option with the mouse)

**Character:** Add "Extra Cheese."

Another important factor in successful speech input is cueing the user when the engine is ready for input, because many speech engines allow only a single utterance at a time. Microsoft Agent provides support for this in two ways. First, if the sound card supports MIDI, Microsoft Agent generates a brief tone to signal when the speech-input channel is available. Second, the Listening Tip window displays an appropriate text prompt when the character (speech engine) is listening for input. In addition, this tip displays what the engine heard.