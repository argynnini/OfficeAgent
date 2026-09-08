---
layout: Conceptual
title: Controls メソッド、プロパティ、およびイベントへのアクセス - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/accessing-the-controls-methods--properties--and-events
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Controls メソッド、プロパティ、およびイベントへのアクセス
document_id: 0e2b7217-1d21-1dc0-d137-0e5752598c85
document_version_independent_id: da037c9f-6e7d-29b7-f780-ff44bc02b427
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/accessing-the-controls-methods--properties--and-events.md
locale: ja-jp
ms.assetid: 70a3b011-0290-4df4-9b66-23b27bcb14e9
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/accessing-the-controls-methods--properties--and-events.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:36:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/accessing-the-controls-methods--properties--and-events.md
page_type: conceptual
toc_rel: toc.json
word_count: 1335
asset_id: lwef/accessing-the-controls-methods--properties--and-events
item_type: Content
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 8bce64e6-97ff-08c9-a8f4-bc12f8d96779
---

# Controls メソッド、プロパティ、およびイベントへのアクセス - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

Visual Basic での Microsoft エージェントのコントロールの使用は、VBScript でコントロールを使用するのとよく似ていますが、Visual Basic のイベントには渡されたパラメーターのデータ型を含める必要があります。 フォームに Microsoft エージェント コントロールを追加すると、適切なパラメーターを持つ Microsoft エージェントのイベントが自動的に含まれます。 また、アプリケーションの実行時にエージェント サーバーへの接続も自動的に作成されます。

また、プログラミング言語のオブジェクトの作成構文を使用して、実行時にコントロールのインスタンスを作成することもできます。 たとえば、Visual Basic (5.0 以降) で、Microsoft Agent 2.0 コントロールをプロジェクトの参照に含める場合は、 [**With Events**](https://www.bing.com/search?q=**With+Events**) を使用できます。[**新しい**](https://www.bing.com/search?q=**New**) 宣言。 参照を含めない場合、MICROSOFT エージェントが起動できなかったことを示すエラーが発生します (エラー コード80042502)。

```syntax
   ' Declare a global variable for the control
   Dim WithEvents MyAgent as Agent

   ' Create an instance of the control using New
   Set MyAgent = New Agent

' Load a character
   MyAgent.Characters.Load "Genie", " Genie.acs"

   ' Display the character
   MyAgent.Characters("Genie").Show
```

5.0 より前のバージョンの VB の場合、[**WithEvents**](https://www.bing.com/search?q=**WithEvents**) 宣言または VB [**CreateObject**](https://msdn.microsoft.com/library/Bb545141%28v=VS.85%29.aspx) 関数を使用せずに VB [**New**](https://www.bing.com/search?q=**New**) キーワード (keyword)を使用できますが、これらの規則ではエージェント コントロールのイベントは公開されません。 また、エージェントのメソッドまたはプロパティを参照する前に [**、Connected**](https://www.bing.com/search?q=**Connected**) プロパティを使用する必要もあります。 これが行われなかった場合、VB は Microsoft エージェントを起動できなかったことを示すエラーを発生させます (エラー コード80042502)。

他のプログラミング言語の場合と同様に、コードでエージェント コントロールのメソッドまたはプロパティを呼び出す前に、 [**Connected**](https://www.bing.com/search?q=**Connected**) プロパティを使用してエージェント コンポーネント オブジェクト モデル (COM) サーバーへの接続を確立する必要がある場合があります。 また、一部のプログラミング言語では、その型を使用してエージェント コントロールを宣言しない限り、エージェントのメソッドとプロパティが直接公開されない場合があります。 たとえば、Microsoft Access 97 では、オブジェクトを Agent 型として宣言して、入力時に [メンバーの自動リスト] ドロップダウン ボックスにメソッドとプロパティが表示されるようにする必要があります。

ActiveX コントロールをサポートするほとんどのプログラミング言語は、Visual Basic と同様の規則に従います。 オブジェクト コレクションをサポートしていないプログラミング言語の場合は、 [**Character**](https://www.bing.com/search?q=**Character**) メソッドと [**Command**](https://www.bing.com/search?q=**Command**) メソッドを使用して、コレクション内の項目のメソッドとプロパティにアクセスできます。

エージェント コントロールによって公開されるオブジェクト型へのアクセスを提供する Visual Basic などのプログラミング言語を使用すると、オブジェクト宣言でこれらを使用できます。 たとえば、オブジェクトをジェネリック型として宣言する代わりに、次のようになります。

```syntax
   Dim Genie as Object
```

オブジェクトは、特定の型として宣言できます。

```syntax
   Dim Genie as IAgentCtlCharacterEx
```

これにより、アプリケーションの全体的なパフォーマンスが向上する可能性があります。

一部のオブジェクト型では、"Ex" サフィックスを除いて同じ 2 つの型が見つかる場合があります。 両方が存在する場合は、エージェントの完全な機能が提供されるため、"Ex" 型を使用します。 "Ex" 以外の対応するは、下位互換性のためにのみ含まれています。