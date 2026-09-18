---
layout: Conceptual
title: '[音声コマンド] ウィンドウ - Win32 apps | Microsoft Learn'
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/the-voice-commands-window
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: '[音声コマンド] ウィンドウ'
document_id: 8572db5e-99fe-fe15-4cd8-23d3e6d28095
document_version_independent_id: 04905c97-d824-52d5-073f-a32e3a1620c7
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/the-voice-commands-window.md
locale: ja-jp
ms.assetid: 4cbf1eeb-be35-46e5-87c0-08e022db621c
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/the-voice-commands-window.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:02:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/the-voice-commands-window.md
page_type: conceptual
toc_rel: toc.json
word_count: 742
asset_id: lwef/the-voice-commands-window
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 4c619dd5-8a56-6e58-3ed1-f9dc65bb3f91
---

# [音声コマンド] ウィンドウ - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

互換性のある音声エンジンがインストールされている場合、Microsoft エージェントは、音声認識用に音声が有効になっているコマンドを表示する **音声コマンド ウィンドウ** と呼ばれる特別なウィンドウを提供します。 **音声コマンド ウィンドウ** は、入力として読み上げることができるものに対する視覚的プロンプトとして機能します (マウスではコマンドを選択できません)。

![の音声コマンドダイアログボックス](images/f2voice.gif)

ユーザーが、音声コマンドを話すか、キャラクターを右クリックしてポップアップメニューからコマンドを選択することで、**音声コマンドウィンドウを開く** コマンドを選択すると、このウィンドウが表示されます。 ただし、ユーザーが音声入力を無効にした場合、**音声コマンド ウィンドウ** にはアクセスできません。

**音声コマンド ウィンドウ** では、音声対応コマンドがツリーとして表示されます。 現在のホスティング アプリケーションで音声コマンドが提供されている場合は、展開されてウィンドウの上部に表示されます。 エントリは、文字を使用する他のアプリケーションにも表示されます。 このウィンドウには、Microsoft エージェントによって提供されるグローバル音声コマンドも含まれます。 現在のホスティング アプリケーションに音声コマンドがない場合は、グローバル音声コマンドが展開され、ウィンドウの上部に表示されます。

ユーザーは、**音声コマンド ウィンドウ**サイズを変更して移動できます。 Microsoft エージェントは、ウィンドウの最後の場所を記憶し、ユーザーがウィンドウを閉じて再度開いた場合に、その場所で再表示します。 ウィンドウ内のエントリがウィンドウの現在の表示サイズを超えると、スクロール バーが表示されます。