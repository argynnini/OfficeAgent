---
layout: Conceptual
title: 音声エンジンの選択 - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/speech-engine-selection
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: 音声エンジンの選択
document_id: 5159b2fe-c468-3b60-705f-79672dda296f
document_version_independent_id: 265a663f-363f-9b01-d5d9-4795402298b2
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/speech-engine-selection.md
locale: ja-jp
ms.assetid: f5afedc6-093f-4247-a5c8-277d6b2d646c
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/speech-engine-selection.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:00:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/speech-engine-selection.md
page_type: conceptual
toc_rel: toc.json
word_count: 718
asset_id: lwef/speech-engine-selection
item_type: Content
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/c6f99e62-1cf6-4b71-af9b-649b05f80cce
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/3f56b378-07a9-4fa1-afe8-9889fdc77628
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: af902c43-e08c-2f15-bafb-b7de0ad13327
---

# 音声エンジンの選択 - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

文字の言語 ID 設定によって、既定の音声入力言語が決まります。Microsoft エージェントは、その言語に一致するインストール済みエンジンの SAPI を要求します。 クライアント アプリケーションで言語設定が指定されていない場合、Microsoft エージェントは、ユーザーの既定の言語 ID (メジャー言語 ID、マイナー言語 ID を使用) に一致する音声認識エンジンの検索を試みます。 この言語に一致するエンジンがない場合、その文字の音声は無効になります。

特定の音声認識エンジンを要求するには、そのモード ID (SRModeID**[プロパティ](srmodeid-property)**文字を使用) を指定します。 ただし、そのモード ID の言語 ID がクライアントの言語設定と一致しない場合、呼び出しは失敗します (コントロールでエラーが発生します)。 その後、音声認識エンジンは、クライアントによって最後に正常に設定されたエンジンのままになります。存在しない場合は、現在のシステム言語 ID と一致するエンジンになります。 一致するものがまだない場合、そのクライアントでは音声入力を使用できません。

Microsoft エージェントは、ユーザーが Listening ホットキーを押して音声入力を開始するか、入力アクティブなクライアントが [**Listen**](listen-method) メソッドを呼び出すと、音声認識エンジンを自動的に読み込みます。 ただし、エンジンは、モード ID の設定またはクエリ、音声コマンド ウィンドウのプロパティの設定またはクエリ、SRStatusクエリを実行するとき、または音声が有効になっていて、ユーザーが [高度な文字オプション] の [音声入力] ページを表示するときにも読み込まれる場合があります。 ただし、Microsoft エージェントは、クライアントが使用している音声エンジンのみを読み込み続けます。