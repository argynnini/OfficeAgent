---
layout: Conceptual
title: サウンド ファイルの保存 - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/saving-a-sound-file
schema: Conceptual
author: QuinnRadich
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: サウンド ファイルの保存
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/59c690cd3dfda967a5ef3f15ec50d15eef24e6ce/desktop-src/lwef/saving-a-sound-file.md
locale: ja-jp
ms.assetid: b8b91883-e4d2-441a-b749-379c5ba661f8
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/saving-a-sound-file.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-08-20T17:22:00.0000000Z
feedback_system: Standard
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2022-09-20T02:42:24.4530879Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/saving-a-sound-file.md
page_type: conceptual
toc_rel: toc.json
feedback_product_url: ''
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 631
asset_id: lwef/saving-a-sound-file
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 29f5775e-d5cc-6faa-2627-2c7d8bbf2fd0
---

# サウンド ファイルの保存 - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。

サウンド ファイルを保存する準備ができたら、[**ファイル] メニュー**またはエディターのツール バーの [**保存**] コマンドを選択します。 エディターによって [名前を **付けて保存** ] ダイアログ ボックスが表示され、ファイルの言語情報を生成したかどうかに基づいて、名前と既定のファイルの種類が提案されます。 ファイルをサウンド ファイル (.wav) として保存すると、エディターによってオーディオ データだけが保存されます。 ファイル情報を言語的に強化されたサウンド ファイル (.lwv) として保存すると、単語と音素の情報が変更されたサウンド ファイルの一部として自動的に含まれます。 名前、場所、ファイルの種類、形式を確認または編集したら、[ **保存** ] ボタンを選択します。

![Screenshot that shows the 'Save As' dialog with a 'File name', 'Save as type', 'Format', and 'Attributes' selected.](images/f7listsave.gif)

新しい名前、別の場所、または別の形式でサウンド ファイルを保存する場合は、[**ファイル**] メニューの [**名前を付けて保存**] コマンドを選択します。 [ **名前を付けて保存** ] ダイアログ ボックスが表示されたら、新しいファイル名を入力し、[ **保存** ] ボタンをクリックします。

サウンド ファイルの一部を保存することもできます。 たとえば、ファイルの先頭または末尾に過度の無音を付けずにファイルを保存できます。 オーディオ リプレゼンテーションで、保存するファイルの一部を選択し、[**ファイル**] メニューから [**名前を付けて選択を保存**] を選択します。 このコマンドは、[Audio Representation]\( **オーディオリプレゼンテーション**\) で選択した場合にのみ有効になります。