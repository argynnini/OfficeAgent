---
layout: Conceptual
title: 音声入力の問題 - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/speech-input-problems
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: 音声入力の問題
document_id: 890f35d9-5b8c-79a9-010b-147dc1efbf31
document_version_independent_id: 4fa1016a-c833-240d-f314-da0cdc9ff346
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/speech-input-problems.md
locale: ja-jp
ms.assetid: b42664a2-9615-4e15-97a6-115e9556096b
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/speech-input-problems.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:00:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/speech-input-problems.md
page_type: conceptual
toc_rel: toc.json
word_count: 2047
asset_id: lwef/speech-input-problems
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 9e9fb508-41e4-25ca-ee79-d97a90a1a388
---

# 音声入力の問題 - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

### この文字は、音声入力に応答しません。

この症状は、多くの問題によって引き起こされる可能性があります。 問題を特定するには、次の手順を試してください。

- マイクが正しく接続されていることを確認します。 別のサウンド入力アプリケーションでテストして、正常に動作することを確認することをお勧めします。
- 互換性のある音声エンジンがインストールされていることを確認します。 Windows 95、Windows 98、Windows NT 4.0 で、コントロール パネルを開きます。 そこで Speech オブジェクトが見つかると、それを開くと、システムに使用可能でインストールされている音声エンジンが一覧表示されます。
- サウンド カードが Microsoft Windows 95、Windows 98、または Windows NT と互換性があることを確認します。

    これを行う最善の方法は、Windows に付属するサウンド レコーダー アプリケーションを実行することです。 通常は、[スタート] メニューにあります。 [スタート] ボタンをクリックし、[プログラム]、[アクセサリ] の順にクリックし、[マルチメディア] をクリックして、[サウンド レコーダー] をクリックします。 サウンドレコーダーウィンドウが表示されたら、**録音** ボタンをクリックしてマイクに話しかけます。 ウィンドウ内の行は、音声入力に応答してアニメーション化する必要があります。

    サウンド レコーダー アプリケーションがシステムで動作しない場合は、サウンド カードの製造元のテクニカル サポート部門にお問い合わせください。 サウンド カードが Windows と互換性がない場合や、サウンド カードのソフトウェア ドライバーに問題がある可能性があります。
- 音声入力のサウンド入力が正しく設定されていることを確認します。

    1. コントロール パネルで Speech 入力オブジェクトを開きます。 Speech オブジェクトが存在しない場合は、インストールします。
    2. インストールした音声入力エンジンを選択します。
    3. マイク設定ウィザードボタンを選択します。 このボタンが無効になっていると、互換性のある音声エンジンがインストールされていないか、インストールした音声エンジンが自動調整をサポートしていない可能性があります。
- エージェント対応アプリケーションまたは Web ページで音声入力がサポートされていることを確認します。 すべてのページ (またはアプリケーション) が音声入力をサポートしているわけではありません。 Listening キーを長押しします。 通常、変更しない限り、これはスクロール ロック キーになります。 文字の下にポップアップ ウィンドウが表示されます。 ヒントのテキストは、文字のリッスン状態を示します。 ヒントが表示されない場合は、アプリケーションまたは Web ページで音声入力がサポートされていないか、互換性のある音声エンジンがインストールされていません。 ヒントが表示され、キャラクターがリッスン中であることを示す場合は、キャラクターの音声コマンドの 1 つを話します。 使用可能な音声コマンドがわからない場合は、Listening キーを放して、文字を右クリックします。 次に、ポップアップ メニューから [音声コマンド ウィンドウを開く] を選択します。 コマンドが表示されない場合、使用しているアプリケーションまたは Web ページで音声サポートを利用できません。 表示される場合は、もう一度 Listening キーを長押しします。 リスニング ヒントが文字の下に表示され、文字がリッスンしていることを示す場合は、ウィンドウに表示されているコマンドのいずれかを読み上げる必要があります。 文字が応答しない場合は、次の手順に進みます。
- 他のアプリケーションが現在オーディオ出力デバイスを使用していないかどうかを確認します。
- Microsoft エージェントによる MIDI の使用によってオーディオ チャネルがブロックされていないことを確認します (「出力の問題」セクションの「[」を実行しているときに、MIDI を再生するアプリケーションにオーディオ出力がない](output-problems)を参照してください)。
- 上記の手順に従っても音声入力に問題がある場合は、サウンド カードとドライバー ソフトウェアが使用している音声エンジンと互換性があることを確認します。 サウンド カードと音声エンジンの製造元のテクニカル サポートに問い合わせてください。

### MIDIトーンは、音声入力を中断するように見えます。

次の手順を使用して MIDI ボリュームを減らします。

1. タスク バーのスピーカー アイコンを右クリックするか、コントロール パネルでマルチメディア オブジェクトを開いて、音量コントロール ウィンドウを開きます。 [オーディオ] ページの [再生] セクションの [音量] ボタンをクリックします。
2. スライダーを下に移動して MIDI 音量を下げます。

### 文字は音声入力に応答しませんが、マイクに話し込むとスピーカーから音声が聞こえます。

サウンド カードが Microsoft エージェントで使用できるように正しく設定されていません。 コントロール パネルの Speech オブジェクトのプロパティ シートで、マイク設定ウィザードを選択します。 このボタンにアクセスする方法については、「文字が音声入力に応答しない」の手順を参照してください。