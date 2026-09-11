Imports OfficeAgent.Core

Partial Public Class ThisAddIn

    Private _agentForm As OfficeAgent.Core.AgentFloatingForm
    Private _settingsTaskPane As Microsoft.Office.Tools.CustomTaskPane

    ' 数式エラーとして検知する文字列（Excelはロケールに関わらずこの表記のまま）
    Private ReadOnly FormulaErrorTexts As String() = {"#DIV/0!", "#N/A", "#NAME?", "#NULL!", "#NUM!", "#REF!", "#VALUE!", "#SPILL!", "#CALC!", "#GETTING_DATA"}
    ' 変更セルが多すぎる（大量ペースト等）場合はエラー検知をスキップする
    Private Const MaxFormulaErrorCheckCells As Integer = 500
    ' 同じセルのエラーを連続で通知しないためのクールダウン（秒）
    Private Const FormulaErrorNotifyCooldownSeconds As Double = 30
    Private _lastFormulaErrorAddress As String
    Private _lastFormulaErrorNotifyTime As DateTime

    Protected Overrides Function CreateRibbonExtensibilityObject() As Microsoft.Office.Core.IRibbonExtensibility
        Return New AgentRibbon()
    End Function

    Private Sub ThisAddIn_Startup() Handles Me.Startup
        OfficeAgent.Core.AssemblyRedirectHelper.EnsureRegistered()

        _agentForm = New OfficeAgent.Core.AgentFloatingForm()

        ' _agentForm.Show()はフォームのハンドル未作成時に同期的にLoadイベントを発火させる。
        ' AgentFloatingForm_Load内で初回表示位置の計算にGetHostWindowHandleFuncを使うため、
        ' Show()より前に登録しておく必要がある（Show()の後だとLoad時点では常に未登録
        ' 扱いになり、初回表示位置がプライマリモニタ基準にフォールバックしてしまう）
        OfficeAgent.Core.AgentFloatingForm.OpenSettingsPaneAction = AddressOf ShowSettingsPane
        OfficeAgent.Core.AgentFloatingForm.GetSelectedTextAction = AddressOf GetSelectedText
        AgentRibbon.IsSettingsPaneVisibleFunc = Function() IsSettingsPaneVisible
        AgentRibbon.ToggleSettingsPaneAction = AddressOf ToggleSettingsPane
        OfficeAgent.Core.AgentFloatingForm.GetHostWindowHandleFunc = AddressOf GetHostWindowHandle

        _agentForm.Show()

        AddHandler Me.Application.WorkbookBeforeSave, AddressOf OnBeforeSave
        AddHandler Me.Application.WorkbookAfterSave, AddressOf OnAfterSave
        AddHandler Me.Application.WorkbookBeforePrint, AddressOf OnBeforePrint
        AddHandler Me.Application.NewWorkbook, AddressOf OnOpen
        AddHandler Me.Application.WorkbookOpen, AddressOf OnOpen
        AddHandler Me.Application.WorkbookBeforeClose, AddressOf OnBeforeClose
        AddHandler Me.Application.ProtectedViewWindowOpen, AddressOf OnProtectedViewWindowOpen
        AddHandler Me.Application.WorkbookNewSheet, AddressOf OnWorkbookNewSheet
        AddHandler Me.Application.SheetChange, AddressOf OnSheetChange
    End Sub

    ' 設定タスクパネル（AgentSettingsPane）はCustomTaskPanes.Addのコストが実測200～460msあり、
    ' 起動時には使わない機能のため、初めて「設定」が開かれるタイミングまで生成を遅延させる
    Private Function EnsureSettingsTaskPane() As Microsoft.Office.Tools.CustomTaskPane
        If _settingsTaskPane IsNot Nothing Then Return _settingsTaskPane
        Dim pane As New OfficeAgent.Core.AgentSettingsPane() With {.HostApp = AnimationEvents.HostApp.Excel}
        _settingsTaskPane = Me.CustomTaskPanes.Add(pane, "OfficeAgent 設定")
        _settingsTaskPane.Width = 260
        _settingsTaskPane.Visible = False
        AddHandler _settingsTaskPane.VisibleChanged, AddressOf SettingsPane_VisibleChanged
        Return _settingsTaskPane
    End Function

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
        Dim pane = EnsureSettingsTaskPane()
        Try
            If Not pane.Visible Then
                DirectCast(pane.Control, OfficeAgent.Core.AgentSettingsPane).LoadSettings()
                pane.Visible = True
            Else
                pane.Visible = False
            End If
        Catch ex As ObjectDisposedException
            _settingsTaskPane = Nothing
        End Try
    End Sub

    ' カイル右クリックの「設定」から呼ばれる：閉じていれば開くだけ（トグルしない）
    Public Sub ShowSettingsPane()
        Dim pane = EnsureSettingsTaskPane()
        Try
            DirectCast(pane.Control, OfficeAgent.Core.AgentSettingsPane).LoadSettings()
            pane.Visible = True
        Catch ex As ObjectDisposedException
            _settingsTaskPane = Nothing
        End Try
    End Sub

    Private Sub SettingsPane_VisibleChanged(sender As Object, e As EventArgs)
        AgentRibbon.Instance?.InvalidateRibbon()
    End Sub

    ' 選択範囲として渡す最大セル数（巨大な範囲選択時にAIへの送信量を抑えるため）
    Private Const MaxSelectedCells As Integer = 500

    ' AgentFloatingForm側のGetHostWindowHandleFuncから呼ばれる：エージェントの初回表示位置を
    ' 「Officeウィンドウがあるモニタ」基準にするため、Excelのメインウィンドウハンドルを返す
    Private Function GetHostWindowHandle() As IntPtr
        Try
            Return New IntPtr(Me.Application.Hwnd)
        Catch ex As Exception
            Return IntPtr.Zero
        End Try
    End Function

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

    ' 変更されたセルに数式エラー（#REF!等）が含まれていたら通知する。
    ' 大量ペースト時の負荷、同一セルへの通知連発を避けるため件数上限とクールダウンを設ける
    Private Sub OnSheetChange(sh As Object, target As Microsoft.Office.Interop.Excel.Range)
        Try
            If target.Cells.Count > MaxFormulaErrorCheckCells Then Return

            Dim errorCell As Microsoft.Office.Interop.Excel.Range = Nothing
            For Each cell As Microsoft.Office.Interop.Excel.Range In target.Cells
                If Array.IndexOf(FormulaErrorTexts, cell.Text.ToString()) >= 0 Then
                    errorCell = cell
                    Exit For
                End If
            Next
            If errorCell Is Nothing Then Return

            Dim address = errorCell.Address(False, False)
            If address = _lastFormulaErrorAddress AndAlso (DateTime.Now - _lastFormulaErrorNotifyTime).TotalSeconds < FormulaErrorNotifyCooldownSeconds Then Return

            _lastFormulaErrorAddress = address
            _lastFormulaErrorNotifyTime = DateTime.Now
            If _agentForm IsNot Nothing Then _agentForm.PlayConfiguredAnimation("FormulaError")
        Catch ex As Exception
            ' セル操作中の一時的なCOM例外等は無視する
        End Try
    End Sub

    Private Sub ThisAddIn_Shutdown() Handles Me.Shutdown
        OfficeAgent.Core.AgentFloatingForm.OpenSettingsPaneAction = Nothing
        OfficeAgent.Core.AgentFloatingForm.GetSelectedTextAction = Nothing
        AgentRibbon.IsSettingsPaneVisibleFunc = Nothing
        AgentRibbon.ToggleSettingsPaneAction = Nothing
        OfficeAgent.Core.AgentFloatingForm.GetHostWindowHandleFunc = Nothing

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
