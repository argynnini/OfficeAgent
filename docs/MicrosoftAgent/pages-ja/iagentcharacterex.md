---
layout: Conceptual
title: IAgentCharacterEx - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcharacterex
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCharacterEx
document_id: d6fc13b0-9445-a296-1114-27a106e1a0f5
document_version_independent_id: cd4b007f-636c-976e-7db5-8956b405c884
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacterex.md
locale: ja-jp
ms.assetid: 8defc836-cc54-40c7-8afc-ec90f941861b
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacterex.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:48:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcharacterex.md
page_type: conceptual
toc_rel: toc.json
word_count: 619
asset_id: lwef/iagentcharacterex
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: d0291bc1-9616-04cf-94ef-d8d0702a056e
---

# IAgentCharacterEx - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

IAgentCharacterEx 、[**IAgentCharacter**](iagentcharacter) インターフェイスから派生します。 これには、すべての **IAgentCharacter** メソッドが含まれるだけでなく、追加の関数へのアクセスも提供されます。

Vtable Order **のメソッドを** する

| IAgentCharacterEx メソッド | 形容 |
| --- | --- |
| [**ShowPopupMenu**](iagentcharacterex--showpopupmenu) | 文字のポップアップ メニューを表示します。 |
| [**SetAutoPopupMenu**](iagentcharacterex--setautopopupmenu) | サーバーがキャラクターのポップアップ メニューを自動的に表示するかどうかを設定します。 |
| GetAutoPopupMenu**[を](iagentcharacterex--getautopopupmenu)**する | サーバーが文字のポップアップ メニューを自動的に表示するかどうかを返します。 |
| GetHelpFileName**[の](iagentcharacterex--gethelpfilename)** | 文字のヘルプ ファイル名を返します。 |
| SetHelpFileName**[の](iagentcharacterex--sethelpfilename)** | 文字のヘルプ ファイル名を設定します。 |
| SetHelpModeOn**[の](iagentcharacterex--sethelpmodeon)** | ヘルプ モードをオンに設定します。 |
| GetHelpModeOn**[の](iagentcharacterex--gethelpmodeon)** | ヘルプ モードがオンかどうかを返します。 |
| SetHelpContextID**[の](iagentcharacterex--sethelpcontextid)** | 文字の HelpContextID を設定します。 |
| GetHelpContextID**[の](iagentcharacterex--gethelpcontextid)** | 文字の HelpContextID を返します。 |
| GetActive**[の](iagentcharacterex--getactive)** | 文字のアクティブな状態を返します。 |
| [**listen**](iagentcharacterex--listen) | 文字のリッスン状態を設定します。 |
| SetLanguageID**[の](iagentcharacterex--setlanguageid)** | 文字の言語 ID を設定します。 |
| getLanguageID**[を](iagentcharacterex--getlanguageid)**する | 文字の言語 ID を返します。 |
| getTTSModeID**[を](iagentcharacterex--getttsmodeid)**する | 文字に設定された TTS モード ID を返します。 |
| [**SetTTSModeID**](iagentcharacterex--setttsmodeid) | 文字の TTS モード ID を設定します。 |
| getSRModeID**[を](iagentcharacterex--getsrmodeid)**する | 現在の音声認識エンジンのモード ID を返します。 |
| setSRModeID**[の](iagentcharacterex--setsrmodeid)** | 音声認識エンジンを設定します。 |
| GetGUID**[を](iagentcharacterex--getguid)**する | 文字の識別子を返します。 |
| GetOriginalSize**[の](iagentcharacterex--getoriginalsize)** | 文字フレームの元のサイズを返します。 |
| [**考える**](iagentcharacterex--think) | 文字の "思考" 吹き出しに指定したテキストを表示します。 |
| [**GetVersion**](iagentcharacterex--getversion) | 文字のバージョンを返します。 |
| GetAnimationNames**[の](iagentcharacterex--getanimationnames)** | 文字のアニメーションの名前を返します。 |
| getSRStatus**[を](iagentcharacterex--getsrstatus)**する | 音声入力をサポートするために必要な条件を返します。 |