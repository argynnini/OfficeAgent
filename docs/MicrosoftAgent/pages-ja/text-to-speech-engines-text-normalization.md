---
layout: Conceptual
title: テキスト読み上げエンジンのテキスト正規化 - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/text-to-speech-engines-text-normalization
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: テキスト読み上げエンジンのテキスト正規化
document_id: e5746fa8-1f15-1935-e2f2-223608556f54
document_version_independent_id: c2975bd7-d50c-f92f-60f5-c4b3872b58e0
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/text-to-speech-engines-text-normalization.md
locale: ja-jp
ms.assetid: 1974d47b-4877-47e3-89d8-fd70967e7605
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/text-to-speech-engines-text-normalization.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:01:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-01-09T19:49:59.6397822Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/text-to-speech-engines-text-normalization.md
page_type: conceptual
toc_rel: toc.json
word_count: 350
asset_id: lwef/text-to-speech-engines-text-normalization
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://authoring-docs-microsoft.poolparty.biz/devrel/a8711e05-df51-442a-970f-935304535b39
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://authoring-docs-microsoft.poolparty.biz/devrel/3d3c20d8-79ed-4203-aee0-ffb9c9bafe72
platformId: 78a5ca2f-484e-21e2-7243-3282fd6c9a18
---

# テキスト読み上げエンジンのテキスト正規化 - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

正規化とは、数値、省略形、頭字語、慣用句を識別し、通常は文のコンテキストに基づいて、必要に応じてフルテキストに変換するプロセスです。

たとえば、L&H TruVoice American English TTS Engine を使用すると、次の文が使用されます。

イギリスのジョージ6世は1952年2月6日に亡くなりました。

は、次のように通常 **コンテキスト** 読み取られます。

 イギリスのジョージ1世は、2月6日に52歳で亡くなりました。

ただし、**電子メール コンテキストの**では、次のように読み取られます。

 イングランドの6番目のジョージ王は、2月6日、1952年に亡くなりました。

**コンテキスト** 音声タグの使用に関する情報は、Microsoft Agent Speech 出力タグの エージェント プログラミング ドキュメントを参照してください。