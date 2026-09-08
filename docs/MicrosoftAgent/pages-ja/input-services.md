---
layout: Conceptual
title: 入力サービス - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/input-services
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: 入力サービス
document_id: 752ec188-de7f-a7da-5e32-02851facca26
document_version_independent_id: c4c30a90-5a92-1bc9-b2ca-9c5da4f4b963
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/input-services.md
locale: ja-jp
ms.assetid: 6a0fb005-2acc-4d7c-babb-bb814faf746d
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/input-services.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:53:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/input-services.md
page_type: conceptual
toc_rel: toc.json
word_count: 315
asset_id: lwef/input-services
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: b5ae1564-6932-fa9d-2966-04d4d0b9aef6
---

# 入力サービス - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

クライアント アプリケーションは、文字と対話するためのプライマリ ユーザー インターフェイスを提供します。 ボタンクリックから入力されたテキストまで、任意の形式の入力に応答するように文字をプログラミングできます。 さらに、Microsoft Agent にはイベントが用意されているため、ユーザーが文字をクリック、ダブルクリック、またはドラッグしたときに何が起こるかをプログラムできます。 サーバーは、ポインターの座標と、これらのイベントの修飾子キーの状態を渡します。

- [Input-Active クライアント](input-active-client)
- [ポップアップ メニューのサポート](pop-up-menu-support)
- 音声入力サポート [の](speech-input-support)
- [音声エンジンの選択](speech-engine-selection)
- 音声入力イベント [を](speech-input-events) する