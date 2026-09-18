---
layout: Conceptual
title: IAgentNotifySinkEx ListeningState - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentnotifysinkex--listeningstate
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentNotifySinkEx ListeningState
document_id: e8c82ed3-eeb5-0d1f-0420-cd971fcf6dfc
document_version_independent_id: 4c60c0cd-15af-c75c-86ed-0dfa88c31e0c
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentnotifysinkex--listeningstate.md
locale: ja-jp
ms.assetid: e303b299-0dd0-419a-87a9-1490fe6cf54a
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentnotifysinkex--listeningstate.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:52:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-07-03T23:50:19.3460266Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentnotifysinkex--listeningstate.md
page_type: conceptual
toc_rel: toc.json
word_count: 774
asset_id: lwef/iagentnotifysinkex--listeningstate
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: bef775c4-ea21-9ab3-a90a-5619365d2c3d
---

# IAgentNotifySinkEx ListeningState - Win32 apps | Microsoft Learn

[Microsoft Agent は Windows 7 の時点で非推奨となり、後続のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT ListeningState(
   long dwCharacterID,  // character ID
   long bListening,     // listening mode state
   long dwCause         // cause  
);
```

リスニング モードが変更されたときにクライアント アプリケーションに通知します。

- 戻り値はありません。

- *dwCharacterID*
    - リスニング状態が変更された文字。
- *bListening*
    - リスニングモードの状態。 **True** はリスニング モードが開始されたことを示します。 **False**はリスニング モードが終了したことを示します。
- *dwCause*
    - イベントの原因。次のいずれかの値になります。

| 値 | 説明 |
| --- | --- |
| **定数符号なしロング** **LSCOMPLETE\_CAUSE\_PROGRAMDISABLED = 1;** | プログラム コードによってリスニング モードがオフになりました。 |
| **定数符号なしロング** **LSCOMPLETE\_CAUSE\_PROGRAMTIMEDOUT = 2;** | リスニング モード (プログラム コードによってオン) がタイムアウトしました。 |
| **定数符号なしロング** **LSCOMPLETE\_CAUSE\_USERTIMEDOUT = 3;** | リスニング モード (リスニング キーによってオン) がタイムアウトしました。 |
| **定数符号なしロング** **LSCOMPLETE\_CAUSE\_USERRELEASEDKEY = 4;** | ユーザーがリスニング キーを放したため、リスニング モードがオフになりました。 |
| **定数符号なしロング** **LSCOMPLETE\_CAUSE\_USERUTTERANCEENDED = 5;** | ユーザーが話し終えたため、リスニング モードはオフになりました。 |
| **定数符号なしロング** **LSCOMPLETE\_CAUSE\_CLIENTDEACTIVATED = 6;** | 入力アクティブ クライアントが非アクティブ化されたため、リスニング モードがオフになりました。 |
| **定数符号なしロング** **LSCOMPLETE\_CAUSE\_DEFAULTCHARCHANGE = 7** | デフォルトの文字が変更されたため、リスニング モードがオフになりました。 |
| **定数符号なしロング** **LSCOMPLETE\_CAUSE\_USERDISABLED = 8** | ユーザーが音声入力を無効にしたため、リスニング モードがオフになりました。 |

このイベントは、ユーザーがリスニング キーを押した後、またはそのタイムアウトが終了した後にリスニング モードが開始されたとき、または入力アクティブ クライアントが [**IAgentCharacterEx::Listen**](iagentcharacterex--listen) メソッドを **True** または **False** で呼び出したときに、すべてのクライアントに送信されます。

このイベントは、現在この文字がロードされているクライアントに値を返します。 他のすべてのクライアントは null 文字 (空の文字列) を受け取ります。