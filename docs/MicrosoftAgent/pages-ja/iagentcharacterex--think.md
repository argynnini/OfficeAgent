---
layout: Conceptual
title: IAgentCharacterEx Think - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcharacterex--think
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCharacterEx Think
document_id: c51254af-3d32-bc98-8025-f628d9af7e0d
document_version_independent_id: 46e2aae8-e1e6-450e-b7a1-e4a7cef017d8
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacterex--think.md
locale: ja-jp
ms.assetid: 64bfa388-0db7-423c-a4af-64a9f7351e9a
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacterex--think.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:48:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcharacterex--think.md
page_type: conceptual
toc_rel: toc.json
word_count: 611
asset_id: lwef/iagentcharacterex--think
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: fb3d377d-4f56-0229-2887-7cd8924ce98d
---

# IAgentCharacterEx Think - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT Think(
   BSTR bszText,    // text to think
   long * pdwReqID  // address of a request ID
);
```

指定したテキストを含む文字の思考ワード バルーンを表示します。

- 操作が成功したことを示すS\_OKを返します。

- *bszText*
    - キャラクターの思考吹き出しに表示されるテキスト。
- pdwReqID*を * する
    - **Think** 要求 ID を受け取る変数のアドレス。

[**IAgentCharacter::Speak**](iagentcharacter--speak) メソッドと同様に、**Think** メソッドは、特別な思考吹き出しに思考が表示されることを除き、単語吹き出しにテキストを表示するキューに登録された要求です。 この吹き出しでは、Bookmark 音声コントロール タグ (**\Mrk**) のみがサポートされ、他の音声コントロール タグは無視されます。 IAgentCharacter::Speak とは異なり、**Think** メソッドはキャラクターのアニメーション状態を変更しません。

[**IAgentBalloon**](/ja-jp/windows/desktop/lwef/iagentballoon) 設定は、思考吹き出しの外観スタイルにも適用されます。 たとえば、吹き出しの [**Enabled**](enabled-property) プロパティも、テキストを表示するために true  する必要があります。

吹き出し内の Microsoft Agent の自動単語区切り文字は、空白文字 (スペースやタブなど) を使用して単語を区切ります。 ただし、吹き出しに合わせて単語を区切る場合もあります。 日本語、中国語、タイ語などの言語では、単語を区切るためにスペースが使用されない場合は、文字間に Unicode ゼロ幅の空白文字 (0x200B) を挿入して、論理的な単語区切りを定義します。

手記

[**IAgentCharacter::Speak**](iagentcharacter--speak) メソッドを使用する前に、文字の言語 ID ([**IAgentCharacterEx::SetLanguageID**](iagentcharacterex--setlanguageid) を使用) を設定して、単語吹き出し内に適切なテキストが表示されるようにします。