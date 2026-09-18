---
layout: Conceptual
title: IAgentCommandEx GetVoiceCaption - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcommandex--getvoicecaption
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCommandEx GetVoiceCaption
document_id: ed41f352-4b26-2918-9970-0eea2e85c68d
document_version_independent_id: 0d600992-05b7-8f9d-36fa-32fbe956248c
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcommandex--getvoicecaption.md
locale: ja-jp
ms.assetid: a81accfd-c137-4347-8ead-4ed5e7148751
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommandex--getvoicecaption.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:49:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcommandex--getvoicecaption.md
page_type: conceptual
toc_rel: toc.json
word_count: 195
asset_id: lwef/iagentcommandex--getvoicecaption
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 037231c9-7ff7-c761-44ff-759c0756c798
---

# IAgentCommandEx GetVoiceCaption - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

```syntax
HRESULT GetVoiceCaption(
   BSTR * pbszVoiceCaption  // address of command's voice caption text
);
```

コマンドの [**VoiceCaption**](voicecaption-property) を取得 [**します**](/ja-jp/windows/desktop/lwef/the-command-object)。

- 操作が成功したことを示すS\_OKを返します。

- *pbszVoiceCaption*
    - [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) に対して表示される [**Caption**](caption-property) テキストの値を受け取る BSTR のアドレス。

[**VoiceCaption**](voicecaption-property) は、クライアント アプリケーションが input-active のときに[音声コマンド] ウィンドウに [**Command オブジェクトに**](/ja-jp/windows/desktop/lwef/the-command-object)表示されるテキストです。