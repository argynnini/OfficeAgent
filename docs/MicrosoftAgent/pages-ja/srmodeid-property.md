---
layout: Conceptual
title: SRModeID プロパティ - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/srmodeid-property
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: SRModeID プロパティ
document_id: 6bf7fbd0-5b60-999c-ffa0-bd2d9a9d4f4d
document_version_independent_id: 92a7c9f1-dfee-1d4c-5966-0a31c975b174
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/srmodeid-property.md
locale: ja-jp
ms.assetid: 4c784fc5-d2c2-4e5b-ba5f-f59b4507f40f
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/srmodeid-property.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:01:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/srmodeid-property.md
page_type: conceptual
toc_rel: toc.json
word_count: 1194
asset_id: lwef/srmodeid-property
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 4b0553bc-0e75-9187-085c-50a6a000ebca
---

# SRModeID プロパティ - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 文字が使用する音声認識エンジンを設定または返します。
- **構文の**
    - エージェント \*\* です。Characters("***CharacterID***")。SRModeID\*\* [ = *ModeID*]

| 部分 | 形容 |
| --- | --- |
| *ModeID* | 音声エンジンのモード ID に対応する文字列式。 |

## 備考

このプロパティは、文字が音声入力に使用する音声認識エンジンを決定します。 音声認識エンジンのモード ID は、エンジンを一意に識別する音声ベンダーによって定義された書式設定された文字列です。 詳細については、「コード [で音声エンジンにアクセスする](accessing-a-speech-engine-in-your-code)」を参照してください。

インストールされていない音声エンジンのモード ID を指定した場合、ユーザーが (Microsoft Agent プロパティ シートで) 音声認識を無効にした場合、または指定した音声エンジンの言語が文字の [**LanguageID**](languageid-property) 設定と一致しない場合、サーバーはエラーを発生させます。

このプロパティに対してクエリを実行し、音声認識エンジンをまだ (正常に) 設定していない場合、サーバーは、文字の [**LanguageID**](languageid-property) 設定に基づいて SAPI が返すエンジンのモード ID を返します。 文字の **LanguageID**を設定していない場合、エージェントは、ユーザーの既定の言語 ID 設定に基づいて SAPI が返すエンジンのモード ID を返します。 一致するエンジンがない場合、サーバーは空の文字列 ("") を返します。 このプロパティのクエリを実行する場合、[**SpeechInput.Enabled**](https://www.bing.com/search?q=**SpeechInput.Enabled**) true **を**に設定する必要はありません。 ただし、音声入力が無効になっているときにプロパティにクエリを実行すると、サーバーは空の文字列を返します。

音声入力が有効になっている場合 ([高度な文字オプション] ウィンドウで)、このプロパティのクエリまたは設定を行うと、関連付けられているエンジンが読み込まれ (まだ読み込まれていない場合)、音声サービスが開始されます。 つまり、リッスン キーを使用でき、リッスン ヒントが表示されます。 (リッスン キーとリッスン ヒントは、[高度な文字オプション] でも有効になっている場合にのみ有効になります)。ただし、音声が無効になっているときにプロパティに対してクエリを実行した場合、サーバーは音声サービスを開始しません。

このプロパティは、クライアント アプリケーションによる文字の使用にのみ適用されます。この設定は、文字の他のクライアントやクライアント アプリケーションの他の文字には影響しません。

Microsoft エージェントの音声エンジンの要件は、Microsoft Speech API に基づいています。 Microsoft エージェントの SAPI 要件をサポートするエンジンは、エージェントと共にインストールして使用できます。

手記

このプロパティは、システムに互換性のあるサウンド サポートがインストールされていない場合も、空の文字列を返します。

手記

このプロパティのクエリを実行しても、通常はエラーは返されません。 ただし、音声エンジンの読み込みに異常に長い時間がかかる場合は、クエリがタイムアウトしたことを示すエラーが発生する可能性があります。