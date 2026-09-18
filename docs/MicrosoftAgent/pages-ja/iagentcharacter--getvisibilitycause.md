---
layout: Conceptual
title: IAgentCharacter GetVisibilityCause - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcharacter--getvisibilitycause
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCharacter GetVisibilityCause
document_id: 49f1b6bf-f4f5-517e-b1c2-c47a41228b5f
document_version_independent_id: aceddea4-5d65-7a9a-3c36-51d0b12d49c1
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacter--getvisibilitycause.md
locale: ja-jp
ms.assetid: 46f681de-1c99-4f90-a3fe-aae04bb75339
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacter--getvisibilitycause.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:46:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-07-03T23:50:19.3460266Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcharacter--getvisibilitycause.md
page_type: conceptual
toc_rel: toc.json
word_count: 499
asset_id: lwef/iagentcharacter--getvisibilitycause
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 0aac813d-1893-67bc-2c73-8e13b1c9e36c
---

# IAgentCharacter GetVisibilityCause - Win32 apps | Microsoft Learn

[Microsoft Agent は Windows 7 の時点で非推奨となり、後続のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT GetVisibilityCause(
   long * pdwCause  // address of variable for cause of character visible state
);
```

キャラクターの表示状態の原因を取得します。

- 操作が成功したことを示す S\_OK を返します。

- *pdwCause*
    - キャラクターの最後の表示状態の変化の原因を受け取り、次のいずれかになる変数のアドレス。

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