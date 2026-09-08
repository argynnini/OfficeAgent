---
layout: Conceptual
title: VoiceCaption プロパティ (Commands オブジェクト) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/voicecaption-property
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Commands オブジェクトの VoiceCaption プロパティについて説明します。このプロパティは、[音声コマンド] ウィンドウで Commands オブジェクトに表示されるテキストを取得または設定します。
document_id: 79873e76-95ff-dc96-52e2-89a523cab029
document_version_independent_id: 59d5f475-2b65-fb5b-74bb-e8e487e0a678
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/voicecaption-property.md
locale: ja-jp
ms.assetid: 2c4fa175-fc2d-4474-b15f-7e838103a435
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/voicecaption-property.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:04:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/voicecaption-property.md
page_type: conceptual
toc_rel: toc.json
word_count: 451
asset_id: lwef/voicecaption-property
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 58bae9a2-f90a-c6e9-3de8-1dede4cafe0e
---

# VoiceCaption プロパティ (Commands オブジェクト) - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - [音声コマンド] ウィンドウの [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) オブジェクトに表示されるテキストを設定または返します。
- **構文の**
    - \*agent.\***Characters("*CharacterID*")。Commands.VoiceCaption** [ = *string*]

| 部分 | 形容 |
| --- | --- |
| 文字列 *を* する | 表示されるテキストに評価される文字列式。 |

## 備考

[**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションの [**Voice**](voice-property) プロパティを設定する場合は、通常、その **VoiceCaption** プロパティも設定します。 **VoiceCaption** テキスト設定は、クライアント アプリケーションが入力アクティブで文字が表示されている場合に、[音声コマンド] ウィンドウに表示されます。 このプロパティが設定されていない場合、**Commands** コレクションの [**Caption**](caption-property) プロパティの設定によって、表示されるテキストが決まります。 **VoiceCaption** プロパティまたは **Caption** プロパティが設定されていない場合、クライアント アプリケーションが入力アクティブになると、コレクション内のコマンドが "(undefined command)" の下の [音声コマンド] ウィンドウに表示されます。

**VoiceCaption** 設定では、リスニング ヒントに表示されるテキストも決定され、文字がリッスンするコマンドが示されます。