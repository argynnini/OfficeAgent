---
layout: Conceptual
title: タグの一時停止 - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/pau-tag
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: タグの一時停止
document_id: 740a2ae2-7c37-74a9-4b7d-5de08350d87c
document_version_independent_id: 5e85b36e-cd67-7161-fd42-0070d15168b9
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/pau-tag.md
locale: ja-jp
ms.assetid: c3278320-1a19-4d96-8a3b-3aafa9dd211f
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/pau-tag.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:58:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/pau-tag.md
page_type: conceptual
toc_rel: toc.json
word_count: 171
asset_id: lwef/pau-tag
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 93f94d21-eb2f-7c1f-749f-d7acabca314f
---

# タグの一時停止 - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 指定したミリ秒単位で音声を一時停止します。
- **構文の**
    - **\Pau=*数値*\**

| 部分 | 形容 |
| --- | --- |
| *番号* | 一時停止するミリ秒数。 |

### 備考

このタグは、TTS で生成された出力でのみサポートされます。 パラメーターの値の範囲は、インストールされている TTS エンジンによって異なる場合があります。