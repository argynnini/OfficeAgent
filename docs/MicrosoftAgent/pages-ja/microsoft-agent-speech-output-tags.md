---
layout: Conceptual
title: Microsoft Agent Speech 出力タグ - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/microsoft-agent-speech-output-tags
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Microsoft Agent Speech 出力タグ
document_id: 110c78e8-3977-f5cd-d792-c90cd9db8499
document_version_independent_id: 625e8ba1-4b05-2913-a492-a46465b45935
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/microsoft-agent-speech-output-tags.md
locale: ja-jp
ms.assetid: b7939974-bc54-4dd8-8e79-3ebd24e76215
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/microsoft-agent-speech-output-tags.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:55:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/microsoft-agent-speech-output-tags.md
page_type: conceptual
toc_rel: toc.json
word_count: 957
asset_id: lwef/microsoft-agent-speech-output-tags
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: e5c60d2f-cc87-db7f-4e14-c145962dd1bb
---

# Microsoft Agent Speech 出力タグ - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

Microsoft エージェント サービスでは、音声テキスト文字列に挿入された特殊なタグを使用した音声出力の変更がサポートされています。 これらのタグは、文字の出力式の特性を変更するのに役立ちます。

音声出力タグでは、次の構文規則が使用されます。

- すべてのタグの先頭と末尾は円記号 (\) です。
- 1 つの円記号は、タグ内では有効になっていません。 タグのテキスト パラメーターに円記号を含めるには、二重円記号 (\\) を使用します。
- タグでは大文字と小文字が区別されません。 たとえば、\pit\ は \PIT\ と同じです。
- タグは空白に依存します。 たとえば、\Rst\ は \Rst \と同じではありません。

別のタグで特に指定または変更されない限り、音声出力は、1 つの [**Speak**](speak-method) メソッドで指定されたテキスト内でタグによって設定された特性を保持します。 音声出力は、**Speak** メソッドが完了した後、ユーザー定義パラメーターによって自動的にリセットされます。

一部のタグには引用符で囲まれた文字列が含まれています。 Visual Basic Scripting Edition (VBScript) や Visual Basic などの一部のプログラミング言語では、タグのパラメーターを指定したり、文字列の一部として二重引用符を連結したりする必要がある場合があります。 後者は、次の Visual Basic の例に示されています。

```
Agent1.Characters("Genie").Speak "This is \map=" + chr(34) + "Spoken text" _
+ chr(34) + "=" + chr(34) + "Balloon text" + chr(34) + "\."
```

C、C++、Java™ プログラミングの場合は、円記号と二重引用符の前に円記号を付けます。 例えば：

```
BSTR bszSpeak = SysAllocString(L"This is \\map=\"Spoken text\"=\"Balloon text\"\\");

pCharacter->Speak(bszSpeak, ......);
```

2 バイト文字セット (DBCS) 文字をサポートする外国語の場合は、2 バイト文字を使用して文字列パラメーターを指定できます。 ただし、タグ自体を含め、タグの定義に使用される他のすべてのパラメーターと文字には、1 バイト文字を使用します。

次のタグがサポートされています。

- chr**[を](chr-tag)**する
- [**Ctx**](ctx-tag)
- Emp**[を](emp-tag)**する
- Lst**[を](lst-tag)**する
- マップ
- mrk**[を](mrk-tag)**する
- [**一時停止**](pau-tag)
- [**ピット**](pit-tag)
- [**Rst**](rst-tag)
- spd**[を](spd-tag)**する
- [**Vol**](vol-tag)

タグは、主にテキスト読み上げ (TTS) で生成された出力を調整するために設計されています。 サウンド ファイルベースの音声出力で使用できるのは、[**Mrk**](mrk-tag) タグと [**Map**](map-tag) タグだけです。

手記

Microsoft エージェントは、Microsoft Speech SDK に記載されているすべてのタグをサポートしているわけではありません。 パラメーターは、選択した TTS エンジンによっても異なる場合があります。 TTSModeID使用して、特定の TTS エンジンを設定できます。