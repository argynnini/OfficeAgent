---
layout: Conceptual
title: Microsoft エージェントでの音声エンジンの使用 - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/using-speech-engines-with-microsoft-agent
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Microsoft エージェントでの音声エンジンの使用
document_id: 09cbbf2b-683f-7830-b907-eac3143f2eef
document_version_independent_id: 85dfbec6-9227-2fc6-df31-8ea51d62095f
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/using-speech-engines-with-microsoft-agent.md
keywords:
- Microsoft エージェント(音声エンジンを使用)
locale: ja-jp
ms.assetid: f2687dd6-d38c-4ce7-9587-51e14614e767
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/using-speech-engines-with-microsoft-agent.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:03:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/using-speech-engines-with-microsoft-agent.md
page_type: conceptual
toc_rel: toc.json
word_count: 398
asset_id: lwef/using-speech-engines-with-microsoft-agent
item_type: Content
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: f8713093-fe23-3a94-6a6d-b3ae26d0cacb
---

# Microsoft エージェントでの音声エンジンの使用 - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

Microsoft では、Microsoft エージェント対応アプリケーションまたは Web ページで使用できる音声入力 (認識) エンジンと音声出力 (tex to Speech または TTS) エンジンのセットを提供しています。 これらのエンジンの使用は、Microsoft エージェントライセンス契約と、エンジンのインストール時に表示される補足補遺の対象となります。 このライセンスは、Microsoft エージェント API を介してエンジンを使用し、表示される文字を使用する場合にのみ、エンジンを配布する権利を与えます。

ここでは、Microsoft エージェントで音声エンジンを使用する方法について説明します。

- [コード内の音声エンジンへのアクセス](accessing-a-speech-engine-in-your-code)
- [Microsoft Agent Speech 出力タグ](microsoft-agent-speech-output-tags)
- [テキスト読み上げエンジンのテキスト正規化](text-to-speech-engines-text-normalization)
- [Microsoft エージェントと互換性のあるその他の音声エンジン](other-speech-engines-compatible-with-microsoft-agent)

次のリンクで、Windows Vista の Microsoft エージェントの音声認識機能の変更を探します。

- [Windows Vista での Microsoft エージェントの変更](microsoft-agent-changes-in-windows-vista)