---
layout: Conceptual
title: ワード バルーンのサポート - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/word-balloon-support
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: ワード バルーンのサポート
document_id: 3b8256c6-1b02-3f80-7fc2-d382f5a3cf15
document_version_independent_id: b5341ddc-efc2-edca-4f77-5f5e09437a23
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/word-balloon-support.md
locale: ja-jp
ms.assetid: deac032f-0480-4a0d-bc69-e26f12666bbc
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/word-balloon-support.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:05:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/word-balloon-support.md
page_type: conceptual
toc_rel: toc.json
word_count: 525
asset_id: lwef/word-balloon-support
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 6e52cfc2-bf01-b5ab-8b6a-b040656fd2a6
---

# ワード バルーンのサポート - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

音声出力は、漫画の単語吹き出しの形式でテキスト出力として表示することもできます。 これは、[**Speak**](speak-method) メソッドを使用する場合に、文字の音声出力を補完するために使用することも、オーディオ出力の代わりに使用することもできます。

![はいマスター ワード バルーン](images/f3ballon.gif)

また、単語吹き出しを使用して、[**Think**](think-method) メソッドを使用して文字が何を "考えている" かを伝えることができます。 これで、指定したテキストが、まだ "思考" の吹き出しで表示されます。 **Think** メソッドは、オーディオ出力が生成されないという点で、[**Speak**](speak-method) メソッドとも異なります。

ワード バルーンは、ユーザー入力ではなく、文字からのキャプション付き通信のみをサポートします。 そのため、吹き出しという単語は入力コントロールをサポートしていません。 ただし、プログラミング言語のインターフェイスや、Microsoft Agent によって提供される他の入力サービス (ポップアップ メニューなど) を使用して、文字のユーザー入力を簡単に提供できます。

文字を定義するときに、ワード バルーンサポートを含めるかどうかを指定できます。 ただし、ワード バルーンサポートを含む文字を使用する場合、サポートを無効にすることはできません。