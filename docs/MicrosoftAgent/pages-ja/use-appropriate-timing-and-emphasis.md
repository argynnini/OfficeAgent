---
layout: Conceptual
title: 適切なタイミングと強調を使用する - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/use-appropriate-timing-and-emphasis
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: 適切なタイミングと強調を使用する
document_id: 91ee7917-f5d1-4ee7-03e5-6ea3aa1c8ed4
document_version_independent_id: 0bf3296f-74ab-bb0b-494d-cc4eb790d136
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/use-appropriate-timing-and-emphasis.md
locale: ja-jp
ms.assetid: a0b26313-ed1f-4858-b1a1-f519c798e0be
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/use-appropriate-timing-and-emphasis.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:03:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/use-appropriate-timing-and-emphasis.md
page_type: conceptual
toc_rel: toc.json
word_count: 368
asset_id: lwef/use-appropriate-timing-and-emphasis
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 7ccab246-5ed8-f2c2-6999-818c0daa6f6b
---

# 適切なタイミングと強調を使用する - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

すべてのフィードバックと同様に、音声出力の効果はタイミングと強調によって異なります。 適切な情報は、何かが話されたときに使用されるペース、音量、ピッチで伝えることができます。 テキスト読み上げエンジンをキャラクターの音声として使用する場合、ほとんどのエンジンでは、単語やフレーズの速度、一時停止、ピッチ、強調を設定できます。 これらの属性を使用して、キャラクターの関心と理解を示したり、ユーザーの注意を引いたり、キャラクターの意図を示すことができます。 音声属性を設定する方法の詳細については、「[Microsoft Agent Speech Output Tags](microsoft-agent-speech-output-tags)」を参照してください。 サウンドファイルをキャラクターの出力として使用している場合は、録音したオーディオでもこれらの要因を考慮してください。