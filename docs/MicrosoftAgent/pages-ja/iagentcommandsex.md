---
layout: Conceptual
title: IAgentCommandsEx - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcommandsex
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCommandsEx
document_id: 0efaf034-421c-3c56-6ca4-2129cc91be53
document_version_independent_id: 2f36e422-6f3f-77d8-e1c2-bbf91cc878c3
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcommandsex.md
locale: ja-jp
ms.assetid: 6c354677-4cdb-4a74-9c41-2d0bf6f8dd55
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommandsex.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:51:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcommandsex.md
page_type: conceptual
toc_rel: toc.json
word_count: 524
asset_id: lwef/iagentcommandsex
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: bb3dd29c-e060-2ef7-a4b3-946cc0d4f356
---

# IAgentCommandsEx - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

IAgentCommandsExは、[**IAgentCommands**](iagentcommands) インターフェイスを拡張するインターフェイスを定義します。

Vtable Order **のメソッドを** する

| IAgentCommandsEx メソッド | 形容 |
| --- | --- |
| SetDefaultID [の](iagentcommandsex--setdefaultid) | 文字のポップアップ メニューの既定のコマンドを設定します。 |
| GetDefaultID [の](iagentcommandsex--getdefaultid) | 文字のポップアップ メニューの既定のコマンドを返します。 |
| SetHelpContextID**[の](iagentcommandex--sethelpcontextid)** | [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトの状況依存ヘルプ トピック ID を設定します。 |
| GetHelpContextID**[の](iagentcommandex--gethelpcontextid)** | [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトの状況依存ヘルプ トピック ID を返します。 |
| [SetFontName](iagentcommandsex--setfontname) | 文字のポップアップ メニューで使用するフォントを設定します。 |
| GetFontName [を](iagentcommandsex--getfontname) する | 文字のポップアップ メニューで使用されるフォントを返します。 |
| SetFontSize [の](iagentcommandsex--setfontsize) | 文字のポップアップ メニューで使用するフォント サイズを設定します。 |
| [GetFontSize](iagentcommandsex--getfontsize) | 文字のポップアップ メニューで使用されるフォント サイズを返します。 |
| SetVoiceCaption**[の](iagentcommandex--setvoicecaption)** | キャラクターの [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトの音声キャプションを設定します。 |
| GetVoiceCaption**[の](iagentcommandex--getvoicecaption)** | キャラクターの [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトの音声キャプションを返します。 |
| AddEx [の](iagentcommandsex--addex) | [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトを [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションに追加します。 |
| InsertEx [の](iagentcommandsex--insertex) | [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションに [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトを挿入します。 |
| SetGlobalVoiceCommandsEnabled [の](iagentcommandsex--setglobalvoicecommandsenabled) | エージェントのグローバル コマンドの音声文法を有効にします。 |
| GetGlobalVoiceCommandsEnabled [の](iagentcommandsex--getglobalvoicecommandsenabled) | エージェントのグローバル コマンドの音声文法が有効かどうかを返します。 |