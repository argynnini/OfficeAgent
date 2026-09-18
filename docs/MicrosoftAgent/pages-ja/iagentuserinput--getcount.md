---
layout: Conceptual
title: IAgentUserInput GetCount - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentuserinput--getcount
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentUserInput GetCount
document_id: 1a3ffc44-db60-6f14-360a-4d6e1970a82f
document_version_independent_id: ebaa8cf5-968c-d2c3-85d2-fa9b4e72ddf4
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentuserinput--getcount.md
locale: ja-jp
ms.assetid: 9c127387-b680-405a-9a62-ee08cc70813a
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentuserinput--getcount.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:53:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentuserinput--getcount.md
page_type: conceptual
toc_rel: toc.json
word_count: 276
asset_id: lwef/iagentuserinput--getcount
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 0fd21532-5990-8a0f-0239-7c538878fad6
---

# IAgentUserInput GetCount - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT GetCount(
   long * pdwCount  // address of a variable for number of alternatives 
);
```

[**IAgentNotifySink::Command**](iagentnotifysink--command) コールバックに渡される [**コマンド**](command-event) の代替手段の数を取得します。

- 操作が成功したことを示すS\_OKを返します。

- pdwCount*を * する
    - [**コマンドの数を受け取る変数のアドレス**](command-event)、サーバーによって識別される代替手段です。

音声入力がコマンドのソースではない場合 (たとえば、ユーザーがキャラクターのポップアップ メニューからコマンドを選択した場合)、GetCount  1 が返されます。 GetCount  0 が返された場合、音声認識エンジンは音声入力を検出しましたが、一致するコマンドがないと判断しました。