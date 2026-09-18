Imports System.Reflection

' OfficeAgent.Core / OfficeAgent.Word.AddIn / OfficeAgent.Excel.AddIn / OfficeAgent.PowerPoint.AddIn の
' 4プロジェクトで共有するアセンブリバージョン。各プロジェクトの vbproj からリンク参照されており、
' バージョンを上げる際はここ1箇所を編集すればよい。
' インストーラのバージョン（installer\wix\Version.props）とは別管理。
<Assembly: AssemblyVersion("3.2.0.0")>
<Assembly: AssemblyFileVersion("3.2.0.0")>
