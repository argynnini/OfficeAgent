---
layout: Conceptual
title: 文字ウィンドウ - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/the-character-window
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: 文字ウィンドウ
document_id: 983b6634-47d0-c9df-993f-b731d3ba473c
document_version_independent_id: 71d46f35-8c7f-0422-0bd9-c6cec49df569
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/the-character-window.md
locale: ja-jp
ms.assetid: 92b6111f-b52d-4720-8bd9-59585d826bf5
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/the-character-window.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:02:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/the-character-window.md
page_type: conceptual
toc_rel: toc.json
word_count: 834
asset_id: lwef/the-character-window
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 8fd157bd-bfed-7299-3860-d965a7f57335
---

# 文字ウィンドウ - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

Microsoft エージェントは、アニメーション化されたキャラクターを独自のウィンドウに表示します。これは常にウィンドウの z オーダーの上部に表示されます (つまり、常に上に表示されます)。 ユーザーは、マウスの左ボタンを使用して文字をドラッグすることで、文字のウィンドウを移動できます。 文字イメージはポインターと共に移動します。 さらに、アプリケーションは [**MoveTo**](moveto-method) メソッドを使用して文字を移動できます。

ユーザーが文字を右クリックすると、次のコマンドを表示するポップアップ メニューが表示されます。

開く |[ Close Voice Commands]\(V oice コマンド ウィンドウを閉じる\)

Hide

----------------------------…

コマンド\*

*OtherHostingApplicationCaption\*\**

\*一覧表示されるコマンドは、入力アクティブなクライアントに基づいています。 ポップアップ メニューに表示されるコマンドの定義の詳細については、「Microsoft エージェント プログラミング インターフェイスの概要」を参照してください。

\*\*一覧表示されているエントリは、現在文字をホストしている他のすべてのアプリケーションです。 このエントリの定義の詳細については、「Microsoft エージェント プログラミング インターフェイスの概要」を参照してください。

オープン |[音声コマンド ウィンドウを閉じる] コマンドは、現在アクティブな文字のコマンド ウィンドウの表示を制御します。 音声認識サービスが無効になっている場合、このコマンドは無効になります。 音声認識サービスがインストールされていない場合、このコマンドは表示されません。

[非表示] コマンドは文字を非表示にします。 キャラクタの **非表示** 状態に割り当てられたアニメーションは、キャラクタを再生および非表示にします。 hide の文字 "H" は、コマンドのアクセス キー (ニーモニック) です。

文字を現在ホストしているアプリケーションのコマンドは、前に区切り記号が付いた Hide コマンドに従います。 その後、文字を使用する他のアプリケーションの名前が表示され、その前に区切り記号が付きます。