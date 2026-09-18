---
layout: Conceptual
title: AnimationNames コレクション - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/the-animationnames-collection
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: AnimationNames コレクション
document_id: a0e87d97-2383-5bed-4c25-b67633c233dd
document_version_independent_id: a0f023f8-bcc7-6ff5-3322-664c366c87f0
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/the-animationnames-collection.md
locale: ja-jp
ms.assetid: 3b06e497-1d03-43be-8d33-e69ef2972237
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/the-animationnames-collection.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:01:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/the-animationnames-collection.md
page_type: conceptual
toc_rel: toc.json
word_count: 319
asset_id: lwef/the-animationnames-collection
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 3ac37d9f-074a-e48a-7d7c-018c9d0f4392
---

# AnimationNames コレクション - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

[**AnimationNames**](https://www.bing.com/search?q=**AnimationNames**) コレクションは、キャラクター用にコンパイルされたアニメーション名の一覧を含む特別なコレクションです。 コレクションを使用して、キャラクターのアニメーションの名前を列挙できます。 たとえば、Visual Basic または VBScript (2.0 以降) では、for Each **を使用してこれらの名前にアクセスできます。次の** ステートメント:

```
   For Each Animation in Genie.AnimationNames
      Genie.Play Animation
   Next
```

コレクション内の項目にはプロパティがないため、個々の項目に直接アクセスすることはできません。

.ACFキャラクターでは、コレクションは、[**Get**](get-method) メソッドで取得されたアニメーションだけでなく、そのキャラクターに対して定義されているすべてのアニメーションを返します。