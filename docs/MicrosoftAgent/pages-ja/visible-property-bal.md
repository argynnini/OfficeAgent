---
layout: Conceptual
title: Visible プロパティ (Balloon オブジェクト) - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/visible-property-bal
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: 指定した文字の吹き出しの表示設定を取得または設定する、Balloon オブジェクトの Visible プロパティについて説明します。
document_id: fd732790-f2b4-083f-01e8-7b9fdd2a2931
document_version_independent_id: 006e9f61-210e-2116-6249-760e2d58deff
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/visible-property-bal.md
locale: ja-jp
ms.assetid: cbda7f69-889a-45a0-9549-d27eddfcec57
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/visible-property-bal.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:03:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/visible-property-bal.md
page_type: conceptual
toc_rel: toc.json
word_count: 643
asset_id: lwef/visible-property-bal
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 10281de1-d0be-da9f-b3c9-ac8db8b634bf
---

# Visible プロパティ (Balloon オブジェクト) - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

- **説明**
    - 指定した文字の吹き出しの表示設定を取得または設定します。
- **構文の**
    - エージェント \*\* です。Characters(**"*CharacterID*"**).Balloon.Visible\*\* [ = *boolean*]

| 部分 | 形容 |
| --- | --- |
| ブール | 吹き出しという単語を表示するかどうかを指定するブール式。**True** 吹き出しが表示されます。**False** 吹き出しが非表示になっています。 |

## 備考

吹き出しに従う場合 [**、または吹き出しのプロパティを変更するステートメントを使用して**](think-method) 呼び出しを考える場合、吹き出しの表示状態には影響しない可能性があります。これは、**Speak** または **Think** 呼び出しがキューに入れられますが、吹き出しの表示状態を設定する呼び出し設定では影響を受けないためです。 したがって、この値を設定するのは、**Speak** がない場合や、**呼び出しが文字のキューにあると考える** 場合のみです。

文字の読み上げ中、移動中、またはドラッグ中にこのプロパティを設定しようとすると、前の操作が完了するまで、プロパティの設定は有効になりません。

[**Speak**](speak-method) を呼び出し  メソッドを呼び出すと、吹き出しが自動的に表示され、[**Visible**](visible-property) プロパティが True 設定されます。 文字のバルーン AutoHide プロパティが有効になっている場合、出力テキストが読み上げられた後、バルーンは自動的に非表示になります。 現在読み上げされていない文字をクリックまたはドラッグすると、自動的に吹き出しが非表示になります(自動非表示設定が無効になっている場合でも)。 吹き出しの [スタイル]**[プロパティを使用して、文字のオートハイド設定](style-property)**変更できます。

### 関連項目

[**Style プロパティの**](style-property)