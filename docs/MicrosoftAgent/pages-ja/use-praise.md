---
layout: Conceptual
title: 称賛を使用する - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/use-praise
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: 称賛を使用する
document_id: c5a6dd9c-446d-fe3c-6887-3c9d95fd418a
document_version_independent_id: a02c1a02-ac02-8616-8c31-1c79fd92adf7
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/use-praise.md
locale: ja-jp
ms.assetid: 813c0f39-177a-4788-8d60-71c97e930ba7
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/use-praise.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:03:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/use-praise.md
page_type: conceptual
toc_rel: toc.json
word_count: 700
asset_id: lwef/use-praise
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: e0087a31-014d-daf5-38cc-880761bf0b7c
---

# 称賛を使用する - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

人間は、賞賛が不当な場合でも、批判よりも賞賛に反応します。 ほとんどのソフトウェア インターフェイスは評価フィードバックの回避に努めていますが、評価をまったく提供しないよりも、賞賛の方が明らかに効果的です。 さらに、ニュートラルとして設計された多くのインターフェイスは、通常、正常に動作しているときに肯定的なフィードバックを受け取ることはまれで、問題が発生した場合はエラー メッセージを受け取らないため、ユーザーによって重要と認識されることがよくあります。 同様に、タスクを実行するより良い方法があることをユーザーに伝える文言は、ユーザーを暗黙的に批判します。

文字はソーシャル コンテキストを作成するため、従来のユーザー インターフェイスよりも、賞賛と批判を慎重に使用することがさらに重要です。 スコファンティックな行動を楽しむ人はほとんどいませんが、賞賛のリベラルな使用の限界はまだ示されていません。 称賛は、ユーザーがタスクのパフォーマンスに対する自信が低い状況で特に効果的です。 その一方で、批判は控えめに使用する必要があります。 批判が適切であると思われる場合でも、人間はそれを無視したり、ソースにリダイレクトしたりする傾向があることに注意してください。

しかし、それがキャラクターがプロジェクトするパーソナリティのユーモラスな部分でない限り、自己賞賛を避けてください。 私たちは自己満足を懐疑的に判断する傾向があります。 キャラクターに称賛を向けたい場合は、他のキャラクターや説明など、別の手段からそれを示しましょう。