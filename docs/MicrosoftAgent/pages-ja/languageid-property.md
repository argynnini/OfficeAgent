---
layout: Conceptual
title: LanguageID プロパティ - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/languageid-property
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: LanguageID プロパティ
document_id: 6f740300-4803-50d3-afff-74e9e730e926
document_version_independent_id: b769237c-2cf3-1e53-b6a6-259b3561d286
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/languageid-property.md
locale: ja-jp
ms.assetid: f57b0fa1-b3b8-49c8-b441-2a40e564d6ea
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/languageid-property.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:54:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-07-03T23:50:19.3460266Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/languageid-property.md
page_type: conceptual
toc_rel: toc.json
word_count: 1031
asset_id: lwef/languageid-property
item_type: Content
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/c6f99e62-1cf6-4b71-af9b-649b05f80cce
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/3f56b378-07a9-4fa1-afe8-9889fdc77628
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: bed8bcac-a70f-8255-5bab-8503de2cb5b7
---

# LanguageID プロパティ - Win32 apps | Microsoft Learn

[Microsoft Agent は Windows 7 の時点で非推奨となり、後続のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 文字の言語 ID を返すか設定します。
- **構文**
    - \*agent.\***キャラクター** **("*CharacterID*").LanguageID** [ = *LanguageID*]

部分

説明

LanguageID

文字の言語 ID を指定する長整数。 文字の言語 ID (LANGID) は、Windows によって定義された 16 ビット値であり、主言語 ID と副言語 ID で構成されます。 次の例は、Microsoft エージェントでサポートされている言語の値です。 他の言語の値を確認するには、 *プラットフォーム SDK ドキュメント*を参照してください。

アラビア語

&H0401

イタリア語

&H0410

バスク語

&H042D

日本語

&H0411

簡体中国語

&H0804

韓国語

&H0412

繁体中国語

&H0404

ノルウェー語

&H0414

クロアチア語

&H041A

ポーランド語

&H0415

チェコ語

&H0405

ポルトガル語 (ポルトガル)

&H0816

デンマーク語

&H0406

ポルトガル語 (ブラジル)

&H0416

オランダ語

&H0413

ルーマニア語

&H0418

英語 (英国)

&H0809

ロシア語

&H0419

英語 (米国)

&H0409

スロバキア語

&H041B

フィンランド語

&H040B

スロベニア語

&H0424

フランス語

&H040C

スペイン語

&H0C0A

ドイツ語

&H0407

スウェーデン語

&H041D

ギリシャ語

&H0408

タイ語

&H041E

ヘブライ語

&H040D

トルコ語

&H041F

ハンガリー語

&H040E

## 解説

キャラクターの **LanguageID** を設定しない場合、対応するエージェント言語 DLL がインストールされていれば、その言語 ID は現在のシステム言語 ID になります。それ以外の場合は、キャラクターの言語は英語 (米国) になります。

このプロパティは、吹き出しテキスト、文字のポップアップ メニューのコマンド、音声認識エンジンの言語も決定します。 また、TTS 出力のデフォルト言語も決定します。

文字の **LanguageID** を設定しようとしたときに、その言語のエージェント言語 DLL がインストールされていないか、言語 ID の表示フォントが利用できない場合は、エージェントはエラーを生成し、 **LanguageID** は最後の設定のままになります。

このプロパティを設定しても、言語に一致する音声エンジンがない場合にはエラーは発生しません。 **LanguageID** に互換性のある音声エンジンがあるかどうかを確認するには、 [**SRModeID**](srmodeid-property) または [**TTSModeID**](ttsmodeid-property) を確認します。 **LanguageID**を設定しない場合は、ユーザーのデフォルトの言語ID設定に設定されます。

このプロパティは、クライアント アプリケーションによる文字の使用にのみ適用されます。設定は、文字の他のクライアントやクライアント アプリケーションの他の文字には影響しません。

Note

**LanguageID** を双方向テキストをサポートする言語 (アラビア語やヘブライ語など) に設定しても、アプリケーションを実行しているシステムに双方向サポートがインストールされていない場合は、バルーン内のテキストは表示順序ではなく論理順序で表示されます。