---
layout: Conceptual
title: 音声入力イベント - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/speech-input-events
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: 音声入力イベント
document_id: e9d8191b-b31c-f22e-9221-eff9fc1167b1
document_version_independent_id: 288f529a-e0c2-a4f2-4c2a-298e4ecfe022
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/speech-input-events.md
locale: ja-jp
ms.assetid: d7b621fe-9274-4b16-af8a-664b0b296c89
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/speech-input-events.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:00:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/speech-input-events.md
page_type: conceptual
toc_rel: toc.json
word_count: 1012
asset_id: lwef/speech-input-events
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 5e9db189-38cb-fc2b-a521-6acf198a63da
---

# 音声入力イベント - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

さらに、[**コマンド**](command-event) イベント通知に対して、エージェントは、サーバーがリッスン モードのオンとオフを切り替えたときに、[**ListenStart**](listenstart-event) と ListenComplete**[イベント (](listencomplete-event)[IAgentNotifySinkEx::ListeningState](iagentnotifysinkex--listeningstate)) を**するときにも、入力アクティブ クライアントに通知します。 ただし、ユーザーがリッスン モード キーを押し、入力アクティブ なクライアントの最上位の文字に対応する音声認識エンジンが使用できない場合、サーバーはリッスンホットキー モードタイムアウトを開始しますが、文字のアクティブなクライアントに対して **ListenStart** イベントを生成しません。 タイムアウトが完了する前に、ユーザーが音声認識エンジンをサポートする別の文字をアクティブ化した場合、サーバーは音声入力のアクティブ化を試み、**ListenStart** イベントを生成します。

同様に、クライアントが [**Listen**](listen-method) メソッドを使用してリッスン モードを有効にしようとしたときに、対応する音声認識エンジンが使用できない場合、呼び出しは失敗し、サーバーは [**ListenStart**](listenstart-event)イベントを生成しません。 Microsoft エージェント コントロールでは、**Listen** メソッドは false 返しますが、呼び出しではエラーは発生しません。

リッスン キー モードがオンで、ユーザーが別の音声認識エンジンを使用する文字に切り替えると、サーバーはそのエンジンに切り替えてアクティブ化し、[**ListenComplete**](listencomplete-event) をトリガーしてから、[**ListenStart**](listenstart-event) イベントをトリガーします。 アクティブ化された文字に使用可能な音声認識エンジンがない場合 (インストールされていないか、アクティブ化された文字の言語 ID 設定と一致しないため)、サーバーは、以前にアクティブ化された文字の **ListenComplete** イベントをトリガーし、**原因** パラメーターの値を返します。 ただし、サーバーは、音声認識をサポートしていないクライアント **ListenStart** **または listenComplete** イベントを生成しません。

クライアントが [**Listen**](listen-method) メソッドを正常に呼び出し、音声認識エンジンがサポートされていない文字がリッスン モードのタイムアウトが完了する前に入力がアクティブになり、ユーザーが元のクライアントの文字に戻ると、サーバーはそのクライアントの [**ListenStart**](listenstart-event) イベントを生成します。

リッスン モードの間に SRModeID変更して音声認識エンジンを切り替えた場合、サーバーは、[**ListenStart**](listenstart-event) イベントを再トリガーせずに、そのエンジンに切り替えてアクティブ化します。 ただし、指定したエンジンが使用できない場合、呼び出しは失敗し (コントロールでエラーが発生します)、サーバーは [**ListenComplete**](listencomplete-event) イベントも呼び出します。