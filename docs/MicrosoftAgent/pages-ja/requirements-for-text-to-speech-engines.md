---
layout: Conceptual
title: テキスト読み上げエンジンの要件 - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/requirements-for-text-to-speech-engines
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: テキスト読み上げエンジンの要件
document_id: 2128e1a8-300f-6f6a-322e-e899ac6c8d3c
document_version_independent_id: 7dc1c40a-3eb2-70fd-c6a2-c2479dc9a382
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/requirements-for-text-to-speech-engines.md
locale: ja-jp
ms.assetid: 21d19949-c9b4-4d9c-9684-6d15162f7a7d
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/requirements-for-text-to-speech-engines.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:00:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/requirements-for-text-to-speech-engines.md
page_type: conceptual
toc_rel: toc.json
word_count: 235
asset_id: lwef/requirements-for-text-to-speech-engines
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 25a30f09-fbb9-ff9b-4b5b-36241a8d41d5
---

# テキスト読み上げエンジンの要件 - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

エンジンは、完全に SAPI 4.0 に準拠している必要があります。 さらに、エンジンでは、タグ付けされたテキストとブックマークの通知に対して、次の SAPI インターフェイスもサポートする必要があります。 これらのインターフェイスを使用すると、Microsoft エージェントはテキストの出力を文字のワード バルーンに合わせてペースを合わせて、文字の口 (またはそれに相当するもの) を話された単語とリップ同期できます。

- [ITTSCentralW](ittscentralw)
- [ITTSNotifySinkW](ittsnotifysinkw)
- [ITTSBufNotifySinkW](ittsbufnotifysinkw)
- [ITTSAttributesW](ittsattributesw)