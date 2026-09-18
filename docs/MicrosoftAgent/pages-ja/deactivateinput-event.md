---
layout: Conceptual
title: DeactivateInput イベント - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/deactivateinput-event
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: DeactivateInput イベント
document_id: a6b350e1-c92f-6338-d80a-1a9973a8855b
document_version_independent_id: dca14518-5ee4-0a50-fda0-cac71778daf0
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/deactivateinput-event.md
locale: ja-jp
ms.assetid: 59747932-82be-45d5-8465-73798904e8a7
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/deactivateinput-event.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:39:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-07-03T23:50:19.3460266Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/deactivateinput-event.md
page_type: conceptual
toc_rel: toc.json
word_count: 470
asset_id: lwef/deactivateinput-event
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 6254d756-e59d-1eea-f158-4a6d3c23a200
---

# DeactivateInput イベント - Win32 apps | Microsoft Learn

[Microsoft Agent は Windows 7 の時点で非推奨となり、後続のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - クライアントが非入力アクティブになったときに発生します。
- **構文**
    - **Sub***agent*\*\*\_DeactivateInput\*\* **(ByVal***CharacterID*\*\*)\*\*

| 部分 | 説明 |
| --- | --- |
| *CharacterID* | クライアントを非入力アクティブにするキャラクターの ID を返します。 |

### 解説

非入力アクティブなクライアントはサーバーからマウス イベントまたは音声イベントを受信しなくなります (再び入力がアクティブになる場合を除く)。 サーバーは、非入力アクティブになるクライアントにのみこのイベントを送信します。

このイベントは、クライアント アプリケーションが入力アクティブで、ユーザーがキャラクターのポップアップ メニューまたは音声コマンド ウィンドウで別のクライアントのキャプションを選択するか、[**Activate**](activate-method) メソッドを呼び出して **State** パラメーターを 0 に設定したときに発生します。 また、ユーザーがクリックまたは読み上げによって別のキャラクターの名前を選択した場合にも発生する可能性があります。 また、このイベントは、キャラクターが非表示になっているか、別のキャラクターが表示されたときにも発生します。

### 参照

[**ActivateInput イベント**](activateinput-event)