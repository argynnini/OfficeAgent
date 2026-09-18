---
layout: Conceptual
title: Listen メソッド - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/listen-method
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Listen メソッド
document_id: a85a4b15-37ba-d540-41c5-d459473cf174
document_version_independent_id: 683b405b-1263-c48c-af91-81cb9c13dc9f
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/listen-method.md
locale: ja-jp
ms.assetid: ceb3b62f-2a33-4a13-b608-4cfa800be38a
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/listen-method.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:54:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/listen-method.md
page_type: conceptual
toc_rel: toc.json
word_count: 1151
asset_id: lwef/listen-method
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 35695996-0654-0682-6c6f-61f5377c449e
---

# Listen メソッド - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

- **Description**
    - 一定期間のリスニング モード (音声認識) をオンにします。
- **構文**
    - *エージェント。**文字***("***CharacterID***")。Listen\*\* *State*

| パーツ | 説明 |
| --- | --- |
| *状態* | 必須。 リッスン モードを有効または無効にするかどうかを決定するブール値。 **True** リスニング モードをオンにします。 **False** リスニング モードをオフにします。 |

## 解説

このメソッドを **True** に設定すると、一定の期間 (10 秒) のリッスン モード (音声認識が有効になります) が有効になります。 タイムアウトの値を設定することはできませんが、タイムアウトが切れる前にリッスン モードをオフにできます。 ユーザー (または別のクライアント) がリッスン モードを正常にオンにし、タイムアウトの期限が切れる前にこのプロパティを **True に** 設定しようとすると、メソッドは成功し、タイムアウトをリセットします。ただし、ユーザーが Listening キーを押しているためにリッスン モードがオンになっている場合、メソッドは成功しますが、タイムアウトは無視され、リッスン キーとのユーザーの操作に基づいてリッスン モードが終了します。

このメソッドは、入力アクティブなクライアントによって呼び出された場合、および音声サービスが開始されている場合にのみ成功します。 音声サービスが開始されていることを確認するには、**Listen** を呼び出す前に [**SRModeID**](srmodeid-property) を照会または設定するか、[**Command**](/ja-jp/windows/desktop/lwef/the-command-object) の[**音声**](voice-property)設定を設定します。そうしないと、メソッドは失敗します。 このメソッドの成功を検出するには、関数として呼び出し、メソッドが成功したかどうかを示すブール値を返します。

```
   If Genie.Listen(True) Then
      'The method succeeded

   Else
      ' The method failed

   End If
```

ユーザーがリッスン キーを押していて、 **Listen** を False に設定しようとすると、メソッドも失敗 **します**。 ただし、ユーザーがリッスン キーを解放し、リッスン モードがタイムアウトしていない場合は、成功します。

また、文字[**の LanguageID**](languageid-property) 設定に一致する互換性のある音声エンジンがない場合、ユーザーが Microsoft Agent プロパティ シートを使用して音声入力を無効にしているか、オーディオ デバイスがビジー状態の場合も、**リッスン**は失敗します。

このメソッドを **True** に正常に設定すると、サーバーによって [**ListenStart**](listenstart-event) イベントがトリガーされます。 リッスン モードのタイムアウトが完了したとき、または Listen を **False** に設定すると、サーバーは [**ListenComplete**](listencomplete-event) を送信します。

このメソッドは、 [**Stop**](stop-method) を自動的に呼び出し、リッスンキーが押されたときにサーバーが行うリッスン状態アニメーションを再生しません。 これにより、**Stop** を呼び出して独自の適切なアニメーションを再生することで、[**ListenStart**](listenstart-event) アニメーションを使用して現在のアニメーションを中断するかどうかを決定できます。 ただし、サーバーは **Stop** を呼び出し、ユーザーの発話が検出されたときにヒアリング状態アニメーションを再生します。