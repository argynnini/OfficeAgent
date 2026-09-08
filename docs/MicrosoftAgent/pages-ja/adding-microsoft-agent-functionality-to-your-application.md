---
layout: Conceptual
title: アプリケーションへの Microsoft エージェント機能の追加 - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/adding-microsoft-agent-functionality-to-your-application
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: アプリケーションへの Microsoft エージェント機能の追加
document_id: bc896203-4357-adf6-75b5-ae55639a0ebc
document_version_independent_id: cf554d70-a01d-db20-7081-c6cd82e6bcb0
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/adding-microsoft-agent-functionality-to-your-application.md
locale: ja-jp
ms.assetid: 2b4816dd-11bf-4c17-873e-4bdbb7fa1ccf
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/adding-microsoft-agent-functionality-to-your-application.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:36:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/adding-microsoft-agent-functionality-to-your-application.md
page_type: conceptual
toc_rel: toc.json
word_count: 1450
asset_id: lwef/adding-microsoft-agent-functionality-to-your-application
item_type: Content
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
platformId: 768bd325-33a2-bc61-8e69-f7fdc50149a5
---

# アプリケーションへの Microsoft エージェント機能の追加 - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

Microsoft エージェントのサーバー インターフェイスにアクセスするには、エージェントがターゲット システムに既にインストールされている必要があります。 エージェントコンポーネントファイルのコピーや登録など、エージェントの自己インストール実行可能ファイルを使用する以外のインストールはサポートされていません。 これにより、一貫性のある完全なインストールが保証されます。 Microsoft エージェントの自己インストール ファイルは、Microsoft Windows 2000 以降のオペレーティング システムにはインストールされないことに注意してください。これらのバージョンのオペレーティング システムには、独自のバージョンのエージェントが既に含まれているためです。

以前の Microsoft Windows オペレーティング システムを使用してターゲット システムにエージェントを正常にインストールするには、ターゲット システムに最新バージョンの Microsoft Visual C++ ランタイム (Msvcrt.dll)、Microsoft 登録ツール (Regsvr32.dll)、および Microsoft COM dll があることを確認する必要もあります。 必要なコンポーネントがターゲット システム上にあることを確認する最も簡単な方法は、Microsoft Internet Explorer 3.02 以降のインストールを要求することです。 または、Microsoft Visual C++ の一部として使用できる最初の 2 つのコンポーネントをインストールすることもできます。 必要な COM dll は、Microsoft Web サイトで入手できる Microsoft DCOM 更新プログラムの一部としてインストールできます。 これらのコンポーネントの詳細情報とライセンス情報は、Microsoft Web サイトで確認できます。

エージェントの言語コンポーネントは、同じ方法でインストールできます。 同様に、この手法を使用して、Microsoft エージェント Web サイトから配布できる Microsoft 文字の ACS 形式をインストールできます。 文字ファイルは、Microsoft Agent \Chars サブディレクトリに自動的にインストールされます。

Microsoft エージェントのコンポーネントはオペレーティング システム コンポーネントとして設計されているため、エージェントをアンインストールできない場合があります。 同様に、エージェントが Windows オペレーティング システムの一部として既にインストールされている場合、エージェントのセルフインストール キャビネットがインストールされない場合があります。

インストールが完了したら、エージェントのインターフェイスを呼び出すには、サーバーのインスタンスを作成し、標準の COM 規則を使用してサーバーがサポートする特定のインターフェイスへのポインターを要求します。 特に、COM ライブラリには、オブジェクトのインスタンスを作成し、オブジェクトの要求されたインターフェイスへのポインターを返す、CoCreateInstanceAPI 関数が用意されています。 **CoCreateInstance** 呼び出し、または後続の [**QueryInterface**](/ja-jp/windows/desktop/api/unknwn/nf-unknwn-iunknown-queryinterface%28q%29)呼び出しで、[**IAgent**](iagent) または [**IAgentEx**](iagentex) インターフェイスへのポインターを要求してください。

次のコードは、C/C++ でこれを示しています。

```
hRes = CoCreateInstance(CLSID_AgentServer,
                     NULL,
                     CLSCTX_SERVER,
                     IID_IAgentEx,
                     (LPVOID *)&amp;pAgentEx);
```

Microsoft エージェント サーバーが実行されている場合、この関数はサーバーに接続します。それ以外の場合は、サーバーを起動します。

Microsoft エージェント サーバー インターフェイスには、多くの場合、"Ex" サフィックスを含む拡張インターフェイスが含まれています。 これらのインターフェイスは、Ex 以外の対応するインターフェイスから派生しているため、すべての機能が含まれます。 拡張機能のいずれかを使用する場合は、Ex インターフェイスを使用します。

BSTR へのポインターを受け取る関数は、[**SysAllocString**](/ja-jp/previous-versions/windows/desktop/api/oleauto/nf-oleauto-sysallocstring)を使用してメモリを割り当てます。 呼び出し元は、SysFreeString**[を使用して、このメモリ](/ja-jp/previous-versions/windows/desktop/api/oleauto/nf-oleauto-sysfreestring)**を解放する責任があります。