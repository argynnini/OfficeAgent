---
layout: Conceptual
title: IdleOn プロパティ - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/idleon-property
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IdleOn プロパティ
document_id: 686b8314-6f9d-eba7-746c-6c755a6f71a2
document_version_independent_id: a513a0a0-eb65-6baa-0206-3b510c402a87
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/idleon-property.md
locale: ja-jp
ms.assetid: ba436dec-c7b4-42e8-99d6-c6ff93afd73c
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/idleon-property.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:53:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/idleon-property.md
page_type: conceptual
toc_rel: toc.json
word_count: 526
asset_id: lwef/idleon-property
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: facdaa10-c96e-fea7-44ff-1d80ba72ca58
---

# IdleOn プロパティ - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 指定した文字の **Idling** 状態アニメーションをサーバーが管理するかどうかを決定するブール値を設定または返します。
- **構文の**
    - エージェント \*\* です。characters ("***CharacterID***")。IdleOn\*\* [ = *boolean*]

| 部分 | 形容 |
| --- | --- |
| ブール | サーバーがアイドル モードを管理するかどうかを指定するブール式。 **True** (既定) アイドル状態のサーバー処理が有効になっています。 **アイドル状態の False** サーバーの処理が無効になっています。 |

## 備考

サーバーは、キャラクターに対して最後に再生されたアニメーションの後にタイムアウトを自動的に設定します。 このタイマーの間隔が完了すると、サーバーはキャラクターの **Idling** 状態を開始し、関連付けられている **Idling** アニメーションを一定の間隔で再生します。 サーバーが **Idling** 状態アニメーションを自動的に再生できないようにするには、プロパティを **False** に設定し、アニメーションを再生するか、[**Stop**](stop-method) メソッドを呼び出します。 この値を設定しても、文字の現在のアニメーション状態には影響しません。

このプロパティは、クライアント アプリケーションによる文字の使用にのみ適用されます。この設定は、文字の他のクライアントやクライアント アプリケーションの他の文字には影響しません。