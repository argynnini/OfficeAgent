---
layout: Conceptual
title: IAgent - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagent
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgent
document_id: c3d39e35-273f-34d6-cfeb-bc489ca03c03
document_version_independent_id: 86ef5125-f89c-ecf9-db5e-5894c65c53b9
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagent.md
locale: ja-jp
ms.assetid: 35b12006-a938-450c-969a-7b73a3768a4d
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagent.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:44:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagent.md
page_type: conceptual
toc_rel: toc.json
word_count: 318
asset_id: lwef/iagent
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: af84d0f0-24c1-207a-1510-7ea72d6c6fe8
---

# IAgent - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

**IAgent** は、アプリケーションが文字を読み込み、イベントを受信し、Microsoft エージェント サーバーの現在の状態を確認できるようにするインターフェイスを定義します。 これらの関数は、[**IAgentEx**](iagentex)からも使用できます。

以前のバージョンに含まれる GetSuspended メソッドは廃止され、下位互換性のために false  返されます。

Vtable Order **のメソッドを** する

| IAgent メソッド | 形容 |
| --- | --- |
| [**読み込み**](load-method) | 文字のデータ ファイルを読み込みます。 |
| [**アンロード**](unload-method) | 文字のデータ ファイルをアンロードします。 |
| [**登録**](iagent--register) | クライアントの通知シンクを登録します。 |
| [**Unegister**](iagent--unregister) | クライアントの通知シンクの登録を解除します。 |
| GetCharacter**[を](iagent--getcharacter)**する | 読み込まれた文字の IAgentCharacter インターフェイスを返します。 |