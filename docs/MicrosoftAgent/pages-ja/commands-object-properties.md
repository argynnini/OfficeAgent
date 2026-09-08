---
layout: Conceptual
title: Commands オブジェクトのプロパティ - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/commands-object-properties
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Commands オブジェクトのプロパティ
document_id: 5f82cf64-9391-74eb-0f4b-0b1b4e5e27d5
document_version_independent_id: b77c885f-e0f9-24ce-c244-d5405c510093
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/commands-object-properties.md
locale: ja-jp
ms.assetid: 889a56b2-0b6d-4df8-a313-7553371e4413
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/commands-object-properties.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:38:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/commands-object-properties.md
page_type: conceptual
toc_rel: toc.json
word_count: 764
asset_id: lwef/commands-object-properties
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: c653b6e6-7831-2405-1bf0-737cb2ae3033
---

# Commands オブジェクトのプロパティ - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

サーバーは、[**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションに対して次のプロパティをサポートしています。

- [**キャプション**](caption-property-cmds)
- [**カウント**](count-property)
- DefaultCommand**[を](defaultcommand-property)**する
- [**FontName**](fontname-property)
- [**FontSize**](fontsize-property)
- [**GlobalVoiceCommandsEnabled**](globalvoicecommandsenabled-property)
- [**HelpContextID**](helpcontextid-property)
- [**表示**](visible-property-cso)
- [**音声**](voice-property)
- [**VoiceCaption**](voicecaption-property)

[**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションのエントリは、文字のポップアップ メニューと音声コマンド ウィンドウの両方に表示できます。 このエントリをポップアップ メニューに表示するには、その [**Caption**](caption-property-cmds) プロパティを設定します。 音声コマンド ウィンドウにエントリを含めるには、その [**VoiceCaption**](voicecaption-property) プロパティを設定します。 (下位互換性のために、VoiceCaption がない場合は、**Caption** 設定が使用されます)。

次の表は、[**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) オブジェクトのプロパティがエントリのプレゼンテーションにどのように影響するかをまとめたものです。

| Caption プロパティ | Voice-Caption プロパティ | Voice プロパティ | Visible プロパティ | キャラクターのポップアップメニューに表示される | [音声コマンド] ウィンドウに表示される |
| --- | --- | --- | --- | --- | --- |
| はい | はい | はい | 真 | はい(キャプションを使用) | はい(VoiceCaption を使用) |
| はい | はい | いいえ | 真 | はい(キャプションを使用) | いいえ |
| はい | はい | はい | 偽 | いいえ | はい(VoiceCaption を使用) |
| はい | はい | いいえ | 偽 | いいえ | いいえ |
| いいえ | はい | はい | 真 | いいえ | はい(VoiceCaption を使用) |
| いいえ | はい | はい | 偽 | いいえ | はい(VoiceCaption を使用) |
| いいえ | はい | いいえ | 真 | いいえ | いいえ |
| いいえ | はい | いいえ | 偽 | いいえ | いいえ |
| はい | No1 | はい | 真 | はい(キャプションを使用) | はい(キャプションを使用) |
| はい | いいえ | いいえ | 真 | はい | いいえ |
| はい | いいえ | はい | 偽 | いいえ | はい(キャプションを使用) |
| はい | いいえ | いいえ | 偽 | いいえ | いいえ |
| いいえ | いいえ | はい | 真 | いいえ | いいえ |
| いいえ | いいえ | はい | 偽 | いいえ | いいえ |
| いいえ | いいえ | いいえ | 真 | いいえ | いいえ |
| いいえ | いいえ | いいえ | 偽 | いいえ | いいえ |
| プロパティ設定が null の場合。 一部のプログラミング言語では、空の文字列が null 文字列と同じとは解釈されない場合があります。 このコマンドは引き続き音声アクセス可能であり、音声コマンド ウィンドウに "(command undefined)" と表示されます。 |  |  |  |  |  |