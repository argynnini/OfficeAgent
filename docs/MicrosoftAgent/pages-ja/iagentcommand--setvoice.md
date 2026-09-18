---
layout: Conceptual
title: IAgentCommand SetVoice - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcommand--setvoice
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCommand SetVoice
document_id: 5a06f3f0-73cf-3230-6d6b-4dcc969d4cc6
document_version_independent_id: 101e2691-8bea-a4f0-0fb8-adbe29901059
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcommand--setvoice.md
locale: ja-jp
ms.assetid: bee06616-26bf-4e1e-89da-6765dd77fb02
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommand--setvoice.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:49:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcommand--setvoice.md
page_type: conceptual
toc_rel: toc.json
word_count: 1768
asset_id: lwef/iagentcommand--setvoice
item_type: Content
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/49f7a155-15b3-4cce-8c03-a814c52269b6
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/73c34d6e-8193-442f-9cd9-38506534a799
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 1aa87a67-3bca-74d4-e928-f9d2aaa250fa
---

# IAgentCommand SetVoice - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT SetVoice(
   BSTR bszVoice  // voice text setting for Command
);
```

[**コマンド**](/ja-jp/windows/desktop/lwef/the-command-object)の [**Voice**](voice-property) プロパティを設定します。

- 操作が成功したことを示すS\_OKを返します。

- *bszVoice*
    - [**コマンド**](/ja-jp/windows/desktop/lwef/the-command-object)の [**Voice**](voice-property) プロパティのテキストを指定する BSTR。

[**コマンド**](/ja-jp/windows/desktop/lwef/the-command-object) には、その [**Voice**](voice-property) プロパティと [**Enabled**](enabled-property) プロパティが音声アクセス可能に設定されている必要があります。 また、その [**VoiceCaption**](voicecaption-property) プロパティが **Voice Commands ウィンドウ**に表示されるように設定されている必要があります。 (下位互換性のために、VoiceCaption がない場合は、[**Caption**](caption-property) 設定が使用されます)。

指定する BSTR 式には、省略可能な単語を示す角かっこ ([ ]) と、代替文字列を示す縦棒 (|) を含めることができます。 代替はかっこで囲む必要があります。 たとえば、"(hello [there] |hi)" は、コマンドの "hello"、"hello there"、または "hi" を受け入れるように音声エンジンに指示します。 角かっこまたはかっこ内のテキストと、角かっこまたはかっこに含まれていないテキストの間に適切なスペースを含めるのを忘れないでください。

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

省略記号 (...) を使用して、*単語スポッティング*をサポートすることもできます。つまり、語句内のこの位置で読み上げられた単語 (*ガベージ* 単語とも呼ばれます) を無視するように音声認識エンジンに指示できます。 したがって、音声エンジンは、隣接する単語または語句でいつ話されたかに関係なく、文字列内の特定の単語のみを認識します。 たとえば、このプロパティを "[...] に設定するとします。check mail [...]" は、音声認識エンジンが "メールを確認してください" や "メールを確認してください" などの語句をこのコマンドに一致させます。 省略記号は、文字列内の任意の場所で使用できます。 ただし、省略記号を含む音声設定は不要な一致の可能性を高める可能性があるため、この手法を使用する場合は注意が必要です。

コマンドの単語と文法を定義するときは、必ず、必要な単語を少なくとも 1 つ含めるようにしてください。つまり、省略可能な単語のみを指定しないでください。 さらに、単語に発音可能な単語と文字のみが含まれていることを確認します。 数値の場合は、数値表現を使用するのではなく、単語をスペル アウトすることをお勧めします。 また、句読点や記号は省略してください。 たとえば、"#1 $10 pizza!" ではなく、"number 10 dollar pizza" を使用します。 1 つのコマンドに発音できない文字または記号を含めると、音声エンジンがすべてのコマンドの文法をコンパイルできないことがあります。 最後に、定義した他の音声コマンドと、音声パラメーターを可能な限り明確にします。 コマンドの音声文法の類似性が高いほど、音声エンジンで認識エラーが発生する可能性が高くなります。 また、信頼度スコアを使用して、類似または類似の音声文法を持つ可能性のある 2 つのコマンドをより適切に区別することもできます。

[**コマンド**](/ja-jp/windows/desktop/lwef/the-command-object) の [**Voice**](voice-property) プロパティを自動的に設定すると、エージェントの音声サービスが有効になり、Listening キーと Listening Tip が使用可能になります。 ただし、音声認識エンジンは読み込まれません。

手記

使用できる文法機能は、音声認識エンジンによって異なります。 サポートされている文法オプションを判断するには、エンジンのベンダーに問い合わせてください。 [**IAgentCharacterEx::SRModeID**](https://www.bing.com/search?q=**IAgentCharacterEx::SRModeID**) を使用してエンジンを指定します。