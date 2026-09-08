---
layout: Conceptual
title: IAgentCharacterEx GetSRModeID - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcharacterex--getsrmodeid
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCharacterEx GetSRModeID
document_id: 40e2aa2a-f076-d167-2992-6356a9295a4a
document_version_independent_id: 4be352f4-3ba7-ea7b-1a2d-a05a253cbbc1
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacterex--getsrmodeid.md
locale: ja-jp
ms.assetid: 28049680-8245-49f3-9ecd-13c7605f10ed
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacterex--getsrmodeid.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:48:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcharacterex--getsrmodeid.md
page_type: conceptual
toc_rel: toc.json
word_count: 808
asset_id: lwef/iagentcharacterex--getsrmodeid
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 41a6fc1b-dc32-581a-194b-d8b0bdfeceef
---

# IAgentCharacterEx GetSRModeID - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT GetSRModeID(
   BSTR * pbszModeID  // address of speech recognition engine ID
);
```

文字に設定されている音声認識エンジンのモード ID を取得します。

- 操作が成功したことを示すS\_OKを返します。

- pbszModeID*を * する
    - 文字の音声認識エンジンのモード ID 設定を受け取る BSTR のアドレス。

この設定は、文字の音声入力のエンジン セットを返します。 音声認識エンジンのモード ID は、エンジンを一意に識別する音声ベンダーによる GUID (中かっことダッシュで書式設定) の文字列表現です。 詳細については、[Microsoft Speech SDK のドキュメント](https://msdn.microsoft.com/library/ee705648.aspx)を参照してください。

文字の音声認識エンジン モード ID を設定しない場合、サーバーは文字の言語設定に一致するエンジンを返します (Microsoft Speech API インターフェイスを使用)。 文字に対応する音声認識エンジンが使用できない場合、サーバーは null (空) 文字列を返します。

音声入力が有効になっている場合 ([高度な文字オプション] ウィンドウで)、このプロパティのクエリまたは設定を行うと、関連付けられているエンジンが読み込まれ (まだ読み込まれていない場合)、音声サービスが開始されます。 つまり、リッスン キーを使用でき、リッスン ヒントが表示されます。 (リッスン キーとリッスン ヒントは、[高度な文字オプション] でも有効になっている場合にのみ有効になります)。ただし、音声が無効になっているときにプロパティにクエリを実行すると、サーバーは音声サービスを開始せず、null 文字列 (空の文字列) を返します。

この関数は、クライアント アプリケーションが文字を使用するための設定のみを返します。この設定には、クライアント アプリケーションの文字または他の文字の他のクライアントは反映されません。

この関数は、[**IAgentSpeechInputProperties::GetEnabled**](iagentspeechinputproperties--getenabled) が false 返した場合は失敗しません。

Microsoft エージェントの音声エンジンの要件は、Microsoft Speech API に基づいています。 Microsoft エージェントの SAPI 要件をサポートするエンジンは、エージェントと共にインストールして使用できます。