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
    Public Function HideDuringSlideShow_GetPressed(control As Office.IRibbonControl) As Boolean
        Return AgentSettings.HideAgentDuringSlideShow
    End Function

    Public Sub HideDuringSlideShow_Toggle(control As Office.IRibbonControl, pressed As Boolean)
        AgentSettings.HideAgentDuringSlideShow = pressed
    End Sub

    ' ── スライドショー中のオーバーレイ表示項目 ──────────────
    Public Function ShowSlideNumber_GetPressed(control As Office.IRibbonControl) As Boolean
        Return AgentSettings.ShowSlideNumberDuringSlideShow
    End Function

    Public Sub ShowSlideNumber_Toggle(control As Office.IRibbonControl, pressed As Boolean)
        AgentSettings.ShowSlideNumberDuringSlideShow = pressed
        OfficeAgent.Core.AgentFloatingForm.Instance?.RefreshSlideShowOverlay()
    End Sub

    Public Function ShowElapsedTime_GetPressed(control As Office.IRibbonControl) As Boolean
        Return AgentSettings.ShowElapsedTimeDuringSlideShow
    End Function

    Public Sub ShowElapsedTime_Toggle(control As Office.IRibbonControl, pressed As Boolean)
        AgentSettings.ShowElapsedTimeDuringSlideShow = pressed
        OfficeAgent.Core.AgentFloatingForm.Instance?.RefreshSlideShowOverlay()
    End Sub

    Public Function ShowLapTime_GetPressed(control As Office.IRibbonControl) As Boolean
        Return AgentSettings.ShowLapTimeDuringSlideShow
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
