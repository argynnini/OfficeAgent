---
layout: Conceptual
title: IAgentCommand SetVoice - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/iagentcommand--setvoice
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
description: IAgentCommand SetVoice
ms.assetid: bee06616-26bf-4e1e-89da-6765dd77fb02
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 5a06f3f0-73cf-3230-6d6b-4dcc969d4cc6
document_version_independent_id: 101e2691-8bea-a4f0-0fb8-adbe29901059
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommand--setvoice.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcommand--setvoice.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 716
asset_id: lwef/iagentcommand--setvoice
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/iagentcommand--setvoice.md
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/49f7a155-15b3-4cce-8c03-a814c52269b6
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/73c34d6e-8193-442f-9cd9-38506534a799
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 1aa87a67-3bca-74d4-e928-f9d2aaa250fa
---

# IAgentCommand SetVoice - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

```syntax
HRESULT SetVoice(
   BSTR bszVoice  // voice text setting for Command
);
```

Sets the [**Voice**](voice-property) property for a [**Command**](/en-us/windows/desktop/lwef/the-command-object).

- Returns S\_OK to indicate the operation was successful.

- *bszVoice*
    - A BSTR that specifies the text for the [**Voice**](voice-property) property of a [**Command**](/en-us/windows/desktop/lwef/the-command-object).

A [**Command**](/en-us/windows/desktop/lwef/the-command-object) must have its [**Voice**](voice-property) property and [**Enabled**](enabled-property) property set to be voice-accessible. It also must have its [**VoiceCaption**](voicecaption-property) property set to appear in the **Voice Commands Window**. (For backward compatibility, if there is no **VoiceCaption**, the [**Caption**](caption-property) setting is used.)

The BSTR expression you supply can include square bracket characters ([ ]) to indicate optional words and vertical bar characters (|) to indicate alternative strings. Alternates must be enclosed in parentheses. For example, "(hello [there] | hi)" tells the speech engine to accept "hello," "hello there," or "hi" for the command. Remember to include appropriate spaces between the text that's in brackets or parentheses and the text that's not in brackets or parentheses.

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

Therefore, you will typically want to use these operators with the grouping characters. For example, the following grammar includes both "New York" and "New York New York":

```syntax
   "(New York)+"
```

Repetition operators are useful when you want to compose a grammar that includes a repeated sequence such as a phone number or specification of a list of items:

```syntax
   "call (one|two|three|four|five|six|seven|eight|nine|zero|oh)*"
   "I'd like (cheese|pepperoni|pineapple|canadian bacon|mushrooms|and)+"
```

Although the operators can also be used with the square brackets (an optional grouping character), doing so may reduce the efficiency of Agent's processing of the grammar.

You can also use an ellipsis (...) to support *word spotting*, that is, telling the speech recognition engine to ignore words spoken in this position in the phrase (sometimes called *garbage* words). Therefore, the speech engine recognizes only specific words in the string regardless of when spoken with adjacent words or phrases. For example, if you set this property to "[...] check mail [...]" the speech recognition engine will match phrases like "please check mail" or "check mail please" to this command. Ellipses can be used anywhere within a string. However, be careful using this technique, because voice settings with ellipses may increase the potential of unwanted matches.

When defining the words and grammar for your command, always make sure that you include at least one word that is required; that is, avoid supplying only optional words. In addition, make sure that the word includes only pronounceable words and letters. For numbers, it is better to spell out the word rather than using the numeric representation. Also, omit any punctuation or symbols. For example, instead of "the #1 $10 pizza!", use "the number one ten dollar pizza". Including non-pronounceable characters or symbols for one command may cause the speech engine to fail to compile the grammar for all your commands. Finally, make your voice parameter as distinct as reasonably possible from other voice commands you define. The greater the similarity between the voice grammar for commands, the more likely the speech engine will make a recognition error. You can also use the confidence scores to better distinguish between two commands that may have similar or similar-sounding voice grammar.

Setting the [**Voice**](voice-property) property for a [**Command**](/en-us/windows/desktop/lwef/the-command-object) automatically enables Agent's speech services, making the Listening key and Listening Tip available. However, it does not load the speech recognition engine.

Note

The grammar features available may depend on the speech recognition engine. You may want to check with the engine's vendor to determine what grammar options are supported. Use [**IAgentCharacterEx::SRModeID**](https://www.bing.com/search?q=**IAgentCharacterEx::SRModeID**) to specify an engine.