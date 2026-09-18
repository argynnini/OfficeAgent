---
layout: Conceptual
title: 非排他的にする - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/be-non-exclusive
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: 非排他的にする
document_id: 398a1ccb-2a9e-c745-af50-2ebc0c096de8
document_version_independent_id: 2bb61704-f1b7-eea5-6f30-00a8c2626868
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/be-non-exclusive.md
locale: ja-jp
ms.assetid: 7a44840d-6bf9-4c12-ba14-66d7067a984d
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/be-non-exclusive.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:37:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/be-non-exclusive.md
page_type: conceptual
toc_rel: toc.json
word_count: 659
asset_id: lwef/be-non-exclusive
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: da354c11-c2cc-d85d-7bff-3f4668aece25
---

# 非排他的にする - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

対話型の文字は、アシスタント、ガイド、エンターテイナー、ストーリーテラー、セールス エージェント、またはその他のさまざまな役割として、ユーザー インターフェイスで使用できます。 自動的に実行または支援する文字は、ユーザーを制御する設計原則に反して設計しないでください。 Web サイトまたは従来のアプリケーションのインターフェイスに文字を追加する場合は、プライマリ インターフェイスの代わりに、拡張機能として文字を使用します。 文字のみを必要とする機能や操作は実装しないでください。

同様に、ユーザーがキャラクターと対話するタイミングを選択できるようにします。 ユーザーは、文字を無視して、ユーザーのアクセス許可でのみ返されるようにする必要があります。 ユーザーに対して文字操作を強制すると、重大な悪影響を及ぼす可能性があります。 文字操作のユーザー制御をサポートするために、Microsoft エージェントには自動的に [非表示] コマンドと [表示] コマンドが含まれます。 Microsoft エージェント API ではこれらのメソッドもサポートされているため、独自のインターフェイスにこれらの関数のサポートを含めることができます。 さらに、Microsoft エージェントのユーザー インターフェイスには、ユーザーが特定の文字出力オプションをオーバーライドできるようにするグローバル プロパティが含まれています。 ユーザーの基本設定を確実に維持するために、API を使用してこれらのプロパティをオーバーライドすることはできません。