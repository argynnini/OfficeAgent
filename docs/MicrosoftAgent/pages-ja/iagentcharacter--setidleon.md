---
layout: Conceptual
title: IAgentCharacter SetIdleOn - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcharacter--setidleon
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCharacter SetIdleOn
document_id: 62f2e3f4-3afd-9923-df00-246fceaf7807
document_version_independent_id: 3c03ebf4-4808-02ac-c937-3ac68832fe06
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacter--setidleon.md
locale: ja-jp
ms.assetid: 397d223a-0970-4535-ad46-2923df6b9975
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacter--setidleon.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:47:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcharacter--setidleon.md
page_type: conceptual
toc_rel: toc.json
word_count: 393
asset_id: lwef/iagentcharacter--setidleon
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 4a16fb6e-59b3-e0f0-7255-4f4d3e57a2f5
---

# IAgentCharacter SetIdleOn - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT SetIdleOn(
   long bOn  // idle processing flag
);
```

文字の自動アイドル処理を設定します。

- 操作が成功したことを示すS\_OKを返します。

- *bOn*
    - アイドル処理フラグ。 このパラメーターが True 場合、Microsoft エージェントは、Idling **状態アニメーション** 自動的に再生します。

サーバーは、キャラクターに対して最後に再生されたアニメーションの後にタイムアウトを自動的に設定します。 このタイマーの間隔が完了すると、サーバーはキャラクターの **Idling** 状態を開始し、関連付けられている **Idling** アニメーションを一定の間隔で再生します。 **Idling** 状態アニメーションを自分で管理する場合は、プロパティを **False**に設定します。 このプロパティは、クライアント アプリケーションによる文字の使用にのみ適用されます。この設定は、文字の他のクライアントやクライアント アプリケーションの他の文字には影響しません。