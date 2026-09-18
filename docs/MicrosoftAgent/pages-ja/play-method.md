---
layout: Conceptual
title: Play メソッド (従来の Windows 環境機能) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/play-method
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Play メソッド
document_id: 3c36f622-ee7a-7a79-cce0-92a5bbde959d
document_version_independent_id: 0a26abe3-7d95-75f0-d2cb-5ca7c1a23820
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/play-method.md
locale: ja-jp
ms.assetid: 7e89341a-b4d3-4bea-8e7f-31c649ff06b3
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/play-method.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:58:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/play-method.md
page_type: conceptual
toc_rel: toc.json
word_count: 785
asset_id: lwef/play-method
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 64b605cc-5804-ed42-3588-85e86dad98c2
---

# Play メソッド (従来の Windows 環境機能) - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 指定した文字の指定したアニメーションを再生します。
- **構文の**
    - エージェント \*\* です。characters ("***CharacterID***")。Play\*\* "*AnimationName*"

| 部分 | 形容 |
| --- | --- |
| *AnimationName* | 必須。 アニメーション シーケンスの名前を指定する文字列。 |

## 備考

アニメーションの名前は、文字が Microsoft エージェント文字エディターでコンパイルされるときに定義されます。 指定したアニメーションを再生する前に、サーバーは前のアニメーションに対して **Return** アニメーションを再生しようとします (割り当てられている場合)。

従来のファイル プロトコルを使用してキャラクターのアニメーションにアクセスする場合は、アニメーションの名前を指定する **Play** メソッドを使用するだけです。 ただし、HTTP プロトコルを使用して文字アニメーション データにアクセスする場合は、**Play** メソッドを呼び出す前に、**Get** メソッドを使用してアニメーションを読み込みます。

詳細については、「**Get** メソッド」を参照してください。

構文を簡略化するために、オブジェクト参照を宣言し、[**Characters**](/ja-jp/windows/desktop/lwef/the-characters-object) コレクション内の [**Character**](/ja-jp/windows/desktop/lwef/the-characters-object) オブジェクトを参照するように設定し、**Play** ステートメントの一部として参照を使用できます。

```
   Dim Genie   
   Agent1.Characters.Load "Genie", "https://agent.microsoft.com/characters/v2/genie/genie.acf"

   Set Genie = Agent1.Characters ("Genie")
   
   Genie.Get "state", "Showing"
   Genie.Show

   Genie.Get "animation", "Greet, GreetReturn"
   Genie.Play "Greet"
   Genie.Speak "Hello."
```

オブジェクト参照を宣言してこのメソッドに設定すると、[**Request**](/ja-jp/windows/desktop/lwef/the-request-object) オブジェクトが返されます。 また、読み込まれていないアニメーションを指定した場合、または文字が正常に読み込まれていない場合、サーバーは、**Request** オブジェクトの [**Status**](status-property) プロパティを適切なエラー番号で "failed" に設定します。 ただし、アニメーションが存在せず、キャラクターのデータが既に正常に読み込まれている場合、サーバーはエラーを発生させます。

**Play** メソッドでは、文字が表示されません。 文字が表示されない場合、サーバーはアニメーションを目に見えない状態で再生し、[**Request**](/ja-jp/windows/desktop/lwef/the-request-object) オブジェクトの [**Status**](status-property) プロパティを設定します。