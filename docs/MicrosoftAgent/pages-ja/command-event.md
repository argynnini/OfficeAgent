---
layout: Conceptual
title: Command イベント - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/command-event
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Command イベント
document_id: 7f31f97d-c211-353a-2959-4edd6f786f10
document_version_independent_id: 03ee5014-c265-db2a-4f31-6c9d9e71d5ae
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/command-event.md
locale: ja-jp
ms.assetid: 3e180286-dfa0-4b34-90ee-3267ed6f48af
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/command-event.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:38:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-07-03T23:50:19.3460266Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/command-event.md
page_type: conceptual
toc_rel: toc.json
word_count: 1316
asset_id: lwef/command-event
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: be684f39-93f6-5a73-f593-bf34950ce048
---

# Command イベント - Win32 apps | Microsoft Learn

[Microsoft Agent は Windows 7 の時点で非推奨となり、後続のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - ユーザーが (クライアントの) コマンドを選択したときに発生します。
- **構文**
    - **Sub***agent*\_**Command** **(ByVal***UserInput*\*\*)\*\*

| 部分 | 説明 |
| --- | --- |
| *UserInput* | サーバーによって返される [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトを識別します。 [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトから次のプロパティにアクセスできます。 CharacterID  コマンドを受け取ったキャラクターの名前 (ID) を識別する文字列値。 [**名前**](name-property) コマンドの名前 (ID) を識別する文字列値。[**信頼度**](confidence-property) コマンドの信頼度スコアリングを示す長整数値。 [**音声**](voice-property) コマンドの音声テキストを識別する文字列値。 Alt1Name  次の (2 番目の) 最適なコマンドの名前を識別する文字列値。 Alt1Confidence  次の (2 番目の) 最適なコマンドの信頼度スコアリングを示す長整数値。 Alt1Voice  次に最適な代替コマンド一致の音声テキストを識別する文字列値。 Alt2Name  3 番目に最適なコマンド一致の名前を識別する文字列値。 Alt2Confidence  3 番目に最適なコマンド一致の信頼度スコアリングを識別する長整数。 Alt2Voice  3 番目に最適なコマンド一致の音声テキストを識別する文字列値。[**Count**](count-property) 返される代替の数を示す長整数。 |

### 解説

アプリケーションが入力アクティブであり、ユーザーが音声入力またはキャラクターのポップアップ メニューでコマンドを選択すると、サーバーからこのイベントが通知されます。 イベントは、 [**Count**](count-property) で使用可能な一致するコマンドの数に加え、それらの一致の名前、信頼度スコアリング、音声テキストを返します。

音声入力によってこのイベントがトリガーされた場合、サーバーは、 [**Name**](name-property) パラメーターで最適な一致を識別する文字列と、Alt1Name と Alt2Name の 2 番目と 3 番目に一致する文字列を返します。 空の文字列は、入力がアプリケーションで定義されたコマンドと一致しなかったことを示します。たとえば、サーバーで定義されているコマンドのいずれかです。 コマンドがエージェントのコマンドと一致した場合。たとえば、Hide では **Name** パラメーターで空の文字列が返されますが、この場合でも [**Voice**](voice-property) パラメーターで読み上げられたテキストを受け取ります。

複数のエントリで同じコマンド名が返される場合があります。 [**Confidence**](confidence-property)、Alt1Confidence、および Alt2Confidence の各パラメーターは、それぞれの一致ごとに音声認識エンジンによって返される、-100 から 100 の範囲の相対スコアを返します。 [**Voice**](voice-property)、Alt1Voice、および Alt2Voice の各パラメーターは、音声認識エンジンが代替手段ごとに一致した音声テキストを返します。 [**Count**](count-property) がゼロ (0) を返した場合、サーバーは音声入力を検出しましたが、一致するコマンドがないと判断しました。

音声入力がコマンドのソースではなかった場合 (たとえば、ユーザーがキャラクターのポップアップ メニューからコマンドを選択した場合)、サーバーは [**Name**](name-property) プロパティで選択したコマンドの名前 (ID) を返します。 また、[**Confidence**](confidence-property) パラメーターの値を 100 として返し、[**Voice**](voice-property) パラメーターの値を空の文字列 ("") として返します。 Alt1Name と Alt2Name も空の文字列を返します。 Alt1Confidence と Alt2Confidence はゼロ (0) を返し、Alt1Voice と Alt2Voice は空の文字列を返します。 [**Count**](count-property) は 1 を返します。

Note

すべての音声認識エンジンがこのイベントのすべてのパラメーターのすべての値を返すわけではありません。 エンジン ベンダーに問い合わせて、エンジンが代替手段と信頼度スコアを返すために Microsoft Speech API インターフェイスをサポートしているかどうかを確認してください。