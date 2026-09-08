---
layout: Conceptual
title: Name プロパティ (Characters オブジェクト) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/name-property
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Characters オブジェクトの Name プロパティについて説明します。 Microsoft エージェントは、Windows 7 の時点で非推奨です。
document_id: 933c2cb2-2871-dcef-d976-45b90fd80a82
document_version_independent_id: 05cf86a8-973f-2cec-c648-ecb859a735f7
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/name-property.md
locale: ja-jp
ms.assetid: vs|msagent|~\pacontrol_2bxm.htm
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/name-property.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:58:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/name-property.md
page_type: conceptual
toc_rel: toc.json
word_count: 363
asset_id: lwef/name-property
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: bb1b7b97-ec18-8ed5-dd0a-71ca89759abd
---

# Name プロパティ (Characters オブジェクト) - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 指定した文字の既定の名前を指定する文字列を設定または返します。
- **構文の**
    - エージェント \*\* です。characters ("***CharacterID***")。Name\*\* [ = *string*]

| 部分 | 形容 |
| --- | --- |
| 文字列 *を* する | 文字の名前に対応する文字列値 (現在の言語設定)。 |

## 備考

文字の **名** は、文字の [**LanguageID**](languageid-property) 設定によって異なります。 ある言語の文字の名前が異なる場合や、別の言語とは異なる文字を使用する場合があります。 特定の言語の文字の既定の **名** は、文字が Microsoft エージェント文字エディターでコンパイルされるときに定義されます。

特に、他のクライアント アプリケーションが同じ文字を使用する場合に使用する場合は、文字の名前を変更しないでください。 また、エージェントは、文字の **名** を使用して、文字を非表示にして表示するためのコマンドを自動的に作成します。