---
layout: Conceptual
title: IAgentCharacterEx GetActive - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcharacterex--getactive
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCharacterEx GetActive
document_id: 32dffc6b-d294-ef33-b94d-c642f2f50a82
document_version_independent_id: 6c4a0682-6008-f8f9-71ed-16d4e48d9ae0
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacterex--getactive.md
locale: ja-jp
ms.assetid: b14ae69a-a50e-4488-b5a7-33702e6555eb
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacterex--getactive.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:47:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-07-03T23:50:19.3460266Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcharacterex--getactive.md
page_type: conceptual
toc_rel: toc.json
word_count: 652
asset_id: lwef/iagentcharacterex--getactive
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 8664596c-ce14-6c64-6530-f65e30163672
---

# IAgentCharacterEx GetActive - Win32 apps | Microsoft Learn

[Microsoft Agent は Windows 7 の時点で非推奨となり、後続のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT GetActive(
   short * psState  // address of active state setting
);
```

クライアント アプリケーションがキャラクターのアクティブなクライアントかどうか、およびキャラクターが一番上にあるかどうかを取得します。

- 操作が成功したことを示す S\_OK を返します。

- *psState*
    - 状態設定に対して次のいずれかの値を受け取る変数のアドレス。

| 値 | 説明 |
| --- | --- |
| **const unsigned short** **ACTIVATE\_NOTACTIVE = 0;** | クライアントがキャラクターのアクティブなクライアントではありません。 |
| **const unsigned short** **ACTIVATE\_ACTIVE = 1;** | クライアントがキャラクターのアクティブなクライアントです。 |
| **const unsigned short** **ACTIVATE\_INPUTACTIVE = 2;** | クライアントが入力アクティブ (最上位キャラクターのアクティブなクライアント) です。 |

この設定を使用すると、ユーザーがキャラクターのアクティブなクライアントかどうか、またはキャラクターが入力アクティブ キャラクターであるかどうかがわかります。 複数のクライアント アプリケーションで同じキャラクターを共有している場合、キャラクターのアクティブなクライアントはマウス入力を受け取ります (たとえば、Microsoft Agent コントロールのクリック イベントまたはドラッグ イベント)。 同様に、複数のキャラクターが表示されると、最上位キャラクター (入力アクティブ クライアントとも呼ばれます) のアクティブなクライアントは [**IAgentNotifySink::Command**](iagentnotifysink--command) イベントを受け取ります。

[**Activate**](iagentcharacter--activate)メソッドを使用して、アプリケーションがキャラクターのアクティブなクライアントかどうかを設定するか、アプリケーションを入力アクティブ クライアントにするか (キャラクターの最上位にもなります) を設定します。