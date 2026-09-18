---
layout: Conceptual
title: IAgentCommand SetConfidenceText - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcommand--setconfidencetext
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCommand SetConfidenceText
document_id: 59e84ecb-a680-6bc4-77db-2a71a0c844bf
document_version_independent_id: 518a1683-1a1e-d0fb-be07-c02b3c6c26c4
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcommand--setconfidencetext.md
locale: ja-jp
ms.assetid: e776a2ba-3592-4f26-a3e3-2c044eed7f0c
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommand--setconfidencetext.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:49:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcommand--setconfidencetext.md
page_type: conceptual
toc_rel: toc.json
word_count: 203
asset_id: lwef/iagentcommand--setconfidencetext
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: a80a145a-4682-2599-9942-c49cadfa9339
---

# IAgentCommand SetConfidenceText - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT SetConfidenceText(
   BSTR bszTipText  // ConfidenceText setting for Command 
);
```

[**コマンド**](/ja-jp/windows/desktop/lwef/the-command-object)の Listening Tip テキストの値を設定します。

- 操作が成功したことを示すS\_OKを返します。

- bszTipText*の *
    - [**コマンド**](/ja-jp/windows/desktop/lwef/the-command-object)の [**ConfidenceText**](confidencetext-property) プロパティのテキストを指定する BSTR。

[**Command**](/ja-jp/windows/desktop/lwef/the-command-object) イベントで返された最適一致の信頼度値が、[**ConfidenceThreshold**](/ja-jp/windows/desktop/lwef/confidence-property) プロパティに設定された値を超えていない場合は、bszTipText  で指定されたテキストがリッスン ヒントに表示されます。