---
layout: Conceptual
title: IAgentCharacter GetTTSPitch - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcharacter--getttspitch
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCharacter GetTTSPitch
document_id: e62adc90-150f-f17b-4e78-7c1b0c142fe6
document_version_independent_id: 3ed6d603-167b-5ca2-0825-52ae1718ff43
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacter--getttspitch.md
locale: ja-jp
ms.assetid: b21ae1f1-daf6-42e5-9c52-f28722180021
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacter--getttspitch.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:46:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcharacter--getttspitch.md
page_type: conceptual
toc_rel: toc.json
word_count: 294
asset_id: lwef/iagentcharacter--getttspitch
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 2ca7fa9d-b3cf-61f0-268f-34477f3b4765
---

# IAgentCharacter GetTTSPitch - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT GetTTSPitch(
   long * pdwPitch  // address of variable for character TTS pitch
);
```

文字の TTS 出力ピッチ設定を取得します。

- 操作が成功したことを示すS\_OKを返します。

- pdwPitch*の *
    - Hertz で文字の現在の TTS ピッチ設定を受け取る変数のアドレス。

アプリケーションではこの値を書き込めませんが、出力テキストにピッチ タグを含めて、特定の発話のピッチを一時的に増やすことができます。 このメソッドは、TTS 出力用に構成された文字にのみ適用されます。 音声合成 (TTS) エンジンが有効になっていない (またはインストールされている) か、文字が TTS 出力をサポートしていない場合、このメソッドはゼロ (0) を返します。