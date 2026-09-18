---
layout: Conceptual
title: Provide Good Error Recovery - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/provide-good-error-recovery
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
description: Provide Good Error Recovery
ms.assetid: 48e00638-9274-49db-93ec-ed444f526441
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 73d539c9-d600-5123-51ef-cf83d2c14400
document_version_independent_id: 978f2f07-d5ed-614a-997e-2d9e76d060b7
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/provide-good-error-recovery.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/provide-good-error-recovery.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 1291
asset_id: lwef/provide-good-error-recovery
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/provide-good-error-recovery.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 97ffadc5-d98a-78f7-770f-6d06275b1625
---

# Provide Good Error Recovery - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

As with any well-designed interface, the interactive process should minimize the circumstances that lead to errors. However, it is rarely possible to eliminate all errors, so supporting good error recovery is essential to maintain the confidence and interest of the user. In general, error recovery involves detecting an error, determining the cause, and defining a way to resolve the error. Users respond better to interfaces that are cooperative, that work with the user to accomplish a task.

The first step in speech error recovery is detecting the failure condition. Speech recognition can fail due to a variety of errors. Error conditions can usually be detected as the result of invalid input, explicit user correction or cancellation, or user repetition.

A *rejection error* occurs when the recognition engine has no match for what the user has said. Background noise or early starts are also common causes of recognition failure, so asking the user to repeat a command is often a good initial solution. However, if the phrase is outside of the current active grammar, asking the user to rephrase the request may solve the problem. The difference in wording may result in a match with something in the current grammar. Listing or suggesting appropriate expected input options is another alternative.

A good strategy for rejection error recovery is to combine these techniques to get the user back on track, offering increasingly more assistance if the failure persists. For example, you can begin by responding to the initial failure with an interrogative like "Huh?" or "What?" or a hand-to-the-ear gesture. A short response increases the likelihood that the user's repeated statement will not fail because the user spoke too soon. Upon a repeated failure, the subsequent request to rephrase improves the chance of matching something within the given grammar. From here, providing explicit prompts of accepted commands further increases the chance of a match. This technique is illustrated in the following example:

**User**: I'd like a Chicago-style pizza with anchovies.

**Character**: (Hand to ear) Huh?

**User**: I want a Chicago pizza with anchovies.

**Character**: (Head shake) Please rephrase your request.

**User**: I said Chicago pizza, with anchovies.

**Character**: (Shrug) I'm sorry. Tell me the style of pizza you want.

**User**: Chicago, with anchovies.

**Character**: Still no luck. Here's what you can say: "Chicago," "Hawaiian," or "Combo."

To make the error handling feel more natural, make sure you provide a degree of random variation when responding to errors. In addition, a natural user reaction to any request to repeat a response is to exaggerate or increase the volume when repeating the statement. It may be useful to occasionally remind the user to speak normally and clearly, as the exaggeration or increased volume may make it harder for the speech engine to recognize the words.

Progressive assistance should do more than bring the error to the user's attention; it should guide the user toward speaking in the current grammar by successively providing more informative messages. Interfaces that appear to be trying to understand encourage a high degree of satisfaction and tolerance from the user.

*Substitution errors*, where the speech engine recognizes the input but matches the wrong command, are harder to resolve because the speech engine detects a matching utterance. A mismatch can also occur when the speech engine interprets extraneous sounds as valid input (also known as an *insertion error*). In these situations, the user's assistance is needed to identify the error condition. To do this, you can repeat what the speech engine returned and ask the user to confirm it before proceeding:

**User**: I'd like a Chicago-style pizza.

**Character**: Did you say you'd like a "Chicago-style pizza"?

**User**: Yes.

**Character**: What additional ingredients would you like on it?

**User**: Anchovies.

**Character**: Did you say "anchovies"?

**User**: Yes.

However, using this technique for every utterance becomes inefficient and tiresome. To handle this, restrict confirmation to situations that have significant negative consequences or increase the complexity of the immediate task. If it is easy for the user to make or reverse changes, you may be able to avoid requesting confirmation of their choices. Similarly, if you make choices visible you may not need to provide explicit correction. For example, choosing an item from a list may not require verification because the user can see the results and easily change them. You can also use confidence and alternative scores to provide a threshold for confirmation. You might adjust the threshold by keeping a history of the user's actions in a given situation and eliminating verification based on consistent user confirmation. Finally, consider the multi-modal nature of the interface. Confirmation from the mouse or keyboard may also be appropriate.

Carefully choose the wording of confirmations. For example, "Did you say…?" or "I think you said..." are better than "Do you really want to…?" because the former phrases imply that the accuracy of the character's listening (recognition) is being queried, not that the user may have misspoke.

Also consider the grammar for a response. For example, a negative response is likely to generate a rejection error, requiring an additional prompt as shown in the following example:

**User**: I'd like some pepperoni.

**Character**: Did you say "no ham"?

**User**: No, I said pepperoni.

**Character**: Huh?

**User**: Pepperoni.

Modifying your grammar to include prefixes to handle natural response variations increases the efficiency of the recovery process, especially when the user doesn't confirm the verification prompt. In this example, the confirmation could have been handled in a single step by modifying the grammar for the "pepperoni" by also including "no I said pepperoni", "I said pepperoni", and "no pepperoni".

You can also handle substitution errors using the alternative matches returned by the speech engine as the corrective confirmation:

**User**: I'd like some pepperoni.

**Character**: (Hears "no ham" as best match, "pepperoni" as first alternative) Did you say "no ham"?

**User**: No, pepperoni.

**Character**: (Still hears "no ham" as best match, but now offers first alternative) "Pepperoni"?

Similarly, you can keep a history of common substitution errors and if a particular error is frequent, offer the alternative the first time.

In any recognition error situation, avoid blaming the user. If the character suggests or even implies that the user is to blame, or the character seems indifferent to the error, the user may become offended. Here also, carefully choose wording that explicitly accepts responsibility, is appropriate to the situation, and uses variety to create a more natural response. When expressing an apology, avoid ambiguous words like "oops" or "uh-oh" that could be interpreted as blaming the user. Instead, use phrases like "I'm sorry" or "My mistake." Repeated or more serious errors might use a more elaborate apology like "I am really sorry about that." Also consider the personality of the character when determining the type of response. Another option is to blame an external situation. Comments such as, "Boy, it's noisy out there," take the blame away from the user and the character. Reminding the user of the cooperative nature of the interaction may be helpful as well: consider phrases such as, "Let's see what we can do to make this work."

Microsoft Agent also supports some automatic feedback for recognition. When an utterance is detected, the Listening Tip displays the voice text of the best match heard. You can set your own text to display based on the confidence setting for a command you define.

Because of error potential, always require confirmation for any choices that have serious negative consequences and are irreversible. Naturally, you'll want to require confirmation when the results of an action could be destructive. However, consider also requiring confirmation for situations that abort any lengthy process or operation.