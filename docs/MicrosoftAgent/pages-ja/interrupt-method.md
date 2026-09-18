---
layout: Conceptual
title: 割り込みメソッド - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/interrupt-method
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: 割り込みメソッド
document_id: 306503d3-fbb9-c2af-6cca-4d17579c1e03
document_version_independent_id: 75c6d0c3-538a-502a-ae12-5eb73c7c2ead
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/interrupt-method.md
locale: ja-jp
ms.assetid: b8442e25-a629-47c7-acdd-1d28e74d78a2
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/interrupt-method.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:54:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/interrupt-method.md
page_type: conceptual
toc_rel: toc.json
word_count: 666
asset_id: lwef/interrupt-method
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/0850fefd-e402-4507-ae98-46cfdfc2e16c
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/6ecf98a5-97c7-4249-b209-a9d9e42633a0
platformId: 1763369d-0b6a-b233-aff2-7ca0b3f3ae84
---

# 割り込みメソッド - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 指定した文字のアニメーションを中断します。
- **構文の**
    - エージェント \*\* です。characters ("***CharacterID***")。割り込み\*\* *要求*

| 部分 | 形容 |
| --- | --- |
| *要求* | 特定のアニメーション呼び出しの [**Request**](/ja-jp/windows/desktop/lwef/the-request-object) オブジェクト。 |

## 備考

これを使用して、キャラクター間でアニメーションを同期できます。 たとえば、別の文字がループ アニメーション内にある場合、このメソッドはループを停止し、キャラクターのキュー内の次のアニメーションに移動します。 使用していない (読み込まれていない) 文字アニメーションを中断することはできません。

要求パラメーターを指定するには、変数を作成し、割り込むアニメーション要求を割り当てる必要があります。

```
   Dim GenieRequest as Object
   Dim RobbyRequest as Object
   Dim Genie as Object
   Dim Robby as Object

   Sub FormLoad()

      MyAgent1.Characters.Load "Genie", "Genie.acs"

      MyAgent1.Characters.Load "Robby", "Robby.acs"

      Set Genie = MyAgent1.Characters ("Genie")
      Set Robby = MyAgent1.Characters ("Robby")

      Genie.Show

      Genie.Speak "Just a moment"

      Set GenieRequest = Genie.Play ("Processing")

      Robby.Show
      Robby.Play "confused"
      Robby.Speak "Hey, Genie. What are you doing?"
      Robby.Interrupt GenieRequest

      Genie.Speak "I was just checking on something."

   End Sub
```

サーバーは **割り込み** メソッドをその文字のアニメーション キューにキューに入れるので、このメソッドで指定したのと同じ文字のアニメーションを中断することはできません。 そのため、**割り込み** を使用して、読み込んだ別のキャラクターのアニメーションを停止することしかできません。

オブジェクト参照を宣言してこのメソッドに設定すると、[**Request**](/ja-jp/windows/desktop/lwef/the-request-object) オブジェクトが返されます。

手記

**割り込み** は文字のキューをフラッシュしません。既存のアニメーションを停止し、キャラクターのキュー内の次のアニメーションに移動します。 文字のキューを停止してフラッシュするには、[**Stop**](stop-method) メソッドを使用します。