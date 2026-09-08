---
layout: Conceptual
title: FontCharSet プロパティ - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/fontcharset-property
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: FontCharSet プロパティ
document_id: 9fabd712-6fa6-24a1-2052-a52fe27a9651
document_version_independent_id: 3d836ad2-e0b4-18a0-3d2b-f751eece1d39
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/fontcharset-property.md
locale: ja-jp
ms.assetid: 2f23a242-d620-4766-8f59-cf158aa55969
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/fontcharset-property.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:42:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/fontcharset-property.md
page_type: conceptual
toc_rel: toc.json
word_count: 685
asset_id: lwef/fontcharset-property
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: f792038d-bf6c-31d9-690a-550573f7edfd
---

# FontCharSet プロパティ - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 指定した文字のワード バルーンに表示されるフォントの文字セットを設定または返します。
- **構文の**
    - エージェント \*\* です。characters ("***CharacterID***")。Balloon.FontCharSet\*\* [ = *value*]

| 部分 | 形容 |
| --- | --- |
| *値の* | フォントで使用される文字セットを指定する整数値。 値の一般的な設定を次に示します。0 標準 Windows 文字 (ANSI)。 1 既定の文字セット。 2 シンボル文字セット。 128 日本語バージョンの Windows に固有の 2 バイト文字セット (DBCS)。 韓国語バージョンの Windows に固有の 129 2 バイト文字セット (DBCS)。 Windows の簡体字中国語バージョンに固有の 134 2 バイト文字セット (DBCS)。 136 Windows の繁体字中国語バージョンに固有の 136 2 バイト文字セット (DBCS)。 通常、Microsoft MS-DOS アプリケーションによって表示される 255 文字の拡張文字。 その他の文字セット値については、Platform SDK のドキュメントを参照してください。 |

## 備考

文字のワード バルーンの文字セットの既定値は、Microsoft エージェント文字エディターで設定されます。 さらに、ユーザーは、Microsoft Agent プロパティ シート内のすべての文字の文字セット設定をオーバーライドできます。

このプロパティは、クライアント アプリケーションによる文字の使用にのみ適用されます。この設定は、文字の他のクライアントやクライアント アプリケーションの他の文字には影響しません。

手記

コンパイルしていない文字を使用している場合は、[**FontName**](fontname-property) を確認し、文字の FontCharSet **プロパティを** して、ロケールに適しているかどうかを判断します。 吹き出し内に適切なテキストが表示されるようにするには、[**Speak**](speak-method) メソッドを使用する前に、これらの値を設定する必要がある場合があります。