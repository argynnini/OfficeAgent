---
layout: Conceptual
title: Remove メソッド - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/remove-method
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Remove メソッド
document_id: d60b1928-805e-9c2c-6a07-7edd26078305
document_version_independent_id: 78b1fa0d-7033-7494-690b-0edee9852827
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/remove-method.md
locale: ja-jp
ms.assetid: b50d47b2-a425-4545-8d85-efeae460d2b1
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/remove-method.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:59:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/remove-method.md
page_type: conceptual
toc_rel: toc.json
word_count: 225
asset_id: lwef/remove-method
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 36ca48fd-3fd9-004a-d345-77e7a63c11f7
---

# Remove メソッド - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - [**Commands**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトを [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションから削除します。
- **構文の**
    - エージェント \*\* です。characters ("***CharacterID***")。Commands.Remove\*\**Name*

| 部分 | 形容 |
| --- | --- |
| *名の* | 必須。 コマンドの ID に対応する文字列値。 |

## 備考

[**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトがコレクションから削除されると、文字のポップアップ メニューが表示されたときや、クライアント アプリケーションが入力アクティブのときにコマンド ウィンドウに表示されなくなります。