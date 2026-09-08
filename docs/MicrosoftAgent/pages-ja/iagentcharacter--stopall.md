---
layout: Conceptual
title: IAgentCharacter StopAll - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcharacter--stopall
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCharacter StopAll
document_id: b24364fb-559b-8aed-7e38-2a3797421dc3
document_version_independent_id: 34af3731-80c3-342a-4c3d-7d7d99db687a
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacter--stopall.md
locale: ja-jp
ms.assetid: cb0ce220-7b35-45c0-b587-30939d26740f
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacter--stopall.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:47:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-07-03T23:50:19.3460266Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcharacter--stopall.md
page_type: conceptual
toc_rel: toc.json
word_count: 342
asset_id: lwef/iagentcharacter--stopall
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 247c95bc-ab72-91d4-2aea-16938c2f12de
---

# IAgentCharacter StopAll - Win32 apps | Microsoft Learn

[Microsoft Agent は Windows 7 の時点で非推奨となり、後続のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT StopAll();
   long lType,  // request type
```

すべてのアニメーション (要求) を停止し、キャラクターのアニメーション キューから削除します。

- *lType*
    - 停止する (およびキャラクターのキューから削除する) 要求の種類を示すビットフィールド。次から構成されます。

| 値 | 説明 |
| --- | --- |
| **const unsigned long** **STOP\_TYPE\_ALL = 0xFFFFFFFF;** | キューに登録されていない [**Prepare**](iagentcharacter--prepare) 要求を含む、すべてのアニメーション要求を停止します。 |
| **const unsigned long** **STOP\_TYPE\_PLAY = 0x00000001;** | すべての Play 要求を停止します。 |
| **const unsigned long** **STOP\_TYPE\_MOVE = 0x00000002;** | すべての [**Move**](https://www.bing.com/search?q=**Move**) 要求を停止します。 |
| **const unsigned long** **STOP\_TYPE\_SPEAK = 0x00000004;** | すべての [**Speak**](iagentcharacter--speak) 要求を停止します。 |
| **const unsigned long** **STOP\_TYPE\_PREPARE = 0x00000008;** | キューに登録されているすべての [**Prepare**](iagentcharacter--prepare) 要求を停止します。 |
| **const unsigned long** **STOP\_TYPE\_NONQUEUEDPREPARE = 0x00000010;** | キューに登録されていないすべての [**Prepare**](iagentcharacter--prepare) 要求を停止します。 |
| **const unsigned long** **STOP\_TYPE\_VISIBLE = 0x00000020;** | すべての [**Hide**](iagentcharacter--hide) または [**Show**](iagentcharacter--show) 要求を停止します。 |