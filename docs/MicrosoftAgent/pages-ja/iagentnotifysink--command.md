---
layout: Conceptual
title: IAgentNotifySink コマンド - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentnotifysink--command
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentNotifySink コマンド
document_id: acadc072-1a77-cbb3-c4f9-09db64d28c1a
document_version_independent_id: bd6f6992-5fb1-317d-88a3-90c0a7ae331e
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentnotifysink--command.md
locale: ja-jp
ms.assetid: d54fb2e8-27d6-47a4-8a1e-5419a94ea26d
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentnotifysink--command.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:52:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentnotifysink--command.md
page_type: conceptual
toc_rel: toc.json
word_count: 370
asset_id: lwef/iagentnotifysink--command
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: a27af99f-3cef-5f99-da02-e3721e9ac9e7
---

# IAgentNotifySink コマンド - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT Command(
   long dwCommandID,         // Command ID of the best match
   IUnknown * punkUserInput  // address of IAgentUserInput object 
);                          
```

[**コマンド**](/ja-jp/windows/desktop/lwef/the-command-object) がユーザーによって選択されたことをクライアント アプリケーションに通知します。

- 戻り値はありません。

- dwCommandID*の *
    - 最適な一致コマンドの代替の識別子。
- punkUserInput*を * する
    - [**IAgentUserInput**](iagentuserinput) オブジェクトの [**IUnknown**](/ja-jp/windows/desktop/api/unknwn/nn-unknwn-iunknown) インターフェイスのアドレス。

[**QueryInterface**](/ja-jp/windows/desktop/api/unknwn/nf-unknwn-iunknown-queryinterface%28q%29) を使用して、[**IAgentUserInput**](iagentuserinput) インターフェイスを取得します。

ユーザーが音声またはキャラクターのポップアップ メニューからコマンドを選択してコマンドを選択すると、サーバーは入力アクティブ クライアントに通知します。 イベントは、ユーザーがサーバーのいずれかのコマンドを選択した場合でも発生します。 この場合、サーバーは null コマンド ID、信頼度スコア、およびそのエントリの音声エンジンによって返される音声テキストを返します。