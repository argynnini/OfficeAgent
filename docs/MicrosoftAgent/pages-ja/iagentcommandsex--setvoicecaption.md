---
layout: Conceptual
title: IAgentCommandsEx SetVoiceCaption - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcommandsex--setvoicecaption
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCommandsEx SetVoiceCaption
document_id: b502aa79-0506-6514-370f-0fc596ceadaa
document_version_independent_id: ab338c9c-4473-890b-fa03-ecf8fb254e46
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcommandsex--setvoicecaption.md
locale: ja-jp
ms.assetid: f13c9ca5-70c9-42d0-b53c-45dc8980a24c
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommandsex--setvoicecaption.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:51:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcommandsex--setvoicecaption.md
page_type: conceptual
toc_rel: toc.json
word_count: 351
asset_id: lwef/iagentcommandsex--setvoicecaption
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 1114e0aa-a6b0-0b3e-9218-5318f46685b3
---

# IAgentCommandsEx SetVoiceCaption - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT SetVoiceCaption(
   BSTR bszVoiceCaption  // voice caption text
);
```

[**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトに表示される [**VoiceCaption**](voicecaption-property) テキストを設定します。

- 操作が成功したことを示すS\_OKを返します。

- *bszVoiceCaption*
    - [**コマンド**](/ja-jp/windows/desktop/lwef/the-command-object)の [**VoiceCaption**](voicecaption-property) プロパティのテキストを指定する BSTR。

[**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションで [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトを定義し、その [**Voice**](voice-property) プロパティを設定する場合は、通常、その [**VoiceCaption**](voicecaption-property) プロパティも設定します。 このテキストは、クライアント アプリケーションが入力アクティブで、文字が表示されている場合に、[音声コマンド] ウィンドウに表示されます。 このプロパティが設定されていない場合、[**Caption**](caption-property) プロパティの設定によって表示されるテキストが決まります。 **VoiceCaption** プロパティまたは **Caption** プロパティが設定されていない場合、コマンドは [音声コマンド] ウィンドウに表示されません。