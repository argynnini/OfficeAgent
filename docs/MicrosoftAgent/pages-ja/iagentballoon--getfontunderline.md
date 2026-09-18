---
layout: Conceptual
title: IAgentBalloon GetFontUnderline - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentballoon--getfontunderline
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentBalloon GetFontUnderline
document_id: 8c6afe5d-ae00-cca9-c210-f59bf7e169e5
document_version_independent_id: 3d1e68dd-fe41-535a-5ef0-6c8e956e2ce4
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentballoon--getfontunderline.md
locale: ja-jp
ms.assetid: 19886e94-8095-4650-bd88-34ea9d96ddaa
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentballoon--getfontunderline.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:45:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentballoon--getfontunderline.md
page_type: conceptual
toc_rel: toc.json
word_count: 301
asset_id: lwef/iagentballoon--getfontunderline
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 14208f42-2812-6403-22ac-1823ca3ebf6a
---

# IAgentBalloon GetFontUnderline - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT GetFontUnderline(
   long * pbFontUnderline  // address of variable for underline setting
);                         // for font displayed in word balloon 
```

単語吹き出しで使用されるフォントに下線スタイルが設定されているかどうかを示します。

- 操作が成功したことを示すS\_OKを返します。

- pbFontUnderline*を * する
    - **True を受け取る値のアドレスは、フォントの下線のスタイルが設定されている場合は**、それ以外の場合は false 。

文字ワード バルーンで使用されるフォント スタイルは、Microsoft エージェント文字エディターで定義されます。 アプリケーションで変更することはできません。 ただし、ユーザーは Microsoft Agent プロパティ シートを使用して、すべての文字のフォント設定をオーバーライドできます。