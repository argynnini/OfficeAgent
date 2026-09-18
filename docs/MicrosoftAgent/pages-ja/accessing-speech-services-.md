---
layout: Conceptual
title: Speech Services へのアクセス (Microsoft エージェント制御) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/accessing-speech-services-
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Microsoft Agent Control を使用した音声サービスへのアクセスについて説明します。 Microsoft エージェントは、Windows 7 の時点で非推奨となりました。
document_id: cc095351-4877-be6b-9dae-4949edd0bdc0
document_version_independent_id: bc109fdb-83e8-aae3-23fe-3448b7b5bd40
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/accessing-speech-services-.md
locale: ja-jp
ms.assetid: c6c10f2a-a433-4a8e-a069-48e3c2032fb8
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/accessing-speech-services-.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:36:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/accessing-speech-services-.md
page_type: conceptual
toc_rel: toc.json
word_count: 913
asset_id: lwef/accessing-speech-services-
item_type: Content
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/a8711e05-df51-442a-970f-935304535b39
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/3d3c20d8-79ed-4203-aee0-ffb9c9bafe72
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: ab96e364-e70f-ac9e-7210-45eace505d71
---

# Speech Services へのアクセス (Microsoft エージェント制御) - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

Microsoft エージェントのサービスには音声入力のサポートが含まれていますが、エージェントの音声入力サービスにアクセスするには、互換性のあるコマンド アンド コントロール音声認識エンジンをインストールする必要があります。 同様に、Microsoft エージェントの音声サービスを使用して文字の合成音声出力をサポートする場合は、文字に互換性のあるテキスト読み上げ (TTS) 音声エンジンをインストールする必要があります。

アプリケーションで音声入力のサポートを有効にするには、 [**Command**](https://www.bing.com/search?q=**Command**) オブジェクトを定義し、その [**Voice**](https://www.bing.com/search?q=**Voice**) プロパティを設定します。 エージェントによって音声サービスが自動的に読み込まれるため、ユーザーがリッスン キーを押すか、 [**Listen**](https://www.bing.com/search?q=**Listen**) を呼び出すと、音声認識エンジンが読み込まれます。 既定では、文字の [**LanguageID**](https://www.bing.com/search?q=**LanguageID**) によって、読み込まれるエンジンが決まります。 エージェントは、Microsoft Speech API (SAPI) がこの言語に一致するように返す最初のエンジンを読み込もうとします。 特定のエンジンを読み込む場合は、 [**SRModeID**](https://www.bing.com/search?q=**SRModeID**) を使用します。

テキスト読み上げ出力を有効にするには、 [**Speak**](https://www.bing.com/search?q=**Speak**) メソッドを使用します。 エージェントは、文字の [**LanguageID**](https://www.bing.com/search?q=**LanguageID**) に一致するエンジンの読み込みを自動的に試みます。 文字の定義に特定の TTS エンジン モード ID が含まれており、そのエンジンが使用可能で、文字の **LanguageID** と一致する場合、エージェントはそのエンジンを文字に対して読み込みます。 そうでない場合は、SAPI が文字の言語設定に一致するように返す最初の TTS エンジンが読み込まれます。 [**TTSModeID**](https://www.bing.com/search?q=**TTSModeID**) を使用して、特定のエンジンを読み込むこともできます。

通常、エージェントは、リッスン モードが開始されたときに音声認識を読み込み、 [**Speak**](https://www.bing.com/search?q=**Speak**) が最初に呼び出されたときにテキスト読み上げエンジンを読み込みます。 ただし、音声エンジンを事前に読み込む場合は、音声インターフェイスに関連するプロパティに対してクエリを実行します。 たとえば、 [**SRModeID**](https://www.bing.com/search?q=**SRModeID**) または [**TTSModeID**](https://www.bing.com/search?q=**TTSModeID**) に対してクエリを実行すると、その種類のエンジンの読み込みが試行されます。

Microsoft エージェントの音声サービスは Microsoft Speech API に基づいているため、必要な音声インターフェイスをサポートする任意のエンジンを使用できます。