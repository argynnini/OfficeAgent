---
layout: Conceptual
title: IAgentCharacter GetSize - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcharacter--getsize
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCharacter GetSize
document_id: 039c808e-ac00-1c8a-3567-13769e72b2ac
document_version_independent_id: 559cac72-d8e0-2b24-b6f5-7d8b13e2cdcc
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacter--getsize.md
locale: ja-jp
ms.assetid: bc2d6fe4-5945-4a35-b603-409c66f8aa2a
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacter--getsize.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:46:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcharacter--getsize.md
page_type: conceptual
toc_rel: toc.json
word_count: 283
asset_id: lwef/iagentcharacter--getsize
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 9488df27-d5f7-ad23-7fa5-aa0cfb2f1d72
---

# IAgentCharacter GetSize - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT GetSize(
   long * plWidth,  // address of variable for character width 
   long * plHeight  // address of variable for character height
);
```

キャラクターのアニメーション フレームのサイズを取得します。

- 操作が成功したことを示すS\_OKを返します。

- plWidth*を * する
    - 画面の原点 (左上) を基準に、文字アニメーション フレームの幅をピクセル単位で受け取る変数のアドレス。
- *plHeight*
    - 画面の原点 (左上) を基準に、文字アニメーション フレームの高さをピクセル単位で受け取る変数のアドレス。

不規則な形状の領域ウィンドウに文字が表示される場合でも、文字の位置は四角形のアニメーション フレームに基づいています。