---
layout: Conceptual
title: SoundEffects プロパティ - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/soundeffects-property
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: SoundEffects プロパティ
document_id: 328a17ef-3c77-b25b-5e50-0db42c6d4109
document_version_independent_id: 16f52682-503d-1844-1aaf-edb7bba08850
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/soundeffects-property.md
locale: ja-jp
ms.assetid: 39e48e5f-b24e-48ce-b5a3-85467ac252e9
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/soundeffects-property.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:00:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/soundeffects-property.md
page_type: conceptual
toc_rel: toc.json
word_count: 359
asset_id: lwef/soundeffects-property
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: c3d29b6a-588b-a61d-86c8-37b3310b6093
---

# SoundEffects プロパティ - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - サウンド エフェクト (.WAV) ファイルがキャラクターのアクションの一部として構成されると再生されます。
- **構文の**
    - エージェント \*\* です。AudioOutput.SoundEffects\*\*

| 価値 | 形容 |
| --- | --- |
| **True** | キャラクターサウンドエフェクトが有効になっています。 |
| false **の** | 文字サウンド効果が無効になっています。 |

## 備考

このプロパティは、[エージェント] プロパティ シートの [出力] ページの [Play Character Sound Effects]\(文字の効果音の再生\) オプションを反映します ([高度な文字オプション])。 **SoundEffects** プロパティが true 返すと、文字の定義に含まれるサウンド エフェクトが再生されます。 False 場合、サウンド エフェクトは再生されません。 プロパティの設定は、すべての文字に影響し、読み取り専用です。このプロパティ値を設定できるのは、ユーザーだけです。