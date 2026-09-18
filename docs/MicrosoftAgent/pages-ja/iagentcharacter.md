---
layout: Conceptual
title: IAgentCharacter - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcharacter
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCharacter
document_id: f89b0ad7-353b-99bb-060c-2ad7a10d7911
document_version_independent_id: adb4a26a-7cb6-cb70-099d-6966573bb672
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacter.md
locale: ja-jp
ms.assetid: 77d0ffc2-76a2-4a21-88e1-1ca85b8c5d2f
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacter.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:47:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcharacter.md
page_type: conceptual
toc_rel: toc.json
word_count: 978
asset_id: lwef/iagentcharacter
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 9564c028-e355-0836-58f4-1a0544227db7
---

# IAgentCharacter - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

IAgentCharacter  は、アプリケーションが文字プロパティのクエリを実行してアニメーションを再生できるようにするインターフェイスを定義します。 これらの関数は、[**IAgentCharacterEx**](iagentcharacterex)からも使用できます。 メソッドの戻り値要求 ID を使用して、文字のキュー内の状態を追跡し、コードをキャラクターの現在のアニメーション状態と同期させることができます。

Vtable Order **のメソッドを** する

| IAgentCharacter メソッド | 形容 |
| --- | --- |
| GetVisible**[の](iagentcharacter--getvisible)** | 文字 (フレーム) が現在表示されているかどうかを返します。 |
| [**SetPosition**](iagentcharacter--setposition) | 文字フレームの位置を設定します。 |
| GetPosition**[を](iagentcharacter--getposition)**する | 文字フレームの位置を返します。 |
| [**SetSize**](iagentcharacter--setsize) | 文字フレームのサイズを設定します。 |
| [**GetSize**](iagentcharacter--getsize) | 文字フレームのサイズを返します。 |
| GetName**[の](iagentcharacter--getname)** | 文字の名前を返します。 |
| GetDescription**[を](iagentcharacter--getdescription)**する | 文字の説明を返します。 |
| GetTTSSpeed**[を](iagentcharacter--getttsspeed)**する | 文字の現在の TTS 出力速度設定を返します。 |
| GetTTSPitch**[を](iagentcharacter--getttspitch)**する | 文字の現在の TTS ピッチ設定を返します。 |
| [**アクティブ化**](iagentcharacter--activate) | クライアントがアクティブか、文字が一番上にあるかを設定します。 |
| SetIdleOn**[の](iagentcharacter--setidleon)** | サーバーのアイドル処理を設定します。 |
| GetIdleOn**[を](iagentcharacter--getidleon)**する | サーバーのアイドル処理の設定を返します。 |
| [**準備**](iagentcharacter--prepare) | 文字のアニメーション データを取得します。 |
| [**Play**](iagentcharacter--play) | 指定したアニメーションを再生します。 |
| [**Stop**](iagentcharacter--stop) | キャラクターのアニメーションを停止します。 |
| [**StopAll**](iagentcharacter--stopall) | 文字のすべてのアニメーションを停止します。 |
| [**wait**](iagentcharacter--wait) | キャラクターのアニメーション キューを保持します。 |
| [**割り込み**](iagentcharacter--interrupt) | キャラクターのアニメーションを中断します。 |
| の表示 | キャラクターを表示し、キャラクターの **表示** 状態アニメーションを再生します。 |
| を非表示にする | キャラクタの **非表示** 状態アニメーションを再生し、キャラクタのフレームを非表示にします。 |
| [**話す**](iagentcharacter--speak) | キャラクターの音声出力を再生します。 |
| MoveTo**[を](iagentcharacter--moveto)**する | 文字フレームを指定した位置に移動します。 |
| [**GestureAt**](iagentcharacter--gestureat) | 指定した位置に基づいて、ゲスチャリング アニメーションを再生します。 |
| GetMoveCause**[を](iagentcharacter--getmovecause)**する | 文字の最後の移動の原因を取得します。 |
| [**GetVisibilityCause**](iagentcharacter--getvisibilitycause) | 文字の表示状態に対する最後の変更の原因を取得します。 |
| [**HasOtherClients**](iagentcharacter--hasotherclients) | 文字に他の現在のクライアントがあるかどうかを取得します。 |
| [**SetSoundEffectsOn**](iagentcharacter--setsoundeffectson) | キャラクター アニメーションのサウンド エフェクトを再生するかどうかを指定します。 |
| GetSoundEffectsOn**[の](iagentcharacter--getsoundeffectson)** | キャラクターのサウンド エフェクト設定が有効かどうかを取得します。 |
| SetName**[の](iagentcharacter--setname)** | 文字の名前を設定します。 |
| SetDescription**[の](iagentcharacter--setdescription)** | 文字の説明を設定します。 |
| GetExtraData**[の](iagentcharacter--getextradata)** | 文字と共に格納されている追加のデータを取得します。 |