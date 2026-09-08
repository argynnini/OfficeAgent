---
layout: Conceptual
title: Character オブジェクトのプロパティ - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/character-object-properties
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Character オブジェクトのプロパティ
document_id: ef37d18f-0995-ed96-c4a0-a1d4b50ed098
document_version_independent_id: 74764482-9875-069e-7357-f8485a0ebf6d
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/character-object-properties.md
locale: ja-jp
ms.assetid: 86748de2-f5c8-4057-bfa4-79d46cac1e62
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/character-object-properties.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:38:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/character-object-properties.md
page_type: conceptual
toc_rel: toc.json
word_count: 500
asset_id: lwef/character-object-properties
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: f03140f6-08a1-f210-2892-5fb44c58bf65
---

# Character オブジェクトのプロパティ - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

[**Character**](/ja-jp/windows/desktop/lwef/the-characters-object) オブジェクトは、次のプロパティを公開します。

- [**Active**](active-property)
- [**AutoPopupMenu**](autopopupmenu-property)
- [**説明**](description-property)
- ExtraData**[を](extradata-property)**する
- [**GUID**](guid-property)
- [**HasOtherClients**](hasotherclients-property)
- [**Height**](height-property)
- [**HelpContextID**](helpcontextid-property-ch)
- [**HelpFile**](helpfile-property)
- [**HelpModeOn**](helpmodeon-property)
- [**IdleOn**](idleon-property)
- [**LanguageID**](languageid-property)
- 左
- [**MoveCause**](movecause-property)
- [**名の**](name-property)
- [**OriginalHeight**](originalheight-property)
- [**OriginalWidth**](originalwidth-property)
- ピッチ**[を](pitch-property)**する
- [**SoundEffectsOn**](soundeffectson-property)
- [**速度**](speed-property)
- SRModeID**[の](srmodeid-property)**
- SRStatus**[を](srstatus-property)**する
- [**トップ**](top-property)
- TTSModeID**[を](ttsmodeid-property)**する
- [**バージョン**](version-property)
- [**VisibilityCause**](visibilitycause-property)
- [**表示**](visible-property-cob)
- [**幅**](width-property-co)

文字の [**Height**](height-property)、[**Left**](left-property)、[**Top**](top-property)、および [**Width**](width-property-co) プロパティは、コントロールの配置に関するプログラミング環境でサポートされるプロパティとは異なります。 [**Character**](/ja-jp/windows/desktop/lwef/the-characters-object) プロパティは、Microsoft エージェント コントロールの場所ではなく、文字の表示形式に適用されます。

[**Character**](/ja-jp/windows/desktop/lwef/the-characters-object) オブジェクト メソッドと同様に、[**Characters**](/ja-jp/windows/desktop/lwef/the-characters-object) コレクションを使用して文字のプロパティにアクセスしたり、オブジェクト変数を宣言してコレクション内の文字に設定することで構文を簡略化したりできます。 次の例では、Test1 と Test2 は同じ値に設定されます。

```
   Dim Genie 
   Dim MyRequest
   
   Sub window_Onload

   Agent.Characters.Load "Genie", "https://agent.microsoft.com/characters/v2/genie/genie.acf"

   Set Genie = Agent.Characters("Genie")

   Genie.MoveTo 15,15
   Set MyRequest = Genie.Show()

   End Sub

   Sub Agent_RequestComplete(ByVal Request)

   If Request = MyRequest Then 
      Test1 = Agent.Characters("Genie").Top
      Test2 = Genie.Top
      MsgBox "Test 1 is " + cstr(Test1) + "and Test 2 is " + cstr(Test2)
   End If

   End Sub
```

サーバーは文字を非同期的に読み込むため、[**RequestComplete**](requestcomplete-event) イベントを使用するなど、プロパティに対してクエリを実行する前に文字が読み込まれたことを確認します。 それ以外の場合、プロパティは正しくない値を返す可能性があります。