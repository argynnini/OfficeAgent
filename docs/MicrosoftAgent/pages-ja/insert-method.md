---
layout: Conceptual
title: Insert メソッド - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/insert-method
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Insert メソッド
document_id: 343220ad-ed61-331b-d5c0-d257a08e3cee
document_version_independent_id: e7508803-9b0f-7e62-f0ff-b922013a270e
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/insert-method.md
locale: ja-jp
ms.assetid: d58cfe50-ace7-4b0f-8539-c2e13a180c96
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/insert-method.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:53:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/insert-method.md
page_type: conceptual
toc_rel: toc.json
word_count: 918
asset_id: lwef/insert-method
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 07b3b2c4-c1bb-5b61-5fb5-3a2630710684
---

# Insert メソッド - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - **Commands** コレクションに **Command** オブジェクトを挿入します。
- **構文の**
    - エージェント \*\* です。characters ("***CharacterID***")。Commands.Insert\*\* *Name*、 *RefName*、 *Before*\_

*キャプション*、*Voice、Enabled、Visible*

| 部分 | 形容 |
| --- | --- |
| *名の* | 必須。 [**コマンド**](/ja-jp/windows/desktop/lwef/the-command-object)に割り当てる ID に対応する文字列値。 |
| *RefName* | 必須。 新しいコマンドを挿入するコマンドのすぐ上または下のコマンドの名前 (ID) に対応する文字列値。 |
| *の前に* | 随意。 RefName *で指定されたコマンドの前に新しいコマンド*挿入するかどうかを示すブール値。 **True** (既定値)。 新しいコマンドは、参照されるコマンドの前に挿入されます。**False** 参照先のコマンドの後に新しいコマンドが挿入されます。 |
| *キャプション* | 随意。 文字のポップアップ メニューと、クライアント アプリケーションが入力/アクティブのときにコマンド ウィンドウに表示される名前に対応する文字列値。 詳細については、「[**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトの [**Caption**](caption-property)プロパティ」を参照してください。 |
| *音声* | 随意。 このコマンドを認識するために音声エンジンによって使用される単語または語句に対応する文字列値。 文字列の書式設定の代替方法の詳細については、「[**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトの **Voice** プロパティ」を参照してください。 |
| *Enabled* | 随意。 コマンドが有効かどうかを示すブール値。 既定値は **True**です。 詳細については、「[**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトの **Enabled** プロパティ」を参照してください。 |
| *表示* | 随意。 クライアント アプリケーションが入力/アクティブのときにコマンド がコマンド ウィンドウに表示されるかどうかを示すブール値。 既定値は **True**です。 詳細については、「[**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトの [**Visible**](visible-property) プロパティ」を参照してください。 |

## 備考

[**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトの [**Name**](name-property) プロパティの値は、[**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクション内で一意である必要があります。 同じ **Name** プロパティ設定を使用して新しい **コマンド** を作成する前に、**コマンド** を削除する必要があります。 既に存在する **Name** プロパティを使用して **コマンド** を作成しようとすると、エラーが発生します。

このメソッドは、[**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトも返します。 これにより、**Insert** メソッドを呼び出すときに、オブジェクトを宣言し、**コマンド** を割り当てることができます。

```
   Dim Cmd2 as IAgentCtlCommandEx
   Set Cmd2 = Genie.Commands.Insert ("my second command", "my first command",_ True, "Test", "Test", True, True)
   Cmd2.VoiceCaption = "this is a test"
```