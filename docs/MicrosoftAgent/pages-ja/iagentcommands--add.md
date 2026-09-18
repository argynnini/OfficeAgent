---
layout: Conceptual
title: IAgentCommands Add - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcommands--add
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCommands Add
document_id: 5b03aaa3-222c-fdd6-50a2-5a1a40d6d7c5
document_version_independent_id: ca56ad6d-ceda-f5d9-b10a-bb557ee055e3
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcommands--add.md
locale: ja-jp
ms.assetid: f6be7773-77fa-4c59-8feb-c2ebf54fd2e0
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommands--add.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:49:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcommands--add.md
page_type: conceptual
toc_rel: toc.json
word_count: 384
asset_id: lwef/iagentcommands--add
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 46b9a5e7-ccaf-091d-379b-202dd894831c
---

# IAgentCommands Add - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT Add(
   BSTR bszCaption,  // Caption setting for Command
   BSTR bszVoice,    // Voice setting for Command
   long bEnabled,    // Enabled setting for Command
   long bVisible,    // Visible setting for Command
   long * pdwID      // address for variable for ID
);
```

[**コマンド**](/ja-jp/windows/desktop/lwef/the-command-object) を [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションに追加します。

- 操作が成功したことを示すS\_OKを返します。

- bszCaption*を * する
    - [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクション内の [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) に表示される [**Caption**](caption-property) テキストの値を指定する BSTR。
- *bszVoice*
    - [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクション内の [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) の [**Voice**](voice-property) テキスト設定の値を指定する BSTR。
- *bEnabled*
    - [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクション内の [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) の [**Enabled**](enabled-property) 設定を指定するブール式。 パラメーターが True 場合、**コマンド** が有効になり、選択できます。false 場合、**コマンド** は無効になります。
- *bVisible*
    - [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクション内の [**コマンド**](/ja-jp/windows/desktop/lwef/the-command-object) の [**表示**](visible-property) 設定を指定するブール式。 パラメーターが True 場合、**コマンド** は文字のポップアップ メニューに表示されます ([**Caption**](caption-property) プロパティも設定されている場合)。
- pdwID*を * する
    - 追加された [**コマンド**](/ja-jp/windows/desktop/lwef/the-command-object)の ID を受け取る変数のアドレス。