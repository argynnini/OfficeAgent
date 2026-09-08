---
layout: Conceptual
title: IAgentCharacter Activate - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcharacter--activate
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCharacter Activate
document_id: 0c27cebf-5152-9208-2483-f44a221f8137
document_version_independent_id: 5f6eb0b0-bc44-39e8-dc6c-ebb76878776f
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacter--activate.md
locale: ja-jp
ms.assetid: a81eb62d-709b-46b4-9ff2-c9017f7f853e
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacter--activate.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:46:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcharacter--activate.md
page_type: conceptual
toc_rel: toc.json
word_count: 1273
asset_id: lwef/iagentcharacter--activate
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: eb1a6bfe-9e6f-37c0-0ac4-7a359b921bf0
---

# IAgentCharacter Activate - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT Activate(
   short sState, // topmost character or client setting
);
```

クライアントがアクティブか、文字が一番上にあるかを設定します。

- 操作が成功したことを示すS\_OKを返します。
- 操作が成功しなかったS\_FALSEを返します。

- *sState*
    - このパラメーターには、次の値を指定できます。

| 価値 | 形容 |
| --- | --- |
| 0 | アクティブなクライアントではないとして設定します。 |
| 1 | アクティブなクライアントとして設定します。 |
| 2 | 一番上の文字を作成します。 |

複数の文字が表示されている場合は、一度に 1 つの文字のみが音声入力を受け取ります。 同様に、複数のクライアント アプリケーションが同じ文字を共有する場合、一度にマウス入力を受け取るクライアントは 1 つだけです (たとえば、Microsoft Agent コントロールのクリックまたはドラッグ イベント)。 マウスと音声の入力を受け取る文字セットは最上位の文字であり、入力を受け取るクライアントはキャラクターのアクティブなクライアントです。 (一番上の文字のウィンドウは、文字ウィンドウの z オーダーの上部にも表示されます)。通常、ユーザーは明示的に選択することで、最上位の文字を決定します。 ただし、一番上のアクティブ化は、文字が表示または非表示になるとも変わります (文字はそれぞれ一番上になるか、または一番上に表示されなくなります)。

また、このメソッドを使用して、アプリケーション自体がアクティブになったときなど、クライアントが文字に向けられた入力を受け取るタイミングを明示的に管理することもできます。 たとえば、State  を 2 に設定すると、その文字が最上位になり、クライアントは、ユーザーと文字の対話から生成されたすべてのマウス入力イベントと音声入力イベントを受け取ります。 そのため、クライアントは文字の入力アクティブ なクライアントにもなります。 ただし、State **を 1 に設定することで、文字を最上位にせずにアクティブなクライアント** 設定することもできます。 これにより、クライアントは、文字が最上位になったときに、その文字に向けられた入力を受け取ります。 同様に、state **を 0 に** 設定することで、文字が最上位になったときにクライアントをアクティブクライアントにしない (入力を受け取らない) ことができます。 [**IAgentCharacter::HasOtherClients**](iagentcharacter--hasotherclients)を使用して、文字に他の現在のクライアントがあるかどうかを確認できます。

[**Show**](iagentcharacter--show) メソッドの直後にこのメソッドを呼び出さないようにします。 **表示** は、入力/アクティブクライアントを自動的に設定します。 文字が非表示の場合、**Show** メソッドが完了する前に処理されると、**Activate** 呼び出しが失敗する可能性があります。

**State** パラメーターを 2 (指定した文字が非表示の場合) に設定してこのメソッドを呼び出そうとすると、失敗します。 同様に、**State** を 0 に設定し、アプリケーションが唯一のクライアントである場合、この呼び出しは失敗します。 文字には常に最上位のクライアントが必要です。

手記

**State** を 1 に設定してこのメソッドを呼び出しても、通常、他の文字が読み込まれていないか、アプリケーションが既に入力アクティブでない限り、[**AgentNotifySink::ActivateInputState**](https://www.bing.com/search?q=**AgentNotifySink::ActivateInputState**) イベントは生成されません。