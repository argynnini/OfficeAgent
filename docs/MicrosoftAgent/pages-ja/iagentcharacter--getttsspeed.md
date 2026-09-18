---
layout: Conceptual
title: IAgentCharacter GetTTSSpeed - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcharacter--getttsspeed
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCharacter GetTTSSpeed
document_id: 324ecda8-15dc-2f8f-5716-3250d4378bc6
document_version_independent_id: 84c7c234-dcee-e983-5049-9eb4ffbefc56
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacter--getttsspeed.md
locale: ja-jp
ms.assetid: 25526ef7-581f-489c-a299-bd3b5ac9ea61
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacter--getttsspeed.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:46:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcharacter--getttsspeed.md
page_type: conceptual
toc_rel: toc.json
word_count: 320
asset_id: lwef/iagentcharacter--getttsspeed
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: d4a9c7fb-3394-13c6-df3e-a4806476b1b5
---

# IAgentCharacter GetTTSSpeed - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT GetTTSSpeed(
   long * pdwSpeed  // address of variable for character TTS output speed
);
```

文字の TTS 出力速度設定を取得します。

- 操作が成功したことを示すS\_OKを返します。

- pdwSpeed*を * する
    - 文字の出力速度を 1 分あたりの単語数で受け取る変数のアドレス。

アプリケーションではこの値を書き込めませんが、特定の発話の出力を一時的に高速化する速度タグを出力テキストに含めることができます。

このプロパティは、文字の現在の読み上げ出力速度の設定を返します。 TTS 出力を使用する文字の場合、プロパティは文字の実際の TTS 出力を返します。 TTS が有効になっていないか、文字が TTS 出力をサポートしていない場合、設定には出力速度のユーザー設定が反映されます。