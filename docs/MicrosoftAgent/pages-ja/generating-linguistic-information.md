---
layout: Conceptual
title: 言語情報の生成 - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/generating-linguistic-information
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: 言語情報の生成
document_id: 5b65c481-ec7b-8e6b-0dc7-c54308a6ba2e
document_version_independent_id: e1378972-9bcd-d615-f0b1-17492082ed5c
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/generating-linguistic-information.md
locale: ja-jp
ms.assetid: 903561f0-89dc-4297-8ea0-3fa150f2e6dd
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/generating-linguistic-information.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:43:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/generating-linguistic-information.md
page_type: conceptual
toc_rel: toc.json
word_count: 2638
asset_id: lwef/generating-linguistic-information
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 9350115d-a9e3-e25f-cb03-c34c699fbe8f
---

# 言語情報の生成 - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

新しいサウンド ファイルを録音した後、または既存のサウンド ファイルを読み込んだ後、サウンド ファイルに対応するテキストを [ **テキスト表現** ] ボックスに入力することで、ふりがなと単語区切りの情報を生成できます。 次に、[**編集**] メニューまたはツール バーから [**言語情報の生成**] コマンドを選択します。 サウンド エディターに進行状況メッセージが表示され、サウンド ファイルの処理が開始されます。 言語情報の生成が完了すると、サウンド ファイルの単語ラベルと音素ラベルのマッピングが [ **オーディオ表現** ] ボックスのボックスに表示されます。 サウンド ファイルのテキスト表現を入力するまで、[ **言語情報の生成]** コマンドは無効のままであることに注意してください。

![Microsoft 言語情報サウンド編集ツールの \[テキスト表現\] ペインと \[オーディオ表現\] ペインを示すスクリーンショット。](images/f3listlabel.gif)

エディターで単語ラベルまたは音素ラベルの許容できるセットが生成されない場合は、もう一度 [ **言語情報の生成** ] コマンドを選択します。 エディターで言語情報が生成されない場合は、テキスト表現をチェックして、すべての単語が正しく順序付けされ、スペルが正しいことを確認し、句読点の周りに不要なスペースがないことを確認します。 次に、[ **言語情報の生成** ] コマンドをもう一度選択します。 テキスト表現を編集するには、[テキスト**表現**] テキスト ボックスでテキストを選択し、[**編集**] メニューの **[切り取り**]、[**コピー**]、[**貼り付け**] コマンドを使用します。 サウンド ファイルに含まれる単語がわからない場合は、[**編集**] メニューまたはエディターのツール バーから [再生] を選択してサウンド ファイルを**再生**できます。 エディターで言語ラベルの生成に失敗した場合は、サウンド ファイルをもう一度記録してみてください。 品質の低い記録 (特に過剰なバックグラウンド ノイズ) では、合理的な言語情報を生成する確率が低下する可能性があります。

また、オーディオ表現の一部を選択し、[**編集**] メニューから [音**素の挿入]** または [**Wordの挿入**] を選択して、独自の言語情報を手動で作成することもできます。 これらのコマンドは、選択範囲内で右クリックした場合にも使用できます。

Microsoft エージェントとの文字アニメーションのリップ同期に言語情報を使用する方法を確認するには、ツール バーの **[再生** ] ボタンを選択すると、エディターによってサウンド ファイルが再生され、生成されたラベル情報に基づいてサンプルの口の画像がアニメーション化されます。

音素ラベルの表示を変更して IPA (国際ふりがな) の割り当てを表示するには、[**編集**] メニューの [**音素ラベルの表示**] コマンドを選択し、[IPA] コマンドを選択します。 これにより、音素のバイト値が表示されます。 わかりやすい名前に戻すには、 **Phoneme Label Display** コマンドをもう一度選択し、[名前] を選択 **します**。

### サウンド ファイルの再生

