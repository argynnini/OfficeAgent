---
layout: Conceptual
title: Visual Basic やその他のプログラミング言語からコントロールにアクセスする - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/accessing-the-control-from-visual-basic-and-other-programming-languages
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Visual Basic やその他のプログラミング言語からコントロールにアクセスする
document_id: b0195058-9dfa-5b22-83a8-b7b27ea4bf4f
document_version_independent_id: ad4a4ab5-4d00-3e31-4f59-8cdfae6e03a8
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/accessing-the-control-from-visual-basic-and-other-programming-languages.md
locale: ja-jp
ms.assetid: 869b8eb1-1f40-4d87-8501-e41d6c0a3a97
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/accessing-the-control-from-visual-basic-and-other-programming-languages.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:36:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/accessing-the-control-from-visual-basic-and-other-programming-languages.md
page_type: conceptual
toc_rel: toc.json
word_count: 1177
asset_id: lwef/accessing-the-control-from-visual-basic-and-other-programming-languages
item_type: Content
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/c6f99e62-1cf6-4b71-af9b-649b05f80cce
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/3f56b378-07a9-4fa1-afe8-9889fdc77628
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: a0fc2738-6308-5b2f-8ea7-92b9444b686e
---

# Visual Basic やその他のプログラミング言語からコントロールにアクセスする - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

Visual Basic やその他のプログラミング言語から Microsoft エージェントのコントロールを使用することもできます。 言語が ActiveX コントロール インターフェイスを完全にサポートしていることを確認し、ActiveX コントロールを追加してアクセスするための規則に従ってください。 コントロールにアクセスするには、エージェントがターゲット システムに既にインストールされている必要があります。

その後、([実行] オプションではなく [保存] オプションを使用して) エージェントのセルフインストール キャビネット ファイルを Web サイトからダウンロードできます。 このファイルは、インストール セットアップ プログラムに含めることができます。 実行されるたびに、ターゲット システムにエージェントが自動的にインストールされます。 インストールの詳細については、Microsoft エージェント配布ライセンス契約を参照してください。 エージェントコンポーネントファイルのコピーや登録など、エージェントのセルフインストールキャビネットファイルを使用する以外のインストールはサポートされていません。 これにより、一貫性のある完全なインストールが保証されます。 Microsoft エージェントの自己インストール ファイルは、Microsoft Windows 2000 にはインストールされません。これは、そのバージョンのオペレーティング システムに独自のバージョンのエージェントが既に含まれているためです。

ターゲット システムにエージェントを正常にインストールするには、ターゲット システムに最新バージョンの Microsoft Visual C++ ランタイム (Msvcrt.dll)、Microsoft 登録ツール (Regsvr32.dll)、および Microsoft COM dll があることを確認する必要もあります。 必要なコンポーネントがターゲット システム上にあることを確認する最も簡単な方法は、Microsoft Internet Explorer 3.02 以降のインストールを要求することです。 または、Microsoft Visual C++ の一部として使用できる最初の 2 つのコンポーネントをインストールすることもできます。 必要な COM dll は、Microsoft Web サイトで入手できる Microsoft DCOM 更新プログラムの一部としてインストールできます。 これらのコンポーネントの詳細情報とライセンス情報は、Microsoft Web サイトで確認できます。

エージェントの言語コンポーネントは、同じ方法でインストールできます。 同様に、この手法を使用して、Microsoft エージェント Web サイトから配布できる Microsoft 文字の ACS 形式をインストールできます。 文字ファイルは、Microsoft Agent \Chars サブディレクトリに自動的にインストールされます。

Microsoft エージェントのコンポーネントはオペレーティング システム コンポーネントとして設計されているため、エージェントをアンインストールできない場合があります。 同様に、エージェントが Windows オペレーティング システムの一部として既にインストールされている場合、エージェントのセルフインストール キャビネットがインストールされない場合があります。