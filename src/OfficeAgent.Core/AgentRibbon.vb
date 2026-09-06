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

    Public Sub New()
    End Sub

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
