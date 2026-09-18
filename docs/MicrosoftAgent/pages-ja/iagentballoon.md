---
layout: Conceptual
title: IAgentBalloon - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentballoon
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentBalloon
document_id: 8826ff92-6545-a490-5cd3-d7605ffa6035
document_version_independent_id: bf1c81fb-ee45-f772-7942-cfb20248caef
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentballoon.md
locale: ja-jp
ms.assetid: 94a48cd9-bea5-4993-8991-50c6c86a646b
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentballoon.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:45:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentballoon.md
page_type: conceptual
toc_rel: toc.json
word_count: 831
asset_id: lwef/iagentballoon
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 8286a42e-b47c-f206-f481-7a955893e946
---

# IAgentBalloon - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

**IAgentBalloon** は、アプリケーションが Microsoft Agent ワード バルーンのプロパティを照会できるようにするインターフェイスを定義します。 これらの関数は、[**IAgentBalloonEx**](https://www.bing.com/search?q=**IAgentBalloonEx**)からも使用できます。

文字の吹き出しの初期既定値は Microsoft エージェント文字エディターで設定されますが、アプリケーションを実行すると、ユーザーは [**Enabled**](enabled-property) プロパティと [Font](fontname-property) プロパティをオーバーライドできます。 ユーザーがバルーンのプロパティを変更すると、変更はすべての文字に影響します。 [**IAgentBalloon**](/ja-jp/windows/desktop/lwef/iagentballoon) オブジェクトのプロパティは、[**Think**](think-method) メソッドを使用したテキスト出力にも適用されます。

Vtable Order **のメソッドを** する

| IAgentBalloon メソッド | 形容 |
| --- | --- |
| GetEnabled [の](iagentballoon--getenabled) | 吹き出しという単語が有効かどうかを返します。 |
| GetNumLines [の](iagentballoon--getnumlines) | 吹き出しという単語に表示される行数を返します。 |
| GetNumCharsPerLine [を](iagentballoon--getnumcharsperline) する | 吹き出しという単語に表示される 1 行あたりの平均文字数を返します。 |
| GetFontName [を](iagentballoon--getfontname) する | 吹き出しという単語に表示されるフォントの名前を返します。 |
| [GetFontSize](iagentballoon--getfontsize) | 吹き出しという単語に表示されるフォントのサイズを返します。 |
| GetFontBold [を](iagentballoon--getfontbold) する | 吹き出しという単語に表示されるフォントが太字かどうかを返します。 |
| GetFontItalic [を](iagentballoon--getfontitalic) する | 吹き出しという単語に表示されるフォントが斜体かどうかを返します。 |
| GetFontStrikethru [の](iagentballoon--getfontstrikethru) | 吹き出しに表示されるフォントを取り消し線として表示するかどうかを返します。 |
| GetFontUnderline [を](iagentballoon--getfontunderline) する | 吹き出しという単語に表示されるフォントに下線を引くかどうかを返します。 |
| GetForeColor [の](iagentballoon--getforecolor) | 吹き出しという単語に表示される前景色を返します。 |
| GetBackColor [の](iagentballoon--getbackcolor) | 吹き出しという単語に表示される背景色を返します。 |
| GetBorderColor [の](iagentballoon--getbordercolor) | 吹き出しという単語に表示される境界線の色を返します。 |
| SetVisible [の](iagentballoon--setvisible) | 吹き出しを表示するように設定します。 |
| GetVisible [の](iagentballoon--getvisible) | 吹き出しという単語の表示設定を返します。 |
| [SetFontName](iagentballoon--setfontname) | 吹き出しという単語で使用するフォントを設定します。 |
| SetFontSize [の](iagentballoon--setfontsize) | ワード バルーンで使用するフォント サイズを設定します。 |
| SetFontCharSet [の](iagentballoon--setfontcharset) | ワード バルーンで使用される文字セットを設定します。 |
| GetFontCharSet [を](iagentballoon--getfontcharset) する | 吹き出しという単語で使用される文字セットを返します。 |