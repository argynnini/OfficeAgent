---
layout: Conceptual
title: IAgentCommandsEx GetHelpContextID - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcommandsex--gethelpcontextid
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCommandsEx GetHelpContextID
document_id: ed40b58c-5429-4475-cf7a-bfb16c6ca923
document_version_independent_id: 7e76a671-3d73-5f56-f78b-bd836e445765
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcommandsex--gethelpcontextid.md
locale: ja-jp
ms.assetid: db5f93e9-8cd3-4147-94b4-50cfe12033c4
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommandsex--gethelpcontextid.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:51:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcommandsex--gethelpcontextid.md
page_type: conceptual
toc_rel: toc.json
word_count: 440
asset_id: lwef/iagentcommandsex--gethelpcontextid
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: e5f682fc-8774-ae6b-49dd-807d7143ba82
---

# IAgentCommandsEx GetHelpContextID - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT GetHelpContextID(
   long * pulHelpID  // address of Commands object help topic ID
);
```

[**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトの [**HelpContextID**](helpcontextid-property) を取得します。

- 操作が成功したことを示すS\_OKを返します。

- pulHelpID*を * する
    - [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトのヘルプ トピックのコンテキスト番号を受け取る変数のアドレス。

アプリケーション用の Windows ヘルプ ファイルを作成し、文字の [**HelpFile**](helpfile-property) プロパティを設定した場合、[**HelpModeOn**](helpmodeon-property) が true  に設定され、ユーザーが [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトを選択すると、Microsoft Agent は自動的にヘルプを呼び出します。 [**HelpContextID**](helpcontextid-property)にコンテキスト番号がある場合、エージェントはヘルプを呼び出し、現在のコンテキスト番号で識別されたトピックを検索します。 現在のコンテキスト番号は、**Command** オブジェクト **HelpContextID** の値です。

このプロパティは、クライアント アプリケーションによる文字の使用にのみ適用されます。この設定は、文字の他のクライアントやクライアント アプリケーションの他の文字には影響しません。

手記

ヘルプ ファイルをビルドするには、Microsoft Windows ヘルプ コンパイラが必要です。