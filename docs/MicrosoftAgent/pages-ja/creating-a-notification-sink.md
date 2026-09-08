---
layout: Conceptual
title: 通知シンクの作成 - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/creating-a-notification-sink
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: 通知シンクの作成
document_id: 15870589-b1bd-4fc3-3784-112747bcf32f
document_version_independent_id: f6f32002-a71e-92f3-ff1e-0b856b871f68
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/creating-a-notification-sink.md
locale: ja-jp
ms.assetid: 6a3cc771-1fef-4b79-baa1-c8d050e36d92
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/creating-a-notification-sink.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:39:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/creating-a-notification-sink.md
page_type: conceptual
toc_rel: toc.json
word_count: 231
asset_id: lwef/creating-a-notification-sink
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: f166f0f5-8766-754c-783a-d2b17df9712c
---

# 通知シンクの作成 - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

Microsoft エージェントによってイベントが通知されるようにするには、 [**IAgentNotifySink**](events)インターフェイスまたは [**IAgentNotifySinkEx**](iagentnotifysinkex) インターフェイスを実装し、COM 規則に従ってその型のオブジェクトを作成して登録する必要があります。

```
// Create a notification sink

pSinkEx = new AgentNotifySinkEx;

pSinkEx->AddRef();

// And register it with Microsoft Agent

hRes = pAgentEx->Register((IUnknown *)pSinkEx, &lNotifySinkID);
```

アプリケーションがシャットダウンされ、Microsoft エージェントのインターフェイスが解放されたときに、通知シンクの登録を解除することを忘れないでください。