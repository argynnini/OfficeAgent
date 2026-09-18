---
layout: Conceptual
title: JavaScript と JScript の使用 - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/using-javascript-and-jscript
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: JavaScript と JScript の使用
document_id: d8238597-97fc-e65c-3e9c-edfb00ae7eda
document_version_independent_id: 8a38eda5-d653-ad2b-0228-975b12b59833
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/using-javascript-and-jscript.md
locale: ja-jp
ms.assetid: c6927663-9432-4fa9-8de6-abb7237909b9
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/using-javascript-and-jscript.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:03:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/using-javascript-and-jscript.md
page_type: conceptual
toc_rel: toc.json
word_count: 497
asset_id: lwef/using-javascript-and-jscript
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 5a191756-26d5-784f-0561-9ee68ee02772
---

# JavaScript と JScript の使用 - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

JavaScript または Microsoft JScript を使用して Microsoft エージェントのプログラミング インターフェイスにアクセスする場合は、この言語の規則に従ってメソッドまたはプロパティを指定します。

```syntax
agent.object.Method (parameter)
agent.object.Property = value
```

現在、JavaScript には、HTML 以外のオブジェクトのイベント構文はありません。 ただし、インターネット エクスプローラーでは、タグの For... を`<SCRIPT>`使用できます**。イベント**構文:

```syntax
<SCRIPT LANGUAGE="JScript" FOR="object" EVENT="event()">
statements
</SCRIPT>
```

現在、すべてのブラウザーでこのイベント構文がサポートされているわけではないため、Microsoft インターネット エクスプローラーをサポートするページ、またはイベント処理を必要としないコードに対してのみ JavaScript を使用できます。

エージェントのオブジェクト コレクションにアクセスするには、JScript [**列挙子**](https://www.bing.com/search?q=**Enumerator**) 関数を使用します。 ただし、インターネット エクスプローラー 4.0 より前のバージョンの JScript は、この関数をサポートしていないため、コレクションをサポートしていません。 [**Character**](/ja-jp/windows/desktop/lwef/the-characters-object) オブジェクトのメソッドとプロパティにアクセスするには、[**Character**](character-method) メソッドを使用します。 同様に、 [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトのプロパティにアクセスするには、 [**Command**](command-method) メソッドを使用します。