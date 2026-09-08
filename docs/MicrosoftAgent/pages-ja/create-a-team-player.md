---
layout: Conceptual
title: チーム プレーヤーを作成する - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/create-a-team-player
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: チーム プレーヤーを作成する
document_id: 0eaa9700-1457-d337-48cc-4d6704647ae5
document_version_independent_id: 76a20a5f-69ba-926b-077d-c305a1a60e9c
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/create-a-team-player.md
locale: ja-jp
ms.assetid: a252dd9d-69bf-4348-bf59-1ac97faaa3eb
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: how-to
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/create-a-team-player.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:39:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/create-a-team-player.md
page_type: conceptual
toc_rel: toc.json
word_count: 1141
asset_id: lwef/create-a-team-player
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/63959238-cb90-4871-a33d-4a5519097e47
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/78d87f42-5582-4a6b-90be-7db2f12b34e6
platformId: 7b85774a-b806-587b-164e-12a0a7faaeb4
---

# チーム プレーヤーを作成する - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない場合があります。]

チームが作成されると、グループのダイナミクスはグループ内のメンバーに強力な影響を及ぼす。 まず、グループまたはチームコンテキストのユーザーは、チーム以外の設定で通常よりもチームの他のユーザーとより多くを識別する傾向があります。 その結果、チーム外のチームメンバーよりもチームメイトとの識別も可能になります。 しかし、同様に重要なのは、チームのメンバーが協力し、彼らの態度や行動を変更することをより多くの意思で行っています。 チームの社会的ダイナミクスはメンバーの相互作用に影響を与えるので、キャラクターとの対話を設計する際に考慮すると便利です。

チーム感覚の作成には、ID と相互依存という 2 つの要素が含まれます。 ID を作成するには、ユーザーとキャラクターが共有するチーム名、色、シンボル、またはその他の識別子を作成します。 たとえば、ユーザーが自分のコンピューターに貼り付けることができるステッカーを提供したり、ユーザーがキャラクターと一緒に表示されるチーム名やアイコンを選ぶようにしたりすることができます。 チーム ID は、キャラクターの言う内容によって確立される場合もあります。 たとえば、キャラクターが自身をパートナーとして、またはユーザーと自身をチームとして参照するようにすることができます。

相互依存は、チーム ID よりも社会的影響が強いように見えるので考慮することが重要ですが、相互依存は実装が困難であるか、確立に時間がかかる場合があります。 これは、マーケティング組織が確立に努める製品ブランドのロイヤルティによって示されています。 相互依存の感覚を作成するには、ユーザーの継続的な有用性と信頼性を示す必要があります。 回答すべき重要な質問は、"文字は価値を提供しますか?" と "キャラクターは予測可能性を確実に動作させるか" です。ここでの重要な要素は、キャラクターとユーザーとの関係がどのように確立されるかです。 チーム間の依存感を生み出すには、ユーザーとのピアとして文字を提示する必要があります。 一部のシナリオでは、キャラクターを専門家または僕として提示するのに役立つ場合がありますが、チーム ダイナミクスの共同作業の利点を活用するには、劣等感を持たずにユーザーがキャラクターに依存できる等しい感覚が必要です。 これは、キャラクターがウィザードとしてではなく、チームメイトまたはコンパニオンとして自分自身を参照するのと同じくらい簡単な場合があります。 また、文字がユーザーに情報を要求する方法によっても影響を受ける可能性があります。 たとえば、"この質問に答えるために一緒に作業しましょう" という文字があるとします。