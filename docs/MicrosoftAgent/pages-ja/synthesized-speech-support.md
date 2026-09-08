---
layout: Conceptual
title: 合成音声のサポート - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/synthesized-speech-support
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: 合成音声のサポート
document_id: cb972b30-36b9-dc74-b3af-1387244f9408
document_version_independent_id: 9cbce955-5da6-55fd-17a8-33a40b1f73b6
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/synthesized-speech-support.md
locale: ja-jp
ms.assetid: 38172e04-a5b6-41e4-9d7c-539d9d4117be
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/synthesized-speech-support.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:01:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/synthesized-speech-support.md
page_type: conceptual
toc_rel: toc.json
word_count: 1201
asset_id: lwef/synthesized-speech-support
item_type: Content
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/c6f99e62-1cf6-4b71-af9b-649b05f80cce
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/3f56b378-07a9-4fa1-afe8-9889fdc77628
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 46d1e533-8c29-8cf8-5340-a4560a9dee7d
---

# 合成音声のサポート - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

合成された音声を使用する場合、キャラクターはほぼすべてのことを言う能力を持ち、柔軟性が最も高い。 録音されたオーディオを使用すると、キャラクターに特定の音声または一意の音声を与えることができます。 出力を指定するには、音声テキストを [**Speak**](speak-method) メソッドのパラメーターとして指定します。

Microsoft Agent のアーキテクチャでは合成音声出力に Microsoft SAPI が使用されるため、この仕様に準拠する任意のエンジンを使用でき、[**ITTSNotifySinkW**](ittsnotifysinkw) インターフェイスの [**Visual**](https://www.bing.com/search?q=**Visual**) メソッドを使用して国際音声アルファベット (IPA) 出力をサポートします。 エンジンに必要な詳細については、「[Speech Engine のサポート要件」](requirements-for-text-to-speech-engines)を参照してください。

文字の言語 ID 設定によって、その TTS 出力が決まります。 クライアントが文字の言語 ID を指定しない場合、文字の言語 ID はユーザーの既定の言語 ID に設定されます。 文字の定義に特定のエンジンが含まれており、そのエンジンを読み込んで、文字の言語設定と一致する場合、そのエンジンが使用されます。 それ以外の場合、Microsoft エージェントは、使用可能な他のエンジンを列挙し、言語、性別、年齢に基づいて (その順序で) SAPI の最適な一致を要求します。 使用可能な一致するエンジンがない場合、そのクライアントによる文字の使用に対する TTS 出力はありません。 エージェントは、最初の [**Speak**](speak-method) 呼び出しで TTS エンジンを読み込もうとします。または、クエリを実行するか、モード ID を正常に設定します。

クライアント アプリケーションでは、その文字に TTS エンジンを指定することもできます ([**TTSModeID**](ttsmodeid-property) プロパティを使用)。 これにより、文字の優先 TTS モード ID または文字の現在の言語 ID 設定に基づいて、一致するエンジンを自動的に検索しようとするサーバーの試行がオーバーライドされます。 ただし、そのエンジンがインストールされていない (または読み込むことができない) 場合、呼び出しは失敗します (コントロールでエラーが発生します)。 その後、サーバーは、言語 ID、コンパイル済み文字 TTS 設定、および使用可能な TTS エンジンに基づいて、別のエンジンの読み込みを試みます。 一致するものがまだない場合、そのクライアントでは TTS を使用できませんが、文字は引き続きワード バルーンに話し込むことができます。

すべてのクライアントで使用中の TTS エンジンのみが読み込まれたままになります。 たとえば、文字に特定のエンジンの設定が定義されていて、そのエンジンを使用できるが、クライアント アプリケーションで異なるエンジンが指定されている (エンジンとは異なる文字の言語 ID を設定するか、別のモード ID を指定する) 場合、アプリケーションで指定されたエンジンのみが読み込まれたままになります。 TTS 設定に対する文字の定義された基本設定に一致するエンジンはアンロードされます (別のクライアントが文字のコンパイル済みエンジン設定を使用している場合を除く)。