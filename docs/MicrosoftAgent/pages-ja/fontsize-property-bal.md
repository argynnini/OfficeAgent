---
layout: Conceptual
title: FontSize プロパティ (Balloon オブジェクト) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/fontsize-property-bal
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: FontSize Balloon オブジェクト プロパティについて説明します。 Microsoft エージェントは Windows 7 の時点で非推奨となっています。
document_id: f5e25323-27d3-b5fe-16ff-ed6149e6a636
document_version_independent_id: df2c05ca-f0b5-6c6c-c1ba-c39e2a45476d
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/fontsize-property-bal.md
locale: ja-jp
ms.assetid: 36d5526a-1ae9-4ef2-94f6-0ad63ce86882
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/fontsize-property-bal.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:43:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-07-03T23:50:19.3460266Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/fontsize-property-bal.md
page_type: conceptual
toc_rel: toc.json
word_count: 288
asset_id: lwef/fontsize-property-bal
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: ebc0e1ec-eff3-a8c6-2418-d4654d313fa8
---

# FontSize プロパティ (Balloon オブジェクト) - Win32 apps | Microsoft Learn

[Microsoft Agent は Windows 7 の時点で非推奨となり、後続のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 指定したキャラクターの吹き出しでサポートされているフォント サイズを返すか設定します。
- **構文**
    - \*agent.\***Characters** **("*CharacterID*").Balloon.FontSize** [ = *Points*]

| 部分 | 説明 |
| --- | --- |
| *Points* | フォント サイズをポイント単位で指定する長整数値。 |

## 解説

[**FontSize**](fontsize-property) プロパティは、現在のフォント サイズをポイント単位で指定する長整数値を返します。 **FontSize** の最大値は 2160 ポイントです。

キャラクターの吹き出しのフォント設定のデフォルト値は、Microsoft エージェント キャラクター エディターで設定されます。 さらに、ユーザーは Microsoft Agent プロパティ シート内のすべてのキャラクターのフォント設定をオーバーライドできます。