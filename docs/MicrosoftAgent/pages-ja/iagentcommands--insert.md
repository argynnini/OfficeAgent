---
layout: Conceptual
title: IAgentCommands Insert - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcommands--insert
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCommands Insert
document_id: e02badf6-a263-a286-0000-74b95a1154c5
document_version_independent_id: b14b3667-88f5-4dab-7a18-c134a307afa7
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentcommands--insert.md
locale: ja-jp
ms.assetid: f450aae4-db6f-4326-ae14-ddb68ab0953a
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommands--insert.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:50:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcommands--insert.md
page_type: conceptual
toc_rel: toc.json
word_count: 501
asset_id: lwef/iagentcommands--insert
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://authoring-docs-microsoft.poolparty.biz/devrel/8b896464-3b7d-4e1f-84b0-9bb45aeb5f64
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://authoring-docs-microsoft.poolparty.biz/devrel/b1d2d671-9549-46e8-918c-24349120dbf5
platformId: ba2a53d9-d81e-517a-af0d-20f8f31da654
---

# IAgentCommands Insert - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT Insert(
   BSTR bszCaption,  // Caption setting for Command
   BSTR bszVoice,    // Voice setting for Command
   long bEnabled,    // Enabled setting for Command
   long bVisible,    // Visible setting for Command
   long dwRefID,     // reference Command for insertion
   long dBefore,     // insertion position flag
   long * pdwID      // address for variable for Command ID
);
```

[**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションに [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトを挿入します。

- 操作が成功したことを示すS\_OKを返します。

- bszCaption*を * する
    - [**コマンド**](/ja-jp/windows/desktop/lwef/the-command-object)に表示される [**Caption**](caption-property) テキストの値を指定する BSTR。
- *bszVoice*
    - [**コマンド**](/ja-jp/windows/desktop/lwef/the-command-object)の [**Voice**](voice-property) テキスト設定の値を指定する BSTR。
- *bEnabled*
    - [**コマンド**](/ja-jp/windows/desktop/lwef/the-command-object)の [**Enabled**](enabled-property) 設定を指定するブール式。 パラメーターが True 場合、**コマンド** が有効になり、選択できます。false 場合、**コマンド** は無効になります。
- *bVisible*
    - [**コマンド**](/ja-jp/windows/desktop/lwef/the-command-object)の [**表示**](visible-property) 設定を指定するブール式。 パラメーターが True 場合、**コマンド** は文字のポップアップ メニューに表示されます ([**Caption**](caption-property) プロパティも設定されている場合)。
- dwRefID*を * する
    - [**コマンドの ID**](/ja-jp/windows/desktop/lwef/the-command-object)、新しい **コマンド**の相対挿入の参照として使用されます。
- dBefore*を * する
    - [**コマンド**](/ja-jp/windows/desktop/lwef/the-command-object)を配置する場所を指定するブール式。 このパラメーターが True 場合、新しい **コマンド** は、参照される **コマンド**の前に挿入されます。false 場合、新しい **コマンド** は、参照される **コマンド**の後に配置されます。
- pdwID*を * する
    - 挿入された [**コマンド**](/ja-jp/windows/desktop/lwef/the-command-object)の ID を受け取る変数のアドレス。