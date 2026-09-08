---
layout: Conceptual
title: IAgentBalloon SetFontSize - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentballoon--setfontsize
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentBalloon SetFontSize
document_id: bcc45fb7-72ed-83a9-a8c9-10b0867b15cd
document_version_independent_id: 4031201a-9881-e266-befb-c101ef7abe08
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentballoon--setfontsize.md
locale: ja-jp
ms.assetid: c38779a6-bd7f-4d3a-9cb0-9d9fac1c7996
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentballoon--setfontsize.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:45:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentballoon--setfontsize.md
page_type: conceptual
toc_rel: toc.json
word_count: 235
asset_id: lwef/iagentballoon--setfontsize
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 13a30fc9-3ad0-e0d5-97e9-7e6a13df8bd4
---

# IAgentBalloon SetFontSize - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT SetFontSize(
   long lFontSize  // font size displayed in word balloon
); 
```

吹き出しという単語に表示されるフォントのサイズを設定します。

- 操作が成功したことを示すS\_OKを返します。

- *lFontSize*
    - フォントのサイズ。

文字の吹き出しで使用される既定のフォント サイズは、Microsoft エージェント文字エディターで定義されます。 IAgentBalloon::SetFontSize で変更できます。 ただし、ユーザーは Microsoft Agent プロパティ シートを使用して、すべての文字のフォント サイズ設定をオーバーライドできます。