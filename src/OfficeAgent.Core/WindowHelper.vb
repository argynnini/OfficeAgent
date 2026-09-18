Public Module WindowHelper

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
