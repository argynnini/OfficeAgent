---
layout: Conceptual
title: Microsoft エージェント - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/microsoft-agent
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Microsoft Agent バージョン 2.0 は、アプリケーションと Web ページ用の革新的な新しい会話インターフェイスを作成するテクノロジを提供します。
document_id: 32001c35-c754-1e60-ce8c-0c05b20cc86f
document_version_independent_id: 2379acd2-084a-da41-7fde-0716b103387b
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/microsoft-agent.md
keywords:
- Microsoft エージェント
- Microsoft エージェントのスタート ページ
locale: ja-jp
ms.assetid: vs|msagent|~\agentstartpage_7gdh.htm
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/microsoft-agent.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:55:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-01-09T19:49:59.6397822Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/microsoft-agent.md
page_type: conceptual
toc_rel: toc.json
word_count: 1388
asset_id: lwef/microsoft-agent
item_type: Content
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: f2e89354-1fc4-6c34-39af-d87ef18fb59b
---

# Microsoft エージェント - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。 詳細については、「[Windows 7 および Windows Server 2008 R2 Application Quality Cookbook](../win7appqual/windows-7-application-quality-cookbook)」を参照してください。

## 目的

Microsoft Agent バージョン 2.0 は、アプリケーションと Web ページ用の革新的な新しい会話インターフェイスを作成するテクノロジを提供します。 強力なアニメーション機能、対話機能、汎用性が提供され、開発が容易になります。

Microsoft Agent は、ユーザーがコンピューターと通信するためのより自然な方法の基盤を提供するテクノロジです。 これは、開発者がインタラクティブなアニメーションキャラクターをアプリケーションやWebページに組み込むことができるソフトウェアサービスのセットです。 これらの文字は、テキスト読み上げエンジンまたは録音されたオーディオを介して話すことも、音声コマンドを受け入れることもできます。 Microsoft Agent を使用すると、開発者は、現在普及している従来のマウス操作やキーボード操作を超えてユーザー インターフェイスを拡張できます。

目に見えるインタラクティブなパーソナリティでアプリケーションや Web ページを強化することで、ユーザーとコンピューターの間の相互作用が広がり、人間化されます。

## 該当する場合

開発者がこれらのパーソナリティを実行するために作成できるロールと関数の数は限りなくあります。

- ウェルカム ホストは、新しいユーザーに挨拶し、コンピューターの電源が初めてオンになったり、アプリケーションが実行されたり、Web サイトが閲覧されたりした場合にガイド付きツアーを提供できます。
- 親しみやすい家庭教師は、タスクやデシジョン ツリーを通して、指示を順を追って案内することができます。
- メッセンジャーは、新しい電子メールが届いたという通知またはアラートを配信し、それを読み取るために提供することができます。
- アシスタントは、インターネット上の情報を検索して大声で読み上げるなどのタスクを実行できます。

## 開発者対象ユーザー

Microsoft エージェントは主に、COM または Microsoft ActiveX コントロール インターフェイスをサポートする言語または環境を使用する開発者向けに設計されています。 次に示します。

- Microsoft Visual Studio (Visual C++、Visual Basic)
- Microsoft Office (Visual Basic for Applications)
- Microsoft Internet Explorer (Visual Basic Scripting Edition または Microsoft JScript)
- Microsoft Windows スクリプト ホスト (ActiveX スクリプト言語)
- COM または ActiveX コントロール インターフェイスをサポートするその他のアプリケーションと環境。

## 実行時の要件

**必須:**

- Microsoft Windows 95、Windows 98、Windows Me、Windows NT 4.0 (x86)、または Windows 2000
- Internet Explorer バージョン 3.02 以降
- Pentium 100 MHz PC (またはそれ以上)
- 16 メガバイト (MB) 以上の RAM
- コア コンポーネント用に少なくとも 1 MB の空きディスク領域
- インストールする文字ごとにさらに 2 ~ 4 MB
- 各言語コンポーネント (DLL) に 32 KB を追加

**推奨:**

- 音声出力に Lernout & Hauspie TruVoice Text-To-Speech Engine を使用する予定の場合は、追加の 1.6 MB の空きディスク領域
- Microsoft 音声認識エンジンを使用して音声入力を行う予定の場合は、さらに 22 MB の空きディスク領域
- Windows 互換のサウンド カード
- 互換性のあるスピーカーとマイクのセット