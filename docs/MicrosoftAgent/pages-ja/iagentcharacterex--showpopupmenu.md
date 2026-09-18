---
layout: Conceptual
title: IAgentCharacterEx ShowPopupMenu - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcharacterex--showpopupmenu
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCharacterEx ShowPopupMenu
document_id: 290341ce-47fd-a36d-e5fe-e157a7a7810d
document_version_independent_id: b5d9530c-1dae-684d-8ae3-7a14ff774704
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacterex--showpopupmenu.md
locale: ja-jp
ms.assetid: f93c4c9e-5ef8-42d1-8f22-d6625af7978f
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacterex--showpopupmenu.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:48:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcharacterex--showpopupmenu.md
page_type: conceptual
toc_rel: toc.json
word_count: 448
asset_id: lwef/iagentcharacterex--showpopupmenu
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: f391b0c4-f675-b3c6-2c4d-1d33d0b2d8c1
---

# IAgentCharacterEx ShowPopupMenu - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT ShowPopupMenu(
   short x,  // x-coordinate of pop-up menu
   short y   // y-coordinate of pop-up menu
);
```

文字のポップアップ メニューを表示します。

- 操作が成功したことを示すS\_OKを返します。

- *x*
    - 画面の原点 (左上) を基準とした、文字のポップアップ メニューの x 座標 (ピクセル単位)。
- *y*
    - 画面の原点 (左上) を基準とした、文字のポップアップ メニューの y 座標 (ピクセル単位)。

IAgentCharacterEx::SetAutoPopupMenuを False に設定すると、文字またはそのタスク バー アイコンが右クリックされたときに、サーバーにメニューが自動的に表示されなくなります。 このメソッドを使用してメニューを表示できます。

ユーザーがコマンドを選択するか、別のメニューを表示するまで、メニューが表示されます。 一度に表示できるポップアップ メニューは 1 つだけです。したがって、このメソッドの呼び出しは、前のメニューをキャンセル (削除) します。

このメソッドは、クライアント アプリケーションが文字のアクティブなクライアントである場合にのみ呼び出す必要があります。それ以外の場合は失敗します。

[**IAgentCharacterEx::SetAutoPopupMenu**](iagentcharacterex--setautopopupmenu)