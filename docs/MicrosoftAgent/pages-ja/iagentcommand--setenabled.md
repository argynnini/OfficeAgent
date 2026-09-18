---
layout: Conceptual
title: IAgentCommand SetEnabled - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcommand--setenabled
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCommand SetEnabled
document_id: 5d2d717f-9e09-7aaf-1d06-32dfd69cae5b
document_version_independent_id: ffa870a2-23a4-b6c0-4a07-15848847f415
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcommand--setenabled.md
locale: ja-jp
ms.assetid: e0a724b4-3613-400f-a801-efc8bf66e355
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommand--setenabled.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:49:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcommand--setenabled.md
page_type: conceptual
toc_rel: toc.json
word_count: 307
asset_id: lwef/iagentcommand--setenabled
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 3059c797-b882-a8fe-a208-131a0d927b02
---

# IAgentCommand SetEnabled - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT SetEnabled(
   long bEnabled  // Enabled setting for Command
);
```

[**コマンド**](/ja-jp/windows/desktop/lwef/the-command-object)の [**Enabled**](enabled-property) プロパティを設定します。

- 操作が成功したことを示すS\_OKを返します。

- *bEnabled*
    - [**コマンド**](/ja-jp/windows/desktop/lwef/the-command-object)の [**Enabled**](enabled-property) 設定の値を設定するブール値。 **True** では、**コマンドの**が有効になります。**False** は無効にします。 無効 **コマンド** を選択できません。

[**コマンド**](/ja-jp/windows/desktop/lwef/the-command-object) を選択するには、その [**Enabled**](enabled-property) プロパティを **True** に設定する必要があります。 また、文字のポップアップ メニューに表示するには、[**Caption**](caption-property) プロパティを設定し、その [**Visible**](visible-property) プロパティ **True** に設定する必要があります。 **音声コマンド ウィンドウ**に **コマンド** を表示するには、その [**Voice**](voice-property)プロパティを設定する必要があります。