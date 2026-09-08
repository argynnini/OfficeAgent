---
layout: Conceptual
title: 文字 - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/characters
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: 文字
document_id: c752ea01-1911-763a-82fe-701a5cf24b5a
document_version_independent_id: 765bc70b-b608-98e2-c40c-bb781a3e50b9
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: 641bad19094f7ca28b1ddcc95c05d2f9e5f169f1
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/641bad19094f7ca28b1ddcc95c05d2f9e5f169f1/desktop-src/lwef/characters.md
locale: ja-jp
ms.assetid: d3eac94b-7899-4695-b0e5-0276c1f5e9cb
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/characters.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:38:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/characters.md
page_type: conceptual
toc_rel: toc.json
word_count: 1703
asset_id: lwef/characters
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
platformId: 018bea25-d257-58b2-613c-8d0cd266dc6e
---

# 文字 - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

人間のコミュニケーションは基本的に社会的です。 Microsoft エージェントを使用すると、アニメーション化されたキャラクターを使用して、この相互作用の側面を活用できます。 ユーザーは、キャラクターが合成であることを理解している場合でも、他のユーザーとやり取りするときに使用する物理的なルールとは限りませんが、同じソーシャルにキャラクターが準拠することを期待します。 期待に応えるキャラクターを作成する範囲で、ユーザーは自分のキャラクターをより信じがちで好きだと感じるでしょう。 したがって、キャラクターをどのように設計するかは、その成功に大きな影響を与える可能性があります。

キャラクターをデザインするときは、まず対象ユーザーのプロファイルと、そのユーザーに対してどのような魅力を持ち、どのようなタスクを行うかを検討します。 同様に、サポートされているアプリケーションに加えて、キャラクターのデザインとスタイルが目的とどの程度一致しているかを検討します。 たとえば、犬の文字は、全体的な外観に応じて、取得やセキュリティ アプリケーションに適している場合があります。 多くの場合、成功は詳細にあります。 研究は、動物のキャラクターの目と耳の形の丸みを変えることで、キャラクターに対して非常に異なる反応を生み出すことができることを示しています。

また、あなたのキャラクターの基本的な性格のタイプを考慮してください:ドミナントまたは従順、感情的または予約的、洗練された、または地球にダウン。または、ユーザーの操作に基づいてその個性を調整したい場合があります。 たとえば、ユーザーがキャラクターの情報を増やすか、質問されるのを待つのかを調整できるようにするコントロールを提供できます。 前者は後者よりも発信的です。

文字に指定する名前は、特定の種類の個性を推測できます。 たとえば、"Max" と "Linus" は、非常に異なる個性を伝える場合があります。 Microsoft エージェント文字エディターを使用すると、文字の名前を設定し、簡単な説明を含めることができます。 これらの属性は、実行時に照会できます。

さらに、合成音声 (テキスト読み上げエンジンを使用) を使用するか、録音された音声 (.WAV ファイル)。 この決定は、使用する文字の種類、サポートする予定の言語、および文字の言い分によって異なる場合があります。 たとえば、合成された音声を使用すると、キャラクターはほとんど何でも言うことができます。 あなたのキャラクターが言うことをプログラミングすることは簡単で迅速です:あなたは文字が話すテキストを提供するだけです。 ただし、コンピューターで生成された音声エンジンを使用するには、初期インストールに余分なオーバーヘッドが必要であり、言語固有になります。 さらに、最も合成された音声はコンピュータによって生成される。彼らはほとんどの人間のスピーチの明確さとプロソディに一致しません。 既に ID が確立されているキャラクターや、非常に特徴的な音声を持つキャラクターを使用する場合は、キャラクターに一致する音声をシミュレートすることは困難な場合があります。 このような場合は、録音された音声ファイルを出力に使用できます。 Microsoft エージェントでは、録音された音声出力のリップ同期もサポートされています。 オーディオ ファイルは自然な音声を提供し、他の言語で簡単に実装できますが、ローカル コンピューターにコピーまたはダウンロードする必要があります。 録音された音声ファイルでは、文字が含まれるボキャブラリに制限されます。 合成音声出力と録音音声出力のどちらを選択した場合でも、音声には、話者の性別、年齢、個性に関する追加のソーシャル情報が含まれている点に注意してください。

また、出力には吹き出しという単語を使用し、バルーンのフォントと色には既定の設定を使用することもできます。 ただし、ユーザーはフォントと色の属性を変更できることに注意してください。 また、ユーザーは吹き出しをオフにできるため、吹き出しという単語の状態が一定のままであるとは想定できません。