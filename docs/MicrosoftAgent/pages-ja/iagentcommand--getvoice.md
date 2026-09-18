---
layout: Conceptual
title: IAgentCommand GetVoice - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcommand--getvoice
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCommand GetVoice
document_id: 23c4ccf7-b763-2021-3d81-0c9e88b9e634
document_version_independent_id: 1624ce0a-e3b1-8991-969f-679e9f1c0941
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcommand--getvoice.md
locale: ja-jp
ms.assetid: 69f3c91b-2ccf-4bea-8034-0c3e0a5e4ec4
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommand--getvoice.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:49:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcommand--getvoice.md
page_type: conceptual
toc_rel: toc.json
word_count: 274
asset_id: lwef/iagentcommand--getvoice
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 872e66cd-a56b-a491-5be2-ca6490051bb0
---

# IAgentCommand GetVoice - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT GetVoice(
   BSTR * pbszVoice  // address of Voice setting for Command
);
```

[**コマンド**](/ja-jp/windows/desktop/lwef/the-command-object)の [**Voice**](voice-property) テキスト プロパティの値を取得します。

- 操作が成功したことを示すS\_OKを返します。

- pbszVoice*を * する
    - [**コマンド**](/ja-jp/windows/desktop/lwef/the-command-object)の [**Voice**](voice-property) テキスト プロパティを受け取る BSTR のアドレス。

[**コマンド**](/ja-jp/windows/desktop/lwef/the-command-object)、[**Voice**](voice-property) プロパティが設定され、その [**Enabled**](enabled-property) プロパティが **True** に設定されている場合は、音声でアクセスできます。 [**Caption**](caption-property) プロパティも設定されている場合は、[音声コマンド] ウィンドウに表示されます。 [**Visible**](visible-property) プロパティが true に設定されている場合は、文字のポップアップ メニューに表示されます。