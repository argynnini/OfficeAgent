Imports System.Windows.Forms

' AxAgent（MS AgentのActiveXコントロール本体、AgentObjects.dll経由でCLSIDから生成）が
' 未インストール・破損している環境では、AgentFloatingForm生成時（AxHost.CreateInstance→
' CoCreateInstance）がERROR_MOD_NOT_FOUND（HRESULT 0x8007007E）のFileNotFoundExceptionを
' 投げ、ThisAddIn_Startupがそこで止まってしまう（実機で確認）。
'
' MSAgentランタイム本体はOfficeAgentAddins.msiとは別チェーンの MSAgentRuntime.msi
' （installer\wix\MSAgentRuntime.wxs）として配布されているため、ここではCOMコンポーネント
' 未登録を検知したら、クラッシュさせる代わりにインストールを促すメッセージを表示する
' （実際のインストール操作（管理者権限が要る）はユーザー自身に行ってもらう）
Public Module MsAgentRuntimeRecovery

    ' 「指定されたモジュールが見つかりません」(ERROR_MOD_NOT_FOUND)をHRESULT化した値。
    ' AxHost.CreateWithLicenseがCOMコンポーネント未登録時に投げるFileNotFoundExceptionのHResult
    Private Const HResultModuleNotFound As Integer = -2147024770 ' &H8007007E

    ' 例外がMSAgentランタイム未登録（AxAgent生成失敗）によるものかどうかを判定する。
    ' Catch ... When句から呼ぶ想定（他の予期しない例外はここで握りつぶさず素通りさせる）
    Public Function IsMsAgentRuntimeMissing(ex As Exception) As Boolean
        Dim current = ex
        While current IsNot Nothing
            If TypeOf current Is IO.FileNotFoundException AndAlso current.HResult = HResultModuleNotFound Then
                Return True
            End If
            current = current.InnerException
        End While
        Return False
    End Function

    ' MSAgentランタイム未登録を検知した際の案内（Catch節から呼ぶ）。
    ' 環境（正規インストール／ソースからのビルド実行）を判定せず、常に同じメッセージで
    ' 両方のインストール手段を案内する
    Public Sub HandleMissingRuntime()
        MessageBox.Show(
            "キャラクター表示に必要な「MS Agentランタイム」が見つかりません。" & Environment.NewLine &
            "OfficeAgentのセットアップ（OfficeAgentSetup.exe）を実行し直してインストールしてください。" & Environment.NewLine &
            "ソースからビルドして実行している場合は、installerフォルダのMSAgentRuntime.msiを" &
            "インストールしてください。",
            "OfficeAgent", MessageBoxButtons.OK, MessageBoxIcon.Warning)
    End Sub

End Module
