---
layout: Conceptual
title: IAgentCommandsEx GetVoiceCaption - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcommandsex--getvoicecaption
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCommandsEx GetVoiceCaption
document_id: 0eefde92-cbeb-f9a8-ec80-cdd4d0f472cc
document_version_independent_id: c6de2251-2678-20ca-e3fe-a27d126a718b
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcommandsex--getvoicecaption.md
locale: ja-jp
ms.assetid: 0e505295-386a-421f-a43c-6da03c8a2b6a
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommandsex--getvoicecaption.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:50:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcommandsex--getvoicecaption.md
page_type: conceptual
toc_rel: toc.json
word_count: 290
asset_id: lwef/iagentcommandsex--getvoicecaption
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: dd0e8a87-96bb-0234-3edd-be7d42fd5959
---

# IAgentCommandsEx GetVoiceCaption - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT GetVoiceCaption(
   BSTR * pbszVoiceCaption  // address of command's voice caption
);
```

[**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトの [**VoiceCaption**](voicecaption-property) を取得します。

- 操作が成功したことを示すS\_OKを返します。

- pbszVoiceCaption*を * する
    - [**コマンド**](/ja-jp/windows/desktop/lwef/the-command-object)に表示される [**Caption**](caption-property) テキストの値を受け取る BSTR のアドレス。

返されるテキストは、[**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトに設定され、クライアント アプリケーションが入力/アクティブのときに [音声コマンド] ウィンドウに表示されます。

このプロパティは、クライアント アプリケーションによる文字の使用にのみ適用されます。この設定は、文字の他のクライアントやクライアント アプリケーションの他の文字には影響しません。