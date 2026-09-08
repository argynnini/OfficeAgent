---
layout: Conceptual
title: 音声入力のサポート - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/speech-input-support
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: 音声入力のサポート
document_id: 5e24a305-0a17-484b-4d61-5513c6ad19a0
document_version_independent_id: 702cc18d-b377-5706-6cc4-4ace41ff9c87
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/speech-input-support.md
locale: ja-jp
ms.assetid: 4702b941-fcc9-4d00-aba2-eca624b6d417
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/speech-input-support.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:01:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/speech-input-support.md
page_type: conceptual
toc_rel: toc.json
word_count: 1946
asset_id: lwef/speech-input-support
item_type: Content
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 0e21af84-854e-eaca-cc14-98926bb321eb
---

# 音声入力のサポート - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

Microsoft エージェントには、マウスとキーボードの操作のサポートに加えて、音声入力の直接サポートも含まれています。 Microsoft エージェントの音声入力のサポートは Microsoft SAPI (Speech Application Programming Interface) に基づいているため、SAPI が必要なサポートを含む音声認識コマンドおよび制御エンジンで Microsoft Agent を使用できます。 音声エンジンの要件の詳細については、「[Speech Engine Support Requirements](requirements-for-speech-recognition-engines)」を参照してください。

Microsoft では、Microsoft エージェントで使用できるコマンド アンド コントロール音声認識エンジンを提供しています。 詳細については、「[Speech Engine Selection](speech-engine-selection)」を参照してください。

ユーザーは、プッシュ読み上げリスニング ホットキーを長押しして音声入力を開始できます。 このリスニング モードでは、音声エンジンが音声入力の先頭を受信した場合、発話の終了が検出されるまでオーディオ チャネルを開いたままにします。 ただし、入力を受信しない場合、オーディオ出力はブロックされません。 これにより、ユーザーはキーを押しながら複数の音声コマンドを発行でき、ユーザーが話していないときに文字が応答できます。

ユーザーがリッスン キーを解放すると、リッスン モードはタイムアウトします。 ユーザーは、[高度な文字オプション] を使用して、このモードのタイムアウトを調整できます。 クライアント アプリケーション コードからこのタイムアウトを設定することはできません。

ユーザーが話している間に文字が話そうとすると、文字の可聴出力は失敗しますが、テキストは引き続きワード バルーンに表示される可能性があります。 Listening キーが押されている間に文字にオーディオ チャネルがある場合、サーバーは、[**Speak**](speak-method) メソッドのテキストを処理した後、自動的にコントロールをユーザーに転送します。 オプションの MIDI トーンが再生され、ユーザーが話し始めます。 これにより、文字を駆動するアプリケーションが出力で論理的な一時停止を提供できなかった場合でも、ユーザーは入力を提供できます。

[**Listen**](listen-method) メソッドを使用して音声入力を開始することもできます。 このメソッドを呼び出すと、定義済みの期間の音声認識が有効になります。 この期間中に入力がない場合、Microsoft エージェントは音声認識エンジンを自動的にオフにし、オーディオ チャネルを解放します。 これにより、オーディオ デバイスへの入力またはオーディオ デバイスからの出力がブロックされるのを回避し、音声認識がオンのときに使用するプロセッサのオーバーヘッドを最小限に抑えることができます。 **Listen** メソッドを使用して、音声入力をオフにすることもできます。 ただし、音声認識エンジンは非同期的に動作するため、効果がすぐには発生しない可能性があることに注意してください。 その結果、**Listen** というコードを呼び出して音声入力をオフにした後でも、[**Command**](command-event) イベントを受け取る可能性があります。

音声入力をサポートするには、*文法*を定義します。音声認識エンジンが、[**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションの [**コマンド**](/ja-jp/windows/desktop/lwef/the-command-object) の **音声** 設定としてリッスンして照合する単語のセットです。 文法には、省略可能な単語や代替単語、繰り返しのシーケンスを含めることができます。 エージェントは、いずれかのクライアントが音声エンジンを正常に読み込むか、**コマンド** オブジェクトの 1 つに対して **音声** を作成するまで、リッスン ホットキーを有効にしないことに注意してください。

ユーザーが Listening ホットキーを押すか、クライアント アプリケーションが [**Listen**](listen-method) メソッドを呼び出して音声入力を開始するかに関係なく、音声認識エンジンは、定義されているコマンドの文法に発話の入力を照合し、情報をサーバーに渡します。 次に、サーバーは、[**Command**](command-event) イベント ([**IAgentNotifySink::Command**](iagentnotifysink--command)) を使用してクライアント アプリケーションに通知します。最適な一致のコマンド ID と、次の 2 つの代替一致 (ある場合)、信頼度スコア、および一致する各一致のテキストを含む、[**UserInput**](/ja-jp/windows/desktop/lwef/iagentuserinput) オブジェクトを返します。

また、サーバーは、指定されたコマンドのいずれかに音声入力が一致すると、クライアント アプリケーションに通知します。 コマンド ID が NULL 場合でも、信頼度スコアとテキストが一致します。 リスニング モードの場合、サーバーはキャラクターの **Listening** 状態に割り当てられたアニメーションを自動的に再生します。 次に、発話が実際に検出されると、サーバーはキャラクターの **聴覚** 状態アニメーションを再生します。 発話が終了するまで、サーバーはキャラクターを注意深い状態に保ちます。 これにより、ユーザーに入力を求める適切なソーシャル フィードバックが提供されます。

ユーザーが高度な文字オプションで音声入力を無効にした場合、Listening ホットキーも無効になります。 同様に、音声入力が無効になっているときに [**Listen**](listen-method) メソッドを呼び出そうとすると、メソッドが失敗します。