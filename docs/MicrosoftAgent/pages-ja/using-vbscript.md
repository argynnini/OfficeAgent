---
layout: Conceptual
title: VBScript の使用 - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/using-vbscript
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: VBScript の使用
document_id: a5d38d44-4bd3-b886-7840-ab84486d3063
document_version_independent_id: a16593b4-a10a-18bf-d265-3a7a7239f6e1
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 26bfe3e357770692c2621532454fea240360964c
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/26bfe3e357770692c2621532454fea240360964c/desktop-src/lwef/using-vbscript.md
locale: ja-jp
ms.assetid: a078eb60-aa12-42ea-850c-7b845fc8037c
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/using-vbscript.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T23:03:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/using-vbscript.md
page_type: conceptual
toc_rel: toc.json
word_count: 827
asset_id: lwef/using-vbscript
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 5d3019fb-eb58-8f49-8693-4b6da6c8bb2d
---

# VBScript の使用 - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

VBScript は、Microsoft Internet Explorer に含まれるプログラミング言語です。 その他のブラウザーについては、サポートについてベンダーにお問い合わせください。 エージェントでの使用には、VBScript 2.0 (以降) をお勧めします。 以前のバージョンの VBScript はエージェントで動作する可能性がありますが、使用する関数が不足しています。 VBScript 2.0 をダウンロードし、Microsoft ダウンロード サイトと Microsoft VBScript サイトで VBScript に関する詳細情報を取得できます。

VBScript から Microsoft Agent をプログラムするには、HTML &lt;SCRIPT&gt; タグを使用します。 プログラミング インターフェイスにアクセスするには、&lt;OBJECT&gt; タグで割り当てるコントロールの名前を使用し、その後にサブオブジェクト (存在する場合)、メソッドまたはプロパティの名前、およびメソッドまたはプロパティでサポートされているパラメーターまたは値を使用します。

```syntax
agent[.object].Method parameter, [parameter]
agent[.object].Property = value
```

イベントの場合は、コントロールの名前の後にイベントの名前と任意のパラメーターを含めます。

```syntax
Sub agent_event (ByVal parameter[,ByVal parameter])
statements
End Sub
```

 &lt;SCRIPT&gt; タグの **For.. を使用してイベント ハンドラーを指定することもできます。イベント** 構文:

```syntax
<SCRIPT LANGUAGE=VBScript For=agent Event=event[(parameter[,parameter])]>
statements
</SCRIPT>
```

Microsoft Internet Explorer ではこの後者の構文がサポートされていますが、すべてのブラウザーでサポートされているわけではありません。 互換性を保つには、イベントの前の構文のみを使用してください。

VBScript (2.0 以降) では、オブジェクトを作成して存在するかどうかを確認することで、Microsoft エージェントがインストールされているかどうかを確認できます。 次の例では、コントロールの自動ダウンロードをトリガーせずにエージェント コントロールを確認する方法を示します (ページにコントロールの &lt;OBJECT&gt; タグを含める場合と同様)。

```syntax
<!-- WARNING - This code requires VBScript 2.0.
It will always fail to detect the Agent control
in VbScript 1.x, because CreateObject doesn't work.
-->

<SCRIPT LANGUAGE=VBSCRIPT>
If HaveAgent() Then
      'Microsoft Agent control was found.
document.write "<H2 align=center>Found</H2>"
Else
      'Microsoft Agent control was not found.
document.write "<H2 align=center>Not Found</H2>"
End If

Function HaveAgent()
' This procedure attempts to create an Agent Control object.
' If it succeeds, it returns True.
'    This means the control is available on the client.
' If it fails, it returns False.
'    This means the control hasn't been installed on the client.

   Dim agent
   HaveAgent = False
   On Error Resume Next
   Set agent = CreateObject("Agent.Control.1")
   HaveAgent = IsObject(agent)

End Function

</SCRIPT>
```