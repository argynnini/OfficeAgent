---
layout: Conceptual
title: Page プロパティ - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/page-property
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Page プロパティ
document_id: e43b0d5a-b050-0b3a-5a49-c097b4c11bf1
document_version_independent_id: 404762e7-04a4-155d-9ef4-0c9196c8312c
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/page-property.md
locale: ja-jp
ms.assetid: c3cf07e9-a324-443b-a0c0-2fb80463548f
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/page-property.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:58:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/page-property.md
page_type: conceptual
toc_rel: toc.json
word_count: 294
asset_id: lwef/page-property
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 9f182e18-9472-b19f-7033-e8ac80881b8d
---

# Page プロパティ - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - Microsoft エージェント のプロパティ シート ウィンドウに表示されるページを設定または返します。
- **構文の**
    - *エージェント*\*\*.PropertySheet.Page\*\* [ = 文字列 ]

| 部分 | 形容 |
| --- | --- |
| 文字列 *を* する | 次のいずれかの値を持つ文字列式。 [音声]  音声入力ページが表示されます。**出力]** 出力ページが表示されます。**著作権]** [著作権] ページが表示されます。 |

## 備考

音声エンジンがインストールされていない場合、**Page** を "Speech"  設定しても効果はありません。 また、ユーザーがページを表示するには、ウィンドウの **Visible** プロパティを **True** に設定する必要があります。

手記

ユーザーはこのプロパティをオーバーライドできます。