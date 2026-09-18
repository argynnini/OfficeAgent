---
layout: Conceptual
title: IAgentUserInput - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentuserinput
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentUserInput
document_id: bf5905c2-7b6e-6f3e-7887-d7104d7ee26e
document_version_independent_id: dc101c88-3b54-e0b1-aae1-1da5ec715f54
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentuserinput.md
locale: ja-jp
ms.assetid: 59ce7337-6031-4449-8b29-fd0c6737c3e8
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentuserinput.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:53:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentuserinput.md
page_type: conceptual
toc_rel: toc.json
word_count: 288
asset_id: lwef/iagentuserinput
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: bffa665a-0ce7-cd4e-f69a-2cce3b700625
---

# IAgentUserInput - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

サーバーは、[**IAgentNotifySink::Command**](iagentnotifysink--command)を使用して入力/アクティブ クライアントに通知すると、[**IAgentUserInput**](/ja-jp/windows/desktop/lwef/iagentuserinput) オブジェクトを介して情報を返します。 **IAgentUserInput** は、アプリケーションがこれらの値に対してクエリを実行できるようにするインターフェイスを定義します。

Vtable Order **のメソッドを** する

| IAgentUserInput メソッド | 形容 |
| --- | --- |
| GetCount**[を](iagentuserinput--getcount)**する | [**Command**](command-event) イベントで返されるコマンド代替の数を返します。 |
| GetItemID**[を](iagentuserinput--getitemid)**する | 特定の [**Command**](command-event) 代替の ID を返します。 |
| GetItemConfidence**[の](iagentuserinput--getitemconfidence)** | 特定の [**Command**](command-event) 代替の [**信頼度**](confidence-property) プロパティの値を返します。 |
| GetItemText**[の](iagentuserinput--getitemtext)** | 特定の [**コマンドの代替 \[音声\](voice-property) テキストの値**](command-event) 返します。 |
| GetAllItemData**[を](iagentuserinput--getallitemdata)**する | すべての [**Command**](command-event) の代替のデータを返します。 |