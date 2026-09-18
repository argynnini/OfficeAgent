---
layout: Conceptual
title: MoveTo メソッド - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/moveto-method
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: MoveTo メソッド
document_id: 0efe238f-ff75-cb64-f90f-1bfd59d89eaa
document_version_independent_id: 0eff35e9-d556-898e-bfd8-3b8ad3686f91
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/moveto-method.md
locale: ja-jp
ms.assetid: cca2b1b8-0d44-4272-9f0b-f7afd091d802
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/moveto-method.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:55:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/moveto-method.md
page_type: conceptual
toc_rel: toc.json
word_count: 698
asset_id: lwef/moveto-method
item_type: Content
platformId: 83a94700-3ec4-dbbc-bed0-c807d7291b6d
---

# MoveTo メソッド - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 指定した文字を指定した位置に移動します。
- **構文の**
    - エージェント \*\* です。characters ("***CharacterID***")。MoveTo\*\* *x,y*[*Speed*]

| 部分 | 形容 |
| --- | --- |
| x、y *を* する | 必須。 アニメーション フレームの左端 (*x*) と上端 (*y*) を示す整数値。 これらの座標をピクセル単位で表します。 |
| *速度* | 随意。 文字のフレームの移動速度をミリ秒単位で指定する Long 整数値。 既定値は 1000 です。 ゼロ (0) を指定すると、アニメーションを再生せずにフレームが移動します。 |

## 備考

サーバーは、**移動** 状態に割り当てられた適切なアニメーションを自動的に再生します。 文字の位置は、そのフレームの左上隅に基づいています。

オブジェクト変数を宣言してこのメソッドに設定すると、[**Request**](/ja-jp/windows/desktop/lwef/the-request-object) オブジェクトが返されます。 さらに、関連付けられているアニメーションがローカル コンピューターに読み込まれていない場合、サーバーは、**Request** オブジェクトの [**Status**](status-property) プロパティを適切なエラー番号で "failed" に設定します。 したがって、HTTP プロトコルを使用して文字またはアニメーション データにアクセスする場合は、[**Get**](get-method) メソッドを使用して、**MoveTo** メソッドを呼び出す前に、**Move** 状態アニメーションを読み込みます。

アニメーションが読み込まれていない場合でも、サーバーはフレームを移動します。

手記

**MoveTo** を 0 以外の値で呼び出すと、文字が表示されないときにアニメーションを再生しようとしていることが示されるため、[**Request**](/ja-jp/windows/desktop/lwef/the-request-object) オブジェクトを割り当てた場合、エラー状態が返されます。

手記

*Speed* パラメーターの実際の効果は、コンピューターのプロセッサの速度と、システムで実行されている他のタスクの優先順位によって異なる場合があります。