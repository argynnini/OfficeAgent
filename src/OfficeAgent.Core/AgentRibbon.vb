Imports System.Drawing
Imports System.Drawing.Drawing2D

<Runtime.InteropServices.ComVisible(True)>
Public Class AgentRibbon
    Implements Office.IRibbonExtensibility

    Public Shared Instance As AgentRibbon
    Private ribbon As Office.IRibbonUI

    ' 各Officeアドイン（ThisAddIn_Startup）が自身の設定タスクペインの
    ' 表示状態確認／トグル処理を登録する
    Public Shared IsSettingsPaneVisibleFunc As Func(Of Boolean)
    Public Shared ToggleSettingsPaneAction As Action

    ' 選択範囲（ノート等の編集中テキスト）をSAPI5 XMLタグで挟み込む処理を、
    ' 各Officeアドインが登録する（第1引数=開始タグ、第2引数=終了タグ）
    Public Shared InsertSapiTagAction As Action(Of String, String)

    Public Sub New()
    End Sub

    ' ホストアプリに存在しないidMsoタブ（例: Word視点でのTabSlideShow/TabFormulas）への
    ' 参照は、Officeのリボンエンジンによって単に無視されるだけで実害はない（実機検証で確認済み）。
    ' そのため全ホストアプリ共通の1つのXMLをそのまま返す
    Public Function GetCustomUI(ByVal ribbonID As String) As String Implements Office.IRibbonExtensibility.GetCustomUI
        Return GetResourceText("RibbonUI.xml")
    End Function

