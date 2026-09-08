---
layout: Conceptual
title: IAgentCharacter GetPosition - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcharacter--getposition
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCharacter GetPosition
document_id: 52dc083c-f741-5601-b755-5a7e613f05d4
document_version_independent_id: fd82df7a-a061-8a8f-3746-3982377b894b
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacter--getposition.md
locale: ja-jp
ms.assetid: 79343337-2700-48cb-a09d-1a356ea560e0
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacter--getposition.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:46:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcharacter--getposition.md
page_type: conceptual
toc_rel: toc.json
word_count: 300
asset_id: lwef/iagentcharacter--getposition
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 48ed55c5-cd2d-ff86-9954-c3f4d099d22f
---

# IAgentCharacter GetPosition - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT GetPosition(
   long * plLeft,  // address of variable for left edge of character 
   long * plTop    // address of variable for top edge of character 
);
```

キャラクターのアニメーション フレーム位置を取得します。

- 操作が成功したことを示すS\_OKを返します。

- plLeft*を * する
    - 画面の原点 (左上) を基準に、文字アニメーション フレームの左端の画面座標をピクセル単位で受け取る変数のアドレス。
- plTop*を * する
    - 画面の原点 (左上) を基準に、文字アニメーション フレームの上端の画面座標をピクセル単位で受け取る変数のアドレス。

不規則な形状の領域ウィンドウに文字が表示される場合でも、文字の位置は四角形のアニメーション フレームに基づいています。