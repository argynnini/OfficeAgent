@echo off

call color 0a

echo Microsoft Agent Core Components インストーラ for after Windows 8

openfiles > NUL 2>&1 
if not %ERRORLEVEL% == 0 (
  call color 4e
  echo 管理者権限で実行してください。
  powershell start-process \"%~f0\" -Verb runas
  goto exit
)

rem ファイル存在の確認
echo %~dp0msAgentCoreComponents.exe
if exist "%~dp0msAgentCoreComponents.exe" (
  echo msAgentCoreComponents.exe が見つかりました。
) else (
  echo msAgentCoreComponents.exe が見つかりません。
  goto :END1
)
if exist "%~dp0msAgentCoreComponentsJP.exe" (
  echo msAgentCoreComponentsJP.exe が見つかりました。
) else (
  echo msAgentCoreComponentsJP.exe が見つかりません。
  goto :END1
)
if exist "%~dp0streams.exe" (
  echo streams.exe が見つかりました。
) else (
  echo streams.exe が見つかりません。
  goto :END1
)
rem インストール処理
echo Microsoft Agent Core Components (msAgentCoreComponents.exe) のインストール中．．．
call "%~dp0msAgentCoreComponents.exe" /Q
echo Microsoft Agent Core Components Japanese (msAgentCoreComponentsJP.exe) のインストール中．．．
call "%~dp0msAgentCoreComponentsJP.exe" /Q

rem バージョンの確認
ver | find /i "Version 6.3." > nul
if %ERRORLEVEL% equ 0 (
  echo OS は "Windows 8.1" です。
  goto :BIT
)
ver | find /i "Version 10.0." > nul
if %ERRORLEVEL% equ 0 (
  echo OS は "Windows 10 / 11" です。
  goto :BIT
)
goto :END1

rem bit数の確認
:BIT
if "%PROCESSOR_ARCHITECTURE%" equ "x86" (
  echo OS は "x86" です。
  goto :x86
)
if "%PROCESSOR_ARCHITECTURE%" equ "AMD64" (
  echo OS は "x86-64" です。
  goto :x64
)
goto :END1

rem レジストリ設定
:x86
echo 修正ファイルのコピー中．．．
call xcopy "%~dp0x86\MSAgent" "C:\Windows\MSAgent" /S /R /Y /I /K /Q > nul
echo レジストリの設定中．．．
call regedit /s "%~dp0x86\MSAgent_x86.reg"
echo ZoneIDの削除中．．．．．．
call "%~dp0streams.exe" -s -d "C:\Windows\msagent"
call "%~dp0streams.exe" -s -d "C:\Windows\msagent\en-US" -nobanner
call "%~dp0streams.exe" -s -d "C:\Windows\msagent\intl" -nobanner
call "%~dp0streams.exe" -s -d "C:\Windows\msagent\chars" -nobanner
goto :END
:x64
echo 修正ファイルのコピー中．．．
echo "%~dp0x64\MSAgent C:\Windows\MSAgent"
call xcopy "%~dp0x64\MSAgent" "C:\Windows\MSAgent" /S /R /Y /I /K /Q > nul
call xcopy "%~dp0x64\MSAgent64" "C:\Windows\MSAgent64" /S /R /Y /I /K /Q > nul
echo レジストリの設定中．．．．．．
call regedit /s "%~dp0x64\MSAgent_x64.reg"
echo ZoneIDの削除中．．．．．．
call "%~dp0streams.exe" -s -d "C:\Windows\msagent"
call "%~dp0streams.exe" -s -d "C:\Windows\msagent\en-US" -nobanner
call "%~dp0streams.exe" -s -d "C:\Windows\msagent\intl" -nobanner
call "%~dp0streams.exe" -s -d "C:\Windows\msagent\chars" -nobanner
call "%~dp0streams.exe" -s -d "C:\Windows\MSAgent64" -nobanner
call "%~dp0streams.exe" -s -d "C:\Windows\MSAgent64\en-US" -nobanner
goto :END

:END
call color 17
echo ☆インストールが完了しました。☆
goto :DONE

:END1
call color 4e
echo ※インストールに失敗しました。※
goto :DONE

:DONE
pause
exit
