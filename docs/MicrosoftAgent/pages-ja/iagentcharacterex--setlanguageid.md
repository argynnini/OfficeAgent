---
layout: Conceptual
title: IAgentCharacterEx SetLanguageID - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcharacterex--setlanguageid
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCharacterEx SetLanguageID
document_id: e462944b-a480-2925-b1e5-7d030a5d19dc
document_version_independent_id: 69d22c93-921c-5cfd-27f3-1db983b7e70c
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacterex--setlanguageid.md
locale: ja-jp
ms.assetid: 064f4c3c-1871-4372-9796-5b53f05c6d9a
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacterex--setlanguageid.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:48:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcharacterex--setlanguageid.md
page_type: conceptual
toc_rel: toc.json
word_count: 1017
asset_id: lwef/iagentcharacterex--setlanguageid
item_type: Content
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/c6f99e62-1cf6-4b71-af9b-649b05f80cce
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/3f56b378-07a9-4fa1-afe8-9889fdc77628
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 978ca583-af78-6fa9-66ae-42efa5be74b9
---

# IAgentCharacterEx SetLanguageID - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT SetLanguageID(
   long langID  // language ID setting of character
); 
```

文字に設定された言語 ID を設定します。

- 操作が成功したことを示すS\_OKを返します。

- langID*を * する
    - 文字の言語 ID 設定。

文字の言語 ID を指定する長整数。 文字の言語 ID (LANGID) は、Windows によって定義される 16 ビット値であり、プライマリ言語 ID と第 2 言語 ID で構成されます。 指定した言語には、次の値を使用できます。 詳細については、プラットフォーム SDK のドキュメントを参照してください。

| 言語 | 身分証明書 | 言語 | 身分証明書 |
| --- | --- | --- | --- |
| アラビア語 (サウジアラビア) | 0x0401 | イタリア語 | 0x0410 |
| バスク語 | 0x042d | 日本語 | 0x0411 |
| 中国語 (簡体字) | 0x0804 | 韓国語 | 0x0412 |
| 中国語 (繁体字) | 0x0404 | ノルウェー語 | 0x0414 |
| クロアチア語 | 0x041A | ポーランド語 | 0x0415 |
| チェコ語 | 0x0405 | ポルトガル語 (ポルトガル) | 0x0816 |
| デンマーク語 | 0x0406 | ポルトガル語 (ブラジル) | 0x0416 |
| オランダ語 | 0x0413 | ルーマニア語 | 0x0418 |
| 英語 (イギリス) | 0x0809 | ロシア語 | 0x0419 |
| 英語 (米国) | 0x0409 | スロヴァキア語 | 0x041B |
| フィンランド語 | 0x040B | スロベニア語 | 0x0424 |
| フランス語 | 0x040C | スペイン語 | 0x0C0A |
| ドイツ語 | 0x0407 | スウェーデン語 | 0x041D |
| ギリシャ語 | 0x0408 | タイ語 | 0x041E |
| ヘブライ語 | 0x040D | トルコ語 | 0x041F |
| ハンガリー語 | 0x040E |  |  |

文字の言語 ID を設定しない場合、対応するエージェント言語 DLL がインストールされている場合、その言語 ID は現在のシステム言語 ID になります。それ以外の場合、文字の言語は英語 (米国) になります。

このプロパティは、吹き出しテキストの言語、文字のポップアップ メニューのコマンド、音声認識エンジンも決定します。 また、TTS 出力の既定の言語も決定します。 文字の言語で使用できる互換性のある音声エンジンがあるかどうかを確認するには、IAgentCharacterEx::GetSRModeID使用するか、IAgentCharacterEx::GetTTSModeID**[を](iagentcharacterex--getttsmodeid)**します。

文字の言語 ID を設定しようとして、エージェント言語リソース、コード ページ、または言語 ID の表示フォントを使用できない場合、エージェントはエラーを返し、文字の言語 ID は最後の設定のままです。 言語に一致する音声エンジンがない場合、このプロパティを設定してもエラーは返されません。

このプロパティは、クライアント アプリケーションによる文字の使用にのみ適用されます。この設定は、文字の他のクライアントやクライアント アプリケーションの他の文字には影響しません。

手記

文字の言語 ID を双方向テキスト (アラビア語やヘブライ語など) をサポートする言語に設定したが、アプリケーションを実行しているシステムに双方向サポートがインストールされていない場合、テキストは表示順序ではなく論理的にワード バルーンに表示されます。