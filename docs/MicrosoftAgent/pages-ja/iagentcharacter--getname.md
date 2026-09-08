---
layout: Conceptual
title: IAgentCharacter GetName - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcharacter--getname
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCharacter GetName
document_id: 3a2950d2-2fe1-1445-3c94-2d69e0299aef
document_version_independent_id: 2d3113a1-4242-4ee6-7b76-9506e9e0f552
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacter--getname.md
locale: ja-jp
ms.assetid: 6c013a18-8c56-42a8-8723-31d83b3230cb
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacter--getname.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:46:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcharacter--getname.md
page_type: conceptual
toc_rel: toc.json
word_count: 281
asset_id: lwef/iagentcharacter--getname
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: f69f839f-3fa1-307e-bb3c-0b922b4f51cb
---

# IAgentCharacter GetName - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT GetName(
   BSTR * pbszName   // address of buffer for character name
);
```

文字の名前を取得します。

- 操作が成功したことを示すS\_OKを返します。

- pbszName*を * する
    - 文字の名前の値を受け取る BSTR のアドレス。

文字の既定の名前は、Microsoft エージェント文字エディターを使用してコンパイルされるときに定義されます。 文字の名前は、文字の言語 ID によって異なる場合があります。 文字は、言語ごとに異なる名前でコンパイルできます。

IAgentCharacter:SetName **;**使用して文字の名前を設定することもできます。ただし、これにより、文字のすべての現在のクライアントの名前が変更されます。