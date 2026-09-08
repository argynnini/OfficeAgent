---
layout: Conceptual
title: SRStatus プロパティ - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/srstatus-property
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: SRStatus プロパティ
document_id: 76c6afbe-62d1-b233-e003-9e8e21ab939a
document_version_independent_id: ca7c8c7f-bba1-a1eb-9f65-ff78a718d1d1
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/srstatus-property.md
locale: ja-jp
ms.assetid: 67618a35-05e4-4bb3-b910-c75de6e32578
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/srstatus-property.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:01:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/srstatus-property.md
page_type: conceptual
toc_rel: toc.json
word_count: 937
asset_id: lwef/srstatus-property
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: d76102f5-b4bc-92e7-a51f-c974f5fcf0e5
---

# SRStatus プロパティ - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 文字の音声入力を開始できるかどうかを返します。
- **構文の**
    - \*agent.\***Characters("*CharacterID*")。SRStatus**

| 価値 | 形容 |
| --- | --- |
| 0 | 条件は音声入力をサポートします。 |
| 1 | このシステムでは、オーディオ入力デバイスを使用できません。 (マイクがインストールされているかどうかは検出されません。これは、ユーザーが正しくインストールされた入力対応サウンド カードと作業ドライバーがあるかどうかを検出することしかできない点に注意してください)。 |
| 2 | 別のクライアントがこの文字のアクティブなクライアントであるか、現在の文字が最上位ではありません。 |
| 3 | オーディオ入力または出力チャネルは現在ビジー状態であり、アプリケーションはオーディオを使用しています。 |
| 4 | 音声認識サブシステムの初期化中に、指定されていないエラーが発生しました。 これには、文字の言語設定に一致する音声エンジンが使用できない可能性が含まれます。 |
| 5 | ユーザーは、[高度な文字オプション] で音声入力を無効にしました。 |
| 6 | オーディオの状態を確認中にエラーが発生しましたが、エラーの原因がシステムによって返されませんでした。 |

## 備考

このプロパティは、オーディオ デバイスの状態など、音声入力をサポートするために必要な条件を返します。 [**Listen**](listen-method) メソッドを呼び出す前に、このプロパティを確認して、成功を確実にすることができます。

エージェント プロパティ シート (高度な文字オプション) で音声入力が有効になっている場合、このプロパティに対してクエリを実行すると、関連付けられているエンジンがまだ読み込まれていない場合は読み込まれ、音声サービスが開始されます。 つまり、リッスン キーを使用でき、リスニング ヒントが自動的に表示されます。 (リッスン キーとリッスン ヒントは、[高度な文字オプション] でも有効になっている場合にのみ有効になります)。ただし、音声が無効になっているときにプロパティに対してクエリを実行した場合、サーバーは音声サービスを開始しません。

このプロパティは、クライアント アプリケーションによる文字の使用にのみ適用されます。この設定は、文字の他のクライアントやクライアント アプリケーションの他の文字には影響しません。