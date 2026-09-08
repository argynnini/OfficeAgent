---
layout: Conceptual
title: 出力の問題 - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/output-problems
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: 出力の問題
document_id: bdd4d2c5-5616-3b2e-5047-feb4c728a8f1
document_version_independent_id: ced4450a-0fd1-f9e9-1995-d4e1e1ac1a4b
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/output-problems.md
locale: ja-jp
ms.assetid: 45423b7e-f648-408c-9cff-f7cf1affc42a
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/output-problems.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:58:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/output-problems.md
page_type: conceptual
toc_rel: toc.json
word_count: 3430
asset_id: lwef/output-problems
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 3b9da945-0e46-e326-0493-26e18327cca4
---

# 出力の問題 - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

### キャラクターは移動時に画像や証跡を残します。

エージェント文字がアニメーション化されると、キャラクターの背後にあるアプリケーション ウィンドウがタイムリーに更新される必要があります。 キャラクターが画面を移動すると、(PCの速度や実行中のアプリケーションに応じて) すぐに消える残りの画像が表示されることがあります。 そうでない場合は、次の原因が考えられます。

- システムがエージェントの最小システム要件を満たしていません。
- 文字の背後にあるアプリケーション ウィンドウは、更新をタイムリーに処理しません。 デスクトップまたはフォルダー ウィンドウの上に文字をドラッグするか、アプリケーションの一部をシャットダウンしてみてください。 顕著な改善が見られた場合、問題は避けられない可能性があります。
- Microsoft Internet Explorer 4.0 (またはそれ以降) の公式リリースがインストールされていない可能性があります。 Internet Explorer 4.0 の以前のプレリリース バージョンでは、画面の更新が正しく処理されませんでした。 これにより、画面に残っている文字の画像が残ります。 この問題を解決するには、Internet Explorer ([https://www.microsoft.com/windows/ie/](https://www.microsoft.com/windows/internet-explorer/default.aspx)) の最新の公式リリースをインストールします。
- システムのスクリーン ドライバーまたはハードウェアに問題がある可能性があります。 グラフィック ハードウェアの最新のドライバーがあることを確認します。 それでも問題が解決しない場合は、PC ベンダーにお問い合わせください。

### 文字は、読み上げ時にオーディオ出力を生成しません。

この症状には、いくつかの原因が考えられます。 問題を特定するには、次の手順を試してください。

- スピーカーが接続されており、サウンド カードが Windows と互換性があることを確認します。 オーディオ出力が正常に動作していることを確認するために、別のサウンド アプリケーションでそれらをテストすることをお勧めします。
- エージェント対応アプリケーションまたは Web ページで音声入力がサポートされていることを確認します。 すべてのサンプル ページで音声入力がサポートされているわけではありません。 リッスン キーを長押しします (通常は、変更しない限りスクロール ロック キーになります)。文字の下にポップアップ ウィンドウが表示されます。 ヒントのテキストは、文字のリッスン状態を示します。 ヒントが表示されない場合は、アプリケーションまたは Web ページで音声入力がサポートされていないか、互換性のある音声エンジンがインストールされていません。 ヒントが表示され、キャラクターがリッスン中であることを示す場合は、キャラクターの音声コマンドの 1 つを読み上げます。 使用可能な音声コマンドがわからない場合は、Listening キーを放して文字を右クリックし、ポップアップ メニューから [音声コマンド ウィンドウを開く] を選択します。 コマンドが表示されない場合、使用しているアプリケーションまたは Web ページで音声サポートを利用できません。 表示される場合は、もう一度 Listening キーを長押しします。 リスニング ヒントが文字の下に表示され、文字がリッスンしていることを示す場合は、ウィンドウに表示されているコマンドのいずれかを読み上げる必要があります。 文字が応答しない場合は、次の手順に進みます。
- 他のアプリケーションが現在オーディオ出力デバイスを使用していないかどうかを確認します。
- 使用している文字が音声出力用に構成されていることを確認します。 (Web サイトまたはアプリケーション サプライヤーに確認する必要がある場合があります)。
- Microsoft エージェントの設定で音声出力が有効になっていることを確認する
- 文字が音声合成 (TTS) エンジンを使用して音声出力を生成する場合は、互換性のある TTS エンジンがインストールされていることを確認します。 たとえば、Internet Explorer 4.0 アドオン コンポーネントとしてインストールすると、Microsoft エージェントのコア コンポーネントのみがインストールされます。 コア コンポーネントには、テキスト読み上げエンジンは含まれません。 この TTS エンジン (Microsoft Speech API 互換エンジン) がないと、Microsoft エージェントのサンプル文字は音声出力を生成しません。
- Microsoft エージェントによる MIDI の使用によってオーディオ チャネルがブロックされていないことを確認します (次のトピック「Microsoft Agent の実行中に MIDI を再生するアプリケーションにオーディオ出力がない」を参照してください)。

### Microsoft エージェントの実行中に MIDI を再生するアプリケーションにはオーディオ出力がありません。

Microsoft エージェントは、リスニング キーを押すと MIDI を使用してトーンを再生します。 これが MIDI を再生する他のアプリケーションに干渉したり、音声入力を妨げたりする場合は、Microsoft エージェントのプロパティの [話せるときにトーンを再生] オプションをオフにすることができます。

### 次のメッセージが表示されます。アプリケーションが入力同期呼び出しをディスパッチしているため、発信呼び出しを行うことはできません。

このメッセージは、次の状況で発生する可能性があります。

Microsoft エージェントを含む Web ページが閉じられた場合 (ページのタスク バー エントリを右クリックし、ポップアップ メニューから [閉じる] を選択すると)、これが発生する可能性があります。 これは、エージェントとブラウザーが同時にシャットダウンするときのタイミングの問題が原因です。 エラーは無害です。 [OK] をクリックしてメッセージを閉じます。

エージェント対応の Web ページ (またはアプリケーション) が特定のテキスト読み上げ (TTS) エンジンを要求しようとしました。 Speechapi.dll がインストールされていません。

### 音声エンジンは Windows XP で Microsoft エージェントで動作しないようですか?

Microsoft エージェントは、SAPI 4.0 を使用して音声サービスを提供します。 ただし、Windows XP には SAPI 5.0 が付属しており、その前身に下位互換性のサポートは提供されていません。 幸いなことに、SAPI 4.0 と SAPI 5.0 は、同じ Windows XP コンピューター上に共存できます。

Windows XP で音声エンジンを Microsoft Agent と連携させるには、最初に SAPI 4.0 ランタイム バイナリ (spchapi.exe) をインストールしてから、特定の音声エンジンをインストールします。

### Windows XP にアップグレードするまで、Microsoft エージェントで動作する音声エンジン。 どうされました。

前の質問と回答を参照してください。 Windows XP のアップグレード プロセスにより、コンピューターに既に存在する SAPI 4.0 サポートが削除された可能性があります。 Windows XP へのアップグレード後に、SAPI 4.0 ランタイムと SAPI 4.0 音声エンジンをもう一度再インストールするだけです。

### Windows XP (または Windows 2000) を実行するコンピューターにTTS3000テキスト読み上げエンジンをインストールし、それに応じてプログラミングを適切に編集して使用しました。 Microsoft エージェントの文字は、これらのTTS3000テキスト読み上げエンジンを使用して、管理者特権を持たない他のユーザーがログインしているが、他の *ユーザーがこのコンピューターにログイン* 場合は読み上げません。 Windows 98 と Windows Me では、これらのTTS3000テキスト読み上げエンジンは両方のユーザー セットで正しく動作します。 これを修正するにはどうすればよいですか?

管理者特権なしでユーザー アカウントで使用できるように、TTS3000テキスト読み上げエンジンの一部のレジストリ キーのセキュリティ アクセス許可を構成する必要があります。 これは、オペレーティング システムのレジストリ エディターを使用して実現できます。

### 前の質問に記載されている問題の解決策として説明されている手順に従いました。 これにより、管理者特権を持たないユーザーが Windows XP (または Windows 2000) コンピューターにログイン *ユーザーが* するときに、これらのTTS3000テキスト読み上げエンジンを使用して、Microsoft エージェントの文字が音声合成エンジンを使用して音声読み上げを行えるようになります。 数か月後、これらの同じTTS3000テキスト読み上げエンジンが再び動作しなくなりました。 どうされました。

前の質問で説明した手順に従うと、管理者以外のユーザー アカウントに、必要なレジストリ キーに対するフル コントロールアクセス許可が提供されました。 これらのユーザーの 1 人が、知らないうちに値を編集したり、アクセス許可を再度変更したり、レジストリ キーを完全に削除したりしている可能性があります。

これらのレジストリ キーとそのアクセス許可が編集、削除、またはその他の変更されたかどうかを確認します。 必要に応じて、これらのレジストリ キーとそのアクセス許可をもう一度変更するか、TTS3000テキスト読み上げを再インストールします。