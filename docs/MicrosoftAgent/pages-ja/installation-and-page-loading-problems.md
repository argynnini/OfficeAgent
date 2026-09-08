---
layout: Conceptual
title: インストールとページの読み込みに関する問題 - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/installation-and-page-loading-problems
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: インストールとページの読み込みに関する問題
document_id: 0a5159be-7dc6-fbf7-85eb-196755333ea0
document_version_independent_id: dfe57f41-5f20-3d5f-93aa-214f67c2cd28
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: ca74834093fa2f82c608f87b28f030b2f88462b1
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/ca74834093fa2f82c608f87b28f030b2f88462b1/desktop-src/lwef/installation-and-page-loading-problems.md
locale: ja-jp
ms.assetid: 1611c3f1-0411-4631-a64c-e7637fc7edd9
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/installation-and-page-loading-problems.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:53:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2025-05-19T16:42:13.7639237Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/installation-and-page-loading-problems.md
page_type: conceptual
toc_rel: toc.json
word_count: 2135
asset_id: lwef/installation-and-page-loading-problems
item_type: Content
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/5287f575-02f0-405f-92b7-800456526b0c
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/06e86142-34c2-4b94-ab9c-9477c21f7152
platformId: b098a43f-bde9-cda5-d4ca-ed1e9b47e537
---

# インストールとページの読み込みに関する問題 - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

### Microsoft Windows NT に Microsoft Agent をインストールしようとすると、管理者である必要があることを示すメッセージが表示されます。

Microsoft エージェントはインストール時にシステム ディレクトリにファイルを書き込むため、インストールするには管理者特権 (ユーザーではない) が必要です。

### Microsoft エージェントをインストールしようとすると、プロセス (Regsvr32 /s ウィンドウ\msagent\AgentCtl.dll) のいずれかのエラーが表示されます。 このファイルの作成時にエラーが発生しました。 このファイルが見つかりません。 (注: エラー メッセージに記載されているディレクトリの場所は、Windows のインストール方法によって異なります)。必要な DLL MSVCRT.DLLが見つかりませんでした。 プロセス &lt;の作成中にエラーが発生しました。c:\windows\msagent\agentsvr.exe /regserver&gt;。 理由: このアプリケーションを実行するために必要なライブラリ ファイルの 1 つが見つかりません。 (注: エラー メッセージに記載されているディレクトリの場所は、Windows のインストール方法によって異なります)。

Microsoft エージェントをインストールするには、Regsvr32.exe、Msvcrt.dll (Microsoft C ランタイム ライブラリ)、および up-to-date OLE dll を適切にインストールする必要があります。 詳細については、 [DCOM の更新に](/ja-jp/openspecs/windows_protocols/ms-dcom/4a893f3d-bd29-48cd-9f43-d9777a4415b0)関する記事を参照してください。 すべての正しいシステム ファイルが存在することを確認する最善の方法は、Microsoft Internet Explorer 4.0 [以降](https://www.microsoft.com/ie/download) インストールすることです。

### Microsoft エージェント用にスクリプト化されたページを読み込もうとすると、"VBScript ランタイム エラー、オブジェクトが必要です" というスクリプト エラーが発生します。

次のいずれかの条件により、メッセージが表示されることがあります。

- ActiveX コントロールとプラグインを有効にするには、Microsoft Internet Explorer のセキュリティ オプションを設定する必要があります。ブラウザーのセキュリティ ページを確認します。 Microsoft Internet Explorer で、[表示] メニューを開き、[オプション] を選択し、[セキュリティ] タブをクリックして、[ActiveX コントロールと Plug-Ins を有効にする] チェック ボックスがオンになっていることを確認します。
- デュアルブート Windows 9x または Windows NT システムで実行していて、1 つのオペレーティング システムに Microsoft エージェントをインストールしたが、もう一方のオペレーティング システムからページにアクセスしようとしている。 オペレーティング システムはディレクトリとファイルを共有できますが、Microsoft エージェントで使用されるレジストリ情報は共有されないため、文字でスクリプト化された Web ページにアクセスするために使用するオペレーティング システムに Microsoft エージェントをインストールする必要があります。

### Microsoft エージェント用にスクリプト化されたページを読み込もうとすると、何も起こりません。

これは、次のいずれかの条件が存在する場合に発生する可能性があります。

- ブラウザーのセキュリティ オプションを確認します。 ActiveX スクリプトの読み込みと ActiveX コントロールの再生を有効にするには、ブラウザーを設定する必要があります。
- Microsoft エージェントでスクリプト化されたページにアクセスし、Microsoft Internet Explorer を使用している場合は、バージョン 3.02 以降が必要です (最新バージョンの Internet Explorer を [https://www.microsoft.com/windows/ie/](https://www.microsoft.com/windows/internet-explorer/default.aspx)https://www.microsoft.com/windows/ie/でダウンロードしてください)。 Microsoft Internet Explorer で、[表示] メニューを開き、[オプション] を選択し、[セキュリティ] タブをクリックして、すべての [アクティブなコンテンツ] チェック ボックスをオンにします。
- ページ上の Java アプレットでも、このエラーが発生する可能性があります。 Java アプレットと同じページで Microsoft エージェントを実行するには、バージョン 2.0 の Microsoft 仮想マシン (VM) が必要です。 詳細については、[プログラミング/スクリプトに関する FAQ](programming-scripting-faq)を参照してください。

### Microsoft エージェント用にスクリプト化されたページを読み込もうとすると、"Microsoft エージェントを初期化できません" というメッセージが表示されます。

これは通常、Microsoft エージェントまたはそのページで使用されるその他のコントロールがインストールされていない場合に発生し、コントロールのインストールを求められたら [いいえ] を選択します。 ページを更新してみてください。ただし、ページが機能するのは、必要なすべてのコンポーネントをインストールした場合のみです。

### Microsoft エージェント用にスクリプト化されたページを読み込もうとすると、"コンポーネントは発行元によってデジタル署名されましたが、署名がコンポーネントと一致しません" というメッセージが表示されます。 このコンポーネントが破損または改ざんされた可能性がありますか? 続行しますか?

これは、Microsoft Internet Explorer 3.02 に Microsoft エージェントをインストールしようとすると表示されることがあります。 インストールを続行するか、ブラウザーを Internet Explorer 4.0 以降に更新できます。

### Netscape Navigator (または他のインターネット ブラウザー) を使用して Microsoft Agent 用にスクリプト化されたページを読み込もうとすると、エラーが発生します。

Microsoft エージェントは、ActiveX インターフェイスを使用して実装されます。 これは、ページ上のスクリプトによる ActiveX オブジェクトの埋め込みをサポートするブラウザー (Microsoft Internet Explorer など) でのみ使用でき、Microsoft Windows 95、Windows 98、および Windows NT 4.0 (またはそれ以降) を実行しているシステムでのみ使用できます。 Microsoft Internet Explorer ([https://www.microsoft.com/windows/ie/](https://www.microsoft.com/windows/internet-explorer/default.aspx)) を使用していない場合は、ブラウザー ベンダーに問い合わせて ActiveX サポートの詳細を確認してください。