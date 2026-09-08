---
layout: Conceptual
title: HelpComplete イベント - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/helpcomplete-event
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: HelpComplete イベント
document_id: 63895371-70f0-5bc2-90ad-e8e9018e8b8f
document_version_independent_id: 22db8074-f079-d1d1-b169-0e741b589170
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/helpcomplete-event.md
locale: ja-jp
ms.assetid: d805f089-154f-4b39-9d78-a02b732f87ed
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/helpcomplete-event.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:43:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-07-03T23:50:19.3460266Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/helpcomplete-event.md
page_type: conceptual
toc_rel: toc.json
word_count: 873
asset_id: lwef/helpcomplete-event
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 6d5f07be-15d4-0991-701f-cc5c49c87c59
---

# HelpComplete イベント - Win32 apps | Microsoft Learn

[Microsoft Agent は Windows 7 の時点で非推奨となり、後続のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 状況依存のヘルプ モードが終了したことを示します。
- **構文**
    - **Sub***agent.***(ByVal***CharacterID*\*\*, ByVal\*\* *Name*\*\*, ByVal\*\* *Cause*\*\*)\*\*

| 部分 | 説明 |
| --- | --- |
| *CharacterID* | クリックしたキャラクターの ID を文字列として返します。 |
| *名前* | コマンドの名前 (ID) を識別する文字列値を返します。 |
| *原因* | ヘルプ モードが完了した原因を示す値を返します。 1 ユーザーはアプリケーションから提供されたコマンドを選択しました。 2 ユーザーは別のクライアントの [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) オブジェクトを選択しました。 3 ユーザーが Open Voice Commands コマンドを選択しました。 4 ユーザーが Close Voice Commands コマンドを選択しました。 5 ユーザーが Show *CharacterName* コマンドを選択しました。 6 ユーザーが Hide *CharacterName* コマンドを選択しました。 7 ユーザーがキャラクターを選択 (クリック) しました。 |

### 解説

通常、ヘルプ モードは、ユーザーがキャラクターをクリックまたはドラッグするか、キャラクターのポップアップ メニューからコマンドを選択すると完了します。 別のキャラクターまたは画面上の他の場所をクリックしても、ヘルプ モードはキャンセルされません。 キャラクターのヘルプ モードを設定するクライアントは、[**HelpModeOn**](helpmodeon-property) を **False** に設定することでヘルプ モードをキャンセルできます。 (これによって **HelpComplete** イベントがトリガーされることはありません)

ユーザーがヘルプ モードでキャラクターのポップアップ メニューからコマンドを選択すると、サーバーはメニューを削除し、コマンドの指定した [**HelpContextID**](helpcontextid-property) でヘルプを呼び出し、このイベントを送信します。 状況依存 (ポップヒントとも呼ばれます) ヘルプ ウィンドウがポインターの位置に表示されます。 ユーザーが音声入力でコマンドを選択すると、そのキャラクターの上にヘルプ ウィンドウが表示されます。 キャラクターが画面外の場合、ウィンドウはキャラクターの現在位置に最も近い画面に表示されます。

サーバーが Name を空の文字列 ("") として返す場合は、ユーザーがサーバー指定のコマンドを選択したことを示します。

このイベントは、キャラクターをヘルプ モードにするクライアント アプリケーションにのみ送信されます。

### 参照

[**HelpModeOn プロパティ**](helpmodeon-property)、[**HelpContextID プロパティ**](helpcontextid-property)