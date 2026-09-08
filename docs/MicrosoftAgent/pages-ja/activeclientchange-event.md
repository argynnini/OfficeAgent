---
layout: Conceptual
title: ActiveClientChange イベント - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/activeclientchange-event
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: ActiveClientChange イベント
document_id: 8b53f7f7-53f6-27a3-5606-088d0c555871
document_version_independent_id: c277b77c-48a1-a50b-f021-7d19fbd90182
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/activeclientchange-event.md
locale: ja-jp
ms.assetid: 617b40e6-cafb-463e-8b36-2a12c468d3ae
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/activeclientchange-event.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:36:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-07-03T23:50:19.3460266Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/activeclientchange-event.md
page_type: conceptual
toc_rel: toc.json
word_count: 814
asset_id: lwef/activeclientchange-event
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 5fc7bf25-e23d-53c6-abf0-0ec4e1da1bd6
---

# ActiveClientChange イベント - Win32 apps | Microsoft Learn

[Microsoft Agent は Windows 7 の時点で非推奨となり、後続のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 文字のアクティブなクライアントが変更されたときに発生します。
- **構文**
    - **Sub** \*agent.\*ActiveClientChange (ByVal *CharacterID*、ByVal *Active***)**

| 部分 | 説明 |
| --- | --- |
| *CharacterID* | イベントが発生した文字の ID を返します。 |
| *アクティブ* | クライアントがアクティブになったか、非アクティブになったかを示すブール値。 **True** クライアント アプリケーションが文字のアクティブなクライアントになりました。 **False** クライアント アプリケーションは、文字のアクティブなクライアントではなくなりました。 |

### 解説

複数のクライアント アプリケーションが同じキャラクターを共有する場合、そのキャラクターのアクティブなクライアントはマウス入力 (たとえば、Microsoft エージェント コントロールのクリック イベントやドラッグ イベント) を受け取ります。 同様に、複数の文字が表示されている場合、最上位の文字のアクティブ クライアント (入力アクティブ クライアントとも呼ばれます) は [Command](command-event) イベントを受信します。

キャラクターのアクティブ クライアントが変更されると、このイベントはそのキャラクターの ID を返し、アプリケーションがキャラクターのアクティブ クライアントになった場合は **True** を返し、アプリケーションがキャラクターのアクティブ クライアントでなくなった場合は **False** を返します。

ユーザーがキャラクタのポップアップ メニューまたは音声コマンドでクライアント アプリケーションのエントリを選択したとき、クライアント アプリケーションがアクティブ ステータスを変更したとき、または別のクライアント アプリケーションが Agent への接続を終了したときに、クライアント アプリケーションはこのイベントを受信することがあります。 エージェントは、直接影響を受けるクライアント アプリケーション (アクティブ クライアントになるか、アクティブ クライアントでなくなるクライアント アプリケーション) にのみこのイベントを送信します。

### 参照

[**ActivateInput イベント**](activateinput-event)、[**Active プロパティ**](active-property)、[**DeactivateInput イベント**](deactivateinput-event)、[**Activate メソッド**](activate-method)