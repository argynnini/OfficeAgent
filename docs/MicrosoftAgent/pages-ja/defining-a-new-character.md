---
layout: Conceptual
title: 新しい文字の定義 - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/defining-a-new-character
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: 新しい文字の定義
document_id: b2a8a91e-e56e-b1cd-be5f-99987a91a5e4
document_version_independent_id: a7015342-5cf1-a3c7-704d-9098eaea7f72
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/defining-a-new-character.md
locale: ja-jp
ms.assetid: 4102cb7d-2fec-45d2-882a-04704c7f5a48
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/defining-a-new-character.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:39:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/defining-a-new-character.md
page_type: conceptual
toc_rel: toc.json
word_count: 2639
asset_id: lwef/defining-a-new-character
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/c6f99e62-1cf6-4b71-af9b-649b05f80cce
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/3f56b378-07a9-4fa1-afe8-9889fdc77628
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: b37b4dc7-e8f1-981e-bb4c-d9953d285f53
---

# 新しい文字の定義 - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

新しい文字を定義するには、エージェント文字エディターを実行します。 既存の文字ファイルが読み込まれている場合は、[**ファイル**] メニューから [**新規**] コマンドを選択します。 これにより、選択肢のサブメニューが表示されます。 独自に使用する文字を作成する場合は、[ **カスタム文字**] を選択します。 エージェントの既定の文字として使用できる文字を作成する場合は、[ **既定の文字**] を選択します。 これにより、必要なすべてのアニメーション名とアニメーション状態の割り当てを使用してエディターが事前に構成され、[ **標準アニメーション セットをサポート** ] オプションが設定されます。 同様に、[Office アシスタント文字] を選択した場合、エディターは、Office アシスタント文字に必要なアニメーション名とアニメーション状態の割り当てを使用して事前に構成されています。 この操作により、ツリー内の **[Character]\(文字** \) アイコンが選択され、ウィンドウの右側にそのプロパティ ページが表示されます。 次のセクションでは、キャラクタのプロパティを設定する方法と、キャラクタのアニメーションを作成する方法について説明します。

### キャラクターの全般的な情報を設定する

文字の定義を開始するには、[ **名前** ] テキスト ボックスに文字の名前を入力します (最大 32 文字)。 Microsoft エージェントは、 という名前を使用してユーザーが文字にアクセスできるようにするため、わかりやすい名前を指定します。 従来のスペルを使用して発音できる名前を指定するか、文字の音声入力を無効にすることができます。 [説明] テキスト ボックスで、文字の短い省略可能な説明 (256 文字) を指定することもできます。 サーバーは、[説明] テキスト ボックスに入力した内容をクライアント アプリケーションに公開します。

ExtraData フィールドを使用して、文字の一部として独自のデータを格納することもできます。 この機能を使用して、キャラクターやその他のデータに関する特別な情報を含めることができます。 文字エディターを使用してコンパイルすると、文字が読み込まれるときに実行時に ExtraData プロパティを使用してこの情報にアクセスできます。

文字の言語 ID 設定に基づいて、文字の名前、説明、および追加のデータ情報を設定できます。 このデータを別の言語に設定するには、[言語] を選択してテキストを入力します。 また、文字ファイルをビルドするシステムに言語コードページがインストールされている必要があります。 そうでない場合、適切な言語設定はコンパイル済み文字ファイルに含まれません。 他の言語で情報を提供する必要はありません。 これらのプロパティがエージェント API を使用して実行時に照会され、その言語の特定の設定がない場合は、英語 (既定) の設定が返されます。

### 文字の出力オプションを設定する

[標準アニメーション セットをサポート] オプションを設定すると、キャラクタ エディタがチェックされ、キャラクタを作成しようとしたときに、既定のキャラクタに必要なすべてのアニメーションとアニメーション状態の割り当てが含まれていることが確認されます。 何かが見つからない場合は、メッセージ ボックスに不足している要素が一覧表示されます。 標準アニメーション セットの詳細については、「 [**Designing Characters for Microsoft Agent**](designing-characters-for-microsoft-agent)」を参照してください。

文字の音声出力に対して、Microsoft エージェントは、合成されたテキスト読み上げ (TTS) 音声または録音されたサウンド ファイルを使用する音声の選択を提供します。 合成音声を使用する場合は、[音声出力に合成音声を使用する] オプションをチェックします。 これにより、音声の特性を選択するための [音声] ページが追加されます。 [音声] ページを選択し、そのページのコントロールを使用して、インストールした互換性のある TTS エンジンの音声、速度、ピッチを選択します。 選択できる音声パラメーターの範囲は、TTS エンジンによって異なります。 TTS エンジンをまだインストールしていない場合、音声 ID リストは空になります。 エージェント文字エディターでキャラクターの音声設定を定義する前に、TTS エンジンをインストールしておく必要があります。

文字の出力に TTS エンジンを使用する場合は、そのエンジンもユーザーのシステムにインストールする必要があります。 特定の TTS エンジンに基づいて音声を選択したが、ユーザーに別の TTS エンジンがインストールされている場合、サーバーはエージェント文字エディターで定義した特性に基づいて音声の照合を試みます。

録音したサウンド ファイルを使用する予定の場合 (.WAV ファイル) を使用する場合は、[音声出力に合成音声を使用] オプションをチェックする必要はありません。 代わりに、音声出力オーディオ ファイルを個別に記録し、アプリケーション コードから読み込む必要があります。

[**吹き出しWord**使用] オプションを使用すると、文字の吹き出しをサポートするかどうかを決定できます。 この機能は、実行時に設定することもできます。

[**吹き出しWord使用**]オプションをオンにすると、[**バルーンのWord**]ページにアクセスできます。 **[吹き出しのWord**] ページのオプションを使用すると、ワード バルーンの既定の特性を変更できます。 [ **行ごとの文字** 数] 設定を使用すると、1 行あたりの平均文字数に基づいてバルーンの幅を定義できます。 既定の高さは、一度に表示する固定行数に基づいて設定することも、 [**Speak**](speak-method) メソッドで指定したテキストに合わせて自動的にサイズを設定することもできます。 **また、Speak** メソッドの完了後に吹き出しを自動的に非表示にするかどうか、およびバルーンが自動的に文字の音声出力速度設定に合わせて単語を自動的に表示するか、"ペース" するかを設定することもできます。

**[吹き出しのWord**] ページでは、文字の吹き出しの既定のフォントと吹き出しの表示色を設定することもできます。 ただし、ユーザーは Microsoft Agent プロパティ シートを使用してワード バルーン フォントの設定をオーバーライドできることに注意してください。

### 文字の識別子を設定する

各文字には一意識別子 (GUID) が必要です。 サーバーは識別子を使用して文字を区別します。 新しい文字を作成すると、エディターによって文字の新しい識別子が自動的に作成されます。 文字の識別子を変更する必要があるのは、別の文字の文字定義ファイルをコピーした場合、または文字を以前のバージョンと意図的に区別する場合のみです。 文字の識別子を変更するには、[新しい GUID] ボタンをクリックすると、エディターによって新しい識別子が生成されます。