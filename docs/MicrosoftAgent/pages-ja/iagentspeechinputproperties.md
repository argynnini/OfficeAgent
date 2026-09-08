---
layout: Conceptual
title: IAgentSpeechInputProperties - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentspeechinputproperties
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentSpeechInputProperties
document_id: 5f76efc2-726d-8927-d6cf-0dde0210f6c7
document_version_independent_id: c257ccc1-21dc-b3a1-401a-e82c7f21bfa9
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/iagentspeechinputproperties.md
locale: ja-jp
ms.assetid: 87bfc8c4-473b-4df9-becd-e90db12dae51
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentspeechinputproperties.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:53:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentspeechinputproperties.md
page_type: conceptual
toc_rel: toc.json
word_count: 510
asset_id: lwef/iagentspeechinputproperties
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: ec559b13-bea6-d75f-9186-27ae3a55b6d9
---

# IAgentSpeechInputProperties - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

IAgentSpeechInputProperties は、サーバーによって管理される音声入力プロパティへのアクセスを提供します。 ほとんどのプロパティはクライアント アプリケーションでは読み取り専用ですが、ユーザーは Microsoft Agent プロパティ シートでそれらを変更できます。 Microsoft エージェント サーバーは、互換性のある音声エンジンがインストールされ、有効になっている場合にのみ値を返します。 これらのプロパティに対してクエリを実行すると、音声エンジンの起動が試みられます。

Vtable Order **のメソッドを** する

| IAgentSpeechInputProperties メソッド | 形容 |
| --- | --- |
| GetEnabled**[の](iagentspeechinputproperties--getenabled)** | 音声認識エンジンが有効になっているかどうかを返します。 |
| GetHotKey**[を](iagentspeechinputproperties--gethotkey)**する | リッスン しているキーの現在のキーの割り当てを返します。 |
| GetListeningTip**[の](iagentspeechinputproperties--getlisteningtip)** | Listening Tip が有効になっているかどうかを返します。 |

[**GetInstalled**](https://www.bing.com/search?q=**GetInstalled**)、[**GetLCID**](https://www.bing.com/search?q=**GetLCID**)、[**GetEngine**](https://www.bing.com/search?q=**GetEngine**)、および [**SetEngine**](https://www.bing.com/search?q=**SetEngine**) メソッド (以前のバージョンの Microsoft Agent でサポート) は、下位互換性のために引き続きサポートされています。 ただし、メソッドはスタブ化されておらず、有用な値を返しません。 GetSRModeID使用し、SetSRModeID**[を](https://www.bing.com/search?q=**SetSRModeID**)**して、文字で使用する音声認識エンジンのクエリと設定を行います。 エンジンは文字の現在の言語設定と一致する必要があることに注意してください。