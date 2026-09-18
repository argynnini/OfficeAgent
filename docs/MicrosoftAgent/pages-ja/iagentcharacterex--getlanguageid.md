---
layout: Conceptual
title: IAgentCharacterEx GetLanguageID - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcharacterex--getlanguageid
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCharacterEx GetLanguageID
document_id: 80fd41d7-3149-7013-b2ff-7e89826751f2
document_version_independent_id: 56fc6672-248e-cd6b-97ef-3122930e7809
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacterex--getlanguageid.md
locale: ja-jp
ms.assetid: 4e4e5342-edf9-480b-a9c3-e2626fd89e76
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacterex--getlanguageid.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:48:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcharacterex--getlanguageid.md
page_type: conceptual
toc_rel: toc.json
word_count: 835
asset_id: lwef/iagentcharacterex--getlanguageid
item_type: Content
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/c6f99e62-1cf6-4b71-af9b-649b05f80cce
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/3f56b378-07a9-4fa1-afe8-9889fdc77628
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: d95dad66-1005-f177-e4ea-b8faaadb1bf8
---

# IAgentCharacterEx GetLanguageID - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT GetLanguageID(
   long * plangID  // address of language ID setting
);
```

文字の言語 ID セットを取得します。

- 操作が成功したことを示すS\_OKを返します。

- plangID*を * する
    - 文字の言語 ID 設定を受け取る変数のアドレス。

文字の言語 ID を指定する長整数。 文字の言語 ID (LANGID) は、Windows によって定義される 16 ビット値であり、プライマリ言語 ID と第 2 言語 ID で構成されます。 次の例は、一部の言語の値です。 他の言語の値を確認するには、プラットフォーム SDK のドキュメントを参照してください。

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

文字にこの言語 ID を設定しない場合、文字の言語 ID は現在のシステム言語 ID になります。

この設定では、TTS 出力、ワード バルーン テキスト、キャラクターのポップアップ メニューのコマンド、音声認識エンジンの言語も決定されます。 文字の言語で使用できる互換性のある音声認識エンジンがあるかどうかを確認するには、IAgentCharacterEx::GetSRModeID使用するか、IAgentCharacterEx::GetTTSModeIDします。

このプロパティは、クライアント アプリケーションによる文字の使用にのみ適用されます。この設定は、文字の他のクライアントやクライアント アプリケーションの他の文字には影響しません。

手記

言語 ID が双方向テキスト (アラビア語やヘブライ語など) をサポートする言語に設定されているが、アプリケーションを実行しているシステムに双方向サポートがインストールされていない場合、テキストは表示順序ではなく論理的に吹き出しで表示されます。