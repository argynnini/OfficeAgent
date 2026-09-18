---
layout: Conceptual
title: Accessing Services Using Java - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/en-us/windows/win32/lwef/accessing-services-using-java
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
uhfHeaderId: MSDocsHeader-WinDevCenter
recommendations: true
adobe-target: true
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.author: jken
author: GrantMeStrength
feedback_system: Standard
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_help_link_type: get-help-at-qna
description: Accessing Services Using Java
ms.assetid: 3eced858-487a-4f36-a7a1-34ac827aad13
ms.topic: concept-article
ms.date: 2018-05-31T00:00:00.0000000Z
locale: en-us
document_id: bb7ed533-6495-1b3e-9f0c-1de5207fa4ca
document_version_independent_id: 6201e952-7625-6db1-5362-d863c777c0f6
updated_at: 2025-03-13T17:42:00.0000000Z
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/accessing-services-using-java.md
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/accessing-services-using-java.md
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
site_name: Docs
depot_name: MSDN.win32
page_type: conceptual
toc_rel: toc.json
pdf_url_template: https://learn.microsoft.com/pdfstore/en-us/MSDN.win32/{branchName}{pdfName}
word_count: 611
asset_id: lwef/accessing-services-using-java
moniker_range_name: 
monikers: []
item_type: Content
source_path: desktop-src/lwef/accessing-services-using-java.md
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

# Accessing Services Using Java - Win32 apps | Microsoft Learn

[Microsoft Agent is deprecated as of Windows 7, and may be unavailable in subsequent versions of Windows.]

You can also access Microsoft Agent services from a Java applet. Many of the functions accessible through the Microsoft Agent interfaces return values through parameters passed by reference. In order to pass these parameters from Java, it is necessary to create single-element arrays in your code and pass them as parameters to the appropriate function. If you are using Microsoft Visual J++ and have run the Java Type Library Wizard on the Microsoft Agent server, refer to the summary.txt file to review which functions require array arguments. The procedure is similar to that in C; you use the [**IAgentEx**](https://www.bing.com/search?q=**IAgentEx**) interface to create an instance of the server, then load the character:

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

The procedure is slightly different when loading characters from a HTTP remote location such as a website. In this case the [**Load**](/en-us/previous-versions/visualstudio/foxpro/h1tx7zt1%28v=vs.71%29) method is asynchronous and will raise a COM exception of E\_PENDING (0x8000000a). You will need to catch this exception and handle it correctly as is done in the following functions:

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

Then get the [**IAgentCharacterEx**](https://www.bing.com/search?q=**IAgentCharacterEx**) interface that enables you to access its methods:

```
// Get the IAgentCharacterEx interface for the loaded
// character by passing its ID to the Agent server.

m_AgentEx.GetCharacterEx(m_MerlinID[0], m_Merlin);

// Show the character

m_Merlin[0].Show(FALSE, m_RequestID);

// And speak hello

m_Merlin[0].Speak("Hello World!", "", m_RequestID);
```

Similarly, to be notified of events, you must implement either the [**IAgentNotifySink**](https://www.bing.com/search?q=**IAgentNotifySink**) or the [**IAgentNotifySinkEx**](https://www.bing.com/search?q=**IAgentNotifySinkEx**) interface, creating and registering an object of that type:

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

In order to access Microsoft Agent from a Java applet, you must generate Java classes that you install with the applet. You can use the Visual J++ Java Type Library Wizard, for example, to generate these files. If you plan to host the applet on a webpage, you will need to build a signed Java CAB inclusive of the generated class files that download with the page. The class files are necessary to access the Microsoft Agent Server since it is a COM object, that executes outside of the Java sandbox.