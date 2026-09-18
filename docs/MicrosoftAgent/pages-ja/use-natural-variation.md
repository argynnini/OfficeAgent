---
layout: Conceptual
title: 自然なバリエーションを使用する - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/use-natural-variation
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: 自然なバリエーションを使用する
document_id: 110f6ad4-f3fe-9139-79ac-48e0c95716b5
document_version_independent_id: 89d89d20-1e3f-e6c3-f4de-3139ebd46360
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/use-natural-variation.md
locale: ja-jp
ms.assetid: 5d5750e4-cf30-43dc-9419-7e6bbdb9aa5a
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/use-natural-variation.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:03:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/use-natural-variation.md
page_type: conceptual
toc_rel: toc.json
word_count: 724
asset_id: lwef/use-natural-variation
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: d9401d36-e5f7-6a54-92c0-1b07acdd0777
---

# 自然なバリエーションを使用する - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

メニューやダイアログ ボックスなど、アプリケーションの従来のインターフェイスでのプレゼンテーションの一貫性により、インターフェイスの予測が容易になりますが、キャラクターのインターフェイスでアニメーションと音声の出力を変えます。 文字の応答を適切に変更すると、より自然なインターフェイスが提供されます。 キャラクターが常にユーザーに対してまったく同じ言い方をする場合、たとえば、常に同じ言葉を言うと、ユーザーはキャラクターが退屈だ、無関心だ、または失礼だと考える可能性があります。 人間のコミュニケーションが正確な繰り返しを伴うことはめったにありません。 同様の状況で何かを繰り返しても、言葉やジェスチャー、表情が変わる可能性があります。

Microsoft エージェントを使用すると、キャラクターにいくつかのバリエーションを持たせることができます。 キャラクターのアニメーションを定義するときに、アニメーション フレームの分岐確率を使用して、再生時にアニメーションを変更できます。 各状態に複数のアニメーションを割り当てることもできます。 Microsoft エージェントは、状態を開始するたびに、割り当てられたアニメーションのいずれかをランダムに選択します。 音声出力の場合は、出力テキストに垂直バー文字を含めて、読み上げられたテキストを自動的に変更することもできます。 たとえば、Microsoft エージェントは、[**Speak**](speak-method) メソッドの一部としてこのテキストを処理するときに、次のいずれかのステートメントをランダムに選択します。

私はこれを言うことができます。|私はそれを言うことができます。|私は何か他のことを言うことができます。