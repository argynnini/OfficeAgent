---
layout: Conceptual
title: アニメーションの原則 - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/animation-principles
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: アニメーションの原則
document_id: a9cdab69-521e-0da4-2c58-33772935fba2
document_version_independent_id: 7dfa17ce-ecef-3762-c73b-93f42984176b
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/animation-principles.md
locale: ja-jp
ms.assetid: 3633744c-ddb1-44bb-a390-7114386d265c
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/animation-principles.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:37:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/animation-principles.md
page_type: conceptual
toc_rel: toc.json
word_count: 2652
asset_id: lwef/animation-principles
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: d402a037-d2b4-5e17-e2af-91bfa7b5258d
---

# アニメーションの原則 - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

効果的なアニメーションデザインには、単に文字をレンダリングする以上のものが必要です。 成功したアニメーターは、さまざまな原則とテクニックに従って、"信じられる" キャラクターを作成します。

**スカッシュとストレッチ**

アニメートされたオブジェクトが移動すると、歪みが発生します。 発生する変形量は、そのオブジェクトの剛性を反映します。 キャラクターの身体の動きをフラット化または細長くすると、キャラクターの性質と構成を伝えるのに役立ちます。

**期待**

予測は、今後のアクションのステージを設定します。 予想されるアクションがなければ、体の動きは突然、硬く、不自然に見えます。 この原則は、現実世界での身体の動きに基づいています。 一方向への移動は、多くの場合、反対方向への移動から始まります。 脚はジャンプ前に収縮します。 息を吐くには、最初に息を吸います。 また、予測アクションは、キャラクターとアクションの両方の性質を伝える上で重要な役割を果たしており、対象ユーザーがアクションに備えるのに役立ちます。 信じ取り可能なキャラクターを作成する重要な側面は、キャラクターのアクションが意図的な意図に由来することを示すことです。 期待は、キャラクターの動機を視聴者に伝えるのに役立ちます。

**タイミング**

タイミングは、アクションの性質を定義します。 頭が左から右に移動する速度は、キャラクターが何気なく周りを見回しているか、否定的な反応を与えているかを伝えます。 タイミングは、オブジェクトの重量とサイズを伝えるのにも役立ちます。 大きなオブジェクトは、小さいオブジェクトよりも加速と減速に時間がかかる傾向があります。 さらに、キャラクターの動きのペースは、それが注目を集める方法に影響します。 通常のシナリオでは、急速な動きが目を引きますが、熱狂的な環境では、静止した動きや遅い動きが同じ効果を持つ可能性があります。

ステージング **の**

キャラクターが使用する背景や小道具も、その気分や目的を伝えることができます。 ステージングには、文字の摩耗、照明効果、表示角度、および他の文字の存在も含まれます。 これらの要素はすべて、キャラクターの個性、目的、行動を強化するために貢献します。 効果的なステージングでは、通信する場所に目を向ける方法を理解する必要があります。

**Follow-Through と重複するアクションの**

ゴルフのフォロースルーがスイングの結果を伝えるのと同様に、あるアクションから次のアクションへの移行は、アクション間の関係を伝える上で重要です。 アクションが突然完全に停止することはめったにありません。 したがって、フォロースルーアクションと重複アクションを使用して、キャラクターのモーションのフローを確立することもできます。 通常、これは、身体のさまざまな部分が移動する速度を変えて、モーションの主要な側面を超えて移動できるようにすることで実装できます。 たとえば、手の指は通常、手のジェスチャで手首の動きに従います。 また、この原則では、アクションが完全に停止するのではなく、他のアクションにスムーズに溶け込む必要があることを強調しています。

**遅いインアウト**

遅いインアンドアウトとは、あるポーズから別のポーズにキャラクターをスムーズに移動することを指します。 文字はアクションの開始と終了をゆっくりと行います。 これを実現するには、"中間" フレームの数、タイミング、位置を指定します。 含めるフレーム間の数が多いほど、遷移の速度が遅くなり、スムーズになります。

**Arcs**

自然の中で生きている物体が完全に直線で動くことはめったにありません。 その結果、移動のための円弧または曲線パスは、より自然な効果を提供します。 アークはまた動きの速度を伝える。 モーションが遅いほど、円弧が大きく、モーションが速いほど、円弧が平坦になります。

**誇張**

良いアニメーターは、多くの場合、キャラクターの形、色、感情、または行動を誇張します。 モーションの側面を「人生よりも大きくする」ことは、アクションのアイデアをより明確に観客に伝えます。 たとえば、キャラクターの腕は、弾力性のあるように見えるまで伸びることがあります。 ただし、誇張はバランスを取る必要があります。 状況によっては使用され、他の状況では使用されない場合、誇張されたアクションは非現実的に見え、ユーザーが特定の意味を持つものとして解釈される可能性があります。 同様に、画像の 1 つの側面を誇張する場合は、一致するように誇張すべき他の側面を検討してください。

セカンダリ アクション **の**

アニメーションには、あるポーズから次のポーズまでの間の画像のメカニズム的な作成以上のものが必要です。 プライマリ アクションは、通常、セカンダリ アクションでサポートされます。 セカンダリ アクションはプレゼンテーションを強化できますが、メイン アクションを損なったり支配したりしないでください。 顔の表情は、身体の動きに対する二次的なアクションとして使用されることがよくあります。 豊かさは、主なアイデアをサポートする要素を追加することで生まれます。

**ソリッド描画**

アニメーション化されたキャラクターを作成するには、一連の画像を作成する以上の作業が必要です。 効果的なアニメーション デザインでは、キャラクターの位置や角度が異なってどのように見えるかが考慮されます。 2 次元画像としてレンダリングされる文字であっても、概念的に 3 次元で考えられると、より現実的で信じやすくなります。 ツインを避ける: 顔、腕、脚を身体の両側に配置します。 これにより、木製の不自然なプレゼンテーションが行われます。 身体の動きはほとんど対称ではありませんが、姿勢や反応の全体的なバランスを取ります。

**アピール**

実装の成功は、対象ユーザーをどの程度よく理解しているかによって異なります。 キャラクターの全体的なイメージと個性は、ターゲットオーディエンスにアピールする必要があります。魅力は、フォトリアリズムを必要としません。 キャラクターの個性は、ジェスチャー、姿勢、その他のマナーを使用して、どんなに単純な形であっても伝えることができます。 最初のアニメーターの一般的な割り当ては、小麦粉袋や小さな敷物のための様々な表現を作成することです。 単純な図形を持つ文字は、多くの場合、複雑な文字よりも効果的です。 たとえば、多くの一般的な文字には 3 本の指と親指しかないとします。