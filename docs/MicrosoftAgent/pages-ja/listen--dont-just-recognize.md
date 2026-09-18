---
layout: Conceptual
title: リッスン、単に認識しない - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/listen--dont-just-recognize
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: リッスン、単に認識しない
document_id: 8be9e38d-149a-454a-b78e-af24e664e8f1
document_version_independent_id: 6f395e5b-7607-a53c-0a9b-57694303bad2
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: fd5b414bbed38784ccf90c12b7bbe416fe7710ed
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/fd5b414bbed38784ccf90c12b7bbe416fe7710ed/desktop-src/lwef/listen--dont-just-recognize.md
locale: ja-jp
ms.assetid: 74bb2122-98c1-4a51-b894-93e1481aa46b
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/listen--dont-just-recognize.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:54:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/listen--dont-just-recognize.md
page_type: conceptual
toc_rel: toc.json
word_count: 1082
asset_id: lwef/listen--dont-just-recognize
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 9a602a0e-0c39-c9a2-7ba2-f5fcf652f268
---

# リッスン、単に認識しない - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

コミュニケーションの成功には、単語の認識以上のものがあります。 対話のプロセスは、ターンテイクと理解を示すために手掛かりを交換することを意味します。 キャラクターは、頭の傾き、うなずき、シェイクなどの手掛かりを提供して、音声エンジンがいつリスニング状態にあり、何かが認識されるかを示すことによって、会話インターフェイスを改善できます。 たとえば、Microsoft エージェントは、ユーザーがプッシュツートークリスニングキーを押したときに **リスニング** 状態に割り当てられたアニメーションと、発話が検出されたときに **のヒアリング** 状態に割り当てられたアニメーションを再生します。 独自のキャラクターを定義するときは、これらの状態に適切なアニメーションを作成して割り当てるようにしてください。 文字の設計の詳細については、「[Microsoft Agent](designing-characters-for-microsoft-agent)の文字の設計」を参照してください。

会話には、言葉以外の手掛かりに加えて、会話を行う当事者間の共通のコンテキストが含まれます。 同様に、コンテキストが適切に確立されると、文字を含む音声入力シナリオが成功する可能性が高くなります。 コンテキストを確立すると、"check's in the mail" や "check my mail" などの類似の音声フレーズをより適切に解釈できます。また、アプリケーションが最後に実行したアクションなど、現在のコンテキストを再指定して応答するコマンド ("ヘルプ" や "Where am I" など) を指定して、ユーザーがコンテキストに対してクエリを実行できるようにすることもできます。

Microsoft Agent には、音声認識エンジンによって返される最適な一致と次に最適な 2 つの代替手段にアクセスできるインターフェイスが用意されています。 さらに、すべての一致の信頼度スコアにアクセスできます。 この情報を使用して、話された内容をより適切に判断できます。 たとえば、最適な一致と最初の代替の信頼度スコアが近い場合は、音声エンジンがそれらの違いを識別するのが困難であることを示している可能性があります。 このような場合は、パフォーマンスを向上させるために、要求を繰り返すか言い換えるかをユーザーに依頼することができます。 ただし、最適な一致と 1 番目または 2 番目の代替が同じコマンドを返す場合は、正しい認識の表示が強化されます。

会話や会話の性質は、話された入力に対する応答が必要であることを意味します。 したがって、ユーザーの入力は、アクションが実行されたか、問題が発生したことを示す、または適切な応答を提供する、口頭または視覚的なフィードバックで常に応答する必要があります。