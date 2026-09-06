Imports System.Linq

' 検索エンジンの一覧（表示名・検索語より前のURL・検索語より後のURL）。
' ユーザーが設定タスクパネルで編集した内容（AgentSettings.SearchEngineListText）があればそれを、
' 無ければ下記の既定値を使用する。
Public Module SearchEngines

    ' {名前, URL(検索語より前), URL(検索語より後)}
    Private ReadOnly DefaultEntries(,) As String = New String(,) {
        {"Google", "https://www.google.com/search?q=", ""},
        {"Yahoo!", "https://search.yahoo.co.jp/search?p=", ""},
        {"YouTube", "https://www.youtube.com/search?q=", ""},
        {"ニコニコ動画", "https://www.nicovideo.jp/search/", ""},
        {"X (Twitter)", "https://x.com/search?q=", ""},
        {"Googleマップ", "https://www.google.com/maps/search/", ""},
        {"Amazon", "https://www.amazon.co.jp/s?k=", ""},
        {"楽天市場", "https://search.rakuten.co.jp/search/mall/", ""},
        {"ヤフオク！", "https://auctions.yahoo.co.jp/search/search?p=", ""},
        {"メルカリ", "https://www.mercari.com/jp/search/?keyword=", ""},
        {"Wikipedia", "https://ja.wikipedia.org/wiki/", ""}}

    ' 設定タスクパネルの初期表示・初回起動時のレジストリ初期値に使う既定テキスト
    Public ReadOnly Property DefaultText As String
        Get
            Return ToText(DefaultEntries)
        End Get
    End Property

    ' 現在有効な検索エンジン一覧。ユーザー設定を解析できればそれを、できなければ既定値を返す
    Public ReadOnly Property List As String(,)
        Get
            Dim parsed = ParseText(AgentSettings.SearchEngineListText)
            Return If(parsed, DefaultEntries)
        End Get
    End Property

    ' {名前, URL前, URL後} の2次元配列を「名前|URL前|URL後」形式・1行1件のテキストへ変換する
    Public Function ToText(entries As String(,)) As String
        Dim sb As New Text.StringBuilder()
        For i = 0 To entries.GetLength(0) - 1
            sb.AppendLine($"{entries(i, 0)}|{entries(i, 1)}|{entries(i, 2)}")
        Next
        Return sb.ToString().TrimEnd()
    End Function

    ' 「名前|URL前|URL後」形式・1行1件のテキストを{名前, URL前, URL後}の2次元配列へ変換する。
    ' 旧形式「名前=URL」（URL後が無い版）も読み取れる。
    ' 不正な行（名前かURL前が空）は読み飛ばす。有効な行が1件も無ければNothingを返す
    Public Function ParseText(text As String) As String(,)
        If String.IsNullOrWhiteSpace(text) Then Return Nothing

        Dim rows As New Collections.Generic.List(Of String())()
        For Each line In text.Replace(vbCr, "").Split(vbLf)
            Dim trimmed = line.Trim()
            If trimmed.Length = 0 Then Continue For

            Dim name As String, prefix As String, suffix As String
            If trimmed.Contains("|"c) Then
                Dim parts = trimmed.Split("|"c)
                name = parts(0).Trim()
                prefix = If(parts.Length > 1, parts(1).Trim(), "")
                suffix = If(parts.Length > 2, String.Join("|", parts.Skip(2)).Trim(), "")
            Else
                ' 旧形式「名前=URL」との互換
                Dim idx = trimmed.IndexOf("="c)
                If idx <= 0 Then Continue For
                name = trimmed.Substring(0, idx).Trim()
                prefix = trimmed.Substring(idx + 1).Trim()
                suffix = ""
            End If
            If name.Length = 0 OrElse prefix.Length = 0 Then Continue For

            rows.Add({name, prefix, suffix})
        Next

        If rows.Count = 0 Then Return Nothing

        Dim result(rows.Count - 1, 2) As String
        For i = 0 To rows.Count - 1
            result(i, 0) = rows(i)(0)
            result(i, 1) = rows(i)(1)
            result(i, 2) = rows(i)(2)
        Next
        Return result
    End Function

End Module
