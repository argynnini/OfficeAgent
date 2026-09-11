' 調査用の一時的なファイルログ。吹き出しの高さ計算（EstimateDisplayWidth／ApplyAutoBalloonHeight）
' の妥当性を実機で確認するため、計算過程をログに残す。原因特定後は削除する
Public Module DebugLog
    Private ReadOnly LogPath As String = IO.Path.Combine(IO.Path.GetTempPath(), "OfficeAgent_debug.log")

    Public Sub Write(message As String)
        Try
            IO.File.AppendAllText(LogPath, $"[{DateTime.Now:HH:mm:ss.fff}] {message}{Environment.NewLine}")
        Catch
        End Try
    End Sub
End Module
