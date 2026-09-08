---
layout: Conceptual
title: 文字のインストール - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/installing-your-character
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: 文字のインストール
document_id: 79c769fb-0bfa-5f44-ec00-fbbfc7d5b11a
document_version_independent_id: a25d45f9-a88b-28a6-5794-bcbb5091ee52
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/installing-your-character.md
locale: ja-jp
ms.assetid: 8e1414e7-d315-4fa5-8803-2c0147a5fb54
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/installing-your-character.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:53:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/installing-your-character.md
page_type: conceptual
toc_rel: toc.json
word_count: 181
asset_id: lwef/installing-your-character
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: d2232642-506d-48b9-b746-ebf2db9c5abb
---

# 文字のインストール - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

アシスタント ギャラリーに文字を表示するには、ユーザーの Application Data フォルダー内の Microsoft\Office\Actors フォルダーにインストールします。 Application Data フォルダーは、Windows ディレクトリまたは Windows ディレクトリ内のユーザー プロファイル ディレクトリにあります。 たとえば、Windows 2000 では、"C:\Documents and Settings\YourLoginName\Application Data\Microsoft\Office\Actors" に文字をインストールできます。