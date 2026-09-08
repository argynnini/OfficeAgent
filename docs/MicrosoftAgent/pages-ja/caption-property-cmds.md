---
layout: Conceptual
title: Caption プロパティ (Commands コレクション オブジェクト) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/caption-property-cmds
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Command Collection オブジェクトの Caption プロパティについて説明します。 Microsoft エージェントは、Windows 7 の時点で非推奨です。
document_id: b59f47fe-b6d2-6748-cdd5-f1e681e94b7b
document_version_independent_id: 2323bb6e-328b-0186-8989-552dbfdf612e
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/caption-property-cmds.md
locale: ja-jp
ms.assetid: 7182c21e-1ff0-4dce-9571-534b7576c082
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/caption-property-cmds.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:37:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-01-09T19:49:59.6397822Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/caption-property-cmds.md
page_type: conceptual
toc_rel: toc.json
word_count: 354
asset_id: lwef/caption-property-cmds
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: ead1f96d-7610-fa0a-197f-97e290bb3200
---

# Caption プロパティ (Commands コレクション オブジェクト) - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 文字のポップアップ メニューで [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) オブジェクトに表示されるテキストを指定します。
- **構文の**
    - エージェント \*\* です。Characters ("***CharacterID***").\*\*[Commands.Caption](caption-property) [ = *string*]

| 部分 | 形容 |
| --- | --- |
| 文字列 *を* する | キャプションとして表示されるテキストに評価される文字列式。 |

## 備考

[**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションの [**Caption**](caption-property) プロパティを設定すると、その [**Visible**](visible-property) プロパティが True に設定されていて、アプリケーションが入力アクティブクライアントでない場合に文字のポップアップ メニューに表示される方法が定義されます。 **Caption**のアクセス キー (線なしニーモニック) を指定するには、その文字の前にアンパサンド (&) 文字を含めます。

[**Caption**](caption-property)を持つ [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションのコマンドを定義する場合は、通常、関連付けられている **Commands** コレクションの **キャプション** も定義します。