---
layout: Conceptual
title: 既定の文字の読み込み - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/loading-the-default-character
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: 既定の文字の読み込み
document_id: 1728d6f2-eac9-ed92-0a2f-ac94d5e3fbc6
document_version_independent_id: 2bdf5183-c88e-d382-76c3-d042345bbc8b
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/loading-the-default-character.md
locale: ja-jp
ms.assetid: 4e91aef5-8402-401d-b09f-83be25011027
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/loading-the-default-character.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:55:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/loading-the-default-character.md
page_type: conceptual
toc_rel: toc.json
word_count: 912
asset_id: lwef/loading-the-default-character
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: d36076cc-4afe-1ad9-d8d0-2600e38ac3e6
---

# 既定の文字の読み込み - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

ファイル名を指定して特定の文字のみを直接読み込む代わりに、既定の文字 読み込むことができます。 既定の文字は、ユーザーが選択した共有の中央 Windows アシスタントを提供することを目的としたサービスです。 Microsoft エージェントには、既定の文字サービスの一部としてプロパティ シートが含まれています。これは、ユーザーが既定の文字の選択を変更できるようにする [文字プロパティ] ウィンドウと呼ばれます。

既定の文字の選択は、標準アニメーション セットをサポートする文字に制限され、文字間の基本的な一貫性レベルが確保されます。 これにより、キャラクターが追加のアニメーションを持つことから除外されることはありません。

ただし、既定の文字は汎用の使用を目的としており、他のアプリケーションで同時に共有される可能性があるため、アプリケーション専用の文字が必要な場合は、既定の文字を読み込むのを避けてください。

既定の文字を読み込むには、ファイル名またはパスを指定せずに [**Load**](load-method) メソッドを呼び出します。 Microsoft エージェントは、現在の文字セットを既定の文字として自動的に読み込みます。 ユーザーがまだ既定の文字を選択していない場合、エージェントは標準アニメーション セットをサポートする最初の文字を選択します。 利用可能なものがない場合、メソッドは失敗し、その原因を報告します。

クライアント アプリケーションは文字の ID を問い合わせることができますが、設定を変更できるのはユーザーだけです。 [**ShowDefaultCharacterProperties**](showdefaultcharacterproperties-method) を使用して、[文字のプロパティ] ウィンドウを表示できます。

サーバーは、ユーザーが文字選択を変更したときに既定の文字を読み込んだクライアントに通知し、新しい文字の GUID を渡します。 サーバーは、元の文字を自動的にアンロードし、新しい文字を再読み込みします。 既定の文字を読み込んだクライアントのキューは停止され、フラッシュされます。 ただし、文字のファイル名を使用して文字を明示的に読み込んだクライアントのキューは影響を受けません。 必要に応じて、サーバーは新しい文字のテキスト読み上げ (TTS) エンジンの自動的なリセットも処理します。