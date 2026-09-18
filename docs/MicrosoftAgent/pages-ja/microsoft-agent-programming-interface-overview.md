---
layout: Conceptual
title: Microsoft エージェント プログラミング インターフェイスの概要 - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/microsoft-agent-programming-interface-overview
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Microsoft エージェント プログラミング インターフェイスの概要
document_id: d054e901-17c1-c0cd-854e-953bfdb750ae
document_version_independent_id: eab2f641-03f9-07e0-dc08-e20d024d1172
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/microsoft-agent-programming-interface-overview.md
locale: ja-jp
ms.assetid: 8709441b-9739-4f11-a2de-40a5f5eefb72
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/microsoft-agent-programming-interface-overview.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:55:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/microsoft-agent-programming-interface-overview.md
page_type: conceptual
toc_rel: toc.json
word_count: 839
asset_id: lwef/microsoft-agent-programming-interface-overview
item_type: Content
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 318b5321-4667-b808-c11e-bc0001311a36
---

# Microsoft エージェント プログラミング インターフェイスの概要 - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

Microsoft Agent API は、アニメーション化されたキャラクターの表示とアニメーションをサポートするサービスを提供します。 OLE オートメーション (コンポーネント オブジェクト モデル [COM]) サーバーとして実装された Microsoft Agent を使用すると、クライアントまたはクライアント アプリケーションと呼ばれる複数のアプリケーションを同時にホストし、そのアニメーション、入力、出力サービスにアクセスできます。 クライアントには、Microsoft エージェントの COM インターフェイスに接続する任意のアプリケーションを指定できます。

COM サーバーとして、Microsoft エージェントは、クライアント アプリケーションが COM インターフェイスと要求を使用して接続する場合にのみ自動的に起動します。 すべてのクライアントが接続を閉じるまで、実行されたままです。 接続されたクライアントが残っていない場合、Microsoft エージェントは自動的に終了します。

Microsoft エージェントの COM インターフェイスは直接呼び出すことができますが、Microsoft エージェントには Microsoft ActiveX コントロールも含まれています。 このコントロールを使用すると、ActiveX コントロール インターフェイスをサポートするプログラミング言語から Microsoft エージェントのサービスに簡単にアクセスできます。

Windows 用に作成されたスタンドアロン プログラムのサポートに加えて、ブラウザーが ActiveX インターフェイスをサポートしている場合は、Web ページをサポートするようにエージェントをスクリプト化できます。 Microsoft Internet エクスプローラーには、ActiveX のサポートと、エージェントのプログラミングに使用できるスクリプト言語が含まれています。 インターネット エクスプローラーを使用していない場合は、ブラウザーの ActiveX のサポートについてベンダーまたはサプライヤーに問い合わせてください。

次の情報は、Microsoft エージェント ソフトウェアのプログラミング インターフェイスの概要を示しています。

- [アニメーション サービス](animation-services)
- [入力サービス](input-services)
- [\[音声コマンド\] ウィンドウ](the-voice-commands-window)
- [出力サービス](output-services)