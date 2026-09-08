---
layout: Conceptual
title: FontUnderline プロパティ - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/fontunderline-property
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: FontUnderline プロパティ
document_id: 25a14104-a03d-c419-dfdd-3dc89d54afee
document_version_independent_id: dae1a97a-689e-10f3-1aa6-70e68ba69a0d
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/fontunderline-property.md
locale: ja-jp
ms.assetid: 6fe6c147-2969-470e-9742-da2e6b3614e1
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/fontunderline-property.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:43:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/fontunderline-property.md
page_type: conceptual
toc_rel: toc.json
word_count: 250
asset_id: lwef/fontunderline-property
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 75d80bfe-292f-76ab-24e8-7c3826089ab6
---

# FontUnderline プロパティ - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 指定した文字の吹き出しウィンドウに現在表示されているフォント スタイルを返します。
- **構文の**
    - エージェント \*\* です。characters ("***CharacterID***")。Balloon.FontUnderline\*\*

| 価値 | 形容 |
| --- | --- |
| **True** | 吹き出しのフォントに下線が引きます。 |
| false **の** | 吹き出しのフォントに下線が引かっていません。 |

## 備考

文字の吹き出しのフォント設定の既定値は、Microsoft エージェント文字エディターで設定されます。 さらに、ユーザーは Microsoft Agent プロパティ シート内のすべての文字のフォント設定をオーバーライドできます。