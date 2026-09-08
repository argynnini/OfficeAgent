---
layout: Conceptual
title: '[高度な文字オプション] ウィンドウ ([音声コマンド] ウィンドウ) - Win32 apps | Microsoft Learn'
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/the-advanced-character-options-window-
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: ユーザーがすべての文字との対話を調整するためのオプションを提供する [高度な文字オプション] ウィンドウについて説明します。
document_id: 7b944240-84fc-c688-34e1-322ee6ab68bf
document_version_independent_id: 690aab39-0b74-887e-5ebc-3534f20b6859
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/the-advanced-character-options-window-.md
locale: ja-jp
ms.assetid: c2f784e9-d1c5-4fa3-b3f7-5061c9b7e6d9
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/the-advanced-character-options-window-.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:01:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/the-advanced-character-options-window-.md
page_type: conceptual
toc_rel: toc.json
word_count: 604
asset_id: lwef/the-advanced-character-options-window-
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: c80b6386-53ed-8cc6-c4ac-90cb7d96ebe1
---

# [高度な文字オプション] ウィンドウ ([音声コマンド] ウィンドウ) - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

[文字の詳細設定オプション] ウィンドウには、ユーザーがすべての文字との対話を調整するためのオプションが用意されています。 たとえば、ユーザーは音声入力を無効にしたり、入力パラメーターを変更したりできます。 ユーザーは、吹き出しという単語の出力設定を変更することもできます。 これらの設定は、クライアント アプリケーションまたは文字定義の一部として設定されたセットをオーバーライドします。 アプリケーションは、すべての文字の操作に対する一般的なユーザー設定に適用されるため、これらのオプションを変更または無効にすることはできません。 ただし、ユーザーがオプションを変更して適用すると、サーバーはアプリケーション (DefaultCharacterChange) に通知します。 また、ウィンドウの [**Visible**](visible-property) プロパティを使用してウィンドウを表示または閉じ、[**Top**](top-property) プロパティと left**[プロパティを使用してその場所](left-property)**アクセスすることもできます。

Microsoft エージェントでは、文字のアニメーションをサポートするだけでなく、文字のオーディオ出力もサポートしています。 これには、音声出力とサウンド エフェクトが含まれます。 読み上げられた出力の場合、サーバーはキャラクターの定義された口の画像を出力に自動的にリップ同期します。 テキスト読み上げ (TTS) 合成、録音されたオーディオ、またはワード バルーン テキスト出力のみを選択できます。