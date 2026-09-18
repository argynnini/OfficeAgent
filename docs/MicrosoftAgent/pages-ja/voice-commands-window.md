---
layout: Conceptual
title: '[音声コマンド] ウィンドウ - Win32 apps | Microsoft Learn'
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/voice-commands-window
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: '[音声コマンド] ウィンドウ'
document_id: 7896e2ec-16e4-fca3-b5f3-c996c42ed4b0
document_version_independent_id: d0a21aa9-9752-9d18-949a-dc10aaa7c7b9
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/voice-commands-window.md
locale: ja-jp
ms.assetid: vs|msagent|~\guidlin_12gn.htm
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/voice-commands-window.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:04:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/voice-commands-window.md
page_type: conceptual
toc_rel: toc.json
word_count: 1721
asset_id: lwef/voice-commands-window
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: c821ecff-1590-c7b2-c8b0-c96c339e25de
---

# [音声コマンド] ウィンドウ - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

[音声コマンド] ウィンドウには、キャラクターに使用できる現在のアクティブな音声コマンドが表示されます。 [コマンド ウィンドウを開く] コマンドを選択するか、[**CommandsWindow**](/ja-jp/windows/desktop/lwef/the-commandswindow-object) オブジェクトの [**Visible**](visible-property) プロパティを True 設定すると、ウィンドウが表示されます。 音声エンジンがまだ読み込まれていない場合は、このプロパティをクエリまたは設定すると、Microsoft エージェントがエンジンの初期化を試みます。 ユーザーが音声を無効にした場合でも、ウィンドウを表示できます。ただし、音声が現在無効になっていることをユーザーに通知するテキスト メッセージが含まれます。

入力/アクティブなクライアントのコマンドは、[**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションの [**VoiceCaption**](voicecaption-property) の下に表示される [**Voice**](voice-property)[**Caption**](caption-property) および **Voice** プロパティ設定に基づいて、[音声コマンド] ウィンドウに表示されます。

**図 1. [音声コマンド] ウィンドウ**

[コマンド ウィンドウを開く] コマンドを選択すると、[音声コマンド] ウィンドウが表示されます。 入力/アクティブなクライアントのコマンドは、[[**コマンド\]**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションの [**\[音声 の\] の下に表示される \[音声**](voice-property)[**キャプション**](caption-property) と **Voice** プロパティの設定に基づいて、[音声コマンド] ウィンドウに表示されます。

また、[音声コマンド] ウィンドウには、文字の他のクライアント用の [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションの [**VoiceCaption**](voicecaption-property) と、[グローバル コマンド] エントリでの一般的な操作のための次のサーバー生成音声コマンドも一覧表示されます。

| 音声キャプション | 音声文法 |
| --- | --- |
| 開く |音声コマンド ウィンドウを閉じる | (開いている | 表示)[the] コマンド [ウィンドウ] |私は何を言うことができます [今] 次のトグルが表示されます。 [the] コマンドを閉じる [ウィンドウ] |
| 隠れる | 隠れる\* |
| CharacterName *を* する | *CharacterName*\*\* |
| グローバル コマンド | [表示][me] グローバル コマンド |

\* 現在表示されている場合にのみ、ここに文字が表示されます。

\*\* 読み込まれたすべての文字が一覧表示されます。

別のクライアントの [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションの音声コマンドを話すと、そのクライアントに切り替え、[音声コマンド] ウィンドウにそのクライアントのコマンドが表示されます。 他のエントリは展開されません。 同様に、ユーザーが文字を切り替えた場合、音声コマンド ウィンドウが変更され、入力/アクティブ クライアントのコマンドが表示されます。 クライアントが既に入力アクティブである場合、その音声コマンドの 1 つを話しても効果はありません。 (ただし、ユーザーがアクティブなクライアントのサブツリーをマウスで折りたたんだ場合、クライアント名を話すとクライアントのサブツリーが再表示されます)。

クライアントに音声コマンドがあるが、[**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) オブジェクトの [**Voice**](voice-property) 設定がない場合 (または、**Voice**[**Caption**](caption-property)がない場合)、ツリーは親エントリとして "(コマンド未定義)" を表示します。ただし、そのクライアントが入力アクティブであり、クライアントがコレクション内に **Caption** と **Voice** 設定を持つコマンドがある場合にのみ表示されます。

サーバーは、現在の入力アクティブなクライアントのコマンドを自動的に表示し、必要に応じてウィンドウをスクロールして、ウィンドウのサイズに基づいて、できるだけ多くのクライアントのコマンドを表示します。 文字にクライアント エントリがない場合は、グローバル コマンド エントリが展開されます。

ユーザーが "グローバル コマンド" と読み上げる場合、音声コマンド ウィンドウには常に関連付けられているサブツリー エントリが表示されます。 既に表示されている場合、コマンドは無効です。

[**Visible**](visible-property) プロパティを使用して、アプリケーションのコードから音声コマンド ウィンドウを表示または非表示にすることもできますが、音声コマンド ウィンドウのサイズや場所を変更することはできません。 サーバーは、ユーザーのウィンドウとの対話に基づいて、音声コマンド ウィンドウのプロパティを保持します。 最初の位置は、キャラクターのタスク バー アイコンのすぐ隣にあります。

音声コマンド ウィンドウは、Alt + TAB ウィンドウの順序に含まれています。 これにより、ユーザーはウィンドウに切り替えて、キーボードを使用してウィンドウのスクロール、サイズ変更、位置変更を行えます。

- リスニング ヒントの [を](the-listening-tip) する
- [文字オプションの詳細設定] ウィンドウの [を](https://www.bing.com/search?q=The+Advanced+Character+Options+Window) する