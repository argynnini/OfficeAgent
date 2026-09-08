---
layout: Conceptual
title: SoundEffectsOn プロパティ - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/soundeffectson-property
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: SoundEffectsOn プロパティ
document_id: bdebb33b-5709-bf76-dc77-e88be5292b6b
document_version_independent_id: bb30cf87-677b-82f4-6ebf-e62b9e82f42b
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/soundeffectson-property.md
locale: ja-jp
ms.assetid: 478c4748-5ca1-4237-958a-17f0a476c32c
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/soundeffectson-property.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:00:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/soundeffectson-property.md
page_type: conceptual
toc_rel: toc.json
word_count: 308
asset_id: lwef/soundeffectson-property
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: a1947af8-d8fa-d8ae-5406-f89a39549c68
---

# SoundEffectsOn プロパティ - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - キャラクターのサウンド エフェクトが有効かどうかを示す値を取得または設定します。
- **構文の**
    - エージェント *を*します。**Characters("*CharacterID*")。SoundEffectsOn** [ = ブール ]

| 部分 | 形容 |
| --- | --- |
| ブール | サウンド エフェクトを有効にするかどうかを指定するブール式。 **True** サウンド エフェクトが有効になっています。**False** サウンド エフェクトは無効になっています。 |

## 備考

このプロパティは、キャラクターのアニメーションの一部として含まれるサウンド エフェクトが、アニメーションの再生時に再生されるかどうかを決定します。 このプロパティの設定は、文字のすべてのクライアントに適用されます。