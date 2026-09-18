---
layout: Conceptual
title: Merlin Character 用の Microsoft エージェント アニメーション - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/microsoft-agent-animations-for-merlin-character
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Merlin Character 用の Microsoft エージェント アニメーション
document_id: 72c3adee-f584-c2d1-1956-c69b1b897438
document_version_independent_id: bc70df23-cfe7-0d30-2d66-0fd336f4141f
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/microsoft-agent-animations-for-merlin-character.md
locale: ja-jp
ms.assetid: 4563a464-2c1a-4928-a471-e3f0fdfe85c0
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/microsoft-agent-animations-for-merlin-character.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:55:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-07-03T23:50:19.3460266Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/microsoft-agent-animations-for-merlin-character.md
page_type: conceptual
toc_rel: toc.json
word_count: 2738
asset_id: lwef/microsoft-agent-animations-for-merlin-character
item_type: Content
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/0850fefd-e402-4507-ae98-46cfdfc2e16c
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/6ecf98a5-97c7-4249-b209-a9d9e42633a0
platformId: 5560ffe3-61ef-046f-d787-50d70224ac52
---

# Merlin Character 用の Microsoft エージェント アニメーション - Win32 apps | Microsoft Learn

[Microsoft Agent は Windows 7 の時点で非推奨となり、後続のバージョンの Windows では使用できない可能性があります。]

