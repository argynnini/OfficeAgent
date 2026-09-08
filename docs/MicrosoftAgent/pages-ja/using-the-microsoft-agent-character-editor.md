---
layout: Conceptual
title: Microsoft エージェント キャラクター エディターの使用 - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/using-the-microsoft-agent-character-editor
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Microsoft エージェント キャラクター エディターの使用
document_id: f638b90b-2e36-4ec4-8731-3af20822e1ee
document_version_independent_id: d3d9fd5e-2fa8-3a11-8ae7-92ac505546b9
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/using-the-microsoft-agent-character-editor.md
locale: ja-jp
ms.assetid: c606c90b-0fd2-4899-9ffd-153fdaf9c80c
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/using-the-microsoft-agent-character-editor.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:03:00.0000000Z
ms.translationtype: HT
ms.contentlocale: ja-jp
loc_version: 2024-03-25T16:31:50.9328632Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/using-the-microsoft-agent-character-editor.md
page_type: conceptual
toc_rel: toc.json
word_count: 467
asset_id: lwef/using-the-microsoft-agent-character-editor
item_type: Content
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: b579838a-66d0-d43d-e7f4-533a216c85b2
---

# Microsoft エージェント キャラクター エディターの使用 - Win32 apps | Microsoft Learn

[Microsoft Agent は Windows 7 の時点で非推奨となり、後続のバージョンの Windows では使用できない可能性があります。]

Microsoft エージェント キャラクター エディターを使用すると、Microsoft エージェントで使用するキャラクター アニメーションをコンパイルできます。 Windows ビットマップ イメージをインポートし、その期間を設定し、必要に応じて分岐、サウンド エフェクト、読み上げオーバーレイを含めることで、アニメーションを定義できます。 キャラクターのアニメーションのデザインの詳細については、「[Microsoft Agent のキャラクターのデザイン](designing-characters-for-microsoft-agent)」を参照してください。

エージェント キャラクター エディターを使用すると、キャラクターの名前と説明、およびテキスト読み上げ (TTS)、合成音声出力、ポップアップ メニューのサポート、キャラクターの吹き出しデザインなどの出力オプションを定義できます。

このドキュメントでは、Microsoft Agent 用の Microsoft エージェント キャラクター エディターについて説明します。これは https://download.cnet.com/microsoft-agent-character-editor/3000-2206_4-10010178.html からダウンロードできます。

- [エージェント キャラクター エディターの起動](starting-the-agent-character-editor)
- [新しいキャラクターの定義](defining-a-new-character)
- [アニメーションの作成](creating-animations)
- [コマンド リファレンス](command-reference-)
- [ツール バーのボタン](toolbar-buttons-)