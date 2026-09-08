---
layout: Conceptual
title: IAgentCommandWindow GetPosition - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcommandwindow--getposition
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCommandWindow GetPosition
document_id: 5f2541fb-ccce-5b57-3d55-e7feb3d4c86e
document_version_independent_id: 78a691c2-0422-bd1e-08f5-376bea845bad
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentcommandwindow--getposition.md
locale: ja-jp
ms.assetid: d85a7a2c-f0ea-4612-aa73-2e44c49e4e18
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommandwindow--getposition.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:51:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcommandwindow--getposition.md
page_type: conceptual
toc_rel: toc.json
word_count: 235
asset_id: lwef/iagentcommandwindow--getposition
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 341e094b-4937-cc55-88f0-2608bcdac477
---

# IAgentCommandWindow GetPosition - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT GetPosition(
   long * plLeft,  // address of variable for left edge of Voice Commands Window
   long * plTop    // address of variable for top edge of Voice Commands Window
);
```

音声コマンド ウィンドウの位置を取得します。

- 操作が成功したことを示すS\_OKを返します。

- plLeft*を * する
    - 画面の原点 (左上) を基準に、音声コマンド ウィンドウの左端の画面座標をピクセル単位で受け取る変数のアドレス。
- plTop*を * する
    - 画面の原点 (左上) を基準に、音声コマンド ウィンドウの上端の画面座標をピクセル単位で受け取る変数のアドレス。