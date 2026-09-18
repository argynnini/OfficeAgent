---
layout: Conceptual
title: 以前のバージョンからの更新 - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/updating-from-previous-version
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: 以前のバージョンからの更新
document_id: 4bcc1a66-1064-f708-52f7-e2670293ae92
document_version_independent_id: d8d6cf28-deaa-95cd-a762-fb1e46aa25ad
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/updating-from-previous-version.md
locale: ja-jp
ms.assetid: a3f0c0bb-8c12-4907-8e49-49b098449c38
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/updating-from-previous-version.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:03:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/updating-from-previous-version.md
page_type: conceptual
toc_rel: toc.json
word_count: 809
asset_id: lwef/updating-from-previous-version
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 82ae8a9b-a98c-8f87-d2e1-40400308b451
---

# 以前のバージョンからの更新 - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

以前の 1.5 バージョンの Microsoft Agent でビルドおよびコンパイルされたアプリケーションは、新しい 2.0 バージョンで変更せずに実行する必要があります。 [**Connected**](connected-property) プロパティを **False** に設定できなくなりました。置き換えられた SpeechInput オブジェクトの特定のプロパティは引き続き存在しますが、値は無効になり、サーバーは [**Restart**](https://www.bing.com/search?q=**Restart**) イベントと [**Shutdown**](https://www.bing.com/search?q=**Shutdown**) イベントを発生させなくなりました。

ただし、エージェント 2.0 コントロールを使用するようにアプリケーションを更新する場合は、コードの変更が必要になる場合があります。 2.0 バージョンの Microsoft エージェントをインストールし、以前のバージョンのエージェント コントロールを使用して Visual Basic プロジェクトを読み込んだ場合、Visual Basic には、新しいバージョンのコントロールが検出されたことを示すメッセージを自動的に表示するオプションが含まれています。 アプリケーションを適切に動作させるために、常に新しいバージョンを使用することを選択してください。

他のプログラミング言語 (Microsoft Office 97 VBA など) の場合、コントロールを更新するには、最初に 1.5 エージェント コントロールを削除してコードを保存する必要があります。 次に、プログラミング環境を終了し、プログラミング環境を再起動し、コードを再読み込みして、新しいコントロールを挿入します。 エージェント 1.5 対応アプリケーションを編集するのと同じプログラミング環境のインスタンスで、エージェント 2.0 対応アプリケーションを編集しないでください。 一部のプログラミング環境では、2 つのバージョンのコントロールの違いを処理できない場合があります。

エージェント 2.0 リリースをインストールした後、システムでエージェント 1.5 リリースをアンインストールできる必要があります。 ただし、2.0 リリースでエージェント 1.5 がインストールされている場合は、2.0 を再インストールする必要がある場合があります。