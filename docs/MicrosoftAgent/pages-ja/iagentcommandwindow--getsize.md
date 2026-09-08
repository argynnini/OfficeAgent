---
layout: Conceptual
title: IAgentCommandWindow GetSize - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcommandwindow--getsize
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCommandWindow GetSize
document_id: eb9581d4-5ea0-76bd-38b3-9e82e27245b6
document_version_independent_id: 06484141-84f6-1eda-f2f9-ac9404715e13
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentcommandwindow--getsize.md
locale: ja-jp
ms.assetid: 24ad3b48-6557-4790-b9c4-2cf7df92fa7d
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommandwindow--getsize.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:51:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcommandwindow--getsize.md
page_type: conceptual
toc_rel: toc.json
word_count: 221
asset_id: lwef/iagentcommandwindow--getsize
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: b3fdf88c-44b6-3e22-243a-779d1a685bab
---

# IAgentCommandWindow GetSize - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT GetSize(
   long * plWidth,  // address of variable for Voice Commands Window width
   long * plHeight  // address of variable for Voice Commands Window height
);
```

音声コマンド ウィンドウの現在のサイズを取得します。

- 操作が成功したことを示すS\_OKを返します。

- plWidth*を * する
    - 画面の原点 (左上) を基準に、音声コマンド ウィンドウの幅をピクセル単位で受け取る変数のアドレス。
- *plHeight*
    - 画面の原点 (左上) を基準に、音声コマンド ウィンドウの高さをピクセル単位で受け取る変数のアドレス。