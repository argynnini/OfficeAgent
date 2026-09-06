Imports OfficeAgent.Core

Partial Public Class ThisAddIn

    Private _agentForm As OfficeAgent.Core.AgentFloatingForm
    Private _settingsTaskPane As Microsoft.Office.Tools.CustomTaskPane

    Protected Overrides Function CreateRibbonExtensibilityObject() As Microsoft.Office.Core.IRibbonExtensibility
        Return New AgentRibbon()
    End Function

    Private Sub ThisAddIn_Startup() Handles Me.Startup
        OfficeAgent.Core.AssemblyRedirectHelper.EnsureRegistered()

        _agentForm = New OfficeAgent.Core.AgentFloatingForm()
        _agentForm.Show()

        Dim pane As New OfficeAgent.Core.AgentSettingsPane() With {.HostApp = AnimationEvents.HostApp.Excel}
        _settingsTaskPane = Me.CustomTaskPanes.Add(pane, "OfficeAgent 設定")
        _settingsTaskPane.Width = 260
        _settingsTaskPane.Visible = False
        AddHandler _settingsTaskPane.VisibleChanged, AddressOf SettingsPane_VisibleChanged

        OfficeAgent.Core.AgentFloatingForm.OpenSettingsPaneAction = AddressOf ShowSettingsPane
        OfficeAgent.Core.AgentFloatingForm.GetSelectedTextAction = AddressOf GetSelectedText
        AgentRibbon.IsSettingsPaneVisibleFunc = Function() IsSettingsPaneVisible
        AgentRibbon.ToggleSettingsPaneAction = AddressOf ToggleSettingsPane

        AddHandler Me.Application.WorkbookBeforeSave, AddressOf OnBeforeSave
        AddHandler Me.Application.WorkbookAfterSave, AddressOf OnAfterSave
        AddHandler Me.Application.WorkbookBeforePrint, AddressOf OnBeforePrint
        AddHandler Me.Application.NewWorkbook, AddressOf OnOpen
        AddHandler Me.Application.WorkbookOpen, AddressOf OnOpen
        AddHandler Me.Application.WorkbookBeforeClose, AddressOf OnBeforeClose
        AddHandler Me.Application.ProtectedViewWindowOpen, AddressOf OnProtectedViewWindowOpen
        AddHandler Me.Application.WorkbookNewSheet, AddressOf OnWorkbookNewSheet
        AddHandler Me.Application.WindowActivate, AddressOf OnWindowActivateOrDeactivate
    End Sub

    Public ReadOnly Property IsSettingsPaneVisible As Boolean
        Get
            If _settingsTaskPane Is Nothing Then Return False
            Try
                Return _settingsTaskPane.Visible
            Catch ex As ObjectDisposedException
                Return False
            End Try
        End Get
    End Property

    Public Sub ToggleSettingsPane()
        If _settingsTaskPane Is Nothing Then Return
        Try
            If Not _settingsTaskPane.Visible Then
                DirectCast(_settingsTaskPane.Control, OfficeAgent.Core.AgentSettingsPane).LoadSettings()
                _settingsTaskPane.Visible = True
            Else
                _settingsTaskPane.Visible = False
            End If
        Catch ex As ObjectDisposedException
            _settingsTaskPane = Nothing
        End Try
    End Sub

    ' カイル右クリックの「設定」から呼ばれる：閉じていれば開くだけ（トグルしない）
    Public Sub ShowSettingsPane()
        If _settingsTaskPane Is Nothing Then Return
        Try
            DirectCast(_settingsTaskPane.Control, OfficeAgent.Core.AgentSettingsPane).LoadSettings()
            _settingsTaskPane.Visible = True
        Catch ex As ObjectDisposedException
            _settingsTaskPane = Nothing
        End Try
    End Sub

    Private Sub SettingsPane_VisibleChanged(sender As Object, e As EventArgs)
        AgentRibbon.Instance?.InvalidateRibbon()
    End Sub

    ' 選択範囲として渡す最大セル数（巨大な範囲選択時にAIへの送信量を抑えるため）
    Private Const MaxSelectedCells As Integer = 500

    ' カイル右クリックの「選択範囲について」から呼ばれる：現在選択中のセル範囲をタブ区切りテキストにして返す
    ' （未選択・空・セル範囲以外の選択ならNothing）
    Private Function GetSelectedText() As String
        Try
            Dim range = TryCast(Me.Application.Selection, Microsoft.Office.Interop.Excel.Range)
            If range Is Nothing Then Return Nothing
            If range.Cells.Count > MaxSelectedCells Then Return Nothing

            Dim sb As New System.Text.StringBuilder()
            For Each row In range.Rows
                Dim rowRange = DirectCast(row, Microsoft.Office.Interop.Excel.Range)
                Dim cellTexts = New List(Of String)
                For Each cell In rowRange.Cells
                    cellTexts.Add(DirectCast(cell, Microsoft.Office.Interop.Excel.Range).Text.ToString())
                Next
                sb.AppendLine(String.Join(vbTab, cellTexts))
            Next

            Dim text = sb.ToString().Trim()
            Return If(text.Length = 0, Nothing, text)
        Catch ex As Exception
            Return Nothing
        End Try
    End Function

    Private Sub OnBeforeSave(wb As Microsoft.Office.Interop.Excel.Workbook, saveAsUI As Boolean, ByRef cancel As Boolean)
        ' If _agentForm IsNot Nothing Then _agentForm.PlayAnimation("GetAttention")
    End Sub

    Private Sub OnAfterSave(wb As Microsoft.Office.Interop.Excel.Workbook, success As Boolean)
        If success AndAlso Not WindowHelper.IsAutoSaveOn(wb) AndAlso _agentForm IsNot Nothing Then _agentForm.PlayConfiguredAnimation("Save")
    End Sub

    Private Sub OnBeforePrint()
        If _agentForm IsNot Nothing Then _agentForm.PlayConfiguredAnimation("Print")
    End Sub

    Private Sub OnOpen(wb As Microsoft.Office.Interop.Excel.Workbook)
        If _agentForm IsNot Nothing Then _agentForm.PlayConfiguredAnimation("Open")
    End Sub

    Private Sub OnBeforeClose(wb As Microsoft.Office.Interop.Excel.Workbook, ByRef cancel As Boolean)
        If _agentForm IsNot Nothing Then _agentForm.PlayConfiguredAnimation("Close")
    End Sub

    Private Sub OnProtectedViewWindowOpen(pvw As Microsoft.Office.Interop.Excel.ProtectedViewWindow)
        If _agentForm IsNot Nothing Then _agentForm.PlayConfiguredAnimation("ProtectedViewWindowOpen")
    End Sub

    Private Sub OnWorkbookNewSheet(wb As Microsoft.Office.Interop.Excel.Workbook, sh As Object)
        If _agentForm IsNot Nothing Then _agentForm.PlayConfiguredAnimation("WorkbookNewSheet")
    End Sub

    Private Sub OnWindowActivateOrDeactivate(wb As Microsoft.Office.Interop.Excel.Workbook, wn As Microsoft.Office.Interop.Excel.Window)
        If _agentForm IsNot Nothing Then _agentForm.PlayLookAnimationTowardWindow(New IntPtr(CInt(wn.Hwnd)))
    End Sub

    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown
        OfficeAgent.Core.AgentFloatingForm.OpenSettingsPaneAction = Nothing
        OfficeAgent.Core.AgentFloatingForm.GetSelectedTextAction = Nothing
        AgentRibbon.IsSettingsPaneVisibleFunc = Nothing
        AgentRibbon.ToggleSettingsPaneAction = Nothing

        If _settingsTaskPane IsNot Nothing Then
            RemoveHandler _settingsTaskPane.VisibleChanged, AddressOf SettingsPane_VisibleChanged
            _settingsTaskPane = Nothing
        End If

        If _agentForm IsNot Nothing Then
            _agentForm.HideAgent(checkOtherApps:=True)
            _agentForm.Dispose()
            _agentForm = Nothing
        End If
    End Sub

End Class
