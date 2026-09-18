---
layout: Conceptual
title: RaiseRequestErrors プロパティ - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/raiserequesterrors-property
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: RaiseRequestErrors プロパティ
document_id: 6b75e77d-6cbd-ed71-4ac9-fb0c83854037
document_version_independent_id: e947879a-7d57-de3f-57bf-b7a8ec9c5954
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/raiserequesterrors-property.md
locale: ja-jp
ms.assetid: 60eb4478-526e-492a-8fb3-d1e54eff9868
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/raiserequesterrors-property.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:59:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/raiserequesterrors-property.md
page_type: conceptual
toc_rel: toc.json
word_count: 404
asset_id: lwef/raiserequesterrors-property
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: c2461af3-b7c2-5c60-06b4-1a2584f93ca8
---

# RaiseRequestErrors プロパティ - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 要求のエラーが発生するかどうかを示す値を取得または設定します。
- **構文の**
    - エージェント \*\* です。RaiseRequestErrors\*\* [ = *boolean*]

| 部分 | 形容 |
| --- | --- |
| ブール | 要求のエラーが発生するかどうかを決定するブール値。**True** (既定) の要求エラーが発生します。 **False** 要求エラーは発生しません。 |

## 備考

このプロパティを使用すると、[**Request**](/ja-jp/windows/desktop/lwef/the-request-object) オブジェクトをサポートするメソッドで発生するエラーがサーバーによって発生するかどうかを判断できます。 たとえば、[**Play**](play-method)メソッドに存在しないアニメーション名を指定した場合、このプロパティを **False**に設定しない限り、サーバーはエラー (エラー メッセージを表示) を発生させます。

これは、エラーが発生したときに回復を提供しないプログラミング言語に役立つ場合があります。 ただし、このプロパティを false に設定する場合は注意が必要です。コード内のエラーを見つけるのが難しい場合があるためです。