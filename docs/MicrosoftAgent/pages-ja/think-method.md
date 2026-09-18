---
layout: Conceptual
title: Think メソッド - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/think-method
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Think メソッド
document_id: b215254f-f9d1-c600-bba1-016eb8d1bf2f
document_version_independent_id: c0aaca06-7368-0dc0-ec07-7e04085f6370
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/think-method.md
locale: ja-jp
ms.assetid: a188dd47-6af1-429d-af0a-69451f6b495e
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/think-method.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:02:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/think-method.md
page_type: conceptual
toc_rel: toc.json
word_count: 691
asset_id: lwef/think-method
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: e69f879a-75b0-2bb4-442c-abc0be23862c
---

# Think メソッド - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - "thought" ワード バルーン内の指定した文字の指定したテキストを表示します。
- **構文の**
    - エージェント \*\* です。characters ("***CharacterID***")。Think\*\* [*Text*]

| 部分 | 形容 |
| --- | --- |
| *テキスト* | 随意。 文字の思考出力を指定する文字列。 |

## 備考

[**Speak**](speak-method) メソッドと同様に、**Think** メソッドは、単語吹き出しにテキストを表示するキューに登録された要求ですが、**Think** ワード バルーンは視覚的に異なります。 さらに、吹き出しは Bookmark 音声コントロール タグ (**\Mrk**) のみをサポートし、他の音声コントロール タグは無視します。 **Speak**とは異なり、**Think** メソッドはキャラクターのアニメーションの状態を変更しません。

[**Balloon**](/ja-jp/windows/desktop/lwef/the-balloon-object) オブジェクトのプロパティは、[**Speak**](speak-method) メソッドと **Think** メソッドの両方の出力に影響します。 たとえば、テキストを表示するには、**Balloon** オブジェクトの [**Enabled**](enabled-property) プロパティを true  する必要があります。

オブジェクト参照を宣言してこのメソッドに設定すると、[**Request**](/ja-jp/windows/desktop/lwef/the-request-object) オブジェクトが返されます。 さらに、ファイルが読み込まれていない場合、サーバーは、**Request** オブジェクトの [**Status**](status-property) プロパティを適切なエラー コード番号で "failed" に設定します。

吹き出し内のエージェントの自動単語区切りは、空白文字 (スペースや Tab など) を使用して単語を区切ります。 ただし、できない場合は、吹き出しに合わせて単語を分割することがあります。 日本語、中国語、タイ語などの言語で、単語を区切るためにスペースを使用しない場合は、文字間に Unicode のゼロ幅スペース文字 (0x200B) を挿入して、論理的な単語区切りを定義します。

手記

[**Speak**](speak-method) メソッドを使用する前に、文字の言語 ID を設定して、単語吹き出し内に適切なテキストが表示されるようにします。