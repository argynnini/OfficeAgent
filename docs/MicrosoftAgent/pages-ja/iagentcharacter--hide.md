---
layout: Conceptual
title: IAgentCharacter Hide - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcharacter--hide
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCharacter Hide
document_id: 7e6324f4-884d-9cf1-4635-ca26494df38a
document_version_independent_id: 56afcdcf-d987-9381-5983-f8f084383ddd
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacter--hide.md
locale: ja-jp
ms.assetid: a8128fe8-9a3b-41a3-bfe3-82ace1baff6f
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacter--hide.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:46:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcharacter--hide.md
page_type: conceptual
toc_rel: toc.json
word_count: 574
asset_id: lwef/iagentcharacter--hide
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: faac1ec1-2b3f-93cc-a561-f29175d19956
---

# IAgentCharacter Hide - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT Hide(
   long bFast,      // play Hiding state animation flag
   long * pdwReqID  // address of request ID
);
```

文字を非表示にします。

- 操作が成功したことを示すS\_OKを返します。 関数から制御が戻ると、pdwReqID  要求の ID が格納されます。

- bFast*を * する
    - **状態アニメーション フラグ** 非表示にします。 このパラメーターが True 場合、**非表示** アニメーションは、文字フレームが非表示になるまで再生されません。False 場合、アニメーションが再生されます。
- pdwReqID*を * する
    - **Hide** 要求 ID を受け取る変数のアドレス。

サーバーは、キャラクターのキュー内の **Hide** メソッドに関連付けられているアニメーションをキューに入れます。 これを使用すると、他のアニメーションのシーケンスの後に文字を非表示にすることができます。 **Hide メソッドを呼び出す前に、[Stop](iagentcharacter--stop) メソッドを使用してアクションをすぐに再生**。

HTTP プロトコルを使用して文字とアニメーションのデータにアクセスする場合は、[**Prepare**](/ja-jp/windows/desktop/lwef/iagentcharacter--prepare) メソッドを使用して、このメソッドを呼び出す前に **の非表示** 状態アニメーションを使用できるようにします。

文字を非表示にすると、別の表示可能な文字の [**IAgentNotifySink::ActivateInputState**](iagentnotifysink--activateinputstate) イベントがトリガーされる場合もあります。

非表示の文字は、オーディオ チャネルにアクセスできません。 アニメーション要求を生成し、キャラクターが非表示の場合、サーバーは [**RequestComplete**](iagentnotifysink--requestcomplete) イベントでエラー状態を返します。