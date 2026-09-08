---
layout: Conceptual
title: IAgentCharacter MoveTo - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcharacter--moveto
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCharacter MoveTo
document_id: 07f423b0-f3e9-5749-b7ba-9c17cbe6e373
document_version_independent_id: a4c9a671-7c6a-a937-619d-0bca84473aee
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacter--moveto.md
locale: ja-jp
ms.assetid: 4e24d2f8-1df2-47ca-a1e9-b9d29708207d
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacter--moveto.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:47:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcharacter--moveto.md
page_type: conceptual
toc_rel: toc.json
word_count: 518
asset_id: lwef/iagentcharacter--moveto
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: b4f7fbc1-8ab3-f413-5a1e-ea080c7e5d87
---

# IAgentCharacter MoveTo - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT MoveTo(
   short x,         // x-coordinate of new location
   short y,         // y-coordinate of new location
   long lSpeed,     // speed to move the character
   long * pdwReqID  // address of request ID
);
```

関連付けられた **移動** 状態アニメーションを再生し、文字フレームを指定した位置に移動します。

- 操作が成功したことを示すS\_OKを返します。 関数から制御が戻るときに、この変数には要求の ID が含まれます。

- *x*
    - 画面の原点 (左上) を基準とした、新しい位置の x 座標 (ピクセル単位)。 文字の位置は、アニメーション フレームの左上隅に基づいています。
- *y*
    - 画面の原点 (左上) を基準とした、新しい位置の y 座標 (ピクセル単位)。 文字の位置は、アニメーション フレームの左上隅に基づいています。
- *lSpeed*
    - 文字のフレームの移動速度をミリ秒単位で指定するパラメーター。 推奨値は 1000 です。 ゼロ (0) を指定すると、アニメーションを再生せずにフレームが移動します。
- pdwReqID*を * する
    - [**MoveTo**](https://www.bing.com/search?q=**MoveTo**) 要求 ID を受け取る変数のアドレス。

HTTP プロトコルを使用して文字とアニメーションのデータにアクセスする場合は、[**Prepare**](/ja-jp/windows/desktop/lwef/iagentcharacter--prepare) メソッドを使用して、このメソッドを呼び出す前に **Moving** 状態アニメーションを使用できるようにします。 アニメーションが読み込まれていない場合でも、サーバーはフレームを移動します。