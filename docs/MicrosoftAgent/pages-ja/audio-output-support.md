---
layout: Conceptual
title: オーディオ出力のサポート - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/audio-output-support
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: オーディオ出力のサポート
document_id: 3344720c-bb6e-10be-d750-31cdf4353722
document_version_independent_id: 2be3158b-538e-8503-0a1f-2a01c3088d9e
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/audio-output-support.md
locale: ja-jp
ms.assetid: 28b7b1dc-0bf2-46db-b114-f93e460d958f
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/audio-output-support.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:37:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/audio-output-support.md
page_type: conceptual
toc_rel: toc.json
word_count: 319
asset_id: lwef/audio-output-support
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: bd8fb05c-d4e2-4122-ec3f-21dc87d3bde7
---

# オーディオ出力のサポート - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

Microsoft エージェントを使用すると、キャラクターの音声出力にオーディオ ファイルを使用できます。 オーディオ ファイルを録音し、[**Speak**](speak-method) メソッドを使用してそのデータを再生できます。 Microsoft エージェント アニメーション サービスは、オーディオ ファイルのオーディオ特性を使用して、文字口のリップ同期を自動的にサポートします。 Microsoft エージェントでは、オーディオ ファイル用の特別な形式もサポートされています。これには、追加の音素と単語区切り情報が含まれており、より強化されたリップ同期のサポートが提供されます。 この特別な形式は、Microsoft 言語情報サウンド編集ツールを使用して生成できます。