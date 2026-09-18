---
layout: Conceptual
title: アニメーションデザイン - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/animation-design
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: アニメーションデザイン
document_id: 46647d0f-4c86-4e87-9047-f2d5da0f6fb6
document_version_independent_id: e6e4fca1-0d7a-c2de-4a94-3f5d2359b8f9
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/animation-design.md
locale: ja-jp
ms.assetid: 8812e4cc-9062-4c65-81ef-229bd29534cd
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/animation-design.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:37:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/animation-design.md
page_type: conceptual
toc_rel: toc.json
word_count: 879
asset_id: lwef/animation-design
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 4229c829-590d-b247-8f57-32e6d58b970b
---

# アニメーションデザイン - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

### 画像のデザイン

パレットの実現に関する潜在的な問題を最小限に抑えるために、文字を設計するときは Microsoft Office パレットを使用します。 文書で使用する色に似た透明度の色を選択しないでください。

### 音

Microsoft エージェントを使用すると、アニメーションでサウンドを再生できます。 **アイドル** アニメーションのサウンドは含めないことをお勧めします。 これは、エージェントがシステム マルチメディア DLL を読み込む必要がある場合に、アニメーションの途中で遅延が発生しないようにするためです。

### フレーム サイズ

一般的な Office アシスタントは 123 x 93 ピクセルです。 他のサイズの文字は作成できますが、アシスタント ギャラリーでは 123 x 93 にスケーリングされます。

### フレームの切り替え

**Goodbye**、**Greeting**、**Show**、 Hide を除くすべてのアニメーションは、RestPose アニメーションで開始および終了する必要があります。 Microsoft Office は明示的な **Return** アニメーションを再生しないため、それらを定義しないでください。 すべてのアニメーションにも Exit Branching が必要です。 Exit Branching を使用すると、次のアニメーションを呼び出す前に、現在のアニメーションを "急いで終了" することができます。 Exit Branching を指定しない場合、アニメーション間の切り替えがぎくしゃくしている可能性があります。

### Character プロパティ

Microsoft Agent では、文字の [**Name**](name-property)、[**Description**](description-property)、および extraData**[プロパティ](extradata-property)**設定できます。 Microsoft Office では、**ExtraData** フィールドを使用して、1 つ以上の概要フレーズとアラーム フレーズを保持します。 Microsoft Office は、アシスタント ギャラリーの吹き出しに配置する他の概要フレーズから選択します。 Outlook からアラームを受け取った場合は、アラーム フレーズを使用します。

[**ExtraData**](extradata-property) フィールドは、次のように書式設定されます。

IntroPhrase1~~IntroPhrase2~~IntroPhrase3^ReminderPhrase1~~ReminderPhrase2~~ReminderPhrase3

イントロ フレーズは、チルダ文字 (~) のペアで区切られた後に、アラーム フレーズが続きます。 これらのリマインダー フレーズも、チルダ文字のペアで区切られます。 2 組のフレーズは、2 つのキャレット文字で区切られます(^^)。 各種類のフレーズの数に制限はありません。ただし、それぞれ少なくとも 1 つが必要です。