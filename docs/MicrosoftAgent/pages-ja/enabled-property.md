---
layout: Conceptual
title: Enabled プロパティ (Balloon オブジェクト) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/enabled-property
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Enabled Balloon オブジェクト プロパティについて説明します。 Microsoft エージェントは、Windows 7 の時点で非推奨です。
document_id: 0f32eef4-0584-a7bb-2a8a-0fecf161cd6e
document_version_independent_id: 04d10e52-225d-81f8-3f13-a236ce855298
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/enabled-property.md
locale: ja-jp
ms.assetid: 4d73acda-6fcc-4912-a466-570849aeb807
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/enabled-property.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:40:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/enabled-property.md
page_type: conceptual
toc_rel: toc.json
word_count: 290
asset_id: lwef/enabled-property
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: c321a885-d470-b668-abd5-935f0d55a5c2
---

# Enabled プロパティ (Balloon オブジェクト) - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 指定した文字に対してワード バルーンが有効になっているかどうかを返します。
- **構文の**
    - エージェント \*\* です。characters ("***CharacterID***")。Balloon.Enabled\*\*

| 価値 | 形容 |
| --- | --- |
| **True** | バルーンが有効になっています。 |
| false **の** | バルーンは無効になっています。 |

## 備考

**Enabled** プロパティは、バルーンが有効かどうかを指定するブール値を返します。 単語吹き出しの既定の状態は、Microsoft エージェント文字エディターで文字がコンパイルされるときに、文字の定義の一部として設定されます。 文字が吹き出しをサポートしないように定義されている場合、このプロパティは常に文字の false  されます。