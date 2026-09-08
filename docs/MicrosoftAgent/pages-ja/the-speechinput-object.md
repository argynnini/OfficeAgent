---
layout: Conceptual
title: SpeechInput オブジェクト - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/the-speechinput-object
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: SpeechInput オブジェクト
document_id: e6a70c3b-c447-9197-9b20-31a77bfc5c11
document_version_independent_id: 39a83e20-ce2e-a0a3-fba2-d3144c096312
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/the-speechinput-object.md
locale: ja-jp
ms.assetid: e968edb8-747f-421a-800b-29f13857410c
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/the-speechinput-object.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:02:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/the-speechinput-object.md
page_type: conceptual
toc_rel: toc.json
word_count: 303
asset_id: lwef/the-speechinput-object
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 0708a0e9-2d80-9d9f-62af-c8fa7499cbea
---

# SpeechInput オブジェクト - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

[**SpeechInput**](https://www.bing.com/search?q=**SpeechInput**) オブジェクトは、エージェント サーバーによって管理される音声入力プロパティへのアクセスを提供します。 プロパティはクライアント アプリケーションでは読み取り専用ですが、ユーザーは Microsoft Agent プロパティ シートでそれらを変更できます。 互換性のある音声エンジンがインストールされ、有効になっている場合にのみ、サーバーから値が返されます。

[**Engine**](https://www.bing.com/search?q=**Engine**)、[**Installed**](https://www.bing.com/search?q=**Installed**)、[**Language**](https://www.bing.com/search?q=**Language**) の各プロパティはサポートされなくなりましたが、(下位互換性のために) クエリを実行すると null 値が返されます。 音声認識のモードを照会または設定するには、 [**SRModeID**](srmodeid-property) プロパティを使用します。

- [SpeechInput プロパティ](speechinput-properties)