Imports System.Linq

' 探索パス上に存在する.acsファイルを検出し、キャラクター選択リストの候補として提供する。
' カイル(DOLPHIN.ACS)以外の.acsが見つかった場合（フィンフィンを含む）も、
' キャラクターIDとしてファイル名（拡張子除く・大文字化）をそのまま使い、汎用設定で動作させる。
Public Module AgentCharacterCatalog

    ' キャラクターファイルの形式。Acs = Microsoft Agent（AxAgent、従来のカイル等）、
    ' Act = Microsoft Actor（FrontierActorControl経由、ROVER.ACT等の.actファイル）
    Public Enum CharacterFormat
        Acs
        Act
    End Enum

    Public Structure CharacterInfo
        Public Id As String
        Public DisplayName As String
        Public AcsPath As String
        Public Format As CharacterFormat
    End Structure

    ' 既知キャラクターの表示名。ここに無いIDは、ファイル名（拡張子を除いたもの）をそのまま表示名として使う
    Private ReadOnly KnownDisplayNames As New Dictionary(Of String, String)(StringComparer.OrdinalIgnoreCase) From {
        {"DOLPHIN", "カイル"}
    }

    Public Function DisplayNameFor(id As String) As String
        Dim name As String = Nothing
        If KnownDisplayNames.TryGetValue(id, name) Then Return name
        Return id
    End Function

    ' TryReadCharacterProfile（.acsを実際に読み込んでName/Description、.actはさらに
    ' CharacterAnimationCountも取得する）の結果をキャッシュする。一度読み込んだファイルは、
    ' パスが変わらない限りアプリ実行中は再読み込みしない
    Private ReadOnly _liveProfileCache As New Dictionary(Of String, (Name As String, Description As String, ActionCount As Integer))(StringComparer.OrdinalIgnoreCase)

    ' 実際にファイルを一度読み込んで、埋め込まれたName/Descriptionプロパティ（.actは加えて
    ' CharacterAnimationCount）を取得する（重いためDiscoverCharacters()では行わず、実際に
    ' 必要になった場面でのみ呼ぶ）。.acsはAgentFloatingForm（AxAgent）経由、.actは
    ' ActorFloatingForm（FrontierActorControl）経由と、形式によって読み込み方法が異なる。
    ' 読み込みに失敗した場合はName/DescriptionがNothing、ActionCountが0になる
    Private Function ResolveLiveProfile(info As CharacterInfo) As (Name As String, Description As String, ActionCount As Integer)
        Dim cached As (Name As String, Description As String, ActionCount As Integer) = Nothing
        If _liveProfileCache.TryGetValue(info.AcsPath, cached) Then Return cached

        Dim resolved As (Name As String, Description As String, ActionCount As Integer)
        If info.Format = CharacterFormat.Act Then
            resolved = ActorFloatingForm.TryReadCharacterProfile(info.AcsPath)
        Else
            Dim profile = AgentFloatingForm.Instance?.TryReadCharacterProfile(info.AcsPath)
            resolved = If(profile.HasValue, (profile.Value.Name, profile.Value.Description, 0), (CStr(Nothing), CStr(Nothing), 0))
        End If
        _liveProfileCache(info.AcsPath) = resolved
        Return resolved
    End Function

    ' キャラクター選択リストの表示名を解決する。実際のNameが取れなければ
    ' DiscoverCharactersが設定したフォールバック名（既知の表示名テーブル、それも無ければ
    ' 拡張子を除いたファイル名）を使う
    Public Function ResolveLiveDisplayName(info As CharacterInfo) As String
        Dim profile = ResolveLiveProfile(info)
        Return If(Not String.IsNullOrWhiteSpace(profile.Name), profile.Name, info.DisplayName)
    End Function

    ' キャラクターの紹介文（Description）を取得する。ACS側に無い場合はNothingを返す
    ' （Descriptionは任意項目のため、Nameと違ってフォールバック文言は用意しない）
    Public Function ResolveLiveDescription(info As CharacterInfo) As String
        Return ResolveLiveProfile(info).Description
    End Function

    ' IDだけからパスを引く簡易版。CharacterInfoを持っていない呼び出し元（GPTルール文の生成など）から使う
    Private Function Find(id As String) As CharacterInfo
        Return DiscoverCharacters().FirstOrDefault(Function(c) String.Equals(c.Id, id, StringComparison.OrdinalIgnoreCase))
    End Function

    Public Function ResolveLiveDisplayName(id As String) As String
        Dim found = Find(id)
        If found.AcsPath Is Nothing Then Return DisplayNameFor(id)
        Return ResolveLiveDisplayName(found)
    End Function

    Public Function ResolveLiveDescription(id As String) As String
        Dim found = Find(id)
        If found.AcsPath Is Nothing Then Return Nothing
        Return ResolveLiveDescription(found)
    End Function

    ' .actキャラクターの収録アクション数（PlayAction(0～N-1)で指定できる範囲）を取得する。
    ' .acs（名前ベースのMicrosoft Agentアニメーション）には無い概念のため0を返す。
    ' 設定タスクパネルの「アニメーション設定」グリッドが、.act選択時に選択肢一覧を
    ' 組み立てるために使う
    Public Function ResolveLiveActionCount(id As String) As Integer
        Dim found = Find(id)
        If found.AcsPath Is Nothing OrElse found.Format <> CharacterFormat.Act Then Return 0
        Return ResolveLiveProfile(found).ActionCount
    End Function

    ' 指定IDのキャラクターファイル形式を返す。見つからない場合はAcs扱い
    ' （リボンの表示/終了ボタンが、AgentFloatingForm/ActorFloatingFormのどちらを
    ' 操作すべきか判断するために使う）
    Public Function GetFormat(id As String) As CharacterFormat
        Dim found = Find(id)
        If found.AcsPath Is Nothing Then Return CharacterFormat.Acs
        Return found.Format
    End Function

    ' .acsの探索候補フォルダ。アプリに同梱されたフォルダ（インストール先の"agents"フォルダ等）を
    ' 優先し、最後にOS標準の msagent\chars を見る（Genie/Merlin/Robbyなど旧MS Agent標準キャラクターが
    ' 残っている環境向け）。ResolveAcsPath（AgentFloatingForm）と揃えた候補リスト
    Private Function CandidateDirs() As List(Of String)
        Dim assemblyDir = IO.Path.GetDirectoryName(GetType(AgentCharacterCatalog).Assembly.Location)
        Dim appBaseDir = AppDomain.CurrentDomain.BaseDirectory.TrimEnd(IO.Path.DirectorySeparatorChar)
        Dim windowsDir As String = Nothing
        Try
            windowsDir = Environment.GetFolderPath(Environment.SpecialFolder.Windows)
        Catch
        End Try

        Dim dirs As New List(Of String) From {
            assemblyDir,
            IO.Path.Combine(If(assemblyDir, ""), "..\agents"),
            appBaseDir,
            IO.Path.Combine(If(appBaseDir, ""), "..\agents"),
            Environment.CurrentDirectory
        }
        If Not String.IsNullOrEmpty(windowsDir) Then
            dirs.Add(IO.Path.Combine(windowsDir, "msagent\chars"))
        End If
        Return dirs
    End Function

    ' 探索パス上の.acsを順番に読み込み、重複なく列挙する。
    ' 同じファイル名（大文字小文字区別なし）が複数の候補フォルダで見つかった場合は、
    ' 先に列挙したフォルダ（アプリ同梱側）を優先し、後から見つかったOS標準フォルダ側は無視する。
    ' カイルが見つかった場合はリストの先頭に並べ、それ以外（フィンフィンを含む）は見つかった順で続く。
    ' .act（Microsoft Actor）も同じ探索パスから列挙するが、.acsとは別エンジン（FrontierActorControl）
    ' で動かすため、同名の.acsが既にあってもIDを衝突させず別エントリとして残す（末尾に"_ACT"を付ける）
    Public Function DiscoverCharacters() As List(Of CharacterInfo)
        Dim result As New List(Of CharacterInfo)
        Dim seenAcsIds As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)
        Dim seenActIds As New HashSet(Of String)(StringComparer.OrdinalIgnoreCase)

        For Each folder In CandidateDirs()
            If String.IsNullOrEmpty(folder) OrElse Not IO.Directory.Exists(folder) Then Continue For

            Dim acsFiles As String()
            Try
                acsFiles = IO.Directory.GetFiles(folder, "*.acs")
            Catch
                Continue For
            End Try
            For Each path In acsFiles
                Dim id = IO.Path.GetFileNameWithoutExtension(path).ToUpperInvariant()
                If seenAcsIds.Contains(id) Then Continue For
                seenAcsIds.Add(id)
                result.Add(New CharacterInfo With {
                    .Id = id,
                    .DisplayName = DisplayNameFor(id),
                    .AcsPath = path,
                    .Format = CharacterFormat.Acs
                })
            Next

            Dim actFiles As String()
            Try
                actFiles = IO.Directory.GetFiles(folder, "*.act")
            Catch
                Continue For
            End Try
            For Each path In actFiles
                Dim baseId = IO.Path.GetFileNameWithoutExtension(path).ToUpperInvariant()
                If seenActIds.Contains(baseId) Then Continue For
                seenActIds.Add(baseId)
                Dim id = If(seenAcsIds.Contains(baseId), baseId & "_ACT", baseId)
                ' KnownDisplayNames（"DOLPHIN"→"カイル"等）は.acs版カイル専用の対応表であり、
                ' 同名の.actファイルは中身が別物（別キャラクター）である可能性があるため流用しない。
                ' フォールバック名は素直にファイル名（baseId）そのものにする
                result.Add(New CharacterInfo With {
                    .Id = id,
                    .DisplayName = baseId,
                    .AcsPath = path,
                    .Format = CharacterFormat.Act
                })
            Next
        Next

        Return result.OrderBy(Function(c) PriorityOf(c.Id)).ToList()
    End Function

    Private Function PriorityOf(id As String) As Integer
        If String.Equals(id, "DOLPHIN", StringComparison.OrdinalIgnoreCase) Then Return 0
        Return 1
    End Function

End Module
