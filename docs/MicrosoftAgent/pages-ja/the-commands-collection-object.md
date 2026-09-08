---
layout: Conceptual
title: Commands コレクション オブジェクト - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/the-commands-collection-object
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Commands コレクション オブジェクト
document_id: 2221bad4-b564-fdc7-7760-d4366aabe893
document_version_independent_id: f4a2b895-a8e9-3247-6523-d6a9bf0d8339
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/the-commands-collection-object.md
locale: ja-jp
ms.assetid: 8726ce04-77d3-4ae3-bd46-e75f42b36d6f
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/the-commands-collection-object.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:02:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/the-commands-collection-object.md
page_type: conceptual
toc_rel: toc.json
word_count: 1644
asset_id: lwef/the-commands-collection-object
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: b0a38f38-efc2-039c-eb09-e9e673cff850
---

# Commands コレクション オブジェクト - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

Microsoft エージェント サーバーは、ユーザーが現在使用できるコマンドの一覧を保持します。 この一覧には、サーバーが一般的な対話のために定義するコマンド ([音声コマンド ウィンドウの非表示] や [開く] など)、使用可能な (ただし入力がアクティブでない) クライアントの一覧、および現在アクティブなクライアントで定義されているコマンドが含まれます。 最初の 2 つのコマンド セットはグローバル コマンドです。つまり、入力アクティブなクライアントに関係なく、いつでも使用できます。 クライアント定義コマンドは、そのクライアントが入力アクティブで文字が表示されている場合にのみ使用できます。

各クライアント アプリケーションでは、 [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションと呼ばれるコマンドのコレクションを定義できます。 コレクションにコマンドを追加するには、 [**Add**](add-method) メソッドまたは [**Insert**](insert-method) メソッドを使用します。 コマンドのプロパティは個別のステートメントで指定できますが、最適なコード パフォーマンスを得るには、 **Add** または **Insert** メソッド ステートメントですべてのコマンドのプロパティを指定します。 コレクション内の各コマンドについて、ユーザーがコマンドにアクセスできるかどうかを、文字のポップアップ メニュー、音声コマンド ウィンドウ、両方、またはどちらにも表示するかどうかを決定できます。 たとえば、文字のポップアップ メニューにコマンドを表示する場合は、コマンドの [**Caption**](caption-property) プロパティと [**Visible**](visible-property) プロパティを設定します。 [音声コマンド] ウィンドウにコマンドを表示するには、コマンドの [**VoiceCaption**](voicecaption-property) プロパティと [**Voice**](voice-property) プロパティを設定します。

ユーザーは、クライアント アプリケーションが入力アクティブな場合にのみ、コレクション内の個々の[**comm コマンド**](/ja-jp/windows/desktop/lwef/the-commands-collection-object)と にアクセスできます。 したがって、文字を他のクライアント アプリケーションと共有する場合は、通常、**Commands** コレクション オブジェクトとコレクション内のコマンドの [**Caption**](caption-property)、[**VoiceCaption**](voicecaption-property)、[**Voice**](voice-property) の各プロパティを設定します。 これにより、 **Commands** コレクションのエントリが文字のポップアップ メニューと [音声コマンド] ウィンドウに配置されます。

ユーザーが [**\[コマンド\]**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) エントリを選択してクライアントに切り替えると、サーバーは自動的にクライアント入力をアクティブにし、 [**ActivateInput**](activateinput-event) イベントを使用してクライアント アプリケーションに通知し、コレクション内のコマンドを使用できるようにします。 また、サーバーは [**、DeActivateInput**](deactivateinput-event) イベントで入力がアクティブでなくなったことをクライアントに通知します。 これにより、サーバーは、現在の入力アクティブなクライアントのコンテキストに適用されるコマンドのみを表示して受け入れることが可能になります。 また、クライアント間のコマンド名の競合を回避するためにも機能します。

また、クライアントは [**Activate**](activate-method) メソッドを使用して、それ自体を入力アクティブなクライアントにすることを明示的に要求することもできます。 このメソッドでは、アプリケーションを入力アクティブ クライアントに設定することもサポートされています。 このメソッドは、別のアプリケーションと文字を共有する場合に使用し、アプリケーション ウィンドウがフォーカスを取得したときに入力アクティブに設定し、フォーカスが失われる場合は入力アクティブにしないように設定できます。

同様に、 [**Activate**](activate-method) メソッドを使用して、アプリケーションを文字のアクティブなクライアントに設定 (または設定しない) できます。 アクティブなクライアントは、その文字が一番上の文字のときに入力を受け取るクライアントです。 この状態が変わると、サーバーは [**ActiveClientChange**](activeclientchange-event) イベントを使用してアプリケーションに通知します。

文字のポップアップ メニューが表示されると、 [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションのプロパティまたはコレクション内のコマンドに対する変更は、ユーザーがメニューを再表示するまで表示されません。 ただし、[コマンド] ウィンドウには変更が発生すると表示されます。

- [Commands オブジェクト メソッド](commands-object-methods)
- [Commands オブジェクトのプロパティ](commands-object-properties)