---
layout: Conceptual
title: ツール バー ボタン (Microsoft エージェント文字エディター) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/toolbar-buttons-
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Microsoft エージェント文字エディターのツール バー ボタン ([新しいカスタム文字] ボタンなど) について説明します。
document_id: 1659ee53-4bcb-9a76-712a-6ca78b81cb6d
document_version_independent_id: 2b54f465-0ba2-6f76-fbaa-8d32ac415e76
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/toolbar-buttons-.md
locale: ja-jp
ms.assetid: 8867a038-d2c4-43c1-b994-bd3779a251b9
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/toolbar-buttons-.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:02:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/toolbar-buttons-.md
page_type: conceptual
toc_rel: toc.json
word_count: 978
asset_id: lwef/toolbar-buttons-
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: c9da0115-f571-3b3a-0a84-bb6844916ac6
---

# ツール バー ボタン (Microsoft エージェント文字エディター) - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

![](images/f9charnew.gif)

- 新しいカスタム文字**を ** する
    - 新しいカスタム文字定義を作成するためのエディターをリセットします。 既存の文字が読み込まれ、ファイルに対する編集が保存されていない場合、エディターには、保存されていない変更を保存するか破棄するかを決定するメッセージが表示されます。

![](images/f10charopen.gif)

- 文字定義**を開く **
    - [ファイルを開く] ダイアログ ボックスを表示し、編集用に既存の文字定義ファイルを開きます。 既存の文字が読み込まれ、ファイルに対する編集が保存されていない場合、エディターには、保存されていない変更を保存するか破棄するかを決定するメッセージが表示されます。

![](images/f11charsave.gif)

- 文字定義**を保存する **
    - 文字定義を保存します。 文字定義が存在しない (名前が指定されていない) 場合は、ファイル名を入力するための [名前を付けて保存] ダイアログ ボックスが表示されます。

![](images/f12charbuild.gif)

- ビルド文字**の **
    - 文字定義から Microsoft エージェント文字をビルドします。

![](images/f13charprint.gif)

- 文字定義**を印刷する **
    - エディターで開いている現在の文字定義ファイルを出力します。

![](images/f14charcut.gif)

- **カット**
    - エディターで選択した項目を削除し、Windows クリップボードに配置します。

![](images/f15charcopy.gif)

- のコピー
    - エディターで選択した項目を Windows クリップボードにコピーします。

![](images/f16charpaste.gif)

- **貼り付け**
    - 現在の Windows クリップボードから選択した場所にデータをコピーします。

![](images/f17chardel.gif)

- **削除**
    - 選択した項目をエディターから削除します。

![](images/f18charundo.gif)

- **元に戻す**
    - エディターで行った変更を削除します。

![](images/f19charredo.gif)

- **Redo**
    - エディターで元に戻す操作を元に戻します。

![](images/f20charaanim.gif)

- 新しいアニメーション**を ** する
    - エディターで新しいアニメーション オブジェクトを作成します。

![](images/f21charanfr.gif)

- 新しいアニメーション フレーム**を ** する
    - アニメーションの新しいフレームを作成します。

![](images/f22charprev.gif)

- **プレビュー**
    - 選択したフレームからアニメーションを再生します。

![](images/f23charprevex.gif)

- **Preview Exit Branching**
    - 選択したフレームから開始して、アニメーションの終了分岐を再生します。

![](images/f24charstop.gif)

- **プレビューの停止**
    - アニメーションのプレビューの再生を停止します。

![](images/f25charadd.gif)

- **イメージ ファイルの追加**
    - [イメージ ファイルの選択] ダイアログ ボックスを表示します。 選択した画像が一覧に追加されます。

![](images/f26charmvup.gif)

- **上に移動**
    - 並べ替え済み (z 順) リスト内の画像を上に移動します。 フレームの画像リストでは、画像が z オーダーで上に移動します。

![](images/f27charmvdwn.gif)

- **下へ移動**
    - 並べ替え済み (z オーダー) リスト内の画像を下に移動します。 フレームの画像リストでは、画像が z オーダーで下方向に移動します。