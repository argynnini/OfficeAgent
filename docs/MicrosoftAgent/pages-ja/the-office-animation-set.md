---
layout: Conceptual
title: Office アニメーション セット - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/the-office-animation-set
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Office アニメーション セット
document_id: e14742fc-6c7d-addc-e6be-f3764a8845c0
document_version_independent_id: dbba89ee-b5cd-532e-ada9-2f31faa6a228
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/the-office-animation-set.md
locale: ja-jp
ms.assetid: ea80d19b-bf4c-4f6e-bab0-424a9f78f457
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/the-office-animation-set.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:02:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/the-office-animation-set.md
page_type: conceptual
toc_rel: toc.json
word_count: 2161
asset_id: lwef/the-office-animation-set
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/e93f3d5f-c77d-4365-a7fb-c9f2234416c7
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/62e8d07a-cc62-4934-b30b-e168a571e51d
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 7357eb5b-6d6c-e3e2-ea3c-c7b36ea61f10
---

# Office アニメーション セット - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

次の表は、Microsoft Office 2000 文字に対して定義されているアニメーションの一覧です。 Microsoft Office で文字を使用する場合は、この表のすべてのアニメーションをサポートする必要があります。 さらに、ライブの他のアニメーションを追加することもできますが、Microsoft Office では呼び出されない点に注意してください。 アスタリスク (\*) を持つアニメーションは、100% ループする必要があります。 その他のアニメーションは簡単にする必要があります。

| アニメーション | エージェントの状態 | 使用する場合の例 | 特定のアニメーションの例 |
| --- | --- | --- | --- |
| **Alert** | なし | 文字がユーザーに警告する場合 | 文字はユーザーを検索します。 |
| **CheckingSomething\*** | なし | スペル チェック、文法チェック | 文字は参考書で何かを検索します |
| **祝福** | なし | ウィザードを完了する | 大きな笑み、安堵の表情、疲れているが幸せ |
| **EmptyTrash** | なし | Outlook でごみ箱が空になっている | キャラクターライトゴミ箱が燃えている |
| **EXPLAIN** | なし | 文字がユーザーに何かを説明する場合 | ユーザーを簡単に見ながら注意深く見て、目を離す |
| **GestureDown** | GesturingDown | キャラクターが画面上で何かを指し示す | キャラクターはユーザーを見てポイントし、画面を見る |
| **GestureLeft** | GesturingLeft | 文字は、ヘルプ トピックや UI の一部など、画面上の何かを指し示します | キャラクターはユーザーを見てポイントし、画面を見る |
| **GestureRight** | GesturingRight | ヘルプ トピックまたはダイアログの表示 | キャラクターはユーザーを見てポイントし、画面を見る |
| **GestureUp** | GesturingUp | キャラクターが画面上で何かを指し示す | キャラクターはユーザーを見てポイントし、画面を見る |
| **GetArtsy\*** | なし | オート | キャラクターはベレットに置き、パレットを保持し、ペイントします |
| **GetAttention** | なし | 優先度の高いヒント | ユーザーの注意を引くために強くジェスチャ。たとえば、腕を振って上下にジャンプします |
| **GetTechy** | なし | プログラミング環境で実行中に実行される | 文字は電卓やはんだごてを引き出します |
| **GetWizardy\*** | なし | [文字] が表示されている間に実行されているグラフ ウィザード (新しいウィザード パネルごとにアクションが再トリガーされます) | キャラクターはウィザードの帽子と波の杖に置きます |
| **さようなら** | なし | 別の文字が選択されている | これは、 **RestPose** で始まり、空白のフレームで終わる複雑な消えです |
| **Greeting** | なし | 文字が選択されている | これは、空白のフレームで始まり、**RestPose** で終わる複雑な外観です |
| **Hearing\_1\*** | なし | 長いファイルを開く | 耳を地面に向けて、コンピューターを聞く |
| **非表示** | ファイルを非表示 | 文字が一時的に離れる | 煙のパフに素早く葉を残す |
| **Idle1\_1** | ユーザー入力なし | 積極的に耳を傾け、その後カールアップし、スリープ状態になります。 (性格を披露する機会) | 点滅、周りを見回す、忍耐強く待つ |
| **Idle2** | ユーザー入力なし | アイドル期間が長い | キャラクターのあくびと眠く見える |
| **Idle3** | ユーザー入力なし | ディープ アイドル (キャラクターが長時間アイドル状態の場合) | キャラクターがスリープ状態になる |
| **IdleHit** | なし | これは、アイドル レベル 1 アニメーションのマップされていない代表的なサンプルです | すべてのアイドル 状態のアニメーション |
| **LookDown** | なし | 簡単に下を向く | 行が挿入され、一目でわかります |
| **LookDownLeft** | なし | 下を見下げて一時的に左に | 行が挿入され、一目でわかります |
| **LookDownRight** | なし | 下と右を簡単に見る | 列が挿入され、一目でわかります |
| **LookLeft** | なし | 一時的に左に見える | テーブルが挿入され、一目でわかります |
| **LookRight** | なし | 簡単に正しく見える | 単語が移動され、一目でわかります |
| **参照** | なし | 画面上の文字の上で何かが起こっているかのように、簡単に見上げる | ツール バー ボタンがクリックされ、そのボタンが一目でわかります (キャラクターは興味を持つほど驚かない) |
| **LookUpLeft** | なし | 左と上を簡単に見る | ツール バー ボタンがクリックされ、そのボタンが一目でわかります (キャラクターは興味を持つほど驚かない) |
| **LookUpRight** | なし | 右と上を簡単に見る | ツール バー ボタンがクリックされ、そのボタンが一目でわかります (キャラクターは興味を持つほど驚かない) |
| **印刷** | なし | 印刷ジョブのページの印刷 | 1 枚の用紙を取り込み、プリンターに送ります |
| **処理\*** | なし | 特定の文字アクションがない一般的なアクション | キャラクターは集中の外観を取得し、ハンマーにハンマーを引き出します。 アニメーションには、ループにすばやく入り込み、次にすばやく終了する必要があります |
| **RestPose** | なし | キャラクターがアニメーションを再生していない場合に使用されます | アシスタントの画像 |
| **保存\*** | なし | ファイルの保存操作中に使用されます | キャラクターがコンテナーに何かを入れる |
| **検索\*** | なし | 検索、スペル チェック、文法チェックに使用されます | 頭の向きが変わり、文書を振り返ります。 アニメーションには、ループにすばやく入り込み、次にすばやく終了する必要があります |
| **SendMail** | なし | メールの送信 | レターを引き出してメールボックスに入れる |
| **表示** | 表示 | 短い休暇から文字が返される | ステージ上で素早くスプリングを素早く、素早く |
| **考えて\*** | なし | ソルバーなどの複雑な計算を行う | キャラクターは上向きに見え、頭を傷付けます。 アニメーションには、ループにすばやく入り込み、次にすばやく終了する必要があります |
| **Wave** | なし | 付随するアラート | 波。 アラートに似ていますが、長い間、または必死ではありません |
| **書く\*** | なし | お客様は、[ツール オプション] で何かを変更します。IntelliSearch 要求を入力する顧客 | パッドを引き出し、筆記を開始します。 アニメーションには、ループにすばやく入り込み、次にすばやく終了する必要があります |