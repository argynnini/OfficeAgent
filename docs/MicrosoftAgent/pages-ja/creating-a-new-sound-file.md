---
layout: Conceptual
title: 新しいサウンド ファイルの作成 - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/creating-a-new-sound-file
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: 新しいサウンド ファイルの作成
document_id: dd9e1e66-fae2-e5a2-865b-d7b055fc0954
document_version_independent_id: 34c45780-6037-2f64-4dbc-b4828c263015
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/creating-a-new-sound-file.md
locale: ja-jp
ms.assetid: ebaa0578-f5f0-4b36-bc5c-99178cc99299
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/creating-a-new-sound-file.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:39:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/creating-a-new-sound-file.md
page_type: conceptual
toc_rel: toc.json
word_count: 305
asset_id: lwef/creating-a-new-sound-file
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 3fcda1ae-3b04-0cbb-ae3a-80dd8658cea0
---

# 新しいサウンド ファイルの作成 - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

エディターを初めて起動するときに、**オーディオ** メニューから **Record** を選択するか、サウンド エディターのツール バーの [**Record**] ボタンをクリックして、システムに接続されているマイクに読み上げることで、新しいサウンド ファイルを作成できます。 ツールバーの **停止** ボタンをクリックして、記録を停止します。 **オーディオ** メニューまたはツール バーから **Play** コマンドを選択すると、Microsoft エージェントが言語的な機能強化なしでサウンド ファイルを処理する方法を確認できます。 別の新しいファイルを作成するには、**[ファイル]** メニューまたはツール バーから [新規作成] を選択します。