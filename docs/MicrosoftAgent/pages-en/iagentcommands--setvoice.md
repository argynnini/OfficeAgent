---
layout: Conceptual
title: IAgentCommands SetVoice - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcommands--setvoice
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
description: IAgentCommands SetVoice
ms.assetid: dfb3b58a-7f24-4366-8f04-93a9e956fdc8
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 1b194228-8e03-76bf-9d45-6dabb41c22e5
document_version_independent_id: c544f87d-0be0-99ed-c473-104868aa09fc
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommands--setvoice.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentcommands--setvoice.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 996
asset_id: lwef/iagentcommands--setvoice
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcommands--setvoice.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 633b72e5-fffa-6d94-c441-b8488ccb6426
---

# IAgentCommands SetVoice - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT SetVoice(
   BSTR bszVoice  // the Voice setting for Command collection
);
```

Sets the [**Voice**](voice-property) text property for a [**Command**](/en-us/windows/desktop/lwef/the-command-object).

- Returns S\_OK to indicate the operation was successful.

- *bszVoice*
    - A BSTR that specifies the value for the [**Voice**](voice-property) text property of a [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection.

A [**Commands**](/en-us/windows/desktop/lwef/the-commands-collection-object) collection must have its [**Voice**](voice-property) text property set to be voice-accessible. It also must have its [**VoiceCaption**](voicecaption-property) or [**Caption**](caption-property) property set to appear in the Voice Commands Window and its [**Visible**](visible-property) property set to **True** to appear on the character's pop-up menu.

The BSTR expression you supply can include square bracket characters ([ ]) to indicate optional words and vertical bar characters (|) to indicate alternative strings. Alternates must be enclosed in parentheses. For example, "(hello [there] | hi)" tells the speech engine to accept "hello," "hello there," or "hi" for the command. Remember to include appropriate spaces between words you include in brackets or parentheses as well as other text. Remember to include appropriate spaces between the text that's in brackets or parentheses and the text that's not in brackets or parentheses.

You can use the star (\*) operator to specify zero or more instances of the words included in the group or the plus (+) operator to specify one or more instances. For example, the following results in a grammar that supports "try this", "please try this", and "please please try this", with unlimited iterations of "please":

```syntax
   "please* try this"
```

The following grammar format excludes "try this" because the + operator defines at least one instance of "please":

```syntax
   "please+ try this"
```

The repetition operators follow normal rules of precedence and apply to the immediately preceding text item. For example, the following grammar results in "New York" and "New York York", but not "New York New York":

```syntax
   "New York+"
```

Therefore, you typically want to use these operators with the grouping characters. For example, the following grammar includes both "New York" and "New York New York":

```syntax
   "(New York)+"
```

Repetition operators are useful when you want to compose a grammar that includes a repeated sequence such as a phone number or specification of a list of items:

```syntax
   "call (one|two|three|four|five|six|seven|eight|nine|zero|oh)*"
   "I'd like (cheese|pepperoni|pineapple|canadian bacon|mushrooms|and)+"
```

Although the operators can also be used with square brackets (an optional grouping character), doing so may reduce the efficiency of Agent's processing of the grammar.

You can also use an ellipsis (...) to support *word spotting*, that is, telling the speech recognition engine to ignore words spoken in this position in the phrase (sometimes called *garbage* words). When you use ellipses, the speech engine recognizes only specific words in the string regardless of when spoken with adjacent words or phrases. For example, if you set this property to "[...] check mail [...]" the speech recognition engine will match phrases like "please check mail" or "check mail please" to this command. Ellipses can be used anywhere within a string. However, be careful using this technique as voice settings with ellipses may increase the potential of unwanted matches.

When defining the words and grammar for your command, include at least one word that is required; that is, avoid supplying only optional words. In addition, make sure that the word includes only pronounceable words and letters. For numbers, it is better to spell out the word rather than use an ambiguous representation. For example, "345" is not a good grammar form. Similarly, instead of "IEEE", use "I triple E". Also, omit any punctuation or symbols. For example, instead of "the #1 $10 pizza!", use "the number one ten dollar pizza". Including non-pronounceable characters or symbols for one command may cause the speech engine to fail to compile the grammar for all your commands. Finally, make your voice parameter as distinct as reasonably possible from other voice commands you define. The greater the similarity between the voice grammar for commands, the more likely the speech engine will make a recognition error. You can also use the confidence scores to better distinguish between two commands that may have similar or similar-sounding voice grammar.

You can include in your grammar words in the form of "*text\pronunciation*", where "text" is the text displayed and "pronunciation" is text that clarifies the pronunciation. For example, the grammar, "1st\first", would be recognized when the user says "first," but the [**Command**](/en-us/windows/desktop/lwef/the-command-object) event will return the text, "1st\first". You can also use IPA (International Phonetic Alphabet) to specify a pronunciation by beginning the pronunciation with a pound-sign character ("#"), then the text representing the IPA pronunciation.

For Japanese speech recognition engines, you can define grammar in the form "*kana\kanji*," reducing the alternative pronunciations and increasing the accuracy. (The ordering is reversed for backward compatibility.) This is particularly important for the pronunciation of proper names in Kanji. However, you can just pass in "kanji," without the Kana, in which case the engine should listen for all acceptable pronunciations for the Kanji. You can also pass in just Kana.

Except for errors using the grouping or repetition formatting characters, Microsoft Agent will not report errors in your grammar, unless the engine itself reports the error. If you pass text in your grammar that the engine fails to compile, but the engine does not handle and return as an error, Agent cannot report the error. Therefore, the client application must be careful defining the grammar for the [**Voice**](voice-property) property.

Note

The grammar features available may depend on the speech recognition engine. You may want to check with the engine's vendor to determine what grammar options are supported. Use the [**SRModeID**](srmodeid-property) to use a specific engine.

The operation of this property depends on the state of Microsoft Agent server's speech recognition state. For example, if speech recognition is disabled or not installed, this function has no immediate effect. If speech recognition is enabled during a session, however, the command will become accessible when its client application is input-active.