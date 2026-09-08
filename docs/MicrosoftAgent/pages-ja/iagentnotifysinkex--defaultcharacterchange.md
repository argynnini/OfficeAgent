---
layout: Conceptual
title: IAgentNotifySinkEx DefaultCharacterChange - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentnotifysinkex--defaultcharacterchange
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentNotifySinkEx DefaultCharacterChange
document_id: e8342be5-adde-aa0d-e6bb-54748fc51f80
document_version_independent_id: 4ebfb84b-0f1d-e09a-4121-1c583443a224
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentnotifysinkex--defaultcharacterchange.md
locale: ja-jp
ms.assetid: 13acb502-e247-433f-abf3-2d78a2d6a4a7
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentnotifysinkex--defaultcharacterchange.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:52:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentnotifysinkex--defaultcharacterchange.md
page_type: conceptual
toc_rel: toc.json
word_count: 324
asset_id: lwef/iagentnotifysinkex--defaultcharacterchange
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 88c3d905-2e7e-d7bf-8943-b6f09394e3d7
---

# IAgentNotifySinkEx DefaultCharacterChange - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT DefaultCharacterChange(
   BSTR bszGUID  // character identifier
);
```

既定の文字が変更されたときにクライアント アプリケーションに通知します。

- 戻り値はありません。

- bszGUID*を * する
    - 文字の一意識別子。

ユーザーがユーザーの既定の文字として割り当てられた文字を変更すると、サーバーはこのイベントを、既定の文字を読み込んだクライアントに送信します。 このイベントは、中かっことダッシュで書式設定された文字の一意識別子 (GUID) を返します。これは、Microsoft Agent Character Editor を使用して文字がビルドされるときに定義されます。

新しい文字が表示されると、既に読み込まれている文字のインスタンスまたは以前の既定の文字 (その順序) と同じサイズが想定されます。