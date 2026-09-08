---
layout: Conceptual
title: IAgentCharacterEx SetHelpFileName - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcharacterex--sethelpfilename
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCharacterEx SetHelpFileName
document_id: 8b60a007-f5a2-a2e2-3b93-5897a573d0e5
document_version_independent_id: 1e951eca-e771-cd04-cc22-adb935c144a9
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacterex--sethelpfilename.md
locale: ja-jp
ms.assetid: 1f8d2bd7-5821-46c0-b371-7ecbc526df72
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacterex--sethelpfilename.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:48:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcharacterex--sethelpfilename.md
page_type: conceptual
toc_rel: toc.json
word_count: 455
asset_id: lwef/iagentcharacterex--sethelpfilename
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: c8c71fdc-34d0-4970-1daf-65381e9d37fe
---

# IAgentCharacterEx SetHelpFileName - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT SetHelpFileName(
   BSTR bszName  // Help filename
);
```

文字の HelpFileName を設定します。

- 操作が成功したことを示すS\_OKを返します。

- bszName*を * する
    - 文字のヘルプ ファイル名。

アプリケーション用の Windows ヘルプ ファイルを作成し、文字の [**HelpFile**](helpfile-property) プロパティを設定した場合、[**HelpModeOn**](helpmodeon-property) が **True** に設定され、ユーザーが文字をクリックするか、ポップアップ メニューからコマンドを選択すると、Microsoft エージェントは自動的にヘルプを呼び出します。 選択したコマンドの [**HelpContextID**](helpcontextid-property) プロパティにコンテキスト番号がある場合、ヘルプには現在のヘルプ コンテキストに対応するトピックが表示されます。それ以外の場合は、"このアイテムに関連付けられているヘルプ トピックがありません" と表示されます。

このプロパティは、クライアント アプリケーションによる文字の使用にのみ適用されます。この設定は、文字の他のクライアントやクライアント アプリケーションの他の文字には影響しません。

手記

ヘルプ ファイルをビルドするには、Microsoft Windows ヘルプ コンパイラが必要です。