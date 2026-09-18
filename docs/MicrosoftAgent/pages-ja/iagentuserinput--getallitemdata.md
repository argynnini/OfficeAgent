---
layout: Conceptual
title: IAgentUserInput GetAllItemData - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentuserinput--getallitemdata
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentUserInput GetAllItemData
document_id: c72e5c62-9f67-2f36-85d1-528416042233
document_version_independent_id: fe3dc598-d89c-e9cd-684a-9d95b97ca303
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentuserinput--getallitemdata.md
locale: ja-jp
ms.assetid: d1857b28-c745-4ed2-b49e-774f247e7348
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentuserinput--getallitemdata.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:53:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentuserinput--getallitemdata.md
page_type: conceptual
toc_rel: toc.json
word_count: 720
asset_id: lwef/iagentuserinput--getallitemdata
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 9ccfe187-ba57-eb6d-bc6c-f75b0ab54c0e
---

# IAgentUserInput GetAllItemData - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT GetAllItemData(
   VARIANT * pdwItemIndices,  // address of variable for alternative IDs
   VARIANT * plConfidences,   // address of variable for confidence scores
   VARIANT * pbszText         // address of variable for voice text
);
```

[**IAgentNotifySink::Command**](iagentnotifysink--command) コールバックに渡されるすべての [**Command**](command-event) の代替手段のデータを取得します。

- 操作が成功したことを示すS\_OKを返します。

- pdwItemIndices*を * する
    - [**IAgentNotifySink::Command**](iagentnotifysink--command) コールバックに渡コマンドの ID を受け取る変数のアドレス。
- plConfidences*を * する
    - [**IAgentNotifySink::Command**](iagentnotifysink--command) コールバックに渡される代替Command の信頼度スコアを受け取る変数のアドレス。
- pbszText*の *
    - [**IAgentNotifySink::Command**](iagentnotifysink--command) コールバックに渡される代替Command の音声テキストを受け取る変数のアドレス。

音声入力が IAgentNotifySink::Commandトリガーされる場合、サーバーは、最適な一致、2 番目に一致する一致、および 3 番目に最適な一致 (音声エンジンによって提供される場合) を返します。 これは、-100 から 100 までの範囲の相対的な信頼度スコアと、音声エンジンによって実際に "聞こえました" テキストを提供します。 最適な一致がサーバー指定のコマンドである場合、サーバーは NULL ID を送信しますが、信頼度スコアと [**音声**](voice-property) テキストを送信します。

音声入力がイベントのソースではない場合。たとえば、ユーザーがキャラクターのポップアップ メニューからコマンドを選択した場合、Microsoft エージェント サーバーは、選択した [**コマンド**](command-event) の ID を返します。信頼度スコアは 100 で、音声テキストは NULL になります。 他の代替手段では、信頼度スコアが 0 (0) で、音声テキストが NULL として NULL として返されます。

手記

すべての音声認識エンジンがこのイベントのすべてのパラメーターのすべての値を返すわけではありません。 エンジンベンダーに問い合わせて、エンジンが代替手段と信頼度スコアを返すために Microsoft Speech API インターフェイスをサポートしているかどうかを確認してください。