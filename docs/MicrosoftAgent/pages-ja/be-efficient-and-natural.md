---
layout: Conceptual
title: 効率的で自然なものにする - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/be-efficient-and-natural
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: 効率的で自然なものにする
document_id: 506afb58-82c2-720e-fc99-7f2a530fe993
document_version_independent_id: eede3f5d-a866-c051-aa72-9078494c9122
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/be-efficient-and-natural.md
locale: ja-jp
ms.assetid: 6642b41c-1833-41be-9de2-ef091cefaa45
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/be-efficient-and-natural.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:37:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/be-efficient-and-natural.md
page_type: conceptual
toc_rel: toc.json
word_count: 1343
asset_id: lwef/be-efficient-and-natural
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/97159432-14a9-4307-a469-d2f2c75f0e33
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/50565c62-5f6b-4687-be38-323113c72c2e
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 6ffcc7ce-cc5b-3bf4-ee55-8e3fffabcf0e
---

# 効率的で自然なものにする - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

タスクを実行する場合、効果的な人間の会話は通常、簡単な情報の交換です。 多くの場合、ディスカッション内の要素は当事者間で確立され、省略された応答を使用して間接的に参照されます。 これらの省略形は効率的であり、話者とリスナーが共通のコンテキストを持っていることを意味するため、有益です。つまり、通信しているということです。 適切な形の省略形を使用すると、対話がより自然になります。

会話の省略形の 1 つの形式は、縮小の使用です。 彼らは使用されていないとき、彼らは話者をより正式で堅く見せ、時には人間を減らします。 ほとんどの人間の会話では、書かれたテキストよりも言語ルールの自由度が高くなります。

会話の略語のもう 1 つの一般的な形式は、代名詞の使用 *であるアナフォラ*です。 たとえば、誰かが「今日ビルを見たことがありますか」と尋ねると、"彼" を "Bill" に置き換える応答は、名前をもう一度繰り返すよりも自然です。 この交代は、対話の当事者が「彼」が *誰であるか* の共通の文脈を共有する手掛かりです。 "I" という単語は、彼または彼女が言うときの文字を指します。

共有コンテキストは、言語的 *省略記号*を使用して伝達されます。これは、元のクエリの多くの単語の切り捨てです。 たとえば、リスナーは "はい、彼を見ました" と応答し、*誰*と*いつ*の共有コンテキストを示す単純な "はい" で応答する*場合*の共有コンテキストを示します。

暗黙的な理解は、次の例に示すように、他の形式の省略形の会話スタイルを通じて伝達することもできます。ここで、コンテンツは繰り返しなしで推論されます。

**ユーザー：** シカゴ風のピザをお願いします。

**文字：** 「エクストラチーズ」では?

同様に、誰かが「ここで暑い」と言った場合、フレーズは理解可能であり、話者がどこにいるか知っていれば、それ以上の詳細は必要ありません。 ただし、コンテキストが適切に確立されていない場合やあいまいな場合は、すべてのコンテキスト参照を排除すると、ユーザーが混乱する可能性があります。

短縮通信を使用する場合は、常にユーザーのコンテキストとコンテンツの種類を考慮してください。 新しくなじみのない情報には、長い説明を使用するのが適切です。 ただし、長い説明情報であっても、小さなチャンクに分割してみてください。 これにより、キャラクターが話すときにアニメーションを変更できます。 また、特に音声入力を使用する場合に、ユーザーが文字を中断する機会も大きくなります。

音声出力では一貫性が重要です。 奇妙な音声パターンやプロソディは、文字のインテリジェンスをダウングレードすると解釈される場合があります。 同様に、TTS と録音された音声を切り替えると、ユーザーはキャラクターを奇妙なものとして解釈したり、複数の個性を持ったりする可能性があります。 口の動きをリップ同期すると、音声の明瞭度が向上します。 Microsoft エージェントは、必要な SAPI インターフェイスに準拠する TTS エンジンのリップ同期を自動的にサポートします。 ただし、リップ同期は、録音された音声でもサポートされています。 サウンド ファイルは、Microsoft 言語サウンド編集ツールを使用して拡張することもできます。