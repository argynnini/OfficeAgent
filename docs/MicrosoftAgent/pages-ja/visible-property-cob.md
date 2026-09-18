---
layout: Conceptual
title: Visible プロパティ (Characters オブジェクト) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/visible-property-cob
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: 文字が表示されているかどうかを示すブール値を返す Characters オブジェクトの Visible プロパティについて説明します。
document_id: 7979c211-7b50-b32c-d640-fd31c87a2b1f
document_version_independent_id: b36a3637-325d-59ed-95d4-3e4a329fb32d
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/visible-property-cob.md
locale: ja-jp
ms.assetid: c06d623d-8997-413a-b4ab-24275eccfa10
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/visible-property-cob.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:03:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/visible-property-cob.md
page_type: conceptual
toc_rel: toc.json
word_count: 343
asset_id: lwef/visible-property-cob
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: b4e9d615-92fb-ac2c-c03d-e2c0f596691c
---

# Visible プロパティ (Characters オブジェクト) - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 文字が表示されているかどうかを示すブール値を返します。
- **構文の**
    - エージェント \*\* です。Characters(**"*CharacterID*"**).目に見える\*\*

| 価値 | 形容 |
| --- | --- |
| 真 | 文字が表示されます。 |
| 偽 | 文字は非表示 (表示されません) です。 |

## 備考

このプロパティは、文字のフレームが表示されているかどうかを示します。 画面に画像があるとは限りません。 たとえば、このプロパティは、表示されている表示領域の外に文字が配置されている場合や、現在の文字フレームに画像が含まれている場合でも、**True** を返します。 このプロパティの設定は、文字のすべてのクライアントに適用されます。

このプロパティは読み取り専用です。 文字を表示または非表示にするには、[**Show**](show-method) または [**Hide**](https://www.bing.com/search?q=**Hide**) メソッドを使用します。