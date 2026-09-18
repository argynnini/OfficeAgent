---
layout: Conceptual
title: Name プロパティ (エージェント コントロール) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/name-property-a
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: エージェント コントロールの Name プロパティについて説明します。 このプロパティは、実行時に読み取り専用です。 Microsoft エージェントは、Windows 7 の時点で非推奨です。
document_id: d5976df2-2eba-89d8-b612-3b9b7ed953b4
document_version_independent_id: 9feea10f-2fe5-690f-00ed-86e1385e306a
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/name-property-a.md
locale: ja-jp
ms.assetid: 83d6682c-ac25-4333-8640-7ef468f2de8b
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/name-property-a.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:58:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/name-property-a.md
page_type: conceptual
toc_rel: toc.json
word_count: 263
asset_id: lwef/name-property-a
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: ee86863f-d28c-b093-376f-976cae666130
---

# Name プロパティ (エージェント コントロール) - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - コントロールを識別するためにコードで使用される名前を返します。 このプロパティは、実行時に読み取り専用です。
- **構文の**
    - エージェント \*\* です。名前\*\*

## 備考

Visual Basic などの一部のプログラミング環境では、コントロールを追加すると、デザイン時に変更できるコントロールの既定の名前が自動的に生成されます。 HTML スクリプトの場合は、&lt;OBJECT&gt; タグで名前を定義できます。 名前を定義する場合は、オブジェクト名を定義するためのプログラミング言語の規則に従ってください。