---
layout: Conceptual
title: IAgentCharacterEx GetHelpModeOn - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcharacterex--gethelpmodeon
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCharacterEx GetHelpModeOn
document_id: 4955310a-49b6-4778-77b4-e4615a246728
document_version_independent_id: d2a2ee19-fe2e-e835-c755-9f924663fefa
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacterex--gethelpmodeon.md
locale: ja-jp
ms.assetid: 848c9e75-6e4c-487c-b01c-36ec6314d0c1
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacterex--gethelpmodeon.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:48:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcharacterex--gethelpmodeon.md
page_type: conceptual
toc_rel: toc.json
word_count: 534
asset_id: lwef/iagentcharacterex--gethelpmodeon
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 1b7a940b-7313-9d23-6ea1-6255ce28e1d0
---

# IAgentCharacterEx GetHelpModeOn - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT GetHelpModeOn(
   long * pbHelpModeOn  // address of help mode setting
);
```

コンテキスト依存のヘルプ モードが文字に対してオンになっているかどうかを取得します。

- 操作が成功したことを示すS\_OKを返します。

- pbHelpModeOn*を * する
    - 文字に対してヘルプ モードがオンの場合は **True** を受け取り、そうでない場合は false  変数のアドレス。

このプロパティを **True**に設定すると、マウス ポインターは、文字の上または文字のポップアップ メニューの上に移動すると、状況依存のヘルプ イメージに変わります。 ユーザーが文字をクリックまたはドラッグするか、文字のポップアップ メニュー内の項目をクリックすると、サーバーは [**IAgentNotifySinkEx::HelpComplete**](https://www.bing.com/search?q=**IAgentNotifySinkEx::HelpComplete**) イベントをトリガーし、ヘルプ モードを終了します。

ヘルプ モードでは、サーバーは [**IAgentNotifySink::Click**](iagentnotifysink--click)、[**IAgentNotifySink::D ragStart**](iagentnotifysink--dragstart)、[**IAgentNotifySink::D ragComplete**](iagentnotifysink--dragcomplete)、および IAgentNotifySink::Command**[イベントを](iagentnotifysink--command)**送信しません。 GetAutoPopupMenu**[プロパティ](https://www.bing.com/search?q=**GetAutoPopupMenu**)**true 返す場合を除く。 その場合、サーバーは **IAgentNotifySink::Click** イベントを送信します (ヘルプ モードは終了しません)。ただし、マウスの右ボタンでのみポップアップ メニューを表示できます。

このプロパティは、クライアント アプリケーションによる文字の使用にのみ適用されます。この設定は、文字の他のクライアントやクライアント アプリケーションの他の文字には影響しません。