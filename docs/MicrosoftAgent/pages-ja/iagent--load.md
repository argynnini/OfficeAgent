---
layout: Conceptual
title: IAgent の読み込み - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagent--load
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgent の読み込み
document_id: 1915ee2f-51af-0e93-d731-362f44987d32
document_version_independent_id: f14defbd-b51d-57e4-27d6-af874ea2c4ae
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagent--load.md
locale: ja-jp
ms.assetid: 8f25e6b6-a117-4b37-969a-d8f80c7be224
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagent--load.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:44:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagent--load.md
page_type: conceptual
toc_rel: toc.json
word_count: 1006
asset_id: lwef/iagent--load
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: eb6f4e37-c48e-cfed-a682-62c310eab83f
---

# IAgent の読み込み - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT Load(
   VARIANT vLoadKey,  // data provider
   long * pdwCharID,  // address of a variable for character ID
   long * pdwReqID    // address of a variable for request ID
);
```

[**Characters**](iagent) コレクションに文字を読み込みます。

- 操作が成功したことを示すS\_OKを返します。

- vLoadKey*の *
    - 次のいずれかである必要があるバリアント データ型。

| 価値 | 形容 |
| --- | --- |
| filespec *を* する | 指定した文字の定義ファイルのローカル ファイルの場所。 |
| *URL* | 文字の定義ファイルの HTTP アドレス。 |
- pdwCharID*の *
    - 文字の ID を受け取る変数のアドレス。
- pdwReqID*を * する
    - [**Load**](load-method) 要求 ID を受け取る変数のアドレス。

Microsoft Agent サブディレクトリから文字を読み込むには、相対パス (コロンまたは先頭のスラッシュ文字を含まないパス) を指定します。 これにより、(ローカライズされた %windows%\msagent ディレクトリにある) エージェントの文字ディレクトリでパスのプレフィックスが付けられます。 相対アドレスを使用して、エージェントの Chars ディレクトリで独自のディレクトリを指定することもできます。

1 つの接続から同じ文字 (同じ GUID を持つ文字) を複数回読み込むことはできません。 同様に、既定の文字は他の文字と同じである可能性があるため、1 つの接続から既定の文字とその他の文字を同時に読み込むことはできません。 ただし、(CoCreateInstance を使用して) 別の接続を作成し、同じ文字を読み込むことができます。

Microsoft エージェントのデータ プロバイダーは、1 つの構造化ファイルとして格納された文字データの読み込みをサポートしています (.ACS) は、文字データとアニメーション データを一緒に使用するか、個別の文字データ (.ACF) とアニメーション (.ACA) ファイル。 一般に、単一の構造化を使用します。ローカル ディスク ドライブまたはネットワークに格納され、従来のファイル プロトコル (UNC パス名など) を使用してアクセスされる文字を読み込む ACS ファイル。 別の .ACF および .HTTP プロトコルを使用してアクセスされるリモート サイトからアニメーション ファイルを個別に読み込む場合の ACA ファイル。

対して。ACS ファイルは、[**Load**](load-method) メソッドを使用してキャラクターのアニメーションにアクセスできます。読み込まれたら、[**Play**](play-method) メソッドを使用してキャラクターをアニメーション化できます。 対して。ACF ファイルでは、[**Prepare**](/ja-jp/windows/desktop/lwef/iagentcharacter--prepare) メソッドを使用してアニメーション データを読み込むこともできます。 **Load** メソッドは、ダウンロードをサポートしていません。HTTP サイトからの ACS ファイル。

文字を読み込んでも、文字は自動的に表示されません。 最初に [**Show**](show-method) メソッドを使用して、文字を表示します。