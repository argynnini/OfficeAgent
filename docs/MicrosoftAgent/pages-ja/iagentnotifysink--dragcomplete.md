---
layout: Conceptual
title: IAgentNotifySink DragComplete - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentnotifysink--dragcomplete
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentNotifySink DragComplete
document_id: b82c8909-2534-86e8-024e-a5704fbd0813
document_version_independent_id: 6b522c8f-947e-5139-08ba-ec40025bdd4e
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentnotifysink--dragcomplete.md
locale: ja-jp
ms.assetid: b2d9b9c2-709e-4988-aa92-f129e3836fc7
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentnotifysink--dragcomplete.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:52:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentnotifysink--dragcomplete.md
page_type: conceptual
toc_rel: toc.json
word_count: 317
asset_id: lwef/iagentnotifysink--dragcomplete
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 34fe8cb0-a1d7-e1be-2155-af7cd9400747
---

# IAgentNotifySink DragComplete - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT DragComplete(
   long dwCharID,  // character ID
   short fwKeys,   // mouse button and modifier key state
   long x,         // x-coordinate of mouse pointer
   long y          // y-coordinate of mouse pointer
);                          
```

ユーザーが文字のドラッグを停止したときにクライアント アプリケーションに通知します。

- 戻り値はありません。

- dwCharID*の *
    - ドラッグされた文字の識別子。
- fwKeys*を * する
    - マウス ボタンと修飾子キーの状態を示すパラメーター。 このパラメーターは、次の任意の組み合わせを返すことができます。

| 価値 | 形容 |
| --- | --- |
| 0x0001 | 左ボタン |
| 0x0010 | 中央ボタン |
| 0x0002 | 右ボタン |
| 0x0004 | Shift キーを下へ移動 |
| 0x0008 | Control Key Down |
| 0x0020 | Alt キーを押しながら下へ |
- *x*
    - 画面の原点 (左上) を基準としたマウス ポインターの x 座標 (ピクセル単位)。
- *y*
    - 画面の原点 (左上) に対するマウス ポインターの y 座標 (ピクセル単位)。