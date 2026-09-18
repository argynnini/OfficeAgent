---
layout: Conceptual
title: 適切なフィードバックを提供する - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/provide-appropriate-feedback
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: 適切なフィードバックを提供する
document_id: 7501177d-2872-7c20-125b-a730d0d17285
document_version_independent_id: 570ef434-0213-ac2c-f5e0-6c9a20b0102d
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/provide-appropriate-feedback.md
locale: ja-jp
ms.assetid: e89b5f08-645e-4048-a153-4f01de8e82f0
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/provide-appropriate-feedback.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:59:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/provide-appropriate-feedback.md
page_type: conceptual
toc_rel: toc.json
word_count: 1053
asset_id: lwef/provide-appropriate-feedback
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/8b896464-3b7d-4e1f-84b0-9bb45aeb5f64
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/b1d2d671-9549-46e8-918c-24349120dbf5
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 0291ca5b-2f38-21cf-24ec-54dcb617de36
---

# 適切なフィードバックを提供する - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

品質、妥当性、タイミングは、インターフェイス設計でフィードバックを提供する際に考慮すべき重要な要素です。 対話型の文字を組み込むと、フィードバックが適切な社会的相互作用に準拠するというユーザーの期待と同様に、自然な形式のフィードバックの機会が増加します。 キャラクターは、音声出力に加えて、音声と非言語の会話の手掛かりを提供するように設計できます。 ジェスチャーや表情を使用して、その気分や意図に関する情報を伝えます。 顔はコミュニケーションにおいて特に重要なので、キャラクターの表情を常に考慮してください。 顔の表情  されない点に注意してください。

人間は、環境の変化、特に動き、音量、コントラストの変化に対応する方向反射を持っています。 そのため、ユーザーがキャラクターと直接やり取りしていない場合は、ユーザーの注意を散らすのを避けるために、キャラクターアニメーションとサウンドエフェクトを最小限に抑える必要があります。 これはキャラクターがフリーズしなければならないという意味ではありませんが、呼吸や周りを見回すなどの自然なアイドリング動作が、より大きな動きに適しています。 アイドリング動作は、ユーザーを邪魔することなく、ソーシャルコンテキストとキャラクターの可用性の錯覚を維持します。 また、ユーザーが設定した期間に操作していない場合は、文字を削除することを検討することもできますが、文字が消える理由をユーザーが理解していることを確認してください。

逆に、大きなボディ モーション、異常なボディ モーション、または非常にアクティブなアニメーションは、特にユーザーの現在のフォーカス外でアニメーションが発生した場合に、ユーザーの注意を引く場合に非常に効果的です。 また、ユーザーに向けた動きは、効果的にユーザーの注意を引くことができることに注意してください。

文字の配置と移動は、ユーザーの現在のタスクへの参加に適している必要があります。 現在のタスクに文字が含まれている場合は、その文字をフォーカスのポイントに配置できます。 ユーザーが文字を操作していない場合は、一貫した "スタンバイ" の場所に移動するか、タスクを妨げたり、ユーザーの注意を妨げたりしない場所に移動します。 文字がある場所から別の場所に到達する方法の根拠を常に提供します。 同様に、ユーザーは、キャラクターが出発したのと同じ画面の場所に表示されると、最も快適に感じます。