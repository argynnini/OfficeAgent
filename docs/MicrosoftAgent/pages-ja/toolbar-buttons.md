---
layout: Conceptual
title: ツール バー ボタン (言語情報サウンド編集ツール) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/toolbar-buttons
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: ツール バー ボタン
document_id: 49b6f7b7-0540-30b9-0ced-9039116150c8
document_version_independent_id: a569bd8b-6de1-4f9d-123e-9d70e72e99bc
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/toolbar-buttons.md
locale: ja-jp
ms.assetid: 346a55e6-b506-4fd4-9ef8-bf4fbd866dd3
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/toolbar-buttons.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:03:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/toolbar-buttons.md
page_type: conceptual
toc_rel: toc.json
word_count: 742
asset_id: lwef/toolbar-buttons
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 84c2fd1b-1341-1893-e1ae-960d8f52e9dd
---

# ツール バー ボタン (言語情報サウンド編集ツール) - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

![](images/f9charnew.gif)

- **新機能**
    - 新しいサウンド ファイルを作成するためのサウンド エディターをリセットします。 既存のサウンド ファイルが読み込まれ、編集が保存されていない場合、サウンド エディターには、保存されていない変更を保存するか破棄するかを決定するメッセージが表示されます。

![](images/f10charopen.gif)

- **開く**
    - [ファイルを開く] ダイアログ ボックスを表示し、既存のサウンド ファイルを開きます。 既存のサウンド ファイルが読み込まれ、編集が保存されていない場合、サウンド エディターには、保存されていない変更を保存するか破棄するかを決定するメッセージが表示されます。

![](images/f11charsave.gif)

- **保存**
    - サウンド ファイルを保存します。 ファイルが存在しない (名前が指定されていない) 場合、エディターはファイル名を入力するための [名前を付けて保存] ダイアログ ボックスを表示します。

![](images/f14charcut.gif)

- **カット**
    - 選択したテキストをエディターから削除し、Windows クリップボードに配置します。

![](images/f15charcopy.gif)

- **コピー**
    - エディターで選択したテキストを Windows クリップボードにコピーします。

![](images/f16charpaste.gif)

- **貼り付け**
    - 現在の Windows クリップボードから、[テキスト表現] テキスト ボックス内の選択した場所にテキストをコピーします。

![](images/f17chardel.gif)

- **削除**
    - 選択したテキストをサウンド エディターから削除します。

![](images/f18charundo.gif)

- **取り消し**
    - サウンド エディターで行われた変更を削除します。

![](images/f19charredo.gif)

- **やり直し**
    - サウンド エディターで元に戻す操作を元に戻します。

![](images/flistlinguist.gif)

- **言語情報の生成**
    - サウンド ファイルの音素と単語ラベルを生成します。

![](images/flistpause.gif)

- **一時 停止**
    - サウンド ファイルの再生を一時停止します。

![](images/flistplay.gif)

- **再生**
    - サウンド ファイルまたはサウンド ファイルの選択した部分を再生します。

![](images/fliststop.gif)

- **停止**
    - サウンド ファイルまたはサウンド ファイルの選択した部分の録音または再生を停止します。

![](images/flistrecord.gif)

- **レコード**
    - サウンド ファイルの記録を開始します。