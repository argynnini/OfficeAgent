---
layout: Conceptual
title: IAgentCharacter Show - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcharacter--show
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCharacter Show
document_id: fb75561c-cc3a-5050-8cc8-033365d9bd75
document_version_independent_id: 0ab79923-241a-2887-f02a-e36750ef8608
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacter--show.md
locale: ja-jp
ms.assetid: 5f13dcef-3777-41eb-827f-6162bad71a2e
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacter--show.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:47:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcharacter--show.md
page_type: conceptual
toc_rel: toc.json
word_count: 526
asset_id: lwef/iagentcharacter--show
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: f23922e6-0c7c-9104-6af0-3a198a64041d
---

# IAgentCharacter Show - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

```syntax
HRESULT Show(
   long bFast,      // play Showing state animation flag
   long * pdwReqID  // address of request ID
);
```

文字を表示します。

- 操作が成功したことを示すS\_OKを返します。 関数が戻ると、 *pdwReqID* には要求の ID が含まれます。

- *bFast*
    - 状態アニメーション フラグを表示しています。 このパラメーターが **True の**場合、 **表示** 状態のアニメーションは、文字を表示した後に再生されます。 **False の**場合、アニメーションは再生されません。
- *pdwReqID*
    - 要求 ID の [**表示**](/ja-jp/windows/desktop/lwef/iagentcharacter--show) を受け取る変数のアドレス。

事前にアニメーションを再生せずに *bFast* パラメーターを **True** に設定しないでください。それ以外の場合は、文字フレームが表示される可能性がありますが、表示するイメージはありません。 特に、文字が表示されていないときに [**MoveTo**](iagentcharacter--moveto) を呼び出すと、アニメーションは再生されないことに注意してください。 したがって、*bFast* を **True** に設定して **Show** メソッドを呼び出すと、イメージは表示されません。 同様に、[**Hide**](/ja-jp/windows/desktop/lwef/iagentcharacter--hide) を呼び出し、*bFast* を **True** に設定して**表示**すると、表示されるイメージは表示されません。

HTTP プロトコルを使用して文字とアニメーションのデータにアクセスする場合は、 [**Prepare**](/ja-jp/windows/desktop/lwef/iagentcharacter--prepare) メソッドを使用して、このメソッドを呼び出す前に **Showing** state アニメーションを使用できることを確認します。