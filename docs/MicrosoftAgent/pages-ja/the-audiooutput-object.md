---
layout: Conceptual
title: AudioOutput オブジェクト - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/the-audiooutput-object
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: AudioOutput オブジェクト
document_id: 3681b1fa-a51f-1579-22db-900bbb801e39
document_version_independent_id: ad9e94a2-794e-617f-3dbb-9598a01aec76
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/the-audiooutput-object.md
locale: ja-jp
ms.assetid: 7c1c6079-f445-4980-9559-8d26b6014e89
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/the-audiooutput-object.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:01:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/the-audiooutput-object.md
page_type: conceptual
toc_rel: toc.json
word_count: 283
asset_id: lwef/the-audiooutput-object
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 8b6db82c-c80d-5625-f4da-7556f75fcbbb
---

# AudioOutput オブジェクト - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

このオブジェクトは、サーバーによって管理されるオーディオ出力プロパティへのアクセスを提供します。 プロパティは読み取り専用ですが、ユーザーは Microsoft Agent プロパティ シートでそれらを変更できます。

IAgentCtlAudioObjectEx型のオブジェクト変数を宣言した場合、[**AudioOutput**](/ja-jp/windows/desktop/lwef/the-audiooutput-object) オブジェクトのすべてのプロパティにアクセスすることはできません。 エージェントは IAgentCtlAudioObjectもサポートしていますが、この後者のインターフェイスは下位互換性のためにのみ提供され、以前のリリースではそれらのプロパティのみをサポートします。

- [**有効**](enabled-property-ao)
- [**音声効果**](soundeffects-property)
- [**ステータス**](status-property)