---
layout: Conceptual
title: Add メソッド - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/add-method
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Add メソッド
document_id: 4fba7970-436b-397c-f65f-56c09ee99b2c
document_version_independent_id: 9adee1b1-610d-8762-a641-758cc5cd7a74
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/add-method.md
locale: ja-jp
ms.assetid: dd258294-33d6-45f5-a6a1-a3a56b12a7df
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/add-method.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:36:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/add-method.md
page_type: conceptual
toc_rel: toc.json
word_count: 752
asset_id: lwef/add-method
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: a2f902e1-c007-a69e-f5d4-4226fc6e51f6
---

# Add メソッド - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - [Command](the-command-object) オブジェクトを [Commands](the-commands-collection-object) コレクションに追加します。
- **構文の**
    - エージェント \*\* です。characters ("***CharacterID***")。Commands.Add\*\* *Name*, *Caption*, *Voice*, *Enabled*, *Visible*

| 部分 | 形容 |
| --- | --- |
| *名の* | 必須。 コマンドに割り当てる ID に対応する文字列値。 |
| *キャプション* | 随意。 文字のポップアップ メニューと、クライアント アプリケーションが入力/アクティブのときにコマンド ウィンドウに表示される名前に対応する文字列値。 詳細については、「[Command](the-command-object) オブジェクトの [Caption](caption-property) プロパティ」を参照してください。 |
| *音声* | 随意。 このコマンドを認識するために音声エンジンによって使用される単語または語句に対応する文字列値。 文字列の書式設定の代替方法の詳細については、[Command](the-command-object) オブジェクトの [Voice](voice-property) プロパティを参照してください。 |
| *Enabled* | 随意。 コマンドが有効かどうかを示すブール値。 既定値は **True**です。 詳細については、「[Command](the-command-object) オブジェクトの [Enabled](enabled-property) プロパティ」を参照してください。 |
| *表示* | 随意。 クライアント アプリケーションが入力/アクティブのときに、文字のポップアップ メニューにコマンドが表示されるかどうかを示すブール値。 既定値は **True**です。 詳細については、「[Command](the-command-object) オブジェクトの [Visible](visible-property) プロパティ」を参照してください。 |

## 備考

[Command](the-command-object) オブジェクトの [Name](name-property) プロパティの値は、[Commands](the-commands-collection-object) コレクション内で一意である必要があります。 同じ Name プロパティ設定を使用して新しいコマンドを作成する前に、コマンドを削除する必要があります。 既に存在する Name プロパティを持つコマンドを作成しようとすると、エラーが発生します。

このメソッドは、[Command](the-command-object) オブジェクトも返します。 これにより、オブジェクトを宣言し、Addmethod を呼び出すときにコマンドを割り当てることができます。

```
   Dim Cmd1 as IAgentCtlCommandEx
   Set Cmd1 = Genie.Commands.Add ("my first command", "Test", "Test", True, True)
   Cmd1.VoiceCaption = "this is a test"
```