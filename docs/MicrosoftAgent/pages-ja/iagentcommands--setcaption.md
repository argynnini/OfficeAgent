---
layout: Conceptual
title: IAgentCommands SetCaption - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcommands--setcaption
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCommands SetCaption
document_id: 6cb53f8b-feca-170d-fb62-d2934466d034
document_version_independent_id: 939b424d-dc78-d25a-3fbe-e1f16fa1ad1e
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentcommands--setcaption.md
locale: ja-jp
ms.assetid: 042f7366-0071-40a5-a47c-81c02cdbe3a9
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommands--setcaption.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:50:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-01-09T19:49:59.6397822Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcommands--setcaption.md
page_type: conceptual
toc_rel: toc.json
word_count: 337
asset_id: lwef/iagentcommands--setcaption
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 05d00cac-c979-79a6-65ab-63a9d6ee6865
---

# IAgentCommands SetCaption - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT SetCaption(
   BSTR bszCaption  // Caption setting for Commands collection
);
```

[**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションに表示される [**Caption**](caption-property) テキストを設定します。

- 操作が成功したことを示すS\_OKを返します。

- bszCaption*を * する
    - [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションの [**Caption**](caption-property) プロパティの値を指定する BSTR。

[**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションの [**Caption**](caption-property) プロパティを設定すると、[**Visible**](visible-property) プロパティが **True** に設定されていて、アプリケーションが入力アクティブクライアントでない場合に、文字のポップアップ メニューに表示される方法が定義されます。 **Caption**のアクセス キー (線なしニーモニック) を指定するには、その文字の前にアンパサンド (&) 文字を含めます。

[**Caption**](caption-property) が設定されている [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションのコマンドを定義する場合は、通常、**Commands** コレクションの **キャプション** も定義します。