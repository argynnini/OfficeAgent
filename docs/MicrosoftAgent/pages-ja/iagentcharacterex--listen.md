---
layout: Conceptual
title: IAgentCharacterEx Listen - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcharacterex--listen
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCharacterEx Listen
document_id: 7dc066ff-41a6-aa71-3f37-c9b2c8e1e694
document_version_independent_id: 031e4436-4d3c-55f6-46f1-6c4918964d5b
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacterex--listen.md
locale: ja-jp
ms.assetid: 8d4cdb6c-04e1-498c-867f-fddbe6e2791a
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacterex--listen.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:48:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcharacterex--listen.md
page_type: conceptual
toc_rel: toc.json
word_count: 1000
asset_id: lwef/iagentcharacterex--listen
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 19c2ee1f-05b6-bd90-4983-af382b03127c
---

# IAgentCharacterEx Listen - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

```syntax
HRESULT Listen(
   long bListen  // listening mode flag
);
```

リッスン モード (音声認識入力) のオンとオフを切り替えます。

- 操作が成功したことを示すS\_OKを返します。

- *bListen*
    - リッスン モード フラグ。 このパラメーターが **True の**場合、リッスン モードは有効になります。 **False の**場合、リッスン モードはオフになります。

このメソッドを **True** に設定すると、一定の期間、リッスン モード (音声認識が有効になります) が有効になります。 タイムアウトの値を設定することはできませんが、タイムアウトが切れる前にリッスン モードをオフにすることはできます。 さらに、タイムアウトの期限が切れる前に、ユーザー (または別のクライアント) がメソッドを正常に **True** に設定したためにリッスン モードが既にオンになっている場合、メソッドは成功し、タイムアウトをリセットします。ただし、ユーザーがリッスン キーを押しているためにリッスン モードが既にオンになっている場合、メソッドは成功しますが、タイムアウトは無視され、リッスン キーとのユーザーの操作に基づいてリッスン モードが終了します。

このメソッドは、入力アクティブ なクライアントによって呼び出された場合にのみ成功します。 したがって、クライアントが最上位文字のアクティブなクライアントでない場合、メソッドは失敗します。 メソッドを **False** に設定しようとして、ユーザーがリッスン キーを押すと、メソッドも失敗します。 また、文字の言語 ID 設定に一致する互換性のある音声エンジンがない場合、またはユーザーが Microsoft Agent プロパティ シートを使用して音声入力を無効にした場合にも失敗する可能性があります。 ただし、オーディオ デバイスがビジー状態の場合、メソッドは失敗しません。

このメソッドを **True** に正常に設定すると、サーバーは [**IAgentNotifySinkEx::ListeningState イベントを**](iagentnotifysinkex--listeningstate) トリガーします。 また、リッスン モードのタイムアウトが完了したとき、または **IAgentCharacterEx::Listen を** False に設定すると、サーバーは [**IAgentNotifySinkEx::ListeningState**](https://www.bing.com/search?q=**IAgentCharacterEx::Listen**) を送信 **します**。

このメソッドは、 [**IAgentCharacter::StopAll**](iagentcharacter--stopall) を自動的に呼び出し、ユーザーがリッスン キーを押したときに発生する文字のリッスン状態アニメーションを再生しません。 これにより、 [**IAgentNotifySinkEx::ListeningState イベントを**](iagentnotifysinkex--listeningstate) 使用して、現在のアニメーションを停止し、独自の適切なアニメーションを再生するかどうかを判断できます。 ただし、ユーザー発話が検出されると、サーバーは **IAgentCharacter::StopAll** を自動的に呼び出し、ヒアリング状態アニメーションを再生します。