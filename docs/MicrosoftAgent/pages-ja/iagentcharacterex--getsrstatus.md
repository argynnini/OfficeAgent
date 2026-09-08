---
layout: Conceptual
title: IAgentCharacterEx GetSRStatus - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcharacterex--getsrstatus
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCharacterEx GetSRStatus
document_id: 539325d9-5aa1-e66a-8b09-44472711f150
document_version_independent_id: 63cd8be3-c05d-c965-8e68-0d33eb0aaf0d
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacterex--getsrstatus.md
locale: ja-jp
ms.assetid: ccb34108-8078-421a-a883-731b51fae179
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacterex--getsrstatus.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:48:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-07-03T23:50:19.3460266Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcharacterex--getsrstatus.md
page_type: conceptual
toc_rel: toc.json
word_count: 1120
asset_id: lwef/iagentcharacterex--getsrstatus
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: f52a04a3-d0ac-bcce-4470-c80e27f5d3c7
---

# IAgentCharacterEx GetSRStatus - Win32 apps | Microsoft Learn

[Microsoft Agent は Windows 7 の時点で非推奨となり、後続のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT GetSRStatus(
   long * plStatus  // address of the speech input status
);
```

音声入力をサポートするために必要な条件の状態を取得します。

- 操作が成功したことを示す S\_OK を返します。

- *plStatus*
    - 状態設定に対して次のいずれかの値を受け取る変数のアドレス。

| 値 | 説明 |
| --- | --- |
| **const unsigned long** **LISTEN\_STATUS\_CANLISTEN = 0;** | 条件は音声入力をサポートしています。 |
| **const unsigned long** **LISTEN\_STATUS\_NOAUDIO = 1;** | このシステムではオーディオ入力デバイスを使用できません。 (マイクがインストールされているかどうかは検出されません。ユーザーが入力対応サウンド カードと対応ドライバーを正しくインストールしたかどうかを検出することしかできません)。 |
| **const unsigned long** **LISTEN\_STATUS\_NOTTOPMOST = 2;** | 別のクライアントがこのキャラクターのアクティブなクライアントであるか、現在のキャラクターが最上位ではありません。 |
| **const unsigned long** **LISTEN\_STATUS\_CANTOPENAUDIO = 3;** | オーディオ入力または出力チャネルは現在ビジー状態であり、他のアプリケーションでオーディオが使用されています。 |
| **const unsigned long** **LISTEN\_STATUS\_COULDNTINITIALIZESPEECH = 4;** | 音声認識サブシステムの初期化中に、指定されていないエラーが発生しました。 これには、キャラクターの言語設定に一致する音声エンジンが使用できない可能性が含まれます。 |
| **const unsigned long** **LISTEN\_STATUS\_SPEECHDISABLED = 5;** | ユーザーが [高度なキャラクター オプション] ウィンドウで音声入力を無効にしました。 |
| **const unsigned long** **LISTEN\_STATUS\_ERROR = 6;** | オーディオ ステータスを確認中にエラーが発生しましたが、エラーの原因がシステムによって返されませんでした。 |

この関数を使用すると、オーディオ デバイスのステータスを含め、現在の条件が音声認識入力をサポートしているかどうかを照会できます。 アプリケーションで [**IAgentCharacterEx::Listen**](iagentcharacterex--listen) メソッドを使用している場合は、この関数を使用して呼び出しの成功率を高めることができます。 このメソッドを呼び出すと、まだ読み込まれていない音声エンジンも読み込まれます。 ただし、リスニング モードはオンになりません。

エージェント プロパティ シートで音声入力が有効になっている場合 (高度なキャラクター オプション)、ステータスのクエリを実行すると、関連付けられているエンジンが読み込まれ (まだ読み込まれていない場合)、音声サービスが開始されます。 つまり、リスニング キーを使用でき、リスニング ヒントが表示されます。 (リスニング キーとリスニング ヒントは、[高度なキャラクター オプション] でも有効になっている場合にのみ有効になります)。ただし、音声が無効になっているときにプロパティに対してクエリを実行した場合、サーバーは音声サービスを開始しません。

この関数は、クライアント アプリケーションがキャラクターを使用するための設定のみを返します。この設定には、キャラクターの他のクライアントまたはクライアント アプリケーションの他のキャラクターは反映されません。