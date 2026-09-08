---
layout: Conceptual
title: IAgentCharacterEx GetOriginalSize - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcharacterex--getoriginalsize
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCharacterEx GetOriginalSize
document_id: 23aa4009-9909-a6f7-6d0c-121792c6cac8
document_version_independent_id: 3c1ab948-7e6f-f5b8-505b-e8c2e4934297
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacterex--getoriginalsize.md
locale: ja-jp
ms.assetid: a27ae88f-3655-4375-b563-0cc320d012cb
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacterex--getoriginalsize.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:48:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcharacterex--getoriginalsize.md
page_type: conceptual
toc_rel: toc.json
word_count: 246
asset_id: lwef/iagentcharacterex--getoriginalsize
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 2f2dbf3c-3a1b-b677-126c-64421c04192c
---

# IAgentCharacterEx GetOriginalSize - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT GetOriginalSize(
   long * plWidth,  // address of variable for character width 
   long * plHeight  // address of variable for character height
);
```

キャラクターのアニメーション フレームの元のサイズを取得します。

- 操作が成功したことを示すS\_OKを返します。

- plWidth*を * する
    - 文字アニメーション フレームの元の幅をピクセル単位で受け取る変数のアドレス。
- *plHeight*
    - 文字アニメーション フレームの元の高さをピクセル単位で受け取る変数のアドレス。

この呼び出しは、Microsoft Agent Character Editor に組み込まれている文字フレームの元のサイズを返します。