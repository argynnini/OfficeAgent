---
layout: Conceptual
title: IAgentCharacter GetMoveCause - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcharacter--getmovecause
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCharacter GetMoveCause
document_id: 7ed3fd73-4ebc-1ba7-872a-af31325a7a7a
document_version_independent_id: 06d25392-6030-af4a-ea5f-1d15a367c9d8
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacter--getmovecause.md
locale: ja-jp
ms.assetid: 36cdd3bc-65b6-469f-9344-93403c1d24e0
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacter--getmovecause.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:46:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-07-03T23:50:19.3460266Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcharacter--getmovecause.md
page_type: conceptual
toc_rel: toc.json
word_count: 304
asset_id: lwef/iagentcharacter--getmovecause
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: bc124128-8a22-8582-a526-02e345bdb232
---

# IAgentCharacter GetMoveCause - Win32 apps | Microsoft Learn

[Microsoft Agent は Windows 7 の時点で非推奨となり、後続のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT GetMoveCause(
   long * pdwCause  // address of variable for cause of character move
);
```

キャラクターの最後の移動の原因を取得します。

- 操作が成功したことを示す S\_OK を返します。

- *pdwCause*
    - キャラクターの最後の移動の原因を受け取り、次のいずれかになる変数のアドレス。

| 値 | 説明 |
| --- | --- |
| **const unsigned short** **NeverMoved = 0;** | キャラクターは移動されていません。 |
| **const unsigned short** **UserMoved = 1;** | ユーザーがキャラクターをドラッグしました。 |
| **const unsigned short** **ProgramMoved = 2;** | アプリケーションがキャラクターを移動しました。 |
| **const unsigned short** **OtherProgramMoved = 3;** | 別のアプリケーションがキャラクターを移動しました。 |
| **const unsigned short** **SystemMoved = 4** | 画面の解像度が変更された後も画面に表示し続けるためにサーバーがキャラクターを移動しました。 |