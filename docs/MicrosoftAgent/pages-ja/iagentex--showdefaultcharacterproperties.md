---
layout: Conceptual
title: IAgentEx ShowDefaultCharacterProperties - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentex--showdefaultcharacterproperties
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentEx ShowDefaultCharacterProperties
document_id: d876d1d9-0ed6-d70c-5718-881715340d12
document_version_independent_id: 41322134-d83e-383d-2783-ecebf1f41694
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentex--showdefaultcharacterproperties.md
locale: ja-jp
ms.assetid: 4817b52a-7168-4008-9cda-0b8d598daea0
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentex--showdefaultcharacterproperties.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:51:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentex--showdefaultcharacterproperties.md
page_type: conceptual
toc_rel: toc.json
word_count: 368
asset_id: lwef/iagentex--showdefaultcharacterproperties
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 8bb0ae72-f095-b22c-d022-e31aa2768025
---

# IAgentEx ShowDefaultCharacterProperties - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT ShowDefaultCharacterProperties(
   short x,          // x-coordinate of window
   short y,          // y-coordinate of window
   long bUseDefault  // default position flag
);
```

既定の文字プロパティ ウィンドウを表示します。

- 操作が成功したことを示すS\_OKを返します。

- *x*
    - 画面の原点 (左上) を基準とした、ウィンドウの x 座標 (ピクセル単位)。
- *y*
    - 画面の原点 (左上) を基準とした、ウィンドウの y 座標 (ピクセル単位)。
- bUseDefault*を * する
    - 既定の位置フラグ。 このパラメーターが true 場合、Microsoft エージェントは、表示された最後の場所に既定の文字のプロパティ シート ウィンドウを表示します。

手記

Windows 2000 では、このウィンドウがフォアグラウンド ウィンドウになるように、新しい [**AllowSetForegroundWindow**](/ja-jp/windows/desktop/api/winuser/nf-winuser-allowsetforegroundwindow) API を呼び出す必要がある場合があります。 Windows 2000 でフォアグラウンド ウィンドウを設定する方法の詳細については、プラットフォーム SDK のドキュメントを参照してください。