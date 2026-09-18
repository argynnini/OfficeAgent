---
layout: Conceptual
title: IAgentAudioOutputProperties GetEnabled - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentaudiooutputproperties--getenabled
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentAudioOutputProperties GetEnabled
document_id: 4433f211-e898-32df-0549-50b9c93db11a
document_version_independent_id: c5b78a16-d749-7f20-926c-c50412eb0851
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentaudiooutputproperties--getenabled.md
locale: ja-jp
ms.assetid: a1e555e1-98f1-4a3d-b6ba-4cd35348db2b
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentaudiooutputproperties--getenabled.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:44:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentaudiooutputproperties--getenabled.md
page_type: conceptual
toc_rel: toc.json
word_count: 224
asset_id: lwef/iagentaudiooutputproperties--getenabled
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: f80294ba-913d-41e4-a49d-d69668aa1739
---

# IAgentAudioOutputProperties GetEnabled - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT GetEnabled(
long * pbEnabled  // address of variable for audio output Enabled setting 
);                      
```

文字音声出力が有効かどうかを示す値を取得します。

- 操作が成功したことを示すS\_OKを返します。

- pbEnabled*を * する
    - 音声出力が現在有効になっている場合は **True** を受け取り、無効にした場合は False **を** 変数のアドレス。

この設定は、すべての文字の音声出力 (TTS とサウンド ファイル) に影響するため、Microsoft Agent プロパティ シートでこのプロパティを変更できるのはユーザーだけです。