#Region "リボンのコールバック"

    Public Sub Ribbon_Load(ByVal ribbonUI As Office.IRibbonUI)
        Me.ribbon = ribbonUI
        Instance = Me
    End Sub

    Public Sub InvalidateRibbon()
        If ribbon IsNot Nothing Then ribbon.Invalidate()
    End Sub

    ' ── 表示/終了 ──────────────────────────
    Public Function ShowHide_GetLabel(control As Office.IRibbonControl) As String
        Dim form = OfficeAgent.Core.AgentFloatingForm.Instance
        If form IsNot Nothing AndAlso form.IsCharacterVisible Then
            Return "終了"
        End If
        Return "表示"
    End Function

    Public Sub ShowHide_Click(control As Office.IRibbonControl)
        Dim form = OfficeAgent.Core.AgentFloatingForm.Instance
        If form Is Nothing Then Return
        If form.IsCharacterVisible Then
            form.HideAgent()
        Else
            form.ShowAgent()
        End If
        InvalidateRibbon()
    End Sub

    Public Function ShowHide_GetImage(control As Office.IRibbonControl) As stdole.IPictureDisp
        Dim form = OfficeAgent.Core.AgentFloatingForm.Instance
        Dim isVisible = form IsNot Nothing AndAlso form.IsCharacterVisible
        Using bmp = ShowHideIcon.Draw(isVisible)
            Return IconConverter.ToIPictureDisp(bmp)
        End Using
    End Function

    ' ── 詳細設定 ──────────────────────────
    Public Function Detail_GetPressed(control As Office.IRibbonControl) As Boolean
        Return IsSettingsPaneVisibleFunc IsNot Nothing AndAlso IsSettingsPaneVisibleFunc()
    End Function

    Public Sub Detail_Toggle(control As Office.IRibbonControl, pressed As Boolean)
        ToggleSettingsPaneAction?.Invoke()
    End Sub

    ' ── スライドショー中は非表示（PowerPointの「スライド ショー」タブ） ──────
    ' スピーカーノート読み上げ（chkSpeakSlideNotes）とは互いに機能上の競合がある
    ' （下記GetEnabled群のコメント参照）ため、読み上げがONの間はこの項目を操作不可にする
    Public Function HideDuringSlideShow_GetPressed(control As Office.IRibbonControl) As Boolean
        Return AgentSettings.HideAgentDuringSlideShow
    End Function

    Public Function HideDuringSlideShow_GetEnabled(control As Office.IRibbonControl) As Boolean
        Return Not AgentSettings.SpeakSlideNotesDuringSlideShow
    End Function

    Public Sub HideDuringSlideShow_Toggle(control As Office.IRibbonControl, pressed As Boolean)
        AgentSettings.HideAgentDuringSlideShow = pressed
    End Sub

    ' ── スライドショー中のオーバーレイ表示項目 ──────────────
    ' オーバーレイ（スライド番号／発表時間／ラップ）は、スライドが切り替わるたびに
    ' UpdateSlideShowOverlayが.StopAll()してSpeakOrThink()で読み上げる仕組みになっており、
    ' スピーカーノート読み上げ（SpeakSlideNotes、同じキャラクターの発話キューを使う）と
    ' 同時に有効だと、お互いの発話を次々と打ち切り合ってしまう。そのためスピーカーノート
    ' 読み上げがONの間は、これらのチェックボックスを操作不可（グレーアウト）にする。
    ' UI上グレーアウトするだけでなく、AgentFloatingForm.OverlayEnabled()側でも
    ' SpeakSlideNotesDuringSlideShowを見て機能的に無効化しており、以前チェックを入れたまま
    ' 読み上げをONにした場合でもオーバーレイが動かないようにしている
    Public Function ShowSlideNumber_GetPressed(control As Office.IRibbonControl) As Boolean
        Return AgentSettings.ShowSlideNumberDuringSlideShow
    End Function

    Public Function ShowSlideNumber_GetEnabled(control As Office.IRibbonControl) As Boolean
        Return Not AgentSettings.SpeakSlideNotesDuringSlideShow
    End Function

    Public Sub ShowSlideNumber_Toggle(control As Office.IRibbonControl, pressed As Boolean)
        AgentSettings.ShowSlideNumberDuringSlideShow = pressed
        OfficeAgent.Core.AgentFloatingForm.Instance?.RefreshSlideShowOverlay()
    End Sub

    Public Function ShowElapsedTime_GetPressed(control As Office.IRibbonControl) As Boolean
        Return AgentSettings.ShowElapsedTimeDuringSlideShow
    End Function

    Public Function ShowElapsedTime_GetEnabled(control As Office.IRibbonControl) As Boolean
        Return Not AgentSettings.SpeakSlideNotesDuringSlideShow
    End Function

    Public Sub ShowElapsedTime_Toggle(control As Office.IRibbonControl, pressed As Boolean)
        AgentSettings.ShowElapsedTimeDuringSlideShow = pressed
        OfficeAgent.Core.AgentFloatingForm.Instance?.RefreshSlideShowOverlay()
    End Sub

    Public Function ShowLapTime_GetPressed(control As Office.IRibbonControl) As Boolean
        Return AgentSettings.ShowLapTimeDuringSlideShow
    End Function

    Public Function ShowLapTime_GetEnabled(control As Office.IRibbonControl) As Boolean
        Return Not AgentSettings.SpeakSlideNotesDuringSlideShow
    End Function

    Public Sub ShowLapTime_Toggle(control As Office.IRibbonControl, pressed As Boolean)
        AgentSettings.ShowLapTimeDuringSlideShow = pressed
        OfficeAgent.Core.AgentFloatingForm.Instance?.RefreshSlideShowOverlay()
    End Sub

    Public Function SpeakSlideNotes_GetPressed(control As Office.IRibbonControl) As Boolean
        Return AgentSettings.SpeakSlideNotesDuringSlideShow
    End Function

    Public Sub SpeakSlideNotes_Toggle(control As Office.IRibbonControl, pressed As Boolean)
        AgentSettings.SpeakSlideNotesDuringSlideShow = pressed
        ' スライド番号／発表時間／ラップ／発表中は非表示のgetEnabledを再評価させる
        ' （getEnabledはRibbon側が自動では再ポーリングしないため、明示的な無効化が必要）
        InvalidateRibbon()
        OfficeAgent.Core.AgentFloatingForm.Instance?.RefreshSlideShowOverlay()
    End Sub

    ' 読み上げに使う音声（TTSエンジン）を選ぶには、Windows標準の「音声のプロパティ」
    ' （コントロールパネル → 音声認識 → 音声合成）を開く必要がある。新しい方の設定アプリの
    ' 音声設定には出てこない（SAPIForVOICEVOX等、旧SAPI5に登録するタイプの音声はこちらにしか
    ' 出てこないため）。コントロールパネルの階層を辿らなくて済むよう、直接ダイアログを開く
    Public Sub OpenVoiceSettings_Click(control As Office.IRibbonControl)
        Try
            Dim sapiCpl = IO.Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Windows), "System32\Speech\SpeechUX\sapi.cpl")
            Diagnostics.Process.Start("rundll32.exe", $"shell32.dll,Control_RunDLL ""{sapiCpl}"",,1")
        Catch ex As Exception
            Windows.Forms.MessageBox.Show(
                "音声設定画面を開けませんでした。" & Environment.NewLine & ex.Message,
                "OfficeAgent", Windows.Forms.MessageBoxButtons.OK, Windows.Forms.MessageBoxIcon.Warning)
        End Try
    End Sub

    ' ── SAPI5 XMLタグ挿入（PowerPointの「スライド ショー」タブ） ──────────
    ' ノートの選択範囲を、対応するSAPI5 XMLタグで挟み込む。MS Agent独自の\Vol\ \Spd\ \Pit\
    ' タグ（SAPI4時代の記法）はSAPI5エンジンには無視されるため使わない。既定値は選択後に
    ' 手で書き換えることを想定した目安の値
    Public Sub InsertVolumeTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<volume level=""50"">", "</volume>")
    End Sub

    Public Sub InsertRateTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<rate speed=""5"">", "</rate>")
    End Sub

    Public Sub InsertPitchTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<pitch middle=""5"">", "</pitch>")
    End Sub

    Public Sub InsertSilenceTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<silence msec=""500""/>", "")
    End Sub

    Public Sub InsertCommentTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<!-- ", " -->")
    End Sub

    Public Sub InsertSpellTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<spell>", "</spell>")
    End Sub

    Public Sub InsertEmphTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<emph>", "</emph>")
    End Sub

    ' ── 発話中操作タグ挿入（PowerPointの「スライド ショー」タブ） ──────────
    ' <agent>／<slide>／<screen>は自作の記法（SAPI標準タグではない）。ノート読み上げ時に
    ' AgentFloatingForm.ExtractSlideNoteActionsがSAPIの<bookmark mark="N"/>へ変換し、発話中に
    ' そのマークへ到達したタイミングでスライド操作・エージェント操作を実行する
    Public Sub InsertActionSlideClickTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<slide op=""click"" dir=""next""/>", "")
    End Sub

    Public Sub InsertActionSlideClickPrevTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<slide op=""click"" dir=""prev""/>", "")
    End Sub

    Public Sub InsertActionSlidePageTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<slide op=""page"" dir=""next""/>", "")
    End Sub

    Public Sub InsertActionSlidePagePrevTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<slide op=""page"" dir=""prev""/>", "")
    End Sub

    Public Sub InsertActionSlidePageGotoTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<slide dir=""1""/>", "")
    End Sub

    Public Sub InsertActionAgentMoveTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<agent op=""move"" x=""100"" y=""100"" speed=""1000""/>", "")
    End Sub

    Public Sub InsertActionAgentGestureAtTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<agent op=""gesture"" x=""100"" y=""100""/>", "")
    End Sub

    Public Sub InsertActionAgentPlayTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<agent op=""play"" name=""Wave""/>", "")
    End Sub

    Public Sub InsertActionAgentShowTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<agent op=""show""/>", "")
    End Sub

    Public Sub InsertActionAgentHideTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<agent op=""hide""/>", "")
    End Sub

    Public Sub InsertActionBalloonShowTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<balloon op=""show""/>", "")
    End Sub

    Public Sub InsertActionBalloonHideTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<balloon op=""hide""/>", "")
    End Sub

    Public Sub InsertActionBalloonStyleTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<balloon op=""style"" size=""12"" font="""" width=""40""/>", "")
    End Sub

    Public Sub InsertActionBlackoutTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<screen op=""blackout""/>", "")
    End Sub

    Public Sub InsertActionWhiteoutTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<screen op=""whiteout""/>", "")
    End Sub

    Public Sub InsertActionScreenResumeTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<screen op=""resume""/>", "")
    End Sub

    Public Sub InsertActionLaserOnTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<laser op=""on""/>", "")
    End Sub

    Public Sub InsertActionLaserOffTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<laser op=""off""/>", "")
    End Sub

    Public Sub InsertActionBreakTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<agent op=""break""/>", "")
    End Sub

    Public Sub InsertActionWaitTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<agent op=""wait"" ms=""1000""/>", "")
    End Sub

    ' ── 変数タグ挿入（PowerPointの「スライド ショー」タブ） ──────────
    ' <var name="..."/>は自作の記法。ノート読み上げ時にAgentFloatingForm.ResolveVariablesが
    ' 実際の値（スライド番号・時刻等）に置き換えてからSpeak()へ渡す
    Public Sub InsertVarSlideNumberTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<var name=""slideNumber""/>", "")
    End Sub

    Public Sub InsertVarSlideCountTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<var name=""slideCount""/>", "")
    End Sub

    Public Sub InsertVarSlidesRemainingTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<var name=""slidesRemaining""/>", "")
    End Sub

    Public Sub InsertVarFileNameTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<var name=""fileName""/>", "")
    End Sub

    Public Sub InsertVarSlideTitleTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<var name=""slideTitle""/>", "")
    End Sub

    Public Sub InsertVarSectionNameTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<var name=""sectionName""/>", "")
    End Sub

    Public Sub InsertVarAuthorTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<var name=""author""/>", "")
    End Sub

    Public Sub InsertVarTimeTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<var name=""time""/>", "")
    End Sub

    Public Sub InsertVarDateTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<var name=""date""/>", "")
    End Sub

    Public Sub InsertVarElapsedTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<var name=""elapsed""/>", "")
    End Sub

    Public Sub InsertVarLapTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<var name=""lap""/>", "")
    End Sub

    Public Sub InsertVarUserNameTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<var name=""userName""/>", "")
    End Sub

    Public Sub InsertVarComputerNameTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<var name=""computerName""/>", "")
    End Sub

    Public Sub InsertVarAgentNameTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<var name=""agentName""/>", "")
    End Sub

    Public Sub InsertVarAgentDescriptionTag_Click(control As Office.IRibbonControl)
        InsertSapiTagAction?.Invoke("<var name=""agentDescription""/>", "")
    End Sub

    ' ── 数式エラー検知（Excelの「数式」タブ） ──────────────
    Public Function FormulaErrorDetection_GetPressed(control As Office.IRibbonControl) As Boolean
        Return OfficeAgent.Core.AnimationEvents.GetSetting("FormulaError", AgentSettings.CharacterId).Enabled
    End Function

    Public Sub FormulaErrorDetection_Toggle(control As Office.IRibbonControl, pressed As Boolean)
        Dim current = OfficeAgent.Core.AnimationEvents.GetSetting("FormulaError", AgentSettings.CharacterId)
        OfficeAgent.Core.AnimationEvents.SaveAll(
            New List(Of (EventKey As String, Enabled As Boolean, Animation As String)) From {
                ("FormulaError", pressed, current.Animation)
            }, AgentSettings.CharacterId)
    End Sub

#End Region

#Region "ヘルパー"

    Private Shared Function GetResourceText(ByVal resourceName As String) As String
        Dim asm As Reflection.Assembly = Reflection.Assembly.GetExecutingAssembly()
        For Each candidate In asm.GetManifestResourceNames()
            If candidate.EndsWith("." & resourceName, StringComparison.OrdinalIgnoreCase) Then
                Using resourceReader As New IO.StreamReader(asm.GetManifestResourceStream(candidate))
                    Return resourceReader.ReadToEnd()
                End Using
            End If
        Next
        Return Nothing
    End Function

#End Region

End Class

' Bitmap → IPictureDisp（リボンボタンのgetImageコールバックに渡す形式）への変換に使う
Friend NotInheritable Class IconConverter
    Inherits Windows.Forms.AxHost

    Private Sub New()
        MyBase.New("")
    End Sub

    Public Shared Function ToIPictureDisp(image As Image) As stdole.IPictureDisp
        Return CType(GetIPictureDispFromPicture(image), stdole.IPictureDisp)
    End Function

End Class

' 表示/終了ボタン用のアイコンをコードで描画する（画像ファイル不要）
Friend NotInheritable Class ShowHideIcon

    Public Shared Function Draw(isVisible As Boolean) As Bitmap
        Dim bmp As New Bitmap(32, 32)
        Using g = Graphics.FromImage(bmp)
            g.SmoothingMode = Drawing2D.SmoothingMode.AntiAlias
            g.Clear(Color.Transparent)

            If isVisible Then
                ' 終了（クリックで非表示にする）… 赤丸に停止アイコン
                Using brush As New SolidBrush(Color.FromArgb(196, 43, 28))
                    g.FillEllipse(brush, 1, 1, 30, 30)
                End Using
                Using brush As New SolidBrush(Color.White)
                    g.FillRectangle(brush, 11, 11, 10, 10)
                End Using
            Else
                ' 表示（クリックで表示する）… 緑丸に再生アイコン
                Using brush As New SolidBrush(Color.FromArgb(16, 124, 16))
                    g.FillEllipse(brush, 1, 1, 30, 30)
                End Using
                Using brush As New SolidBrush(Color.White)
                    g.FillPolygon(brush, {New PointF(11, 8), New PointF(11, 24), New PointF(25, 16)})
                End Using
            End If
        End Using
        Return bmp
    End Function

End Class
