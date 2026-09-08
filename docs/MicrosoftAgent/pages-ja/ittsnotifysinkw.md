---
layout: Conceptual
title: ITTSNotifySinkW - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/ittsnotifysinkw
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: ITTSNotifySinkW
document_id: 395338e3-591a-eafb-60b8-8bd8a9b1fb3b
document_version_independent_id: 180c27cb-94c8-174b-0749-7f37b4c76299
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/ittsnotifysinkw.md
locale: ja-jp
ms.assetid: 6305dad6-c162-458a-899e-628f6486680e
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/ittsnotifysinkw.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:54:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/ittsnotifysinkw.md
page_type: conceptual
toc_rel: toc.json
word_count: 414
asset_id: lwef/ittsnotifysinkw
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: acc6d87f-39a4-0e6c-2fe3-00b998a7dc3c
---

# ITTSNotifySinkW - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

エンジンは、[**AudioStop**](https://www.bing.com/search?q=**AudioStop**)、[**AudioStart**](https://www.bing.com/search?q=**AudioStart**)、および Visual呼び出す必要があります。 **Visual** コールバックは、IPA 音素を提供する必要があります。 (国際音声アルファベット [IPA] は、音声通信のふりがなの内容を記述するためのユニバーサル表記です。読み上げ可能なすべての音素は IPA で表現されます。IPA の詳細については、Microsoft Speech API 仕様 (Speech SDK 4.0 ダウンロードの一部) ([https://www.microsoft.com/speech/](https://msdn.microsoft.com/library/ee705648.aspx)) を参照してください。

[**Visual**](https://www.bing.com/search?q=**Visual**) 通知は非常に豊富ですが、Microsoft エージェントでは、**cIPAPhoneme** 値のみを使用して、キャラクターが話すにつれて口をアニメーション化します。 Microsoft エージェント互換エンジンでは、生成された発話のふりがなコンテンツを反映 **Visual** 通知の密接に同期されたストリームを提供する必要があります。 この場合、話者と聞き手は口の位置と音響コンテンツの不一致にかなり敏感であるため、"比較的タイムリーな通知" は適切ではありません。 **Visual** 通知をすぐに返す必要があります。