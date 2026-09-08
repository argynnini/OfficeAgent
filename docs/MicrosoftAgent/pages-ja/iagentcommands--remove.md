---
layout: Conceptual
title: IAgentCommands Remove - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcommands--remove
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCommands Remove
document_id: 1f3db6db-29e7-dc68-b14c-e3e1004bc090
document_version_independent_id: 9f292a43-4167-6449-aaa7-624abea488bb
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentcommands--remove.md
locale: ja-jp
ms.assetid: 1f41aa2d-e50b-48a8-87fc-fda4730b035a
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommands--remove.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:50:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcommands--remove.md
page_type: conceptual
toc_rel: toc.json
word_count: 204
asset_id: lwef/iagentcommands--remove
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 306b7d78-268f-fd4f-4c2f-07754d8861d0
---

# IAgentCommands Remove - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT Remove(
   long dwID  // Command ID
);
```

指定した [**コマンド**](/ja-jp/windows/desktop/lwef/the-command-object) を [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションから削除します。

- 操作が成功したことを示すS\_OKを返します。

- dwID*を * する
    - [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションから削除する [**コマンド**](/ja-jp/windows/desktop/lwef/the-command-object) の ID。

[**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションから [**コマンド**](/ja-jp/windows/desktop/lwef/the-command-object) を削除すると、アプリケーションが入力アクティブのときに、ポップアップ メニューと **音声コマンド ウィンドウ** からも削除されます。