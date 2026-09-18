---
layout: Conceptual
title: Microsoft 言語情報サウンド編集ツールをサポートするための要件 - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/requirements-for-supporting-the-microsoft-linguistic-information-sound-editing-tool
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Microsoft 言語情報サウンド編集ツールをサポートするための要件
document_id: 06f98b70-52b7-1f2a-bf43-df0847ce68bb
document_version_independent_id: 8724eed8-1b7b-55f0-b4bf-43bc8aeab5ec
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/requirements-for-supporting-the-microsoft-linguistic-information-sound-editing-tool.md
locale: ja-jp
ms.assetid: 8ec9801c-e763-4586-b447-1ea6fb8470e6
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/requirements-for-supporting-the-microsoft-linguistic-information-sound-editing-tool.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:00:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/requirements-for-supporting-the-microsoft-linguistic-information-sound-editing-tool.md
page_type: conceptual
toc_rel: toc.json
word_count: 235
asset_id: lwef/requirements-for-supporting-the-microsoft-linguistic-information-sound-editing-tool
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 8a9e6bad-10cf-e684-14dd-2a7fbcbd9605
---

# Microsoft 言語情報サウンド編集ツールをサポートするための要件 - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

Microsoft 言語情報サウンド編集ツールは、音声認識エンジンを使用して、標準の Windows 波音 (.wav) ファイルの単語区切りとふりがな情報を生成します。 2.0 バージョンでは、他の音声エンジンでの使用がサポートされるようになりました。 サウンド エディターをサポートするベンダーは、コンテキストフリーの文法エンジンと次の要件に対して、エンジンが SAPI 4.0 仕様を完全にサポートしていることを確認する必要があります。

- [ISRResGraphEx と IAttributes](isrresgraphex-and-iattributes)