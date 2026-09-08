---
layout: Conceptual
title: Get メソッド - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/get-method
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Get メソッド
document_id: 567df11d-44ac-e95a-49f9-232daed8a8d9
document_version_independent_id: 6106f217-20d7-7cd4-ac78-9d061275a915
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/get-method.md
locale: ja-jp
ms.assetid: 749566ba-d29d-4c20-b90a-adb4a4dd333d
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/get-method.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:43:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-07-03T23:50:19.3460266Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/get-method.md
page_type: conceptual
toc_rel: toc.json
word_count: 1464
asset_id: lwef/get-method
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 50195d1d-4166-0fe1-cd1f-7f4ebff58222
---

# Get メソッド - Win32 apps | Microsoft Learn

[Microsoft Agent は Windows 7 の時点で非推奨となり、後続のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 指定したキャラクターの指定したアニメーション データを取得します。
- **構文**
    - *agent*\*\*.Characters ("***CharacterID***").Get\*\* *Type*, *Name*, [*Queue*]

| 部分 | 説明 |
| --- | --- |
| *Type* | 必須。 読み込むアニメーション データ型を示す文字列値。 "**Animation**" キャラクターのアニメーション データ。  "**State**" キャラクターの状態データ。  "**WaveFile**" キャラクターのオーディオ (音声出力用) ファイル。 |
| *名前* | 必須。 アニメーション タイプの名前を表す文字列。 "**name**" アニメーションまたは状態の名前。  アニメーションの場合、名前は、Microsoft エージェント キャラクター エディターを使用して保存するときに、そのキャラクターに対して定義された名前に基づいています。  状態では次の値を使用できます。 "**Gesturing**" すべての **Gesturing** 状態アニメーションを取得します。 "**GesturingDown**" **GesturingDown** アニメーションを取得します。 "**GesturingLeft**" **GesturingLeft** アニメーションを取得します。 "**GesturingRight**" **GesturingRight** アニメーションを取得します。 "**GesturingUp**" **GesturingUp** アニメーションを取得します。 "**Hiding**" **Hiding** 状態アニメーションを取得します。 "**Hearing**" **Hearing** 状態アニメーションを取得します。 "**Idling**" すべての **Idling** 状態アニメーションを取得します。 "**IdlingLevel1**" すべての **IdlingLevel1** アニメーションを取得します。 "**IdlingLevel2**" すべての **IdlingLevel2** アニメーションを取得します。 "**IdlingLevel3**" すべての **IdlingLevel3** アニメーションを取得します。 "**Listening**" **Listening** 状態アニメーションを取得します。 "**Moving**" すべての **Moving** 状態アニメーションを取得します。 "**MovingDown**" **MovingDown** アニメーションを取得します。 "**MovingLeft**" **MovingLeft** アニメーションを取得します。 "**MovingRight**" **MovingRight** アニメーションを取得します。 "**MovingUp**" **MovingUp** アニメーションを取得します。 "**Showing**" **Showing** 状態アニメーションを取得します。 "**Speaking**" **Speaking** 状態アニメーションを取得します。 アニメーションと状態が複数ある場合は、カンマで区切って指定できます。 ただし、同じ **Get** ステートメントに型を混在させることはできません。 "*URL or* *filespec*" サウンド (.WAV または .LWV) ファイルの仕様。 指定が完全でない場合は、[**Load**](load-method) メソッドで使用される仕様に対して相対的であると解釈されます。 |
| *キュー* | 省略可能。 サーバーが **Get** 要求をキューに入れるかどうかを指定するブール式。 **True** (デフォルト) では **Get** 要求がキューに入れられます。 **Get** 要求 (同じキャラクター) に続くアニメーション要求は、アニメーション データが読み込まれるまで待機します。**False** では **Get** 要求がキューに入れられません。 |

## 解説

HTTP プロトコル (.ACF ファイル) を使用してキャラクターを読み込む場合、アニメーションを再生する前に、**Get** メソッドを使用してアニメーション データを取得する必要があります。 UNC プロトコル (.ACS ファイル) を使用してキャラクターを読み込んだ場合は、このメソッドを使用しません。 UNC プロトコル (.ACS キャラクターファイル) を使用してキャラクターを読み込んだ場合、**Get** を使用してキャラクターの HTTP データを取得することもできません。

オブジェクト参照を宣言してこのメソッドに設定すると、[**Request**](/ja-jp/windows/desktop/lwef/the-request-object) オブジェクトが返されます。 関連付けられたアニメーションの読み込みに失敗した場合、サーバーは **Request** オブジェクトの [**Status**](status-property) プロパティを適切なエラー番号で "failed" に設定します。 [**RequestComplete**](requestcomplete-event) イベントを使用してステータスを確認し、実行するアクションを決定できます。

**Get** メソッドを使用して取得したアニメーションまたはサウンド データは、ブラウザーのキャッシュに格納されます。 後続の呼び出しではキャッシュがチェックされ、アニメーション データが既に存在する場合、コントロールはキャッシュから直接データを読み込みます。 読み込まれたアニメーションまたはサウンド データは、[**Play**](play-method) メソッドまたは [**Speak**](speak-method) メソッドで再生できます。