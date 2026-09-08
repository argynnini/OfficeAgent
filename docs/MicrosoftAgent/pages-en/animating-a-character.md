---
layout: Conceptual
title: Animating a Character - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/animating-a-character
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
description: Animating a Character
ms.assetid: ed42de30-acac-41e8-bacb-4caaff254724
ms.topic: concept-article
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: f7954ffd-2c98-28b8-92e7-41a273d09ca2
document_version_independent_id: 3712ed8a-effd-1b0f-1eea-275c303a5b31
updated_at: 2025-03-13T17:42:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/animating-a-character.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/animating-a-character.md
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 662
asset_id: lwef/animating-a-character
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/animating-a-character.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: ddc836c4-bbf4-5242-906e-7bc8616b36b3
---

# Animating a Character - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

Once a character is loaded, you can use several of Microsoft Agent's methods for animating the character. The first one you use is typically the [**Show**](show-method) method. **Show** makes the character's frame visible and plays the animation assigned to the character's **Showing** state.

Once the character's frame is visible, you can use the [**Play**](play-method) method, specifying the name of an animation, to play that animation. Animation names are specific to a character definition. As an animation plays, the shape of its window changes to match the image in the frame. This results in a movable graphic image, or *sprite*, displayed on top of the desktop and all windows, or *z-order*.

If the character's file is stored locally, you can simply call the [**Play**](play-method) method. In other cases, such as when you have loaded an .ACF character from an HTTP server, you must use the [**Get**](get-method) (or [**Prepare**](/en-us/windows/desktop/lwef/iagentcharacter--prepare)) method to first retrieve the animation data. This will cause Agent to request the animation file from the server and store it in the browser's buffer on the local machine.

The [**Speak**](speak-method) method enables you to program the character to speak, automatically lip-syncing the output. Further details are covered in the Output section of this document.

You can use the [**MoveTo**](moveto-method) method to position the character at a new location. When you call the **MoveTo** method, Microsoft Agent automatically plays the appropriate animation based on the character's current location, then moves the character's frame. Similarly, when you call [**GestureAt**](gestureat-method), Microsoft Agent plays the appropriate gesturing animation based on the character's location and the location specified in the call.

To hide the character, call the [Hide](hide-method) method. This automatically plays the character associated with the character's **Hiding** state, then hides the character's frame. However, you can also hide or show a character by setting the character's [**Visible**](visible-property) property.

Microsoft Agent processes all animation calls, or *requests*, asynchronously. This enables your application's code to continue handling other events while the request is being processed. For example, calls to the [**Play**](play-method) method place the animation in a queue for the character so that the animations can be played sequentially. However, this means you cannot assume that a call to other functions will necessarily execute after an animation it follows in your code. For example, typically, a statement following a call to **Play** or [**MoveTo**](moveto-method) will execute before the animation finishes.

You can synchronize your code with animations in a character's queue by creating an object reference to the animation request, and, when the animation starts or completes, monitoring the [Request](the-request-object) events that the server uses to notify clients of the character. For example, if you want a message box to appear when the character finishes an animation, you can put the message box call in your [**RequestComplete**](requestcomplete-event) event handling subroutine, checking for the particular request ID.

When a character is hidden, the server does not play animations; however, it still queues and processes the animation request (plays the animation) and passes a request status back to the client. In the hidden state, the character cannot become input-active. However, if the user speaks the name of the character (when speech input is enabled), the server automatically shows the character.

When your client application loads multiple characters at the same time, Microsoft Agent's animation services enable you to animate characters independently or use the [**Wait**](wait-method), [**Interrupt**](interrupt-method), or [**Stop**](stop-method) methods to synchronize their animation with each other.

Microsoft Agent also plays other animations automatically for you. For example, if the character's state has not changed for several seconds, Agent begins playing animations assigned to the character's **Idling** animations. Similarly, when speech input is enabled, Agent plays the character's **Listening** animations and then **Hearing** animations when an utterance is detected. These server-managed animations are called *states*, and are defined when a character is created. For more information, see [Designing Characters for Microsoft Agent](agent-states).