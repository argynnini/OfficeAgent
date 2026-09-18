---
layout: Conceptual
title: Load メソッド - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/load-method
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Load メソッド
document_id: 92ed1656-a7dc-1bc5-031f-89535896ce63
document_version_independent_id: fa6eb514-b855-bda7-eedf-fe572af1525f
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/load-method.md
locale: ja-jp
ms.assetid: 72a37471-f69b-49a5-a6eb-d65bff970c0f
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/load-method.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:55:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/load-method.md
page_type: conceptual
toc_rel: toc.json
word_count: 1531
asset_id: lwef/load-method
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: f318b588-f1a6-4820-3639-e2930ac70751
---

# Load メソッド - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - [**Characters**](/ja-jp/windows/desktop/lwef/the-characters-object) コレクションに文字を読み込みます。
- **構文の**
    - エージェント \*\* です。Characters.Load "***CharacterID***",\*\* *Provider*

| 部分 | 形容 |
| --- | --- |
| CharacterID *の* | 必須。 読み込む文字データを参照するために使用する文字列値。 |
| *プロバイダー* | 必須。 次のいずれかである必要があるバリアント データ型: **Filespec** 指定した文字の定義ファイルのローカル ファイルの場所。 **URL** 文字の定義ファイルの HTTP アドレス。 |

## 備考

相対パス (コロンまたは先頭のスラッシュ文字を含まないパス) を指定することで、Agent サブディレクトリから文字を読み込むことができます。 これにより、(ローカライズされた Windows\msagent ディレクトリにある) エージェントの文字ディレクトリでパスのプレフィックスが付けられます。 たとえば、次のように指定すると、エージェントの Chars ディレクトリから Genie.acs が読み込まれます。

```
   Agent.Character.Load "genie", "genie.acs"
```

エージェントの Chars ディレクトリで独自のディレクトリを指定することもできます。

```
   Agent.Character.Load "genie", "MyCharacters\genie.acs"
```

**Load** メソッドの 2 番目のパラメーターとしてパスを含めずに、現在のユーザーの既定の文字として現在設定されている文字を読み込むことができます。

```
   Agent.Character.Load "character"
```

コントロールの 1 つのインスタンスから同じ文字 (同じ GUID を持つ文字) を複数回読み込むことはできません。 同様に、既定の文字は他の文字と同じである可能性があるため、コントロールの 1 つのインスタンスから既定の文字とその他の文字を同時に読み込むことはできません。 これを行おうとすると、サーバーでエラーが発生します。 ただし、エージェント コントロールの別のインスタンスを作成し、同じ文字を読み込むことができます。

Microsoft エージェント データ プロバイダーは、単一の構造化ファイル (.ACS) と文字データとアニメーション データを一緒に使用するか、個別の文字データ (.ACF) とアニメーション (.ACA) ファイル。 単一の構造化を使用します。ローカル ディスクまたはネットワークに格納され、従来のファイル プロトコル (UNC パス名など) を使用してアクセスされる文字を読み込む ACS ファイル。 別の .ACF および .HTTP プロトコルを使用してアクセスされるリモート サイトからアニメーション ファイルを個別に読み込む場合は、ACA ファイル。

対して。**Load** メソッドを使用する ACS ファイルは、キャラクターのアニメーションにアクセスできます。 対して。ACF ファイルでは、[**Get**](get-method) メソッドを使用してアニメーション データを読み込むこともできます。 **Load** メソッドは、ダウンロードをサポートしていません。HTTP サイトからの ACS ファイル。

文字を読み込んでも、文字は自動的に表示されません。 最初に [**Show**](show-method) メソッドを使用して、文字を表示します。

**Load** メソッドを使用してローカル コンピューターに格納されている文字ファイルを読み込む場合、呼び出しは失敗します。たとえば、ファイルが見つからないため、エージェントはエラーを発生させます。 プログラミング言語のサポートを使用して、エラーをキャッチして処理するエラー処理ルーチンを提供できます。

```
   Sub Form_Load
      On Error GoTo ErrorHandler
      Agent1.Characters.Load "mychar", "genie.acs"
      ' Successful load
      . . .
      Exit Sub
      ErrorHandler:
      ' Unsuccessful load
      . . .
      Resume Next
   End Sub
```

また、RaiseRequestErrorsFalse **を**に設定し、オブジェクトを宣言し、**Load** 要求を割り当てることで、エラーを処理することもできます。 次に、[**Request**](/ja-jp/windows/desktop/lwef/the-request-object) オブジェクトの状態を確認するステートメントを使用して、**Load** 呼び出しに従います。

```
Dim LoadRequest as Object

   Sub Form_Load
      Agent1.RaiseRequestErrors = False
      Set LoadRequest = Agent1.Characters.Load _
         ("mychar", "c:\some directory\some character.acs")
      If LoadRequest.Status Not 0 Then
         ' Unsuccessful load
         . . .
         Exit Sub
      Else 
         ' Successful load
         . . .
   End Sub
```

ローカルではない文字を読み込む場合。たとえば、HTTP プロトコルを使用して、[**Request**](/ja-jp/windows/desktop/lwef/the-request-object) オブジェクトを **Load** メソッドに割り当てることで、**Load** エラーを確認することもできます。 ただし、文字を読み込むこのメソッドは非同期的に処理されるため、[**RequestComplete**](requestcomplete-event) イベントでその状態を確認します。 この手法では、**Load** メソッドが同期的に処理されるため、UNC プロトコルを使用した文字の読み込みは機能しません。