---
layout: Conceptual
title: ShowDefaultCharacterProperties メソッド - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/showdefaultcharacterproperties-method
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: ShowDefaultCharacterProperties メソッド
document_id: b578a1d7-bec5-4c56-6ccc-62e0a0862ec4
document_version_independent_id: 5c0d6b1a-43a9-66f2-7866-418b9d24a7b2
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/showdefaultcharacterproperties-method.md
locale: ja-jp
ms.assetid: a3b109c0-5701-4a72-baae-bcbb97b025a3
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/showdefaultcharacterproperties-method.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:00:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/showdefaultcharacterproperties-method.md
page_type: conceptual
toc_rel: toc.json
word_count: 304
asset_id: lwef/showdefaultcharacterproperties-method
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: fec1ff7d-ddfe-757b-f35d-d0fedc3927a7
---

# ShowDefaultCharacterProperties メソッド - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 既定の文字のプロパティを表示します。
- **構文の**
    - エージェント \*\* です。ShowDefaultCharacterProperties\*\* [ *X* , *Y* ]

| 部分 | 形容 |
| --- | --- |
| *X* | 随意。 ウィンドウを表示する水平 (*X*) 画面座標を示す短い整数値。 この座標はピクセル単位で指定する必要があります。 |
| *Y* | 随意。 ウィンドウを表示する垂直 (*Y*) 画面座標を示す短い整数値。 この座標はピクセル単位で指定する必要があります。 |

## 備考

このメソッドを呼び出すと、既定の文字プロパティ ウィンドウが表示されます (Microsoft Agent プロパティ シートではありません)。 X 座標と Y 座標を指定しない場合、ウィンドウは最後に表示された場所に表示されます。