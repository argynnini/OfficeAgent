---
layout: Conceptual
title: GestureAt メソッド - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/gestureat-method
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: GestureAt メソッド
document_id: 52f22719-04a7-40ff-4964-8a84841c465f
document_version_independent_id: 7974dbf5-25cf-c010-58eb-a2f70b9026f2
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/gestureat-method.md
locale: ja-jp
ms.assetid: c84e9363-e905-476a-832b-9acf6ddee5f1
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/gestureat-method.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:43:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/gestureat-method.md
page_type: conceptual
toc_rel: toc.json
word_count: 456
asset_id: lwef/gestureat-method
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 83975e0e-adec-ac4b-a6a2-cacf95962c76
---

# GestureAt メソッド - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 指定した位置にある指定した文字のゲスチャリング アニメーションを再生します。
- **構文の**
    - エージェント \*\* です。characters ("***CharacterID***")。GestureAt\*\* *x,y*

| 部分 | 形容 |
| --- | --- |
| x、y *を* する | 必須。 文字がジェスチャを行う水平 (*x*) 画面座標と垂直 (*y*) 画面座標を示す整数値。 これらの座標はピクセル単位で指定する必要があります。 |

## 備考

サーバーは、指定した場所に向かってジェスチャする適切なアニメーションを自動的に再生します。 座標は常に画面の原点 (左上) に対して相対的です。

オブジェクト参照を宣言してこのメソッドに設定すると、[**Request**](/ja-jp/windows/desktop/lwef/the-request-object) オブジェクトが返されます。 さらに、関連付けられているアニメーションがローカル コンピューターに読み込まれていない場合、サーバーは、**Request** オブジェクトの [**Status**](status-property) プロパティを適切なエラー番号で "failed" に設定します。 したがって、HTTP プロトコルを使用して文字アニメーション データにアクセスする場合は、[**Get**](get-method) メソッドを使用して、**GestureAt** メソッドを呼び出す前に、**Gesturing** 状態アニメーションを読み込みます。