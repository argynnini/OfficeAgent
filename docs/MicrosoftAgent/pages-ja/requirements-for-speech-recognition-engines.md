---
layout: Conceptual
title: 音声認識エンジンの要件 - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/requirements-for-speech-recognition-engines
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: 音声認識エンジンの要件
document_id: f581b2bb-e9c8-30b8-5d70-fee068188aea
document_version_independent_id: 02b5c7b4-7ee8-c8c9-8b3c-ed3565172052
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/requirements-for-speech-recognition-engines.md
locale: ja-jp
ms.assetid: 41aca5da-c680-41c1-b070-af291cb0c8e1
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/requirements-for-speech-recognition-engines.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:59:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-01-09T19:49:59.6397822Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/requirements-for-speech-recognition-engines.md
page_type: conceptual
toc_rel: toc.json
word_count: 639
asset_id: lwef/requirements-for-speech-recognition-engines
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 8e6719d7-1cd3-a5f9-77df-7e5250609a19
---

# 音声認識エンジンの要件 - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

音声認識エンジンは、SAPI 4.0 に従って、完全に準拠したコマンド アンド コントロール (C&C) エンジンである必要もあります。 仕様で説明されているバイナリ形式の複数の文法をサポートし、それらの文法をリアルタイムでアクティブ化または非アクティブ化できるようにする必要があります。

SAPI 4.0 では、音声認識エンジンがワイド文字の Unicode インターフェイスをサポートする必要があることに注意してください。 ただし、これらのインターフェイスをサポートする場合、一部のシステムではエンジンが正しく機能しない可能性があるため、エンジンは Unicode データを ANSI に変換することに依存しないようにする必要があります。 たとえば、Unicode を ANSI に変換する日本語エンジンは、英語の Microsoft Windows 95 システムでは機能しない場合があります。

さらに、Microsoft エージェントに準拠すると見なされるためには、(ISRGramNotifySinkW::P hraseFinish を使用して) フレーズが正常に認識されると、エンジンは結果オブジェクトを返す必要があります。 これらの結果オブジェクトは、仕様に必要な ISRResBasic をサポートする必要があります。 さらに、ISRResScore をサポートする必要があります。 Microsoft Agent は ISRResBasic のみをサポートするエンジン、または結果オブジェクトを返さないエンジンでも実行されますが、通常、このようなエンジンではパフォーマンスが大幅に低下します。 多くのアプリケーションでは、エンジンによって提供される信頼度値を使用して、さまざまなコマンドへの応答方法を制御します。