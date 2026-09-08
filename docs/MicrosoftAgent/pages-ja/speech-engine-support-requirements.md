---
layout: Conceptual
title: 音声エンジンのサポート要件 - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/speech-engine-support-requirements
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: 音声エンジンのサポート要件
document_id: 12a3f429-0644-63eb-4c6b-e88183896699
document_version_independent_id: c59c07f5-e26f-f316-3aa1-050406f3f549
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/speech-engine-support-requirements.md
locale: ja-jp
ms.assetid: 3f37cf87-e45c-4a75-aae0-1db3b3e0206e
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/speech-engine-support-requirements.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:00:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/speech-engine-support-requirements.md
page_type: conceptual
toc_rel: toc.json
word_count: 274
asset_id: lwef/speech-engine-support-requirements
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: a861fa4f-f5ed-3bc6-f159-e62f69f66e6e
---

# 音声エンジンのサポート要件 - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

Microsoft Agent は、Microsoft Speech Application Programming Interface (SAPI) を使用して、音声入力 (音声認識、SR) と音声出力 (テキスト読み上げ、TTS) をサポートします。 この標準をサポートすることで、Microsoft エージェントの音声サービスを他の音声エンジンでサポートできます。 このドキュメントでは、Microsoft エージェントで使用される必要な SAPI インターフェイスについて説明します。 SAPI の詳細については、Microsoft Speech [グループの Web サイト](https://msdn.microsoft.com/library/ee705648.aspx) を参照してください。

- テキストTo-Speech エンジン [の](requirements-for-text-to-speech-engines) 要件
- 音声認識エンジン [の](requirements-for-speech-recognition-engines) 要件
- Microsoft 言語情報サウンド編集ツール [をサポートするための](requirements-for-supporting-the-microsoft-linguistic-information-sound-editing-tool) 要件