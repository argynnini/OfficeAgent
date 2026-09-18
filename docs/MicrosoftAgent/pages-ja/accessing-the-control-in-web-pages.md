---
layout: Conceptual
title: Web ページ内のコントロールへのアクセス - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/accessing-the-control-in-web-pages
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Web ページ内のコントロールへのアクセス
document_id: 6583c93f-7040-dbd3-0899-e5cd70154699
document_version_independent_id: bf084828-cb05-8efb-29be-59b67169c269
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/accessing-the-control-in-web-pages.md
locale: ja-jp
ms.assetid: 0c799c60-c81a-44ea-a9e0-1a385208528f
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/accessing-the-control-in-web-pages.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:36:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-09-22T17:57:32.8103094Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/accessing-the-control-in-web-pages.md
page_type: conceptual
toc_rel: toc.json
word_count: 1946
asset_id: lwef/accessing-the-control-in-web-pages
item_type: Content
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/c6f99e62-1cf6-4b71-af9b-649b05f80cce
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/3f56b378-07a9-4fa1-afe8-9889fdc77628
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 05a850a0-f2ec-b8b8-a78e-4eafa6731966
---

# Web ページ内のコントロールへのアクセス - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

Web ページから Microsoft エージェント サービスにアクセスするには、ページの `<HEAD>` または `<BODY>` 要素内の HTML `<OBJECT>` タグを使用して、コントロールの Microsoft CLSID (クラス識別子) を指定します。 さらに、CODEBASE パラメーターを使用して、Microsoft エージェントのインストール ファイルの場所とそのバージョン番号を指定します。

Microsoft Internet Explorer (バージョン 3.02 以降) がシステムにインストールされていても、Microsoft エージェントがまだインストールされておらず、ユーザーがエージェント CLSID で &lt;OBJECT&gt; タグを持つ Web ページにアクセスすると、ブラウザーは自動的に Microsoft Web サイトからエージェントのダウンロードを試みます。 その後、ユーザーはインストールを続行するかどうかを確認するメッセージが表示されます。 その他のブラウザーについては、サプライヤーに問い合わせて、ActiveX コントロールのサポートまたはサード パーティのサポートに関する情報を入手してください。

次の例は、CODEBASE パラメーターを使用して、Microsoft エージェントの英語バージョン 2.0 を自動ダウンロードする方法を示しています。

```syntax
<OBJECT
classid="clsid: D45FD31B-5C6E-11D1-9EC1-00C04FD7081F"
CODEBASE = "#VERSION=2,0,0,0"
 id=Agent
>
</OBJECT>
```

エージェントは、独自の HTTP サーバーから、またはアプリケーションのインストール プロセスの一部としてインストールすることもできます。 独自の HTTP サーバーからのインストールをサポートするには、Microsoft エージェントのセルフインストール キャビネットを投稿する必要があります。EXE ファイルを作成し、その URL を CODEBASE タグに指定します。

```syntax
<OBJECT
classid="clsid: D45FD31B-5C6E-11D1-9EC1-00C04FD7081F"
CODEBASE = "https://your server/msagent.exe#VERSION=2,0,0,0"
 id=Agent
>
</OBJECT>
```

Web ページからの Microsoft エージェント言語コンポーネントの自動ダウンロードをサポートするには、エージェント コントロール オブジェクト タグの前に言語コンポーネントの Object タグをページに含めます。

```syntax
<OBJECT width=0 height=0
CLASSID="CLSID: C348XXXX-A7F8-11D1-AA75-00C04FA34D72"
CODEBASE = "#VERSION=2,0,0,0">
</OBJECT>
```

ここで、XXXX は言語 ID に置き換えられます。 現在サポートされている言語については、Microsoft エージェントの Web サイトを参照してください。

- 言語コンポーネントの `<OBJECT>` タグは、Microsoft Agent コア コンポーネントの &lt;OBJECT&gt; タグの前に置く必要があります。
- 同じクライアントに複数の言語をインストールできます。
- 文字の [**LanguageID**](https://www.bing.com/search?q=**LanguageID**) を設定する前に、[**userLanguage**](https://www.bing.com/search?q=**userLanguage**) プロパティで使用できるブラウザーのロケールが、設定されている言語と一致することをスクリプトで確認することをお勧めします。

他の言語バージョンのエージェントをサポートするには、言語コンポーネントを指定する別のオブジェクト タグを使用します。 ただし、複数の言語を同時にインストールしようとすると、ユーザーが再起動する必要があることに注意してください。 エージェント言語コンポーネントは、エージェントのコア コンポーネントと同じ手順を使用して、エージェント Web サイトから取得できます。 言語コンポーネントの配布ライセンスについては、標準のエージェント配布ライセンスを参照してください。文字の使用を開始するには、[**Load**](/ja-jp/previous-versions/visualstudio/foxpro/h1tx7zt1%28v=vs.71%29) メソッドを使用して文字を読み込む必要があります。 文字は、ユーザーのローカル ストレージまたは HTTP サーバーから読み込むことができます。 文字を読み込む構文の詳細については、「**Load** メソッド」を参照してください。 文字が正常に読み込まれたら、エージェント コントロールによって公開されるメソッド、プロパティ、およびイベントを使用して、文字をプログラムできます。 また、プログラミング言語とブラウザーによって公開されるメソッド、プロパティ、およびイベントを使用して、文字をプログラミングすることもできます。たとえば、ボタン クリックに対する反応をプログラムする場合などです。 ブラウザーのドキュメントを参照して、スクリプト モデルで公開されている機能を確認してください。 Microsoft Internet Explorer については、ActiveX SDK で使用できるスクリプト オブジェクト モデルを参照してください。

エージェントのサービスは、接続を持つクライアント アプリケーションが少なくとも 1 つ存在する場合にのみ読み込まれたままになります。 つまり、ユーザーがエージェントが有効な Web ページ間を移動すると、エージェントはシャットダウンされ、読み込んだ文字はすべて消えます。 ページ間でエージェントを実行し続ける (文字を表示したままにする) には、ページ変更の間に読み込まれたままの別のクライアントを作成します。 たとえば、HTML フレームセットを作成し、親フレームで Agent の &lt;OBJECT&gt; タグを宣言できます。 その後、子フレームに読み込むページをスクリプト化して、親のスクリプトを呼び出すことができます。 または、子フレームに読み込む各ページに &lt;OBJECT&gt; タグを含めることもできます。 この場合は、各ページが独自のクライアントになることに注意してください。 [**Activate**](/ja-jp/previous-versions/visualstudio/foxpro/01ayxx68%28v=vs.71%29) メソッドを使用して、ユーザーが親ページまたは子ページを操作するときに制御できるクライアントを設定することが必要になる場合があります。