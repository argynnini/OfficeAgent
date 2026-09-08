---
layout: Conceptual
title: Create a Team Player - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/create-a-team-player
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
description: Create a Team Player
ms.assetid: a252dd9d-69bf-4348-bf59-1ac97faaa3eb
ms.topic: how-to
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: 0eaa9700-1457-d337-48cc-4d6704647ae5
document_version_independent_id: 76a20a5f-69ba-926b-077d-c305a1a60e9c
updated_at: 2025-03-13T18:20:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/create-a-team-player.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/create-a-team-player.md
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 420
asset_id: lwef/create-a-team-player
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/create-a-team-player.md
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/63959238-cb90-4871-a33d-4a5519097e47
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/78d87f42-5582-4a6b-90be-7db2f12b34e6
platformId: 7b85774a-b806-587b-164e-12a0a7faaeb4
---

# Create a Team Player - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

When a team is created, group dynamics have a powerful effect on the members in the group. First, people in a group or team context have a tendency to identify more with the other people on the team than they typically would in a non-team setting. As a result, they can also identify more with their teammates than those outside the team. But equally important, members of a team are more willing to cooperate and modify their attitudes and behavior. Because the social dynamics of a team affect its members' interaction, it can be useful to consider when designing interaction with characters.

Creating a sense of team involves two factors: identity and interdependence. You can create identity by creating a team name, color, symbol, or other identifier that the user and character share. For example, you could provide a sticker the user could affix to their computer or enable the user to pick a team name or icon that would appear with the character. Team identity may also be established by what the character says. For example, you could have the character refer to itself as a partner or to the user and itself as a team.

Interdependence may be harder to implement or take longer to establish, though it is important to consider because interdependence seems to have a stronger social impact than team identity. This is illustrated by the product brand loyalty that marketing organizations endeavor to establish. Creating a sense of interdependence involves demonstrating continuing usefulness and reliability for the user. Important questions to answer are "Does the character provide value?" and "Does the character operate predictability and reliably?" An important factor here is how the character's relationship is established with the user. To engender a sense of team interdependence, the character needs to be presented as a peer to the user. Although it may be useful in some scenarios to present the character as an expert or a servant, to leverage the collaborative benefits of team dynamics, there must be a sense of equality where the user can be dependent on the character without a sense of inferiority. This may be as simple as having the character refer to itself as a teammate or companion rather than as a wizard. It can also be influenced by how the character requests information from the user. For example, a character might say, "Let's work together to answer this question."