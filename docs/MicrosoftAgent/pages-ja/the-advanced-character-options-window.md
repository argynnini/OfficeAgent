---
layout: Conceptual
title: '[高度な文字オプション] ウィンドウ (Microsoft エージェント ユーザー インターフェイス) - Win32 apps | Microsoft Learn'
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/the-advanced-character-options-window
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: グローバル設定オプションとその現在の設定を表示する [文字オプションの詳細設定] ウィンドウについて説明します。
document_id: 4c0f8d1e-416e-eef0-5c3f-d86fc4ecfa4b
document_version_independent_id: 9afc1454-7b36-7aab-4cda-a9756258ef34
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/the-advanced-character-options-window.md
locale: ja-jp
ms.assetid: c54e462e-d60a-42ce-96ad-3db531c6f9fd
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/the-advanced-character-options-window.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:01:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/the-advanced-character-options-window.md
page_type: conceptual
toc_rel: toc.json
word_count: 269
asset_id: lwef/the-advanced-character-options-window
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: ab5ec559-0345-6a33-11dd-435081d298a1
---

# [高度な文字オプション] ウィンドウ (Microsoft エージェント ユーザー インターフェイス) - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

Microsoft Agent は、ユーザーがすべての文字との対話を制御できるようにする特定のグローバル設定を保持します。 [高度な文字オプション] ウィンドウには、これらのオプションとその現在の設定が表示され、Microsoft Agent プログラミング インターフェイスを使用して任意のホスティング アプリケーションで表示できます。 Microsoft エージェントは、最後に表示されたページを記憶し、プロパティ シートが表示されたときにそのページを表示します。

- 出力ページの [を](the-output-page) する
- 音声入力ページの [を](the-speech-input-page) する
- 著作権ページの [を](the-copyright-page) する