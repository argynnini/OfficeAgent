---
layout: Conceptual
title: IAgentCommand - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcommand
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCommand
document_id: 7626a395-6fed-8702-a5e4-8cbc316e671c
document_version_independent_id: c2b46835-5d3f-6147-f347-d51755e9cafe
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcommand.md
locale: ja-jp
ms.assetid: 70873093-df71-4377-9c39-c7528400052f
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcommand.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:49:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcommand.md
page_type: conceptual
toc_rel: toc.json
word_count: 1787
asset_id: lwef/iagentcommand
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: afa6e40d-75ab-c233-8d4d-b30b2eedf568
---

# IAgentCommand - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

[**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトは、[**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクション内の項目です。 サーバーは、クライアント アプリケーションが入力アクティブになるコマンドへのユーザー アクセスを提供します。 **コマンド**を取得するには、IAgentCommands::GetCommand呼び出します。

**IAgentCommand** は、アプリケーションが、文字のポップアップ メニューと音声コマンド ウィンドウに表示できる [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトのプロパティを設定およびクエリできるようにするインターフェイスを定義します。 これらの関数は、[**IAgentCommandEx**](iagentcommandex)からも使用できます。 **Command** オブジェクトは、[**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクション内の項目です。 サーバーは、クライアント アプリケーションが入力がアクティブになったときに、コマンドへのユーザー アクセスを提供します。

[**コマンド**](/ja-jp/windows/desktop/lwef/the-command-object) は、キャラクターのポップアップ メニューと音声コマンド ウィンドウの両方に表示される場合があります。 ポップアップ メニューに表示するには、[**キャプション**](caption-property) があり、[**Visible**](visible-property) プロパティが true に設定されている必要があります。 [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクション オブジェクトの **Visible** プロパティは、クライアント アプリケーションが入力/アクティブのときにコマンドをポップアップ メニューに表示するには、**True** にも設定する必要があります。 [音声コマンド] ウィンドウに表示するには、**コマンド** の [**VoiceCaption**](voicecaption-property) プロパティと [**Voice**](voice-property) プロパティが設定されている必要があります。 (下位互換性のために、VoiceCaption がない場合は、**Caption** 設定が使用されます)。

メニューが表示されている間、文字のポップアップ メニュー エントリは変更されません。 文字のポップアップ メニューが表示されているときにコマンドを追加または削除したり、プロパティを変更したりすると、再表示時にメニューにそれらの変更が表示されます。 ただし、[音声コマンド] ウィンドウでは、変更を行うと表示されます。

次の表は、コマンドのプロパティがプレゼンテーションにどのように影響するかをまとめたものです。

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

一般に、[**音声**](voice-property) 設定を使用して [**コマンド**](/ja-jp/windows/desktop/lwef/the-command-object) を定義する場合は、関連付けられている [**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションの [**キャプション**](caption-property) と **音声** 設定も定義します。 一連のコマンドの **Commands** コレクションに **音声** がないか、**Caption** 設定がなく、現在入力がアクティブな場合は、 ただし、**コマンド** キャプション **と 音声 設定**、クライアント アプリケーションが入力アクティブになると、**コマンド ウィンドウのツリー ビューの [(未定義のコマンド)]に表示**。

サーバーは、[**Commands**](/ja-jp/windows/desktop/lwef/the-commands-collection-object) コレクションに対して定義した [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトのいずれかに一致する入力を受け取ると、[**IAgentNotifySink::Command**](https://www.bing.com/search?q=**IAgentNotifySink::Command**) イベントを送信し、[**IAgentUserInput**](https://www.bing.com/search?q=**IAgentUserInput**) オブジェクトの属性としてコマンドの ID を返します。 その後、条件付きステートメントを使用して、コマンドの照合と処理を行うことができます。

Vtable Order **のメソッドを** する

| IAgentCommand メソッド | 形容 |
| --- | --- |
| SetCaption**[の](https://www.bing.com/search?q=**SetCaption**)** | [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトの [**Caption**](caption-property) の値を設定します。 |
| GetCaption**[を](https://www.bing.com/search?q=**GetCaption**)**する | [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトの [**Caption**](caption-property) プロパティの値を返します。 |
| SetVoice**[の](iagentcommand--setvoice)** | [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトの [**Voice**](voice-property) テキストの値を設定します。 |
| [**GetVoice**](iagentcommand--getvoice) | [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトの [**Voice**](voice-property) プロパティの値を返します。 |
| SetEnabled**[の](iagentcommand--setenabled)** | [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトの [**Enabled**](enabled-property) プロパティの値を設定します。 |
| GetEnabled**[の](iagentcommand--getenabled)** | [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトの [**Enabled**](enabled-property) プロパティの値を返します。 |
| SetVisible**[の](iagentcommand--setvisible)** | [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトの [**Visible**](visible-property) プロパティの値を設定します。 |
| GetVisible**[の](iagentcommand--getvisible)** | [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトの [**Visible**](visible-property) プロパティの値を返します。 |
| SetConfidenceThreshold**[の](iagentcommand--setconfidencethreshold)** | [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトの [**Confidence**](confidence-property) プロパティの値を設定します。 |
| GetConfidenceThreshold**[の](iagentcommand--getconfidencethreshold)** | [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトの [**Confidence**](confidence-property) プロパティの値を返します。 |
| [**SetConfidenceText**](iagentcommand--setconfidencetext) | [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトの [**ConfidenceText**](confidencetext-property) プロパティの値を設定します。 |
| getConfidenceText**[を](iagentcommand--getconfidencetext)**する | [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトの [**ConfidenceText**](confidencetext-property) プロパティの値を返します。 |
| getID**[を](iagentcommand--getid)**する | [**Command**](/ja-jp/windows/desktop/lwef/the-command-object) オブジェクトの ID を返します。 |