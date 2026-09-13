' Office97のVBAオブジェクトモデルにあった Assistant.Animation プロパティ用の列挙
' （MsoAnimationType）の実数値。MSO97.DLLのtypelibリソースを解析して確定した。
' 実機（DOLPHIN.ACT）でアクション番号を1つずつ目視確認した結果、Office97のAssistantは
' キャラクターごとの変換テーブルを持たず、この数値をそのまま.actのPlayActionのアクションIDとして
' 渡していたことが判明した（例：msoAnimationThinking=24を指定するとアクション24番が再生される）。
' そのためOfficeAgentの.actキャラクターでも、この数値をそのままアクションIDとして扱う
Public Enum MsoAnimationType
    msoAnimationIdle = 1
    msoAnimationGreeting = 2
    msoAnimationGoodbye = 3
    msoAnimationBeginSpeaking = 4
    msoAnimationCharacterSuccessMajor = 6
    msoAnimationGetAttentionMajor = 11
    msoAnimationGetAttentionMinor = 12
    msoAnimationSearching = 13
    msoAnimationPrinting = 18
    msoAnimationGestureRight = 19
    msoAnimationWritingNotingSomething = 22
    msoAnimationWorkingAtSomething = 23
    msoAnimationThinking = 24
    msoAnimationSendingMail = 25
    msoAnimationListensToComputer = 26
    msoAnimationDisappear = 31
    msoAnimationAppear = 32
    msoAnimationGetArtsy = 100
    msoAnimationGetTechy = 101
    msoAnimationGetWizardy = 102
    msoAnimationCheckingSomething = 103
    msoAnimationLookDown = 104
    msoAnimationLookDownLeft = 105
    msoAnimationLookDownRight = 106
    msoAnimationLookLeft = 107
    msoAnimationLookRight = 108
    msoAnimationLookUp = 109
    msoAnimationLookUpLeft = 110
    msoAnimationLookUpRight = 111
    msoAnimationSaving = 112
    msoAnimationGestureDown = 113
    msoAnimationGestureLeft = 114
    msoAnimationGestureUp = 115
    msoAnimationEmptyTrash = 116
End Enum