[Microsoft Agent Merlin Character](https://download.cnet.com/agent-2-0-character-merlin-character-file/3000-2206_4-10728306.html) は、Microsoft Corporation の著作権で保護されています。

Merlin では、次の表に示すアニメーションがサポートされています。 キャラクターのアニメーションを呼び出す方法については、「[Microsoft Agent サーバー インターフェイスのプログラミング](/ja-jp/windows/desktop/lwef/programming-the-microsoft-agent-server-interface)」と「[Microsoft Agent コントロールのプログラミング](programming-the-microsoft-agent-control)」を参照してください。

HTTP プロトコルとコントロールの [**取得**](get-method) メソッドまたはサーバーの [**準備**](/ja-jp/windows/desktop/lwef/iagentcharacter--prepare) メソッドを使用してこれらのキャラクター アニメーションにアクセスする場合は、それらをダウンロードする方法を検討してください。 すべてのアニメーションを一度にダウンロードする代わりに、最初に **Showing** 状態のアニメーションと **Speaking** 状態のアニメーションを取得することができます。 これにより、キャラクターをすばやく表示し、他のアニメーションを非同期的に停止させながら読み上げるさせることが可能になります。 さらに、キャラクターとアニメーションのデータが正常に読み込まれるようにするには、 [**RequestComplete**](requestcomplete-event) イベントを使用します。 読み込み要求が失敗した場合は、データの読み込みを再試行するか、適切なメッセージを表示できます。

アニメーションの **リターン** アニメーションが終了分岐を使用して定義されている場合は、明示的に呼び出す必要はありません。エージェントは、次のアニメーションの前に **リターン** アニメーションを自動的に再生します。 ただし、 **リターン** アニメーションが表示されている場合は、スムーズな切り替えを提供するために、別のアニメーションの前に [**再生**](play-method) メソッドを使用してアニメーションを呼び出す必要があります。 **リターン** アニメーションが一覧に表示されていない場合、アニメーションは通常、遷移アニメーションを必要とすることなく終了します。

キャラクター ファイルには、次の表に示すように、一部のアニメーションのサウンド エフェクトが含まれています。 サウンド エフェクトは、Microsoft Agent のプロパティ シートでこのオプションが有効になっている場合にのみ再生されます。 アプリケーションでサウンド エフェクトを無効にすることもできます。

| アニメーション | リターン アニメーション | スピーキングをサポートする | 音響効果 | 割り当て先ステータス | 説明 |
| --- | --- | --- | --- | --- | --- |
| **確認** | なし | いいえ | **いいえ** | なし | うなずく |
| **Alert** | はい、終了分岐を使用 | はい | **いいえ** | **Listening** | 直立して、眉を上げる |
| **Announce** | はい、終了分岐を使用 | はい | **はい** | なし | ラッパを掲げて吹く |
| **Blink** | なし | いいえ | **いいえ** | **IdlingLevel1** **IdlingLevel2** | まばたきする |
| **Confused** | はい、終了分岐を使用 | はい | **はい** | なし | 頭をかく |
| **Congratulate** | はい、終了分岐を使用 | はい | **はい** | なし | トロフィーを見せる |
| **Congratulate\_2** | はい、終了分岐を使用 | はい | **はい** | なし | 拍手する |
| **Decline** | はい、終了分岐を使用 | はい | **いいえ** | なし | 手を上げ、頭を振る |
| **DoMagic1** | なし | はい | **いいえ** | なし | 魔法の杖を掲げる |
| **DoMagic2** | はい、終了分岐を使用 | いいえ | **はい** | なし | 杖を下ろす、雲が現れる |
| **DontRecognize** | はい、終了分岐を使用 | はい | **いいえ** | なし | 手を耳に当てる |
| **EXPLAIN** | はい、終了分岐を使用 | はい | **いいえ** | なし | 両腕を横に伸ばす |
| **GestureDown** | はい、終了分岐を使用 | はい | **いいえ** | **GesturingDown** | 腕を下ろす |
| **GestureLeft** | はい、終了分岐を使用 | はい | **いいえ** | **GesturingLeft** | 腕を左に振る |
| **GestureRight** | はい、終了分岐を使用 | はい | **いいえ** | **GesturingRight** | 腕を右に振る |
| **GestureUp** | はい、終了分岐を使用 | はい | **いいえ** | **GesturingUp** | 腕を上に上げる |
| **GetAttention** | **GetAttentionReturn** | はい | **はい** | なし | 身を乗り出してノックする |
| **GetAttentionContinued** | **GetAttentionReturn** | はい | **はい** | なし | 身を乗り出して、再びノックする |
| **GetAttentionReturn** | なし | いいえ | **いいえ** | なし | ニュートラルの姿勢に戻る |
| **Greet** | はい、終了分岐を使用 | はい | **はい** | なし | おじぎする |
| **Hearing\_1** | なし | いいえ | **いいえ** | **Hearing** | 耳が伸びる (\*ループ アニメーション) |
| **Hearing\_2** | なし | いいえ | **いいえ** | **Hearing** | 頭を左に傾ける(\*ループアニメーション) |
| **Hearing\_3** | なし | いいえ | **いいえ** | **Hearing** | 頭を左に向ける (\*ループ アニメーション) |
| **Hearing\_4** | なし | いいえ | **いいえ** | **Hearing** | 頭を右に向ける (\*ループアニメーション) |
| **非表示** | なし | いいえ | **はい** | **Hiding** | キャップの下に消える |
| **Idle1\_1** | はい、終了分岐を使用 | いいえ | **いいえ** | **IdlingLevel1** **IdlingLevel2** | 息を吸う |
| **Idle1\_2** | はい、終了分岐を使用 | いいえ | **いいえ** | **IdlingLevel1** **IdlingLevel2** | 左をちらっと見てまばたきする |
| **Idle1\_3** | はい、終了分岐を使用 | いいえ | **いいえ** | **IdlingLevel1** **IdlingLevel2** | 右をちらっと見る |
| **Idle1\_4** | はい、終了分岐を使用 | いいえ | **いいえ** | **IdlingLevel1** **IdlingLevel2** | ちらっと右を見上げてまばたきする |
| **Idle2\_1** | なし | いいえ | **いいえ** | **IdlingLevel2** | 杖を見てまばたきする |
| **Idle2\_2** | なし | いいえ | **いいえ** | **IdlingLevel2** | 手を握ってまばたきする |
| **Idle3\_1** | なし | いいえ | **はい** | **IdlingLevel3** | あくびをする |
| **Idle3\_2** | はい、終了分岐を使用 | いいえ | **はい** | **IdlingLevel3** | 眠りに落ちる (\*ループ アニメーション) |
| **LookDown** | **LookDownReturn** | いいえ | **いいえ** | なし | 下を向く |
| **LookDownBlink** | **LookDownReturn** | いいえ | **いいえ** | なし | 下を見ながらまばたきする |
| **LookDownReturn** | なし | いいえ | **いいえ** | なし | ニュートラルの姿勢に戻る |
| **LookLeft** | **LookLeftReturn** | いいえ | **いいえ** | なし | 左を見る |
| **LookLeftBlink** | **LookLeftReturn** | いいえ | **いいえ** | なし | 左を見ながらまばたきする |
| **LookLeftReturn** | なし | いいえ | **いいえ** | なし | ニュートラルの姿勢に戻る |
| **LookRight** | **LookRightReturn** | いいえ | **いいえ** | なし | 右を見る |
| **LookRightBlink** | **LookRightReturn** | いいえ | **いいえ** | なし | 右を見ながらまばたきする |
| **LookRightReturn** | なし | いいえ | **いいえ** | なし | ニュートラルの姿勢に戻る |
| **LookUp** | **LookUpReturn** | いいえ | **いいえ** | なし | 顔を上げる |
| **LookUpBlink** | **LookUpReturn** | いいえ | **いいえ** | なし | 上を見ながらまばたきする |
| **LookUpReturn** | なし | いいえ | **いいえ** | なし | ニュートラルの姿勢に戻る |
| **MoveDown** | はい、終了分岐を使用 | いいえ | **はい** | **MovingDown** | 下に飛ぶ |
| **MoveLeft** | はい、終了分岐を使用 | いいえ | **はい** | **MovingLeft** | 左へ飛ぶ |
| **MoveRight** | はい、終了分岐を使用 | いいえ | **はい** | **MovingRight** | 右に飛ぶ |
| **MoveUp** | はい、終了分岐を使用 | いいえ | **はい** | **MovingUp** | 上に飛ぶ |
| **Pleased** | はい、終了分岐を使用 | はい | **いいえ** | なし | 笑顔になって手を組み合わせる |
| **処理** | いいえ | いいえ | **はい** | なし | 大釜をかき混ぜる |
| **処理** | はい、終了分岐を使用 | いいえ | **はい** | なし | 大釜をかき混ぜる (\*ループ アニメーション) |
| **読み取り** | **ReadReturn** | はい | **はい** | なし | 書籍を開き、読み上げて顔を上げる |
| **ReadContinued** | **ReadReturn** | はい | **はい** | なし | 読み上げて顔を上げる |
| **ReadReturn** | なし | いいえ | **はい** | なし | ニュートラルの姿勢に戻る |
| **Reading** | はい、終了分岐を使用 | いいえ | **はい** | なし | 読む (\*ループ アニメーション) |
| **RestPose** | なし | はい | **いいえ** | **Speaking** | ニュートラルの姿勢 |
| **Sad** | はい、終了分岐を使用 | はい | **いいえ** | なし | 悲しみの表情 |
| **Search** | いいえ | いいえ | **はい** | なし | 水晶玉を覗き込む |
| **Searching** | はい、終了分岐を使用 | いいえ | **はい** | なし | 水晶玉を覗き込む (\*ループアニメーション) |
| **表示** | なし | いいえ | **はい** | **Showing** | キャップの中から現れる |
| **startlistening** | はい、終了分岐を使用 | はい | **いいえ** | なし | 手を耳におく |
| **stoplistening** | はい、終了分岐を使用 | はい | **いいえ** | なし | 両耳の上に手を置く |
| **Suggest** | はい、終了分岐を使用 | はい | **はい** | なし | 電球を見せる |
| **Surprised** | はい、終了分岐を使用 | はい | **はい** | なし | 驚きの表情を見せる |
| **Think** | はい、終了分岐を使用 | はい | **いいえ** | なし | あごに手を当てて顔を上げる |
| **Thinking** | いいえ | いいえ | **いいえ** | なし | あごに手を当てて顔を上げる (\*ループアニメーション) |
| **Uncertain** | はい、終了分岐を使用 | はい | **いいえ** | なし | 身を乗り出して眉を上げる |
| **Wave** | はい、終了分岐を使用 | はい | **いいえ** | なし | 手を振る |
| **書き込み** | **WriteReturn** | はい | **はい** | なし | 書籍を開き、書き込んで顔を上げる |
| **WriteContinued** | **WriteReturn** | はい | **はい** | なし | 書き込んで顔を上げる |
| **WriteReturn** | なし | いいえ | **はい** | なし | ニュートラルの姿勢に戻る |
| **Writing** | はい、終了分岐を使用 | いいえ | **はい** | なし | 書き込む (\*ループ アニメーション) |

\*ループアニメーションを再生する場合は、キャラクターのキューの他のアニメーションが再生される前に、 [**停止**](stop-method) を使用してクリアする必要があります。