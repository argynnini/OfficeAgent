---
layout: Conceptual
title: IAgentCharacterEx SetTTSModeID - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcharacterex--setttsmodeid
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCharacterEx SetTTSModeID
document_id: f4281466-8bbf-b03f-685c-982c5ce31cf9
document_version_independent_id: 74fe0a5c-681b-9f88-f617-9c1ed44788e3
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacterex--setttsmodeid.md
locale: ja-jp
ms.assetid: 66ed792a-1693-45dc-b9a8-eebe772c5af9
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacterex--setttsmodeid.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:48:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcharacterex--setttsmodeid.md
page_type: conceptual
toc_rel: toc.json
word_count: 792
asset_id: lwef/iagentcharacterex--setttsmodeid
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 0f70208d-13c5-636a-bab6-d88166207ee8
---

# IAgentCharacterEx SetTTSModeID - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT SetTTSModeID(
   BSTR bszModeID  // TTS engine ID
);
```

文字に設定されている TTS エンジンのモード ID を設定します。

- 操作が成功したことを示すS\_OKを返します。

- bszModeID*の *
    - 文字の TTS エンジンのモード ID 設定。

手記

**IAgentCharacterEx:SetTTSModeID** は、Speech.dll がインストールされておらず、指定したエンジンが文字のコンパイル済み TTS モード設定と一致しない場合に失敗する可能性があります。

この設定により、キャラクターの音声 TTS 出力の優先エンジン モードが決まります。 TTS (テキスト読み上げ) エンジンのモード ID は、(中かっことダッシュで書式設定された) エンジンのモードを一意に識別する音声ベンダーによって定義された GUID です。 詳細については、[Microsoft Speech SDK のドキュメント](https://msdn.microsoft.com/library/ee705648.aspx)を参照してください。

TTS モード ID を設定すると、文字のコンパイル済み TTS モード ID、現在のシステム言語 ID、および文字の現在の言語 ID に基づいて、音声エンジンとの照合がサーバーによってオーバーライドされます。 ただし、ユーザーが Microsoft Agent プロパティ シートで音声出力を無効にした場合、または関連付けられているエンジンがインストールされていないときにモード ID を設定しようとすると、この呼び出しは失敗します。

文字の TTS エンジン モード ID を設定しない場合、サーバーは文字の言語設定に一致するエンジンを設定します (Microsoft Speech API インターフェイスを使用)。 このプロパティを設定すると、関連付けられているエンジンがまだ読み込まれていない場合に読み込まれます。

このプロパティは、クライアント アプリケーションによる文字の使用にのみ適用されます。この設定は、文字の他のクライアントやクライアント アプリケーションの他の文字には影響しません。

Microsoft エージェントの音声エンジンの要件は、Microsoft Speech API に基づいています。 Microsoft エージェントの SAPI 要件をサポートするエンジンは、エージェントと共にインストールして使用できます。