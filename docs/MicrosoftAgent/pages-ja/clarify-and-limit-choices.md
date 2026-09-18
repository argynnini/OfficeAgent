---
layout: Conceptual
title: 選択肢を明確にして制限する - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/clarify-and-limit-choices
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: 選択肢を明確にして制限する
document_id: af236765-c5cf-5bb4-55f7-c8da0e016ab5
document_version_independent_id: e056c1e9-6ea9-e7ad-0ef9-925fadc04a1a
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/clarify-and-limit-choices.md
locale: ja-jp
ms.assetid: 4ec3ca01-231b-4a45-aae1-fba5b2ba0033
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/clarify-and-limit-choices.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:38:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/clarify-and-limit-choices.md
page_type: conceptual
toc_rel: toc.json
word_count: 2790
asset_id: lwef/clarify-and-limit-choices
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 0efbd0eb-2d6e-44fe-d461-bf77359143ea
---

# 選択肢を明確にして制限する - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

ユーザーが適切な文法の範囲を学習すると、音声認識がより成功します。 また、選択肢の範囲が限られている場合にも有効です。 入力のオープンエンドが少ないほど、音声エンジンは音響情報入力を分析できます。

Microsoft Agent には、音声入力の成功を高めるいくつかの組み込みプロビジョニングが含まれています。 1 つ目は、ユーザーが "コマンド ウィンドウを開く" または "何を言うことができるか" と表示されたときに表示されるコマンド ウィンドウです。(または、ユーザーがキャラクターのポップアップ メニューから [コマンド ウィンドウを開く] を選択した場合)。 コマンド ウィンドウは、音声エンジンのアクティブな文法の視覚的なガイドとして機能します。 また、入力アクティブなアプリケーションと Microsoft Agent のグローバル コマンドの音声認識文法のみをアクティブにすることで、認識エラーを減らします。 したがって、音声エンジンのアクティブな文法は、即時コンテキストに適用されます。 コマンド ウィンドウの詳細については、「[Microsoft エージェント プログラミング インターフェイスの概要](microsoft-agent-programming-interface-overview)を参照してください。

Microsoft Agent の音声対応コマンドを作成するときに、コマンド ウィンドウに表示されるキャプション テキストと、その音声テキスト (文法) を作成できます。このコマンドの照合にエンジンが使用する必要がある単語です。 常に、コマンドを可能な限り独特なものにしてみてください。 コマンドの文言 (特に音声テキスト) の違いが大きいほど、音声エンジンは音声コマンドを区別し、正確な一致を提供できる可能性が高くなります。 また、単一単語または非常に短いコマンドは避けてください。 一般に、発話内の音響情報が多いほど、エンジンは正確な一致を行う可能性が高くなります。

コマンドの音声テキストを定義する場合は、適切な種類の文言を指定します。 同じことを意味する要求は、次の例に示すように、非常に異なる方法で表現できます。

ペペロニを追加します。

ペパロニが必要です。

ペペロニを追加できますか?

ペパロニ、お願いします。

Microsoft エージェントを使用すると、アプリケーションの音声文法の代替単語または省略可能な単語を簡単に指定できます。 代替の単語または語句をかっこで囲み、縦棒で区切ります。 省略可能な単語は、角かっこで囲んで定義できます。 代替または省略可能な単語を入れ子にすることもできます。 さらに、音声テキストの省略記号 (...) を任意の単語のプレースホルダーとして使用することもできます。 ただし、省略記号を頻繁に使用すると、エンジンが異なる音声コマンドを区別するのが難しくなる場合があります。 いずれの場合も、必ず、オプションではないコマンドごとに、音声テキストに少なくとも 1 つの固有の単語が含まれていることを確認してください。 通常、これは、[コマンド] ウィンドウに表示される、定義したキャプション テキスト内の単語または単語と一致する必要があります。

キャプション テキストには記号、句読点、または省略形を含めることができますが、音声テキストには含めないでください。 多くの音声認識エンジンは、記号や省略形を処理できないか、特別な入力パラメーターを設定するために使用できます。 さらに、数値を入力します。 これにより、より信頼性の高い認識のサポートも保証されます。

また、ディレクティブ プロンプトを使用して、オープンエンド入力を回避することもできます。 ディレクティブ プロンプトは、次の例に示すように、選択肢を暗黙的に参照するか、明示的に指定します。

| プロンプト | 評価 |
| --- | --- |
| 何がしたいですか。 | 一般的すぎる、未終了の要求 |
| ピザのスタイルや材料を選択してください。 | 選択肢が表示されているが、それでも一般的な場合は良い |
| 「ハワイ」、「シカゴ」、または「作品」と言います。 | より良い、特定のオプションを持つ明示的なディレクティブ |

これにより、ユーザーは有効なコマンドを発行するように指示されます。 単語または語句を提案することで、期待される単語を見返りとして引き出す可能性が高くなります。 不自然な繰り返しを回避するには、ユーザーが入力スタイルに慣れるにつれて、その後のプレゼンテーションの単語を変更するか、元の表現を短くします。 ディレクティブ プロンプトは、ユーザーが所定の時間内にコマンドを発行できない場合や、予想されるコマンドを指定できない場合にも使用できます。 ディレクティブ プロンプトは、音声出力、アプリケーション インターフェイス、またはその両方を使用して提供できます。 重要なのは、ユーザーが適切な選択肢を把握するのに役立ちます。

文言はプロンプトの成功に影響します。 たとえば、"ピザを注文しますか?" というプロンプトでは、"はい" または "いいえ" のいずれかの応答が生成されますが、注文要求が生成される場合もあります。 プロンプトをあいまいにしないか、より多様な応答を受け入れる準備をするように定義します。 さらに、人が読み上げる単語やコンストラクトを模倣する傾向に注意してください。 これは、多くの場合、次の例のように適切な応答を呼び起こすために使用できます。

**ユーザー:** Paul からのすべてのメッセージを表示します。

**文字:**

これは、考えられるプレフィックスが "I mean" または "I meant" である当事者の完全な名前を引き出す可能性が高くなります。

Microsoft エージェントの文字は Microsoft Windows のビジュアル インターフェイス内で動作するため、ビジュアル要素を使用して音声入力のディレクティブ プロンプトを提供できます。 たとえば、選択肢の一覧で文字ジェスチャを設定し、ユーザーに選択を要求したり、ダイアログ ボックスまたはメッセージ ウィンドウに選択肢を表示したりできます。 これには 2 つの利点があります。ユーザーが話す単語を明示的に提案し、ユーザーが返信する別の方法を提供します。

次の例に示すように、他の対話モードを使用して、適切な音声認識文法をユーザーに微妙に提案することもできます。

**ユーザー:** (マウスでハワイスタイルのピザオプションをクリック)

**キャラクター:ハワイ風ピザ**。

**ユーザー:** (マウスで [追加チーズ] オプションをクリック)

**文字:**「余分なチーズ」を追加します。

音声入力が成功するもう 1 つの重要な要因は、多くの音声エンジンで一度に 1 つの発話しか許可されないため、エンジンが入力の準備ができたときにユーザーに通知することです。 Microsoft エージェントは、2 つの方法でこれをサポートします。 まず、サウンド カードが MIDI をサポートしている場合、Microsoft Agent は音声入力チャネルが使用可能になったときに通知する短いトーンを生成します。 次に、文字 (音声エンジン) が入力をリッスンしているときに、リッスン ヒント ウィンドウに適切なテキスト プロンプトが表示されます。 さらに、このヒントには、エンジンが聞いた内容が表示されます。