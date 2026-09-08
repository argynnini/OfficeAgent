---
layout: Conceptual
title: Active Voice を使用する - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/use-the-active-voice
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Active Voice を使用する
document_id: 3afb8870-2cb3-7653-9afe-15672673ac46
document_version_independent_id: dc02109b-ba34-b079-218f-43268f25d395
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/use-the-active-voice.md
locale: ja-jp
ms.assetid: 7a89ea83-1cf0-4bfb-8f69-63081f8adf48
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/use-the-active-voice.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:03:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/use-the-active-voice.md
page_type: conceptual
toc_rel: toc.json
word_count: 394
asset_id: lwef/use-the-active-voice
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: f834b1d9-c9b2-8b3a-1b82-b9ea9eef3042
---

# Active Voice を使用する - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

音声出力を使用してディレクティブ情報を提供したり、ユーザーの応答を引き出したりする場合は、アクティブな音声を使用し、ユーザーの期待されるアクションを明確に指定します。 次の例は、違いを示しています。

| ディレクティブ | 評価 |
| --- | --- |
| 番号を繰り返しましょう。 | ユーザーアクションなし |
| 数値が繰り返されます。 | パッシブ音声、ユーザー アクションなし |
| 番号が繰り返されている間にリッスンします。 | パッシブ音声 |
| 繰り返しを聞きます。 | 最適な選択 |

さらに、次の例に示すように、フレーズの末尾にキー情報を展開する出力を作成します。

| これは使わない | プロパティ |
| --- | --- |
| "3 桁は次の数字ですか? | "次の数字は 3 ですか? |
| "[OK] をクリックして開始します。 | "開始するには、[OK] をクリックします。 |
| "完了" と言って注文を完了します。 | "注文を完了するには、"完了" と言います。 |