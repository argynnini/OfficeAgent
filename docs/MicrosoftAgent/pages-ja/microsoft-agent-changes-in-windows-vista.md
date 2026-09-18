---
layout: Conceptual
title: Windows Vista での Microsoft エージェントの変更点 - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/microsoft-agent-changes-in-windows-vista
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Windows Vista での Microsoft エージェントの変更点
document_id: ce40749e-e8ce-8af6-33c9-b3cbe0514f6b
document_version_independent_id: 17d24cb0-530c-95d3-ebc3-f3145661e6ea
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/microsoft-agent-changes-in-windows-vista.md
locale: ja-jp
ms.assetid: 2498e8d5-2274-477c-a807-77443c76afb7
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/microsoft-agent-changes-in-windows-vista.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:55:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-01-09T19:49:59.6397822Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/microsoft-agent-changes-in-windows-vista.md
page_type: conceptual
toc_rel: toc.json
word_count: 1443
asset_id: lwef/microsoft-agent-changes-in-windows-vista
item_type: Content
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 7124db36-426a-6da4-2819-94fd0f09d53c
---

# Windows Vista での Microsoft エージェントの変更点 - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

Windows Vista では、音声認識と Windows Vista の対話方法にいくつかの変更が導入されています。

Microsoft エージェントでは、SAPI 5 のテキスト読み上げと音声認識のコンポーネントがサポートされるようになりました。 エージェント オブジェクトの TTSModeID プロパティと SRModeID プロパティは、エージェントに対して選択されている音声または認識エンジンを決定し、この選択を変更するために引き続き使用されます。 SAPI 4 モードは"{ca141fd0-ac7f-11d1-97a3-006008273000}" などの GUID 文字列として表示され、SAPI 5 トークン (モードと同等) は通常の名前 ("Microsoft Anna" など) として表示されます。 以前のリリースと同様に、エージェントは既定で TTS エンジンと SR エンジンを選択します。 SAPI 5 エンジンがインストールされている場合は、インストールできる SAPI 4 エンジンよりも常に優先されます。 コントロール パネルで指定されているユーザーの既定のテキスト読み上げエンジンは、その性別がキャラクターの性別と一致する場合に使用されます。それ以外の場合は、同じ性別の SAPI 5 エンジンが選択されます (使用可能な場合)。 SAPI 5 エンジンが存在する場合、文字に直接指定されたモード ID は無視されます。 既定の選択は、スクリプトの先頭にある TTSModeID プロパティと SRModeID プロパティを読み取ることで確認できます。

以前と同様に、テキスト読み上げまたは音声認識機能が存在しない場合、TTSModeID と SRModeID は空白の文字列を返します。 特定の音声または認識エンジンを選択するには、これらのプロパティを適切な SAPI 4 モード文字列または SAPI 5 トークン名に設定します。 特定のモードまたはトークンを設定した後、プロパティをもう一度読み取って、その値が取得されたことを確認することもできます。これは、新しいモードまたはトークンが実際に使用可能であり、正常に選択されたことを示します。 Web 経由でエージェントを展開する開発者の場合は、多くの Vista ユーザーに 1 つ以上の SAPI 5 音声が既にインストールされていることに注意してください。そのため、ダウンロードした音声が最終的に使用されないので、スクリプトが明示的に要求しない限り、SAPI 4 の音声を自動ダウンロードしないようにすることをお勧めします。

SAPI 5 テキスト読み上げエンジンでは、SAPI 4 とは異なる標準セットを使用して、音声にマークアップで注釈を付けます。たとえば、音声のピッチやレートを変更します。 SAPI 4 では、/pit=170/ などの "スラッシュ" コマンドを使用します。 SAPI 5 では、&lt;PITCH MIDDLE="5"/&gt;などの XML タグを使用します。 Vista では、エージェントは Speak メソッド文字列 "スラッシュ" コマンドの両方の種類の注釈を受け入れますが、SAPI 5 エンジンでは無視され、XML タグは SAPI 4 エンジンでは無視されます。 スラッシュ タグと同様に、SAPI 5 XML タグのサポートはベンダーによって異なり、一部のベンダーは追加のタグをサポートする場合があります。 SAPI 5 XML タグの詳細については、SAPI 5 の仕様を参照してください。

エージェントに複数の言語のサポートが含まれるようになりました。 エージェントによって使用される言語は、オペレーティング システムに登録されているユーザーの現在の言語であると常に想定されます。 Agent オブジェクトの LanguageID プロパティは引き続き書き込み可能ですが、その値は Vista 上のエージェントによって無視されます。 たとえば、ユーザーの言語が米国英語 (&H0409) に設定されていて、LanguageID をフランス語 (&H040C) に設定するプログラムを使用している場合、音声ヒントテキストと[高度な文字オプション]ダイアログは引き続き英語で表示されます。