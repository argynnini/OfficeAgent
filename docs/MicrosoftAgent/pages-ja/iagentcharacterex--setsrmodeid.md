---
layout: Conceptual
title: IAgentCharacterEx SetSRModeID - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcharacterex--setsrmodeid
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCharacterEx SetSRModeID
document_id: f3a1020a-a833-7bd0-e920-49c5655cc815
document_version_independent_id: 2801ba02-dde9-1b08-b920-04d5332602ae
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacterex--setsrmodeid.md
locale: ja-jp
ms.assetid: 8f9072ec-1f64-4f5c-972d-cd6799ce028c
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacterex--setsrmodeid.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:48:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcharacterex--setsrmodeid.md
page_type: conceptual
toc_rel: toc.json
word_count: 794
asset_id: lwef/iagentcharacterex--setsrmodeid
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: d1629588-9669-b42e-815b-73489b589110
---

# IAgentCharacterEx SetSRModeID - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT SetSRModeID(
   BSTR bszModeID  // speech recognition engine ID
);
```

文字に設定された音声認識エンジンのモード ID を設定します。

- 操作が成功したことを示すS\_OKを返します。

bszModeID

文字の音声認識エンジンのモード ID 設定。

この設定では、文字の音声入力のエンジンを設定します。 音声認識エンジンのモード ID は、(中かっことダッシュで書式設定された) エンジンのモードを一意に識別する、音声認識エンジンによって定義された GUID です。 詳細については、[Microsoft Speech SDK のドキュメント](https://msdn.microsoft.com/library/ee705648.aspx)を参照してください。

文字の言語設定と一致しないモード ID を指定した場合、ユーザーが (Microsoft Agent プロパティ シートで) 音声認識を無効にしているか、エンジンがインストールされていない場合、この呼び出しは失敗します。 文字の音声認識エンジン モード ID を設定しない場合、サーバーは文字の言語設定に一致するものを設定します (Microsoft Speech API インターフェイスを使用)。

エージェント プロパティ シートで音声入力が有効になっている場合 (高度な文字オプション)、このプロパティを設定すると、関連付けられているエンジンが読み込まれ (まだ読み込まれていない場合)、音声サービスが開始されます。 つまり、リッスン キーを使用でき、リッスン ヒントが表示されます。 (Listening Key と Listening tip は、[Advanced Character Options]\(高度な文字オプション\) でも有効になっている場合にのみ有効になります)。ただし、音声が無効になっているときにプロパティに対してクエリを実行した場合、サーバーは音声サービスを開始しません。

このプロパティは、文字のクライアントにのみ適用されます。この設定には、その文字の他のクライアントまたはクライアントの他の文字の設定は反映されません。

Microsoft エージェントの音声エンジンの要件は、Microsoft Speech API に基づいています。 Microsoft エージェントの SAPI 要件をサポートするエンジンは、エージェントと共にインストールして使用できます。