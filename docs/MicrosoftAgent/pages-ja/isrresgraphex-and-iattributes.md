---
layout: Conceptual
title: ISRResGraphEx と IAttributes - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/isrresgraphex-and-iattributes
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: ISRResGraphEx と IAttributes
document_id: 7c6da650-5cb5-e201-5362-2f8eb4561179
document_version_independent_id: 91e0faa7-1742-df95-25a7-9e2810dd3308
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/isrresgraphex-and-iattributes.md
locale: ja-jp
ms.assetid: 6eb37da1-5252-4c41-891c-c19cca6fb7d1
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/isrresgraphex-and-iattributes.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:54:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2024-01-09T19:49:59.6397822Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/isrresgraphex-and-iattributes.md
page_type: conceptual
toc_rel: toc.json
word_count: 1416
asset_id: lwef/isrresgraphex-and-iattributes
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 9f65c9e0-e87c-c6db-4544-b07fd55a8ec6
---

# ISRResGraphEx と IAttributes - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

エンジンによって返される結果オブジェクトは、ISRResGraphEx インターフェイスと IAttributes インターフェイスをサポートする必要があります。 ISRResGraphEx インターフェイスをサポートするだけで、サウンド エディターで単語区切り情報を提供できますが、音素情報に必要なサポートは提供されません。

サウンド エディターでは、エンジンが特別な DWord 属性 **SRATTR\_PHONESEG**もサポートしている必要があります。 エディターはエンジンにクエリを実行して IAttributes インターフェイスを確認し、**SRATTR\_PHONESEG** を 1 に設定しようとします。 その呼び出しが成功した場合、サウンド エディターは、エンジンの結果が結果オブジェクトからの音素セグメント化情報の収集をサポートすることを前提としています。

`#define    SRATTR_PHONESEG    MAKELONG (1, SRVEN_MICROSOFT)`

結果オブジェクトがサウンド エディターに送信されると、そのオブジェクトに対して ISRResGraphEx の実装を照会します。 ISRResGraphEx には、型シグネチャを持つメンバー関数 DataGet が含まれています

`HRESULT  DataGet  (DWord, dwID, GUID gAttrib, SDATA *psData)`

ここで、dwID  はグラフ オブジェクトの識別子、**gAttrib** は必要な属性に対応する GUID、**psData** は返されるデータを含む SDATA オブジェクトへのポインターです。 エンジンは、[**CoTaskMemAlloc**](/ja-jp/windows/desktop/api/combaseapi/nf-combaseapi-cotaskmemalloc)を使用して、**psData** に格納されているデータを割り当てる役割を担います。 呼び出し元のアプリケーション (この場合はサウンド エディター) は、完了時 [**CoTaskMemFree**](/ja-jp/windows/desktop/api/combaseapi/nf-combaseapi-cotaskmemfree) を使用して解放する役割を担います。

DataGet は、SAPI ドキュメントに記載されている 3 つの定義済みの GUID を認識するために必要です。 **DWORDSet(SRATTR\_PHONESEG, 1)** の呼び出しに成功コードを返すエンジンは、グラフ内のエッジに対応する **dwID** を使用して呼び出されたときに、特定の GUID **SRGARC\_PHONEMESEGMENTATION**を認識するためにも必要です。

`DEFINE_GUID(SRGARC_PHONMESEGMENTATION, 0xd05405b0, 0x1db1, 0x11d2, 0x94, 0x2, 0x0, 0xc0, 0x4f, 0x8e, 0xf4, 0x8f);`

呼び出しから制御が戻るときに、psData  は、次で定義された、**PHONESEG**型の DWORD でアラインメントされた構造体の配列を指す必要があります。

```syntax
typedef struct tagSRPHONESEG {
   DWORD   dwSize;       // Size of the SRPHONESEG structure + phone data
   QWORD   qwStartTime;  // SAPI timestamp of the start of the seqment
   …QWORD   qwEndTime;    // SAPI timestamp of the end of the seqment
   int      nScore;      // The segment's score
   WCHAR   aPhones[0];   // Array of phone(s) making up the segment
} SRPHONESEG,  *PSRPHONESEG;
```

ここで、**qwStartTime** と **qwEndTime** は、エッジでカバーされる単語を構成する各音素の先頭と末尾を指し、**aPhone** は、このセグメントで生成された電話の IPA 表現に対応する Unicode 文字の配列です。 (一部の言語では、複数の IPA 音素でスペルが設定されている音素があります。たとえば、英語では、"live" という単語の "long I" 音は、実際には 2 つの単純な音素で構成される二分音です)。**aPhones** 配列は、配列内の各 **SRPHONESEG** 構造体を 4 バイトの長さの偶数倍数にするために、末尾にゼロで終わり、埋め込む必要があります。

たとえば、アーク 4 で読み上げられた単語が "作成" されたとします。 その後、DataGet(4, **SRGARC\_PHONEMESEGMENTATION**, &sd) の呼び出しは、3 つの音素セグメントの配列を返す可能性があります。/m/ **qwStartTime**=328434 バイトから qwEndTime **=330354 バイト**まで実行されます。 /1e/ **qwStartTime**=330354 バイトから **qwEndTime**=344114 バイトまで実行され、/d/ **qwStartTime**=344114 バイトから qwEndTime **=347314 バイト**実行されます。 これらは、サイズが 28、32、28 バイトの 3 つの **SRPHONESEG** 構造体のパックされた配列として提示されます。 SRPHONESEG **構造体の中央** 末尾にパディングがあり、配列内の次の項目が 4 バイトの境界から始まることがわかります。

SAPI 4.0 SDK には、SAPI 4.0 仕様への準拠をテストするためのツール (SRFunc) が含まれています。このツールには、この一連のインターフェイスに準拠するためのテストが含まれています。 このツールのソース コードは、これらのインターフェイスがサウンド エディターとやり取りする方法を理解し、開発中にインターフェイスをデバッグするために開始するのに適した場所です。