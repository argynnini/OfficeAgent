---
layout: Conceptual
title: ソーシャルインタラクション - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/social-interaction
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: ソーシャルインタラクション
document_id: 5aeaf2fe-605d-a799-f50d-7b80323e5121
document_version_independent_id: b66a1905-a0fb-6557-3924-9e9bce2c7bff
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/social-interaction.md
locale: ja-jp
ms.assetid: 4e8096e8-7bd1-4225-b12c-832f312ef833
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/social-interaction.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:00:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/social-interaction.md
page_type: conceptual
toc_rel: toc.json
word_count: 812
asset_id: lwef/social-interaction
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 1fe6b0d3-090d-4ef4-dbf6-956f8f9bed36
---

# ソーシャルインタラクション - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

人間のコミュニケーションは基本的に社会的です。 私たちが生まれるときから、私たちは環境の社会的手掛かりに反応し始め、イントネーションや単語の順序付けなどの言葉による行動や、姿勢、ジェスチャー、表情などの言葉以外の行動を含む、効果的な相互作用のための適切なルールを学び始めます。 これらの行動は、私たちのコミュニケーションを彩る態度、アイデンティティ、感情を伝えます。 多くの場合、メールやオンライン チャット セッションなど、言語以外の手掛かりに対して自然に帯域幅を提供しない通信チャネルの代替規則を作成します。

残念ながら、ソフトウェアインターフェイス設計の大部分は、主にコミュニケーションの認知的側面に焦点を当て、ほとんどの社会的側面を見落としています。 しかし、最近の研究は、人間がインタラクティブな文脈で提示される社会的刺激に自然に反応することを示しています。 また、反応は、多くの場合、人々が互いに使用するのと同じ規則に従います。 メッセージに表示される色や単語の選択など、最小のキューでも、この自動応答をトリガーできます。 目と口を持つアニメーションキャラクターのプレゼンテーションは、キャラクターに対する社会的期待と応答の強さを高めます。 ユーザーがキャラクターの行動が人為的であることを知っているため、社会的に適さないと想定しないでください。 これを知って、キャラクターの相互作用を設計する際に、相互作用の社会的側面を考慮することが重要です。 *メディアの方程式:人々がコンピュータ、テレビ、新メディアを実際の人と場所として扱う方法* byron Reeves and Clifford Nass(ニューヨーク:ケンブリッジ大学出版局)は、この分野の現在の研究に関する優れた参考資料です。

- パーソナリティ [を作成する](create-personality)
- 適切なエチケット [を](observe-appropriate-etiquette) に観察する
- 称賛 [を使用する](use-praise)
- チーム プレーヤー [を作成する](create-a-team-player)
- 性別効果 [を考慮する](consider-gender-effects)