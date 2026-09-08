---
layout: Conceptual
title: キャラクターのアニメーション化 - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/animating-a-character
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: キャラクターのアニメーション化
document_id: f7954ffd-2c98-28b8-92e7-41a273d09ca2
document_version_independent_id: 3712ed8a-effd-1b0f-1eea-275c303a5b31
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/animating-a-character.md
locale: ja-jp
ms.assetid: ed42de30-acac-41e8-bacb-4caaff254724
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/animating-a-character.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:37:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/animating-a-character.md
page_type: conceptual
toc_rel: toc.json
word_count: 1933
asset_id: lwef/animating-a-character
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: ddc836c4-bbf4-5242-906e-7bc8616b36b3
---

# キャラクターのアニメーション化 - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

文字が読み込まれたら、いくつかの Microsoft エージェントのメソッドを使用してキャラクターをアニメーション化できます。 最初に使用するのは、通常、 [**Show**](show-method) メソッドです。 **[表示** ] を選択すると、キャラクタのフレームが表示され、キャラクタの **表示** 状態に割り当てられたアニメーションが再生されます。

キャラクターのフレームが表示されたら、アニメーションの名前を指定して [**Play**](play-method) メソッドを使用してそのアニメーションを再生できます。 アニメーション名は文字定義に固有です。 アニメーションが再生されると、フレーム内のイメージに合わせてウィンドウの形状が変わります。 その結果、デスクトップとすべてのウィンドウ (*z オーダー*) の上に移動可能なグラフィック イメージ (*スプライト*) が表示されます。

文字のファイルがローカルに格納されている場合は、 [**単に Play**](play-method) メソッドを呼び出すことができます。 その他のケースでは、 を読み込んだ場合などです。HTTP サーバーからのCF 文字。最初にアニメーション データを取得するには、 [**Get**](get-method) (または [**Prepare**](/ja-jp/windows/desktop/lwef/iagentcharacter--prepare)) メソッドを使用する必要があります。 これにより、エージェントはサーバーからアニメーション ファイルを要求し、ローカル コンピューター上のブラウザーのバッファーに格納します。

[**Speak**](speak-method) メソッドを使用すると、文字をプログラムして読み上げ、出力を自動的にリップ同期できます。 詳細については、このドキュメントの「出力」セクションを参照してください。

[**MoveTo**](moveto-method) メソッドを使用して、文字を新しい場所に配置できます。 **MoveTo** メソッドを呼び出すと、Microsoft Agent はキャラクターの現在の位置に基づいて適切なアニメーションを自動的に再生し、その後、キャラクタのフレームを移動します。 同様に、 [**GestureAt**](gestureat-method) を呼び出すと、Microsoft エージェントは、キャラクターの位置と呼び出しで指定された場所に基づいて適切なジェスチャ アニメーションを再生します。

文字を非表示にするには、 [Hide](hide-method) メソッドを呼び出します。 これにより、文字の **非表示** 状態に関連付けられている文字が自動的に再生され、文字のフレームが非表示になります。 ただし、文字の [**Visible**](visible-property) プロパティを設定することで、文字を非表示または表示することもできます。

Microsoft エージェントは、すべてのアニメーション呼び出し ( *要求) を*非同期的に処理します。 これにより、要求の処理中にアプリケーションのコードで他のイベントの処理を続行できます。 たとえば、 [**Play**](play-method) メソッドを呼び出して、アニメーションを順番に再生できるように、キャラクターのキューにアニメーションを配置します。 ただし、これは、他の関数の呼び出しが、コード内で後に続くアニメーションの後に必ずしも実行されることを想定できないことを意味します。 たとえば、通常、 **Play** または [**MoveTo**](moveto-method) の呼び出しの後のステートメントは、アニメーションが終了する前に実行されます。

アニメーション要求へのオブジェクト参照を作成し、アニメーションが開始または完了したら、サーバーがクライアントに文字を通知するために使用する [Request](the-request-object) イベントを監視することで、コードをキャラクターのキュー内のアニメーションと同期できます。 たとえば、文字がアニメーションを終了したときにメッセージ ボックスを表示する場合は、メッセージ ボックス呼び出しを [**RequestComplete**](requestcomplete-event) イベント処理サブルーチンに配置し、特定の要求 ID を確認できます。

キャラクターが非表示の場合、サーバーはアニメーションを再生しません。ただし、引き続きキューに入れ、アニメーション要求を処理し (アニメーションを再生)、要求の状態をクライアントに返します。 非表示の状態では、文字を入力アクティブにすることはできません。 ただし、ユーザーが文字の名前を読み上げる場合 (音声入力が有効になっている場合)、サーバーは自動的に文字を表示します。

クライアント アプリケーションが複数の文字を同時に読み込む場合、Microsoft エージェントのアニメーション サービスを使用すると、文字を個別にアニメーション化したり、 [**Wait**](wait-method)、 [**Interrupt**](interrupt-method)、または [**Stop**](stop-method) メソッドを使用してアニメーションを相互に同期したりできます。

Microsoft エージェントでは、他のアニメーションも自動的に再生されます。 たとえば、キャラクターの状態が数秒変わっていない場合、エージェントはキャラクターの **アイドリング** アニメーションに割り当てられたアニメーションの再生を開始します。 同様に、音声入力が有効になっている場合、エージェントはキャラクターの **リスニング アニメーションを** 再生し、発話が検出されたときにアニメーションを **聞** きます。 これらのサーバーで管理されるアニメーションは *状態*と呼ばれ、文字の作成時に定義されます。 詳細については、「 [Microsoft エージェントの文字の設計](agent-states)」を参照してください。