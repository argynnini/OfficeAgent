---
layout: Conceptual
title: Style プロパティ - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/style-property
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Style プロパティ
document_id: f33755a3-06bf-6758-9048-6b89e3c35509
document_version_independent_id: 70e3d192-22bd-4621-900b-3112283675f1
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/style-property.md
locale: ja-jp
ms.assetid: f01d7d51-8a16-4265-b9b7-93b64f4984e3
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/style-property.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:01:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/style-property.md
page_type: conceptual
toc_rel: toc.json
word_count: 1486
asset_id: lwef/style-property
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 22eb21d5-3313-7630-161b-9ae9cdc8d8da
---

# Style プロパティ - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 文字のワード バルーン出力スタイルを設定または返します。
- **構文の**
    - \*agent.\***Characters("*CharacterID*")。Balloon.Style** [ = *Style*]

| 部分 | 形容 |
| --- | --- |
| *スタイルの* | バルーンの出力スタイルを表す整数。 スタイル設定はビットフィールドで、吹き出し (ビット 0)、サイズからテキスト (ビット 1)、自動非表示 (ビット 2)、自動ペース (ビット 3)、1 行あたりの文字数 (ビット 16 から 23)、行数 (ビット 24 から 31) に対応します。 |

## 備考

吹き出しのスタイル ビットが 1 に設定されている場合、ユーザーが Microsoft Agent プロパティ シートでこの設定をオーバーライドしない限り、[**Speak**](https://www.bing.com/search?q=**Speak**) または [**Think**](think-method) メソッドを使用すると、吹き出しが表示されます。 0 に設定すると、バルーンは表示されません。

サイズとテキストのスタイル のビットが 1 に設定されている場合、吹き出しの高さは、[**Speak**](https://www.bing.com/search?q=**Speak**) または [**Think**](think-method) ステートメントのテキストの現在のサイズに自動的に変更されます。 0 に設定すると、バルーンの高さは、[**NumberOfLines**](numberoflines-property) プロパティの設定に基づいています。 このスタイル ビットが 1 に設定されていて、**NumberOfLines** プロパティを設定しようとすると、エージェントでエラーが発生します。

自動非表示のスタイル ビットが 1 に設定されている場合、吹き出しという単語は、読み上げられた出力が完了すると自動的に非表示になります。 0 に設定すると、吹き出しは、次の [**読み上げ**](https://www.bing.com/search?q=**Speak**) または  呼び出し、文字が非表示、またはユーザーが文字をクリックまたはドラッグするまで表示されます。

自動ペース スタイル のビットが 1 に設定されている場合、バルーンという単語は、現在の出力レート (たとえば、一度に 1 単語) に基づいて出力のペースを設定します。 出力がバルーンのサイズを超えると、前のテキストが自動的にスクロールされます。 0 に設定すると、[**Speak**](https://www.bing.com/search?q=**Speak**) または [**Think**](think-method) ステートメントに含まれるすべてのテキストが一度に表示されます。

下位 4 ビットの値のみを取得するには、**し、255 で スタイルによって返される値を** します。 ビット値を設定するには、**または設定するビットの値で返される値を** します。 ビットをオフにするには、**し、返された値をビットの補数で** します。

```
   Const BalloonOn = 1

   ' Turn the word balloon off
   Genie.Balloon.Style = Genie.Balloon.Style And (Not BalloonOn)
   Genie.Speak "No balloon"

   ' Turn the word balloon on
   Genie.Balloon.Style = Genie.Balloon.Style Or BalloonOn
   Genie.Speak "Balloon"
```

**Style** プロパティは、上の単語の下位バイトの 1 行あたりの文字数と、上の単語の上位バイトの行数も返します。 これは、[**CharsPerLine**](charsperline-property) と NumberOfLines**[プロパティ](numberoflines-property)**使用して読みやすくすることができますが、**Style** プロパティを使用して、これらの値を設定することもできます。

たとえば、行数を変更するには、**Style** プロパティの既存の値に追加された新しい値を 2^24 の積として設定する前に、論理 **AND** 演算でビット 24 から 31 をクリアします。

```
   ' Set the number of lines to 4
   Genie.Balloon.Style = (Genie.Balloon.Style <b>AND</b> &amp;H00FFFFFF) + (4*(2^24))
```

1 行あたりの文字数を設定するには、論理 **AND** 演算を使用してビット 16 から 23 をクリアしてから、新しい値の積として新しい値を 2^16 に設定し、Style プロパティの既存の値に追加します。

```
   ' Set the number of characters per line to 16
   Genie.Balloon.Style = (Genie.Balloon.Style AND &amp;HFF00FFFF) + (16*(2^16))
```

**スタイル** プロパティは、ユーザーが Microsoft Agent プロパティ シートを使用して吹き出しの表示を無効にしている場合でも設定できます。 ただし、行数の値は 1 ~ 128 で、1 行あたりの文字数は 8 から 255 の範囲にする必要があります。 **Style** プロパティに無効な値を指定すると、エージェントによってエラーが発生します。

このプロパティは、クライアント アプリケーションによる文字の使用にのみ適用されます。この設定は、文字の他のクライアントやクライアント アプリケーションの他の文字には影響しません。

これらのスタイル ビットの既定値は、Microsoft エージェント文字エディターで文字をコンパイルするときの設定に基づいています。