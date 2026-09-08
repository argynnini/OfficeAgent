---
layout: Conceptual
title: FontName プロパティ (Balloon オブジェクト) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/fontname-property-bal
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: FontName Balloon オブジェクト プロパティについて説明します。 Microsoft エージェントは、Windows 7 の時点で非推奨です。
document_id: f020f9e5-594c-f78a-ada2-64c761f3ae42
document_version_independent_id: b455a6f2-bb49-70c0-05bf-3ea8a1dfb980
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/fontname-property-bal.md
locale: ja-jp
ms.assetid: a84a19a4-9e0e-4736-b401-286e6618bc19
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/fontname-property-bal.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:42:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/fontname-property-bal.md
page_type: conceptual
toc_rel: toc.json
word_count: 479
asset_id: lwef/fontname-property-bal
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 438d7834-d692-eebb-788f-1c1ac5dce474
---

# FontName プロパティ (Balloon オブジェクト) - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 指定した文字の吹き出しに使用するフォントを設定または返します。
- **構文の**
    - \*agent.\***Characters("*CharacterID*")。Balloon.FontName** [ = *font*]

| 部分 | 形容 |
| --- | --- |
| フォント *を* する | フォントの名前に対応する文字列値。 |

## 備考

[**FontName**](fontname-property) プロパティは、文字列の吹き出しウィンドウにテキストを表示するために使用するフォントを定義します。 文字の吹き出しのフォント設定の既定値は、Microsoft エージェント文字エディターで設定されます。 さらに、ユーザーは Microsoft Agent プロパティ シート内のすべての文字のフォント設定をオーバーライドできます。

このプロパティは、クライアント アプリケーションによる文字の使用にのみ適用されます。この設定は、文字の他のクライアントやクライアント アプリケーションの他の文字には影響しません。

手記

コンパイルしていない文字を使用している場合は、[**FontName**](fontname-property) を確認し、文字の FontCharSet**[プロパティを](fontcharset-property)**して、ロケールに適しているかどうかを判断します。 吹き出し内に適切なテキストが表示されるようにするには、[**Speak**](speak-method) メソッドを使用する前に、これらの値を設定する必要がある場合があります。