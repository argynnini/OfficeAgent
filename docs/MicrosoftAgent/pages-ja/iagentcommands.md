---
layout: Conceptual
title: IAgentCommands - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcommands
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCommands
document_id: 47643ed3-299e-27f9-15cd-7b2af605cf52
document_version_independent_id: 62df9940-4539-2803-3ae3-a0b82f45c663
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcommands.md
locale: ja-jp
ms.assetid: a171a2f0-7c1c-440f-9b19-28447cc68b95
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommands.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:50:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcommands.md
page_type: conceptual
toc_rel: toc.json
word_count: 2556
asset_id: lwef/iagentcommands
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 7706c110-0c14-6a0c-fce1-ad34836fe6a5
---

# IAgentCommands - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

Microsoft エージェント サーバーは、ユーザーが現在使用できるコマンドの一覧を保持します。 この一覧には、非表示や Microsoft エージェントのプロパティなどの一般的な操作用にサーバーが定義するコマンド、使用可能な (ただし、非入力アクティブな) クライアントの一覧、現在のアクティブなクライアントによって定義されているコマンドが含まれます。 最初の 2 つのコマンド セットはグローバル コマンドです。つまり、入力/アクティブなクライアントに関係なく、いつでも使用できます。 クライアント定義コマンドは、そのクライアントが入力アクティブである場合にのみ使用できます。

