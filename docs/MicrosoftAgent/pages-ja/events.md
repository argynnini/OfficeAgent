---
layout: Conceptual
title: IAgentNotifySink - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/events
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentNotifySink
document_id: 5365cf38-fd37-eb4d-1587-78288aadbf7c
document_version_independent_id: 69d15307-d777-fe16-a3e4-414a3fec8dd5
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/events.md
locale: ja-jp
ms.assetid: vs|msagent|~\paface_2xet.htm
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/events.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:42:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/events.md
page_type: conceptual
toc_rel: toc.json
word_count: 611
asset_id: lwef/events
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: fef37f4b-b4b3-aeaf-99b0-fb5e6db6123e
---

# IAgentNotifySink - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

IAgentNotifySink は、特定の状態変更が発生したときにクライアントに通知します。 これらの関数は、[IAgentNotifySinkEx](iagentnotifysinkex)からも使用できます。

Vtable Order **のメソッドを** する

| IAgentNotifySink | 形容 |
| --- | --- |
| [**コマンド**](command-method) | サーバーがクライアント定義コマンドを処理するときに発生します。 |
| ActivateInputState**[の](iagentnotifysink--activateinputstate)** | 文字が入力アクティブになったり、入力が終了したりしたときに発生します。 |
| [**BalloonVisibleState**](iagentnotifysink---balloonvisiblestate) | 文字の **Visible** 状態が変化したときに発生します。 |
| [**イベント**](click-event) をクリックする | 文字がクリックされたときに発生します。 |
| DblClick イベント**[の](dblclick-event)** | 文字がダブルクリックされたときに発生します。 |
| [**DragStart**](/ja-jp/windows/desktop/lwef/dragstart-event) | ユーザーが文字のドラッグを開始したときに発生します。 |
| [**DragComplete**](https://www.bing.com/search?q=**DragComplete**) | ユーザーが文字のドラッグを停止したときに発生します。 |
| [**RequestStart**](iagentnotifysink--requeststart) | サーバーが [**Request**](/ja-jp/windows/desktop/lwef/the-request-object) オブジェクトの処理を開始したときに発生します。 |
| [**RequestComplete**](iagentnotifysink--requestcomplete) | サーバーが [**Request**](/ja-jp/windows/desktop/lwef/the-request-object) オブジェクトの処理を完了したときに発生します。 |
| [**ブックマーク**](iagentnotifysink--bookmark) | サーバーがブックマークを処理するときに発生します。 |
| アイドル**[の](iagentnotifysink--idle)** | サーバーがアイドル処理を開始または終了したときに発生します。 |
| [**移動**](iagentnotifysink--move) | 文字が移動されたときに発生します。 |
| [**サイズ**](iagentnotifysink---size) | 文字のサイズが変更されたときに発生します。 |
| [**BalloonVisibleState**](iagentnotifysink---balloonvisiblestate) | 文字のワード バルーンの表示状態が変更されたときに発生します。 |

以前のバージョンの Microsoft エージェントでサポートされている IAgentNotifySink::Restart イベントと IAgentNotifySink::Shutdown イベントは廃止されました。 下位互換性のためにサポートされていますが、サーバーはこれらのイベントを送信しなくなりました。