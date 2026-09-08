---
layout: Conceptual
title: IAgentBalloonEx GetStyle - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentballoonex--getstyle
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentBalloonEx GetStyle
document_id: 091ece34-ee1d-bba1-affd-61698524f5ae
document_version_independent_id: 5998813b-23fc-aa00-681b-5e621a5f77f6
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentballoonex--getstyle.md
locale: ja-jp
ms.assetid: 7c6a7260-073b-4535-b8e7-a8cae9aae9ef
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentballoonex--getstyle.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:45:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-07-03T23:50:19.3460266Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentballoonex--getstyle.md
page_type: conceptual
toc_rel: toc.json
word_count: 944
asset_id: lwef/iagentballoonex--getstyle
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: d38d5ce0-e791-2af0-35ac-f84e3a03c6d3
---

# IAgentBalloonEx GetStyle - Win32 apps | Microsoft Learn

[Microsoft Agent は Windows 7 の時点で非推奨となり、後続のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT GetStyle(
   long * plStyle,  // address of style settings
);
```

キャラクターの吹き出しスタイル設定を取得します。

- 操作が成功したことを示す S\_OK を返します。

- *plStyle*
    - 吹き出しのスタイル設定。次のいずれかの値を組み合わせて使用できます。

| 値 | 説明 |
| --- | --- |
| **const unsigned short** **BALLOON\_STYLE\_BALLOONON = 0x00000001;** | 吹き出しは出力に対してサポートされています。 |
| **const unsigned short** **BALLOON\_STYLE \_SIZETOTEXT = 0x0000002;** | 吹き出しの高さはテキスト出力に合わせてサイズが設定されます。 |
| **const unsigned short** **BALLOON\_STYLE \_AUTOHIDE = 0x00000004;** | 吹き出しは自動的に非表示になります。 |
| **const unsigned short** **BALLOON\_STYLE \_AUTOPACE = 0x00000008;** | テキスト出力は出力レートに基づいてペースが設定されます。 |

**BalloonOn** スタイル ビットが設定されている場合、ユーザーが Microsoft Agent プロパティ シートを介して表示をオーバーライドしない限り、[**Speak**](speak-method) または [**Think**](think-method) メソッドを使用すると吹き出しが表示されます。 設定しない場合、吹き出しは表示されません。

**SizeToText** スタイル ビットを設定すると、吹き出しの高さが、[**Speak**](speak-method) または [**Think**](think-method) メソッドで指定されたテキストの現在のサイズに自動的に変更されます。 設定しない場合、吹き出しの高さは吹き出しの行数プロパティの設定に基づいて決定されます。 このスタイル ビットは 1 に設定されており、[**IAgentBalloonEx::SetNumLines**](iagentballoonex--setnumlines) を使用しようとするとエラーが発生します。

**AutoHide** スタイル ビットを設定すると、短いタイムアウト後に吹き出しが自動的に非表示になります。設定されていない場合、新しい [**Speak**](speak-method) または [**Think**](think-method) 呼び出し、キャラクターの非表示、またはユーザーによるキャラクターのクリックまたはドラッグまで吹き出しが表示されます。

**AutoPace** スタイル ビットが設定されている場合、吹き出しでは、現在の出力レート (一度に 1 単語など) に基づくペースで出力が表示されます。 出力が吹き出しのサイズを超えると、それまでのテキストが自動的にスクロールされます。 設定しない場合、[**Speak**](speak-method) または [**Think**](think-method) ステートメントに含まれるすべてのテキストが一度に表示されます。

このプロパティは、クライアント アプリケーションによるキャラクターの使用にのみ適用されます。この設定は、キャラクターの他のクライアントやクライアント アプリケーションの他のキャラクターには影響しません。

これらのスタイル ビットのデフォルトは、Microsoft エージェント キャラクター エディターを使用してキャラクターをコンパイルするときの設定に基づいています。