**IAgentCommands**の IAgentCharacter**[インターフェイス](https://www.bing.com/search?q=**IAgentCharacter**)**クエリを実行して、**IAgentCommands** インターフェイスを取得します。 各 Microsoft エージェント クライアント アプリケーションは、[**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションと呼ばれるコマンドのコレクションを定義できます。 [**コマンド**](/ja-jp/windows/desktop/lwef/the-command-object) をコレクションに追加するには、[**Add**](add-method) または [**Insert**](insert-method) メソッドを使用します。 IAgentCommand**[メソッド](iagentcommand)**使用して **コマンドの** プロパティを指定できますが、最適なコード パフォーマンスを得るための **コマンド**のプロパティはすべて、[**IAgentCommands::Add**](iagentcommands--add) メソッドまたは [**IAgentCommands::**](iagentcommands--insert) Insert **Command**のプロパティを最初に設定するときに指定します。 **IAgentCommand** メソッドを使用して、プロパティの設定を照会または変更できます。

[**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクション内の各 [**コマンド**](/ja-jp/windows/desktop/lwef/the-command-object) について、そのコマンドがキャラクターのポップアップ メニュー、音声コマンド ウィンドウ、両方に表示されるか、どちらに表示されるかを決定できます。 たとえば、文字のポップアップ メニューにコマンドを表示する場合は、コマンドの [**Caption**](caption-property) と visible**[プロパティ](visible-property)**設定します。 **音声コマンド ウィンドウの**にコマンドを表示するには、コマンドの **Caption** プロパティと [**Voice**](voice-property) プロパティを設定します。

ユーザーは、クライアント アプリケーションが入力アクティブであり、文字が表示されている場合にのみ、Commands コレクション内の個々のコマンドにアクセスできます。 そのため、通常は、[**Commands**](caption-property)、[**VoiceCaption**](voicecaption-property)、および [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクション オブジェクトの voice**[プロパティとコレクション内のコマンドの](voice-property)**を設定する必要があります。これは、文字のポップアップ メニューと音声コマンド ウィンドウに **Commands** コレクションのエントリが配置されるためです。 ユーザーが **Commands** エントリを選択してクライアントに切り替えると、サーバーは自動的にクライアント入力をアクティブにし、[**IAgentNotifySink::ActivateInputState**](https://www.bing.com/search?q=**IAgentNotifySink::ActivateInputState**) を使用してクライアント アプリケーションに通知し、そのコレクション内の **Commands** を使用できるようにします。 また、サーバーは、**IAgentNotifySink::ActivateInputState** イベントを使用して、入力がアクティブでなくなったことをクライアントに通知します。 これにより、サーバーは、現在の入力/アクティブなクライアントのコンテキストに適用される **コマンド** のみを表示して受け入れることが可能になります。 また、[**コマンド**](/ja-jp/windows/desktop/lwef/the-command-object)-name のクライアント間の競合を回避するためにも機能します。

クライアントは、[**IAgentCharacter::Activate**](iagentcharacter--activate) メソッドを使用して、自身を入力/アクティブ クライアントにすることを明示的に要求することもできます。 このメソッドでは、アプリケーションを入力/アクティブ クライアントにしない設定もサポートしています。 このメソッドは、文字を別のアプリケーションと共有する場合に使用し、アプリケーション ウィンドウがフォーカスを取得したときに入力アクティブに設定し、フォーカスが失われるときに入力/アクティブにしないように設定できます。

同様に、[**IAgentCharacter::Activate**](iagentcharacter--activate) を使用して、アプリケーションを文字のアクティブなクライアントに設定 (または設定しない) できます。 アクティブなクライアントは、その文字が最上位の文字である場合に入力を受け取るクライアントです。 この状態が変わると、サーバーは IAgentNotifySinkEx::ActiveClientChange**[イベント](iagentnotifysinkex--activeclientchange)**アプリケーションに通知します。

文字のポップアップ メニューが表示されると、[**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションのプロパティに対する変更、またはそのコレクション内のコマンドは、ユーザーがメニューを再表示するまで表示されません。 ただし、音声コマンド ウィンドウを開くと、変更が発生したときに表示されます。

**IAgentCommands** は、アプリケーションが [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションのプロパティを追加、削除、設定、およびクエリできるようにするインターフェイスを定義します。 これらの関数は、[**IAgentCommandsEx**](iagentcommandsex)からも使用できます。

[**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションは、ポップアップ メニューと文字の [音声コマンド] ウィンドウの両方でコマンドとして表示できます。 **Commands** コレクションを表示するには、その [**Caption**](caption-property) プロパティを設定する必要があります。 次の表は、**Commands** コレクションのプロパティがプレゼンテーションにどのように影響するかをまとめたものです。

| Caption プロパティ | Voice-Caption プロパティ | Voice プロパティ | Visible プロパティ | キャラクターのポップアップメニューに表示される | [音声コマンド] ウィンドウに表示される |
| --- | --- | --- | --- | --- | --- |
| はい | はい | はい | 真 | はい([**Caption**](caption-property) を使用) | はい([**VoiceCaption**](voicecaption-property) を使用) |
| はい | はい | No¹ | 真 | はい([**Caption**](caption-property) を使用) | いいえ |
| はい | はい | はい | 偽 | いいえ | はい([**VoiceCaption**](voicecaption-property) を使用) |
| はい | はい | No¹ | 偽 | いいえ | いいえ |
| No¹ | はい | はい | 真 | いいえ | はい([**VoiceCaption**](voicecaption-property) を使用) |
| No¹ | はい | はい | 偽 | いいえ | はい([**VoiceCaption**](voicecaption-property) を使用) |
| No¹ | はい | No¹ | 真 | いいえ | いいえ |
| No¹ | はい | No¹ | 偽 | いいえ | いいえ |
| はい | No¹ | はい | 真 | はい([**Caption**](caption-property) を使用) | はい([**Caption**](caption-property) を使用) |
| はい | No¹ | No¹ | 真 | はい | いいえ |
| はい | No¹ | はい | 偽 | いいえ | はい([**Caption**](caption-property) を使用) |
| はい | No¹ | No¹ | 偽 | いいえ | いいえ |
| No¹ | No¹ | はい | 真 | いいえ | No² |
| No¹ | No¹ | はい | 偽 | いいえ | No² |
| No¹ | No¹ | No¹ | 真 | いいえ | いいえ |
| No¹ | No¹ | No¹ | 偽 | いいえ | いいえ |

¹ プロパティ設定が null の場合。 一部のプログラミング言語では、空の文字列が null 文字列と同じとは解釈されない場合があります。

²コマンドは引き続き音声でアクセスできます。

Vtable Order **のメソッドを** する

| IAgentCommands メソッド | 形容 |
| --- | --- |
| GetCommand**[を](iagentcommands--getcommand)**する | [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションから [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトを取得します。 |
| GetCount**[を](iagentcommands--getcount)**する | [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクション内の [**Commands**](/ja-jp/windows/desktop/lwef/the-command-object) の数の値を返します。 |
| SetCaption**[の](iagentcommands--setcaption)** | [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションの [**Caption**](caption-property) プロパティの値を設定します。 |
| GetCaption**[を](iagentcommands--getcaption)**する | [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションの [**Caption**](caption-property) プロパティの値を返します。 |
| SetVoice**[の](iagentcommands--setvoice)** | [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションの [**Voice**](voice-property) プロパティの値を設定します。 |
| [**GetVoice**](iagentcommands--getvoice) | [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションの [**Voice**](voice-property) プロパティの値を返します。 |
| SetVisible**[の](iagentcommands--setvisible)** | [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションの [**Visible**](visible-property) プロパティの値を設定します。 |
| GetVisible**[の](iagentcommands--getvisible)** | [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションの [**Visible**](visible-property) プロパティの値を返します。 |
| の追加 | [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトを [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションに追加します。 |
| [**挿入**](iagentcommands--insert) | [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションに [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトを挿入します。 |
| [**削除**](iagentcommands--remove) | [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクション内の [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトを削除します。 |
| [**RemoveAll**](iagentcommands--removeall) | [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションからすべての [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトを削除します。 |