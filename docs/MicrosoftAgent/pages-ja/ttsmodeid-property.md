---
layout: Conceptual
title: TTSModeID プロパティ - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/ttsmodeid-property
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: TTSModeID プロパティ
document_id: 5e07e893-9882-b407-61dd-d24ca8997b4c
document_version_independent_id: ccdf1115-c722-6361-47f2-2a507f1f0747
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/ttsmodeid-property.md
locale: ja-jp
ms.assetid: 9205c37e-e006-466a-9b33-b98408c01ed7
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/ttsmodeid-property.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:03:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/ttsmodeid-property.md
page_type: conceptual
toc_rel: toc.json
word_count: 1354
asset_id: lwef/ttsmodeid-property
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 395ca1a5-7e94-424d-e204-ffb7056ac039
---

# TTSModeID プロパティ - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 文字に使用される TTS エンジン モードを設定または返します。
- **構文の**
    - エージェント \*\* です。characters ("***CharacterID***")。TTSModeID\*\* [ = *ModeID*]

| 部分 | 形容 |
| --- | --- |
| *ModeID* | 音声エンジンのモード ID に対応する文字列式。 |

## 備考

このプロパティは、文字の音声出力の TTS (テキスト読み上げ) エンジン モード ID を決定します。 TTS エンジンのモード ID は、エンジンのモードを一意に識別する音声ベンダーによって定義される書式設定された文字列です。 詳細については、「コード [で音声エンジンにアクセスする](accessing-a-speech-engine-in-your-code)」を参照してください。

このプロパティを設定すると、文字のコンパイル済みの TTS 設定と、文字の現在の [**LanguageID**](languageid-property) 設定に基づいてエンジンを読み込もうとするサーバーの試行がオーバーライドされます。 ただし、インストールされていないエンジンのモード ID を指定した場合、またはユーザーが Microsoft Agent プロパティ シート (**AudioOutput.Enabled = False**) で音声出力を無効にした場合、サーバーはエラーを発生させます。

文字の TTS モード ID を設定しない (または正常に設定しなかった) 場合、サーバーは、文字のコンパイル済み TTS モード設定が文字の [**LanguageID**](languageid-property) 設定と一致するかどうか、および関連付けられている TTS エンジンがインストールされているかどうかを確認します。 その場合、音声出力の文字によって使用される TTS モードで、このプロパティはそのモード ID を返します。 そうでない場合、サーバーは、文字の **LanguageID**、および文字のコンパイル済みモード ID に設定された性別と年齢に一致する互換性のある SAPI 音声エンジンを要求します。 文字の **LanguageID**を設定していない場合、その **LanguageID** は現在のユーザー言語になります。 一致するエンジンが見つからない場合、このプロパティのクエリを実行すると、エンジンのモード ID の空の文字列が返されます。 同様に、ユーザーが Microsoft エージェント プロパティ シート (**AudioOutput.Enabled = False**) で音声出力を無効にしたときにこのプロパティにクエリを実行すると、値は空の文字列になります。

このプロパティのクエリまたは設定を行うと、関連付けられているエンジンが読み込まれます (まだ読み込まれていない場合)。 ただし、文字のコンパイル済み TTS 設定で指定されたエンジンがインストールされ、文字の言語 ID 設定と一致する場合は、文字の読み込み時にエンジンが読み込まれます。

このプロパティは、クライアント アプリケーションによる文字の使用にのみ適用されます。この設定は、文字の他のクライアントやクライアント アプリケーションの他の文字には影響しません。

Microsoft エージェントの音声エンジンの要件は、Microsoft Speech API に基づいています。 Microsoft エージェントの SAPI 要件をサポートするエンジンは、エージェントと共にインストールして使用できます。

手記

このプロパティは、システムに互換性のあるサウンド サポートがインストールされていない場合も、空の文字列を返します。

手記

Speech.dll がインストールされておらず、指定したエンジンが文字のコンパイル済み TTS モード設定と一致しない場合、**TTSModeID** の設定は失敗する可能性があります。

手記

このプロパティのクエリを実行しても、通常はエラーは返されません。 ただし、音声エンジンの読み込みに異常に長い時間がかかる場合は、クエリがタイムアウトしたことを示すエラーが発生する可能性があります。