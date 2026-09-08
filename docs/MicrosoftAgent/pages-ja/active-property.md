---
layout: Conceptual
title: Active プロパティ - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/active-property
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Active プロパティ
document_id: 44a4f53d-7d21-26c5-d67a-6e322876a2d6
document_version_independent_id: 1dd8b27e-6d1d-f0cc-8fd7-e27b507331b4
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/active-property.md
locale: ja-jp
ms.assetid: 76ada073-782a-4355-b4e8-42dd84d0139b
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/active-property.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:36:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/active-property.md
page_type: conceptual
toc_rel: toc.json
word_count: 475
asset_id: lwef/active-property
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 167a083a-5691-dc9f-8f0c-8f0f058faabf
---

# Active プロパティ - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - アプリケーションが文字のアクティブなクライアントかどうか、および文字が最上位であるかどうかを返します。
- **構文の**
    - エージェント *します。**Characters***("***CharacterID***")。Active\*\* [ = *State*]

| 部分 | 形容 |
| --- | --- |
| *状態の* | クライアント アプリケーションの状態を指定する整数式。 0 アクティブなクライアントではありません。 1 アクティブなクライアント。  2 入力アクティブなクライアント。 (一番上の文字)。 |

## 備考

複数のクライアント アプリケーションが同じ文字を共有する場合、キャラクターのアクティブなクライアントはマウス入力を受け取ります (たとえば、Microsoft Agent コントロール [**クリック**](click-event) または [DragStart](dragstart-event) イベント)。 同様に、複数の文字が表示されると、最上位文字のアクティブなクライアント (入力/アクティブ クライアントとも呼ばれます) が Command イベントを受け取ります。

[**Activate**](activate-method)メソッドを使用して、アプリケーションが文字のアクティブ なクライアントかどうかを設定するか、アプリケーションを入力アクティブ クライアントにするかを設定できます (文字の最上位にもなります)。