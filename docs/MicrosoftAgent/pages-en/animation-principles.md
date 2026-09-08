---
layout: Conceptual
title: Animation Principles - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/animation-principles
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
description: Animation Principles
ms.assetid: 3633744c-ddb1-44bb-a390-7114386d265c
ms.topic: reference
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: a9cdab69-521e-0da4-2c58-33772935fba2
document_version_independent_id: 7dfa17ce-ecef-3762-c73b-93f42984176b
updated_at: 2025-03-13T17:42:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/animation-principles.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/animation-principles.md
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 896
asset_id: lwef/animation-principles
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/animation-principles.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: d402a037-d2b4-5e17-e2af-91bfa7b5258d
---

# Animation Principles - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

Effective animation design requires more than simply rendering a character. Successful animators follow a variety of principles and techniques to create "believable" characters.

**Squash and Stretch**

There should be a degree of distortion as an animated object moves. The amount of deformation that occurs reflects the rigidity of that object. Flattening or elongating a part of a character's body as it moves helps you convey the nature and composition of the character.

**Anticipation**

Anticipation sets the stage for an upcoming action. Without anticipatory actions, body movements look abrupt, rigid, and unnatural. This principle is based on how a body moves in the real world. Movement in one direction often begins with movement in the opposite direction. Legs contract before a jump. To exhale, you first inhale. Anticipatory action also has an important role in communicating the nature of both the character and the action and helps your audience prepare for the action. A key aspect of creating a believable character involves demonstrating that the character's actions stem from a purposeful intent. Anticipation helps communicate the character's motivation to the audience.

**Timing**

Timing defines the nature of an action. The speed that a head moves from left to right conveys whether a character is casually looking around or giving a negative response. Timing also helps convey the weight and size of an object. Larger objects tend to take longer to accelerate and decelerate than smaller ones. In addition, the pacing of a character's movements affects how it draws attention. In a normal scenario, rapid motion draws the eye, while in a frenetic environment, stationary or slow movements may have the same effect.

**Staging**

The background and props a character uses can also convey its mood or purpose. Staging also includes what the character wears, lighting effects, viewing angle, and the presence of other characters. These elements all contribute to reinforcing a character's personality, objectives, and actions. Effective staging involves understanding how to direct the eye to where you want to communicate.

**Follow-Through and Overlapping Action**

Just as a golfer's follow-through communicates the result of the swing, the transition from one action to the next is important in communicating the relationship between the actions. Actions rarely come to a sudden and complete stop. So, too, follow-through and overlapping actions allow you to establish the flow of the character's motion. You can typically implement this by varying the speed at which different parts of a body move, allowing movement beyond the primary aspect of the motion. For example, the fingers of a hand typically follow the movement of the wrist in a hand gesture. This principle also emphasizes that actions should not come to a complete stop, but smoothly blend into other actions.

**Slow In-and-Out**

Slow in-and-out refers to moving a character smoothly from one pose to another. The character begins and ends actions slowly. You accomplish this by the number, timing, and location of "in-between" frames. The more in-between frames you include, the slower and smoother the transition.

**Arcs**

Living objects in nature rarely move in a perfectly straight line. As a result, arcs or curved paths for movement provide more natural effects. Arcs also convey speed of motion. The slower the motion, the higher the arc, and the faster the motion, the flatter the arc.

**Exaggeration**

Good animators often exaggerate the shape, color, emotion, or actions of a character. Making aspects of the motion "larger than life" more clearly communicates the idea of the action to the audience. For example, a character's arms may stretch to the point that they appear elastic. However, exaggeration must be balanced. If used in some situations and not others, the exaggerated action may appear unrealistic and may be interpreted by the user as having a particular meaning. Similarly, if you exaggerate one aspect of an image, consider what other aspects should be exaggerated to match.

**Secondary Action**

Animation requires more than the mechanistic creation of in-between images from one pose to the next. A primary action is typically supported by secondary actions. Secondary actions can enhance the presentation, but should not detract from or dominate the main action. Facial expressions can often be used as secondary actions to body movement. Richness comes from adding elements that support the main idea.

**Solid Drawing**

Creating an animated character involves more than creating a series of images. Effective animation design considers how the character looks in different positions and from different angles. Even characters rendered as two-dimensional images become more realistic and believable if considered conceptually in three dimensions. Avoid twins: mirroring the position the face, arms, and legs on both sides of the body. This results in a wooden, unnatural presentation. Body movement is rarely symmetrical, but involves overall balancing of posture or reactions.

**Appeal**

Successful implementation depends on how well you understand your audience. Your character's overall image and personality should appeal to your target audience; appeal does not require photo-realism. A character's personality can be conveyed—no matter how simple its shape—by using gestures, posture, and other mannerisms. A common assignment of beginning animators is to create a variety of expressions for a flour sack or small rug. Characters with simple shapes are often more effective than complex ones. Consider, for example, that many popular characters have only three fingers and a thumb.