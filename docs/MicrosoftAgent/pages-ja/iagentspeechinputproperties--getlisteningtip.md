---
layout: Conceptual
title: IAgentSpeechInputProperties GetListeningTip - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentspeechinputproperties--getlisteningtip
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentSpeechInputProperties GetListeningTip
document_id: c4fd4650-8d60-f5eb-e16b-62ddfd0a4685
document_version_independent_id: 1ce7d03b-03ca-c757-1347-b2c8852747a4
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentspeechinputproperties--getlisteningtip.md
locale: ja-jp
ms.assetid: b0488a54-03f8-43ce-935c-dd49c6ed5dbc
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentspeechinputproperties--getlisteningtip.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:53:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentspeechinputproperties--getlisteningtip.md
page_type: conceptual
toc_rel: toc.json
word_count: 217
asset_id: lwef/iagentspeechinputproperties--getlisteningtip
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: cf34c88f-bb86-35b5-f686-f854d6a217be
---

# IAgentSpeechInputProperties GetListeningTip - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT GetListeningTip(
long * pbListeningTip  // address of variable for listening tip flag
);                       
```

Listening Tip が表示可能かどうかを示す値を取得します。

- 操作が成功したことを示すS\_OKを返します。

- pbListeningTip*を * する
    - リッスン ヒントの表示が有効になっている場合は **True** を受け取る変数のアドレス。リッスン ヒントが無効になっている場合は false **を** します。

GetEnabledが false 返した場合、他の音声入力プロパティに対してクエリを実行するとエラーが返されます。