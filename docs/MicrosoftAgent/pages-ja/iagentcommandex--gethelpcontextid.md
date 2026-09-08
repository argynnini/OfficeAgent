---
layout: Conceptual
title: IAgentCommandEx GetHelpContextID - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcommandex--gethelpcontextid
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCommandEx GetHelpContextID
document_id: 6d5d8d40-51c4-648b-75a7-48582dc6b242
document_version_independent_id: 97c95f4b-359c-5056-e6f5-f9bf8d4a3376
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcommandex--gethelpcontextid.md
locale: ja-jp
ms.assetid: 97b390f3-ab24-4c09-aa87-d76076eba995
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommandex--gethelpcontextid.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:49:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcommandex--gethelpcontextid.md
page_type: conceptual
toc_rel: toc.json
word_count: 365
asset_id: lwef/iagentcommandex--gethelpcontextid
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 2d92548d-843c-bc15-3a0a-fbe8d52a73ac
---

# IAgentCommandEx GetHelpContextID - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT GetHelpContextID(
   long * pulID  //  address of command's help topic ID
);
```

[**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトの [**HelpContextID**](helpcontextid-property-com) を取得します。

- 操作が成功したことを示すS\_OKを返します。

- pulID*を * する
    - [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトに関連付けられたヘルプ トピックのコンテキスト番号を受け取る変数のアドレス。

アプリケーション用の Windows ヘルプ ファイルを作成し、文字の [**HelpFile**](helpfile-property) プロパティをこのファイルに設定した場合、[**HelpModeOn**](helpmodeon-property) が **True** に設定され、ユーザーがコマンドを選択すると、Microsoft エージェントは自動的にヘルプを呼び出します。 [**HelpContextID**](helpcontextid-property-com)にコンテキスト番号がある場合、エージェントはヘルプを呼び出し、現在のコンテキスト番号で識別されたトピックを検索します。 現在のコンテキスト番号は、コマンド **HelpContextID** の値です。

手記

ヘルプ ファイルをビルドするには、Microsoft Windows ヘルプ コンパイラが必要です。