---
layout: Conceptual
title: Activate メソッド - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/activate-method
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Activate メソッド
document_id: 4816c39d-8c53-7a32-6cdf-2d0541e68be1
document_version_independent_id: c708b108-8828-58ce-2911-c175fc630281
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/activate-method.md
locale: ja-jp
ms.assetid: 8111139d-1453-416e-8f08-38c06669ff4d
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/activate-method.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:36:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/activate-method.md
page_type: conceptual
toc_rel: toc.json
word_count: 1289
asset_id: lwef/activate-method
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 5560df44-15eb-4998-b806-8f4d1fb52a45
---

# Activate メソッド - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

- [**説明**](../wmformat/description)
    - アクティブなクライアントまたは文字を設定します。
- **構文**
    - *agent*\*\*。文字 ("***CharacterID***")。Activate\*\* [*State*]

| パーツ | 説明 |
| --- | --- |
| *状態* | 省略可能。 このパラメーターには、次の値を指定できます。0 アクティブなクライアントではありません。 1 アクティブなクライアント。  2 (既定値) 一番上の文字。 |

## 解説

複数の文字が表示されている場合、一度に 1 つの文字のみが音声入力を受け取ります。 同様に、複数のクライアント アプリケーションが同じ文字を共有する場合、1 つのクライアントのみがマウス入力を受け取ります (たとえば、Microsoft Agent コントロールのクリックイベントやドラッグ イベント)。 マウスと音声の入力を受け取る文字セットは最上位の文字であり、入力を受け取るクライアントはその文字のアクティブなクライアントです。 (一番上の文字のウィンドウは、文字ウィンドウの z オーダーの上部にも表示されます)。通常、ユーザーは文字を明示的に選択することで、最上位の文字を決定します。 ただし、一番上のアクティブ化は、文字が表示または非表示の場合にも変更されます (文字はそれぞれ最上位になるか、または一番上に表示されなくなります)。

また、このメソッドを使用して、アプリケーション自体がアクティブになったときなど、文字に対する入力をクライアントが受け取るタイミングを明示的に管理することもできます。 たとえば、 *State* を 2 に設定すると、文字が最上位になり、クライアントは、ユーザーと文字との対話から生成されたすべてのマウスおよび音声入力イベントを受け取ります。 そのため、クライアントは文字の入力アクティブなクライアントにもなります。

ただし、 *State* を 1 に設定することで、文字を最上位にすることなく、文字のアクティブなクライアントに自分自身を設定することもできます。 これにより、クライアントは、文字が最上位になったときに、その文字に送られた入力を受け取ることができます。 同様に、文字が最上位になったときに 、 *State* を 0 に設定することで、クライアントをアクティブなクライアント (入力を受け取らない) に設定できます。

[**Show**](/ja-jp/previous-versions/visualstudio/foxpro/d79z7xxa%28v=vs.71%29) メソッドの直後にこのメソッドを呼び出さないようにします。 **[表示]** を選択すると、入力アクティブなクライアントが自動的に設定されます。 文字が非表示の場合、**Show** メソッドが完了する前に処理されると[**、Activate**](/ja-jp/previous-versions/visualstudio/foxpro/01ayxx68%28v=vs.71%29) 呼び出しが失敗する可能性があります。

このメソッドを関数に呼び出すと、メソッドが成功したかどうかを示すブール値が返されます。 指定した文字が非表示のときに *State* パラメーターを 2 に設定してこのメソッドを呼び出そうとすると、失敗します。 同様に、 *State* を 0 に設定し、アプリケーションが唯一のクライアントである場合、文字は常に最上位のクライアントを持つ必要があるため、この呼び出しは失敗します。

```
   Dim Genie as Object

   Sub FormLoad()

   Agent1.Characters.Load "Genie", "Genie.acs"

   Set Genie = Agent1.Characters ("Genie")

   If (Genie. Activate = True) Then
      'I'm active

   Else
      'I must be hidden or something

   End If 
   
   End Sub
```

Note

*State* を 1 に設定してこのメソッドを呼び出しても、他の文字が読み込まれていないか、アプリケーションが既に入力アクティブでない限り、通常 [**ActivateInput**](https://www.bing.com/search?q=**ActivateInput**) イベントは生成されません。