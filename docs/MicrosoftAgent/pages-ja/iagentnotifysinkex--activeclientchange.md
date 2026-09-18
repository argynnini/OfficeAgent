---
layout: Conceptual
title: IAgentNotifySinkEx ActiveClientChange - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentnotifysinkex--activeclientchange
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentNotifySinkEx ActiveClientChange
document_id: c340dd7b-2f89-101a-4c2f-cdcb5c24c81a
document_version_independent_id: 643ab780-a03e-b269-a4ae-24e64c31211a
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentnotifysinkex--activeclientchange.md
locale: ja-jp
ms.assetid: e953e803-c898-4c07-adc0-8b895b5e8473
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentnotifysinkex--activeclientchange.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:52:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-07-03T23:50:19.3460266Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentnotifysinkex--activeclientchange.md
page_type: conceptual
toc_rel: toc.json
word_count: 992
asset_id: lwef/iagentnotifysinkex--activeclientchange
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 941a92da-6442-9646-1174-4afdbcd83ef9
---

# IAgentNotifySinkEx ActiveClientChange - Win32 apps | Microsoft Learn

[Microsoft Agent は Windows 7 の時点で非推奨となり、後続のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT ActiveClientChange(
...long dwCharID,  // character ID
   long lStatus    // active state flag
);
```

アクティブ クライアントがキャラクターのアクティブ クライアントではなくなった場合に、クライアント アプリケーションに通知します。

- 戻り値はありません。

- *dwCharID*
    - アクティブ クライアントのステータスが変更された文字の識別子。
- *lStatus*
    - クライアントのアクティブな状態の変更。次のいずれかの値の組み合わせになります。

| 値 | 説明 |
| --- | --- |
| **const unsigned short** **ACTIVATE\_NOTACTIVE = 0;** | クライアントがキャラクターのアクティブなクライアントではありません。 |
| **const unsigned short** **ACTIVATE\_ACTIVE = 1;** | クライアントがキャラクターのアクティブなクライアントです。 |
| **const unsigned short** **ACTIVATE\_INPUTACTIVE = 2;** | クライアントは入力アクティブです (最上位文字のアクティブ クライアント)。 |

複数のクライアント アプリケーションが同じキャラクターを共有する場合、そのキャラクターのアクティブなクライアントはマウス入力 (たとえば、Microsoft エージェント コントロールのクリック イベントやドラッグ イベント) を受け取ります。 同様に、複数の文字が表示されている場合、最上位の文字のアクティブ クライアント (入力アクティブ クライアントとも呼ばれます) は [**IAgentNotifySink::Command**](iagentnotifysink--command) イベントを受信します。

キャラクターのアクティブ クライアントが変更されると、このイベントはそのキャラクターの ID を返し、アプリケーションがキャラクターのアクティブ クライアントになった場合は **True** を返し、アプリケーションがキャラクターのアクティブ クライアントでなくなった場合は **False** を返します。

ユーザーがキャラクタのポップアップ メニューまたは音声コマンドで別のクライアント アプリケーションのエントリを選択したとき、クライアント アプリケーションがアクティブ ステータスを変更したとき、または別のクライアント アプリケーションが Microsoft Agent への接続を終了したときに、クライアント アプリケーションはこのイベントを受信することがあります。 エージェントは、直接影響を受けるクライアント アプリケーション (アクティブ クライアントになるか、アクティブ クライアントでなくなるクライアント アプリケーション) にのみこのイベントを送信します。

[**Activate**](iagentcharacter--activate) メソッドを使用すると、アプリケーションがキャラクターのアクティブ クライアントであるかどうか、またはアプリケーションが入力アクティブ クライアント (これにより、キャラクターが最上位になる) であるかどうかを設定することができます。