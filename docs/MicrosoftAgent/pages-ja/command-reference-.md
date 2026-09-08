---
layout: Conceptual
title: コマンド リファレンス (Microsoft エージェント文字エディター) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/command-reference-
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: このコマンド リファレンスでは、Microsoft エージェント文字エディターについて説明します。 Microsoft エージェントは、Windows 7 の時点で非推奨です。
document_id: 69f823dc-3f48-521f-cfbe-202602063714
document_version_independent_id: 60d8f3ec-1d7b-2d27-5763-b59127c22728
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/command-reference-.md
locale: ja-jp
ms.assetid: c8d57500-ad29-4325-aec7-3f857990b28c
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/command-reference-.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:38:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/command-reference-.md
page_type: conceptual
toc_rel: toc.json
word_count: 1463
asset_id: lwef/command-reference-
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 7fc6c24b-f9f8-6af3-bba8-125f74db0dd8
---

# コマンド リファレンス (Microsoft エージェント文字エディター) - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

## [ファイル] メニュー

- 新しい**の **
    - 新しい文字定義を作成するためのエージェント文字エディターをリセットします。 既存の文字が読み込まれ、編集が保存されていない場合、エディターには、保存されていない変更を保存するか破棄するかを決定するメッセージが表示されます。
- **開く**
    - [ファイルを開く] ダイアログ ボックスを表示し、編集用に既存の文字定義ファイルを開きます。 既存の文字が読み込まれ、ファイルへの編集が保存されていない場合、エディターには、保存されていない変更を保存するか破棄するかを決定するメッセージが表示されます。
- **保存**
    - 文字定義を保存します。 文字定義が存在しない (名前が指定されていない) 場合は、ファイル名を入力するための [名前を付けて保存] ダイアログ ボックスが表示されます。
- **名前を付けて保存**
    - [名前を付けて保存] ダイアログ ボックスを表示し、文字定義ファイルの新しい名前を入力できるようにします。
- **印刷**
    - [印刷] ダイアログ ボックスが表示され、印刷オプションを選択したり、文字定義ファイルを印刷したりできます。
- ビルド文字**の **
    - [文字のビルド] ダイアログ ボックスが表示されます。このダイアログ ボックスには、Microsoft エージェントで使用するキャラクターのデータ ファイルとアニメーション ファイルを作成する方法を定義するためのオプションが含まれています。
- **ページのセットアップ**
    - 文字定義ファイルの印刷オプションを設定できる [ページ設定] ダイアログ ボックスを表示します。
- 最近開いたファイルを
    - 開いた最近の文字定義ファイルを追跡します。 ファイルを選択すると、編集用にそのファイルが自動的に開きます。 既存の文字が読み込まれ、ファイルへの編集が保存されていない場合、エディターには、保存されていない変更を保存するか破棄するかを決定するメッセージが表示されます。
- **Exit**
    - エージェント文字エディターを終了します。 既存の文字が読み込まれ、ファイルへの編集が保存されていない場合、エディターには、保存されていない変更を保存するか破棄するかを決定するメッセージが表示されます。

## [編集] メニュー

- **元に戻す**
    - エディターで行った変更を削除します。
- **Redo**
    - エディターで元に戻す操作を元に戻します。
- **カット**
    - 選択した項目をエディターから削除し、Windows クリップボードに配置します。
- のコピー
    - エディターで選択した項目を Windows クリップボードにコピーします。
- **貼り付け**
    - 現在の Windows クリップボードから選択した場所にデータをコピーします。
- **削除**
    - 選択した項目をエディターから削除します。
- 新しいアニメーション**を ** する
    - エディターで新しいアニメーション オブジェクトを作成します。
- 新しいフレーム**を ** する
    - アニメーションの新しいフレームを作成します。
- ファイル**から新しいフレームを ** する
    - [イメージ ファイルの選択] ダイアログ ボックスを表示し、選択したファイルを使用してフレームを作成します。
- **フレーム ウィンドウを開く**
    - フレームに読み込まれたイメージをスケーリングせずに、現在のフレームとそのイメージを別のウィンドウに表示します。
- **プレビュー |プレビュー** の停止
    - 選択したフレームからアニメーションを再生 (または再生を停止) します。
- **プレビュー |Stop Preview Exit Branching**
    - 選択したフレームから開始して、アニメーションの終了分岐を再生 (または再生を停止) します。

## [ヘルプ] メニュー

- **ヘルプ トピック**
    - [ヘルプ トピック] ダイアログ ボックスが表示され、エディターのヘルプ トピックを選択できます。
- **Microsoft Agent Character Editor** について
    - エディターの著作権とバージョン情報を含むダイアログ ボックスを表示します。