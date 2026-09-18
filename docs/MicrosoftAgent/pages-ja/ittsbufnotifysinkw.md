---
layout: Conceptual
title: ITTSBufNotifySinkW - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/ittsbufnotifysinkw
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: ITTSBufNotifySinkW
document_id: 23000878-265d-db1e-77d3-d88b530aabd4
document_version_independent_id: 35c9ffab-f5d0-8869-93ed-d50a1eb32741
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/ittsbufnotifysinkw.md
locale: ja-jp
ms.assetid: 00f4a529-2db1-4cad-9340-ed95999448f7
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/ittsbufnotifysinkw.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:54:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/ittsbufnotifysinkw.md
page_type: conceptual
toc_rel: toc.json
word_count: 475
asset_id: lwef/ittsbufnotifysinkw
item_type: Content
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: e68563ec-6302-e30a-6ad6-a99c804f4b66
---

# ITTSBufNotifySinkW - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

エンジンは BookMark 呼び出す必要があります。 音声出力の前処理中に、Microsoft Agent コードは "単語" の間にブックマークを挿入し、それらのブックマークの到着を使用して、単語吹き出し内のテキストのペースを上げさせます。 SAPI では、発話が終了する前のある時点でこれらのブックマークが到着した場合以外は必要ありませんが、Microsoft エージェントをサポートするには、比較的タイムリーにブックマークを返す必要があります。

日本語などの一部の言語では、"word" という厳密な概念がないことに注意してください。 Microsoft エージェントの [**Speak**](speak-method) メソッドでは、"単語" は、意味と発音が分離された記号の接続された文字列として定義されます。 Microsoft エージェントでは、非常に単純な解析コードを使用して、"単語" とは何かを判断します。空白で区切られたシンボルを検索します。 したがって、英語の文字列 "The 101 Dalmatians"には、"the"、"one hundred and one"、"Dalmatians" という 3 つの "単語" があります。 Microsoft エージェント マップ タグに含まれるテキストは、表示目的で 1 つの "単語" として扱われます。