---
layout: Conceptual
title: ShowPopupMenu メソッド - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/showpopupmenu-method
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: ShowPopupMenu メソッド
document_id: 38ed5b21-a7e1-93f2-0492-add87d9a48f7
document_version_independent_id: e6bdf577-a307-45ac-2593-1fdfae89894d
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/showpopupmenu-method.md
locale: ja-jp
ms.assetid: 7f964d53-2594-41b1-9450-1ba7e9f85882
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/showpopupmenu-method.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:00:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/showpopupmenu-method.md
page_type: conceptual
toc_rel: toc.json
word_count: 575
asset_id: lwef/showpopupmenu-method
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 32a2fe21-d189-1bc0-c540-e9ac4a80805c
---

# ShowPopupMenu メソッド - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 指定した位置に文字のポップアップ メニューを表示します。
- **構文の**
    - エージェント *します。**Characters("CharacterID")。ShowPopupMenu**x, y*

| 部分 | 形容 |
| --- | --- |
| *x* | 必須。 メニューを表示する水平 (*x*) 画面座標を示す整数値。 これらの座標はピクセル単位で指定する必要があります。 |
| *y* | 必須。 メニューを表示する垂直 (*y*) 画面座標を示す整数値。 これらの座標はピクセル単位で指定する必要があります。 |

## 備考

ユーザーが文字を右クリックすると、エージェントによって文字のポップアップ メニューが自動的に表示されます。 AutoPopupMenufalse **を**に設定した場合は、このメソッドを使用してメニューを表示できます。

ユーザーがコマンドを選択するか、別のメニューを表示するまで、メニューは表示されたままです。 一度に表示できるポップアップ メニューは 1 つだけです。したがって、このメソッドの呼び出しは、前のメニューをキャンセル (削除) します。

このメソッドは、クライアント アプリケーションが文字のアクティブなクライアントである場合にのみ呼び出す必要があります。それ以外の場合は失敗します。 このメソッドの成功を確認するには、関数として呼び出すことができます。メソッドが成功したかどうかを示すブール値が返されます。

```
   If Genie.ShowPopupMenu (10,10) = True Then
      ' The menu will be displayed

   Else 
      ' The menu will not be displayed

   End If
```