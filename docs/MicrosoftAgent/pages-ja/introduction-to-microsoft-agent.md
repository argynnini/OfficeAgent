---
layout: Conceptual
title: Microsoft エージェントの概要 - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/introduction-to-microsoft-agent
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Microsoft エージェントの概要
document_id: b09f6164-bee6-6f1b-8319-7f729c12e61a
document_version_independent_id: e01a9850-1cc3-c5d7-e9d5-8591e75ce4e5
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/introduction-to-microsoft-agent.md
keywords:
- Microsoft エージェント、概要
locale: ja-jp
ms.assetid: a58338e6-e59a-49d1-b291-1b926a8d66cf
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/introduction-to-microsoft-agent.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:54:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/introduction-to-microsoft-agent.md
page_type: conceptual
toc_rel: toc.json
word_count: 920
asset_id: lwef/introduction-to-microsoft-agent
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: f25b2b86-b92e-03fb-0ed3-b60ada0d84ee
---

# Microsoft エージェントの概要 - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

Microsoft エージェントは、対話型のアニメーション化されたキャラクターのプレゼンテーションをサポートするプログラム可能なソフトウェア サービスのセットです。 開発者は、対話型のアシスタントとして文字を使用して、ウィンドウ、メニュー、コントロールの従来の使用に加えて、Web ページやアプリケーションを紹介、ガイド、楽しませる、またはその他の方法で拡張することができます。

Microsoft エージェントを使用すると、ソフトウェア開発者と Web 作成者は、人間のソーシャル コミュニケーションの自然な側面を活用する、会話インターフェイスと呼ばれる新しい形式のユーザー操作を組み込むことができます。 Microsoft エージェントには、マウスとキーボードの入力に加えて、アプリケーションが音声コマンドに応答できるように、音声認識のオプションのサポートが含まれています。 文字は、合成された音声、録音されたオーディオ、または漫画の単語吹き出しのテキストを使用して応答できます。

Microsoft エージェント サービスによって促進される会話インターフェイス アプローチは、従来のグラフィカル ユーザー インターフェイス (GUI) 設計に代わるものではありません。 代わりに、文字の相互作用を、ウィンドウ、メニュー、コントロールなどの従来のインターフェイス コンポーネントと簡単に組み合わせて、アプリケーションのインターフェイスを拡張および拡張できます。

Microsoft エージェントのプログラミング インターフェイスを使用すると、ユーザー入力に応答する文字を簡単にアニメーション化できます。 アニメーション化されたキャラクターは、独自のウィンドウに表示され、画面に表示できる場所に対して最大限の柔軟性を提供します。 Microsoft エージェントには、Visual Basic Scripting Edition (VBScript) などの Web スクリプト言語を含む、ActiveX をサポートするプログラミング言語からサービスにアクセスできるようにする ActiveX コントロールが含まれています。 これは、OBJECT&gt; タグを使用して HTML ページからでも文字の相互作用を&lt;プログラムできることを意味します。

次のリンクで、Windows Vista の Microsoft エージェントの音声および音声認識機能の変更を探します。

- [Windows Vista での Microsoft エージェントの変更](microsoft-agent-changes-in-windows-vista)