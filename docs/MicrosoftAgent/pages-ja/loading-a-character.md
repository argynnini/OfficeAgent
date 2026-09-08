---
layout: Conceptual
title: 文字の読み込み - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/loading-a-character
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: 文字の読み込み
document_id: a9c6a9c0-1884-a550-7d23-9ab8df1796c0
document_version_independent_id: a7d23ce2-a34e-d005-655e-171ec1001812
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/loading-a-character.md
locale: ja-jp
ms.assetid: 973de75b-b530-40c6-896d-e2ab0755ae2c
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/loading-a-character.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:55:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/loading-a-character.md
page_type: conceptual
toc_rel: toc.json
word_count: 726
asset_id: lwef/loading-a-character
item_type: Content
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: a4e65760-5419-8311-2fa0-a57e3614bb24
---

# 文字の読み込み - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

キャラクターをアニメーション化するには、最初にキャラクターを読み込む必要があります。 文字のデータを読み込むには、[**Load**](load-method) メソッドを使用します。 Microsoft Agent では、文字データとアニメーション データの 2 つの形式がサポートされています。1 つの構造化ファイルと個別のファイルです。 通常は、1 つのファイル形式 (.ACS) は、データがローカルに格納されている場合に使用されます。 複数のファイル形式 (.ACF、.ACA) は、HTTP サーバーからアニメーションにアクセスする場合など、アニメーションを個別にダウンロードする場合に最適です。

クライアント アプリケーションは、同じ文字の 1 つのインスタンスのみを読み込むことができます。 同じ文字を複数回読み込もうとすると失敗します。 ただし、アプリケーションは、Microsoft エージェントへの個別の接続を提供することで、同じ文字の複数のインスタンスを読み込むことができます。 たとえば、アプリケーションは、Microsoft エージェント コントロールの 2 つのコピーから同じ文字を読み込むことができます。

Microsoft エージェントで使用する独自の文字を定義することもできます。 最終的に Windows ビットマップフォーマットファイルを使用する場合は、イメージの作成に好むレンダリング ツールを使用できます。 Microsoft エージェントで使用するためにキャラクターのイメージを組み立ててアニメーションにコンパイルするには、Microsoft Agent Character Editor を使用します。 このツールを使用すると、キャラクタの既定のプロパティを定義できるほか、キャラクタのアニメーションを定義できます。 Microsoft エージェント文字エディターでは、文字を作成するときに適切なファイル形式を選択することもできます。