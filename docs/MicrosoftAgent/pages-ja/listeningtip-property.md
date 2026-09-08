---
layout: Conceptual
title: ListeningTip プロパティ - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/listeningtip-property
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: ListeningTip プロパティ
document_id: ae8a866a-51da-78bc-752b-0e334bc94e1f
document_version_independent_id: 2de8c38c-26b6-7e76-d123-eb70f83e186f
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/listeningtip-property.md
locale: ja-jp
ms.assetid: 02a678bb-5eb6-495f-b339-35170a44b15e
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/listeningtip-property.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:54:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/listeningtip-property.md
page_type: conceptual
toc_rel: toc.json
word_count: 261
asset_id: lwef/listeningtip-property
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 984d3b0d-d822-071c-32e8-2592410f3680
---

# ListeningTip プロパティ - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - リスニング ヒントの現在のユーザー設定を示すブール値を返します。
- **構文の**
    - エージェント \*\* です。SpeechInput.ListeningTip\*\*

| 価値 | 形容 |
| --- | --- |
| **True** | Listening Tip が有効になっています。 |
| false **の** | リッスンヒントが無効になっています。 |

## 備考

**ListeningTip** プロパティは、Microsoft Agent プロパティ シートの [リッスン ヒントの表示] オプション ([高度な文字オプション]) が有効かどうかを示します。 listeningTip  が true  返され、音声入力が有効になっている場合、ユーザーが Listening キーを押すと、サーバーにヒント ウィンドウが表示されます。