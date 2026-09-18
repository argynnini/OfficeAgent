---
layout: Conceptual
title: ActivateInput イベント - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/activateinput-event
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: ActivateInput イベント
document_id: f16ae5e0-64db-bf0b-6b16-a6e70abafbe6
document_version_independent_id: 6b10bf6e-be7e-1ab8-a9a8-21f369bfd3d5
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/activateinput-event.md
locale: ja-jp
ms.assetid: bc395750-5da0-4379-8eca-3195e936052c
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/activateinput-event.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:36:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-07-03T23:50:19.3460266Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/activateinput-event.md
page_type: conceptual
toc_rel: toc.json
word_count: 568
asset_id: lwef/activateinput-event
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 6ab18d3e-e4ff-8889-745b-4813e5dc9841
---

# ActivateInput イベント - Win32 apps | Microsoft Learn

[Microsoft Agent は Windows 7 の時点で非推奨となり、後続のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - クライアントが入力アクティブになったときに発生します。
- **構文**
    - **Sub***agent*\_ActivateInput\*\*(ByVal\*\* *CharacterID*\*\*)\*\*

| 部分 | 説明 |
| --- | --- |
| *CharacterID* | クライアントが入力アクティブになる文字の ID を返します。 |

### 解説

入力アクティブ クライアントは、サーバーから提供されるマウスおよび音声入力イベントを受信します。 サーバーは、入力アクティブになるクライアントにのみこのイベントを送信します。

このイベントは、ユーザーが [Command](the-command-object) オブジェクトに切り替えたときに発生する可能性があります。たとえば、[コマンド] ウィンドウまたは文字のポップアップ メニューで Command オブジェクト エントリを選択したときです。 また、ユーザーが文字を選択したとき (文字をクリックするか名前を発声することによって)、文字が表示されたとき、および別のクライアント アプリケーションの文字が非表示になったときにも発生する可能性があります。 [Activate メソッド](activate-method) (**State** を 2 に設定) を呼び出して、文字を明示的に最上位に設定することもできます。これにより、クライアント アプリケーションが入力アクティブになり、このイベントがトリガーされます。 ただし、Activate Method メソッドを使用して、クライアントがキャラクターのアクティブ クライアントであるかどうかのみを指定する場合、このイベントは発生しません。

### 参照

[**DeactivateInput** イベント](deactivateinput-event)、[**Activate** メソッド](activate-method)