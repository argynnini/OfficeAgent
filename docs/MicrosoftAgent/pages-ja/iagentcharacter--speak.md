---
layout: Conceptual
title: IAgentCharacter Speak - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcharacter--speak
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCharacter Speak
document_id: 4995970e-4a3d-a39d-4b99-3673038232f9
document_version_independent_id: 30fd8758-9d60-be68-8d3d-ff4c02392822
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacter--speak.md
locale: ja-jp
ms.assetid: 3c4baf83-9e69-4048-bdaf-4ead8ea8e7cd
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacter--speak.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:47:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcharacter--speak.md
page_type: conceptual
toc_rel: toc.json
word_count: 1140
asset_id: lwef/iagentcharacter--speak
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 5702a2db-753f-8740-01fd-297f0f8c61c0
---

# IAgentCharacter Speak - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT Speak(
   BSTR bszText,    // text to speak
   BSTR bszURL,     // URL of a file to speak
   long * pdwReqID  // address of a request ID
);
```

テキストまたはサウンド ファイルを読み上げる。

- 操作が成功したことを示すS\_OKを返します。

- *bszText*
    - 文字が読み上げるテキスト。
- bszURL*を * する
    - 音声出力に使用するサウンド ファイルの URL (またはファイル指定)。 これは、標準のサウンド ファイル (.WAV) または言語的に拡張されたサウンド ファイル (.LWV)。
- pdwReqID*を * する
    - [**Speak**](/ja-jp/windows/desktop/lwef/iagentcharacter--speak) 要求 ID を受け取る変数のアドレス。

テキスト読み上げ (TTS) エンジンを使用して話されるように構成された文字でこのメソッドを使用する場合。*bszText* パラメーターを指定するだけです。 *bszText* パラメーターに垂直バー文字 (|) を含めて代替文字列を指定し、サーバーがメソッドを処理するたびにランダムに別の文字列を選択することができます。 TTS 出力のサポートは、Microsoft エージェント文字エディターを使用して文字をコンパイルするときに定義されます。

文字にサウンド ファイル出力を使用する場合は、*bszURL* パラメーターでファイルの場所を指定します。 HTTP プロトコルを使用してサウンド ファイルをダウンロードする場合は、[**Prepare**](/ja-jp/windows/desktop/lwef/iagentcharacter--prepare) メソッドを使用して、このメソッドを使用する前にファイルの可用性を確保します。 *bszText* パラメーターを使用して、文字の吹き出しに表示される単語を指定できます。 言語的に拡張されたサウンド ファイル (.LWV) は、*bszURL* パラメーターに対してテキストを指定せず、*bszText* パラメーターはファイルに格納されているテキストを使用します。

[**Speak**](/ja-jp/windows/desktop/lwef/iagentcharacter--speak) メソッドは、最後に再生されたアニメーションを使用して、再生するスピーキング アニメーションを決定します。 たとえば、**Speak** コマンドの前に、[**IAgentCharacter::P lay**](iagentcharacter--play) "**GestureRight**" を指定すると、サーバーは GestureRight  再生され、**GestureRight** 読み上げアニメーションが再生されます。 最後に再生されたアニメーションにスピーキング アニメーションがない場合、Microsoft エージェントはキャラクターの **読み上げ** 状態に割り当てられたアニメーションを再生します。

[**Speak**](/ja-jp/windows/desktop/lwef/iagentcharacter--speak) を呼び出し、オーディオ チャネルがビジー状態の場合、キャラクターのオーディオ出力は聞こえないが、テキストは吹き出しという単語に表示されます。 吹き出しの [Enabled](enabled-property) プロパティも、テキストを表示するには True  する必要があります。

Microsoft Agent の吹き出し内の単語の自動改行は、空白文字 (スペースやタブなど) を使用して単語を区切ります。 ただし、吹き出しに合わせて単語を区切る場合もあります。 日本語、中国語、タイ語などの言語では、単語を区切るためにスペースが使用されない場合は、文字間に Unicode ゼロ幅の空白文字 (0x200B) を挿入して、論理的な単語区切りを定義します。

手記

[**Speak**](/ja-jp/windows/desktop/lwef/iagentcharacter--speak) メソッドを使用する前に、文字の言語 ID ([**IAgentCharacterEx::SetLanguageID**](iagentcharacterex--setlanguageid) を使用) を設定して、吹き出し内に適切なテキストが表示されるようにします。