---
layout: Conceptual
title: IAgentCharacter SetSoundEffectsOn - Win32 apps | Microsoft Learn
canonicalUrl: https://learn.microsoft.com/ja-jp/windows/win32/lwef/iagentcharacter--setsoundeffectson
schema: Conceptual
adobe-target: true
author: GrantMeStrength
breadcrumb_path: /windows/desktop/breadcrumb/toc.json
depot_name: MSDN.win32
description: IAgentCharacter SetSoundEffectsOn
document_id: 27dcbc99-28a7-2b2b-fa1e-7c9cd61a1095
document_version_independent_id: 5b2af90e-1eb2-1831-0a97-141894045696
feedback_help_link_type: get-help-at-qna
feedback_help_link_url: https://learn.microsoft.com/answers/tags/224/windows-api-win32/
feedback_product_url: https://www.microsoft.com/en-us/windowsinsider/feedbackhub/fb
feedback_system: Standard
git_commit_id: cb17de026a5ce979e7fbeed83f48318a1b1aed70
gitcommit: https://github.com/MicrosoftDocs/win32-pr/blob/cb17de026a5ce979e7fbeed83f48318a1b1aed70/desktop-src/lwef/iagentcharacter--setsoundeffectson.md
locale: ja-jp
ms.assetid: 141dd9a8-5fd8-42c6-880a-856c61cb8940
ms.author: jken
ms.date: 2018-05-31T00:00:00.0000000Z
ms.service: windows-api-desktop-tech
ms.subservice: desktop-environment
ms.topic: reference
original_content_git_url: https://github.com/MicrosoftDocs/win32-pr/blob/live/desktop-src/lwef/iagentcharacter--setsoundeffectson.md
recommendations: true
site_name: Docs
uhfHeaderId: MSDocsHeader-WinDevCenter
updated_at: 2026-07-05T22:47:00.0000000Z
ms.translationtype: MT
ms.contentlocale: ja-jp
loc_version: 2023-06-12T04:01:50.7691235Z
loc_source_id: Github-175691945#live
loc_file_id: Github-175691945.live.MSDN.win32.lwef/iagentcharacter--setsoundeffectson.md
page_type: conceptual
toc_rel: toc.json
word_count: 347
asset_id: lwef/iagentcharacter--setsoundeffectson
item_type: Content
cmProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/bcbcbad5-4208-4783-8035-8481272c98b8
- https://authoring-docs-microsoft.poolparty.biz/devrel/caec7b7f-4941-4578-b79f-c63b1c1f5af4
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/96407ebd-b9e6-40db-9488-063e1af76a01
spProducts:
- https://authoring-docs-microsoft.poolparty.biz/devrel/43b2e5aa-8a6d-4de2-a252-692232e5edc8
- https://authoring-docs-microsoft.poolparty.biz/devrel/754dea88-f800-4835-b6b5-280cb5d81e88
- https://microsoft-devrel.poolparty.biz/DevRelOfferingOntology/8af61fb5-33c5-4523-b00a-7a42d7bbe9cd
platformId: 425179fb-5546-02f0-6530-faae3447aca1
---

# IAgentCharacter SetSoundEffectsOn - Win32 apps | Microsoft Learn

[Microsoft エージェントは Windows 7 の時点で非推奨となり、以降のバージョンの Windows では使用できない可能性があります。]

```syntax
HRESULT SetSoundEffectsOn(
   long bOn  // character sound effects setting 
);
```

キャラクターのサウンド エフェクトを再生するかどうかを決定します。

- 操作が成功したことを示すS\_OKを返します。

- *bOn*
    - サウンド エフェクトの設定。 このパラメーターが True 場合、アニメーションの再生時にアニメーションのサウンド エフェクトが再生されます。false 場合、サウンド エフェクトは再生されません。

この設定は、関連するアニメーションを再生するときに、キャラクターの一部としてコンパイルされたサウンド エフェクトを再生するかどうかを決定します。 このプロパティの設定は、文字のすべてのクライアントに適用されます。 また、この設定は、[**IAgentAudioOutputProperties::GetUsingSoundEffects**](iagentaudiooutputproperties--getusingsoundeffects)のユーザーのグローバルサウンドエフェクト設定の対象となります。