---
layout: Conceptual
title: IAgentCharacter SetSize - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcharacter--setsize
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCharacter SetSize
document_id: 67773503-0e2b-30aa-3120-75fc86ef5627
document_version_independent_id: 2a2acf06-56ff-2c94-6b0a-b8f5f131420e
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacter--setsize.md
locale: ja-jp
ms.assetid: 8324ab84-2b59-4459-b375-700d72b621bc
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacter--setsize.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:47:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcharacter--setsize.md
page_type: conceptual
toc_rel: toc.json
word_count: 320
asset_id: lwef/iagentcharacter--setsize
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 19325acf-c93b-4ceb-a77a-c884efd6fc50
---

# IAgentCharacter SetSize - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT SetSize(
   long * lWidth,  // width of the character frame
   long * lHeight  // height of the character frame
);
```

キャラクターのアニメーション フレームのサイズを設定します。

- 操作が成功したことを示すS\_OKを返します。

- *lWidth*
    - キャラクターのアニメーション フレームの幅 (ピクセル単位)。
- *lHeight*
    - キャラクターのアニメーション フレームの高さ (ピクセル単位)。

文字のフレーム サイズを変更すると、このメソッドを使用して文字がサイズ セットにスケーリングされます。 このプロパティの設定は、文字のすべてのクライアントに適用されます。

不規則な形状の領域ウィンドウに文字が表示される場合でも、文字の位置は四角形のアニメーション フレームに基づいています。