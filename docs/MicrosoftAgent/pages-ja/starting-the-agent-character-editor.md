---
layout: Conceptual
title: エージェント文字エディターの起動 - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/starting-the-agent-character-editor
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: エージェント文字エディターの起動
document_id: 5dd076cc-dce1-7249-88b4-f12bfe6e5d41
document_version_independent_id: 2ce38c11-17fa-d750-260c-b1592a2a4d4f
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/starting-the-agent-character-editor.md
locale: ja-jp
ms.assetid: 981fea1d-e961-42c2-8839-e539361e549a
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/starting-the-agent-character-editor.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:01:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/starting-the-agent-character-editor.md
page_type: conceptual
toc_rel: toc.json
word_count: 521
asset_id: lwef/starting-the-agent-character-editor
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 9a9210c4-b050-9627-eccf-9da39bed5650
---

# エージェント文字エディターの起動 - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

エージェント文字エディターを実行するには、Windows タスク バーの **[スタート**] メニューから [**エージェント文字エディター**] オプションを選択するか、デスクトップの Microsoft **エージェント文字エディター** アイコンをダブルクリックします。 エディターのウィンドウが開き、メニューが表示され、頻繁に使用されるコマンドを含むツール バー、文字の定義を構成するコンポーネントを一覧表示するツリー、およびコンポーネント ツリーの選択に基づいて変更されるタブ付きページのセットが表示されます。

![\[Character - Microsoft Agent Character Editor\] の \[プロパティ\] ページを示すスクリーンショット。](images/f1chared.gif)

キーボードからウィンドウ内のフィールドにアクセスするには、Tab キーと Shift + Tab キーを使用してコントロール間を移動するか、アクセス キー (Alt + *下線付き文字*) を使用して特定のコントロールに移動します。 エディターの起動が完了したら、新しい文字定義の作成を開始するか、既存の文字定義を読み込むことができます。

ステータス バーには、ポインターを上に移動すると、コマンドまたはツール バー ボタンに関する情報が表示されます。 また、キャラクターの作成時に、キャラクターのアニメーション データとステータス情報に関する概要情報も表示されます。