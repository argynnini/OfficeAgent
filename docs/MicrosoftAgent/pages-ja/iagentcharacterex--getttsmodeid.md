---
layout: Conceptual
title: IAgentCharacterEx GetTTSModeID - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcharacterex--getttsmodeid
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCharacterEx GetTTSModeID
document_id: 3ab7cea4-1ada-c52c-396d-e56763d45a42
document_version_independent_id: 6f878eee-4d18-51d7-73aa-566349d62fc8
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacterex--getttsmodeid.md
locale: ja-jp
ms.assetid: e7b3c576-dc3c-40de-8d09-8e7f4b79250b
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacterex--getttsmodeid.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:48:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcharacterex--getttsmodeid.md
page_type: conceptual
toc_rel: toc.json
word_count: 698
asset_id: lwef/iagentcharacterex--getttsmodeid
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/c6f99e62-1cf6-4b71-af9b-649b05f80cce
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/3f56b378-07a9-4fa1-afe8-9889fdc77628
platformId: 7994feb3-7161-1fee-f405-8b2e458c2af9
---

# IAgentCharacterEx GetTTSModeID - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT GetTTSModeID(
   BSTR * pbszModeID  // address of TTS engine ID
);
```

文字の TTS エンジン セットのモード ID を取得します。

- 操作が成功したことを示すS\_OKを返します。

- pbszModeID*を * する
    - 文字の TTS エンジンのモード ID 設定を受け取る BSTR のアドレス。

この設定は、文字の音声出力の TTS (テキスト読み上げ) エンジン モード ID を返します。 TTS エンジンのモード ID は、エンジンを一意に識別する音声ベンダーによって定義された GUID (中かっことダッシュで書式設定) の文字列表現です。 詳細については、[Microsoft Speech SDK のドキュメント](https://msdn.microsoft.com/library/ee705648.aspx)を参照してください。 このプロパティのクエリを実行すると、関連付けられているエンジンがまだ読み込まれていない場合に読み込まれます。

文字に TTS エンジン モード ID を設定しない場合、サーバーは、(Microsoft Speech API インターフェイスを使用して) 文字のコンパイル済み TTS 設定と文字の現在の言語設定に一致するエンジンを返そうとします。 これらが異なる場合は、文字の言語設定によって作成モードの設定がオーバーライドされます。 文字の言語設定を設定していない場合、文字の言語はユーザーの既定の言語 ID であり、サーバーはその言語 ID に基づいて一致を試みます。

[**IAgentAudioObjectProperties::GetEnabled**](https://www.bing.com/search?q=**IAgentAudioObjectProperties::GetEnabled**) が false 返した場合、この関数は失敗しません。

このプロパティは、クライアント アプリケーションによる文字の使用にのみ適用されます。この設定は、文字の他のクライアントやクライアント アプリケーションの他の文字には影響しません。

Microsoft エージェントの音声エンジンの要件は、Microsoft Speech API に基づいています。 Microsoft エージェントの SAPI 要件をサポートするエンジンは、エージェントと共にインストールして使用できます。