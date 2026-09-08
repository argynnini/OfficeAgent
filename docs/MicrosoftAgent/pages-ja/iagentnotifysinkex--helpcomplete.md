---
layout: Conceptual
title: IAgentNotifySinkEx HelpComplete - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentnotifysinkex--helpcomplete
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentNotifySinkEx HelpComplete
document_id: 6905c3aa-ef72-7a8e-43e3-bb6f04faed86
document_version_independent_id: 6e6f0b90-1dda-2acd-1023-87b1129b77c7
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentnotifysinkex--helpcomplete.md
locale: ja-jp
ms.assetid: f8285d05-3b96-4046-a058-0e001e47b54b
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentnotifysinkex--helpcomplete.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:52:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-07-03T23:50:19.3460266Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentnotifysinkex--helpcomplete.md
page_type: conceptual
toc_rel: toc.json
word_count: 982
asset_id: lwef/iagentnotifysinkex--helpcomplete
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 203a3c77-7ba5-d8ca-48f1-a718f083c2ef
---

# IAgentNotifySinkEx HelpComplete - Win32 apps | Microsoft Learn

[Microsoft Agent は Windows 7 の時点で非推奨となり、後続のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT HelpComplete(
   long dwCharID,     // character ID
   long dwCommandID,  // command ID
   long dwCause       // cause 
);
```

ユーザーがヘルプ モードを完了するためにコマンドまたは文字を選択すると、クライアント アプリケーションに通知します。

- 戻り値はありません。

- *dwCharID*
    - ヘルプ モードが完了した文字の識別子。
- *dwCommandID*
    - ユーザーが選択したコマンドの識別子。
- *dwCause*
    - イベントの原因。次の値になります。

| 値 | 説明 |
| --- | --- |
| **定数符号なしショート** **CSHELPCAUSE\_COMMAND = 1;** | ユーザーはアプリケーションによって提供されたコマンドを選択しました。 |
| **定数符号なしショート** **CSHELPCAUSE\_OTHERPROGRAM = 2;** | ユーザーは別のクライアントの [**コマンド**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) オブジェクトを選択しました。 |
| **定数符号なしショート** **CSHELPCAUSE\_OPENCOMMANDSWINDOW = 3;** | ユーザーは「Voice コマンドを開く」コマンドを選択しました。 |
| **定数符号なしショート** **CSHELPCAUSE\_CLOSECOMMANDSWINDOW = 4;** | ユーザーは「Voice コマンドを閉じる」コマンドを選択しました。 |
| **定数符号なしショート** **CSHELPCAUSE\_SHOWCHARACTER = 5;** | ユーザーは「*CharacterName* の表示」コマンドを選択しました。 |
| **定数符号なしショート** **CSHELPCAUSE\_HIDECHARACTER = 6;** | ユーザーは、 *CharacterName* を非表示コマンドを選択しました。 |
| **定数符号なしショート** **CSHELPCAUSE\_CHARACTER = 7;** | ユーザーが文字を選択（クリック）しました。 |

通常、ヘルプ モードは、ユーザーが文字をクリックまたはドラッグするか、文字のポップアップ メニューからコマンドを選択すると完了します。 別の文字や画面上の他の場所をクリックしても、ヘルプ モードはキャンセルされません。 キャラクターにヘルプ モードを設定したクライアントは、 [**IAgentCharacter::HelpModeOn**](https://www.bing.com/search?q=**IAgentCharacter::HelpModeOn**) を **False** に設定することでヘルプ モードをキャンセルできます。 (これにより、**IAgentNotifySinkEx::HelpComplete** イベントはトリガーされません。)

ユーザーがヘルプ モードでキャラクターのポップアップ メニューからコマンドを選択すると、サーバーはメニューを削除し、コマンドの指定された [**HelpContextID**](helpcontextid-property) を使用してヘルプを呼び出し、このイベントを送信します。 状況依存 (ポップヒントとも呼ばれます) ヘルプ ウィンドウがポインターの位置に表示されます。 ユーザーが音声入力でコマンドを選択すると、そのキャラクターの上にヘルプ ウィンドウが表示されます。 キャラクターが画面外にいる場合、ウィンドウはキャラクターの現在の位置に最も近い画面上に表示されます。

サーバーが *dwCommandID* を空の文字列 ("") として返す場合、ユーザーがサーバー提供のコマンドを選択したことを示します。

このイベントは、キャラクターをヘルプ モードにするクライアント アプリケーションにのみ送信されます。