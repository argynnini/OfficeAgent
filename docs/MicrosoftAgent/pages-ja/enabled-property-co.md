---
layout: Conceptual
title: Enabled プロパティ (Command オブジェクト) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/enabled-property-co
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Enabled Command オブジェクト プロパティについて説明します。 Microsoft エージェントは、Windows 7 の時点で非推奨です。
document_id: e96dd39b-f131-6658-88bb-0e7bbf2c6750
document_version_independent_id: 99172b9a-ffca-5222-e29e-4c8ed52ae3af
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/enabled-property-co.md
locale: ja-jp
ms.assetid: d9dcbdf0-ba35-4ebd-b6f2-f3c8bdfc0431
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/enabled-property-co.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:40:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/enabled-property-co.md
page_type: conceptual
toc_rel: toc.json
word_count: 343
asset_id: lwef/enabled-property-co
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 2ebec279-6381-1006-0933-54dd04e28533
---

# Enabled プロパティ (Command オブジェクト) - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 指定した文字のポップアップ メニューで **コマンド** が有効かどうかを示す値を取得または設定します。
- **構文の**
    - エージェント \*\* です。characters ("***CharacterID***")。Commands("***名***")。Enabled\*\* [ = *boolean*]

| 部分 | 形容 |
| --- | --- |
| ブール | **コマンド** が有効かどうかを指定するブール式。<br>- **True**<br>    - **コマンド** が有効になっています。<br>- false**の **<br>    - **コマンド** が無効になっています。 |

## 備考

[**Enabled**](enabled-property) プロパティが **True**に設定されている場合、[**コマンド**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトのキャプションは、クライアント アプリケーションが入力アクティブのときに、文字のポップアップ メニューに通常のテキストとして表示されます。 **Enabled** プロパティが False 場合、キャプションは使用不可 (無効) テキストとして表示されます。 無効な **コマンド** にも、音声入力にはアクセスできません。