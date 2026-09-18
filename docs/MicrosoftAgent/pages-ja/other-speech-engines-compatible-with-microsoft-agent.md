---
layout: Conceptual
title: Microsoft エージェントと互換性のあるその他の音声エンジン - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/other-speech-engines-compatible-with-microsoft-agent
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Microsoft エージェントと互換性のあるその他の音声エンジン
document_id: 8670d59b-88e0-cf0a-2477-608f53def857
document_version_independent_id: b43951e3-0841-4d64-1ef9-12fb562dcf3b
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/other-speech-engines-compatible-with-microsoft-agent.md
locale: ja-jp
ms.assetid: fa87c592-c819-4dea-a1d0-6ccb25cc0bcc
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/other-speech-engines-compatible-with-microsoft-agent.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:58:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/other-speech-engines-compatible-with-microsoft-agent.md
page_type: conceptual
toc_rel: toc.json
word_count: 1021
asset_id: lwef/other-speech-engines-compatible-with-microsoft-agent
item_type: Content
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: ae447366-e8e5-281d-f89b-90958be4f882
---

# Microsoft エージェントと互換性のあるその他の音声エンジン - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

Microsoft エージェントで提供およびサポートされている Microsoft 音声エンジンに加えて、多くの企業が Microsoft エージェントのサポートを備えた音声エンジンも提供しています。 このページでは、米国英語やその他の言語で利用できる可能性があるこのようなエンジンの概要を示します。 エンジンのインストールとアクセス方法、およびエンジンのライセンスと再配布の方法に関する情報は、Web サイトで確認できます。

サードパーティ製の音声エンジンを使用する場合は、エンジンが適切に列挙されるように Microsoft SAPI 4.0a ランタイム バイナリをインストールする必要もあります。 Web ページから次のタグを含め、Speech API の自動ダウンロードをトリガーできます。

```syntax
<OBJECT WIDTH=0 HEIGHT=0
  CLASSID="CLSID:0C7F3F20-8BAB-11d2-9432-00C04F8EF48F"
  CODEBASE="#VERSION=4,0,0,0">
</OBJECT>
```

SAPI ランタイム バイナリの詳細については、[Microsoft Speech グループの Web サイト](https://msdn.microsoft.com/library/ee705648.aspx)を参照してください。 Microsoft エージェントは、Microsoft 音声認識エンジン、音声コントロール パネル、およびエージェント文字エディターを使用して、SAPI ランタイム バイナリもインストールします。

これらのリンクは、Microsoft の管理下にないサーバーを指しています。 他のサーバーに関する microsoft [公式声明](https://www.microsoft.com/isapi/gomscom.asp?TARGET=/Misc/NonMS.md) を読んでください。 Microsoft は、これらの Web サイトで提供されるコンテンツやソフトウェアを推奨しません。 技術的およびサポートに関するすべての質問は、Microsoft や Microsoft エージェント チームではなく、エンジンのサプライヤーにも送信する必要があります。

**Digalo Text-To-Speech エンジン**

Digalo は、エンドユーザーと開発者向けに設計された手頃な価格の TTS エンジンです。 エンジンは、フランス語、ドイツ語、ポルトガル語 (ブラジル)、スペイン語、ロシア語、英国、および米国英語の多くの言語で提供され、イタリア語、ポーランド語、その他の言語が近日公開されます。 開発者情報だけでなく、エンドユーザーの登録とアフィリエイトプログラムの詳細も利用できます。

**Elan Speech Engine**

Elan Speech Engine は、Elan の Text To Speech テクノロジを使用し、フランス語、ドイツ語、ポルトガル語 (ブラジル)、スペイン語、ロシア語、英国、米国英語の 7 つの言語で利用できます。

**IBM ViaVoice Outloud**

IBM は、ViaVoice Outloud で使用する Microsoft エージェント文字をいくつか開発しました。 IBM ViaVoice Outloud は、テキスト読み上げ (音声合成) テクノロジであり、フランス語、ドイツ語、イタリア語、スペイン語、英国英語、および米国英語で利用できます。 Microsoft Agent と組み合わせると、多くの言語で活気のあるアプリケーションを作成し、新しい世界中の市場に販売機会を拡大できます。