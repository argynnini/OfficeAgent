---
layout: Conceptual
title: VoiceCaption プロパティ (Command オブジェクト) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/voicecaption-property-c
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Command オブジェクトの VoiceCaption プロパティについて説明します。このプロパティは、[音声コマンド] ウィンドウで Command オブジェクトに表示されるテキストを設定または返します。
document_id: 7d806b59-78c6-7a24-0dc4-883b03c54b73
document_version_independent_id: d8ce3ce9-85d7-4cd7-daeb-ce7a6985378e
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/voicecaption-property-c.md
locale: ja-jp
ms.assetid: 97a3015c-6c39-42d5-b6bd-7563bd444b38
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/voicecaption-property-c.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:04:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/voicecaption-property-c.md
page_type: conceptual
toc_rel: toc.json
word_count: 373
asset_id: lwef/voicecaption-property-c
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 9de27910-501b-1234-1a17-6e06cedd122b
---

# VoiceCaption プロパティ (Command オブジェクト) - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 音声コマンド ウィンドウの [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトに表示されるテキストを設定または取得します。
- **構文の**
    - \*agent.\***Characters("*CharacterID*")。Commands("*Name*").VoiceCaption** [ = 文字列 ]

| 部分 | 形容 |
| --- | --- |
| 文字列 *を* する | 表示されるテキストに評価される文字列式。 |

## 備考

[**Commands**](https://www.bing.com/search?q=**Commands**) コレクションで [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトを定義し、その [**Voice**](voice-property) プロパティを設定する場合は、通常、その [**VoiceCaption**](voicecaption-property) プロパティも設定します。 このテキストは、クライアント アプリケーションが入力アクティブで、文字が表示されている場合に、[音声コマンド] ウィンドウに表示されます。 このプロパティが設定されていない場合、[**Caption**](caption-property) プロパティの設定によって表示されるテキストが決まります。 **VoiceCaption** プロパティと caption **プロパティ** どちらも設定されていない場合、コマンドは [音声コマンド] ウィンドウに表示されません。

### 関連項目

[**Caption プロパティの**](caption-property)