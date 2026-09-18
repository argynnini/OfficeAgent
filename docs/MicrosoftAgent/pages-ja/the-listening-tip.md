---
layout: Conceptual
title: リッスンヒント - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/the-listening-tip
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: リッスンヒント
document_id: 44133598-3b37-bb3a-c65d-fc8c2f02e9f1
document_version_independent_id: 97266942-8c87-324a-e9ba-c4504e9b63b6
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/the-listening-tip.md
locale: ja-jp
ms.assetid: d363c1ac-53fc-4b93-b056-63eeee923380
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/the-listening-tip.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:02:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/the-listening-tip.md
page_type: conceptual
toc_rel: toc.json
word_count: 2598
asset_id: lwef/the-listening-tip
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: f1c1954e-a139-4458-7bf3-88673237bde0
---

# リッスンヒント - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

リッスン ヒントは、Microsoft エージェントによって提供されるもう 1 つの音声入力サービスです。 音声入力がインストールされている場合、エージェントには、ユーザーが Listening ホットキーを押すか、Listen メソッドを呼び出したときに表示される特別なツールヒント ウィンドウが含まれます。 リッスン ヒントは、音声サービスが使用可能な場合にのみ表示されます。 クライアントが音声コマンドを作成していない場合、または音声エンジンを正常に読み込んだ場合、リッスン ヒントは表示されません。 さらに、音声入力と [高度な文字オプション] の [リッスンヒントの表示] オプションの両方を有効にして、ヒントを表示する必要があります。

次の表は、音声認識が有効になっている場合のリッスン ヒントの表示をまとめたものです。

| アクション | 結果 |
| --- | --- |
| ユーザーがリッスン モードのホットキーを押すか、または入力アクティブな [**Listen メソッドを**](listen-method) 呼び出す | リッスン ヒントは、アクティブなクライアントの文字の下に表示され、次のように表示されます。 -- *CharacterName* がリッスンしています -- "*InputActiveClientCommandsVoiceCaption*" コマンドの場合。 クライアントが VoiceCaption の Commands オブジェクトを定義していない場合は、Caption プロパティの値が使用されます。 文字を識別する最初の行は中央揃えです。 2 行目は左揃えで、リスニング チップの最大幅を超えると 3 行目に分割されます。 文字の入力アクティブなクライアントに Commands オブジェクトのキャプションまたは定義された音声パラメーターがない場合、リッスン ヒントは次のように表示されます。 -- *CharacterName* がリッスンしています -- コマンドの場合は 。 表示されている文字がない場合、リスニング ヒントは文字のタスク バー アイコンの隣に表示され、次のように表示されます。 -- *CharacterName* がリッスンしています -- 表示する文字の名前を指定します。 音声認識がまだ初期化中の場合は、リッスン ヒントに次の情報が表示されます。 -- *CharacterName* はリッスンの準備をしています -- お待ちください。 文字が音声で読み上げられたときや他のアプリケーションがオーディオ チャネルを使用している場合のように、オーディオ チャネルがビジー状態の場合は、リスニング ヒントが表示されます。 -- *CharacterName* がリッスンしていません -- "*InputActiveClientCommandsVoiceCaption*" コマンドの場合。 入力/アクティブ なクライアントの文字に言語互換の音声エンジンがインストールされていない場合、リッスン ヒントには次が表示されます。ここで、 *Language* は文字の選択した言語を表します。 -- *CharacterName* がリッスンしていません - 音声入力は *言語*では使用できません。 オーディオ デバイスがビジー状態の場合やオーディオ デバイスを開こうとする際に何らかのエラーが発生した場合など、他の理由でオーディオ デバイスを使用できない場合は、リッスン モードがアクティブになったときに次のヒントが表示されます。 -- *CharacterName* がリッスンしていません - 音声入力は使用できません。 入力アクティブなクライアント アプリケーションでコマンドの音声設定が定義されておらず、エージェントのグローバル コマンドの音声パラメーターも無効になっている場合は、次のヒントが表示されます。*CharacterName* がリッスンしていません - 音声コマンドはありません。 すべての文字が非表示の場合、リッスン ヒントには次のテキストが表示されます。*CharacterName* がリッスンしています - 表示する文字の名前を指定します。 |
| ユーザーが音声コマンドを読み上げる | 読み上げられたテキストがクライアントまたはサーバー定義のコマンドと一致する場合、リッスン ヒントはアクティブなクライアントの文字の下に表示され、次のように表示されます。 -- *CharacterName* がリッスンしています - "*CommandText*" と読み上がいました ただし、認識が戻され、リッスン モードがタイムアウトしたが、リッスン ヒントのタイムアウトがない場合、またはリスニング モードがまだ有効になっているが、オーディオ チャネルがまだ使用できない場合 (たとえば、ユーザーがまだリッスン キーを保持しているか、リッスン モードがタイムアウトしていない場合) 文字が読み上げになっているため)、リスニング ヒントには次の情報が表示されます。*CharacterName* がリッスンしていません - "*テキストが聞こえない" と読み上がった* 読み上げられたテキストがサーバー定義のコマンドと一致するが、コマンドの信頼度スコアが低いためにサーバーが動作しない場合、リッスン ヒントの 2 行目に次の情報が表示されます。 要求を理解できませんでした。 最初の行は中央揃えです。 2 行目は左揃えで、リスニング チップの最大幅を超えると 3 行目に分割されます。 |

リッスン ヒントは、表示された後に自動的にタイムアウトします。 ユーザーがホットキーを押したままの間に "Heard" テキストのタイムアウトが完了した場合、サーバーが別の一致する発話を受信しない限り、ヒントは "リッスン中" テキストに戻ります。 この場合、ヒントには新しい "Heard" テキストが表示され、そのヒント テキストのタイムアウトが開始されます。 ユーザーがホットキーを離し、サーバーに "Heard" テキストが表示されている場合、タイムアウトは続行され、タイムアウト間隔が経過すると [Listening Tip] ウィンドウは非表示になります。

サーバーが音声認識エンジンの読み込みをまだ試行していない場合、リッスン ヒントは表示されません。 同様に、ユーザーがリスニング ヒントの表示を無効にした場合、または高度な文字オプションで音声入力を無効にした場合、リスニング ヒントは表示されません。

ポインターが文字のタスク バー アイコンの上にある場合、リッスン ヒントは表示されません。 代わりに、標準の通知ヒント ウィンドウが表示され、文字の名前が表示されます。

クライアント アプリケーションはリッスン ヒントに直接書き込めませんが、一致する音声コマンドの認識時にサーバーが表示する代替テキストを指定できます。 これを行うには、コマンドの [**Confidence**](confidence-property) プロパティと新しい [**ConfidenceText**](confidencetext-property)プロパティを設定します。 音声入力がコマンドと一致するが、最適な一致が信頼度設定を超えない場合、サーバーはヒント ウィンドウの **ConfidenceText** プロパティのテキスト セットを使用します。 クライアントがこの値を指定しない場合、サーバーは一致したテキスト (文法) を表示します。

使用可能な言語互換音声認識エンジンがあるかどうかに関係なく、リッスン ヒント テキストは、入力アクティブなクライアントの文字言語 ID 設定に基づいて言語で表示されます。