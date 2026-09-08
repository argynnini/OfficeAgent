---
layout: Conceptual
title: コマンド リファレンス (言語情報サウンド編集ツール) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/command-reference
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: このコマンド リファレンスでは、言語情報サウンド編集ツールについて説明します。 Microsoft エージェントは、Windows 7 の時点で非推奨となりました。
document_id: 14c4387b-9746-fb58-f546-71f00bc49ddf
document_version_independent_id: 817e4c54-e8ef-b789-4f06-8e240cd21d09
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/command-reference.md
locale: ja-jp
ms.assetid: 084f14ee-6774-46e2-a4ec-92f480f2f74a
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/command-reference.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:38:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/command-reference.md
page_type: conceptual
toc_rel: toc.json
word_count: 1655
asset_id: lwef/command-reference
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 793d8b17-afe3-c738-2521-9b054bbfc062
---

# コマンド リファレンス (言語情報サウンド編集ツール) - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

### [ファイル] メニュー

- **新機能**
    - 新しい拡張サウンド ファイルを作成するためのサウンド エディターをリセットします。 既存のサウンド ファイルが読み込まれ、編集が保存されていない場合、サウンド エディターには、保存されていない変更を保存するか破棄するかを決定するメッセージが表示されます。
- **開く**
    - [開く] ダイアログ ボックスを表示し、既存のサウンド ファイルを開きます。 既存のサウンド ファイルが読み込まれ、編集が保存されていない場合、サウンド エディターには、保存されていない変更を保存するか破棄するかを決定するメッセージが表示されます。
- **保存**
    - サウンド ファイルを保存します。 サウンド ファイルが存在しない (名前が指定されていない) 場合、サウンド エディターはファイル名を入力するための [名前を付けて保存] ダイアログ ボックスを表示します。
- **名前を付けて保存**
    - [名前を付けて保存] ダイアログ ボックスを表示し、サウンド ファイルの新しい名前を入力できるようにします。
- **選択範囲を名前を付けて保存**
    - [選択範囲に名前を付けて保存] ダイアログ ボックスを表示し、サウンド ファイルの選択した部分の名前を入力できるようにします。
- **最近開いたファイル**
    - 開いた最近の文字定義ファイルを追跡します。 ファイルを選択すると、そのファイルが編集用に自動的に開きます。 既存の文字が読み込まれ、ファイルへの編集が保存されていない場合は、サウンド エディターにメッセージが表示され、未保存の変更を保存するか破棄するかを決定します。
- **終了**
    - サウンド エディターを終了します。 既存のファイルが読み込まれ、編集が保存されていない場合、サウンド エディターにメッセージが表示され、保存されていない変更を保存するか破棄するかを決定します。

### [編集] メニュー

- **取り消し**
    - サウンド エディターで行われた変更を削除します。
- **やり直し**
    - サウンド エディターで元に戻す操作を元に戻します。
- **カット**
    - 選択したテキストを削除し、クリップボードに配置します。
- **コピー**
    - 選択したテキストをクリップボードにコピーします。
- **貼り付け**
    - クリップボードのテキストを、[テキスト表現] テキスト ボックスの挿入ポイントまたは選択範囲にコピーします。
- **削除**
    - 選択したテキストを削除します。
- **[すべて選択]**
    - [テキスト表現] テキスト ボックスのテキストを選択します。
- **言語情報の生成**
    - サウンド ファイルの単語区切りと音素情報の生成を開始します。
- **音素の挿入**
    - 選択した音素ラベルを挿入できる [音素の挿入] ダイアログ ボックスを表示します。
- **音素を置き換える**
    - 選択した音素ラベルを置き換えることができる [音素の置換] ダイアログ ボックスを表示します。
- **音素の削除**
    - 選択した音素ラベルを削除します。
- **Wordの挿入**
    - [Word挿入] ダイアログ ボックスを表示します。このダイアログ ボックスを使用すると、オーディオ表現に単語ラベルを挿入できます。
- **Wordを置き換える**
    - [Word置換] ダイアログ ボックスを表示します。このダイアログ ボックスを使用すると、オーディオ表現で選択した単語ラベルを置き換えることができます。
- **Wordの削除**
    - オーディオ表現で選択した単語ラベルを削除します。
- **音素ラベル表示**
    - わかりやすい名前と IPA バイト値の間で音素ラベルの表示を変更します。
- **音声エンジン**
    - 単語区切りと音素情報を生成するために使用する音声エンジンを変更できます。

### [オーディオ] メニュー

- **再生**
    - サウンド ファイルまたはサウンド ファイルの選択した部分を再生します。
- **レコード**
    - 新しいサウンド ファイルを記録します。
- **一時 停止**
    - サウンド ファイルまたはサウンド ファイルの選択した部分の再生を一時停止します。 再生を再開するには、[再生] を使用します。
- **停止**
    - サウンド ファイルまたはサウンド ファイルの選択した部分の録音または再生を停止します。

### [ヘルプ] メニュー

- **ヘルプ トピック**
    - [ヘルプ トピック] ダイアログ ボックスが表示され、サウンド エディターのヘルプ トピックを選択できます。
- **Microsoft 言語サウンド編集ツールについて**
    - サウンド エディターの著作権とバージョン情報を含むダイアログ ボックスを表示します。