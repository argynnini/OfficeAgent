---
layout: Conceptual
title: ListenComplete イベント - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/listencomplete-event
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: ListenComplete イベント
document_id: 9005e410-60c4-1fc0-eed7-128698bad71b
document_version_independent_id: 2b936665-983c-400a-09b7-08131629611b
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/listencomplete-event.md
locale: ja-jp
ms.assetid: 29e3f424-17b4-4287-b644-ed62b80e0035
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/listencomplete-event.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:54:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-07-03T23:50:19.3460266Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/listencomplete-event.md
page_type: conceptual
toc_rel: toc.json
word_count: 832
asset_id: lwef/listencomplete-event
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 8047a4ad-ef31-4999-58b0-a103c1113297
---

# ListenComplete イベント - Win32 apps | Microsoft Learn

[Microsoft Agent は Windows 7 の時点で非推奨となり、後続のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - リスニングモード（音声認識）が終了したときに発生します。
- **構文**
    - **サブ***エージェント。**ListenComplete (ByVal**CharacterID、 **ByVal**原因*)\*\*

| 部分 | 説明 |
| --- | --- |
| *CharacterID* | リスニング中の文字の ID を文字列として返します。 |
| *原因* | 完了イベントの原因を、次のいずれかの整数として返します: 1 リスニング モードがプログラム コードによってオフにされました。 2 リスニング モード (プログラム コードによってオン) がタイムアウトしました。 3 リスニング モード (リスニング キーによってオン) がタイムアウトしました。 4 ユーザーがリスニング キーを放したため、リスニング モードがオフになりました。 5 ユーザーが話し終えたため、リスニングモードが終了しました。 6 入力アクティブクライアントが非アクティブ化されたため、リスニング モードが終了しました。 7 デフォルト文字が変更されたため、リスニングモードが終了しました。 8 ユーザーが音声入力を無効にしたため、リスニング モードが終了しました。 |

### 解説

このイベントは、リスニング モードのタイムアウトが終了したとき、ユーザーがリスニング キーを放した後、入力アクティブ クライアントが [**Listen**](listen-method) メソッドを **False** で呼び出したとき、またはユーザーが話し終えたときに、すべてのクライアントに送信されます。 このイベントを使用して、キャラクターの音声出力をいつ再開するかを決定できます。

[**Listen**](listen-method) メソッドを使用してリスニング モードをオンにし、ユーザーがリスニング キーを押すと、リスニング モードはリセットされ、リスニング キーのタイムアウトが完了するか、リスニング キーが放されるか、ユーザーが話し終えるまで、いずれか遅い方まで継続されます。 この状況では、リスニング キーのモードが完了するまで **ListenComplete** イベントは受信されません。

このイベントは、現在このキャラクターがロードされているクライアントにキャラクターを返します。 他のすべてのクライアントは null 文字 (空の文字列) を受け取ります。

### 参照

[**ListenStartイベント**](listenstart-event)、 [**Listenメソッド**](listen-method)