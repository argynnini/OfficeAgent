---
layout: Conceptual
title: 既定の文字プロパティ ウィンドウ - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/the-default-character-properties-window
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: 既定の文字プロパティ ウィンドウ
document_id: bdb932ac-9198-789e-5121-764bc768c6bd
document_version_independent_id: 16bf5c10-abf9-468b-8e51-1f951336ac38
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/the-default-character-properties-window.md
locale: ja-jp
ms.assetid: a775738e-c3f8-443e-b519-1df0a5d3e95d
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/the-default-character-properties-window.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:02:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/the-default-character-properties-window.md
page_type: conceptual
toc_rel: toc.json
word_count: 334
asset_id: lwef/the-default-character-properties-window
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 142be42c-e14d-917a-66c8-5564e9b57e1d
---

# 既定の文字プロパティ ウィンドウ - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

アプリケーションで特定の文字を読み込むことができるだけでなく、アプリケーションはユーザーの共有リソースである文字 ( *既定の文字*と呼ばれます) を読み込むことができます。 既定の文字は任意のアプリケーションからアクセスできますが、文字はユーザーのみが選択できます。 この文字の選択を容易にするために、エージェントは、既定の文字プロパティ ウィンドウと呼ばれる、この文字を選択するためのアクセスを提供するウィンドウを提供します。 このウィンドウへのアクセスは、エージェント API からサポートされています。

![\[genie 文字のプロパティ\] ダイアログ ボックス](images/f8dpwin.gif)

既定の文字プロパティ ウィンドウを使用して、既定の文字以外の文字を選択することはできません。