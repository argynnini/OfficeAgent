---
layout: Conceptual
title: IAgentCharacterEx GetAutoPopupMenu - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcharacterex--getautopopupmenu
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCharacterEx GetAutoPopupMenu
document_id: f0efda8b-ea4e-8cf9-b730-15e49ecd4e71
document_version_independent_id: 41b43875-a0d0-ac67-ab65-88087a0511cd
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacterex--getautopopupmenu.md
locale: ja-jp
ms.assetid: c29bfd6e-c7eb-426e-be38-2fa0bdb13211
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacterex--getautopopupmenu.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:47:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcharacterex--getautopopupmenu.md
page_type: conceptual
toc_rel: toc.json
word_count: 347
asset_id: lwef/iagentcharacterex--getautopopupmenu
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 20f536f8-5255-ba22-456c-cec29d304bd1
---

# IAgentCharacterEx GetAutoPopupMenu - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT GetAutoPopupMenu(
   long * pbAutoPopupMenu  // address of auto pop-up menu display setting
);
```

サーバーがキャラクターのポップアップ メニューを自動的に表示するかどうかを取得します。

- 操作が成功したことを示すS\_OKを返します。

- pbAutoPopupMenu*を * する
    - **True を受け取る変数のアドレスは、Microsoft エージェント サーバーが自動的に文字のポップアップ メニューの表示を処理し、そうでない場合は false を 場合に** します。

このプロパティを **False**に設定すると、アプリケーションは IAgentCharacterEx::ShowPopupMenu**[メソッド](iagentcharacterex--showpopupmenu)**使用してポップアップ メニューを表示する必要があります。

このプロパティは、クライアント アプリケーションによる文字の使用にのみ適用されます。この設定は、文字の他のクライアントやクライアント アプリケーションの他の文字には影響しません。