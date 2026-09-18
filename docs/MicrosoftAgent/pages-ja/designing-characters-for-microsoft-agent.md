---
layout: Conceptual
title: Microsoft エージェントの文字の設計 - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/designing-characters-for-microsoft-agent
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Microsoft エージェントの文字の設計
document_id: e694f80b-39ca-9f43-079d-20ade23c62b3
document_version_independent_id: 215cc503-8f95-d482-2c15-32fa6d23f614
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/designing-characters-for-microsoft-agent.md
locale: ja-jp
ms.assetid: c424a4c6-6a36-4f0b-a3f1-2c91a513df75
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/designing-characters-for-microsoft-agent.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:39:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/designing-characters-for-microsoft-agent.md
page_type: conceptual
toc_rel: toc.json
word_count: 367
asset_id: lwef/designing-characters-for-microsoft-agent
item_type: Content
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 85b2a48c-e1e4-062d-ce15-45b58db5d18a
---

# Microsoft エージェントの文字の設計 - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

このドキュメントでは、Microsoft エージェントで使用するキャラクターの設計と開発に役立つ情報を提供します。 これには、キャラクター、画像、アニメーションのデザインに関する概念的および技術的な情報が含まれています。作成する必要がある画像のサイズ、色の使用、および種類。推奨されるアニメーション。話すアニメーション;および エージェントの状態。 効果的なアニメーションの原則は、視覚的に説得力のあるアニメーション化されたキャラクターを作成する際の使用についても説明されています。

次のセクションでは、Microsoft エージェントの文字をデザインする方法について説明します。

- [文字](characters)
- [アニメーション](animations)
- [エージェントの状態](agent-states)
- [アニメーションの原則](animation-principles)