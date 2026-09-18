---
layout: Conceptual
title: 言語情報サウンド編集ツールの使用 - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/using-the-microsoft-linguistic-information-sound-editing-tool
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Microsoft 言語情報サウンド編集ツールの使用
document_id: 03232695-d06b-e38e-e6e2-78b86553a479
document_version_independent_id: 949edac5-1e1c-240b-7dd2-fc4b7acf5897
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/using-the-microsoft-linguistic-information-sound-editing-tool.md
keywords:
- 言語情報サウンド編集ツール
locale: ja-jp
ms.assetid: 6f029798-129e-4d63-b92e-94e3b902480c
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/using-the-microsoft-linguistic-information-sound-editing-tool.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:03:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/using-the-microsoft-linguistic-information-sound-editing-tool.md
page_type: conceptual
toc_rel: toc.json
word_count: 428
asset_id: lwef/using-the-microsoft-linguistic-information-sound-editing-tool
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 8413dbdb-14ac-4ea9-6d36-399d068980c7
---

# 言語情報サウンド編集ツールの使用 - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

言語情報サウンド編集ツールを使用すると、Windows サウンド (.wav) ファイルを拡張するための音素と単語区切りの情報を生成して、高品質のリップ同期文字アニメーションをサポートできます。 次のセクションでは、ツールの使用方法について説明します。

- [サウンド エディターのインストール](installing-the-sound-editor)
- [サウンド エディターの起動](starting-the-sound-editor)
- [新しいサウンド ファイルの作成](creating-a-new-sound-file)
- [既存のサウンド ファイルの読み込み](loading-an-existing-sound-file)
- [言語情報の生成](generating-linguistic-information)
- [サウンド ファイルの保存](saving-a-sound-file)
- [コマンド リファレンス](command-reference)
- [ツール バー ボタン](toolbar-buttons)

サウンド エディターで生成された言語的に強化されたサウンド ファイルを使用して、Microsoft エージェントの文字出力のリップ同期をサポートできます。 これを行うには、ファイルをパラメーターとして [**Speak**](speak-method) メソッドに渡すだけです。 詳細については、「 [Microsoft エージェント コントロールのプログラミング](programming-the-microsoft-agent-control) 」または「 [Microsoft エージェント サーバー インターフェイスのプログラミング](programming-the-microsoft-agent-server-interface)」を参照してください。