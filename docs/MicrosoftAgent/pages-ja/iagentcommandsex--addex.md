---
layout: Conceptual
title: IAgentCommandsEx AddEx - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcommandsex--addex
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCommandsEx AddEx
document_id: 062c1e7b-ac00-5866-75cf-2fd072c14e36
document_version_independent_id: baeed131-9971-d2b1-2d63-b16c1534ceba
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcommandsex--addex.md
locale: ja-jp
ms.assetid: 54be4793-89ac-475b-8a6a-5b8c18bb4b38
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommandsex--addex.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:50:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcommandsex--addex.md
page_type: conceptual
toc_rel: toc.json
word_count: 535
asset_id: lwef/iagentcommandsex--addex
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: fea6f7c0-6d18-b27d-7fbe-ea78298c6359
---

# IAgentCommandsEx AddEx - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

```syntax
HRESULT AddEx(
   BSTR bszCaption,       // Caption setting for Command
   BSTR bszVoice,         // Voice setting for Command
   BSTR bszVoiceCaption,  // VoiceCaption setting for Command
   long bEnabled,         // Enabled setting for Command
   long bVisible,         // Visible setting for Command
   long ulHelpID,         // HelpContextID setting for Command
   long * pdwID           // address for variable for ID
);
```

Command コレクションに [**Command を**](/ja-jp/windows/desktop/lwef/the-commands-collection-object)追加[**します**](/ja-jp/windows/desktop/lwef/the-command-object)。

- 操作が成功したことを示すS\_OKを返します。

- *bszCaption*
    - [**Command**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクション内の [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) に対して表示される [**Caption**](caption-property) テキストの値を指定する BSTR。
- *bszVoice*
    - [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクション内の [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) の[**音声**](voice-property)テキスト設定の値を指定する BSTR。
- *bszVoiceCaption*
    - [**Command**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクション内の [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) に対して表示される [**VoiceCaption**](voicecaption-property) テキストの値を指定する BSTR。
- *bEnabled*
    - [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクション内の [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) の [**Enabled**](enabled-property) 設定を指定するブール式。 パラメーターが **True の**場合、 **Command** は有効になり、選択できます。 **False の**場合、 **コマンド** は無効になります。
- *bVisible*
    - [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクション内の [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) の [**Visible**](visible-property) 設定を指定するブール式。 パラメーターが **True の**場合、 **Command** は文字のポップアップ メニューに表示されます ( [**Caption**](caption-property) プロパティも設定されている場合)。
- *ulHelpID*
    - [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトに関連付けられているヘルプ トピックのコンテキスト番号。コマンドの状況依存のヘルプを提供するために使用されます。
- *pdwID*
    - 追加された [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) の ID を受け取る変数のアドレス。

[**IAgentCommandsEx::AddEx**](https://www.bing.com/search?q=**IAgentCommandsEx::AddEx**) は[**、HelpContextID**](helpcontextid-property) プロパティを含めることで [**IAgentCommands::Add**](iagentcommands--add) を拡張します。 プロパティは、[**IAgentCommandsEx::SetHelpContextID** を使用して設定することもできます。](iagentcommandsex--sethelpcontextid)