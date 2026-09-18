---
layout: Conceptual
title: IAgentCharacter Wait - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcharacter--wait
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCharacter Wait
document_id: 48de3a8a-f8da-8294-f338-efde316bd5c9
document_version_independent_id: f2eff3d6-1acc-b146-d475-bf26f9a51bb7
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacter--wait.md
locale: ja-jp
ms.assetid: 4edb9a47-9385-49da-83ff-144780853ae7
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacter--wait.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:47:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcharacter--wait.md
page_type: conceptual
toc_rel: toc.json
word_count: 349
asset_id: lwef/iagentcharacter--wait
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 65e075a1-fe86-3f28-5e3b-62d59be5acdd
---

# IAgentCharacter Wait - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT Wait(
   long dwReqID,    // request ID
   long * pdwReqID  // address of request ID
);
```

別の文字に対する別の要求が完了するまで、指定したアニメーション (要求) でキャラクターのアニメーション キューを保持します。

- 操作が成功したことを示すS\_OKを返します。

- dwReqID*を * する
    - 待機する要求の ID。
- pdwReqID*を * する
    - **Wait** 要求 ID を受け取る変数のアドレス。

このメソッドは、複数の (同時) 文字をサポートし、それらの対話をシーケンスする場合にのみ使用します。 (1 文字の場合、各アニメーション要求は、前の要求が完了した後に順番に再生されます)。2 つの文字があり、一方の文字のアニメーション要求でもう一方の文字のアニメーションが完了するまで待機する場合は、**Wait** メソッドをもう一方の文字のアニメーション要求 ID に設定します。