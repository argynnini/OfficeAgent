---
layout: Conceptual
title: Speed プロパティ - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/speed-property
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Speed プロパティ
document_id: ee21fece-ddb6-e7cb-ed65-a8873faba741
document_version_independent_id: 4ea69575-6021-4128-6467-2d420cfab01e
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/speed-property.md
locale: ja-jp
ms.assetid: 43d0480b-d3a5-4992-a2a5-80eba37221e4
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/speed-property.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:01:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/speed-property.md
page_type: conceptual
toc_rel: toc.json
word_count: 362
asset_id: lwef/speed-property
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: d73f0ca1-925c-51e4-c261-df2477e1401d
---

# Speed プロパティ - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 文字の音声出力の現在の速度を指定する長整数を返します。
- **構文の**
    - エージェント \*\* です。characters ("***CharacterID***")。速度\*\*

## 備考

このプロパティは、文字の現在の読み上げ出力速度の設定を返します。 TTS 出力を使用する文字の場合、プロパティは文字の実際の TTS 出力設定を返します。 TTS が有効になっていないか、文字が TTS 出力をサポートしていない場合、設定には出力速度のユーザー設定が反映されます。

アプリケーションではこの値を書き込めませんが、特定の発話の出力を一時的に高速化 **Spd** (速度) タグを出力テキストに含めることができます。 ただし、**Spd** タグを使用して文字の読み上げ出力を変更しても、**Speed** プロパティの設定には影響しません。 詳細については、「音声出力タグの 」を参照してください。