---
layout: Conceptual
title: CommandsWindow オブジェクト - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/the-commandswindow-object
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: CommandsWindow オブジェクト
document_id: b706958c-ccf6-e390-f9d8-74c413383aa5
document_version_independent_id: 841ae551-1591-36fe-59dc-1722c77705ce
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/the-commandswindow-object.md
locale: ja-jp
ms.assetid: f7f37499-f16b-47fb-85d1-23a68171bf0b
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/the-commandswindow-object.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:02:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/the-commandswindow-object.md
page_type: conceptual
toc_rel: toc.json
word_count: 432
asset_id: lwef/the-commandswindow-object
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 587c22fd-2131-647e-0716-1fe0bc4d609b
---

# CommandsWindow オブジェクト - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

[**CommandsWindow**](/ja-jp/windows/desktop/lwef/the-commandswindow-object) オブジェクトは、音声コマンド ウィンドウのプロパティにアクセスできます。 音声コマンド ウィンドウは、主にユーザーが音声対応コマンドを表示できるように設計された共有リソースです。 音声認識が無効になっている場合、音声コマンド ウィンドウは引き続き表示され、テキスト "Speech input disabled" (文字の言語で) が表示されます。 ウィンドウに表示される文字の言語設定に一致する音声エンジンがインストールされていない場合は、「音声入力は使用できません」と表示されます。入力アクティブなクライアントがコマンドの音声パラメーターを定義せず、グローバル音声コマンドを無効にした場合、ウィンドウに "音声コマンドなし" と表示されます。音声入力が無効になっているか、互換性のある音声エンジンがインストールされているかどうかに関係なく、[音声コマンド] ウィンドウのプロパティに対してクエリを実行することもできます。

- [CommandsWindow プロパティ](commandswindow-properties)