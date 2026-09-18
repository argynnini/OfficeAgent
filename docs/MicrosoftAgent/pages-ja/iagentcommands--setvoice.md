---
layout: Conceptual
title: IAgentCommands SetVoice - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcommands--setvoice
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCommands SetVoice
document_id: 1b194228-8e03-76bf-9d45-6dabb41c22e5
document_version_independent_id: c544f87d-0be0-99ed-c473-104868aa09fc
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentcommands--setvoice.md
locale: ja-jp
ms.assetid: dfb3b58a-7f24-4366-8f04-93a9e956fdc8
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommands--setvoice.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:50:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcommands--setvoice.md
page_type: conceptual
toc_rel: toc.json
word_count: 2512
asset_id: lwef/iagentcommands--setvoice
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 633b72e5-fffa-6d94-c441-b8488ccb6426
---

# IAgentCommands SetVoice - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT SetVoice(
   BSTR bszVoice  // the Voice setting for Command collection
);
```

[**コマンド**](/ja-jp/windows/desktop/lwef/the-command-object)の [**Voice**](voice-property) テキスト プロパティを設定します。

- 操作が成功したことを示すS\_OKを返します。

- *bszVoice*
    - [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションの [**Voice**](voice-property) テキスト プロパティの値を指定する BSTR。

[**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションには、その [**Voice**](voice-property) text プロパティが音声アクセス可能に設定されている必要があります。 また、その [**VoiceCaption**](voicecaption-property) または [**Caption**](caption-property) プロパティが [音声コマンド] ウィンドウに表示されるように設定され、その [**Visible**](visible-property) プロパティが文字のポップアップ メニューに表示 **True** に設定されている必要があります。

指定する BSTR 式には、省略可能な単語を示す角かっこ ([ ]) と、代替文字列を示す縦棒 (|) を含めることができます。 代替はかっこで囲む必要があります。 たとえば、"(hello [there] |hi)" は、コマンドの "hello"、"hello there"、または "hi" を受け入れるように音声エンジンに指示します。 角かっこまたはかっこに含める単語と、その他のテキストの間に適切なスペースを含める必要があります。 角かっこまたはかっこ内のテキストと、角かっこまたはかっこに含まれていないテキストの間に適切なスペースを含めるのを忘れないでください。

star (\*) 演算子を使用して、グループに含まれる単語の 0 個以上のインスタンスを指定するか、プラス (+) 演算子を使用して 1 つ以上のインスタンスを指定できます。 たとえば、次の結果は、"try this"、"please this"、および "please this" をサポートする文法になり、"please" の反復回数に制限はありません。

```syntax
   "please* try this"
```

次の文法形式では、+演算子で "please" のインスタンスが少なくとも 1 つ定義されているため、"try this" は除外されます。

```syntax
   "please+ try this"
```

繰り返し演算子は、通常の優先順位の規則に従い、直前のテキスト項目に適用されます。 たとえば、次の文法の結果は "New York" と "New York" になりますが、"New York New York" ではありません。

```syntax
   "New York+"
```

そのため、通常は、これらの演算子をグループ化文字と共に使用します。 たとえば、次の文法には "New York" と "New York New York" の両方が含まれます。

```syntax
   "(New York)+"
```

繰り返し演算子は、電話番号やアイテムリストの指定などの繰り返しシーケンスを含む文法を作成する場合に便利です。

```syntax
   "call (one|two|three|four|five|six|seven|eight|nine|zero|oh)*"
   "I'd like (cheese|pepperoni|pineapple|canadian bacon|mushrooms|and)+"
```

演算子は角かっこ (省略可能なグループ化文字) でも使用できますが、これを行うと、Agent による文法処理の効率が低下する可能性があります。

省略記号 (...) を使用して、*単語スポッティング*をサポートすることもできます。つまり、語句内のこの位置で読み上げられた単語 (*ガベージ* 単語とも呼ばれます) を無視するように音声認識エンジンに指示できます。 省略記号を使用する場合、音声エンジンは、隣接する単語または語句で読み上げられたときに関係なく、文字列内の特定の単語のみを認識します。 たとえば、このプロパティを "[...] に設定するとします。check mail [...]" は、音声認識エンジンが "メールを確認してください" や "メールを確認してください" などの語句をこのコマンドに一致させます。 省略記号は、文字列内の任意の場所で使用できます。 ただし、省略記号付きの音声設定では、望ましくない一致の可能性が高まる可能性があるため、この手法を使用する場合は注意してください。

コマンドの単語と文法を定義する場合は、必要な単語を少なくとも 1 つ含めます。つまり、省略可能な単語のみを指定しないでください。 さらに、単語に発音可能な単語と文字のみが含まれていることを確認します。 数値の場合は、あいまいな表現を使用するのではなく、単語をスペル アウトすることをお勧めします。 たとえば、"345" は適切な文法形式ではありません。 同様に、"IEEE" の代わりに "I triple E" を使用します。 また、句読点や記号は省略してください。 たとえば、"#1 $10 pizza!" ではなく、"number 10 dollar pizza" を使用します。 1 つのコマンドに発音できない文字または記号を含めると、音声エンジンがすべてのコマンドの文法をコンパイルできないことがあります。 最後に、定義した他の音声コマンドと、音声パラメーターを可能な限り明確にします。 コマンドの音声文法の類似性が高いほど、音声エンジンで認識エラーが発生する可能性が高くなります。 また、信頼度スコアを使用して、類似または類似の音声文法を持つ可能性のある 2 つのコマンドをより適切に区別することもできます。

文法の単語には、"*text\pronunciation*" という形式で含めることができます。ここで、"text" は表示されるテキスト、"発音" は発音を明確にするテキストです。 たとえば、ユーザーが "first" と言うと文法 "1st\first" が認識されますが、[**Command**](/ja-jp/windows/desktop/lwef/the-command-object) イベントは "1st\first" というテキストを返します。 IPA (国際ふりがな) を使用して、発音をシャープ記号 ("#") で始め、次に IPA の発音を表すテキストで発音を指定することもできます。

日本語の音声認識エンジンでは、文法を "*かな\漢字*" という形式で定義し、代替の発音を減らし、精度を高めることができます。 (下位互換性のために順序が逆になります)。これは、漢字の正しい名前の発音に特に重要です。 ただし、かなを使用せずに「漢字」を渡すことができます。その場合、エンジンは漢字に対して許容できるすべての発音を聞く必要があります。 かなだけを渡すこともできます。

グループ化または繰り返しの書式設定文字を使用するエラーを除き、エンジン自体がエラーを報告しない限り、Microsoft エージェントは文法のエラーを報告しません。 文法で、エンジンがコンパイルに失敗したが、エンジンが処理せず、エラーとして返されるテキストを渡した場合、エージェントはエラーを報告できません。 そのため、クライアント アプリケーションでは、[**Voice**](voice-property) プロパティの文法を慎重に定義する必要があります。

手記

使用できる文法機能は、音声認識エンジンによって異なります。 サポートされている文法オプションを判断するには、エンジンのベンダーに問い合わせてください。 特定のエンジンを使用するには、[**SRModeID**](srmodeid-property) を使用します。

このプロパティの操作は、Microsoft エージェント サーバーの音声認識状態の状態によって異なります。 たとえば、音声認識が無効になっているか、インストールされていない場合、この関数はすぐには効果がありません。 ただし、セッション中に音声認識が有効になっている場合は、クライアント アプリケーションが入力アクティブのときにコマンドにアクセスできるようになります。