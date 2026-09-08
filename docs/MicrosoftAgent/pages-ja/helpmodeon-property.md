---
layout: Conceptual
title: HelpModeOn プロパティ - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/helpmodeon-property
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: HelpModeOn プロパティ
document_id: c2b099d7-cfc2-ca6f-46bc-fa69bc19b4c2
document_version_independent_id: 179fec8a-2402-0370-70ca-6d41219bd159
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/helpmodeon-property.md
locale: ja-jp
ms.assetid: 4a9b5fd3-12e2-489b-8ce0-9b66b01f517a
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/helpmodeon-property.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:44:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/helpmodeon-property.md
page_type: conceptual
toc_rel: toc.json
word_count: 563
asset_id: lwef/helpmodeon-property
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 4a0e94fc-1fb5-def3-9155-71e2a8b3cfcd
---

# HelpModeOn プロパティ - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - コンテキスト依存ヘルプ モードが文字に対してオンになっているかどうかを示す値を取得または設定します。
- **構文の**
    - \*agent.\***Characters("*CharacterID*")。HelpModeOn** [ = ブール ]

| 部分 | 形容 |
| --- | --- |
| ブール | 状況依存ヘルプ モードがオンかどうかを指定するブール式。 **True** ヘルプ モードがオンです。 **False** (既定) ヘルプ モードがオフです。 |

## 備考

このプロパティを **True**に設定すると、マウス ポインターは、文字の上または文字のポップアップ メニューの上に移動すると、状況依存のヘルプ イメージに変わります。 ユーザーがキャラクターをクリックまたはドラッグするか、キャラクターのポップアップ メニューで項目をクリックすると、サーバーは [**HelpComplete**](helpcomplete-event) イベントをトリガーし、ヘルプ モードを終了します。

ヘルプ モードでは、[**AutoPopupMenu**](autopopupmenu-property) プロパティを **True**に設定しない限り、サーバーは [**クリック**](click-event)、[**DragStart**](dragstart-event)、[**DragComplete**](dragcomplete-event)、および [**コマンド**](command-event) イベントを送信しません。 その場合、サーバーは **Click** イベントを送信します (ヘルプ モードは終了しません)。ただし、マウスの右ボタンに対してのみポップアップ メニューを表示できます。

このプロパティは、クライアント アプリケーションによる文字の使用にのみ適用されます。この設定は、文字の他のクライアントやクライアント アプリケーションの他の文字には影響しません。