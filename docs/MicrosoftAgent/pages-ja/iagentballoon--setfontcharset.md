---
layout: Conceptual
title: IAgentBalloon SetFontCharSet - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentballoon--setfontcharset
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentBalloon SetFontCharSet
document_id: 2f160ebf-e9ef-c2b8-d8ab-f2bed8d2b713
document_version_independent_id: fe167d97-a4e7-2e0f-c592-0a5d25a28751
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentballoon--setfontcharset.md
locale: ja-jp
ms.assetid: ce1b152d-c8af-47ec-9e6b-5768dbcf3566
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentballoon--setfontcharset.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:45:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentballoon--setfontcharset.md
page_type: conceptual
toc_rel: toc.json
word_count: 551
asset_id: lwef/iagentballoon--setfontcharset
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 0c47753c-8ca0-81fa-05ff-33d5ec4c6956
---

# IAgentBalloon SetFontCharSet - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT SetFontCharSet(
   short sFontCharSet  // character set displayed in word balloon
); 
```

吹き出しという単語に表示されるフォントの文字セットを設定します。

- 操作が成功したことを示すS\_OKを返します。

- *sFontCharSet*
    - フォントの文字セット。 値の一般的な設定を次に示します。

| 価値 | 文字セット |
| --- | --- |
| 0 | 標準の Windows 文字 (ANSI)。 |
| 1 | 既定の文字セット。 |
| 2 | シンボル文字セット。 |
| 128 | 日本語バージョンの Windows に固有の 2 バイト文字セット (DBCS)。 |
| 129 | 韓国語バージョンの Windows に固有の 2 バイト文字セット (DBCS)。 |
| 134 | Windows の簡体字中国語バージョンに固有の 2 バイト文字セット (DBCS)。 |
| 136 | 繁体字中国語バージョンの Windows に固有の 2 バイト文字セット (DBCS)。 |
| 255 | 通常、MS-DOS アプリケーションによって表示される拡張文字。 |

その他の文字セット値については、Platform SDK のドキュメントを参照してください。

文字のワード バルーンで使用される既定の文字セットは、Microsoft エージェント文字エディターで定義されます。 IAgentBalloon::SetFontCharSetで変更できます。 ただし、ユーザーは Microsoft Agent プロパティ シートを使用して、すべての文字の文字セット設定をオーバーライドできます。 このプロパティは、クライアント アプリケーションによる文字の使用にのみ適用されます。この設定は、文字の他のクライアントやクライアント アプリケーションの他の文字には影響しません。