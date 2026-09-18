---
layout: Conceptual
title: Status プロパティ - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/status-property
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Status プロパティ
document_id: f13d673e-cb4e-2609-44b6-5e3a7f03c73e
document_version_independent_id: 9a16fe01-381d-5cf2-a1af-da28f9310fb3
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/status-property.md
locale: ja-jp
ms.assetid: vs|msagent|~\pacontrol_8xd6.htm
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/status-property.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:01:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/status-property.md
page_type: conceptual
toc_rel: toc.json
word_count: 538
asset_id: lwef/status-property
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: fa1c4eac-ff87-326a-00ff-e4a75d2f11a7
---

# Status プロパティ - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - オーディオ出力チャネルの状態を返します。
- **構文の**
    - エージェント \*\* です。AudioOutput.Status\*\*

| 価値 | 形容 |
| --- | --- |
| 0 | オーディオ出力チャネルは使用可能です (ビジー状態ではありません)。 |
| 1 | オーディオ出力はサポートされません。たとえば、サウンド カードがないためです。 |
| 2 | オーディオ出力チャネルを開くことができない (ビジー状態)。たとえば、他のアプリケーションがオーディオを再生しているためです。 |
| 3 | サーバーがユーザーの音声入力を処理しているため、オーディオ出力チャネルはビジー状態です。 |
| 4 | 文字が現在話しているため、オーディオ出力チャネルはビジー状態です。 |
| 5 | オーディオ出力チャネルはビジーではありませんが、ユーザーの音声入力を待機しています。 |
| 6 | オーディオ出力チャネルにアクセスしようとしたときに、他の (不明な) 問題が発生しました。 |

## 備考

この設定により、クライアント アプリケーションはオーディオ出力チャネルに対してクエリを実行し、オーディオ出力チャネルの状態を示す整数値を返します。 これを使用して、キャラクターが話すのが適切かどうか、またはリスニング モードを有効にするのが適切かどうかを判断できます ([**Listen**](listen-method) メソッドを使用)。