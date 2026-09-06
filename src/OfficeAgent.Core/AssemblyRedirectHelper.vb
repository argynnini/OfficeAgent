' VSTOの vstolocal 配置では、アドインDLL自身の.config（アセンブリバインディングリダイレクト）が
' 適用されないことがある（WordのAppDomainがアドインの.configではなくWord本体側の設定探索に
' フォールバックしてしまうため）。この場合、NuGetパッケージ間で要求バージョンが食い違う
' 依存アセンブリ（System.Runtime.CompilerServices.Unsafe等）の読み込みに失敗する。
'
' そのため、.configのリダイレクトに頼らず、要求されたバージョンに関わらず「同じフォルダに
' 実際に置いてあるДLL」を読み込ませるAssemblyResolveハンドラを各ThisAddIn_Startupの
' 冒頭で登録する。
Public Module AssemblyRedirectHelper

    Private _registered As Boolean = False

    Public Sub EnsureRegistered()
        If _registered Then Return
        _registered = True
        AddHandler AppDomain.CurrentDomain.AssemblyResolve, AddressOf ResolveAssembly
    End Sub

    Private Function ResolveAssembly(sender As Object, args As ResolveEventArgs) As Reflection.Assembly
        Try
            Dim requestedName = New Reflection.AssemblyName(args.Name).Name
            ' Assembly.Locationはシャドウコピーキャッシュ（%LOCALAPPDATA%\assembly\dl3\...）を指すことがある
            ' （VSTOのvstolocalロードではこれが常に発生する）ため、実際のインストール先を指す
            ' CodeBase（元の場所を示すURI）から求める
            Dim codeBase = GetType(AssemblyRedirectHelper).Assembly.CodeBase
            Dim assemblyDir = IO.Path.GetDirectoryName(New Uri(codeBase).LocalPath)
            Dim candidatePath = IO.Path.Combine(assemblyDir, requestedName & ".dll")
            If IO.File.Exists(candidatePath) Then
                Return Reflection.Assembly.LoadFrom(candidatePath)
            End If
        Catch ex As Exception
            ' 解決失敗はホストの標準的なアセンブリ解決に委ねる（Nothingを返す）
        End Try
        Return Nothing
    End Function

End Module
