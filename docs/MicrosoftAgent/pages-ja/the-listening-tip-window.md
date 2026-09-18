---
layout: Conceptual
title: '[リッスンヒント] ウィンドウ - Win32 apps | Microsoft Learn'
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/the-listening-tip-window
schema: Conceptual
author: QuinnRadich
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: '[リッスンヒント] ウィンドウ'
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/0180b6dbcaa133e58745702bf0ebefa871ee151b/desktop-src/lwef/the-listening-tip-window.md
locale: ja-jp
ms.assetid: 8f7075ed-1ce9-4528-9f02-95552a8446b6
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/the-listening-tip-window.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-08-20T17:41:00.0000000Z
feedback_system: Standard
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2022-09-20T02:42:24.4530879Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/the-listening-tip-window.md
page_type: conceptual
toc_rel: toc.json
feedback_product_url: ''
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 215
asset_id: lwef/the-listening-tip-window
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 71f983e0-893f-c654-371f-47603e3f0588
---

# [リッスンヒント] ウィンドウ - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンのWindowsでは使用できない場合があります。

音声が有効になっている場合は、ユーザーがプッシュツートーク キーを押して音声入力を開始すると、特別なツールヒント ウィンドウが表示されます。 リッスン ヒントには、Microsoft エージェントの現在の入力状態に関連するコンテキスト情報が表示されます。 互換性のある音声認識がインストールされていないか、無効になっている場合、リッスン ヒントは表示されません。

![genie text box](images/f4ltip.gif)