---
layout: Conceptual
title: IAgentCommandsEx SetDefaultID - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcommandsex--setdefaultid
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCommandsEx SetDefaultID
document_id: e0803b29-3f8e-fc88-bea1-0e0d74562eec
document_version_independent_id: 3940e969-b5b3-1eec-cb6c-0571402c2916
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcommandsex--setdefaultid.md
locale: ja-jp
ms.assetid: 056ec518-bf0b-403f-adc6-9b53b0c044a7
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommandsex--setdefaultid.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:50:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcommandsex--setdefaultid.md
page_type: conceptual
toc_rel: toc.json
word_count: 333
asset_id: lwef/iagentcommandsex--setdefaultid
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 1d1280ce-5e66-bd1d-fe73-1d71fed3e886
---

# IAgentCommandsEx SetDefaultID - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT SetDefaultID(
   long dwID,  // default command's ID
);
```

[**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクション内の既定のコマンドの ID を設定します。

- 操作が成功したことを示すS\_OKを返します。

- dwID*を * する
    - [**コマンドの ID**](/ja-jp/windows/desktop/lwef/the-command-object) 既定値として設定されます。

このプロパティは、[**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションに設定された既定の [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトを設定します。 既定のコマンドは、文字のポップアップ メニューで太字です。 ただし、既定のコマンドを設定しても、コマンド処理やダブルクリック イベントは実際には変更されません。

このプロパティは、クライアント アプリケーションによる文字の使用にのみ適用されます。この設定は、文字の他のクライアントやクライアント アプリケーションの他の文字には影響しません。