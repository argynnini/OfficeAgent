---
layout: Conceptual
title: Microsoft エージェント サーバー インターフェイスのプログラミング - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/programming-the-microsoft-agent-server-interface
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Microsoft エージェント サーバー インターフェイスのプログラミング
document_id: 8b7e133a-43a0-a9c8-39fb-73d75fabc5a6
document_version_independent_id: 3da208c1-16bd-9e38-b334-7d5dabf89313
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/programming-the-microsoft-agent-server-interface.md
locale: ja-jp
ms.assetid: d1f9feb1-afcf-45a5-8ebf-7200c5963f70
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/programming-the-microsoft-agent-server-interface.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:59:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/programming-the-microsoft-agent-server-interface.md
page_type: conceptual
toc_rel: toc.json
word_count: 376
asset_id: lwef/programming-the-microsoft-agent-server-interface
item_type: Content
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 461923a4-96e3-f223-bda6-3d1dec0792ba
---

# Microsoft エージェント サーバー インターフェイスのプログラミング - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

Microsoft エージェントには、アプリケーションからアニメーション化されたキャラクターをプログラミングできるサービスが用意されています。 これらのサービスは、OLE オートメーション サーバーとして実装されます。 OLE オートメーションを使用すると、アプリケーションは別のアプリケーションのオブジェクトをプログラムで制御できます。 このドキュメントでは、コンポーネント オブジェクト モデル (COM) と OLE について理解していることを前提としています。 これらのサービスの概要については、「 [プログラミング インターフェイスの概要](microsoft-agent-programming-interface-overview)」を参照してください。

- [アプリケーションへの Microsoft エージェント機能の追加](adding-microsoft-agent-functionality-to-your-application)
- [文字データとアニメーション データの読み込み](loading-character-and-animation-data)
- [通知シンクの作成](creating-a-notification-sink)
- [Java を使用したサービスへのアクセス](accessing-services-using-java)
- [Speech Services へのアクセス](accessing-speech-services)
- [参照](reference)