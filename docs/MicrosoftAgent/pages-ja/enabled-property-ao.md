---
layout: Conceptual
title: Enabled プロパティ (AudioOutput オブジェクト) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/enabled-property-ao
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Enabled AudioOutput オブジェクト プロパティについて説明します。 Microsoft エージェントは、Windows 7 の時点で非推奨です。
document_id: 3e334f08-02ef-c28f-c3d8-cb7f2468a0e0
document_version_independent_id: 7e31dd86-9ad4-c5ec-7d90-ceaa2e7591bb
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/enabled-property-ao.md
locale: ja-jp
ms.assetid: 6526f249-be13-4732-b79e-a9952489461f
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/enabled-property-ao.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:40:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/enabled-property-ao.md
page_type: conceptual
toc_rel: toc.json
word_count: 420
asset_id: lwef/enabled-property-ao
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: d0ff1f31-c677-70a3-54ce-526f7ee8cda1
---

# Enabled プロパティ (AudioOutput オブジェクト) - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - オーディオ (音声) 出力が有効かどうかを示すブール値を返します。
- **構文の**
    - エージェント \*\* です。AudioOutput.Enabled\*\*

| 価値 | 形容 |
| --- | --- |
| **True** | (既定値)音声オーディオ出力が有効になっています。 |
| false **の** | 音声オーディオ出力が無効になっています。 |

## 備考

このプロパティは、[エージェント] プロパティ シートの [出力] ページの [オーディオ出力の再生] オプションを反映します (文字の詳細設定オプション)。 [**Enabled**](enabled-property) プロパティが true 返す場合、互換性のある TTS エンジンがインストールされている場合、または音声出力にサウンド ファイルを使用する場合、[**Speak**](speak-method) メソッドはオーディオ出力を生成します。 False 返される場合は、音声出力がインストールされていないか、ユーザーによって無効にされていることを意味します。 プロパティの設定は、すべてのエージェント文字に適用され、読み取り専用です。このプロパティ値を設定できるのは、ユーザーだけです。