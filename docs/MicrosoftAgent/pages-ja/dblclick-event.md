---
layout: Conceptual
title: DblClick イベント - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/dblclick-event
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: DblClick イベント
document_id: 191186e1-75f4-8513-7d9a-1cacf0dca3a7
document_version_independent_id: d5cf0046-a104-e28b-ded2-a73b42df1976
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/dblclick-event.md
locale: ja-jp
ms.assetid: 81ed5396-a2dc-49fe-820f-61ca0935fe85
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/dblclick-event.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:39:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-07-03T23:50:19.3460266Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/dblclick-event.md
page_type: conceptual
toc_rel: toc.json
word_count: 989
asset_id: lwef/dblclick-event
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: c3f1174b-4375-b6e4-9fa2-87a0fd7c9ef9
---

# DblClick イベント - Win32 apps | Microsoft Learn

[Microsoft Agent は Windows 7 の時点で非推奨となり、後続のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - ユーザーがキャラクターをダブルクリックしたときに発生します。
- **構文**
    - **Sub***agent*\*\*\_DblClick\*\* **(ByVal***CharacterID*, **ByVal***Button*, **ByVal***Shift*, **ByVal***X*, **ByVal***Y*\*\*)\*\*

| 部分 | 説明 |
| --- | --- |
| *CharacterID* | ダブルクリックしたキャラクターの ID を文字列として返します。 |
| *Button* | イベントを発生させるために押されて離されたボタンを識別する整数を返します。 button 引数は、左ボタン (ビット 0)、右ボタン (ビット 1)、中央ボタン (ビット 2) に対応するビットを含むビットフィールドです。 これらのビットはそれぞれ値 1、2、4 に対応しています。 イベントの原因となったボタンを示す、いずれか 1 つのビットのみが設定されます。 キャラクターにタスク バー アイコンが含まれており、ビット 13 も設定されている場合は、タスク バー アイコンのクリックが発生しました。 |
| *Shift* | button 引数で指定されたボタンが押されるか離されたときに、Shift キー、Ctrl キー、Alt キーの状態に対応する整数を返します。 キーが押されている場合はビットが設定されます。 shift 引数は、Shift キー (ビット 0)、Ctrl キー (ビット 1)、Alt キー (ビット 2) に対応する最下位ビットが含まれるビットフィールドです。 これらのビットはそれぞれ値 1、2、4 に対応しています。 shift 引数はこれらのキーの状態を示します。 一部またはすべてのビットを設定することも、ビットを一切設定しないこともでき、キーの一部またはすべてが押されたか、まったく押されていないことを示します。 たとえば、Ctrl キーと Alt キーの両方が押された場合、shift の値は 6 になります。 |
| *X,Y* | マウス ポインターの現在の位置を示す整数を返します。 X と Y の値は、画面の左上隅を基準にして常にピクセル単位で表されます。 |

### 解説

このイベントは、キャラクターの入力アクティブなクライアントにのみ送信されます。 ユーザーが入力アクティブなクライアントを持たないキャラクターまたはそのタスク バー アイコンをダブルクリックすると、サーバーは最後の入力アクティブなクライアントにイベントを送信します。 キャラクターが表示されている場合 ([Visible](visible-property) = **True**)、アクティブなクライアントを現在の入力アクティブ クライアントとして設定し、[**ActivateInput**](activateinput-event) イベントをそのクライアントに送信してから **DblClick** イベントを送信します。 キャラクターが非表示 (Visible = **False**) で、ユーザーがボタン 1 を使用してキャラクターのタスク バー アイコンをダブルクリックすると、キャラクターも自動的に表示されます。