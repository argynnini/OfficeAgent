---
layout: Conceptual
title: IAgentCommandWindow - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcommandwindow
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCommandWindow
document_id: b299cccc-0c3f-c826-89f6-17acacb19861
document_version_independent_id: 905df70c-961b-8de3-0417-4ae091937eb2
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentcommandwindow.md
locale: ja-jp
ms.assetid: 315b24b4-110e-4373-a1ee-0317531e6008
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommandwindow.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:51:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcommandwindow.md
page_type: conceptual
toc_rel: toc.json
word_count: 567
asset_id: lwef/iagentcommandwindow
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: e9587875-b1b4-acd2-8019-9b40d1c38eca
---

# IAgentCommandWindow - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

**IAgentCommandWindow** は、アプリケーションが音声コマンド ウィンドウのプロパティを設定およびクエリできるようにするインターフェイスを定義します。 音声コマンド ウィンドウは、主にユーザーが音声対応コマンドを表示できるように設計された共有リソースです。 音声認識が無効になっている場合、音声コマンド ウィンドウは引き続き表示され、"音声入力は無効" というテキストが表示されます (文字の言語)。 文字の言語設定に一致する音声エンジンがインストールされていない場合、ウィンドウに "音声入力が使用できません" と表示されます。入力アクティブなクライアントがコマンドの音声パラメーターを定義せず、グローバル音声コマンドを無効にしている場合、ウィンドウに "音声コマンドなし" と表示されます。音声入力が無効になっているか、互換性のある音声エンジンがインストールされているかに関係なく、[音声コマンド] ウィンドウのプロパティを照会することもできます。

Vtable Order **のメソッドを** する

| IAgentCommandWindow メソッド | 形容 |
| --- | --- |
| SetVisible**[の](iagentcommandwindow--setvisible)** | [音声コマンド] ウィンドウの [**Visible**](visible-property) プロパティの値を設定します。 |
| GetVisible**[の](iagentcommandwindow--getvisible)** | [音声コマンド] ウィンドウの [**Visible**](visible-property) プロパティの値を返します。 |
| GetPosition**[を](iagentcommandwindow--getposition)**する | 音声コマンド ウィンドウの位置を返します。 |
| [**GetSize**](iagentcommandwindow--getsize) | [音声コマンド] ウィンドウのサイズを返します。 |