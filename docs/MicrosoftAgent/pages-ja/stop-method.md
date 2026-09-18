---
layout: Conceptual
title: Stop メソッド (従来の Windows 環境機能) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/stop-method
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Stop メソッド
document_id: 61ea26df-ff61-b18a-b461-e66a990c124a
document_version_independent_id: 2ee4c980-2c93-2ec0-b83c-585ce769fe57
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/stop-method.md
locale: ja-jp
ms.assetid: 68372f72-db9c-447c-a3e4-488940c730d7
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/stop-method.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:01:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/stop-method.md
page_type: conceptual
toc_rel: toc.json
word_count: 481
asset_id: lwef/stop-method
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: df133574-6624-f430-2965-0def9a14319d
---

# Stop メソッド (従来の Windows 環境機能) - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 指定した文字のアニメーションを停止します。
- **構文の**
    - エージェント \*\* です。characters ("***CharacterID***")。Stop\*\* [*Request*]

| 部分 | 形容 |
| --- | --- |
| *要求* | 随意。 特定のアニメーション呼び出しを指定する [**Request**](/ja-jp/windows/desktop/lwef/the-request-object) オブジェクト。 |

## 備考

要求パラメーターを指定するには、変数を作成し、停止するアニメーション要求を割り当てる必要があります。 **Request** パラメーターを設定しない場合、サーバーはキューに登録された [**Get**](get-method) 呼び出しを含むキャラクターのすべてのアニメーションを停止し、そのアニメーション キューをクリアします。ただし、キャラクターが現在  の非表示または **表示** アニメーションを再生していない限り、そのアニメーション キューをクリアします。 このメソッドは、get **呼び出し** キューにない呼び出しを停止しません。

特定のアニメーションを停止するか、Get**[呼び出し](get-method)**するには、オブジェクト変数を宣言し、アニメーション要求をその変数に割り当てます。

```
   Dim MyRequest
   Dim Genie

   Agent1.Characters.Load "Genie", "https://agent.microsoft.com/characters/v2/genie/genie.acf"

   Set Genie = Agent1.Characters ("Genie")

   Genie.Get "state", "Showing"
   Genie.Get "animation", "Greet, GreetReturn"

   Genie.Show
   
   'This animation will never play
   Set MyRequest = Genie.Play ("Greet")
   
   Genie.Stop MyRequest
```

このメソッドは、[**Request**](/ja-jp/windows/desktop/lwef/the-request-object) オブジェクトを生成しません。