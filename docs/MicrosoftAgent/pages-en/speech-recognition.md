---
layout: Conceptual
title: Speech Recognition - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/speech-recognition
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
description: Speech Recognition
ms.assetid: cb5ac509-12a4-4ca4-8776-424568cf780d
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 91402e4b-802d-0e71-e265-65eea7947fce
document_version_independent_id: 51846f8e-c45c-f570-7eb2-14e2c287ab7a
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/speech-recognition.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/speech-recognition.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 544
asset_id: lwef/speech-recognition
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/speech-recognition.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: fb4dbfcc-b7a9-e066-70c7-1284248882c5
---

# Speech Recognition - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

Speech recognition provides a very natural and familiar interface for interacting with characters. However, speech input also presents many challenges. Speech engines currently operate without substantial parts of the human speech communication repertoire, such as gestures, intonation, and facial expressions. Further, natural speech is typically unbounded. It is easy for the speaker to exceed the current vocabulary, or *grammar*, of the engine. Similarly, wording or word order can vary for any given request or response. In addition, speech recognition engines must often deal with large variations in the speaker's environment. For example, background noise, microphone quality, and location can affect input quality. Similarly, different speaker pronunciations or even same-speaker variations, such as when the speaker has a cold, make it a challenge to convert the acoustic data into representational understanding. Finally, speech engines must also deal with similar sounding words or phrases in a language, such as "new," "knew," and "gnu," or "wreck a nice beach" and "recognize speech."

Speech isn't always the best form of input for a task. Because of the turn-taking nature of speech, it can often be slower than other forms of input. Like the keyboard, speech input is a poor interface for pointing unless some type of mnemonic representation is provided. Therefore, always consider whether speech is the most appropriate input for a task. It is best to avoid using speech as the exclusive interface to any task. Provide other ways to access any basic functionality using methods such as the mouse or keyboard. In addition, take advantage of the multi-modal nature of using speech in the visual interface by combining speech input with visual information that helps specify the context and options.

Finally, the successful use of speech input is due only in part to the quality of the technology. Even human recognition, which exceeds any current recognition technology, sometimes fails. However, in human communication we use strategies that improve the probability of success and that provide error recovery when something goes wrong. Therefore, the effectiveness of speech input also depends on the quality of the user interface that presents it.

Studying human models of speech interaction can be useful when designing more natural speech interfaces. Recording actual human speech dialogues for particular scenarios may help you better understand the constructs and patterns used as well as effective forms of feedback and error recovery. It can help determine the appropriate vocabulary to use (for input and output). It is better to design a speech interface based on how people actually speak than to simply derive it from the graphical interface in which it operates.

Note that Microsoft Agent uses the Microsoft Speech API (SAPI) to support speech recognition. This enables Microsoft Agent to be used with a variety of compatible engines. Although Microsoft Agent specifies certain basic interfaces, the performance requirements and quality of an engine may vary.

Speech is not the only means of supporting conversational interfaces. You can also use natural-language processing of keyboard input in place of or in addition to speech. In those situations, you can still generally apply guidelines for speech input.

- [Listen, Don't Just Recognize](listen--dont-just-recognize)
- [Clarify and Limit Choices](clarify-and-limit-choices)
- [Provide Good Error Recovery](provide-good-error-recovery)