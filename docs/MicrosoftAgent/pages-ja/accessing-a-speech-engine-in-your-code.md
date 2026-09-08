---
layout: Conceptual
title: コード内の音声エンジンへのアクセス - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/accessing-a-speech-engine-in-your-code
schema: Conceptual
adobe-target: true
author: QuinnRadich
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: コード内の音声エンジンへのアクセス
feedback_system: Standard
git_commit_id: adcc2e2cf0329f73eb5d5ecafc17c88bc0bfb02f
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/adcc2e2cf0329f73eb5d5ecafc17c88bc0bfb02f/desktop-src/lwef/accessing-a-speech-engine-in-your-code.md
locale: ja-jp
ms.assetid: ddfe0552-a29e-4ce4-b608-c131efbe300b
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.topic: concept-article
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/accessing-a-speech-engine-in-your-code.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-08-20T17:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/accessing-a-speech-engine-in-your-code.md
page_type: conceptual
toc_rel: toc.json
feedback_product_url: ''
feedback_help_link_type: ''
feedback_help_link_url: ''
word_count: 1845
asset_id: lwef/accessing-a-speech-engine-in-your-code
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/c6f99e62-1cf6-4b71-af9b-649b05f80cce
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/3f56b378-07a9-4fa1-afe8-9889fdc77628
platformId: 3df1e384-5868-011a-7728-a67180a0d557
---

# コード内の音声エンジンへのアクセス - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

