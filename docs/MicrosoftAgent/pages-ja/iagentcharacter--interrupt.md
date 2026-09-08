---
layout: Conceptual
title: IAgentCharacter 割り込み - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcharacter--interrupt
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCharacter 割り込み
document_id: fa290ceb-7901-f7c5-346b-9575cf1cf5b4
document_version_independent_id: 1cf2eba5-f074-95e9-71e5-7a8ece8cfd98
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacter--interrupt.md
locale: ja-jp
ms.assetid: ae05d317-e2d9-4d11-a6df-f9b25e43467a
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacter--interrupt.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:46:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcharacter--interrupt.md
page_type: conceptual
toc_rel: toc.json
word_count: 542
asset_id: lwef/iagentcharacter--interrupt
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 5903c8d6-1a95-f9a1-a2f1-84f213906d35
---

# IAgentCharacter 割り込み - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT Interrupt(
   long dwReqID,    // request ID to interrupt
   long * pdwReqID  // address of request ID
);
```

別の文字の指定したアニメーション (要求) を中断します。

- 操作が成功したことを示すS\_OKを返します。 関数から制御が戻ると、pdwReqID  要求の ID が格納されます。

- dwReqID*を * する
    - 割り込む要求の ID。
- pdwReqID*を * する
    - **割り込み** 要求 ID を受け取る変数のアドレス。

複数の文字を読み込む場合は、このメソッドを使用して、文字間でアニメーションを同期できます。 たとえば、別の文字がループ アニメーション内にある場合、このメソッドはループ アニメーションを停止し、キャラクターのキューで次のアニメーションを開始します。

**割り込み** は既存のアニメーションを停止しますが、キャラクターのアニメーション キューはフラッシュしません。 キャラクターのキューで次のアニメーションが開始されます。 文字のキューを停止してフラッシュするには、[**Stop**](/ja-jp/windows/desktop/lwef/iagentcharacter--stop) メソッドを使用します。

このメソッドを使用して文字割り込み自体を行うことはできません。これは、Microsoft エージェント サーバーがキャラクターのアニメーション キューに **割り込み** メソッドをキューに入れるからです。 そのため、**割り込み** を使用して、読み込んだ別のキャラクターのアニメーションを停止することしかできません。