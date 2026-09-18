---
layout: Conceptual
title: IAgentEx - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentex
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentEx
document_id: f67809a1-0585-bf06-f2d6-38abb242dda7
document_version_independent_id: 2f6ab206-c319-d9cb-3633-cba40e62687c
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentex.md
locale: ja-jp
ms.assetid: 6d9d67c6-26f6-435a-9ddf-f1f0a667f963
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentex.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:51:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentex.md
page_type: conceptual
toc_rel: toc.json
word_count: 176
asset_id: lwef/iagentex
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 9333988e-3ed0-d592-9445-c0fcb6aa7420
---

# IAgentEx - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

IAgentEx 、[**IAgent**](iagent) インターフェイスから派生します。 これには、すべての **IAgent** メソッドが含まれるだけでなく、追加の関数へのアクセスも提供されます。

Vtable Order **のメソッドを** する

| IAgentEx メソッド | 形容 |
| --- | --- |
| ShowDefaultCharacterProperties**[の](iagentex--showdefaultcharacterproperties)** | 既定の文字プロパティを表示します。 |
| [**GetVersion**](iagentex--getversion) | Microsoft エージェント (サーバー) のバージョン番号を返します。 |