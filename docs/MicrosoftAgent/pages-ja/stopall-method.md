---
layout: Conceptual
title: StopAll メソッド - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/stopall-method
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: StopAll メソッド
document_id: d97efe7e-20a6-c8ff-3cf0-e2178a074ca7
document_version_independent_id: c84b3ebc-99d3-289f-d153-2e6ddbd7cb0b
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/stopall-method.md
locale: ja-jp
ms.assetid: 2ce32ff8-4908-45b1-9b83-4d558f67417c
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/stopall-method.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:01:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/stopall-method.md
page_type: conceptual
toc_rel: toc.json
word_count: 487
asset_id: lwef/stopall-method
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: ae3296b0-23d3-06f7-d057-ff36a87188a7
---

# StopAll メソッド - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

- **Description**
    - 指定した文字のすべてのアニメーション要求または指定した種類の要求を停止します。
- **構文**
    - *agent*\*\*。文字 ("***CharacterID***")。StopAll\*\* [*Type*]

| パーツ | 説明 |
| --- | --- |
| *Type* | 省略可能。 このパラメーターを使用するには、次のいずれかの値を使用できます。 複数の型をコンマで区切って指定することもできます。  "**Get**" キューに登録されているすべての [**Get**](get-method) 要求を停止します。 "**NonQueuedGet**" キューに登録されていない [**Get**](get-method) 要求をすべて停止するには (**Queue** パラメーターを **False** に設定した **Get** メソッド)。 "**移動**" キューに登録されているすべての [**MoveTo**](moveto-method) 要求を停止します。 "**再生**" キューに登録されているすべての [**Play**](play-method) 要求を停止します。 "**Speak**" キューに登録されているすべての [**Speak**](speak-method) 要求を停止します。 |

## 解説

**Type** パラメーターを設定しない場合、サーバーは、キューに入っている Get 要求とキューに入っていない [**Get**](get-method) 要求を含む文字のすべてのアニメーションを停止し、そのアニメーション キューをクリアします。 また、キャラクターの [非表示] または [アニメーションの表示] の再生も停止します。

このメソッドは [**Request**](/ja-jp/windows/desktop/lwef/the-request-object) オブジェクトを生成しません。