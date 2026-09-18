---
layout: Conceptual
title: IAgentBalloonEx SetNumLines - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentballoonex--setnumlines
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentBalloonEx SetNumLines
document_id: 3558a29c-3adf-6b21-3507-26fb99ffca75
document_version_independent_id: 88d7b851-8af3-68bd-4d4f-28a67a4d68d4
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentballoonex--setnumlines.md
locale: ja-jp
ms.assetid: 350fd273-a941-4454-a309-045d19ed8f59
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentballoonex--setnumlines.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:46:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentballoonex--setnumlines.md
page_type: conceptual
toc_rel: toc.json
word_count: 320
asset_id: lwef/iagentballoonex--setnumlines
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 7aca561e-6f4f-4511-9c1d-ec77d5276dc4
---

# IAgentBalloonEx SetNumLines - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT SetNumLines(
   long lLines,  // number of lines setting
);
```

文字の吹き出しに表示できるテキスト出力の行数を設定します。

- 操作が成功したことを示すS\_OKを返します。
- パラメーターが 0 の場合E\_INVALIDARGを返します。

- *lLines*
    - 吹き出しという単語に表示する行数。

最小設定は 1、最大値は 128 です。 [**Speak**](speak-method) または [**Think**](think-method) メソッドで指定されたテキストが現在の吹き出しのサイズを超えた場合、エージェントは吹き出し内のテキストを自動的にスクロールします。

**SizeToText** バルーン スタイル ビットが設定されている場合、このメソッドは失敗します。

既定の設定は、Microsoft エージェント文字エディターを使用して文字をコンパイルするときの設定に基づいています。