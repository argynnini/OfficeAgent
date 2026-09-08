---
layout: Conceptual
title: エージェント コントロールのプロパティ - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/agent-control-properties
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: エージェント コントロールのプロパティ
document_id: bf6fbd8f-f44c-58d2-0185-092178bd7bce
document_version_independent_id: b44c02dd-0f8c-5ea4-1bc8-6dbed8fb5fab
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/agent-control-properties.md
locale: ja-jp
ms.assetid: e6a5b2db-9abf-4988-be41-fc7f4530507f
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/agent-control-properties.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:36:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/agent-control-properties.md
page_type: conceptual
toc_rel: toc.json
word_count: 291
asset_id: lwef/agent-control-properties
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: f83394c1-3bd3-d367-c97f-dfde05e34a7f
---

# エージェント コントロールのプロパティ - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

次のプロパティは、エージェント コントロールから直接アクセスされます。

- 接続
- [**名の**](name-property-a)
- [**RaiseRequestErrors**](raiserequesterrors-property)

さらに、一部のプログラミング環境では、追加のデザイン時または実行時のプロパティが割り当てられる場合があります。 たとえば、Visual Basic では、実行時にコントロールがフォームのページに表示されない場合でも、フォーム上のコントロールの場所を定義する Left、Index、Tag、および Top プロパティが追加されます。

Suspended プロパティは下位互換性のために引き続きサポートされていますが、サーバーが中断状態 **サポートしなくなったため、常に False** を返します。