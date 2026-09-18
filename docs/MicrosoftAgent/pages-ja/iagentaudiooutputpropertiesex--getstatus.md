---
layout: Conceptual
title: IAgentAudioOutputPropertiesEx GetStatus - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentaudiooutputpropertiesex--getstatus
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentAudioOutputPropertiesEx GetStatus
document_id: b80b848b-e8c9-79d5-07b7-e56526618376
document_version_independent_id: 457ced76-3d3b-3102-0be6-239c9cadd624
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentaudiooutputpropertiesex--getstatus.md
locale: ja-jp
ms.assetid: 29bf1379-eebe-4b8b-b8d0-b86d2da78b64
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentaudiooutputpropertiesex--getstatus.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:44:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-07-03T23:50:19.3460266Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentaudiooutputpropertiesex--getstatus.md
page_type: conceptual
toc_rel: toc.json
word_count: 560
asset_id: lwef/iagentaudiooutputpropertiesex--getstatus
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: f3ae7da2-241b-72cf-442f-72c639ddf23c
---

# IAgentAudioOutputPropertiesEx GetStatus - Win32 apps | Microsoft Learn

[Microsoft Agent は Windows 7 の時点で非推奨となり、後続のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT GetStatus(
   long * plStatus,  // address of audio channel status
);
```

オーディオ チャネルのステータスを取得します。

- 操作が成功したことを示す S\_OK を返します。

- *plStatus*
    - オーディオ出力チャネルの状態。次のいずれかの値になります。

| 値 | 説明 |
| --- | --- |
| **const unsigned short** **AUDIO\_STATUS\_AVAILABLE = 0;** | オーディオ出力チャネルは使用可能です (ビジー状態ではありません)。 |
| **const unsigned short** **AUDIO\_STATUS\_NOAUDIO = 1;** | オーディオ出力はサポートされていません。たとえば、サウンド カードがないためです。 |
| **const unsigned short** **AUDIO\_STATUS\_CANTOPENAUDIO = 2;** | オーディオ出力チャネルを開くことができません (ビジー状態)。たとえば、別のアプリケーションがオーディオを再生しているためです。 |
| **const unsigned short** **AUDIO\_STATUS\_USERSPEAKING = 3;** | サーバーがユーザー音声入力を処理しているため、オーディオ出力チャネルがビジー状態です。 |
| **const unsigned short** **AUDIO\_STATUS\_CHARACTERSPEAKING = 4;** | キャラクターが現在話しているため、オーディオ出力チャネルはビジー状態です。 |
| **const unsigned short** **AUDIO\_STATUS\_SROVERRIDEABLE = 5;** | オーディオ出力チャネルはビジー状態ではありませんが、ユーザーの音声入力を待機しています。 |
| **const unsigned short** **AUDIO\_STATUS\_ERROR = 6;** | オーディオ出力チャネルにアクセスしようとしたときに、他の (不明な) 問題が発生しました。 |

この設定により、クライアント アプリケーションはオーディオ出力チャネルの状態を照会できます。 これを使用して、キャラクターに話させるか、リスニング モードをオンにするかを決定できます (**IAgentCharacterEx::Listen** を使用)。