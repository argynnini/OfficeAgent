---
layout: Conceptual
title: Show メソッド - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/show-method
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Show メソッド
document_id: 604f17e9-f883-ebaa-366c-640fc2266ce7
document_version_independent_id: 3d242798-7104-d285-59ef-beb542f86592
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/show-method.md
locale: ja-jp
ms.assetid: 58adbb55-f4cb-4356-abc4-b85fa3af744d
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/show-method.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:00:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/show-method.md
page_type: conceptual
toc_rel: toc.json
word_count: 605
asset_id: lwef/show-method
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: f813a384-2c19-36b2-c65a-707ea8035c21
---

# Show メソッド - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

- **Description**
    - 指定した文字を表示し、関連する **アニメーションの表示** を再生します。
- **構文**
    - *agent*\*\*。文字 ("***CharacterID***")。Show\*\* [*Fast*]

| パーツ | Description |
| --- | --- |
| *[高速]* | 省略可能。 サーバーが **表示** アニメーションを再生するかどうかを指定するブール式。 **True** **[状態の表示**] アニメーションをスキップします。 **False** (既定値) 状態の **表示** アニメーションをスキップしません。 |

## 解説

オブジェクト参照を宣言し、このメソッドに設定すると、 [**Request**](/ja-jp/windows/desktop/lwef/the-request-object) オブジェクトが返されます。 さらに、関連する **Showing** アニメーションが読み込まれず、 **Fast** パラメーターを **True** に指定していない場合、サーバーは **Request** オブジェクトの [**Status**](status-property) プロパティを適切なエラー番号で "failed" に設定します。 したがって、HTTP プロトコルを使用して文字アニメーション データにアクセスする場合は、**Show** メソッドを呼び出す前に [**Get**](get-method) メソッドを使用して **Show** 状態アニメーションを読み込みます。

最初にアニメーションを事前に再生せずに **、Fast** パラメーターを **True** に設定しないでください。それ以外の場合は、文字フレームが画像なしで表示される場合があります。 特に、文字が表示されていないときに [**MoveTo を**](moveto-method) 呼び出すと、アニメーションは再生されないことに注意してください。 したがって、**Fast** を **True** に設定して **Show** メソッドを呼び出すと、画像は表示されません。 同様に、[[**非表示\]**](hide-method) を呼び出し、[**高速**] を **True** に設定して **[表示**] を呼び出すと、表示される画像は表示されません。