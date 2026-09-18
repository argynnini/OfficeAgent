---
layout: Conceptual
title: パーソナリティの作成 - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/create-personality
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: パーソナリティの作成
document_id: d0403368-8969-2b07-8a7c-f8bcda71524a
document_version_independent_id: d07f2dd9-40c6-49ea-015a-744425b4e9c3
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/create-personality.md
locale: ja-jp
ms.assetid: ee8b2b8d-82e6-47c9-9ba1-8eb18f82683f
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/create-personality.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:39:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/create-personality.md
page_type: conceptual
toc_rel: toc.json
word_count: 1054
asset_id: lwef/create-personality
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 5a51a7ac-4bcf-ba8f-537c-17341fd642ac
---

# パーソナリティの作成 - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

私たちは、姿勢、ジェスチャー、外観、単語の選択、スタイルなど、最も簡単な社会的手掛かりに基づいて、出会う人々の個性をすばやく分類します。 だから、キャラクターが作る第一印象は非常に重要です。 パーソナリティを作成するには、人工知能や現実的なレンダリングは必要ありません。 偉大なアニメーターは長年これを知っており、最も単純な社会的手掛かりを使用して、生き物のための豊かな個性を作り出してきました。 たとえば、ディズニーの *アラジン*の空飛ぶカーペットや、ラスシサーの *ルクソールjr*、ペアデスクランプのユーモラスなアニメーションビデオを考えてみましょう。 ディズニーでアニメーターを始めるのは、感情を表す小麦粉袋を描くという課題をしばしば受け取りました。

文字の名前、自己紹介方法、話し方、移動方法、ユーザー入力への応答はすべて、その基本的な個性の確立に貢献できます。 たとえば、権限のある、または優勢な性格スタイルは、文字がアサーションを作成し、自信を示し、コマンドを発行することによって確立できます。一方、従順な性格は、物事を質問として言い回したり、提案したりすることによって特徴付けることができます。 同様に、パーソナリティは相互作用のシーケンスで伝えることができます。 優勢な性格は常に最初に行きます。 作成するパーソナリティの種類に関係なく、明確に定義された個別のパーソナリティ型を提供することが重要です。 誰もが弱い定義やあいまいな性格を嫌うのが一般的です。

キャラクターに対して選択するパーソナリティの種類は、目的によって異なります。 キャラクターの目的が特定の目標に向かってユーザーを導く場合は、優勢で積極的な性格を使用します。 キャラクターの目的がユーザーの要求に応答する場合は、より従順な性格を使用します。

もう 1 つのアプローチは、キャラクターの個性をユーザーに適応させることです。 研究では、ユーザーは自分自身と最も似た性格との相互作用を好むことが示されています。 ユーザーに異なる個性を持つ文字の選択を提供したり、ユーザーのキャラクターとの対話スタイルを観察したり、キャラクターの対話型スタイルを変更したりすることもできます。 調査によると、ユーザーの性格を一致させる場合、常に 100% 正しいとは限りません。 人間は人間関係に柔軟性を示す傾向があり、社会的関係の性質上、キャラクターを扱うために自分の行動を多少変更する可能性もあります。