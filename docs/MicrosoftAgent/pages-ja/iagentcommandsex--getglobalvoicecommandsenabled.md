---
layout: Conceptual
title: IAgentCommandsEx GetGlobalVoiceCommandsEnabled - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcommandsex--getglobalvoicecommandsenabled
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCommandsEx GetGlobalVoiceCommandsEnabled
document_id: 133ff1ba-9d59-e21c-272e-7ec2dad834c6
document_version_independent_id: 3e3a3176-3223-e7a4-4268-5a6e964b82a0
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcommandsex--getglobalvoicecommandsenabled.md
locale: ja-jp
ms.assetid: 9c8fa978-a02b-4dfc-8cf7-e066c5b75122
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommandsex--getglobalvoicecommandsenabled.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:50:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcommandsex--getglobalvoicecommandsenabled.md
page_type: conceptual
toc_rel: toc.json
word_count: 417
asset_id: lwef/iagentcommandsex--getglobalvoicecommandsenabled
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 541e5017-3384-4c16-2e24-055ec2dc2678
---

# IAgentCommandsEx GetGlobalVoiceCommandsEnabled - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT GetGlobalVoiceCommandsEnabled(
   long * pbEnabled  // address of the global voice command setting
);
```

エージェントのグローバル コマンドの音声文法が有効かどうかを取得します。

- 操作が成功したことを示すS\_OKを返します。

- pbEnabled*を * する
    - エージェントのグローバル コマンドの音声文法が有効になっている場合、**True** を受け取るアドレス。無効になっている場合は False 。

Microsoft エージェントは、音声コマンド ウィンドウを開いたり閉じたり、文字を表示したり非表示にしたりするための音声パラメーター (文法) を自動的に追加します。 このメソッドが **False**を返す場合、これらのコマンドの音声パラメーターと、他のクライアントの [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトの [**キャプション**](caption-property) の音声パラメーターは文法に含まれません。 これにより、クライアントの現在のアクティブな文法からこれらを排除できます。 ただし、この設定では、文字のポップアップ メニューにこれらのコマンドが含まれているとは見なされません。