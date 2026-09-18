---
layout: Conceptual
title: IAgentCommandsEx SetGlobalVoiceCommandsEnabled - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcommandsex--setglobalvoicecommandsenabled
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCommandsEx SetGlobalVoiceCommandsEnabled
document_id: 3bc289de-47bc-f551-2cbc-ff24f90fc6ac
document_version_independent_id: 81c72f1b-67ee-0040-dea0-4eeb559b4dc1
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcommandsex--setglobalvoicecommandsenabled.md
locale: ja-jp
ms.assetid: f456b1d3-60aa-4b90-90d0-6c695947fa8a
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommandsex--setglobalvoicecommandsenabled.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:51:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcommandsex--setglobalvoicecommandsenabled.md
page_type: conceptual
toc_rel: toc.json
word_count: 536
asset_id: lwef/iagentcommandsex--setglobalvoicecommandsenabled
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 9719ab37-4b64-73e7-4518-3242c063c4ad
---

# IAgentCommandsEx SetGlobalVoiceCommandsEnabled - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT SetGlobalVoiceCommandsEnabled(
 long bEnable  // Enabled setting for Agent's global voice commands
);
```

Microsoft エージェントのグローバル コマンドの音声文法の [**Enabled**](enabled-property) プロパティを設定します。

- 操作が成功したことを示すS\_OKを返します。

- *bEnable*
    - エージェントのグローバル コマンドの音声文法が有効かどうかを設定するブール値。 **True** では、音声文法が有効になります。**False** は無効にします。

Microsoft エージェントは、音声コマンド ウィンドウを開いたり閉じたり、文字を表示したり非表示にしたりするための音声パラメーター (文法) を自動的に追加します。 False **を**に設定すると、エージェントは、これらのコマンドの音声パラメーターと、他のクライアントの [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトの [**Caption**](caption-property) の音声パラメーターを無効にします。 これにより、クライアントの現在のアクティブな文法からこれらを排除できます。 ただし、これにより他のクライアントへの音声アクセスがブロックされる可能性があるため、ユーザーの音声入力を処理した後、このプロパティを **True** にリセットします。

プロパティを無効にしても、文字のポップアップ メニューには影響しません。 サーバーによって追加されたグローバル コマンドは引き続き表示されます。 ポップアップ メニューから削除することはできません。