---
layout: Conceptual
title: IAgentUserInput GetItemText - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentuserinput--getitemtext
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentUserInput GetItemText
document_id: aa6943bf-c915-e56e-c848-63c6fd01e6d5
document_version_independent_id: 50dd9b61-e8ea-0ee8-569d-8112949cbef5
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentuserinput--getitemtext.md
locale: ja-jp
ms.assetid: 69653806-c001-4015-bd05-3c261a312ede
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentuserinput--getitemtext.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:53:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentuserinput--getitemtext.md
page_type: conceptual
toc_rel: toc.json
word_count: 276
asset_id: lwef/iagentuserinput--getitemtext
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: dca8e8d8-13e6-0b7f-48a8-642e3320fb24
---

# IAgentUserInput GetItemText - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT GetItemText(
   Long dwItemIndex,  // index of Command alternative
   BSTR * pbszText    // address of voice text for Command 
);
```

[**IAgentNotifySink::Command**](iagentnotifysink--command) コールバックに渡される、[**コマンド**](command-event) 代替の音声テキストを取得します。

- 操作が成功したことを示すS\_OKを返します。

- dwItemIndex*を * する
    - [**コマンドのインデックス**](command-event)、[**IAgentNotifySink::Command**](iagentnotifysink--command) コールバックに渡される代替値です。
- pbszText*の *
    - [**コマンド**](command-event)の音声テキストの値を受け取る BSTR のアドレス。

音声入力がコマンドのソースではない場合 (たとえば、ユーザーがキャラクターのポップアップ メニューからコマンドを選択した場合)、サーバーは、[**コマンド**](command-event)の音声テキストに対して null  返します。