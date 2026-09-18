---
layout: Conceptual
title: IAgentCharacter Prepare - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcharacter--prepare
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCharacter Prepare
document_id: 7400979b-3aa0-0c88-9d72-e70a37ffa364
document_version_independent_id: 6b858a57-3526-e7a4-b8a7-ee6b33fe6acb
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacter--prepare.md
locale: ja-jp
ms.assetid: e016039f-a0b1-4ae9-bff6-7212b02c1ad8
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacter--prepare.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:47:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-07-03T23:50:19.3460266Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcharacter--prepare.md
page_type: conceptual
toc_rel: toc.json
word_count: 1366
asset_id: lwef/iagentcharacter--prepare
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: eda8c4b0-1455-437d-9e80-eb0bb2e586c7
---

# IAgentCharacter Prepare - Win32 apps | Microsoft Learn

[Microsoft Agent は Windows 7 の時点で非推奨となり、後続のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT Prepare(
   long dwType,     // type of animation data to load
   BSTR bszName,    // name of the animation 
   long bQueue,     // queue the request
   long * pdwReqID  // address of request ID
);
```

キャラクターのアニメーション データを取得します。

- 操作が成功したことを示す S\_OK を返します。 関数で返すときに、*pdwReqID* には要求の ID が含まれます。

- *dwType*
    - 読み込むアニメーション データ型を示す値。次のいずれかである必要があります。

| 値 | 説明 |
| --- | --- |
| **const unsigned short** **PREPARE\_ANIMATION = 0;** | キャラクターのアニメーション データ。 |
| **const unsigned short** **PREPARE\_STATE = 1;** | キャラクターの状態データ。 |
| **const unsigned short** **PREPARE\_WAVE = 2** | 読み上げられる出力用のキャラクターのサウンド ファイル (.WAV または .LWV)。 |
- *bszName*
    - アニメーションまたは状態の名前。

アニメーション名は、Microsoft エージェント キャラクター エディターを使用して保存したときに、そのキャラクターに対して定義された名前に基づいています。

状態の場合、値は次のいずれかになります。

| - | 説明 |
| --- | --- |
| **"Gesturing"** | すべての **Gesturing** 状態アニメーションを取得します。 |
| **"GesturingDown"** | **GesturingDown** アニメーションを取得します。 |
| **"GesturingLeft"** | **GesturingLeft** アニメーションを取得します。 |
| **"GesturingRight"** | **GesturingRight** アニメーションを取得します。 |
| **"GesturingUp"** | **GesturingUp** アニメーションを取得します。 |
| **"Hiding"** | **Hiding** 状態アニメーションを取得します。 |
| **"Hearing"** | **Hearing** 状態アニメーションを取得します。 |
| **"Idling"** | すべての **Idling** 状態アニメーションを取得します。 |
| **"IdlingLevel1"** | すべての **IdlingLevel1** アニメーションを取得します。 |
| **"IdlingLevel2"** | すべての **IdlingLevel2** アニメーションを取得します。 |
| **"IdlingLevel3"** | すべての **IdlingLevel3** アニメーションを取得します。 |
| **"Listening"** | **Listening** 状態アニメーションを取得します。 |
| **"Moving"** | すべての **Moving** 状態アニメーションを取得します。 |
| **"MovingDown"** | すべての **Moving** アニメーションを取得します。 |
| **"MovingLeft"** | すべての **MovingLeft** アニメーションを取得します。 |
| **"MovingRight"** | すべての **MovingRight** アニメーションを取得します。 |
| **"MovingUp"** | すべての **MovingUp** アニメーションを取得します。 |
| **"Showing"** | **Showing** 状態アニメーションを取得します。 |
| **"Speaking"** | **Speaking** 状態アニメーションを取得します。 |

.WAV ファイルの場合は、.WAV ファイルの URL またはファイル指定に *bszName* を設定します。 指定が完全でない場合は、[**Load**](https://www.bing.com/search?q=**Load**) メソッドで使用される仕様に対して相対的であると解釈されます。
- *bQueue*
    - サーバーが [**Prepare**](/ja-jp/windows/desktop/lwef/iagentcharacter--prepare) 要求をキューに入れるかどうかを指定するブール値。 **True** は要求をキューに格納し、その後に続くアニメーション要求は、指定したアニメーション データが読み込まれるまで待機します。 **False** はアニメーション データを非同期的に取得します。
- *pdwReqID*
    - [**Prepare**](/ja-jp/windows/desktop/lwef/iagentcharacter--prepare)要求 ID を受け取る変数のアドレス。

HTTP プロトコル (.ACF ファイル) を使用してキャラクターを読み込む場合、アニメーションを再生する前に、[**Prepare**](/ja-jp/windows/desktop/lwef/iagentcharacter--prepare) メソッドを使用してアニメーション データを取得する必要があります。 UNC プロトコル (.ACS ファイル) を使用してキャラクターを読み込んだ場合は、このメソッドを使用できません。 UNC プロトコル (.ACS キャラクターファイル) を使用してキャラクターを読み込んだ場合、**Prepare** を使用してキャラクターの HTTP データを取得することもできません。

[**Prepare**](/ja-jp/windows/desktop/lwef/iagentcharacter--prepare) メソッドを使用して取得したアニメーションまたはサウンド データは、ブラウザーのキャッシュに格納されます。 後続の呼び出しではキャッシュがチェックされ、アニメーション データが既に存在する場合、コントロールはキャッシュから直接データを読み込みます。 読み込まれたアニメーションまたはサウンド データは、[**Play**](/ja-jp/windows/desktop/lwef/iagentcharacter--play) メソッドまたは [**Speak**](/ja-jp/windows/desktop/lwef/iagentcharacter--speak) メソッドで再生できます。

アニメーションと状態が複数ある場合は、カンマで区切って指定できます。 ただし、同じ [**Prepare**](/ja-jp/windows/desktop/lwef/iagentcharacter--prepare) ステートメントに型を混在させることはできません。