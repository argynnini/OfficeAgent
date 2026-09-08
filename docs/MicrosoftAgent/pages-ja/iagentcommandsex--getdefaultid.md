---
layout: Conceptual
title: IAgentCommandsEx GetDefaultID - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcommandsex--getdefaultid
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCommandsEx GetDefaultID
document_id: a6477ffe-1053-f1b4-d69c-a0a7789af491
document_version_independent_id: 6bf4f12a-171e-3e55-b1bb-cc42ac1693c4
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcommandsex--getdefaultid.md
locale: ja-jp
ms.assetid: 14079ae0-ad2c-4f38-9371-9914f8402e49
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommandsex--getdefaultid.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:50:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcommandsex--getdefaultid.md
page_type: conceptual
toc_rel: toc.json
word_count: 342
asset_id: lwef/iagentcommandsex--getdefaultid
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 81b51123-1344-2195-466b-1f0a4103f890
---

# IAgentCommandsEx GetDefaultID - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT GetDefaultID(
   long * pdwID  // address of default command's ID
);
```

[**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクション内の既定のコマンドの ID を取得します。

- 操作が成功したことを示すS\_OKを返します。

- pdwID*を * する
    - [**コマンドの ID を受け取る変数のアドレス**](/ja-jp/windows/desktop/lwef/the-command-object) 既定値として設定されます。

このプロパティは、[**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクション内の現在の既定の [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトを返します。 既定のコマンドは、文字のポップアップ メニューで太字です。 ただし、既定のコマンドを設定しても、コマンド処理やダブルクリック イベントは変更されません。

このプロパティは、クライアント アプリケーションによる文字の使用にのみ適用されます。この設定は、文字の他のクライアントやクライアント アプリケーションの他の文字には影響しません。