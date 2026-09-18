---
layout: Conceptual
title: Java を使用したサービスへのアクセス - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/accessing-services-using-java
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: Java を使用したサービスへのアクセス
document_id: bb7ed533-6495-1b3e-9f0c-1de5207fa4ca
document_version_independent_id: 6201e952-7625-6db1-5362-d863c777c0f6
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/accessing-services-using-java.md
locale: ja-jp
ms.assetid: 3eced858-487a-4f36-a7a1-34ac827aad13
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/accessing-services-using-java.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:36:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/accessing-services-using-java.md
page_type: conceptual
toc_rel: toc.json
word_count: 1083
asset_id: lwef/accessing-services-using-java
item_type: Content
cmProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/540ac133-a371-4dbb-8f94-28d6cc77a70b
spProducts:
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/60bfc045-f127-4841-9d00-ea35495a5800
platformId: 70ed59a6-47b2-5fcc-5a83-01244e185e5d
---

# Java を使用したサービスへのアクセス - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

Java アプレットから Microsoft エージェント サービスにアクセスすることもできます。 Microsoft エージェント インターフェイスを介してアクセスできる関数の多くは、参照渡しされたパラメーターを介して値を返します。 これらのパラメーターを Java から渡すには、コードに単一要素配列を作成し、パラメーターとして適切な関数に渡す必要があります。 Microsoft Visual J++ を使用していて、Microsoft エージェント サーバーで Java タイプ ライブラリ ウィザードを実行している場合は、summary.txt ファイルを参照して、配列引数を必要とする関数を確認してください。 この手順は C の手順と似ています。 [**IAgentEx**](https://www.bing.com/search?q=**IAgentEx**) インターフェイスを使用してサーバーのインスタンスを作成し、文字を読み込みます。

```
private IAgentEx            m_AgentEx = null;
private IAgentCharacterEx   m_Merlin[] = {null};
private int                 m_MerlinID[] = {-1};
private int                 m_RequestID[] = {0};
private final String        m_CharacterPath = "merlin.acs";

public void start()
{
      // Start the Microsoft Agent Server

      m_AgentEx = (IAgentEx) new AgentServer();

      try
      {

         Variant characterPath = new Variant();
         characterPath.putString(m_CharacterPath);

         // Load the character

         m_AgentEx.Load(characterPath,
                    m_MerlinID,
                    m_RequestID);
      }
```

Web サイトなどの HTTP リモートの場所から文字を読み込む場合、手順は少し異なります。 この場合、 [**Load**](/ja-jp/previous-versions/visualstudio/foxpro/h1tx7zt1%28v=vs.71%29) メソッドは非同期であり、E\_PENDING (0x8000000a) の COM 例外を発生させます。 この例外をキャッチし、次の関数で行われるように正しく処理する必要があります。

```
// Constants used in asynchronous character loads

private final int E_PENDING = 0x8000000a;
private final int NOERROR = 0;

// This function loads a character from the specified path.
// It correctly handles the loading of characters from
// remote sites.

// This sample doesn't care about the request id returned
// from the Load call.  Real production code might use the
// request id and the RequestComplete callback to check for
// a successful character load before proceeding.

public int LoadCharacter(Variant path, int[] id)
{
   int requestid[] = {-1};
   int hRes = 0;

   try
   {
      // Load the character

      m_AgentEx.Load(path, id, requestid);
   }
   catch(com.ms.com.ComException e)
   {
      // Get the HRESULT

      hRes = e.getHResult();
      
      // If the error code is E_PENDING, we return NOERROR

      if (hRes == E_PENDING)
         hRes = NOERROR;
   }

   return hRes;
}

public void start()
{
   if (LoadCharacter(characterPath, m_MerlinID) != NOERROR)
   {
      stop();
      return;
   }

   // Other initialization code here

   .
   .
   .
}
```

次に、メソッドにアクセスできる [**IAgentCharacterEx**](https://www.bing.com/search?q=**IAgentCharacterEx**) インターフェイスを取得します。

```
// Get the IAgentCharacterEx interface for the loaded
// character by passing its ID to the Agent server.

m_AgentEx.GetCharacterEx(m_MerlinID[0], m_Merlin);

// Show the character

m_Merlin[0].Show(FALSE, m_RequestID);

// And speak hello

m_Merlin[0].Speak("Hello World!", "", m_RequestID);
```

同様に、イベントを通知するには、 [**IAgentNotifySink**](https://www.bing.com/search?q=**IAgentNotifySink**) インターフェイスまたは [**IAgentNotifySinkEx**](https://www.bing.com/search?q=**IAgentNotifySinkEx**) インターフェイスを実装し、その型のオブジェクトを作成して登録する必要があります。

```
...
// Declare an Agent Notify Sink so that we can get
// notification callbacks from the Agent server.

private AgentNotifySinkEx m_SinkEx = null;
private int            m_SinkID[] = {-1};

public void start()
   {
   ...
   // Create and register a notify sink

   m_SinkEx = new AgentNotifySinkEx();

   m_AgentEx.Register(m_SinkEx, m_SinkID);
   …
   // Give our notify sink access to the character

   m_SinkEx.SetCharacter(m_Merlin[0]);
   ...
   }
```

Java アプレットから Microsoft エージェントにアクセスするには、アプレットと共にインストールする Java クラスを生成する必要があります。 たとえば、Visual J++ Java タイプ ライブラリ ウィザードを使用して、これらのファイルを生成できます。 Web ページでアプレットをホストする予定の場合は、ページと共にダウンロードする生成されたクラス ファイルを含む署名付き Java CAB を構築する必要があります。 クラス ファイルは、Java サンドボックスの外部で実行される COM オブジェクトであるため、Microsoft エージェント サーバーにアクセスするために必要です。