標準の Windows サウンド ファイルまたは言語的に強化されたサウンド ファイルを再生するには、[**オーディオ**] メニューまたはエディターのツール バーから **[再生**] コマンドを選択します。 **[一時停止]** コマンドと **[停止**] コマンドを使用すると、サウンド ファイルの再生を一時停止または停止できます。 ファイルを再生すると、サンプルの口の画像がアニメーション化され、Microsoft エージェント文字によってリップ同期情報がどのように使用されるかが示されます。

オーディオ **表現** で選択範囲をドラッグするか、単語または音素ラベルをクリックして、[ **再生**] を選択して、サウンド ファイルの選択した部分を再生することもできます。 Shift キーを押しながらクリックするか、Shift キーを押して **オーディオ表現**の新しい場所にドラッグすることで、既存の選択範囲を拡張できます。

### 言語情報の編集

ファイルの言語情報は、いくつかの方法で編集できます。 たとえば、単語または音素ラベルの境界を調整するには、ラベルの範囲を定義するボックスの端にポインターを移動します。 ポインターが境界移動ポインターに変わったら、左または右にドラッグします。 エディターでは、隣接する単語または音素の境界も自動的に調整されます。

![ファイルの言語情報の編集を示すスクリーンショット。](images/f4listadj.gif)

音素ラベルの境界を調整すると、オーディオの再生時に音素のタイミングが変わります。 Microsoft エージェントで使用するために開発された文字の場合、音素ラベルの境界を変更すると、その音素にマップされた口の画像のタイミングまたは期間が変更される可能性があります。 単語ラベルの境界を変更すると、文字の吹き出しの単語の外観のタイミングが変わります。

音素の割り当てを置き換えるには、音素ラベルを選択し、[**編集]** メニューから [**音素の置換**] を選択するか、音素ラベルを右クリックしてポップアップ メニューから [**音素の置換**] を選択します。 エディターに [ **音素の置換** ] ダイアログ ボックスが表示され、ラベルの現在の音素の割り当てが強調表示されます。 **IPA** リストで 1 つを選択するか、[**名前**] リストで別のエントリを選択して、置換音素を選択できます。 その名前に対して複数の IPA 変換を使用できる場合は、 **IPA** リスト内の項目を選択します。 言語に直接含まれない音素の IPA 指定を入力するには、その 16 進値または複数の 16 進値をプラス (+) 文字と連結して入力します。 置換する音素情報を選択したら、[ **OK] を**選択すると、選択した音素ラベルがエディターによって置き換えられます。

![わかりやすいラベルとして \[SIL&gt;\] が選択されている \[&lt;音素の置換\] ダイアログを示すスクリーンショット。](images/f5listphone.gif)

同様に、ラベルのボックスをクリックして [Word置換] を選択**するか、ラベル**のボックスを右クリックしてポップアップ メニューから [Word置換] を選択することで、単語ラベルを**置き換**えることができます。 エディターに [**Word置換**] ダイアログ ボックスが表示されます。 置換単語を入力し、[ **OK] を選択します**。

![\[Word テキスト\] テキスト ボックスに入力された \[Wordの置換\] ダイアログを示すスクリーンショット。](images/f6listrep.gif)

Microsoft Agent で使用するために開発された文字の場合、音素ラベルを置き換えると、サウンド ファイルの再生時に表示される口の画像が変更される場合があります。 単語を置き換えると、 [**Speak**](speak-method) メソッドが呼び出されたときに文字の吹き出しに表示されるテキストが置き換えられます。

新しい音素ラベルまたは単語を挿入するには、[**オーディオ表現**] で選択し、[**編集**] メニューから [**音素の挿入]** または **[Word挿入**] を選択するか、選択範囲内を右クリックしてポップアップ メニューからコマンドを選択します。 これらのコマンドは、[**音素の置換**] ダイアログ ボックスと [**Word置換**] ダイアログ ボックスと同様のダイアログ ボックスを表示します。ただし、エディターは既存の情報を置き換えるのではなく、新しい単語または音素を挿入します。

最後に、音素または単語のラベルを選択し、[音素の削除] または [削除] Wordを選択して、**音素**または単語を**削除**できます。 これにより、その言語情報がファイルから削除されます。