---
layout: Conceptual
title: IAgentNotifySink Move - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentnotifysink--move
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentNotifySink Move
document_id: 36c0b953-92fc-3fc2-977f-346612ffb985
document_version_independent_id: 6577d529-5971-ee2b-e067-9d4569f7c58f
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentnotifysink--move.md
locale: ja-jp
ms.assetid: d1809fdb-df4b-4884-b9e8-2877a814dc9a
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentnotifysink--move.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:52:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-07-03T23:50:19.3460266Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentnotifysink--move.md
page_type: conceptual
toc_rel: toc.json
word_count: 498
asset_id: lwef/iagentnotifysink--move
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: ff0c05e2-2580-aca2-cdfa-48fe6290fb52
---

# IAgentNotifySink Move - Win32 apps | Microsoft Learn

[Microsoft Agent は Windows 7 の時点で非推奨となり、後続のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT Move(
   long dwCharID,  // character ID
   long x,         // x-coordinate of new location
   long y,         // y-coordinate of new location
   long dwCause    // cause of move state
);                          
```

キャラクターが移動されたときにクライアント アプリケーションに通知します。

- 戻り値はありません。

- *dwCharID*
    - 移動されたキャラクターの識別子。
- *x*
    - 画面の原点 (左上) を基準とした新しい位置の x 座標 (ピクセル単位)。 キャラクターの位置は、アニメーション フレームの左上隅が基準になります。
- *y*
    - 画面の原点 (左上) を基準とした新しい位置の y 座標 (ピクセル単位)。 キャラクターの位置は、アニメーション フレームの左上隅が基準になります。
- *dwCause*
    - キャラクター移動の原因。 パラメーターは次のいずれかになります。

| 値 | 説明 |
| --- | --- |
| **const unsigned short** **NeverMoved = 0;** | キャラクターは移動されていません。 |
| **const unsigned short** **UserMoved = 1;** | ユーザーがキャラクターをドラッグしました。 |
| **const unsigned short** **ProgramMoved = 2;** | アプリケーションがキャラクターを移動しました。 |
| **const unsigned short** **OtherProgramMoved = 3;** | 別のアプリケーションがキャラクターを移動しました。 |
| **const unsigned short** **SystemMoved = 4** | 画面の解像度が変更された後も画面に表示し続けるためにサーバーがキャラクターを移動しました。 |

このイベントは、キャラクターのすべてのクライアントに送信されます。