---
layout: Conceptual
title: IAgentNotifySink VisibleState - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentnotifysink--visiblestate
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentNotifySink VisibleState
document_id: e212675c-06df-a0d9-1df1-f008b6ed84fa
document_version_independent_id: 9d75493a-9002-c613-7e72-e8d20d61f8de
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentnotifysink--visiblestate.md
locale: ja-jp
ms.assetid: b0346296-74e9-448f-aa6d-a9fb1e645f05
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentnotifysink--visiblestate.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:52:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-07-03T23:50:19.3460266Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentnotifysink--visiblestate.md
page_type: conceptual
toc_rel: toc.json
word_count: 595
asset_id: lwef/iagentnotifysink--visiblestate
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: f67838d7-0217-ef58-2bed-af18e9651d1d
---

# IAgentNotifySink VisibleState - Win32 apps | Microsoft Learn

[Microsoft Agent は Windows 7 の時点で非推奨となり、後続のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT VisibleState(
   long dwCharID,  // character ID
   long bVisible,  // visibility flag
   long dwCause,   // cause of visible state
);                          
```

キャラクターの表示状態が変更されたときにクライアント アプリケーションに通知します。

- 戻り値はありません。

- *dwCharID*
    - 表示状態が変更されたキャラクターの識別子。
- *bVisible*
    - 表示フラグ。 このブール値はキャラクターが表示されたときに **True** になり、キャラクターが非表示になったときに **False** になります。
- *dwCause*
    - キャラクターの表示状態が最後に変更された原因。 パラメーターは次のいずれかになります。

| 値 | 説明 |
| --- | --- |
| **const unsigned short** **NeverShown = 0;** | キャラクターが表示されていません。 |
| **const unsigned short** **UserHid = 1;** | ユーザーは、キャラクターのタスク バー アイコンのポップアップ メニューまたは音声入力を使用してキャラクターを非表示にしました。 |
| **const unsigned short** **UserShowed = 2;** | ユーザーがキャラクターを表示しました。 |
| **const unsigned short** **ProgramHid = 3;** | アプリケーションがキャラクターを非表示にしました。 |
| **const unsigned short** **ProgramShowed = 4;** | アプリケーションがキャラクターを表示しました。 |
| **const unsigned short** **OtherProgramHid = 5;** | 別のアプリケーションがキャラクターを非表示にしました。 |
| **const unsigned short** **OtherProgramShowed = 6;** | 別のアプリケーションがキャラクターを表示しました。 |
| **const unsigned short** **UserHidViaCharacterMenu = 7** | ユーザーがキャラクターのポップアップ メニューでキャラクターを非表示にしました。 |
| **const unsigned short** **UserHidViaTaskbarIcon = UserHid** | ユーザーは、キャラクターのタスク バー アイコンのポップアップ メニューまたは音声入力を使用してキャラクターを非表示にしました。 |