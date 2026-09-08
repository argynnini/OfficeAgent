---
layout: Conceptual
title: IAgentCommandsEx SetFontSize - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcommandsex--setfontsize
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCommandsEx SetFontSize
document_id: cca6c5c8-cc59-8fc6-e6e3-2a56dee20abd
document_version_independent_id: d96c3964-58a9-a4fa-bece-28e5f2882d56
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcommandsex--setfontsize.md
locale: ja-jp
ms.assetid: 095f78d2-ef91-4880-ad49-dd9a94f02891
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommandsex--setfontsize.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:51:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-07-03T23:50:19.3460266Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcommandsex--setfontsize.md
page_type: conceptual
toc_rel: toc.json
word_count: 466
asset_id: lwef/iagentcommandsex--setfontsize
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: c3bd2031-b033-65f0-c468-0a1382fab371
---

# IAgentCommandsEx SetFontSize - Win32 apps | Microsoft Learn

[Microsoft Agent は Windows 7 の時点で非推奨となり、後続のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT SetFontSize(
   long lFontSize  // font size displayed in character's pop-up menu
);
```

キャラクターのポップアップ メニューに表示されるフォントのサイズを設定します。

- 操作が成功したことを示す S\_OK を返します。

- *lFontSize*
    - フォントのサイズ。

このプロパティは、クライアント アプリケーションが入力アクティブのときにキャラクターのポップアップ メニューにテキストを表示するために使用されるフォントのポイント サイズを決定します。 フォント設定のデフォルト値は、キャラクターの言語 ID 設定のメニュー フォント設定、またはユーザーのデフォルトの言語設定が設定されていない場合に基づいています。 入力アクティブでない場合、クライアント アプリケーションの [**Command**](/ja-jp/windows/desktop/lwef/the-command-object)[**Caption**](caption-property) テキストは、入力アクティブ クライアントに指定されたポイント サイズで表示されます。

このプロパティは、クライアント アプリケーションによるキャラクターの使用にのみ適用されます。この設定は、キャラクターの他のクライアントやクライアント アプリケーションの他のキャラクターには影響しません。