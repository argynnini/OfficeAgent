---
layout: Conceptual
title: バルーン オブジェクト - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/the-balloon-object
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: バルーン オブジェクト
document_id: d02539ec-dac1-4bbe-4967-d08e0adf7a83
document_version_independent_id: fed15457-1fac-13fb-2086-d503a313cb90
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/the-balloon-object.md
locale: ja-jp
ms.assetid: d5b52310-0b4e-4fe3-a481-53687be4a89c
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/the-balloon-object.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:02:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/the-balloon-object.md
page_type: conceptual
toc_rel: toc.json
word_count: 432
asset_id: lwef/the-balloon-object
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: e68ca1db-9982-d17e-6627-27625becb612
---

# バルーン オブジェクト - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

Microsoft Agent では、漫画の単語吹き出しを使用した [**Speak**](speak-method) メソッドのテキストキャプションがサポートされています。 [**Think**](think-method) メソッドを使用すると、"thought" ワード バルーンにオーディオ出力なしでテキストを表示できます。

文字の最初の吹き出しウィンドウの既定値は、Microsoft エージェント文字エディターで定義およびコンパイルされます。 実行すると、バルーンの [**Enabled**](enabled-property) プロパティと [**Font**](https://www.bing.com/search?q=**Font**) プロパティがユーザーによってオーバーライドされる場合があります。 ユーザーが吹き出しという単語のプロパティを変更すると、すべての文字に影響します。 吹き出しの [**読み上げ**](speak-method) と [**考え方**](think-method) の両方で、サイズに同じプロパティ設定が使用されます。 [**Character**](/ja-jp/windows/desktop/lwef/the-characters-object) オブジェクトの子である [**Balloon**](/ja-jp/windows/desktop/lwef/the-balloon-object) オブジェクトを使用して、文字のワード バルーンのプロパティにアクセスできます。

[**Balloon**](/ja-jp/windows/desktop/lwef/the-balloon-object) オブジェクトは、次のプロパティをサポートしています。

- [**Backcolor**](backcolor-property)
- [**BorderColor**](bordercolor-property)
- [**CharsPerLine**](charsperline-property)
- [**Enabled**](enabled-property)
- [**FontCharSet**](fontcharset-property)
- [**FontName**](fontname-property-bal)
- [**フォント太字**](fontbold-property)
- [**フォント斜体**](fontitalic-property)
- [**Fontsize**](fontsize-property-bal)
- [**FontStrikeThru**](fontstrikethru-property)
- [**フォント下線**](fontunderline-property)
- [**Forecolor**](forecolor-property)
- [**NumberOfLines**](numberoflines-property)
- [**スタイル**](style-property)
- [**\[表示\]**](visible-property-bal)