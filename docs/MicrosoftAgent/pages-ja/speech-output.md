---
layout: Conceptual
title: 音声出力 - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/speech-output
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: 音声出力
document_id: 4d351290-1622-3ff1-680a-892889eb9d50
document_version_independent_id: f9151f78-304c-8b4e-d2f5-2adcafc76a68
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/speech-output.md
locale: ja-jp
ms.assetid: 86ac204c-4925-4945-b7fa-d628c3539a8a
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/speech-output.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:01:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/speech-output.md
page_type: conceptual
toc_rel: toc.json
word_count: 752
asset_id: lwef/speech-output
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 83207be6-f664-1bdc-d612-33679a742e64
---

# 音声出力 - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

音声入力と同様に、音声出力は使い慣れた自然な形式の通信であるため、文字ベースのインターフェイスでも適切な補完です。 ただし、音声出力にも責任があります。 一部の環境では、音声出力が優先されないか、可聴である可能性があります。 さらに、音声自体は見えなくなり、短期的な記憶に大きく依存する永続的な出力はありません。 これらの要因により、大量の情報を処理するための容量と速度が制限されます。 同様に、音声出力は、特に音声が入力方法である場合に、ユーザー入力を中断する可能性もあります。 一般に、音声エンジンでは、音声または他のオーディオに出力チャネルがある場合にユーザーが中断できるようにするサポートはほとんどありません。

その結果、音声を排他形式の出力として使用しないようにします。 ただし、Microsoft エージェントは Windows インターフェイスの一部として文字を提供するため、音声のみの環境よりもいくつかの利点があります。 文字を他の形式の入力と出力と組み合わせて、オプションとアクションを表示し、視覚的または音声ベースのインターフェイスよりも効果的なインターフェイスを実現できます。

さらに、音声出力を表示しやすくするために、Microsoft エージェントには、漫画スタイルの単語吹き出しを使用してキャラクターを作成するオプションが含まれています。 その他の設定を使用すると、吹き出し内のテキストの表示方法と吹き出しを削除するタイミングを決定できます。 使用するフォントを決定することもできます。 文字のワード バルーン属性は設定できますが、ユーザーはこれらの設定をオーバーライドできることに注意してください。

- [効率的で自然な](be-efficient-and-natural)
- [Active Voice](use-the-active-voice) を使用する
- 適切なタイミングと強調 [を使用](use-appropriate-timing-and-emphasis)