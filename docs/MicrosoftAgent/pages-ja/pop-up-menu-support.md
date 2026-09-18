---
layout: Conceptual
title: ポップアップ メニューのサポート - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/pop-up-menu-support
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: ポップアップ メニューのサポート
document_id: af577a70-7e82-2196-c1b5-68cc4e9ebd38
document_version_independent_id: 504c3485-0a0e-5c2b-75cf-a8d1a5f7a45b
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/pop-up-menu-support.md
locale: ja-jp
ms.assetid: a8a1cf91-c18a-497f-89a7-b47536eaca0a
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/pop-up-menu-support.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:59:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-01-09T19:49:59.6397822Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/pop-up-menu-support.md
page_type: conceptual
toc_rel: toc.json
word_count: 1101
asset_id: lwef/pop-up-menu-support
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: de2e7233-b797-feb2-5df0-889bb61908e6
---

# ポップアップ メニューのサポート - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

Microsoft エージェントには、各文字のポップアップ メニュー (コンテキスト メニューとも呼ばれます) が含まれています。 ユーザーが文字を右クリックすると、サーバーによってこのポップアップ メニューが自動的に表示されます。 [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションを定義することで、クライアント アプリケーションのコマンドをメニューに追加できます。 定義するコレクション内の各コマンドに対して、Caption**[プロパティ](caption-property)**指定したり、Visible**[プロパティ](visible-property)**したりできます。 **キャプション** は、**Visible** プロパティが True に設定されている場合にメニューに表示されるテキストです。 [**Enabled**](enabled-property) プロパティを使用して、メニューにコマンドを無効として表示したり、[**HelpContextID**](helpcontextid-property) を使用してプロパティのヘルプ サポートをサポートしたりすることもできます。 **Caption** テキスト設定のテキスト文字の前にアンパサンド (&) を含めることで、メニュー テキストのアクセス キーを定義します。

サーバーは、音声コマンド ウィンドウを開いて文字を非表示にするためのメニュー コマンドに自動的に追加します。また、[**コマンド**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) 文字の他のクライアントのキャプションを使用して、ユーザーがクライアントを切り替えることができます。 サーバーは、メニューエントリとクライアントによって定義されたメニューの間に自動的に区切り記号を追加します。 区切り記号は、分離する項目がメニューに存在する場合にのみ表示されます。

メニューからコマンドを削除するには、[**Remove**](remove-method) メソッドを使用します。 メニューが表示されている間、メニュー エントリは変更されないことに注意してください。 コマンドを追加または削除したり、そのプロパティを変更したりすると、ユーザーがメニューを再表示したときにメニューに変更が表示されます。

文字に独自のポップアップ メニュー サービスを提供する場合は、[**AutoPopupMenu**](autopopupmenu-property) プロパティを使用して、右クリック アクションのサーバー処理を無効にすることができます。 その後、[**Click**](click-event) イベント通知を使用して、独自のメニュー処理動作を作成できます。

ユーザーがキャラクターのポップアップ メニューまたは音声コマンド ウィンドウからコマンドを選択すると、サーバーは関連付けられたクライアントの [**Command**](command-event) イベントをトリガーし、[**UserInput**](/ja-jp/windows/desktop/lwef/iagentuserinput) オブジェクトを使用して入力のパラメーターを返します。

サーバーには、キャラクターのタスク バー アイコンのポップアップ メニューも用意されています。 文字が表示されている場合、このメニューを右クリックすると、文字を右クリックして表示されるものと同じコマンドが表示されます。 ただし、文字が非表示の場合は、サーバー指定のコマンドのみが含まれます。