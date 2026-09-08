---
layout: Conceptual
title: IAgentPropertySheet GetPage - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentpropertysheet--getpage
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentPropertySheet GetPage
document_id: 7d9649ac-1ec8-df5d-a01b-d7f490bdcf0e
document_version_independent_id: 74290a53-0200-b0a2-cb60-2219c7f4f67c
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentpropertysheet--getpage.md
locale: ja-jp
ms.assetid: 40d00e9b-dd81-4e23-907a-6ca24a28fa95
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentpropertysheet--getpage.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:52:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentpropertysheet--getpage.md
page_type: conceptual
toc_rel: toc.json
word_count: 229
asset_id: lwef/iagentpropertysheet--getpage
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: b52c29ae-314b-d381-0344-7fff11610ee3
---

# IAgentPropertySheet GetPage - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT GetPage(
BSTR * pbszPage  // address of variable for current property page
);
```

Microsoft Agent プロパティ シートの現在のページを取得します。

- 操作が成功したことを示すS\_OKを返します。

- pbszPage*を * する
    - プロパティ シートの現在のページを受け取る変数のアドレス (ウィンドウが開かっていない場合は最後に表示されたページ)。 パラメーターには、次のいずれかを指定できます。

| - | 形容 |
| --- | --- |
| "Speech" **を** する | [音声入力] ページ。 |
| "出力" **を** する | [出力] ページ。 |
| **"Copyright"** | 著作権ページ。 |