コードで特定の音声エンジンを使用するには、エージェント API を使用してエンジンを設定します。 音声入力エンジンの場合は、エンジンのモード ID を指定して [**SRModeID**](https://www.bing.com/search?q=**SRModeID**) を使用します。 ただし、エンジンをインストールする必要があることに注意してください。 エンジンが存在するかどうかを判断するには、 **SRModeID** に対してクエリを実行します。 エンジンは、文字の [**LanguageID**](https://www.bing.com/search?q=**LanguageID**) 設定と一致する必要があります。 たとえば、**LanguageID** がフランス語である文字の **SRModeID** をドイツ語の音声認識エンジン モード ID に設定することはできません。

**音声入力エンジン モード ID**

| 音声 | モード ID |
| --- | --- |
| Microsoft 音声認識エンジン v4.0 | {D8905400-B5C8-11D0-B968020AFDB1B9C} |

**アプリケーションの Command** オブジェクトの音声パラメーターの文法を定義する前に、コードで文字の [**LanguageID**](https://www.bing.com/search?q=**LanguageID**) と [**SRModeID**](https://www.bing.com/search?q=**SRModeID**) を確認して設定します。 また、ユーザーの構成と一致することを確実にできるように、ブラウザーまたはシステム言語を確認することも検討してください。 エンジンが一致しない言語の文法を定義しようとすると、エンジンが失敗することがあります。

テキスト読み上げ (TTS) 出力の文字セットは、既定の音声出力エンジンのモード ID 設定を使用してコンパイルできます。 文字が読み込まれると、エンジンがインストールされ、文字の [**LanguageID**](https://www.bing.com/search?q=**LanguageID**) と一致する場合、エージェントは音声出力用にそのモード ID の読み込みを試みます。 エンジンが存在しないか、別の **LanguageID** を持っている場合、エージェントは、文字の **LanguageID** に一致する最初のモード ID を読み込もうとしますが、それでも文字のコンパイル速度とピッチ設定を設定します。

Microsoft Agent で提供されるすべての文字は、既定の音声出力エンジンとして Lernout & Hauspie TruVoice American English エンジンを使用するようにコンパイルされるため、文字の速度とピッチの設定は、この言語とエンジンに合わせて調整されます。 したがって、他の TTS エンジンや他の言語のエンジンを使用する場合、文字が最適なピッチまたは速度で話されない可能性があります。 アプリケーションまたは Web ページで [**Pitch**](/ja-jp/previous-versions/ms809428%28v=msdn.10%29) プロパティ値と [**Speed**](https://www.bing.com/search?q=**Speed**) プロパティ値を記述することはできませんが、出力テキストに [Pit](pit-tag) (pitch) タグと [Spd](spd-tag) (speed) タグを含めて、特定の発話のピッチと速度を一時的に変更できます。 ただし、Pit タグと Spd タグを使用すると、 **Pitch** プロパティと **Speed** プロパティは変更されません。 詳細については、「 [Microsoft エージェント コントロールと Microsoft](programming-the-microsoft-agent-control)[エージェント音声出力タグ](microsoft-agent-speech-output-tags) のプログラミング」を参照してください。

また、L H TruVoice American English エンジン以外&の SAPI 準拠 TTS エンジンと Microsoft Agent が提供する文字を使用してエンジンを適切に列挙する場合は、SAPI 4.0a ランタイム バイナリ (SPCHAPI.exe) をインストールする必要があります。 Web ページから、次の Object タグを含め、コンポーネントを自動的にインストールします。

```syntax
<OBJECT width=0 height=0
CLASSID="CLSID:0C7F3F20-8BAB-11d2-9432-00C04F8EF48F"
CODEBASE="#VERSION=4,0,0,0">
</OBJECT>
```

エンジンのモード ID を照会または設定するには、 [**TTSModeID**](https://www.bing.com/search?q=**TTSModeID**) を使用します。 **TTSModeID** を使用すると、文字の [**LanguageID**](https://www.bing.com/search?q=**LanguageID**) とは異なるモード ID を設定できます。 たとえば、フランス語モード ID を使用して話すドイツ語の文字を設定できます。 音声出力エンジン モード ID は、使用するエンジンを定義するだけでなく、エンジンでサポートされている特定の音声にも対応します。 また、Microsoft エージェント文字エディターまたは [Microsoft Speech SDK ドキュメント](https://msdn.microsoft.com/library/ee705648.aspx) に含まれているツールを使用して、システムにインストールされている TTS エンジンのモード ID を照会することもできます。

**音声出力モード ID**

| 音声 | モード ID |
| --- | --- |
| 成人女性 #1、米国英語、L&H TruVoice | {CA141FD0-AC7F-11D1-97A3-006008273008} |
| 成人女性 #2、米国英語、L&H TruVoice | {CA141FD0-AC7F-11D1-97A3-006008273009} |
| 成人男性 #1、米国英語、L&H TruVoice | {CA141FD0-AC7F-11D1-97A3-006008273000} |
| 成人男性 #2、米国英語、L&H TruVoice | {CA141FD0-AC7F-11D1-97A3-006008273001} |
| 成人男性 #3、米国英語、L&H TruVoice | {CA141FD0-AC7F-11D1-97A3-006008273002} |
| 成人男性 #4、米国英語、L&H TruVoice | {CA141FD0-AC7F-11D1-97A3-006008273003} |
| 成人男性 #5、米国英語、L&H TruVoice | {CA141FD0-AC7F-11D1-97A3-006008273004} |
| 成人男性 #6、米国英語、L&H TruVoice | {CA141FD0-AC7F-11D1-97A3-006008273005} |
| 成人男性 #7、米国英語、L&H TruVoice | {CA141FD0-AC7F-11D1-97A3-006008273006} |
| 成人男性 #8、米国英語、L&H TruVoice | {CA141FD0-AC7F-11D1-97A3-006008273007} |
| Carol、British English、L&H TTS3000 | {227A0E40-A92A-11d1-B17B-0020AFED142E} |
| Peter, British English, L&H TTS3000 | {227A0E41-A92A-11d1-B17B-0020AFED142E} |
| リンダ、オランダ語、L&H TTS3000 | {A0DDCA40-A92C-11d1-B17B-0020AFED142E} |
| アレクサンダー、オランダ語、L&H TTS3000 | {A0DDCA41-A92C-11d1-B17B-0020AFED142E} |
| Véronique、フランス語、L&H TTS3000 | {0879A4E0-A92C-11d1-B17B-0020AFED142E} |
| ピエール、フランス語、L&H TTS3000 | {0879A4E1-A92C-11d1-B17B-0020AFED142E} |
| Anna、ドイツ語、L&H TTS3000 | {3A1FB760-A92B-11d1-B17B-0020AFED142E} |
| ステファン、ドイツ語、L&H TTS3000 | {3A1FB761-A92B-11d1-B17B-0020AFED142E} |
| バーバラ、イタリア語、L&H TTS3000 | {7EF71700-A92D-11d1-B17B-0020AFED142E} |
| ステファノ、イタリア語、L&H TTS3000 | {7EF71701-A92D-11d1-B17B-0020AFED142E} |
| ナオコ, 日本語, L&H TTS3000 | {A778E060-A936-11d1-B17B-0020AFED142E} |
| ケンジ、日本語、L&H TTS3000 | {A778E061-A936-11d1-B17B-0020AFED142E} |
| Shin-Ah, 韓国語, L&H TTS3000 | {12E0B720-A936-11d1-B17B-0020AFED142E} |
| Jun-Ho, 韓国語, L&H TTS3000 | {12E0B721-A936-11d1-B17B-0020AFED142E} |
| Juliana、ポルトガル語 (ブラジル)、L&H TTS3000 | {8AA08CA0-A1AE-11d3-9BC5-00A0C967A2D1} |
| Alexandre、ポルトガル語 (ブラジル)、L&H TTS3000 | {8AA08CA1-A1AE-11d3-9BC5-00A0C967A2D1} |
| Svetlana、ロシア語、L&H TTS3000 | {06377F80-D48E-11d1-B17B-0020AFED142E} |
| ボリス語、ロシア語、L&H TTS3000 | {06377F81-D48E-11d1-B17B-0020AFED142E} |
| カルメン、スペイン語、L&H TTS3000 | {2CE326E0-A935-11d1-B17B-0020AFED142E} |
| Julio、スペイン語、L&H TTS3000 | {2CE326E1-A935-11d1-B17B-0020AFED142E} |

Note

音声エンジンのインストール CLSID とそのモード ID には違いがあります。 同様に、音声エンジンにもエンジン ID がありますが、この ID はエージェント API には適用されません。