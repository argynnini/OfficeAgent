---
layout: Conceptual
title: サウンド エディターのインストール - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/installing-the-sound-editor
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: サウンド エディターのインストール
document_id: b6d861b3-4a01-f3ed-62d9-4285ad98fbd5
document_version_independent_id: 8535943a-db80-1497-53b2-b1ced49f1a28
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/installing-the-sound-editor.md
locale: ja-jp
ms.assetid: 0ce35b29-1cf3-4068-91b8-04231cb02a9d
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/installing-the-sound-editor.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:53:00.0000000Z
ms.translationtype: HT
ms.contentlocale: ja-jp
loc_version: 2024-03-25T16:31:50.9328632Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/installing-the-sound-editor.md
page_type: conceptual
toc_rel: toc.json
word_count: 658
asset_id: lwef/installing-the-sound-editor
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 57f50347-22b3-2f9b-3507-4d2862b08b03
---

# サウンド エディターのインストール - Win32 apps | Microsoft Learn

[Microsoft Agent は Windows 7 の時点で非推奨となり、後続のバージョンの Windows では使用できない可能性があります。]

サウンド エディターを使用するための推奨されるシステム構成は、Pentium 166、少なくとも 48 MB (メガバイト) RAM、および Windows 互換のサウンド カードを備えた PC です。 このツールを使用して音声入力を記録する場合は、互換性のあるマイクも必要です。

Microsoft Linguistic Sound Editing Tool をインストールするには、その自己解凍インストール ファイルを開きます。 これにより、適切なファイルがシステムに自動的にインストールされます。 Microsoft Agent の Web サイトからサウンド エディターをダウンロードする場合は、ダウンロード後にエディターをインストールするか、ディスクに保存して、後で開いてインストールすることができます。 インストール ツールは、Microsoft Agent の Tools サブディレクトリにインストールすることをお勧めします。 この保存場所を使用することをお勧めします。

サウンド エディターを使用するには、Microsoft Command および Microsoft コントロール音声認識エンジン (バージョン 4.0) もインストールする必要があります。 通常、これはサウンド エディターと共にインストールされますが、後でアンインストールした場合は、Microsoft Platform SDK または Microsoft Agent の Web サイトから再インストールできます。 サウンド エディターは、音声エンジンでサポートされている言語に基づいた言語情報のみを生成できます。 他の言語の情報を生成するには、その言語に対して互換性のある音声認識エンジンをインストールする必要があります。 Microsoft Linguistic Sound Editing Tool をサポートしているかどうかを判断するには、音声エンジンのベンダーにお問い合わせください。