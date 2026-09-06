Imports System.Drawing
Imports System.Runtime.InteropServices

Public Module WindowHelper

    <DllImport("user32.dll")>
    Private Function GetWindowRect(hWnd As IntPtr, ByRef rect As RECT) As Boolean
    End Function

    Private Structure RECT
        Public Left As Integer
        Public Top As Integer
        Public Right As Integer
        Public Bottom As Integer
    End Structure

    ' 指定ウィンドウの画面上の矩形（ピクセル）を取得する。
    ' 取得に失敗した場合はNullを返す。
    Public Function GetWindowBounds(hWnd As IntPtr) As Rectangle?
        If hWnd = IntPtr.Zero Then Return Nothing
        Dim rect As RECT = Nothing
        If Not GetWindowRect(hWnd, rect) Then Return Nothing
        Return Rectangle.FromLTRB(rect.Left, rect.Top, rect.Right, rect.Bottom)
    End Function

    ' Word/Excel/PowerPointのDocument/Workbook/Presentationが持つ「AutoSaveOn」プロパティ
    ' （OneDrive/SharePoint上のファイルのクラウド自動保存）は、このプロジェクトが参照している
    ' Office 2013世代のPIAには存在しないため、リフレクションではなく遅延バインディングで確認する。
    ' プロパティが無いホストバージョンでは例外を握りつぶしFalse（＝自動保存ではない扱い）とする。
    Public Function IsAutoSaveOn(target As Object) As Boolean
        If target Is Nothing Then Return False
        Try
            Return CBool(Microsoft.VisualBasic.Interaction.CallByName(target, "AutoSaveOn", CallType.Get))
        Catch
            Return False
        End Try
    End Function

End Module
