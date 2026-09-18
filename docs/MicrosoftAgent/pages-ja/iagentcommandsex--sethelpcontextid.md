---
layout: Conceptual
title: IAgentCommandsEx SetHelpContextID - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcommandsex--sethelpcontextid
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCommandsEx SetHelpContextID
document_id: bfd3e8e2-8c38-4a61-d365-381733457b9e
document_version_independent_id: 606e70f3-f4ee-6cad-30fe-0921c5d9bead
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcommandsex--sethelpcontextid.md
locale: ja-jp
ms.assetid: b49d8184-f8dd-4359-9d45-3f038af18da5
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommandsex--sethelpcontextid.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:51:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcommandsex--sethelpcontextid.md
page_type: conceptual
toc_rel: toc.json
word_count: 570
asset_id: lwef/iagentcommandsex--sethelpcontextid
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: b8b31cf5-7c7d-a6ae-5112-c97bf411bbec
---

# IAgentCommandsEx SetHelpContextID - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT SetHelpContextID(
   long ulHelpID  // ID for help topic
);
```

[**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトの [**HelpContextID**](helpcontextid-property) を設定します。

- 操作が成功したことを示すS\_OKを返します。

- ulHelpID*を * する
    - [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトに関連付けられているヘルプ トピックのコンテキスト番号。コマンドの状況依存のヘルプを提供するために使用されます。

アプリケーションの Windows ヘルプ ファイルを作成し、文字の [**HelpFile**](helpfile-property) プロパティで設定した場合。 [**HelpModeOn**](helpmodeon-property) が True  に設定され、ユーザーがコマンドを選択すると、エージェントは自動的にヘルプを呼び出します。 [**HelpContextID**](helpcontextid-property)にコンテキスト番号がある場合、エージェントはヘルプを呼び出し、現在のコンテキスト番号で識別されたトピックを検索します。 現在のコンテキスト番号は、コマンド **HelpContextID** の値です。 選択したコマンドの **HelpContextID** プロパティにコンテキスト番号がある場合、ヘルプには現在のヘルプ コンテキストに対応するトピックが表示されます。それ以外の場合は、"このアイテムに関連付けられているヘルプ トピックがありません" と表示されます。

このプロパティは、クライアント アプリケーションによる文字の使用にのみ適用されます。この設定は、文字の他のクライアントやクライアント アプリケーションの他の文字には影響しません。

手記

ヘルプ ファイルをビルドするには、Microsoft Windows ヘルプ コンパイラが必要です。