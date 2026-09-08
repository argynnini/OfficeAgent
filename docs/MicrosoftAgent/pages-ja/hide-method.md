---
layout: Conceptual
title: Hide メソッド - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/hide-method
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Hide メソッド
document_id: e7d201c8-b4c3-69f1-f8d4-47e7e7ed0335
document_version_independent_id: 000acc47-fe39-8828-8031-1104124845a3
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/hide-method.md
locale: ja-jp
ms.assetid: c30eda78-0951-43b4-8ae1-daccbd41170d
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/hide-method.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:44:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/hide-method.md
page_type: conceptual
toc_rel: toc.json
word_count: 652
asset_id: lwef/hide-method
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: ec6260bb-cfd7-3994-8b92-7e2c891fd91b
---

# Hide メソッド - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 指定した文字を非表示にします。
- **構文の**
    - エージェント \*\* です。characters ("***CharacterID***")。Hide\*\* [*Fast*]

| 部分 | 形容 |
| --- | --- |
| 高速 *を* する | 随意。 文字の非表示状態に関連付けられているアニメーションをスキップするかどうかを示すブール値 **True** **非表示** アニメーションを再生しません。 **False** (既定値) **非表示** アニメーションを再生します。 |

## 備考

サーバーは、**Hide** メソッドのアクションをキャラクターのキューに入れるので、これを使用して、他のアニメーションのシーケンスの後に文字を非表示にすることができます。 このメソッドを呼び出す前に、[**Stop**](stop-method) メソッドを使用してアクションをすぐに再生できます。

オブジェクト参照を宣言してこのメソッドに設定すると、[**Request**](/ja-jp/windows/desktop/lwef/the-request-object) オブジェクトが返されます。 さらに、関連付けられた **非表示** アニメーションが読み込まれず、**高速** パラメーターを **true**として指定していない場合、サーバーは、**Request** オブジェクト [**Status**](status-property) プロパティを適切なエラー番号で "failed" に設定します。 したがって、HTTP プロトコルを使用して文字またはアニメーション データにアクセスする場合は、[**Get**](get-method) メソッドを使用し、**Hide** メソッドを呼び出す前にアニメーションを読み込むための **非表示** 状態を指定します。

文字を非表示にすると、別のクライアントの [**ActivateInput**](activateinput-event) イベントがトリガーされる場合もあります。

手記

非表示の文字は、オーディオ チャネルにアクセスできません。 アニメーション要求を生成し、キャラクターが非表示の場合、サーバーは [**RequestComplete**](requestcomplete-event) イベントでエラー状態を返します。