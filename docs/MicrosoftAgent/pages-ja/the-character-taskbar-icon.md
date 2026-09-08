---
layout: Conceptual
title: 文字タスク バー アイコン - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/the-character-taskbar-icon
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: 文字タスク バー アイコン
document_id: df26948b-c037-2616-fa5f-5aad6315b736
document_version_independent_id: f64a3815-49b9-b29d-baa4-a359e34def9e
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/the-character-taskbar-icon.md
locale: ja-jp
ms.assetid: b1db7151-b367-4708-897e-0695988163e8
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/the-character-taskbar-icon.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:02:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/the-character-taskbar-icon.md
page_type: conceptual
toc_rel: toc.json
word_count: 488
asset_id: lwef/the-character-taskbar-icon
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: a9cdfb02-504d-3311-5b91-17ca32c1e4ca
---

# 文字タスク バー アイコン - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

アイコンを含むように文字が作成されている場合、Microsoft エージェントの実行時にタスク バーの通知領域にアイコンが表示されます。 このアイコンを使用すると、文字のポップアップ メニューにアクセスできます。これにより、文字を非表示にして表示するコマンドなど、エージェントのグローバル コマンドにアクセスできます。

![時計とアイコン付きの通知領域](images/f1tbicon.gif)

タスク バー アイコンの上にポインターを移動すると、(システムの現在の言語で) 文字の名前を反映するヒント ウィンドウが表示されます。 文字のタスク バー アイコンをクリックすると、文字が表示されます。 アイコンのダブルクリックに関連するアクションは、その文字を制御している現在のアプリケーションによって異なります。

アイコンを右クリックすると、ポップアップ メニューが表示されます。 文字が表示されている場合、ポップアップ メニューには、文字を右クリックしたときに表示されるものと同じコマンドが表示されます。 文字が非表示の場合は、[音声コマンド ウィンドウを開く (または閉じる)] コマンドと [表示] コマンドのみが表示されます。