---
layout: Conceptual
title: IAgentCharacter SetDescription - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcharacter--setdescription
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCharacter SetDescription
document_id: 9d873b40-f66e-3f0b-4d56-94b0885d7715
document_version_independent_id: 9745197a-24c5-a04e-7c39-ead80ee4e5c9
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacter--setdescription.md
locale: ja-jp
ms.assetid: ae01b9e6-1616-4806-9125-ceb4cb54aab1
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacter--setdescription.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:47:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcharacter--setdescription.md
page_type: conceptual
toc_rel: toc.json
word_count: 284
asset_id: lwef/iagentcharacter--setdescription
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 47b7fe04-96bb-9f14-499c-aca9ac7adede
---

# IAgentCharacter SetDescription - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT SetDescription(
   BSTR bszDescription   // character description
); 
```

文字の説明を設定します。

- 操作が成功したことを示すS\_OKを返します。

- *bszDescription*
    - 文字の説明を設定する BSTR。 文字の既定の説明は、Microsoft エージェント文字エディターを使用してコンパイルされるときに定義されます。 説明の設定は省略可能であり、すべての文字に対して指定できるわけではありません。 IAgentCharacter::setDescription 使用して、文字の説明を変更できます。ただし、この値は永続的ではありません (永続的に格納されます)。 文字の説明は、文字がクライアントによって最初に読み込まれるたびに、既定の設定に戻ります。