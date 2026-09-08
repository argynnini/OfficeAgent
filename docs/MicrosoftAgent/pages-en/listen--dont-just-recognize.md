---
layout: Conceptual
title: Listen, Dont Just Recognize - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/listen--dont-just-recognize
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
description: Listen, Dont Just Recognize
ms.assetid: 74bb2122-98c1-4a51-b894-93e1481aa46b
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 8be9e38d-149a-454a-b78e-af24e664e8f1
document_version_independent_id: 6f395e5b-7607-a53c-0a9b-57694303bad2
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/listen--dont-just-recognize.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/listen--dont-just-recognize.md
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 384
asset_id: lwef/listen--dont-just-recognize
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/listen--dont-just-recognize.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 9a602a0e-0c39-c9a2-7ba2-f5fcf652f268
---

# Listen, Dont Just Recognize - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

Successful communication involves more than recognition of words. The process of dialogue implies exchanging cues to signal turn-taking and understanding. Characters can improve conversational interfaces by providing cues like head tilts, nods, or shakes to indicate when the speech engine is in the listening state and when something is recognized. For example, Microsoft Agent plays animations assigned to the **Listening** state when a user presses the push-to-talk listening key and animations assigned to the **Hearing** state when an utterance is detected. When defining your own character, make sure you create and assign appropriate animations to these states. For more information on designing characters, see [Designing Characters for Microsoft Agent](designing-characters-for-microsoft-agent).

In addition to non-verbal cues, a conversation involves a common context between the conversing parties. Similarly, speech input scenarios with characters are more likely to succeed when the context is well established. Establishing the context enables you to better interpret similar-sounding phrases like "check's in the mail" and "check my mail." You may also want to enable the user to query the context by providing a command, such as "Help" or "Where am I," to which you respond by restating the current context, such as the last action your application performed.

Microsoft Agent provides interfaces that enable you access the best match and the two next best alternatives returned by the speech recognition engine. In addition, you can access confidence scores for all matches. You can use this information to better determine what was spoken. For example, if the confidence scores of the best match and first alternative are close, it may indicate that the speech engine had difficulty discerning the difference between them. In such a case, you may want to ask the user to repeat or rephrase the request in an effort to improve performance. However, if the best match and first or second alternatives return the same command, it strengthens the indication of the correct recognition.

The nature of a conversation or dialogue implies that there should be a response to spoken input. Therefore, a user's input should always be responded to with verbal or visual feedback that indicates an action was performed or a problem was encountered, or provides an appropriate reply.