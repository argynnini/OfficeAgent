---
layout: Conceptual
title: 音声認識 - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/speech-recognition
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: 音声認識
document_id: 91402e4b-802d-0e71-e265-65eea7947fce
document_version_independent_id: 51846f8e-c45c-f570-7eb2-14e2c287ab7a
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/speech-recognition.md
locale: ja-jp
ms.assetid: cb5ac509-12a4-4ca4-8776-424568cf780d
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/speech-recognition.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:01:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/speech-recognition.md
page_type: conceptual
toc_rel: toc.json
word_count: 1574
asset_id: lwef/speech-recognition
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: fb4dbfcc-b7a9-e066-70c7-1284248882c5
---

# 音声認識 - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

音声認識は、文字と対話するための非常に自然で使い慣れたインターフェイスを提供します。 ただし、音声入力にも多くの課題があります。 現在、音声エンジンは、ジェスチャー、イントネーション、顔の表現など、人間の音声通信のレパトアのかなりの部分なしで動作します。 また、自然な音声は通常、無制限です。 スピーカーは、エンジンの現在のボキャブラリ(文法 )を超えるのは簡単です。 同様に、単語または単語の順序は、特定の要求または応答によって異なる場合があります。 さらに、音声認識エンジンは、多くの場合、話者の環境の大きなバリエーションに対処する必要があります。 たとえば、バックグラウンド ノイズ、マイクの品質、位置は入力品質に影響を与える可能性があります。 同様に、話者の発音が異なる場合や、話者が寒い場合など、同じ話者のバリエーションであっても、音響データを表現理解に変換することが困難になります。 最後に、音声エンジンは、"新しい"、"知っている"、"gnu"、"素晴らしいビーチを破壊する"、"音声を認識する" など、同じような音声の単語やフレーズを言語で処理する必要があります。

音声は、タスクに最適な入力形式とは限りません。 音声のターンテイクの性質上、多くの場合、他の形式の入力よりも遅くなる可能性があります。 キーボードと同様に、何らかの種類のニーモニック表現が提供されない限り、音声入力は指し示しのインターフェイスが不適切です。 そのため、音声がタスクに最も適した入力であるかどうかを常に検討してください。 任意のタスクに対する排他的なインターフェイスとして音声を使用することは避けるのが最善です。 マウスやキーボードなどのメソッドを使用して、基本的な機能にアクセスする他の方法を提供します。 さらに、コンテキストとオプションを指定するのに役立つ視覚情報と音声入力を組み合わせることにより、ビジュアル インターフェイスで音声を使用するマルチモーダルな性質を利用します。

最後に、音声入力の正常な使用は、テクノロジの品質の一部に過ぎません。 現在の認識テクノロジを超える人間の認識であっても、失敗することがあります。 ただし、人間のコミュニケーションでは、成功の確率を向上させ、問題が発生したときにエラーの回復を提供する戦略を使用します。 したがって、音声入力の有効性は、それを提示するユーザー インターフェイスの品質にも依存します。

より自然な音声インターフェイスを設計する場合は、音声対話の人間モデルを研究すると便利です。 特定のシナリオに対して実際の人間の音声ダイアログを記録すると、使用されるコンストラクトとパターン、および効果的な形式のフィードバックとエラーの回復をより深く理解するのに役立つ場合があります。 使用する適切なボキャブラリを決定するのに役立ちます (入力と出力用)。 ユーザーが実際に話す方法に基づいて音声インターフェイスを設計する方が、動作するグラフィカル インターフェイスから派生させるよりも優れています。

Microsoft エージェントでは、音声認識をサポートするために Microsoft Speech API (SAPI) が使用されることに注意してください。 これにより、Microsoft エージェントをさまざまな互換性のあるエンジンで使用できます。 Microsoft エージェントは特定の基本インターフェイスを指定していますが、エンジンのパフォーマンス要件と品質は異なる場合があります。

会話インターフェイスをサポートする手段は音声だけではありません。 また、音声の代わりに、または音声に加えて、キーボード入力の自然言語処理を使用することもできます。 このような場合でも、通常は音声入力のガイドラインを適用できます。

- 聞く [、](listen--dont-just-recognize) を認識するだけではない
- [選択肢の明確化と制限](clarify-and-limit-choices)
- 適切なエラー回復 [を提供する](provide-good-error-recovery)